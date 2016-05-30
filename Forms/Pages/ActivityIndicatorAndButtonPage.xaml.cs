using System;

namespace Forms.Pages
{
    public partial class ActivityIndicatorAndButtonPage
    {
        public ActivityIndicatorAndButtonPage()
        {
            InitializeComponent();

            Indicator.IsRunning = true;
            StartButton.IsEnabled = false;
            StopButton.IsEnabled = true;

            StopButton.Clicked += StopButton_OnClicked;
        }

        private void StartButton_OnClicked(object sender, EventArgs e)
        {
            Indicator.IsRunning = true;
            StartButton.IsEnabled = false;
            StopButton.IsEnabled = true;
        }

        private void StopButton_OnClicked(object sender, EventArgs e)
        {
            Indicator.IsRunning = false;
            StartButton.IsEnabled = true;
            StopButton.IsEnabled = false;
        }
    }
}