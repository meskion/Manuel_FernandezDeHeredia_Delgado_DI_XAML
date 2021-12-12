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
     Clase de la venta con la informacion de contacto del acuario
     */
    public partial class ContactWindow : Window
    {
        public ContactWindow()
        {
            InitializeComponent();
        }
        /**
         Metodo del boton para volver al menu principal
         */
        private void goBack(object sender, RoutedEventArgs e)
        {
            new AppSelectWindow().Show();
            Close();
        }
    }
}
