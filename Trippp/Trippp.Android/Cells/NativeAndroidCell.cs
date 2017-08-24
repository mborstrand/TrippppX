using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Trippp.Droid.Cells;
using Trippp.CustomRender;
using System;

namespace Trippp.Droid.Cells
{
    internal class NativeAndroidCell : LinearLayout
    {

        public CustomViewCell CustomViewCell { get; private set; }

        public NativeAndroidCell(Context context, CustomViewCell cell) : base(context)
        {
            Console.WriteLine("Hello there native android cell.");
        }

        public void UpdateCell(CustomViewCell cell)
        {
            Console.WriteLine(cell.View);
        }

    }
}