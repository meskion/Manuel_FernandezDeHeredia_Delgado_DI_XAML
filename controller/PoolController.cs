using Manuel_Fernandez_de_Heredia_Delgado_DI_XAML.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Manuel_Fernandez_de_Heredia_Delgado_DI_XAML.controller
{
    /**
     * Almacena y manejas las instancias de la clase Pool(piscinas) con metodos para acceder y manejar la informacion en la "base de datos" (una lista)
     */
    public class PoolController
    {
        /** Propiedad lista con las piscinas a almacenar*/
        public ObservableCollection<Pool> PoolList { get; set; }

        public PoolController()
        {
            PoolList = new ObservableCollection<Pool>();
            PoolList.Add(new Pool("Mediterranea", 20, "Pececitos", new DateTime(2021, 10, 1), "Limpieza"));
        }
        /** Metodo para insertar una piscina */
        public void insert(Pool p)
        {
            PoolList.Add(p);
        }
        /**Actualiza una piscina en la posicion indicada. */
        public void update(int index, Pool p)
        {
            PoolList[index] = p;
        }
        /** Borra una piscina*/
        public void delete(int index)
        {
            PoolList.RemoveAt(index);
        }
}
}
