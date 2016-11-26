using Our.Umbraco.Ditto;
using Our.Umbraco.ModularDevelopment.ComponentModel;
using System.Web;

namespace Our.Umbraco.ModularDevelopment.ViewModels
{
    [UmbracoProperties(Prefix = "promoBox_")]
    public class PromoBoxViewModel
    {
        [UmbracoProperty]
        [UmbracoPicker]
        [EnumerableConverter]
        [ContentValueUmbracoUrl]
        public string Thumbnail { get; set; }

        [UmbracoProperty]
        public string Title { get; set; }

        [UmbracoProperty]
        public IHtmlString Content { get; set; }
    }
}