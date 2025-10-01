using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LiveSplit.Model;
using LiveSplit.PathOfExile2AutoSplitter.Component.Constants;
using LiveSplit.PathOfExile2AutoSplitter.Component.Enums;
using LiveSplit.PathOfExile2AutoSplitter.Component.Settings;
using LiveSplit.PathOfExile2AutoSplitter.Component.Timer;
using LiveSplit.PathOfExile2AutoSplitter.Component.UI;
using LiveSplit.PathOfExile2AutoSplitter.Properties;

namespace LiveSplit.PathOfExile2AutoSplitter.Component
{
    partial class SettingsControl : UserControl
    {
        private ComponentSettings _settings;
        private LiveSplitState _state;

        public SettingsControl(ComponentSettings settings, LiveSplitState state)
        {
            _settings = settings;
            _state = state;
            
            InitializeComponent();
            XmlRefresh();
        }

        public void XmlRefresh()
        {
            checkAutoSplit.Checked = _settings.AutoSplitEnabled;
            //checkLoadRemoval.Checked = settings.LoadRemovalEnabled;
            textBoxLogLocation.Text = _settings.LogLocation;
            radioCampaignFull.Checked = _settings.SplitCriteria == EnSplitCriteria.CampaignFull;
            radioCampaignMandatory.Checked = _settings.SplitCriteria == EnSplitCriteria.CampaignAnyPercent;
            radioLevel.Checked = _settings.SplitCriteria == EnSplitCriteria.Level;

            UpdateSplitCriteria();
        }

        private void HandleAutoSplitChanged(object sender, EventArgs e)
        {
            _settings.AutoSplitEnabled = checkAutoSplit.Checked;
        }

        private void HandleFreshCharacterAutoStart(object sender, EventArgs e)
        {
            _settings.AutoStartEnabled = checkAutoStart.Checked;
        }

        private void HandleSplitCriteriaChanged(object sender, EventArgs e)
        {
            if (radioCampaignFull.Checked)
            {
                // Populate only mandatory campaign zones
                _settings.SplitCriteria = EnSplitCriteria.CampaignFull;
            }
            
            else if (radioCampaignMandatory.Checked)
            {
                // Populate entire campaign
                _settings.SplitCriteria = EnSplitCriteria.CampaignAnyPercent;
            }
            
            else if(radioLevel.Checked)
            {
                // Populate Levels
                _settings.SplitCriteria = EnSplitCriteria.Level;
            }

            UpdateSplitCriteria();
        }

