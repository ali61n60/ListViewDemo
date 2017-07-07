using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
    [Activity(Label = "ListViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView _listViewTest;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            initFields();
        }

        private void initFields()
        {
            _listViewTest = FindViewById<ListView>(Resource.Id.listViewTest);
            List<string> listMyFamily=new List<string>();
            listMyFamily.Add("Ali");
            listMyFamily.Add("Maryam");
            listMyFamily.Add("Ilia");
            ArrayAdapter<string> arrayAdapterMyFamily=new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1,listMyFamily);
            _listViewTest.Adapter = arrayAdapterMyFamily;
        }
    }
}

