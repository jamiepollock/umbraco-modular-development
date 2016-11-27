using System.Linq;

namespace Our.Umbraco.ModularDevelopment.ViewModels
{
    public static class ViewModelExtensionMethods
    {
        public static bool HasTitle(this PromoBoxesViewModel viewModel)
        {
            return string.IsNullOrWhiteSpace(viewModel.Title) == false;
        }
        public static bool HasItems(this PromoBoxesViewModel viewModel)
        {
            return viewModel.Items != null 
                && viewModel.Items.Any();
        }
    }
}