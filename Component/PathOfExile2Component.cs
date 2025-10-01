using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.PathOfExile2AutoSplitter.Component.ClientLog;
using LiveSplit.PathOfExile2AutoSplitter.Component.Settings;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using AutoSplitter = LiveSplit.PathOfExile2AutoSplitter.Component.Timer.AutoSplitter;

namespace LiveSplit.PathOfExile2AutoSplitter.Component
{
    public class PathOfExile2Component : LogicComponent
    {
        public const string Name = "Path of Exile 2";
        public override string ComponentName => Name;

        private ClientReader _reader;
        private ComponentSettings _settings = new ComponentSettings();
        private SettingsControl _control;

        public PathOfExile2Component(LiveSplitState state)
        {
            TimerModel timer = new TimerModel();
            timer.CurrentState = state;

            AutoSplitter auto = new AutoSplitter(timer, _settings);

            _reader = new ClientReader(_settings, auto);
            _reader.Start();

            _control = new SettingsControl(_settings, state);
            _settings.HandleLogLocationChanged = _reader.Start;
        }

        public override void Dispose()
        {
            _reader.Stop();
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return _settings.GetSettings(document);
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return _control;
        }

        public override void SetSettings(XmlNode settings)
        {
            _settings.SetSettings(settings);
            _control.XmlRefresh();
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        { }
    }
}
