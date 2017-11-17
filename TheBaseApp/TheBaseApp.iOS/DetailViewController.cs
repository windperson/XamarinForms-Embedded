using System;
using System.Drawing;

using CoreFoundation;
using CoreGraphics;
using UIKit;
using Foundation;

namespace TheBaseApp.iOS
{

    [Register("DetailViewController")]
    public class DetailViewController : UIViewController
    {
        private UILabel label;
        public DetailViewController() : base()
        {
            View.BackgroundColor = UIColor.White;
            label = new UILabel(new CGRect(100,100,300,50));
            label.Text = "This is the detail view";
            View.AddSubview(label);
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            return true;
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

       
    }
}