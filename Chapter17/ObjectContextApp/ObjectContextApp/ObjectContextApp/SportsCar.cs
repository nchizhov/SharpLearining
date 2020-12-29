using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp
{
    class SportsCar
    {
        public SportsCar()
        {
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}", this.ToString(), ctx.ContextID);
            foreach (IContextProperty itCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop: {0}", itCtxProp.Name);
        }
    }
}
