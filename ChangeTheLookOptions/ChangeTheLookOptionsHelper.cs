using System;
using System.Net.Http;

namespace ChangeTheLookOptions
{
    public class ChangeTheLookOptionsHelper
    {
        internal static void ChangeHeaderLayout(string siteUrl, HeaderLayout layout, string userName, string password)
        {
            using (var client = new SPHttpClient(new Uri(siteUrl), userName, password))
            {
                var itemPayload = new { __metadata = new { type = "SP.Web" }, HeaderLayout = layout };
                var endpointUrl = string.Format("{0}/_api/web", siteUrl);
                var data = client.ExecuteJson(endpointUrl, HttpMethod.Post, itemPayload);
            }
        }

        internal static void ChangeHeaderBackground(string siteUrl, HeaderBackground background, string userName, string password)
        {
            using (var client = new SPHttpClient(new Uri(siteUrl), userName, password))
            {
                var itemPayload = new { __metadata = new { type = "SP.Web" }, HeaderEmphasis = background };
                var endpointUrl = string.Format("{0}/_api/web", siteUrl);
                var data = client.ExecuteJson(endpointUrl, HttpMethod.Post, itemPayload);
            }
        }

        internal static void ChangeMenuStyle(string siteUrl, MenuStyle menuStyle, string userName, string password)
        {
            bool megaMenuEnabled = menuStyle == MenuStyle.Megamenu ? true : false;
            using (var client = new SPHttpClient(new Uri(siteUrl), userName, password))
            {
                var itemPayload = new { __metadata = new { type = "SP.Web" }, MegaMenuEnabled = megaMenuEnabled };
                var endpointUrl = string.Format("{0}/_api/web", siteUrl);
                var data = client.ExecuteJson(endpointUrl, HttpMethod.Post, itemPayload);
            }
        }

    }

    public enum HeaderLayout
    {
        Standard = 1,
        Compact = 2
    }

    //These names are just for reference and are not the actual names
    public enum HeaderBackground
    {
        Lighter,
        Light,
        Dark,
        Darker
    }

    public enum MenuStyle
    {
        Megamenu,
        Cascading
    }
}
