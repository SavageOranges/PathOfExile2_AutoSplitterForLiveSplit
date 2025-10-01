using System;
using System.Collections.Generic;
using LiveSplit.PathOfExile2AutoSplitter.Component.Constants;
using LiveSplit.PathOfExile2AutoSplitter.Component.DTOs;
using LiveSplit.PathOfExile2AutoSplitter.Component.Enums;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.Timer
{
    public class CampaignArea : ICampaignArea
    {
        // Campaign area fields
        public string AreaId;
        public string AreaName;
        public EnIconType IconType { get; set; }
        public bool IsMandatory { get; set; }
        
        // Campaign area lists for splits and lookups
        public static readonly List<CampaignArea> CampaignAnyPercentAreas;
        public static readonly List<CampaignArea> CampaignFullAreas;
        public static readonly Dictionary<string, CampaignArea> CampaignAreaLookup;
        
        static CampaignArea()
        {
            CampaignAnyPercentAreas = new List<CampaignArea>();
            CampaignFullAreas = new List<CampaignArea>();
            CampaignAreaLookup = new Dictionary<string, CampaignArea>();
            
            // Act 1 Areas
            AddCampaignArea(CampaignAreas.TheRiverbank);
            AddCampaignArea(CampaignAreas.ClearfellEncampment);
            AddCampaignArea(CampaignAreas.Clearfell);
            AddCampaignArea(CampaignAreas.MudBurrow);
            AddCampaignArea(CampaignAreas.TheGrelwood);
            AddCampaignArea(CampaignAreas.TheRedVale);
            AddCampaignArea(CampaignAreas.TheGrimTangle);
            AddCampaignArea(CampaignAreas.CemeteryOfTheEternals);
            AddCampaignArea(CampaignAreas.TombOfTheConsort);
            AddCampaignArea(CampaignAreas.MausoleumOfThePraetor);
            AddCampaignArea(CampaignAreas.HuntingGrounds);
            AddCampaignArea(CampaignAreas.OghamFarmlands);
            AddCampaignArea(CampaignAreas.OghamVillage);
            AddCampaignArea(CampaignAreas.TheManorRamparts);
            AddCampaignArea(CampaignAreas.OghamManor);
            AddCampaignArea(CampaignAreas.Freythorn);
            
            // Act 2 Areas
            AddCampaignArea(CampaignAreas.VastiriOutskirts);
            AddCampaignArea(CampaignAreas.TheArduraCaravan);
            AddCampaignArea(CampaignAreas.MawdunQuarry);
            AddCampaignArea(CampaignAreas.MawdunMine);
            AddCampaignArea(CampaignAreas.TraitorsPassage);
            AddCampaignArea(CampaignAreas.TheHalaniGates);
            AddCampaignArea(CampaignAreas.Keth);
            AddCampaignArea(CampaignAreas.TheLostCity);
            AddCampaignArea(CampaignAreas.BuriedShrines);
            AddCampaignArea(CampaignAreas.MastodonBadlands);
            
            // ----- Abyss League ----- //
            AddCampaignArea(CampaignAreas.LightlessPassage);
            AddCampaignArea(CampaignAreas.TheWellOfSouls);
            // ----- End ----- //
            
            AddCampaignArea(CampaignAreas.TheBonePits);
            AddCampaignArea(CampaignAreas.ValleyOfTheTitans);
            AddCampaignArea(CampaignAreas.TheTitanGrotto);
            AddCampaignArea(CampaignAreas.Deshar);
            AddCampaignArea(CampaignAreas.PathOfMourning);
            AddCampaignArea(CampaignAreas.TheSpiresOfDeshar);
            AddCampaignArea(CampaignAreas.TrialOfTheSekhemas);
            AddCampaignArea(CampaignAreas.TheDreadnought);
            AddCampaignArea(CampaignAreas.DreadnoughtVanguard);
            
            // Act 3 Areas
            AddCampaignArea(CampaignAreas.SandsweptMarsh);
            AddCampaignArea(CampaignAreas.ZigguratEncampment);
            AddCampaignArea(CampaignAreas.JungleRuins);
            AddCampaignArea(CampaignAreas.TheVenomCrypts);
            AddCampaignArea(CampaignAreas.InfestedBarrens);
            AddCampaignArea(CampaignAreas.AzakBog);
            AddCampaignArea(CampaignAreas.ChimeralWetlands);
            AddCampaignArea(CampaignAreas.JiquanisMachinarium);
            AddCampaignArea(CampaignAreas.JiquanisSanctum);
            AddCampaignArea(CampaignAreas.TheMatlanWaterways);
            AddCampaignArea(CampaignAreas.TheDrownedCity);
            AddCampaignArea(CampaignAreas.TheMoltenVault);
            AddCampaignArea(CampaignAreas.ApexOfFilth);
            AddCampaignArea(CampaignAreas.TempleOfKopec);
            AddCampaignArea(CampaignAreas.TheTempleOfChaos);
            AddCampaignArea(CampaignAreas.Utzaal);
            AddCampaignArea(CampaignAreas.Aggorat);
            AddCampaignArea(CampaignAreas.TheBlackChambers);
                 
            // Act 4 Areas
            AddCampaignArea(CampaignAreas.Kingsmarch);
            AddCampaignArea(CampaignAreas.IsleOfKin);
            AddCampaignArea(CampaignAreas.VolcanicWarrens);
            AddCampaignArea(CampaignAreas.EyeOfHinekora);
            AddCampaignArea(CampaignAreas.HallsOfTheDead);
            AddCampaignArea(CampaignAreas.TrialOfTheAncestors);
            AddCampaignArea(CampaignAreas.KedgeBay);
            AddCampaignArea(CampaignAreas.JourneysEnd);
            AddCampaignArea(CampaignAreas.AbandonedPrison);
            AddCampaignArea(CampaignAreas.SolitaryConfinement);
            AddCampaignArea(CampaignAreas.WhakapanuIsland);
            AddCampaignArea(CampaignAreas.SingingCaverns);
            AddCampaignArea(CampaignAreas.ShrikeIsland);
            AddCampaignArea(CampaignAreas.PlundersPoint);
            AddCampaignArea(CampaignAreas.Arastas);
            AddCampaignArea(CampaignAreas.TheExcavation);
            AddCampaignArea(CampaignAreas.Ngakanu);
            AddCampaignArea(CampaignAreas.HeartOfTheTribe);
            
            // Interlude 1 Areas
            AddCampaignArea(CampaignAreas.TheRefuge);
            AddCampaignArea(CampaignAreas.ScorchedFarmlands);
            AddCampaignArea(CampaignAreas.StonesOfSerle);
            AddCampaignArea(CampaignAreas.TheBlackwood);
            AddCampaignArea(CampaignAreas.Holten);
            AddCampaignArea(CampaignAreas.Wolvenhold);
            AddCampaignArea(CampaignAreas.HoltenEstate);
            
            // Interlude 2 Areas
            AddCampaignArea(CampaignAreas.TheKhariBazaar);
            AddCampaignArea(CampaignAreas.TheKhariCrossing);
            AddCampaignArea(CampaignAreas.PoolsOfKhatal);
            AddCampaignArea(CampaignAreas.SelKhariSanctuary);
            AddCampaignArea(CampaignAreas.TheGalaiGates);
            AddCampaignArea(CampaignAreas.Qimah);
            AddCampaignArea(CampaignAreas.QimahReservoir);
            
            // Interlude 3 Areas
            AddCampaignArea(CampaignAreas.TheGlade);
            AddCampaignArea(CampaignAreas.AshenForest);
            AddCampaignArea(CampaignAreas.KriarVillage);
            AddCampaignArea(CampaignAreas.GlacialTarn);
            AddCampaignArea(CampaignAreas.HowlingCaves);
            AddCampaignArea(CampaignAreas.KriarPeaks);
            AddCampaignArea(CampaignAreas.EtchedRavine);
            AddCampaignArea(CampaignAreas.CuachicVault);
            
            // Endgame Area (Stop timer trigger)
            AddCampaignArea(CampaignAreas.TheZigguratRefuge);
        }
        
        private static void AddCampaignArea(CampaignAreaDto areaDto)
        {
            // Create a new CampaignArea object from the area DTO's data
            CampaignArea newArea = new CampaignArea(
                areaDto.AreaId, 
                areaDto.AreaName, 
                areaDto.IconType, 
                areaDto.IsMandatory
            );
            
            // Add it to the AnyPercentArea list
            CampaignFullAreas.Add(newArea);
            CampaignAreaLookup.Add(newArea.AreaId, newArea);

            if (newArea.IsMandatory)
            {
                CampaignAnyPercentAreas.Add(newArea);
            }
        }
        
        private CampaignArea(string areaId, string areaName, EnIconType iconType, bool isMandatory)
        {
            AreaId = areaId;
            AreaName = areaName;
            IconType = iconType;
            IsMandatory = isMandatory;
        }

        public static ICampaignArea Parse(string areaId, HashSet<ICampaignArea> encounteredCampaignAreas)
        {
            if (CampaignAreaLookup.TryGetValue(areaId, out CampaignArea campaignArea))
            {
                return campaignArea;
            }

            throw new ArgumentException($"Area ID {areaId} does not exist in the CampaignAreaLookup Dictionary.");
        }
        
        public string Serialize()
        {
            return AreaName;
        }

        public override string ToString()
        {
            return AreaName;
        }
    }
}