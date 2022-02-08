using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Xamarin.Essentials;

namespace App_Theme
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class AppThemeActivity : AppCompatActivity
    {
        private TextView _themeTextView;
        private Button _checkThemeButton;
      //  private Button _changeThemeButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            UIReferences();
            UIClickevents();
        }

        private void UIClickevents()
        {
            _checkThemeButton.Click += CheckThemeButton_Click;
         
        }

        private void CheckThemeButton_Click(object sender, EventArgs e)
        {
            var currentTheme = AppInfo.RequestedTheme;
            _themeTextView.Text = $"Current theme: {currentTheme}";
        }

        private void UIReferences()
        {
            _themeTextView = FindViewById<TextView>(Resource.Id.ThemView);
            _checkThemeButton = FindViewById<Button>(Resource.Id.chkThem);
            
        }
    }
}