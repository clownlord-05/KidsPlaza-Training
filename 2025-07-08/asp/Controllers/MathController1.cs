using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class MathController1 : Controller
    {
        public IActionResult sum(int x , int y )
        {
            return Content((x+y).ToString());
        }   
    }
}
