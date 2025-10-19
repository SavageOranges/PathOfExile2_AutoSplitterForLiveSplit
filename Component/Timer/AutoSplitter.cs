using System;
using System.Collections.Generic;
using System.Linq;
using LiveSplit.Model;
using LiveSplit.PathOfExile2AutoSplitter.Component.ClientLog;
using LiveSplit.PathOfExile2AutoSplitter.Component.Enums;
using LiveSplit.PathOfExile2AutoSplitter.Component.Settings;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.Timer
{
    public class AutoSplitter : IClientEventHandler
    {
        private ComponentSettings _settings;
        private ITimerModel _timer;

        private long loadTimes = 0;
        private long? startTimestamp;
        
        private HashSet<ICampaignArea> encounteredCampaignAreas = new HashSet<ICampaignArea>();
        private HashSet<int> levelsReached = new HashSet<int>();
        
        private ICampaignArea _previousCampaignArea;

        public AutoSplitter(ITimerModel timer, ComponentSettings settings)
        {
            _settings = settings;
            _timer = timer;

            _timer.CurrentState.OnStart += HandleResetRuns;
        }

        public void HandleLoadStart(long timestamp)
        {
            if (_settings.LoadRemovalEnabled)
            {
                _timer.CurrentState.IsGameTimePaused = true;
                startTimestamp = timestamp;
            }
        }

        public void HandleLoadEnd(long timestamp, string areaId)
        {
            if (_settings.LoadRemovalEnabled)
            {
                loadTimes += timestamp - startTimestamp.GetValueOrDefault(timestamp);
                _timer.CurrentState.IsGameTimePaused = false;
                _timer.CurrentState.LoadingTimes = TimeSpan.FromMilliseconds(loadTimes);
            }

            ICampaignArea campaignArea = CampaignArea.Parse(areaId, encounteredCampaignAreas);

            if (_settings.AutoSplitEnabled)
            {
                // Automatically start the timer when player enters The Riverbank
                if (campaignArea.Serialize() == "The Riverbank" && _settings.AutoStartEnabled)
                {
                    _timer.Start();
                    encounteredCampaignAreas.Add(campaignArea);
                    
                    return;
                }
                
                // Check if we should Split when the player enters a new area
                if (ShouldSplitForCriteriaArea(campaignArea))
                {
                    _timer.Split();
                }

                if (campaignArea.ToString() == "The Ziggurat Refuge")
                {
                    // Additional Split() call to end the run
                    _timer.Split();
                }
                
                encounteredCampaignAreas.Add(campaignArea);
            }
            
            _previousCampaignArea = campaignArea;
        }

        // TODO implement non-linear splits
        private void HandleAutoSplit(ICampaignArea campaignArea)
        {
            var run = _timer.CurrentState.Run;
            var targetSegment = run.FirstOrDefault(x => x.Name == campaignArea.ToString());

            if (targetSegment != null)
            {
                var gameTime = _timer.CurrentState.CurrentTime;
                
                // Move timer index to matching row for the target segment
                _timer.CurrentState.CurrentSplitIndex = run.IndexOf(targetSegment);
                
                targetSegment.SplitTime = new Time(
                    _timer.CurrentState.CurrentTime.RealTime,
                    _timer.CurrentState.CurrentTime.GameTime
                );
                
                _timer.CurrentState.CallComparisonRenamed(EventArgs.Empty);
            }
        }
        
        private bool ShouldSplitForCriteriaArea(ICampaignArea campaignArea)
        {
            // If our splits don't have this zone (ie. AnyPercent), don't split the timer
            if (!_settings.SplitCampaignAreas.Contains(campaignArea))
            {
                return false;
            }
            
            // If our splits have the zone and we haven't already encountered it, split the timer
            if (!encounteredCampaignAreas.Contains(campaignArea))
            {
                return true;
            }

            return false;
        }

        private bool IsCampaignProgressionSplitCriteriaMet()
        {
            return _settings.SplitCriteria == EnSplitCriteria.CampaignAnyPercent ||
                    _settings.SplitCriteria == EnSplitCriteria.CampaignFull;
        }
        
        public void HandleLevelUp(long timestamp, int level)
        {
            if (!levelsReached.Contains(level) && LevelsToSplitOn().Contains(level))
            {
                _timer.Split();
            }
            
            levelsReached.Add(level);
        }
        
        private HashSet<int> LevelsToSplitOn()
        {
            if (!_settings.AutoSplitEnabled)
            {
                return new HashSet<int>();
            }

            if (_settings.SplitCriteria == EnSplitCriteria.Level)
            {
                return _settings.SplitLevels;
            }
            
            return new HashSet<int>();
        }
        
        // TODO Implement a boss rush setting :)
        public void HandleBossDialogue(long timestamp, string dialogue)
        {
            throw new NotImplementedException();
        }
        
        private void HandleResetRuns(object sender, EventArgs e)
        {
            loadTimes = 0;
            startTimestamp = null;
            encounteredCampaignAreas = new HashSet<ICampaignArea>();
            levelsReached = new HashSet<int>();
        }
    }
}