using System;
using System.Collections.Generic;
using System.Xml;
using LiveSplit.Options;
using LiveSplit.PathOfExile2AutoSplitter.Component.Enums;
using LiveSplit.PathOfExile2AutoSplitter.Component.Timer;
using LiveSplit.UI;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.Settings
{
    public class ComponentSettings
    {
        private const string LOG_KEY = "log.location";
        private const string LOAD_REMOVAL_FLAG = "load.removal";
        private const string AUTO_SPLIT_FLAG = "auto.split";
        private const string FRESH_CHARACTER_AUTO_START = "auto.start";
        private const string SPLIT_CAMPAIGN_AREAS = "split.areas.on";
        private const string SPLIT_CAMPAIGN_AREA = "split.area";
        private const string SPLIT_CRITERIA = "split.criteria";
        private const string SPLIT_LEVELS = "split.levels.on";
        private const string SPLIT_LEVEL = "split.level";
        private const string GENERATE_WITH_ICONS = "generate.with.icons";
        private const string DEFAULT_LOG_LOCATION = @"C:\Program Files (x86)\Steam\steamapps\common\Path of Exile 2\logs\Client.txt";

        private string logLocation;

        public string LogLocation
        {
            get
            {
                return logLocation;
            }
            set
            {
                logLocation = value;
                HandleLogLocationChanged?.Invoke();
            }
        }

        public bool LoadRemovalEnabled;
        public bool AutoSplitEnabled;
        public bool AutoStartEnabled;
        public HashSet<ICampaignArea> SplitCampaignAreas { get; private set; }
        public EnSplitCriteria SplitCriteria;
        public HashSet<int> SplitLevels { get; private set; }
        public bool GenerateWithIcons;
        public Action HandleLogLocationChanged { get; set; }

        public ComponentSettings()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            AutoSplitEnabled = true;
            AutoStartEnabled = false;
            LoadRemovalEnabled = false;
            GenerateWithIcons = true;
            SplitCriteria = EnSplitCriteria.CampaignFull;
            logLocation = DEFAULT_LOG_LOCATION;
            SplitCampaignAreas = new HashSet<ICampaignArea>();
            SplitLevels = new HashSet<int>();
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            // Serialise settings into a new XmlNode.
            XmlElement settingsNode = document.CreateElement("Settings");
            SettingsHelper.CreateSetting(document, settingsNode, LOG_KEY, LogLocation);
            SettingsHelper.CreateSetting(document, settingsNode, LOAD_REMOVAL_FLAG, LoadRemovalEnabled);
            SettingsHelper.CreateSetting(document, settingsNode, AUTO_SPLIT_FLAG, AutoSplitEnabled);
            SettingsHelper.CreateSetting(document, settingsNode, FRESH_CHARACTER_AUTO_START, AutoStartEnabled);
            SettingsHelper.CreateSetting(document, settingsNode, SPLIT_CRITERIA, SplitCriteria);
            SettingsHelper.CreateSetting(document, settingsNode, GENERATE_WITH_ICONS, GenerateWithIcons);

            settingsNode.AppendChild(SerializeCampaignAreas(document));
            settingsNode.AppendChild(SerializeLevels(document));

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            // Deserialise settings.
            SetDefaults();
            
            try
            {
                XmlElement element = (XmlElement)settings;
                if (!element.IsEmpty)
                {
                    if (element[LOG_KEY] != null)
                    {
                        LogLocation = element[LOG_KEY].InnerText;
                    }

                    if (element[LOAD_REMOVAL_FLAG] != null)
                    {
                        LoadRemovalEnabled = bool.Parse(element[LOAD_REMOVAL_FLAG].InnerText);
                    }
                    
                    if (element[AUTO_SPLIT_FLAG] != null)
                    {
                        AutoSplitEnabled = bool.Parse(element[AUTO_SPLIT_FLAG].InnerText);
                    }

                    if (element[FRESH_CHARACTER_AUTO_START] != null)
                    {
                        AutoStartEnabled = bool.Parse(element[FRESH_CHARACTER_AUTO_START].InnerText);
                    }
                    
                    if (element[SPLIT_CRITERIA] != null)
                    {
                        SplitCriteria = (EnSplitCriteria)Enum.Parse(typeof(EnSplitCriteria), element[SPLIT_CRITERIA].InnerText);
                    }
                    
                    if (element[GENERATE_WITH_ICONS] != null)
                    {
                        GenerateWithIcons = bool.Parse(element[GENERATE_WITH_ICONS].InnerText);
                    }

                    if (element[SPLIT_CAMPAIGN_AREAS] != null)
                    {
                        XmlElement campaignAreasElement = element[SPLIT_CAMPAIGN_AREAS];
                    }
                    
                    if (element[SPLIT_LEVELS] != null)
                    {
                        foreach (XmlNode child in element[SPLIT_LEVELS].GetElementsByTagName(SPLIT_LEVEL))
                        {
                            SplitLevels.Add(Int32.Parse(child.InnerText));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        // TODO the SplitCampaignAreas logic here feels out of place
        private XmlElement SerializeCampaignAreas(XmlDocument document)
        {
            XmlElement parent = SettingsHelper.ToElement(document, SPLIT_CAMPAIGN_AREAS, (string)null);

            SplitCampaignAreas.Clear();
            
            if (SplitCriteria == EnSplitCriteria.CampaignAnyPercent)
            {
                foreach (CampaignArea campaignArea in CampaignArea.CampaignAnyPercentAreas)
                {
                    if (CampaignArea.CampaignAnyPercentAreas.Contains(campaignArea))
                    {
                        SettingsHelper.CreateSetting(document, parent, SPLIT_CAMPAIGN_AREA, campaignArea.Serialize());
                        SplitCampaignAreas.Add(campaignArea);
                    }
                }
            }
            else if (SplitCriteria == EnSplitCriteria.CampaignFull)
            {
                foreach(CampaignArea campaignArea in CampaignArea.CampaignFullAreas)
                {
                    if (CampaignArea.CampaignFullAreas.Contains(campaignArea))
                    {
                        SettingsHelper.CreateSetting(document, parent, SPLIT_CAMPAIGN_AREA, campaignArea.Serialize());
                        SplitCampaignAreas.Add(campaignArea);
                    }
                }
            }

            return parent;
        }
        
        private XmlElement SerializeLevels(XmlDocument document)
        {
            XmlElement parent = SettingsHelper.ToElement(document, SPLIT_LEVELS, (string)null);
            
            foreach (int level in SplitLevels)
            {
                SettingsHelper.CreateSetting(document, parent, SPLIT_LEVEL, level);
            }
            
            return parent;
        }
        
        private HashSet<string> DeserializeCampaignAreas(XmlElement element)
        {
            HashSet<string> zones = new HashSet<string>();
            foreach (XmlNode child in element.GetElementsByTagName(SPLIT_CAMPAIGN_AREA))
            {
                zones.Add(child.InnerText);
            }
            return zones;
        }
    }
}
