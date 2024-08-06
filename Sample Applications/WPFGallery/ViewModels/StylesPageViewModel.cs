using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WPFGallery.Navigation;
using WPFGallery.Views;

namespace WPFGallery.ViewModels
{
    public partial class StylesPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _pageTitle = "Styles";

        [ObservableProperty]
        private string _pageDescription = "Different Styling options for your app";

        [ObservableProperty]
        private ICollection<NavigationCard> _navigationCards = new ObservableCollection<NavigationCard>
        {
            new NavigationCard
            {
                Name = "Compact Sizing",
                PageType = typeof(CompactPage),
                Icon = new Image {Source= new BitmapImage(new Uri("pack://application:,,,/Assets/ControlImages/CompactSizing.png"))},
               // Icon = newSymbolIcon { Symbol = SymbolRegular.ArrowDownload24 },
                Description = "Allows you to make your app more compact"
            },
        };

        private readonly INavigationService _navigationService;

        public StylesPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        public void Navigate(object pageType){
            if (pageType is Type page)
            {
                _navigationService.NavigateTo(page);
            }
        }

        
    }
}
