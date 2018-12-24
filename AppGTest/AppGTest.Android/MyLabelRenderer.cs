using Android.Content;
using AppGTest.Droid;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
//[assembly: ExportRenderer(typeof(Label), typeof(MyLabelRenderer))]
namespace AppGTest.Droid
{
    public class MyLabelRenderer : LabelRenderer
    {
        public MyLabelRenderer(Context context) : base(context)  { }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            //抓取控制項上的字形設定，並重新設定原本的單位為DP
            if (this.Control != null && this.Element != null)
                this.Control.SetTextSize(Android.Util.ComplexUnitType.Dip, Convert.ToSingle(this.Element.FontSize));
        }
    }
}