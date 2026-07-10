using Syncfusion.Maui.Rotator;
using System.Collections.ObjectModel;

namespace BottomSheetSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            orderDetailsSheet.IsOpen = true;
        }
    }

}
