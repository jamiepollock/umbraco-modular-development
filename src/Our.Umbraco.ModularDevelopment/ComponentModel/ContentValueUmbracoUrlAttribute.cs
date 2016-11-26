using Our.Umbraco.Ditto;
using Umbraco.Core.Models;

namespace Our.Umbraco.ModularDevelopment.ComponentModel
{
    [DittoProcessorMetaData(ValueType = typeof(IPublishedContent))]
    public class ContentValueUmbracoUrlAttribute : DittoProcessorAttribute
    {
        public string DefaultValue { get; set; }

        public override object ProcessValue()
        {
            var contentValue = Value as IPublishedContent;

            if (contentValue != null)
            {
                return contentValue.Url;
            }

            return DefaultValue;
        }
    }
}