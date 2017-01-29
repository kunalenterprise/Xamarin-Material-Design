using System.Collections.Generic;
using Android.Support.V4.App;
using System;

namespace Xamarin_Material_Design.Droid.Adapter
{
    public class FragmentAdapter : FragmentPagerAdapter
    {
        private List<Fragment> fragments = new List<Fragment>();
        List<string> fragmentTitles = new List<string>();

        public FragmentAdapter(FragmentManager fm):base(fm)
        {
            
        }

        public void AddFragment(Fragment fragment, String title)
        {
            fragments.Add(fragment);
            fragmentTitles.Add(title);
        }

        public override int Count
        {
            get
            {
                return fragments.Count;
            }
        }

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(fragmentTitles[position]);
        }
    }
}