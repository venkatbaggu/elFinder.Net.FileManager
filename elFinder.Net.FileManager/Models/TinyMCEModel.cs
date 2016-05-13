using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace elFinder.Net.FileManager.Models
{
    public class TinyMCEModel
    {
        [AllowHtml]
        [UIHint("tinymce_full")]
        public string Content { get; set; }
    }
}