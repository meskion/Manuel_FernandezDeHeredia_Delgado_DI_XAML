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
     * Clase con un pequeño juguete digital ambientado en el acuario. Con un slider podemos controlar el tamaño de un pez globo, usando un binding ver cose 
     */
    public partial class Minigame : Window
    {
        public Minigame()
        {
            InitializeComponent();
        }
        /**
         * Metodo OnClick para volver al menu
         */
        public void goBack(object sender, RoutedEventArgs e)
        {
            new AppSelectWindow().Show();
            Close();
        }
    }
}
