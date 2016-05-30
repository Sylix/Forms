using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Forms.Pages
{
    public partial class PickerBoxViewPage
    {
        private readonly Dictionary<string, Color> Cores;

        public PickerBoxViewPage()
        {
            InitializeComponent();

            Cores = new Dictionary<string, Color>
            {
                {"Blue", Color.Blue},
                {"Gray", Color.Gray},
                {"Black", Color.Black},
                {"Lime", Color.Lime},
                {"Green", Color.Green},
                {"Purple", Color.Purple},
                {"Silver", Color.Silver},
                {"White", Color.White},
                {"Yellow", Color.Yellow},
            };

            foreach (var color in Cores.Keys)
            {
                PickerColor.Items.Add(color);
            }
        }

        private void PickerColor_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (PickerColor.SelectedIndex == -1)
            {
                BoxViewColors.Color = Color.Default;
            }
            else
            {
                string colorName = PickerColor.Items[PickerColor.SelectedIndex];
                BoxViewColors.Color = Cores[colorName];
            }
        }
    }
}