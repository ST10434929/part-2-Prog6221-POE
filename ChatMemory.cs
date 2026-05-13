using System.Collections.Generic;

namespace CybersecurityAwarenessBotGUI
{
    public class ChatMemory
    {
        private List<string> messages = new List<string>();
        private string userName = "User";

        public void Store(string msg)
        {
            messages.Add(msg);
        }

        public void SetName(string name)
        {
            userName = name;
        }

        public string GetName()
        {
            return userName;
        }
    }
}