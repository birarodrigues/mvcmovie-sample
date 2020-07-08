using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        #region  part-2-add-controller-only-html
        // // GET: /HelloWorld/
        // public string Index()
        // {
        //     return "This is my default action...";
        // }

        // // GET: /HelloWorld/Welcome/ 
        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }

        // // GET: /HelloWorld/Welcome/ 
        // public string Welcome(string name, int ID = 1)
        // {
        //     //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }
        #endregion

        #region  part-3-add-view
        public IActionResult Index()
        {
            return View();
        }

        //https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        #endregion
    }

}
