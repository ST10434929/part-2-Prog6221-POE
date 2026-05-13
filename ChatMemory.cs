using System.Collections.Generic;

namespace CybersecurityAwarenessBotGUI
{
    public class ChatMemory
    {
        private List<string> messages = new List<string>();

        public void Store(string msg)
        {
            messages.Add(msg);
        }

        public string GetLast()
        {
            if (messages.Count == 0)
                return "Nothing stored yet.";

            return messages[messages.Count - 1];
        }
    }
}
