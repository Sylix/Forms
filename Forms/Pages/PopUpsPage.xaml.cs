using System;

namespace Forms.Pages
{
    public partial class PopUpsPage
    {
        public PopUpsPage()
        {
            InitializeComponent();
        }

        private void AlertOk_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Você foi avisado", "Ok");
        }

        private async void AlertTwoOptions_OnClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Duas Opções", "Você tem duas opções", "Opção 1", "Opção 2");
            string opcaoEscolhida = answer ? "Você escolheu a opção 1" : "Voce escolheu a opção 2";

            await DisplayAlert("Sério!!!!", opcaoEscolhida, "Ok");
        }

        private async void ActionSheetCancel_OnClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Qual a melhor plataforma?", "Cancelar", null, "Android", "iOS", "Windows");

            if (action == "Cancelar")
                return;

            await DisplayAlert(action, "É uma boa plataforma", "Comprar", "Cancelar");
        }

        private void ActionSheetDestruction_OnClicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Quem você apoia?", "Cancel", "Destruir Brasilia", "Aécio Neves", "Dilma Rousseff");
        }
    }
}