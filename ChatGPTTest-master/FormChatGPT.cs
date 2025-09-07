using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.VisualBasic;

namespace ChatGPTTest
{
    public partial class FormChatGPT : Form
    {
        private const string OpenAI_ApiUrl = "https://api.openai.com/v1/chat/completions";
        private const string OpenAI_ApiKey = "Your API Key"; // Replace with your OpenAI API Key
        private bool isLoggedIn = false;
        private List<Conversation> conversationHistory = new List<Conversation>();

        // Class to represent a conversation
        private class Conversation
        {
            public string UserQuery { get; set; }
            public string ChatGPTResponse { get; set; }
            public DateTime Timestamp { get; set; }

            public Conversation(string userQuery, string chatGPTResponse)
            {
                UserQuery = userQuery;
                ChatGPTResponse = chatGPTResponse;
                Timestamp = DateTime.Now;
            }

            public override string ToString()
            {
                return $"[{Timestamp:dd/MM/yyyy hh:mm:ss tt}] User: {UserQuery}\nChatGPT: {ChatGPTResponse}";
            }
        }

        public FormChatGPT()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webViewGPT.EnsureCoreWebView2Async();
            webViewGPT.CoreWebView2.NavigateToString(
                "<html>" +
                "<body style='background-color: #1e1e1e; color: white; display: flex; justify-content: center; align-items: center; height: 100%; margin: 0;'>" +
                "<h2 style='text-align: center;'>ChatGPT Response Will Appear Here...</h2>" +
                "</body></html>");
        }

        private void SetStatusMessage(string message)
        {
            toolStripStatusLabel1.Text = message;
        }

        private async void buttonAsk_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in with a valid Gmail ID to use the Ask feature.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SetStatusMessage("Please Wait..");
                string userMessage = textBoxQuery.Text.Trim();
                if (string.IsNullOrEmpty(userMessage))
                {
                    textBoxQuery.Clear();
                    return;
                }

                string chatResponse = await GetChatGPTResponse(userMessage);


                conversationHistory.Add(new Conversation(userMessage, chatResponse));

                string htmlResponse = $"<html>" +
                                     $"<body style='background-color: #1e1e1e; color: white; margin: 0; padding: 20px; height: 100%; overflow-y: auto;'>" +
                                     $"<div style='width: 100%; max-width: 928px; margin: 0 auto;'>" +
                                     $"<div style='text-align: right; margin-bottom: 20px;'>" +
                                     $"<h2 style='font-size: 16px; margin-bottom: 5px; display: inline-block; text-align: right;'>User:</h2>" +
                                     $"<p style='font-size: 14px; margin-top: 0; text-align: right;'>{userMessage}</p>" +
                                     $"</div>" +
                                     $"<div style='text-align: left; margin-bottom: 20px;'>" +
                                     $"<h2 style='font-size: 16px; margin-bottom: 5px; display: inline-block; text-align: left;'>ChatGPT:</h2>" +
                                     $"<p style='font-size: 14px; margin-top: 0; text-align: left;'>{chatResponse}</p>" +
                                     $"</div>" +
                                     $"</div></body></html>";

                webViewGPT.CoreWebView2.NavigateToString(htmlResponse);
                textBoxQuery.Clear();
                SetStatusMessage("Done..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuery.Clear();
            }
        }

        private async Task<string> GetChatGPTResponse(string message)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {OpenAI_ApiKey}");

                var request = new
                {
                    model = "gpt-4o-mini",
                    messages = new[] { new { role = "user", content = message } }
                };

                var response = await client.PostAsJsonAsync(OpenAI_ApiUrl, request);
                var result = await response.Content.ReadAsStringAsync();

                var jsonDoc = JsonDocument.Parse(result);
                var content = jsonDoc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

                return content ?? "Error: No response";
            }
        }

        private void FormChatGPT_Load(object sender, EventArgs e)
        {

        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    MessageBox.Show($"Selected File: {filePath}", "File Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Microsoft.VisualBasic.Interaction.InputBox("Please enter your Gmail ID:", "Login", "", -1, -1).Trim();

                if (!string.IsNullOrEmpty(email))
                {
                    if (email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) && email.Contains("."))
                    {
                        string firstLetter = email.Substring(0, 1).ToUpper();
                        LoginButton.Text = firstLetter;
                        isLoggedIn = true;
                        MessageBox.Show($"Logged in with: {email}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Gmail ID (e.g., example@gmail.com).", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No email ID provided.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (conversationHistory.Count == 0)
                {
                    MessageBox.Show("No conversation history available.", "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                StringBuilder historyText = new StringBuilder();
                foreach (var conversation in conversationHistory)
                {
                    historyText.AppendLine(conversation.ToString());
                    historyText.AppendLine("--------------------------------");
                }

                Form historyForm = new Form
                {
                    Text = "Conversation History",
                    Size = new Size(600, 400)
                };
                TextBox historyBox = new TextBox
                {
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    Dock = DockStyle.Fill,
                    Text = historyText.ToString(),
                    ReadOnly = true
                };
                historyForm.Controls.Add(historyBox);
                historyForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}