namespace Plemiona
{
    partial class AttactForm
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
            this.labelYourArmy = new System.Windows.Forms.Label();
            this.labelOpponentArmy = new System.Windows.Forms.Label();
            this.labelYourArmyValue = new System.Windows.Forms.Label();
            this.labelOpponentArmyValue = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelYourArmy
            // 
            this.labelYourArmy.AutoSize = true;
            this.labelYourArmy.BackColor = System.Drawing.Color.Transparent;
            this.labelYourArmy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourArmy.ForeColor = System.Drawing.Color.Black;
            this.labelYourArmy.Location = new System.Drawing.Point(15, 8);
            this.labelYourArmy.Name = "labelYourArmy";
            this.labelYourArmy.Size = new System.Drawing.Size(150, 26);
            this.labelYourArmy.TabIndex = 0;
            this.labelYourArmy.Text = "Twoje wojska";
            // 
            // labelOpponentArmy
            // 
            this.labelOpponentArmy.AutoSize = true;
            this.labelOpponentArmy.BackColor = System.Drawing.Color.Transparent;
            this.labelOpponentArmy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpponentArmy.ForeColor = System.Drawing.Color.Black;
            this.labelOpponentArmy.Location = new System.Drawing.Point(417, 9);
            this.labelOpponentArmy.Name = "labelOpponentArmy";
            this.labelOpponentArmy.Size = new System.Drawing.Size(218, 26);
            this.labelOpponentArmy.TabIndex = 1;
            this.labelOpponentArmy.Text = "Wojska przeciwnika";
            // 
            // labelYourArmyValue
            // 
            this.labelYourArmyValue.AutoSize = true;
            this.labelYourArmyValue.BackColor = System.Drawing.Color.Transparent;
            this.labelYourArmyValue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourArmyValue.ForeColor = System.Drawing.Color.Black;
            this.labelYourArmyValue.Location = new System.Drawing.Point(70, 41);
            this.labelYourArmyValue.Name = "labelYourArmyValue";
            this.labelYourArmyValue.Size = new System.Drawing.Size(20, 26);
            this.labelYourArmyValue.TabIndex = 2;
            this.labelYourArmyValue.Text = "-";
            // 
            // labelOpponentArmyValue
            // 
            this.labelOpponentArmyValue.AutoSize = true;
            this.labelOpponentArmyValue.BackColor = System.Drawing.Color.Transparent;
            this.labelOpponentArmyValue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpponentArmyValue.ForeColor = System.Drawing.Color.Black;
            this.labelOpponentArmyValue.Location = new System.Drawing.Point(514, 41);
            this.labelOpponentArmyValue.Name = "labelOpponentArmyValue";
            this.labelOpponentArmyValue.Size = new System.Drawing.Size(20, 26);
            this.labelOpponentArmyValue.TabIndex = 3;
            this.labelOpponentArmyValue.Text = "-";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Transparent;
            this.labelWin.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelWin.Location = new System.Drawing.Point(191, 222);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(261, 55);
            this.labelWin.TabIndex = 4;
            this.labelWin.Text = "Zwycięstwo";
            // 
            // AttactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plemiona.Properties.Resources.AttactBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.labelOpponentArmyValue);
            this.Controls.Add(this.labelYourArmyValue);
            this.Controls.Add(this.labelOpponentArmy);
            this.Controls.Add(this.labelYourArmy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AttactForm";
            this.Text = "Obrona miasta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourArmy;
        private System.Windows.Forms.Label labelOpponentArmy;
        private System.Windows.Forms.Label labelYourArmyValue;
        private System.Windows.Forms.Label labelOpponentArmyValue;
        private System.Windows.Forms.Label labelWin;
    }
}