namespace Atelier7
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Fclic(object sender, EventArgs e)
        {
            if (int.TryParse(FaraE.Text, out int faraneit))
            {
                int celcus = (faraneit - 32) * 5 / 9;
                CT.Text = celcus.ToString() + " 'C";

            }
        }

        private void Celclic(object sender, EventArgs e)
        {
            if (int.TryParse(CelsusE.Text, out int celcus))
            {
                int faraneit = (celcus * 9 / 5) + 32;
                FT.Text = faraneit.ToString()+" 'F";
            }
        }
    }

}
