// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Custome_View_IOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Custome_View_IOS.Rating_View rating { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (rating != null) {
                rating.Dispose ();
                rating = null;
            }
        }
    }
}