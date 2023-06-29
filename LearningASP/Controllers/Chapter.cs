using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LearningASP.Controllers
{
    public class Chapter : Controller
    {
        // 
        // GET: /Chapter/
        public IActionResult Index()
        {
            return View();
            //return "This is my default action...";
        }

        // 
        // GET: /Chapter/Welcome?name=YourName&rank=YourRank
        public IActionResult Welcome(string name, string rank)
        {
            /*   return HtmlEncoder.Default.Encode(
                   $"Hello {name}, dear {rank}"
                );
            */

            @ViewData["Name"] = HtmlEncoder.Default.Encode(name);
            @ViewData["Rank"] = HtmlEncoder.Default.Encode(rank);
            return View(); //Need to specify a View with the same name as the function
        }

        // 
        // GET: /Chapter/Welcome/6?name=YourName
        // Where '6' is the id added as an argument
        public string WelcomeWithId(string name, int id)
        {
            return HtmlEncoder.Default.Encode(
                $"Hello {name}, your user id is: {id}"
            );
        }
    }
}
