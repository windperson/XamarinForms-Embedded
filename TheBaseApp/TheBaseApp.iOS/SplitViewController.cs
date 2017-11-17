using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace TheBaseApp.iOS
{
    

    [Register("SplitViewController")]
    public class SplitViewController : UISplitViewController
    {
        private UIViewController masterViewController, detailViewController;

        public SplitViewController() : base()
        {
            masterViewController = new MasterViewController();
            detailViewController = new DetailViewController();

            ViewControllers = new[]{masterViewController, detailViewController};
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