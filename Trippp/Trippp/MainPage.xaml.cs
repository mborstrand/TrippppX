using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Trippp.Common;
using Common.Models;


namespace Trippp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var service = new Common.Service();

            var request = service.GetStops();
            Console.WriteLine("Request In View Result: {0}", request.Result);
        }
    }
}
