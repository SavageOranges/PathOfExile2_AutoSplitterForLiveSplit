using LiveSplit.PathOfExile2AutoSplitter.Component.DTOs;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.Constants
{
    public static class DialogMessages
    {
        public static readonly DialogMessageDto TimerRunning = new DialogMessageDto()
        {
            Title = "Generate Splits",
            Message = "Splits cannot be changed while the timer is running or has not been reset."
        };
        
        public static readonly DialogMessageDto ConfirmOverwrite = new DialogMessageDto()
        {
            Title = "Confirm Generate Splits",
            Message = "Your current split segments will be overwritten.\nAre you sure you want to proceed?"
        };
        
        public static readonly DialogMessageDto Success = new DialogMessageDto()
        {
            Title = "Generate Splits",
            Message = "Splits generated successfully.\n\n" +
                      "The splits can be edited in the Splits Editor after saving and reopening.\n" +
                      "If the split names do not match the order of your zone progression, they can be " +
                      "reordered using that editor."
        };

        public static readonly DialogMessageDto LogFileTestOk = new DialogMessageDto()
        {
            Title = "Log file test",
            Message = "No problems found."
        };

        public static readonly DialogMessageDto LogFileNoPath = new DialogMessageDto()
        {
            Title = "Missing file path",
            Message = "Add the path to your Client.txt file."
        };
        
        public static readonly DialogMessageDto LogFileIncorrectName = new DialogMessageDto()
        {
            Title = "Invalid 'Client.txt' file",
            Message = "Only 'Client.txt' is a valid file name. Make sure you are selecting your Path of Exile 2 'Client.txt' file."
        };
    }
}