        private void HandleGenerateSplits(object sender, EventArgs e)
        {
            if (_state.CurrentPhase != TimerPhase.NotRunning)
            {
                MessageBox.Show(
                    DialogMessages.TimerRunning.Message,
                    DialogMessages.TimerRunning.Title, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                
                return;
            }
            
            if (MessageBox.Show(DialogMessages.ConfirmOverwrite.Message, 
                    DialogMessages.ConfirmOverwrite.Title,
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }
            
            _state.Run.Clear();
            
            for (int i = 0; i < checkedSplitList.Items.Count; i++)
            {
                if (checkedSplitList.GetItemChecked(i))
                {
                    object selectedItem = checkedSplitList.Items[i];
                    Image icon = null;

                    if (selectedItem is CampaignArea)
                    {
                        CampaignArea area = (CampaignArea)selectedItem;

                        if (_settings.GenerateWithIcons)
                        {
                            icon = GetIconForType(area.IconType);
                        }
                        
                        _state.Run.AddSegment(selectedItem.ToString(), default(Time), default(Time), icon);
                    }
                    else
                    {
                        icon = GetIconForType(EnIconType.Level);
                        _state.Run.AddSegment(selectedItem.ToString(), default(Time), default(Time), icon);
                    }
                }
            }

            if (_state.Run.Count == 0)
            {
                _state.Run.AddSegment("");
            }

            _state.Run.HasChanged = true;
            _state.Form.Invalidate();

            MessageBox.Show(DialogMessages.Success.Message, 
                DialogMessages.Success.Title,
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private Image GetIconForType(EnIconType iconType)
        {
            switch (iconType)
            {
                case EnIconType.Town:
                    return Resources.Town_WorldMapIcon;
                case EnIconType.Waypoint:
                    return Resources.Waypoint_WorldMapIcon;
                case EnIconType.NoWaypoint:
                    return Resources.NoWaypoint_WorldMapIcon;
                case EnIconType.InteriorWaypoint:
                    return Resources.InteriorWaypoint_WorldMapIcon;
                case EnIconType.InteriorNoWaypoint:
                    return Resources.InteriorNoWaypoint_WorldMapIcon;
                case EnIconType.Level:
                    return Resources.LevelUp_Icon;
            }

            return Resources.Waypoint_WorldMapIcon; // Default
        }
        
        private void HandleIconsChecked(object sender, EventArgs e)
        {
            _settings.GenerateWithIcons = checkWithIcons.Checked;
        }
        
        private void HandleSelectAll(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedSplitList.Items.Count; i++)
            {
                checkedSplitList.SetItemChecked(i, checkSelectAll.Checked);
            }
        }

        private void HandleLogLocationChanged(object sender, EventArgs e)
        {
            _settings.LogLocation = textBoxLogLocation.Text;
        }

        private void HandleBrowseClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Force a restriction to Client.txt file
                string selectedFile = openFileDialog.FileName;
                string fileName = Path.GetFileName(selectedFile);

                if (!string.Equals(fileName, "Client.txt", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        DialogMessages.LogFileIncorrectName.Message,
                        DialogMessages.LogFileTestOk.Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                
                textBoxLogLocation.Text = openFileDialog.FileName;
            }
        }
        
        private void HandleTestClick(object sender, EventArgs e)
        {
            try
            {
                // Check for an empty Client.txt path
                if (string.IsNullOrWhiteSpace(_settings.LogLocation))
                {
                    MessageBox.Show(
                        DialogMessages.LogFileNoPath.Message,
                        DialogMessages.LogFileNoPath.Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                
                // Check that file path leads to a file named Client.txt 
                string fileName = Path.GetFileName(_settings.LogLocation);
                
                if (!string.Equals(fileName, "Client.txt", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        DialogMessages.LogFileIncorrectName.Message,
                        DialogMessages.LogFileIncorrectName.Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    
                    return;
                }
                
                // With above two conditions satisfied, check that we have the right permissions for the Client.txt file
                using (FileStream fs = new FileStream(
                    _settings.LogLocation,
                    FileMode.Open,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite))
                { }

                MessageBox.Show(
                    DialogMessages.LogFileTestOk.Message, 
                    DialogMessages.LogFileTestOk.Title,
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogMessages.LogFileTestOk.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UpdateSplitCriteria()
        {
            // Clear the list to handle radio selection change
            checkedSplitList.Items.Clear();

            switch (_settings.SplitCriteria)
            {
                case EnSplitCriteria.CampaignAnyPercent:
                    foreach (CampaignArea campaignArea in CampaignArea.CampaignAnyPercentAreas)
                    {
                        checkedSplitList.Items.Add(campaignArea, checkSelectAll.Checked);
                    }
                    break;
                
                case EnSplitCriteria.CampaignFull:
                    foreach (CampaignArea campaignArea in CampaignArea.CampaignFullAreas)
                    {
                        checkedSplitList.Items.Add(campaignArea, checkSelectAll.Checked);
                    }
                    break;
                
                case EnSplitCriteria.Level:
                    for (int i = 2; i <= 100; i++)
                    {
                        checkedSplitList.Items.Add(new LevelLabel(i), checkSelectAll.Checked);
                    }
                    break;
            }
        }

        private void HandleItemChecked(object sender, ItemCheckEventArgs e)
        {
            object selectedItem = checkedSplitList.Items[e.Index];

            if (_settings.SplitCriteria == EnSplitCriteria.CampaignFull ||
                _settings.SplitCriteria == EnSplitCriteria.CampaignAnyPercent)
            {
                if (selectedItem is ICampaignArea)
                {
                    ICampaignArea campaignArea = (ICampaignArea)selectedItem;
                    
                    if (e.NewValue == CheckState.Checked)
                    {
                        _settings.SplitCampaignAreas.Add(campaignArea);
                    }
                    else
                    {
                        _settings.SplitCampaignAreas.Remove(campaignArea);
                    }
                }
            }
            else if (_settings.SplitCriteria == EnSplitCriteria.Level)
            {
                LevelLabel level = (LevelLabel)selectedItem;
                
                if (e.NewValue == CheckState.Checked)
                {
                    _settings.SplitLevels.Add(level.Level);
                }
                else
                {
                    _settings.SplitLevels.Remove(level.Level);
                }
            }
        }
    }
}
