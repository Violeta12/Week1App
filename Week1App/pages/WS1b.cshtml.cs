using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week1App.pages
{
    public class WS1bModel : PageModel
    {
        public void OnGet()
        {

        }

        public string Message1 { get; set; } = "";

        public string Message2 { get; set; } = "";

        public void OnPost(int number1, int number2, string operation)
        {
           
            Message1 = $"The sum of {number1} and {number2} is {number1 + number2}";

            switch (operation) {
                case "plus":
                    Message2 =$"The sum of {number1} and {number2} is {number1 + number2}";
                    break;
                case "minus":
                    Message2 = $"The subtraction of {number1} and {number2} is {number1 - number2}";
                    break;
                case "multiply":
                    Message2 = $"The product of {number1} and {number2} is {number1 * number2}";
                    break;
                case "divide":
                    Message2 = $"The division of {number1} and {number2} is {number1 / number2}";
                    break;
            }
            
        }
    }
}