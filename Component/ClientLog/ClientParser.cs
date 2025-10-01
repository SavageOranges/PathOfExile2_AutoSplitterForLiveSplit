using System.Text.RegularExpressions;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.ClientLog
{
    public class ClientParser
    {
        // TODO Move to constants
        private static readonly string TIMESTAMP_SECTION = @"^[^ ]+ [^ ]+ (\d+)";

        private static readonly Regex START = new Regex(TIMESTAMP_SECTION + @".*Got Instance Details");

        private static readonly Regex AREA_NAME = new Regex(
            TIMESTAMP_SECTION + @".*Generating level \d+ area ""([^""]+)"""
        );

        private static readonly Regex LEVEL_UP = new Regex(TIMESTAMP_SECTION + @".* is now level (\d+)$");

        private IClientEventHandler _splitter;

        public ClientParser(IClientEventHandler splitter)
        {
            _splitter = splitter;
        }

        public void ProcessLine(string s)
        {
            
            Match match = START.Match(s);

            if (match.Success)
            {
                GroupCollection groups = match.Groups;
                _splitter.HandleLoadStart(long.Parse(groups[1].Value));
                return;
            }
            
            match = AREA_NAME.Match(s);

            if (match.Success)
            {
                GroupCollection groups = match.Groups;
                _splitter.HandleLoadEnd(long.Parse(groups[1].Value), groups[2].Value);
            }
            
            match = LEVEL_UP.Match(s);

            if (match.Success)
            {
                GroupCollection groups = match.Groups;
                _splitter.HandleLevelUp(long.Parse(groups[1].Value), int.Parse(groups[2].Value));
            }
            
            // TODO Add Boss Dialogue case
        }
    }
}
