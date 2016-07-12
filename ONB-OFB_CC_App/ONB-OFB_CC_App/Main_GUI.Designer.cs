namespace ONB_OFB_CC_App
{
    partial class Main_GUI
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
            this.Onboard = new System.Windows.Forms.Button();
            this.Offboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Onboard
            // 
            this.Onboard.Location = new System.Drawing.Point(22, 24);
            this.Onboard.Name = "Onboard";
            this.Onboard.Size = new System.Drawing.Size(75, 23);
            this.Onboard.TabIndex = 0;
            this.Onboard.Text = "Onboard";
            this.Onboard.UseVisualStyleBackColor = true;
            this.Onboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // Offboard
            // 
            this.Offboard.Location = new System.Drawing.Point(22, 79);
            this.Offboard.Name = "Offboard";
            this.Offboard.Size = new System.Drawing.Size(75, 23);
            this.Offboard.TabIndex = 1;
            this.Offboard.Text = "Offboard";
            this.Offboard.UseVisualStyleBackColor = true;
            this.Offboard.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 130);
            this.Controls.Add(this.Offboard);
            this.Controls.Add(this.Onboard);
            this.Name = "Main_GUI";
            this.Text = "Main_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Onboard;
        private System.Windows.Forms.Button Offboard;
    }
}

