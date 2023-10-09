namespace tabliczkaM
{
    public partial class MainPage : ContentPage
    {
        private string s = "1";

        public MainPage()
        {
            InitializeComponent();
        }
        private string zamiana(int i, int j, int maks)
        {
            string k=(i*j).ToString();
            int star=k.Length;
            int stop = maks.ToString().Length;
            for(int a=star; a<=stop; a++)
            {
                k = " " + k;
            }
            return k;
        }
        private void btnGenerujClicked(object sender, EventArgs e)
        {
            s = "";
            int n = int.Parse(entRozmiar.Text);
            int maks = n * n;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    s += zamiana(i, j, maks) + "\t";
                }
                s += '\n';
            }
            lblTabliczka.Text = s;
            SemanticScreenReader.Announce(lblTabliczka.Text);
        }
        private void btnResetClicked(object sender, EventArgs e)
        {
            s = "Tabliczka mnożenia";
            lblTabliczka.Text = s;
            SemanticScreenReader.Announce(lblTabliczka.Text);
        }
    }
}