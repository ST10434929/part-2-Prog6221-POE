using System;

namespace CybersecurityAwarenessBotGUI
{
    public class BotEngine
    {
        private ChatMemory memory = new ChatMemory();
        private ResponseBank responses = new ResponseBank();

        public string Process(string input)
        {
            memory.Store(input);

            // SENTIMENT DETECTION
            if (input.Contains("worried"))
                return "It's okay to feel worried. Let me help you step by step.";

            if (input.Contains("frustrated"))
                return "I understand — cybersecurity can be confusing.";

            if (input.Contains("curious"))
                return "Great! Let’s explore cybersecurity together.";

            // MEMORY
            if (input.Contains("my name is"))
            {
                string name = input.Replace("my name is", "").Trim();
                memory.SetName(name);
                return $"Nice to meet you, {name}!";
            }

            if (input.Contains("what is my name"))
                return "Your name is " + memory.GetName();

            // KEYWORDS + RANDOM RESPONSES
            if (input.Contains("password"))
                return responses.GetRandom("password");

            if (input.Contains("phishing"))
                return responses.GetRandom("phishing");

            if (input.Contains("scam"))
                return responses.GetRandom("scam");

            if (input.Contains("privacy"))
                return responses.GetRandom("privacy");
