using Trippp.CustomRender;
using Trippp.Droid.CustomRenders;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using Android.Views;
using System;
using Trippp.Droid.Cells;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(DroidViewCellRenderer)) ]

namespace Trippp.Droid.CustomRenders
{
    public class DroidViewCellRenderer : ViewCellRenderer
    {

        NativeAndroidCell cell;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var nativeCell = (CustomViewCell)item;
            Console.WriteLine("\t\t" + nativeCell);

            cell = convertView as NativeAndroidCell;
            if (cell == null)
            {
                cell = new NativeAndroidCell(context, nativeCell);
            } 
            else
            {
                //cell.CustomViewCell.PropertyChanged -= OnNativeCellPropertyChanged;
            }

            //nativeCell.PropertyChanged += OnNativeCellPropertyChanged;

            cell.UpdateCell(nativeCell);

            return cell;
        }

        void OnNativeCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }

    }
}