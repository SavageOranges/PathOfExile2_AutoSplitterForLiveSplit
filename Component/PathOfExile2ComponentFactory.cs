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
        // Fill in this empty string with the URL of the repository where your component is hosted.
        // This should be the raw content version of the repository. If you're not uploading this
        // to GitHub or somewhere, you can ignore this.
        public string UpdateURL => "";
        public Version Version => Version.Parse("1.0.0");
        // Fill in this empty string with the path of the XML file containing update information.
        // Check other LiveSplit components for examples of this. If you're not uploading this to
        // GitHub or somewhere, you can ignore this.
        public string XMLURL => UpdateURL + "updates.xml";
        
        public IComponent Create(LiveSplitState state)
        {
            return new PathOfExile2Component(state);
        }
    }
}