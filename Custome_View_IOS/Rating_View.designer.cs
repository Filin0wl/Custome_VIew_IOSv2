// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Custome_View_IOS
{
    [Register ("Rating_View")]
    partial class Rating_View
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView rootView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton starButton1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton starButton2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton starButton3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton starButton4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton starButton5 { get; set; }

        [Action ("StarButton1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StarButton1_TouchUpInside (UIKit.UIButton sender);

        [Action ("StarButton2_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StarButton2_TouchUpInside (UIKit.UIButton sender);

        [Action ("StarButton3_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StarButton3_TouchUpInside (UIKit.UIButton sender);

        [Action ("StarButton4_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StarButton4_TouchUpInside (UIKit.UIButton sender);

        [Action ("StarButton5_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StarButton5_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (rootView != null) {
                rootView.Dispose ();
                rootView = null;
            }

            if (starButton1 != null) {
                starButton1.Dispose ();
                starButton1 = null;
            }

            if (starButton2 != null) {
                starButton2.Dispose ();
                starButton2 = null;
            }

            if (starButton3 != null) {
                starButton3.Dispose ();
                starButton3 = null;
            }

            if (starButton4 != null) {
                starButton4.Dispose ();
                starButton4 = null;
            }

            if (starButton5 != null) {
                starButton5.Dispose ();
                starButton5 = null;
            }
        }
    }
}