namespace Crimp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = "You're not good at following directions, huh";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
