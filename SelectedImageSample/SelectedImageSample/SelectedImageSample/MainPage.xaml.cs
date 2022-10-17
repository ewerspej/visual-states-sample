using System;
using Xamarin.Forms;

namespace SelectedImageSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SelectImage(object sender, EventArgs e)
        {
            if (sender is ImageButton imageButton)
            {
                VisualStateManager.GoToState(imageButton, "Selected");
            }
        }
    }
}
