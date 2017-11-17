using System;
using System.Collections.Generic;
using System.Linq;

using UIKit;
using MonoTouch.Dialog;

namespace TheBaseApp.iOS
{
    public partial class MasterViewController : DialogViewController
    {
        public MasterViewController() : base(UITableViewStyle.Grouped, null)
        {
            var section = new Section();
            section.AddAll(Enumerable.Range(1, 3).Select(num => (Element) new StringElement("Item" + num)));

            Root = new RootElement("Items");
            Root.Add(section);
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            return true;
        }
    }
}