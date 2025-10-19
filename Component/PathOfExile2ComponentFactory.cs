using System;
using LiveSplit.Model;
using LiveSplit.PathOfExile2AutoSplitter.Component;
using LiveSplit.UI.Components;

[assembly: ComponentFactory(typeof(PathOfExile2ComponentFactory))]

namespace LiveSplit.PathOfExile2AutoSplitter.Component
{
    public class PathOfExile2ComponentFactory : IComponentFactory
    {
        public ComponentCategory Category => ComponentCategory.Timer;

        public string ComponentName => "Path of Exile 2";
        public string Description => "An AutoSplitter for Path of Exile 2";
        public string UpdateName => "Path of Exile 2";
        public string UpdateURL => "http://raw.githubusercontent.com/SavageOranges/PathOfExile2_AutoSplitterForLiveSplit/master/Component/DLL/";
        public Version Version => Version.Parse("1.0.1");
        public string XMLURL => UpdateURL + "updates.xml";
        
        public IComponent Create(LiveSplitState state)
        {
            return new PathOfExile2Component(state);
        }
    }
}