using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingleton
{
    class MySingleton
    {
        //Prywatna instancja klasy 
        private static MySingleton instance = new MySingleton();

        //przykładowe zmienne
        private string marka;
        private string model;


        //statyczny konstruktor klasy pozwalający wywołać tylko jeden raz w ciagu działania programu
        static MySingleton() { }

        //prywatny konstrukrtor klasy
        private MySingleton() { }

        public static MySingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
    }
}
