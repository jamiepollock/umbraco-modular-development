using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Our.Umbraco.ModularDevelopment.ViewModels
{
    public static class ViewModelExtensionMethods
    {
        public static bool HasTitleOrIntro(this PromoBoxesViewModel viewModel)
        {
            return string.IsNullOrWhiteSpace(viewModel.Title) == false
                || (viewModel.Intro != null && string.IsNullOrWhiteSpace(viewModel.Intro.ToHtmlString()) == false);
        }
    }
}