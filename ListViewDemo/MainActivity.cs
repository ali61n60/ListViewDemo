using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace ListViewDemo
{
    [Activity(Label = "ListViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView _listViewTest;
        private List<string> _listMyFamily;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            initFields();
        }

        private void initFields()
        {
            initListView();
            
        }

        private void initListView()
        {
            _listViewTest = FindViewById<ListView>(Resource.Id.listViewTest);
            _listViewTest.ItemClick += _listViewTest_ItemClick;

            _listMyFamily = new List<string> {"Ali", "Maryam", "Ilia"};
            ArrayAdapter<string> arrayAdapterMyFamily = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, _listMyFamily);
            _listViewTest.Adapter = arrayAdapterMyFamily;
        }

        private void _listViewTest_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string message = "";
            message ="Hello, "+ _listMyFamily[e.Position]+"!";
            Toast.MakeText(this,message,ToastLength.Long).Show();
        }
    }
}

