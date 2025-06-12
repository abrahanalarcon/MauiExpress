using Microsoft.Maui.Controls;

namespace MauiExpress
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            int caracteres = comentarioEditor.Text?.Length ?? 0;
            contadorCaracteres.Text = $"Caracteres: {caracteres}";

            
            contadorCaracteres.TextColor = caracteres > 50 ? Colors.Red : Colors.Gray;
        }

       
        private void OnEnviarComentarioClicked(object sender, EventArgs e)
        {
            string texto = comentarioEditor.Text;
            comentarioMostrado.Text = texto;
            contadorFinal.Text = $"Longitud final: {texto?.Length ?? 0} caracteres";
        }

        
        private void OnLimpiarComentarioClicked(object sender, EventArgs e)
        {
            comentarioEditor.Text = string.Empty;
            comentarioMostrado.Text = "Tu comentario aparecerá aquí!";
            contadorFinal.Text = "Longitud final: 0 caracteres";
            contadorCaracteres.Text = "Caracteres: 0";
            contadorCaracteres.TextColor = Colors.Gray;
        }
    }
}
