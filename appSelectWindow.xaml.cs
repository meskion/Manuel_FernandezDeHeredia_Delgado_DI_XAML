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
    * Clase de la ventana menu principal que da acceso al resto de ventanas de la aplicación
    */
    public partial class AppSelectWindow : Window
    {
        public AppSelectWindow()
        {
            InitializeComponent();
        }
        /**
         Metodo Onclick del boton para volver al menu
         */
        public void goBack(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
        /**
         * Metodo para ir a la venta de control de piscinas
         */
        private void goToControl(object sender, RoutedEventArgs e)
        {
            new PoolControlWindow().Show();
            Close();
        }
        /**
         * Metodo para ir a la ventana del minijuego.
         */
        private void goToGame(object sender, RoutedEventArgs e)
        {
            new Minigame().Show();
            Close();
        }

        /**
         *Metodo para ir a la ventana de las salas de acuario 
         */
         private void goToRooms(object sender, RoutedEventArgs e)
        {
            new FishRoomsWindow().Show();
            Close();
        }
        /**
         * Metodo para ir a la ventana de contacto
         */
        private void goToContact(object sender, RoutedEventArgs e)
        {
            new ContactWindow().Show();
            Close();
        }
    }
}
