using LiveSplit.PathOfExile2AutoSplitter.Component.DTOs;
using LiveSplit.PathOfExile2AutoSplitter.Component.Enums;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.Constants
{
    public static class CampaignAreas
    {
        #region Act 1
        public static readonly CampaignAreaDto TheRiverbank = new CampaignAreaDto
        {
            AreaId = "G1_1",
            AreaName = "The Riverbank",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ClearfellEncampment = new CampaignAreaDto
        {
            AreaId = "G1_town",
            AreaName = "Clearfell Encampment",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Clearfell = new CampaignAreaDto
        {
            AreaId = "G1_2",
            AreaName = "Clearfell",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MudBurrow = new CampaignAreaDto
        {
            AreaId = "G1_3",
            AreaName = "Mud Burrow",
            IconType = EnIconType.InteriorNoWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TheGrelwood = new CampaignAreaDto
        {
            AreaId = "G1_4",
            AreaName = "The Grelwood",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheRedVale = new CampaignAreaDto
        {
            AreaId = "G1_5",
            AreaName = "The Red Vale",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheGrimTangle = new CampaignAreaDto
        {
            AreaId = "G1_6",
            AreaName = "The Grim Tangle",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto CemeteryOfTheEternals = new CampaignAreaDto
        {
            AreaId = "G1_7",
            AreaName = "Cemetery of the Eternals",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MausoleumOfThePraetor = new CampaignAreaDto
        {
            AreaId = "G1_8",
            AreaName = "Mausoleum of the Praetor",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TombOfTheConsort = new CampaignAreaDto
        {
            AreaId = "G1_9",
            AreaName = "Tomb of the Consort",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HuntingGrounds = new CampaignAreaDto
        {
            AreaId = "G1_11",
            AreaName = "Hunting Grounds",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Freythorn = new CampaignAreaDto
        {
            AreaId = "G1_12",
            AreaName = "Freythorn",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto OghamFarmlands = new CampaignAreaDto
        {
            AreaId = "G1_13_1",
            AreaName = "Ogham Farmlands",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto OghamVillage = new CampaignAreaDto
        {
            AreaId = "G1_13_2",
            AreaName = "Ogham Village",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheManorRamparts = new CampaignAreaDto
        {
            AreaId = "G1_14",
            AreaName = "The Manor Ramparts",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto OghamManor = new CampaignAreaDto
        {
            AreaId = "G1_15",
            AreaName = "Ogham Manor",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Act 2
        public static readonly CampaignAreaDto VastiriOutskirts = new CampaignAreaDto
        {
            AreaId = "G2_1",
            AreaName = "Vastiri Outskirts",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheArduraCaravan = new CampaignAreaDto
        {
            AreaId = "G2_town",
            AreaName = "The Ardura Caravan",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MawdunQuarry = new CampaignAreaDto
        {
            AreaId = "G2_10_1",
            AreaName = "Mawdun Quarry",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MawdunMine = new CampaignAreaDto
        {
            AreaId = "G2_10_2",
            AreaName = "Mawdun Mine",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TraitorsPassage = new CampaignAreaDto
        {
            AreaId = "G2_2",
            AreaName = "Traitor's Passage",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheHalaniGates = new CampaignAreaDto
        {
            AreaId = "G2_3",
            AreaName = "The Halani Gates",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Keth = new CampaignAreaDto
        {
            AreaId = "G2_4_1",
            AreaName = "Keth",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheLostCity = new CampaignAreaDto
        {
            AreaId = "G2_4_2",
            AreaName = "The Lost City",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto BuriedShrines = new CampaignAreaDto
        {
            AreaId = "G2_4_3",
            AreaName = "Buried Shrines",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto MastodonBadlands = new CampaignAreaDto
        {
            AreaId = "G2_5_1",
            AreaName = "Mastodon Badlands",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        // ----- Abyss League ----- //
        public static readonly CampaignAreaDto LightlessPassage = new CampaignAreaDto
        {
            AreaId = "Abyss_Intro",
            AreaName = "Lightless Passage",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TheWellOfSouls = new CampaignAreaDto
        {
            AreaId = "Abyss_Hub",
            AreaName = "The Well of Souls",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = false
        };
        // ----- End ----- //
        
        public static readonly CampaignAreaDto TheBonePits = new CampaignAreaDto
        {
            AreaId = "G2_5_2",
            AreaName = "The Bone Pits",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ValleyOfTheTitans = new CampaignAreaDto
        {
            AreaId = "G2_6",
            AreaName = "Valley of the Titans",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheTitanGrotto = new CampaignAreaDto
        {
            AreaId = "G2_7",
            AreaName = "The Titan Grotto",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Deshar = new CampaignAreaDto
        {
            AreaId = "G2_8",
            AreaName = "Deshar",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto PathOfMourning = new CampaignAreaDto
        {
            AreaId = "G2_9_1",
            AreaName = "Path of Mourning",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheSpiresOfDeshar = new CampaignAreaDto
        {
            AreaId = "G2_9_2",
            AreaName = "The Spires of Deshar",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheDreadnought = new CampaignAreaDto
        {
            AreaId = "G2_12_1",
            AreaName = "The Dreadnought",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto DreadnoughtVanguard = new CampaignAreaDto
        {
            AreaId = "G2_12_2",
            AreaName = "Dreadnought Vanguard",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TrialOfTheSekhemas = new CampaignAreaDto
        {
            AreaId = "G2_13",
            AreaName = "Trial of the Sekhemas",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Act 3
        public static readonly CampaignAreaDto SandsweptMarsh = new CampaignAreaDto
        {
            AreaId = "G3_1",
            AreaName = "Sandswept Marsh",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ZigguratEncampment = new CampaignAreaDto
        {
            AreaId = "G3_town",
            AreaName = "Ziggurat Encampment",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto JungleRuins = new CampaignAreaDto
        {
            AreaId = "G3_3",
            AreaName = "Jungle Ruins",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheVenomCrypts = new CampaignAreaDto
        {
            AreaId = "G3_4",
            AreaName = "The Venom Crypts",
            IconType = EnIconType.InteriorNoWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto InfestedBarrens = new CampaignAreaDto
        {
            AreaId = "G3_2_1",
            AreaName = "Infested Barrens",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto AzakBog = new CampaignAreaDto
        {
            AreaId = "G3_7",
            AreaName = "The Azak Bog",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto ChimeralWetlands = new CampaignAreaDto
        {
            AreaId = "G3_5",
            AreaName = "Chimeral Wetlands",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto JiquanisMachinarium = new CampaignAreaDto
        {
            AreaId = "G3_6_1",
            AreaName = "Jiquani's Machinarium",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto JiquanisSanctum = new CampaignAreaDto
        {
            AreaId = "G3_6_2",
            AreaName = "Jiquani's Sanctum",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheMatlanWaterways = new CampaignAreaDto
        {
            AreaId = "G3_2_2",
            AreaName = "The Matlan Waterways",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheDrownedCity = new CampaignAreaDto
        {
            AreaId = "G3_8",
            AreaName = "The Drowned City",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheMoltenVault = new CampaignAreaDto
        {
            AreaId = "G3_9",
            AreaName = "The Molten Vault",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto ApexOfFilth = new CampaignAreaDto
        {
            AreaId = "G3_11",
            AreaName = "Apex of Filth",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TempleOfKopec = new CampaignAreaDto
        {
            AreaId = "G3_12",
            AreaName = "Temple of Kopec",
            IconType = EnIconType.InteriorNoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Utzaal = new CampaignAreaDto
        {
            AreaId = "G3_14",
            AreaName = "Utzaal",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Aggorat = new CampaignAreaDto
        {
            AreaId = "G3_16",
            AreaName = "Aggorat",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheBlackChambers = new CampaignAreaDto
        {
            AreaId = "G3_17",
            AreaName = "The Black Chambers",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheTempleOfChaos = new CampaignAreaDto
        {
            AreaId = "G3_10_Airlock",
            AreaName = "The Temple of Chaos",
            IconType = EnIconType.InteriorWaypoint,
            IsMandatory = true
        };
        
        #endregion
        
        #region Act 4
        public static readonly CampaignAreaDto Kingsmarch = new CampaignAreaDto
        {
            AreaId = "G4_town",
            AreaName = "Kingsmarch",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto IsleOfKin = new CampaignAreaDto
        {
            AreaId = "G4_1_1",
            AreaName = "Isle of Kin",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto VolcanicWarrens = new CampaignAreaDto
        {
            AreaId = "G4_1_2",
            AreaName = "Volcanic Warrens",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto EyeOfHinekora = new CampaignAreaDto
        {
            AreaId = "G4_4_1",
            AreaName = "Eye of Hinekora",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto HallsOfTheDead = new CampaignAreaDto
        {
            AreaId = "G4_4_2",
            AreaName = "Halls of the Dead",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TrialOfTheAncestors = new CampaignAreaDto
        {
            AreaId = "G4_4_3",
            AreaName = "Trial of the Ancestors",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto KedgeBay = new CampaignAreaDto
        {
            AreaId = "G4_2_1",
            AreaName = "Kedge Bay",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto JourneysEnd = new CampaignAreaDto
        {
            AreaId = "G4_2_2",
            AreaName = "Journey's End",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto AbandonedPrison = new CampaignAreaDto
        {
            AreaId = "G4_5_1",
            AreaName = "Abandoned Prison",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto SolitaryConfinement = new CampaignAreaDto
        {
            AreaId = "G4_5_2",
            AreaName = "Solitary Confinement",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto WhakapanuIsland = new CampaignAreaDto
        {
            AreaId = "G4_3_1",
            AreaName = "Whakapanu Island",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto SingingCaverns = new CampaignAreaDto
        {
            AreaId = "G4_3_2",
            AreaName = "Singing Caverns",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ShrikeIsland = new CampaignAreaDto
        {
            AreaId = "G4_7",
            AreaName = "Shrike Island",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Arastas = new CampaignAreaDto
        {
            AreaId = "G4_8b",
            AreaName = "Arastas",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheExcavation = new CampaignAreaDto
        {
            AreaId = "G4_10",
            AreaName = "The Excavation",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Ngakanu = new CampaignAreaDto
        {
            AreaId = "G4_11_1b",
            AreaName = "Ngakanu",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HeartOfTheTribe = new CampaignAreaDto
        {
            AreaId = "G4_11_2",
            AreaName = "Heart of the Tribe",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto PlundersPoint = new CampaignAreaDto
        {
            AreaId = "G4_13",
            AreaName = "Plunder's Point",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        #endregion
        
        #region Interlude 1
        public static readonly CampaignAreaDto TheRefuge = new CampaignAreaDto
        {
            AreaId = "P1_Town",
            AreaName = "The Refuge",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto ScorchedFarmlands = new CampaignAreaDto
        {
            AreaId = "P1_1",
            AreaName = "Scorched Farmlands",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto StonesOfSerle = new CampaignAreaDto
        {
            AreaId = "P1_2",
            AreaName = "Stones of Serle",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheBlackwood = new CampaignAreaDto
        {
            AreaId = "P1_3",
            AreaName = "The Blackwood",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Holten = new CampaignAreaDto
        {
            AreaId = "P1_4",
            AreaName = "Holten",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Wolvenhold = new CampaignAreaDto
        {
            AreaId = "P1_5",
            AreaName = "Wolvenhold",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HoltenEstate = new CampaignAreaDto
        {
            AreaId = "P1_6",
            AreaName = "Holten Estate",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Interlude 2
        public static readonly CampaignAreaDto TheKhariBazaar = new CampaignAreaDto
        {
            AreaId = "P2_Town",
            AreaName = "The Khari Bazaar",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto TheKhariCrossing = new CampaignAreaDto
        {
            AreaId = "P2_1",
            AreaName = "The Khari Crossing",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto PoolsOfKhatal = new CampaignAreaDto
        {
            AreaId = "P2_2",
            AreaName = "Pools of Khatal",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto SelKhariSanctuary = new CampaignAreaDto
        {
            AreaId = "P2_3",
            AreaName = "Sel Khari Sanctuary",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto TheGalaiGates = new CampaignAreaDto
        {
            AreaId = "P2_5",
            AreaName = "The Galai Gates",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto Qimah = new CampaignAreaDto
        {
            AreaId = "P2_6",
            AreaName = "Qimah",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto QimahReservoir = new CampaignAreaDto
        {
            AreaId = "P2_7",
            AreaName = "Qimah Reservoir",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Interlude 3
        public static readonly CampaignAreaDto TheGlade = new CampaignAreaDto
        {
            AreaId = "P3_Town",
            AreaName = "The Glade",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto AshenForest = new CampaignAreaDto
        {
            AreaId = "P3_1",
            AreaName = "Ashen Forest",
            IconType = EnIconType.NoWaypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto KriarVillage = new CampaignAreaDto
        {
            AreaId = "P3_2",
            AreaName = "Kriar Village",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto GlacialTarn = new CampaignAreaDto
        {
            AreaId = "P3_3",
            AreaName = "Glacial Tarn",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto HowlingCaves = new CampaignAreaDto
        {
            AreaId = "P3_4",
            AreaName = "Howling Caves",
            IconType = EnIconType.Waypoint,
            IsMandatory = false
        };
        
        public static readonly CampaignAreaDto KriarPeaks = new CampaignAreaDto
        {
            AreaId = "P3_5",
            AreaName = "Kriar Peaks",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto EtchedRavine = new CampaignAreaDto
        {
            AreaId = "P3_6",
            AreaName = "Etched Ravine",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        
        public static readonly CampaignAreaDto CuachicVault = new CampaignAreaDto
        {
            AreaId = "P3_7",
            AreaName = "The Cuachic Vault",
            IconType = EnIconType.Waypoint,
            IsMandatory = true
        };
        #endregion
        
        #region Endgame
        public static readonly CampaignAreaDto TheZigguratRefuge = new CampaignAreaDto
        {
            AreaId = "G_Endgame_Town",
            AreaName = "The Ziggurat Refuge",
            IconType = EnIconType.Town,
            IsMandatory = true
        };
        #endregion
    }
}