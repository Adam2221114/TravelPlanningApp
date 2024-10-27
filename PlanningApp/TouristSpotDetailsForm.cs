using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class TouristSpotDetailsForm : Form
    {
        private readonly AppDbContext _context;  // 数据库上下文
        private readonly TouristSpot _touristSpot;
        private bool isLiked = false;  // 用于跟踪是否已点赞
        private string apiUrl = "https://api.weatherbit.io/v2.0/current?key=86fb8e3c32814f16bc290d3f2b653191";
        // 构造函数接收数据库上下文和景点信息
        public TouristSpotDetailsForm(AppDbContext context, TouristSpot touristSpot)
        {
            FetchWeatherDataAsync();
            _context = context;  // 初始化数据库上下文
            _touristSpot = touristSpot;  // 初始化景点
            InitializeComponent();
            LoadTouristSpotDetails();
        }
        private async Task FetchWeatherDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Make the API request and get the response
                    HttpResponseMessage response = await client.GetAsync(apiUrl + "&country=AU&city=Sydney");

                    // Ensure the request was successful
                    response.EnsureSuccessStatusCode();

                    // Read the response content as a string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse JSON manually using JsonDocument
                    using (JsonDocument jsonDoc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = jsonDoc.RootElement;

                        // Access the first object in the "data" array
                        JsonElement data = root.GetProperty("data")[0];

                        // Extract app_temp and weather.description
                        double appTemp = data.GetProperty("app_temp").GetDouble();
                        string weatherDescription = data.GetProperty("weather").GetProperty("description").GetString();

                        weatherLabel.Text = appTemp + "C " + weatherDescription;
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Request error: " + e.Message);
                }
            }
        }

        // 加载景点详细信息
        private void LoadTouristSpotDetails()
        {
            lblName.Text = _touristSpot.Name;
            lblLocation.Text = $"Location: {_touristSpot.Location}";
            lblRating.Text = $"Rating: {_touristSpot.Rating}/5";
            lblDescription.Text = _touristSpot.Description;

            // 加载图片
            if (!string.IsNullOrEmpty(_touristSpot.ImagePath) && System.IO.File.Exists(_touristSpot.ImagePath))
            {
                pictureBox.Image = Image.FromFile(_touristSpot.ImagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // 设置为Zoom，确保图片不变形
            }

            // 检查用户是否已收藏该景点
            if (UserSession.Instance.CurrentUser is Customer customer)
            {
                var favoriteList = customer.Favorites?.Split(',').ToList() ?? new List<string>();
                isLiked = favoriteList.Contains(_touristSpot.Id.ToString());
                button1.Text = isLiked ? "❤️ Unlike" : "❤️ Like";
            }
        }

        // 收藏/取消收藏按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            // 检查用户是否已登录
            if (UserSession.Instance.CurrentUser is Customer customer)
            {
                // 获取用户收藏的景点ID列表
                var favoriteList = customer.Favorites?.Split(',').ToList() ?? new List<string>();

                if (!isLiked)
                {
                    // 如果没有收藏，添加景点ID到收藏夹
                    if (!favoriteList.Contains(_touristSpot.Id.ToString()))
                    {
                        favoriteList.Add(_touristSpot.Id.ToString());
                        customer.Favorites = string.Join(",", favoriteList);

                        // 更新景点的 PopularityCount
                        var touristSpot = _context.TouristSpots.Find(_touristSpot.Id);
                        if (touristSpot != null)
                        {
                            touristSpot.PopularityCount += 1; // 增加受欢迎程度
                        }

                        // 保存更改到数据库
                        _context.Entry(customer).State = EntityState.Modified;
                        _context.SaveChanges();

                        button1.Text = "❤️ Unlike";
                        isLiked = true;
                    }
                }
                else
                {
                    // 如果已经收藏，取消收藏
                    if (favoriteList.Contains(_touristSpot.Id.ToString()))
                    {
                        favoriteList.Remove(_touristSpot.Id.ToString());
                        customer.Favorites = string.Join(",", favoriteList);

                        // 更新景点的 PopularityCount
                        var touristSpot = _context.TouristSpots.Find(_touristSpot.Id);
                        if (touristSpot != null)
                        {
                            touristSpot.PopularityCount -= 1; // 减少受欢迎程度
                        }

                        // 保存更改到数据库
                        _context.Entry(customer).State = EntityState.Modified;
                        _context.SaveChanges();

                        button1.Text = "❤️ Like";
                        isLiked = false;
                    }
                }
            }
            else
            {
                // 用户未登录，提示要求登录
                MessageBox.Show("Please log in to save this attraction！");
            }
        }

    }
}
