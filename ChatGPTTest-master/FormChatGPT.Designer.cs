using System.Windows.Forms;

namespace ChatGPTTest
{
    partial class FormChatGPT
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatGPT));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoginButton = new ChatGPTTest.RoundButton();
            this.HistoryButton = new ChatGPTTest.RoundButton();
            this.webViewGPT = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.labelDisclaimer = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.attachButton = new ChatGPTTest.RoundButton();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewGPT)).BeginInit();
            this.panelInput.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMain.Controls.Add(this.tableLayoutPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1017, 341);
            this.panelMain.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Controls.Add(this.LoginButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.HistoryButton, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.webViewGPT, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelDisclaimer, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(977, 301);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Blue;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(3, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(44, 44);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackgroundImage = global::ChatGPTTest.Properties.Resources.HistoryButton;
            this.HistoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Location = new System.Drawing.Point(930, 3);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(44, 44);
            this.HistoryButton.TabIndex = 3;
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // webViewGPT
            // 
            this.webViewGPT.AllowExternalDrop = true;
            this.tableLayoutPanel.SetColumnSpan(this.webViewGPT, 3);
            this.webViewGPT.CreationProperties = null;
            this.webViewGPT.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.webViewGPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewGPT.Location = new System.Drawing.Point(216, 43);
            this.webViewGPT.Margin = new System.Windows.Forms.Padding(216, 3, 290, 3);
            this.webViewGPT.Name = "webViewGPT";
            this.webViewGPT.Size = new System.Drawing.Size(471, 215);
            this.webViewGPT.TabIndex = 1;
            this.webViewGPT.ZoomFactor = 1D;
            // 
            // labelDisclaimer
            // 
            this.labelDisclaimer.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelDisclaimer, 3);
            this.labelDisclaimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDisclaimer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelDisclaimer.ForeColor = System.Drawing.Color.Gray;
            this.labelDisclaimer.Location = new System.Drawing.Point(3, 261);
            this.labelDisclaimer.Name = "labelDisclaimer";
            this.labelDisclaimer.Size = new System.Drawing.Size(971, 40);
            this.labelDisclaimer.TabIndex = 3;
            this.labelDisclaimer.Text = "Powered by OpenAI. Responses may vary in accuracy.";
            this.labelDisclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelInput.Controls.Add(this.attachButton);
            this.panelInput.Controls.Add(this.buttonAsk);
            this.panelInput.Controls.Add(this.textBoxQuery);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 341);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(10);
            this.panelInput.Size = new System.Drawing.Size(1017, 159);
            this.panelInput.TabIndex = 1;
            // 
            // attachButton
            // 
            this.attachButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.attachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.attachButton.FlatAppearance.BorderSize = 0;
            this.attachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachButton.ForeColor = System.Drawing.Color.White;
            this.attachButton.Location = new System.Drawing.Point(226, 84);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(47, 47);
            this.attachButton.TabIndex = 2;
            this.attachButton.Text = "📎";
            this.attachButton.UseVisualStyleBackColor = false;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // buttonAsk
            // 
            this.buttonAsk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(195)))), ((int)(((byte)(125)))));
            this.buttonAsk.FlatAppearance.BorderSize = 0;
            this.buttonAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAsk.ForeColor = System.Drawing.Color.White;
            this.buttonAsk.Location = new System.Drawing.Point(629, 84);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(80, 40);
            this.buttonAsk.TabIndex = 1;
            this.buttonAsk.Text = "Ask";
            this.buttonAsk.UseVisualStyleBackColor = false;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxQuery.ForeColor = System.Drawing.Color.White;
            this.textBoxQuery.Location = new System.Drawing.Point(226, 23);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(483, 108);
            this.textBoxQuery.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // FormChatGPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1017, 522);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChatGPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIKTS Innovations";
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewGPT)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Button buttonAsk;
        private RoundButton attachButton;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
        private TableLayoutPanel tableLayoutPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewGPT;
        private Label labelDisclaimer;
        private RoundButton LoginButton;
        private RoundButton HistoryButton;
    }
}