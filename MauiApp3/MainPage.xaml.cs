namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Método cuando el texto de la entrada cambia 
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pasado = e.OldTextValue;    //Valor anterior 
            string nuevo = e.NewTextValue; //Nuevo valor 
        }

        //Método cuando se completa la entrada
        private void Entry_Completed(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
          
        }
    }

}
