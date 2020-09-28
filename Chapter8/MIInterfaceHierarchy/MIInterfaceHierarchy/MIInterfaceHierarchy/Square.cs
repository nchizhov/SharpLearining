using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square: IShape
    {
        void IPrintable.Draw()
        {

        }
        void IDrawable.Draw()
        {

        }
        public void Print()
        {

        }
        public int GetNumberOfSides()
        {
            return 4;
        }
    }
}
