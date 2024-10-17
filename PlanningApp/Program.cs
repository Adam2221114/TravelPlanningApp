using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace PlanningApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=localdatabase.db");
            var context = new AppDbContext(optionsBuilder.Options);

            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage(context)); // 使用 HomePage 作为启动表单
        }
    }
}







