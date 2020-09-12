using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio1_ED2;
using LAB1_API.Models;
namespace LAB1_API.Models
{
    public class mTree
    {
        private int order;
        private MultiwayTree<mMovies> multiwayPeli;

        public int Order { get => order; set => order = value; }
        public MultiwayTree<mMovies> MultiwayPeli { get => multiwayPeli; set => multiwayPeli = value; }
    }
}
