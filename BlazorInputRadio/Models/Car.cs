using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorInputRadio.Models
{
    public class Car
    {
        [Required, EnumDataType(typeof(Color))]
        public Color? Color { get; set; } = null;
        [Required, EnumDataType(typeof(Model))] 
        public Model? Model { get; set; } = null;
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
