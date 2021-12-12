using Manuel_Fernandez_de_Heredia_Delgado_DI_XAML.model;
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
    /// <summary>
    /// Interaction logic for PoolForm.xaml
    ///
    /// </summary>
    public partial class PoolForm : Window
    {
        private Pool pool;
        private int index;
        public PoolForm()
        {
            InitializeComponent();
            index = -1;
            pool = new Pool();
            DataContext = pool;

        }

        public PoolForm(int index)
        {
            InitializeComponent();
            this.index = index;
            pool = PoolControlWindow.controller.PoolList[index];
            DataContext = pool;
        }

        private void AcceptClick(object sender, RoutedEventArgs e)
        {
            if (index > -1)
            {
                PoolControlWindow.controller.update(index, pool);
            } else
            {
                PoolControlWindow.controller.insert(pool);
            }
            Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
