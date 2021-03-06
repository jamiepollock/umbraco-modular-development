﻿using Our.Umbraco.Ditto;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Our.Umbraco.ModularDevelopment.ViewModels
{
    [UmbracoProperties(Prefix = "promoBoxes_")]
    public class PromoBoxesViewModel
    {
        [UmbracoProperty]
        public string Title { get; set; }

        [UmbracoProperty]
        public IHtmlString Intro { get; set; }

        [UmbracoProperty]
        public IEnumerable<PromoBoxViewModel> Items { get; set; }

        [DittoIgnore]
        public int ColumnWidth
        {
            get
            {
                var itemCount = Items.Count();

                switch (itemCount)
                {
                    case 3:
                        return 4;
                    case 4:
                        return 3;
                    default:
                        return 6;
                }
            }
        }
    }
}