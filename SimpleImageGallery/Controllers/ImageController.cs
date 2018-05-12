using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Models;

namespace SimpleImageGallery.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Upload()
        {
            var model = new UploadImageModel();

            return View();
        }

        [HttpPost]
        public IActionResult UploadNewImage()
        {
            return Ok();
        }
    }
}