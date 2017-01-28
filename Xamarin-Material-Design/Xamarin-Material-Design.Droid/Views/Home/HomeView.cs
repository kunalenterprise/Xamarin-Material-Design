using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace Xamarin_Material_Design.Droid.Views.Home
{
    [Activity(Label = "", MainLauncher = true)]
    public class HomeView : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.homeview);
        }
    }
}
