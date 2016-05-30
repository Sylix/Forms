using System;
using System.Collections.ObjectModel;
using Forms.Data;
using Xamarin.Forms;

namespace Forms.Pages
{
    public partial class ListWithCustomCellsPage
    {
        //ObservableCollection<Jogador> 
        //private List<Jogador> Jogadores { get; } = Escalacao.Get().ToList();
        private ObservableCollection<Jogador> Jogadores { get; }
        public ListWithCustomCellsPage()
        {
            InitializeComponent();

            //JogadoresList.ItemsSource = Jogadores;
            Jogadores = new ObservableCollection<Jogador>(Escalacao.Get());
            BindingContext = Jogadores;
        }

        private void OnMore(object sender, EventArgs e)
        {
            var mi = sender as MenuItem;
            var jogador = mi.CommandParameter as Jogador;
            Jogadores.Add(jogador);
        }

        private void OnDelete(object sender, EventArgs e)
        {
            var mi = sender as MenuItem;
            var jogador = mi.CommandParameter as Jogador;
            Jogadores.Remove(jogador);
        }

        private void JogadoresList_OnRefreshing(object sender, EventArgs e)
        {
            if (Jogadores.Count > 0)
            {
                Jogadores.Clear();
            }
            else
            {
                foreach (var jogador in Escalacao.Get())
                {
                    Jogadores.Add(jogador);
                }
            }

            JogadoresList.IsRefreshing = false;
            //JogadoresList.EndRefresh();
        }

        private void JogadoresList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            var jogador = e.SelectedItem as Jogador;
            DisplayAlert("Selecionou o Jogador", jogador.Nome, "Ok");
            ((ListView) sender).SelectedItem = null;
        }
    }
}