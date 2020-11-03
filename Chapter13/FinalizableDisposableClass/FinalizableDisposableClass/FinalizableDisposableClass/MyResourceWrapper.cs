using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposableClass
{
    class MyResourceWrapper: IDisposable
    {
        private bool disposed = false;
        ~MyResourceWrapper()
        {
            Console.Beep();
            CleanUp(false);
        }
        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }
        private void CleanUp(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }
    }
}
