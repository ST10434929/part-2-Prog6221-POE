using System;
using System.Media;
using System.Windows.Forms;

namespace CybersecurityAwarenessBotGUI
{
    public partial class Form1 : Form
    {
        private BotEngine bot = new BotEngine();

        private RichTextBox chat;
        private TextBox input;
        private Button send;

        public Form1()
        {
            InitializeComponent();

            Text = "Cybersecurity Awareness Bot";
            Width = 800;
            Height = 600;

            chat = new RichTextBox() { Width = 750, Height = 400, Top = 10, Left = 10, ReadOnly = true };
            input = new TextBox() { Width = 600, Top = 420, Left = 10 };
            send = new Button() { Text = "Send", Top = 420, Left = 620 };

            send.Click += Send_Click;

            Controls.Add(chat);
            Controls.Add(input);
            Controls.Add(send);

            // Voice greeting
            try
            {
                new SoundPlayer("greeting.wav").Play();
            }
            catch { }

            chat.AppendText("Bot: Hello! Ask me anything about cybersecurity.\n\n");
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string msg = input.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(msg))
                return;

            chat.AppendText("You: " + msg + "\n");

            string response = bot.Process(msg);

            chat.AppendText("Bot: " + response + "\n\n");

            input.Clear();
        }
    }
}