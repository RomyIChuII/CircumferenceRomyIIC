namespace CircumferenceRomyIIC
{
    partial class frmCircumference
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
            this.lblRadiusText = new System.Windows.Forms.Label();
            this.lblCircumferenceStatement = new System.Windows.Forms.Label();
            this.btnCalculateRadius = new System.Windows.Forms.Button();
            this.txtRadiusInput = new System.Windows.Forms.TextBox();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRadiusText
            // 
            this.lblRadiusText.AutoSize = true;
            this.lblRadiusText.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiusText.Location = new System.Drawing.Point(45, 59);
            this.lblRadiusText.Name = "lblRadiusText";
            this.lblRadiusText.Size = new System.Drawing.Size(103, 37);
            this.lblRadiusText.TabIndex = 0;
            this.lblRadiusText.Text = "Radius:";
            // 
            // lblCircumferenceStatement
            // 
            this.lblCircumferenceStatement.AutoSize = true;
            this.lblCircumferenceStatement.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumferenceStatement.Location = new System.Drawing.Point(21, 163);
            this.lblCircumferenceStatement.Name = "lblCircumferenceStatement";
            this.lblCircumferenceStatement.Size = new System.Drawing.Size(233, 33);
            this.lblCircumferenceStatement.TabIndex = 1;
            this.lblCircumferenceStatement.Text = "The Circumference Is:";
            // 
            // btnCalculateRadius
            // 
            this.btnCalculateRadius.Location = new System.Drawing.Point(154, 113);
            this.btnCalculateRadius.Name = "btnCalculateRadius";
            this.btnCalculateRadius.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateRadius.TabIndex = 2;
            this.btnCalculateRadius.Text = "Calculate";
            this.btnCalculateRadius.UseVisualStyleBackColor = true;
            this.btnCalculateRadius.Click += new System.EventHandler(this.btnCalculateRadius_Click);
            // 
            // txtRadiusInput
            // 
            this.txtRadiusInput.Location = new System.Drawing.Point(154, 72);
            this.txtRadiusInput.Name = "txtRadiusInput";
            this.txtRadiusInput.Size = new System.Drawing.Size(100, 20);
            this.txtRadiusInput.TabIndex = 3;
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumference.Location = new System.Drawing.Point(260, 163);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(27, 33);
            this.lblCircumference.TabIndex = 4;
            this.lblCircumference.Text = "0";
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(447, 24);
            this.mnuFile.TabIndex = 5;
            this.mnuFile.Text = "menuStrip1";
            // 
            // mniExit
            // 
            this.mniExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(37, 20);
            this.mniExit.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 312);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.txtRadiusInput);
            this.Controls.Add(this.btnCalculateRadius);
            this.Controls.Add(this.lblCircumferenceStatement);
            this.Controls.Add(this.lblRadiusText);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmCircumference";
            this.Text = "Circumference by RomyIIC";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadiusText;
        private System.Windows.Forms.Label lblCircumferenceStatement;
        private System.Windows.Forms.Button btnCalculateRadius;
        private System.Windows.Forms.TextBox txtRadiusInput;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

