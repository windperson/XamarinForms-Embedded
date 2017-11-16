using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using EmebedXamarinForm;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Threading.Tasks;

namespace TheBaseApp.Droid
{
	[Activity (Label = "Mixed Android App", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

		    RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

		    var ft = FragmentManager.BeginTransaction();
		    ft.Replace(Resource.Id.base_framelayout, InitXamarinFormFragment(), "main");
		    ft.Commit();
		}


        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            throw e.ExceptionObject as Exception;
        }

        private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            throw e.Exception;
        }

        private Fragment InitXamarinFormFragment()
	    {
	        Forms.Init(this, null);
	        return new XamarinFormPage().CreateFragment(this);
	    }
	}
}


