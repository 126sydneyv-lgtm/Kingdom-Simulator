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
            this.decision1Button = new System.Windows.Forms.Button();
            this.decision2Button = new System.Windows.Forms.Button();
            this.decision3Button = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.kingdomTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(601, 206);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 16);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "label1";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(601, 326);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(44, 16);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "label1";
            // 
            // decision1Button
            // 
            this.decision1Button.Location = new System.Drawing.Point(207, 103);
            this.decision1Button.Name = "decision1Button";
            this.decision1Button.Size = new System.Drawing.Size(75, 23);
            this.decision1Button.TabIndex = 5;
            this.decision1Button.Text = "button1";
            this.decision1Button.UseVisualStyleBackColor = true;
            this.decision1Button.Click += new System.EventHandler(this.decision1Button_Click);
            // 
            // decision2Button
            // 
            this.decision2Button.Location = new System.Drawing.Point(363, 214);
            this.decision2Button.Name = "decision2Button";
            this.decision2Button.Size = new System.Drawing.Size(75, 23);
            this.decision2Button.TabIndex = 6;
            this.decision2Button.Text = "button1";
            this.decision2Button.UseVisualStyleBackColor = true;
            this.decision2Button.Click += new System.EventHandler(this.decision2Button_Click);
            // 
            // decision3Button
            // 
            this.decision3Button.Location = new System.Drawing.Point(288, 243);
            this.decision3Button.Name = "decision3Button";
            this.decision3Button.Size = new System.Drawing.Size(75, 23);
            this.decision3Button.TabIndex = 7;
            this.decision3Button.Text = "button1";
            this.decision3Button.UseVisualStyleBackColor = true;
            this.decision3Button.Click += new System.EventHandler(this.decision3Button_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.Location = new System.Drawing.Point(405, 337);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(75, 23);
            this.endTurnButton.TabIndex = 8;
            this.endTurnButton.Text = "button1";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(476, 69);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "button1";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // kingdomTextBox
            // 
            this.kingdomTextBox.Location = new System.Drawing.Point(380, 140);
            this.kingdomTextBox.Name = "kingdomTextBox";
            this.kingdomTextBox.Size = new System.Drawing.Size(100, 22);
            this.kingdomTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(461, 206);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(44, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.decision3Button);
            this.Controls.Add(this.decision2Button);
            this.Controls.Add(this.decision1Button);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.kingdomTextBox);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kingdom Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button decision1Button;
        private System.Windows.Forms.Button decision2Button;
        private System.Windows.Forms.Button decision3Button;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox kingdomTextBox;
        private System.Windows.Forms.Label titleLabel;
    }
}

