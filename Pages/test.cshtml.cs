using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_1001_Test.Pages
{
    public class testModel : PageModel
    {
        public void OnGet()
        {
            if(firstNumber>0 && secondNumber > 0)
            {
                Result = firstNumber*secondNumber;
                ResultSet = true;
            }
        }
        [FromQuery(Name = "firstNumber")]
        public int firstNumber { get; set; }

        [FromQuery(Name = "secondNumber")]
        public int secondNumber { get; set; }

        public int Result { get; set; }

        public bool ResultSet { get; set; }
    }
}