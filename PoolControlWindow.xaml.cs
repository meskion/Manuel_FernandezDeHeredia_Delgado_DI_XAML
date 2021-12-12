using Manuel_Fernandez_de_Heredia_Delgado_DI_XAML.controller;
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
    * Clase de la ventana de control de piscinas. Tiene un CRUD donde pueden verser y administrar las piscinas de las salas. Sirve como interfaz grafica a la clase PoolController, donde esta la lógica
    */
    public partial class PoolControlWindow : Window
    {
        /** Injección del controlador de piscinas que maneja los cambios en la "base de datos" */
        public static PoolController controller = new PoolController();

        public PoolControlWindow()
        {
            InitializeComponent();
            /** Asociamos el controlador al contexto de la ventana para los bindings*/
            poolGrid.DataContext = controller;
        }

        public void goBack(object sender, RoutedEventArgs e)
        {
            new AppSelectWindow().Show();
            Close();
        }
        /**
         * Metodo OnClick que muestra el formulario para añadir piscinas.
         */
        public void addPool(object sender, RoutedEventArgs e)
        {
            new PoolForm().Show();
        }
        /**
         * Metodo OnClick que muestra el formulario para modificar una piscina. Coge los datos de la piscina seleccionada en la tabla del XAML
         */

        public void UpdatePool(object sender, RoutedEventArgs e)
        {
            if (poolGrid.SelectedIndex != -1)
            {
                new PoolForm(poolGrid.SelectedIndex).Show();
            }
        }
        /**
         * Metodo OnClick que elimina una piscina de la lista
         */
         private void DeletePool(object sender, RoutedEventArgs e)
        {
            if (poolGrid.SelectedIndex != -1)
            {
                controller.delete(poolGrid.SelectedIndex);
            }
        }
    }
}
