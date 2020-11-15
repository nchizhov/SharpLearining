using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShapes;
using Chapter14.My3DShapes;
using The3DHexagon = Chapter14.My3DShapes.Hexagon;
using bfHome = System.Runtime.Serialization.Formatters.Binary;

namespace CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            The3DHexagon h2 = new The3DHexagon();
            bfHome.BinaryFormatter b = new bfHome.BinaryFormatter();
        }
    }
}
