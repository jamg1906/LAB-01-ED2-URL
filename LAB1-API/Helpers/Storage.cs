using LAB1_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB1_API.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }
        public static Laboratorio1_ED2.MultiwayTree<mMovies> MovieTree = new Laboratorio1_ED2.MultiwayTree<mMovies>();
    }
}
