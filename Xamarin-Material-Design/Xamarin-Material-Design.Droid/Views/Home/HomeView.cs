using System;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Widget;
using Android.Support.V4.View;
using Xamarin_Material_Design.Droid.Adapter;
using Java.Lang;
using System.Collections.Generic;
using Xamarin_Material_Design.Droid.Fragments;
using Android.Runtime;

namespace Xamarin_Material_Design.Droid.Views.Home
{
    [Activity(Label = "", MainLauncher = true)]
    public class HomeView : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar _toolbar;
        NavigationView navigationView;
        DrawerLayout drawerLayout;
        ViewPager viewpager;
        TabLayout tablayout;
        List<Android.Support.V4.App.Fragment> frag;
        ICharSequence[] titles;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.homeview);

            GetReferences();

            SetUpToolbar();

            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;

            SetUpDrawer();

            if (viewpager != null)
            {
                var adapter = new FragmentAdapter(SupportFragmentManager);
                adapter.AddFragment(new MaterialFragment(), "Material Design");
                adapter.AddFragment(new AndroidFragment(), "Android Patterns");
                adapter.AddFragment(new ExtrasFragment(), "Extras");
                viewpager.Adapter = adapter;
                
            }
            tablayout.SetupWithViewPager(viewpager);
        }

        private void GetReferences()
        {
            navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            viewpager = FindViewById<ViewPager>(Resource.Id.viewpager);
            tablayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
        }

        private void SetUpToolbar()
        {
            var titleName = "Xamarin Material";

            _toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(_toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            var collapsingToolbar = FindViewById<CollapsingToolbarLayout>(Resource.Id.collapsing_toolbar);
            collapsingToolbar.SetTitle(titleName);

            var imageView = FindViewById<ImageView>(Resource.Id.backdrop);
            imageView.SetImageResource(Resource.Drawable.sparkling_feather);
        }

        private void SetUpDrawer()
        {
            var toggle = new ActionBarDrawerToggle(this, drawerLayout, _toolbar, Resource.String.drawer_open, Resource.String.drawer_close);
            drawerLayout.AddDrawerListener(toggle);
            toggle.SyncState();
        }

        private void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            
        }

        private void SetUpFragments()
        {
            frag = new List<Android.Support.V4.App.Fragment>()
            {
                new MaterialFragment(),
                new ExtrasFragment(),
                new AndroidFragment()
            };

            titles = CharSequence.ArrayFromStringArray(new[]
             {
                  "Material Content" , "Android Patterns" , "Extras"
            });
        }
    }
}
