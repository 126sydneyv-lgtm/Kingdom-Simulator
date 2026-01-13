namespace Kingdom_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.approveButton = new System.Windows.Forms.Button();
            this.denyButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.kingdomTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.statsPanel.SuspendLayout();
            this.requestPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(248, 248);
            this.statusLabel.TabIndex = 2;
            // 
            // outputLabel
            // 
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(0, 0);
            this.outputLabel.MaximumSize = new System.Drawing.Size(400, 250);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Padding = new System.Windows.Forms.Padding(10);
            this.outputLabel.Size = new System.Drawing.Size(198, 98);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.YellowGreen;
            this.approveButton.Location = new System.Drawing.Point(253, 340);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(120, 25);
            this.approveButton.TabIndex = 5;
            this.approveButton.Text = "Approve";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // denyButton
            // 
            this.denyButton.BackColor = System.Drawing.Color.IndianRed;
            this.denyButton.Location = new System.Drawing.Point(456, 339);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(120, 25);
            this.denyButton.TabIndex = 6;
            this.denyButton.Text = "Deny";
            this.denyButton.UseVisualStyleBackColor = false;
            this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(564, 77);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 35);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Reign";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // kingdomTextBox
            // 
            this.kingdomTextBox.Location = new System.Drawing.Point(306, 83);
            this.kingdomTextBox.Name = "kingdomTextBox";
            this.kingdomTextBox.Size = new System.Drawing.Size(200, 22);
            this.kingdomTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(782, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Kingdom Simulator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.Location = new System.Drawing.Point(-2, 82);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(279, 23);
            this.namePromptLabel.TabIndex = 7;
            this.namePromptLabel.Text = "label1";
            this.namePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsPanel
            // 
            this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsPanel.Controls.Add(this.statusLabel);
            this.statsPanel.Location = new System.Drawing.Point(-3, 175);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(250, 250);
            this.statsPanel.TabIndex = 8;
            // 
            // requestPanel
            // 
            this.requestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestPanel.Controls.Add(this.outputLabel);
            this.requestPanel.Location = new System.Drawing.Point(582, 265);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(200, 100);
            this.requestPanel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.requestPanel);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.namePromptLabel);
            this.Controls.Add(this.denyButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.kingdomTextBox);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kingdom Simulator";
            this.statsPanel.ResumeLayout(false);
            this.requestPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button denyButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox kingdomTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel requestPanel;
    }
}

