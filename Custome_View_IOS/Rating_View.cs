using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using UIKit;

namespace Custome_View_IOS
{
    [DesignTimeVisible(true)]
    public partial class Rating_View : UIView, IComponent
    {
        private List<UIButton> btnList;
        int rating;
        [Export("Rating"), Browsable(true)]
        public int Rating 
        {
            get
            {
                return rating;
            }
            set
            {
                if (value <= 0)
                    rating = 0;
                else if (value >= 5)
                    rating = 5;
                else
                    rating = value;

            }
        }
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
            //rootView.Frame = this.Frame;
            btnList = new List<UIButton>(){
                starButton1,
                starButton2,
                starButton3,
                starButton4,
                starButton5
            };
            rating = 0;
            foreach (UIButton item in btnList)
            {
                item.Selected = false;
                item.Highlighted = false;            }
            for (int i = 0; i < Rating; i++)
            {
                btnList[i].Selected = true;
            }
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

        private void OnStarClick(int rating)
        {
            if (rating == this.rating)
            {
                foreach (UIButton btn in btnList)
                {
                    btn.Selected = false;
                    btn.Highlighted = false;
                }
                this.rating = 0;
            }
            else if (rating > this.rating)
            {
                for (int i = this.rating; i < rating; i++)
                {
                    btnList[i].Selected = true;
                }
                this.rating = rating;
            }
            else
            {
                for (int i = rating; i < this.rating; i++)
                {
                    btnList[i].Selected = false;
                }
                this.rating = rating;
            }
        }

        partial void StarButton1_TouchUpInside(UIButton sender)
        {
            OnStarClick(1);
        }

        partial void StarButton2_TouchUpInside(UIButton sender)
        {
            OnStarClick(2);
        }

        partial void StarButton3_TouchUpInside(UIButton sender)
        {
            OnStarClick(3);
        }

        partial void StarButton4_TouchUpInside(UIButton sender)
        {
            OnStarClick(4); 
        }

        partial void StarButton5_TouchUpInside(UIButton sender)
        {
            OnStarClick(5);
        }
    }
}