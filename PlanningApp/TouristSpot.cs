using System.ComponentModel.DataAnnotations;

namespace PlanningApp
{
    public class TouristSpot
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string ImagePath { get; set; } // 图片路径

        [MaxLength(500)]
        public string Description { get; set; } // 景点描述

        [Required]
        [MaxLength(200)]
        public string Location { get; set; } // 景点位置

        [Range(0, 5)]
        public double Rating { get; set; } // 评分（0-5）

        public bool IsPopular { get; set; } // 是否为热门景点
    }
}



