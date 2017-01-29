using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace Xamarin_Material_Design.Droid.Fragments
{
    public class ExtrasFragment:Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.extras, container, false);
            return view;

        }
    }
}