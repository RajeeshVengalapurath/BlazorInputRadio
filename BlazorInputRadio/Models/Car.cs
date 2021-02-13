using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorInputRadio.Models
{
    public class Car
    {
        [Required]
        public Color Color { get; set; }// = Color.Black;
        [Required]
        public Model Model { get; set; } = Model.Model1;
    }
    public enum Color
    {
        Red, Black, White
    }
    public enum Model
    {
        Model1, Model2, Model3
    }
}
