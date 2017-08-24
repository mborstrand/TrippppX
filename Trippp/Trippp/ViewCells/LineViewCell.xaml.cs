using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trippp.ViewCells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LineViewCell : ViewCell
	{
		public LineViewCell ()
		{
			InitializeComponent ();

            Frame frame = new Frame();
            frame.BackgroundColor = Color.White;
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