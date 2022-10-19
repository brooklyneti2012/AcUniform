using System;
using System.ComponentModel.DataAnnotations;

namespace AcUniform.Models
{
    public class Junior
    {
        public int JuniorID { get; set; }
        public string? ClotheName { get; set; }
        public int Price { get; set; }
    }
}
