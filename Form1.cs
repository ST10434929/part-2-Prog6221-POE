using System;
using System.Media;
using System.Windows.Forms;

namespace CybersecurityAwarenessBotGUI
{
    public partial class Form1 : Form
    {
        private RichTextBox rtbChat;
        private TextBox txtUserInput;
        private Button btnSend;

        public Form1()
        {
            InitializeComponent();

            // FORM SETTINGS
            this.Text = "Cybersecurity Awareness Bot";
            this.Width = 800;
            this.Height = 600;

            // CHAT BOX
            rtbChat = new RichTextBox();
            rtbChat.Width = 750;
            rtbChat.Height = 400;
            rtbChat.Top = 10;
            rtbChat.Left = 10;
            rtbChat.ReadOnly = true;

            // INPUT BOX
            txtUserInput = new TextBox();
            txtUserInput.Width = 600;
            txtUserInput.Top = 420;
            txtUserInput.Left = 10;

            // BUTTON
            btnSend = new Button();
            btnSend.Text = "Send";
            btnSend.Top = 418;
            btnSend.Left = 620;
            btnSend.Click += BtnSend_Click;

            // ADD CONTROLS
            this.Controls.Add(rtbChat);
            this.Controls.Add(txtUserInput);
            this.Controls.Add(btnSend);

            // VOICE GREETING 
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Play();
            }
            catch
            {
                MessageBox.Show("Voice file not found or cannot play.");
            }

            // WELCOME MESSAGE
            rtbChat.AppendText("Cybersecurity Awareness Bot Started...\n");
            rtbChat.AppendText("Ask me about passwords, phishing, scams, privacy.\n\n");
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string input = txtUserInput.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please type something.");
                return;
            }

            rtbChat.AppendText("You: " + input + "\n");

            string response = GetResponse(input);

            rtbChat.AppendText("Bot: " + response + "\n\n");

            txtUserInput.Clear();
        }
        private string GetResponse(string input)
        {
            // SENTIMENT DETECTION
            if (input.Contains("worried"))
                return "It's okay to feel worried. Let me help you stay safe online.";

            if (input.Contains("frustrated"))
                return "Cybersecurity can be confusing, but I’ll guide you step by step.";

            if (input.Contains("curious"))
                return "Great! Curiosity helps you stay safe online.";

            // KEYWORD RESPONSES
            if (input.Contains("password"))
                return "Use strong passwords with numbers, symbols, and letters.";

            if (input.Contains("phishing"))
                return "Phishing is when scammers trick you into giving personal info.";

            if (input.Contains("privacy"))
                return "Keep your personal information private online.";

            if (input.Contains("scam"))
                return "Never trust unknown messages asking for money or info.";

            if (input.Contains("malware"))
                return "Avoid downloading files from untrusted sources.";

            if (input.Contains("vpn"))
                return "A VPN helps protect your internet connection.";

            // FOLLOW-UP FLOW
            if (input.Contains("tell me more") || input.Contains("another tip"))
                return "Sure! Always double-check links before clicking.";

            // DEFAULT RESPONSE
            return "I’m not sure about that. Try asking about passwords, phishing, scams, or privacy.";
        }
    }
}