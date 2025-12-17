using System.Drawing;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace Raicu_Eva_Lab1.Controllers
{
    public class probaController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}