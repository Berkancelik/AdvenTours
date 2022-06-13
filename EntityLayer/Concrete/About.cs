﻿
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public string Status { get; set; }

    }
}
