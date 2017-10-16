using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using LiveSplit.RivaTuner.UI.Components;

[assembly: ComponentFactory(typeof(RivaTunerFactory))]

namespace LiveSplit.RivaTuner.UI.Components
{
    public class RivaTunerFactory : IComponentFactory
    {
        public ComponentCategory Category => ComponentCategory.Other;

        public string ComponentName => "RivaTuner";

        public string Description => "Display LiveSplit information using RivaTuner's OSD";

        public string UpdateName => ComponentName;

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.0.0");

        public string XMLURL => "";

        public IComponent Create(LiveSplitState state) => new RivaTunerComponent(state);
    }
}
