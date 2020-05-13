using Foundation;
using System;
using System.ComponentModel;
using UIKit;

namespace Custome_View_IOS
{
    [DesignTimeVisible(true)]
    public partial class Rating_View : UIView, IComponent
    {
        public ISite Site { get; set; }
        public event EventHandler Disposed;
        public Rating_View (IntPtr handle) : base (handle)
        {

        }
        public Rating_View()
        {
            Initial();
        }

        private void Initial()
        {
            NSBundle.MainBundle.LoadNib("Rating_View", this, null);

            this.AddSubview(this.rootView);
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            if ((Site != null) && Site.DesignMode)
            {
                // Bundle resources aren't available in DesignMode
                return;
            }

            Initial();

            
        }

    }
}