using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    interface IMovieScraper
    {
        event EventHandler<OneCompleteEventArg> CompleteOneItem;
        System.Collections.Generic.List<ArtMovie> GetPicturePage(int page);
        System.Collections.Generic.List<ArtMovie> GetVideoPage(int page);
        System.Collections.Generic.List<ArtMovie> GetAllUpdate(int page);
        bool IsDownloadCoverPicture { get; set; }
        bool IsDownloadExtraPicture { get; set; }
        string DisplayName { get; set; }
    }
}
