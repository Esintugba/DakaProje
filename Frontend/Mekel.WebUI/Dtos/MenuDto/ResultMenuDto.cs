﻿namespace Mekel.WebUI.Dtos.MenuDto
{
    public class ResultMenuDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}