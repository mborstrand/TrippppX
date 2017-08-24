using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trippp.ViewCells;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Common.Models;
using Trippp.CustomRender;

namespace Trippp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{

        ListView listView = new ListView();

		public StartPage ()
		{
			InitializeComponent ();

            SetupInterface();

		}

        private void SetupInterface()
        {
            Title = "Avgångar";

            SetupListView();
        }

        private void SetupListView()
        {
            listView.Margin = new Thickness(0, 10, 0, 10);
            listView.RowHeight = 130;
            listView.SeparatorColor = Color.White;
            listView.ItemTemplate = new DataTemplate(typeof(CustomViewCell));
            listView.ItemsSource = Departure.DepartureList;
            listView.IsPullToRefreshEnabled = true;
            listView.RefreshCommand = new Command(() =>
            {
                listView.IsRefreshing = false;
            });

            // Add The list view to the views content.
            Content = listView;
        }
    }
}