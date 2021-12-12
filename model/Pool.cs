using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Manuel_Fernandez_de_Heredia_Delgado_DI_XAML.model
{
    public class Pool : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Pool(string name, float temperature, string species, DateTime lastReview, string treatment)
        {
            this.name = name;
            this.temperature = temperature;
            this.species = species;
            this.lastReview = lastReview;
            this.treatment = treatment;
        }

        public Pool() { }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private float temperature;
        public float Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Temperature"));
            }

        }

        private string species;
        public string Species
        {
            get => species;
            set
            {
                species = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Species"));
            }
        }
        private DateTime lastReview;

        public DateTime LastReview
        {
            get => lastReview; set
            {
                lastReview = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LastReview"));
            }
        }

        private string treatment;
        public string Treatment { get => treatment; set 
            {
                treatment = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Treatment"));
            }
        }
    }
}
