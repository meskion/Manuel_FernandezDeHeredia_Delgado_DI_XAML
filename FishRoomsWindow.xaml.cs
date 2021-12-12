using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Manuel_Fernandez_de_Heredia_Delgado_DI_XAML
{
   /**
    Clase de la ventana con las diferentes salas del acuario. Pulsando la imagen de cada sala aparece una breve explicación
    
    */
    public partial class FishRoomsWindow : Window
    {
       
        public FishRoomsWindow()
        {
            InitializeComponent();
            
        }
        /**
         Metodo OnClick del boton para volver al menu principal de la App
         */
        private void goBack(object sender, RoutedEventArgs e)
        {
            new AppSelectWindow().Show();
            Close();
        }

        /**
        Metodo onCick del boton de la sala tropical, oculta el resto de textos y muestra el de su sala        
         */
        private void TropiButton(object sender, RoutedEventArgs e)
        {
            TropiText.Visibility = Visibility.Visible;
            MamiText.Visibility = Visibility.Hidden;
            CrustText.Visibility = Visibility.Hidden;
        }
        /**
        Metodo onCick del boton de la sala Grandes Mamiferos, oculta el resto de textos y muestra el de su sala        
        */

        private void MamiButton(object sender, RoutedEventArgs e)
        {
            TropiText.Visibility = Visibility.Hidden;
            MamiText.Visibility = Visibility.Visible;
            CrustText.Visibility = Visibility.Hidden;
        }
        /**
        Metodo onCick del boton de la sala Crustaceos, oculta el resto de textos y muestra el de su sala        
        */
        private void CrustButton(object sender, RoutedEventArgs e)
        {
            TropiText.Visibility = Visibility.Hidden;
            MamiText.Visibility = Visibility.Hidden;
            CrustText.Visibility = Visibility.Visible;
        }
    }
}
