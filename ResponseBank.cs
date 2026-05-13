using System;
using System.Collections.Generic;

namespace CybersecurityAwarenessBotGUI
{
    public class ResponseBank
    {
        private Random rand = new Random();

        private Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>()
        {
            {
                "password",
                new List<string>
                {
                    "Use strong passwords with symbols and numbers.",
                    "Never reuse passwords across accounts.",
                    "A good password should be at least 12 characters long."
                }
            },
            {
                "phishing",
                new List<string>
                {
                    "Check email addresses carefully before clicking links.",
                    "Phishing scams often pretend to be banks or companies.",
                    "Never enter details from suspicious links."
                }
            },
            {
                "scam",
                new List<string>
                {
                    "If it sounds too good to be true, it probably is.",
                    "Never send money to unknown contacts.",
                    "Scammers often pressure you to act quickly."
                }
            },
            {
                "privacy",
                new List<string>
                {
                    "Keep your personal information private online.",
                    "Adjust privacy settings on social media.",
                    "Avoid sharing location publicly."
                }
            }
        };

        public string GetRandom(string key)
        {
            var list = responses[key];
            return list[rand.Next(list.Count)];
        }

        public string GetGenericTip()
        {
            string[] tips =
            {
                "Always verify links before clicking.",
                "Keep your software updated.",
                "Enable two-factor authentication."
            };

            return tips[rand.Next(tips.Length)];
        }
    }
}