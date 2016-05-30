using System.Collections.Generic;
using Forms.Pages;
using Xamarin.Forms;

namespace Forms.StarMenu
{
    public partial class StartOptionsPage
    {
        public ListView ListView => MenuList;

        public StartOptionsPage()
        {
            InitializeComponent();

            var grouped = new List<StartMenuGroup>();
            var contentPagesGroup = new StartMenuGroup() {Title = "Content Pages"};
            var tabbedPagesGroup = new StartMenuGroup() {Title = "Tabbed Pages"};

            contentPagesGroup.Add(new StartMenuItem
            {
                Title = "Page 1",
                IconSource = "ic_filter_1_black_24dp.png",
                TargetType = typeof(ActivityIndicatorAndButtonPage)
            });

            contentPagesGroup.Add(new StartMenuItem
            {
                Title = "Page 2",
                IconSource = "ic_filter_2_black_24dp.png",
                TargetType = typeof(PopUpsPage)
            });

            contentPagesGroup.Add(new StartMenuItem
            {
                Title = "Page 3",
                IconSource = "ic_filter_3_black_24dp.png",
                TargetType = typeof(PickerBoxViewPage)
            });



            //tabbedPagesGroup.Add(new StartMenuItem
            //{
            //    Title = "TabbedPage",
            //    IconSource = "ic_filter_4_black_24dp.png",
            //    TargetType = typeof(ListsTabbedPage)
            //});

            grouped.Add(contentPagesGroup);
            //grouped.Add(tabbedPagesGroup);

            ListView.ItemsSource = grouped;
        }
    }
}