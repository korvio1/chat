namespace chat
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Send(object sender, EventArgs e)
        {
            //pobierz nazwę użytkownika
            string userName = UsernameEntry.Text;
            //wyciągam wiadomość z entry
            string message = ChatEntry.Text;
            //resetuję entry
            ChatEntry.Text = string.Empty;
            //placeholder - lokalne demo
            Label messageLabel = new Label();
            messageLabel.Text = userName + ": " + message;
            ChatHistory.Children.Add(messageLabel);
        }
    }    
}