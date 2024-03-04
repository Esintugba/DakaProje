﻿using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.CategoryDto
{
    public class UpdateCategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public int CategoryId { get; set; }
    }
}