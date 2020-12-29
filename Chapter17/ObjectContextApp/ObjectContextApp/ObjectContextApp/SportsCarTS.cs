using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp
{
    [Synchronization]
    class SportsCarTS: ContextBoundObject
    {
        public SportsCarTS()
        {
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} onject in context {1}", this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
        }
    }
}
