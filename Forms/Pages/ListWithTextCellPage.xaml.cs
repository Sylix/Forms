using Forms.Data;

namespace Forms.Pages
{
    public partial class ListWithTextCellPage
    {
        public ListWithTextCellPage()
        {
            InitializeComponent();

            JogadoresList.ItemsSource = Escalacao.Get();
        }
    }
}