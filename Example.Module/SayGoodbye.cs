using Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Module
{
    internal class SayGoodbye : ISayGoodbye
    {
        public string Talk()
        {
            return "Goodbye from SayGoodbye";
        }
    }

    public class ExampleModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISayGoodbye>().To<SayGoodbye>();
        }
    }
}
