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
