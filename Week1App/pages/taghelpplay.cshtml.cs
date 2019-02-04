using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week1App.pages
{
    public class taghelpplayModel : PageModel
    {
        public void OnGet()
        {

        }

        public string Message1 { get; set; } = "";
        public string Message2 { get; set; } = "";
        public string Message3 { get; set; } = "";
        public string Message4 { get; set; } = "";
        public string Message5 { get; set; } = "";
        public string Message6 { get; set; } = "";
        public string Message7 { get; set; } = "";
        public string Message8 { get; set; } = "";
        public string Message9 { get; set; } = "";
        public string Message10 { get; set; } = "";
        public string Message11 { get; set; } = "";
        public string Message12 { get; set; } = "";
        

        [BindProperty]
        public int Number1 { get; set; }
        public int? Number2 { get; set; }
        public double Number3 { get; set; }
        public double? Number4 { get; set; }
        public decimal Number5 { get; set; }
        public decimal? Number6 { get; set; }
        public float Number7 { get; set; }
        public float? Number8 { get; set; }
        public string Number9 { get; set; }
        public DateTime Number10 { get; set; }
        public DateTime? Number11 { get; set; }
        public bool Number12 { get; set; }



        public string[] Season { get; set; }
            = { "Summer", "Autumn", "Winter", "Spring" };


        public void OnPost(int Number1, int? Number2, double Number3, double? Number4, decimal Number5,
            decimal? Number6, float Number7, float? Number8, string Number9, DateTime Number10, 
            DateTime? Number11, bool Number12)
        {
            Message1 = $"Number is {Number1}";
            Message2 = $"Number is {Number2}";
            Message3 = $"Number is {Number3}";
            Message4 = $"Number is {Number4}";
            Message5 = $"Number is {Number5}";
            Message6 = $"Number is {Number6}";
            Message7 = $"Number is {Number7}";
            Message8 = $"Number is {Number8}";
            Message9 = $"Number is {Number9}";
            Message10 = $"Number is {Number10}";
            Message11 = $"Number is {Number11}";
            Message12 = $"Value is {Number12}";
            

        }
    }
}