using ImageShare.Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageShare.Web.Controllers
{
    public class ImageController : Controller
    {
        private IImageManager imageManager { get; set; }

        public ImageController(IImageManager imageManager)
        {
        }

        // GET: Image
        public ActionResult Index()
        {
            var images = imageManager.GetPagedImages(
                new Logic.RequestModels.PagedRequest
                {
                    Page = 0,
                    PageSize = 100,
                    Requestor = "",
                    SortBy = Logic.RequestModels.SortBy.Created
                }
            );

            return View(images);
        }

        public ActionResult Index(string uri)
        {
            var image = imageManager.GetImageByURI(uri);

            return View(image);
        }
    }
}