namespace SynergySploit
{
    partial class UI
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
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AttachButton = new System.Windows.Forms.Button();
            this.ScriptBox = new System.Windows.Forms.RichTextBox();
            this.AttachingLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.Location = new System.Drawing.Point(12, 799);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(132, 73);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(150, 799);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(132, 73);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AttachButton
            // 
            this.AttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachButton.ForeColor = System.Drawing.Color.White;
            this.AttachButton.Location = new System.Drawing.Point(12, 9);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(105, 41);
            this.AttachButton.TabIndex = 2;
            this.AttachButton.Text = "Attach";
            this.AttachButton.UseVisualStyleBackColor = true;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // ScriptBox
            // 
            this.ScriptBox.Location = new System.Drawing.Point(12, 66);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Size = new System.Drawing.Size(956, 727);
            this.ScriptBox.TabIndex = 3;
            this.ScriptBox.Text = "";
            // 
            // AttachingLabel
            // 
            this.AttachingLabel.AutoSize = true;
            this.AttachingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AttachingLabel.Location = new System.Drawing.Point(123, 17);
            this.AttachingLabel.Name = "AttachingLabel";
            this.AttachingLabel.Size = new System.Drawing.Size(192, 25);
            this.AttachingLabel.TabIndex = 4;
            this.AttachingLabel.Text = "Status: Not Ready!";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(0, -4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 67);
            this.Title.TabIndex = 5;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(980, 884);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.AttachingLabel);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.AttachButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExecuteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UI";
            this.ShowIcon = false;
            this.Text = "Synergy Sploit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.RichTextBox ScriptBox;
        private System.Windows.Forms.Label AttachingLabel;
        private System.Windows.Forms.Label Title;
    }
}

