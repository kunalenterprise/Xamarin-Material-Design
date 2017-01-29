using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace Xamarin_Material_Design.Droid.Fragments
{
    public class MaterialFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View view = inflater.Inflate(Resource.Layout.material_design, container, false);
            return view;
        }
    }
}