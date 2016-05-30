using System;
using Xamarin.Forms;

namespace Forms.StarMenu
{
    public partial class StartPage : MasterDetailPage
    {
        public StartPage()
        {
            InitializeComponent();

            MasterPage.ListView.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as StartMenuItem;

            if (item != null)
            {
                Detail = (Page) Activator.CreateInstance(item.TargetType);

                MasterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }

        }
    }
}