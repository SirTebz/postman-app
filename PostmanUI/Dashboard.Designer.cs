namespace PostmanUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            apiText = new TextBox();
            apiLabel = new Label();
            callApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            httpVerbSelection = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodyText = new TextBox();
            resultsTab = new TabPage();
            resultsText = new TextBox();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            resultsTab.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(25, 28);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(181, 38);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman App";
            // 
            // apiText
            // 
            apiText.Location = new Point(210, 90);
            apiText.Name = "apiText";
            apiText.Size = new Size(471, 39);
            apiText.TabIndex = 1;
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(25, 93);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(53, 32);
            apiLabel.TabIndex = 2;
            apiLabel.Text = "API:";
            // 
            // callApi
            // 
            callApi.Location = new Point(687, 90);
            callApi.Name = "callApi";
            callApi.Size = new Size(68, 39);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 592);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(780, 32);
            statusStrip.TabIndex = 5;
            statusStrip.Text = " ";
            // 
            // systemStatus
            // 
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(60, 25);
            systemStatus.Text = "Ready";
            // 
            // httpVerbSelection
            // 
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            httpVerbSelection.Location = new Point(84, 90);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(120, 40);
            httpVerbSelection.TabIndex = 7;
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(resultsTab);
            callData.Location = new Point(25, 157);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(730, 416);
            callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(bodyText);
            bodyTab.Location = new Point(4, 41);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(722, 371);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // bodyText
            // 
            bodyText.BackColor = Color.White;
            bodyText.BorderStyle = BorderStyle.FixedSingle;
            bodyText.Dock = DockStyle.Fill;
            bodyText.Location = new Point(3, 3);
            bodyText.Multiline = true;
            bodyText.Name = "bodyText";
            bodyText.ScrollBars = ScrollBars.Both;
            bodyText.Size = new Size(716, 365);
            bodyText.TabIndex = 6;
            // 
            // resultsTab
            // 
            resultsTab.Controls.Add(resultsText);
            resultsTab.Location = new Point(4, 34);
            resultsTab.Name = "resultsTab";
            resultsTab.Padding = new Padding(3);
            resultsTab.Size = new Size(722, 378);
            resultsTab.TabIndex = 1;
            resultsTab.Text = "Results";
            resultsTab.UseVisualStyleBackColor = true;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Dock = DockStyle.Fill;
            resultsText.Location = new Point(3, 3);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(716, 372);
            resultsText.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 624);
            Controls.Add(callData);
            Controls.Add(httpVerbSelection);
            Controls.Add(statusStrip);
            Controls.Add(callApi);
            Controls.Add(apiLabel);
            Controls.Add(apiText);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            Text = "Postman App by Teboho Mokgosi";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            resultsTab.ResumeLayout(false);
            resultsTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private TextBox apiText;
        private Label apiLabel;
        private Button callApi;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerbSelection;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage resultsTab;
        private TextBox resultsText;
        private TextBox bodyText;
    }
}
