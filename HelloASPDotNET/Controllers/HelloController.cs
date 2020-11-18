using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hello_aspdotnet.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='english' selected>English</option>" +
                "<option value='french'>French</french>" +
                "<option value='german'>German</option>" +
                "<option value='Spanish'>spanish</option>" +
                "<option value='swahili'>Swahili</option></select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");

        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string language = "english")
        {
            return Content(CreateMessage(name, language));

        }

        public static string CreateMessage(string name, string language)
        {
            string helloTranslation = "";
            switch (language)
            {
                case "french":
                    helloTranslation = "Bonjour ";
                    break;
                case "spanish":
                    helloTranslation = "Hola ";
                    break;
                case "german":
                    helloTranslation = "Guten tag ";
                    break;
                case "swahili":
                    helloTranslation = "Jambo ";
                    break;
                case "english":
                    helloTranslation = "Hello ";
                    break;
            }
            return helloTranslation + name;



        }


    }
}