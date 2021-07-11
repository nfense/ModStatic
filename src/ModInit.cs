using Nfense.NProxy;

namespace Nfense.ModStatic {
    internal class ModInit : Module {
        ModInit () {}

        public override void Init()
        {
            NProxy.NProxy.AddHandler("static", new StaticHandler());
        }

        public override string GetName()
        {
            return "ModStatic";
        }
    }
}