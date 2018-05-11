using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data.Models;
using SimpleImageGallery.Models;

namespace SimpleImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTag = new List<ImageTag>();
            var cityImageTag = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };

            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };

            var tag3 = new ImageTag()
            {
                Description = "New york",
                Id = 2
            };

            hikingImageTag.Add(tag1);
            cityImageTag.AddRange(new List<ImageTag> { tag2, tag3 });

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://images.pexels.com/photos/771079/pexels-photo-771079.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTag
                },
                new GalleryImage()
                {
                    Title = "On the Trail",
                    Url = "https://images.pexels.com/photos/868097/pexels-photo-868097.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTag
                },
                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://images.pexels.com/photos/378570/pexels-photo-378570.jpeg",
                    Created = DateTime.Now,
                    Tags = cityImageTag
                }
            };

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}