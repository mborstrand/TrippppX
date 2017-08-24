using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trippp.CustomRender
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class CustomViewCell : ViewCell
    {

        public CustomViewCell()
        {
            Console.WriteLine(" **** ");
            Frame frame = new Frame();
            frame.BackgroundColor = Color.LightBlue;
            frame.VerticalOptions = LayoutOptions.FillAndExpand;
            frame.HorizontalOptions = LayoutOptions.FillAndExpand;
            frame.CornerRadius = 10;

            StackLayout verticalLayout = new StackLayout();
            verticalLayout.BackgroundColor = Color.Transparent;
            verticalLayout.Orientation = StackOrientation.Vertical;

            Label destinationLabel = new Label();
            //destinationLabel.SetBinding(Label.TextProperty, "Destination");
            destinationLabel.Text = "Destination Name";

            verticalLayout.Children.Add(destinationLabel);


            StackLayout cellWrapper = new StackLayout();
            cellWrapper.Margin = new Thickness(20, 7.5, 20, 7.5);
            cellWrapper.Padding = 1;
            cellWrapper.BackgroundColor = Color.White;
            cellWrapper.Children.Add(verticalLayout);
            cellWrapper.Children.Add(frame);


            View = cellWrapper;
        }
    }
}
