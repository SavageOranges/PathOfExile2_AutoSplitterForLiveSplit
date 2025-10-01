using LiveSplit.PathOfExile2AutoSplitter.Component.Enums;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.DTOs
{
    public class CampaignAreaDto
    {
        public string AreaId { get; set; }
        public string AreaName { get; set; }
        public EnIconType IconType { get; set; }
        public bool IsMandatory { get; set; }
    }
}