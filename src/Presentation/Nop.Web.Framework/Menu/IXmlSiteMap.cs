using System.Threading.Tasks;

namespace Nop.Web.Framework.Menu
{
    /// <summary>
    /// XML sitemap interface
    /// </summary>
    public interface IXmlSiteMap
    {
        SiteMapNode RootNode { get; set; }

        Task LoadFromAsync(string physicalPath);
    }
}