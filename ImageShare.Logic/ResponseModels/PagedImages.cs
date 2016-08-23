using ImageShare.Logic.ViewModels;
using System.Collections.Generic;

namespace ImageShare.Logic.ResponseModels
{
    public class PagedImages : PagedResponse
    {
        public ICollection<ImageViewModel> Images { get; set; }
    }
}
