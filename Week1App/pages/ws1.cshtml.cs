﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week1App.pages
{
    public class ws1Model : PageModel
    {
        
        public void OnGet()
        {

        }

        public string Message { get; set; } = "";

        public string[] MyTestArray { get; set; } 
            = {"England", "Ireland", "Scotland", "Wales"};

        public void OnPost(string FirstName)
        {
            Message = $"Hello {FirstName}"; 

        }
    }
}