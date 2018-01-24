using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Firehose.Web.Authors
{
    public class MabroukMahdhi : IAmACommunityMember
    {
             public string EmailAddress => "mabrouk@mahdhi.com";

        public IEnumerable<Uri> FeedUris => new List<Uri>() { new Uri("https://www.xamabrouk.net/feed.xml") };


        public string FirstName => "Mabrouk";


        public string GitHubHandle => "MabroukENG";


        public string GravatarHash => "ed455d0dc5298d7ebb2941b76b76cd07";


        public string LastName => "Mahdhi";

        public GeoPosition Position => new GeoPosition(49.022821, 12.162714);

        public string ShortBioOrTagLine => ", is a .Net & Xamarin apps developer @Gefasoft-Engineering GmbH";


        public string StateOrRegion => "Regensburg, Bayern, Germany";


        public string TwitterHandle => "Mabrouk_MAHDHI";

        public Uri WebSite => new Uri("http://xamabrouk.net/");
    }
}
