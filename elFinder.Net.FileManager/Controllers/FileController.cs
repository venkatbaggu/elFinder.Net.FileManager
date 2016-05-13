using ElFinder;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace elFinder.Net.FileManager.Controllers
{
    public class FilesController : Controller
    {
        private Connector _connector;

        public Connector Connector
        {
            get
            {
                if (_connector == null)
                {
                    FileSystemDriver driver = new FileSystemDriver();
                    DirectoryInfo thumbsStorage = new DirectoryInfo(Server.MapPath("~/images"));

                    driver.AddRoot(new Root(new DirectoryInfo(Server.MapPath("~/images")), "http://" + Request.Url.Authority + "/images/")
                    {
                        Alias = "Website Contents",
                        IsReadOnly = false,
                        LockedFolders = new List<string>(new string[] { "images" }),
                        ThumbnailsStorage = thumbsStorage,
                        MaxUploadSizeInMb = 5.0,
                        ThumbnailsUrl = "/Thumbnails/"
                    });
                    _connector = new Connector(driver);
                }
                return _connector;
            }
        }
        public ActionResult Index()
        {
            return Connector.Process(this.HttpContext.Request);
        }

        public ActionResult SelectFile(string target)
        {
            return Json(Connector.GetFileByHash(target).FullName);
        }

        public ActionResult Thumbs(string tmb)
        {
            return Connector.GetThumbnail(Request, Response, tmb);
        }
    }
}