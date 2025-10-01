namespace LiveSplit.PathOfExile2AutoSplitter.Component.ClientLog
{
    public interface IClientEventHandler
    {
        void HandleLoadStart(long timestamp);
        
        void HandleLoadEnd(long timestamp, string areaName);
        
        void HandleLevelUp(long timestamp, int level);
        
        void HandleBossDialogue(long timestamp, string dialogue);
    }
}
