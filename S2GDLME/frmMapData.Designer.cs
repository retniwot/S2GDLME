namespace S2GDLME
{
    partial class frmMapData
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
            this.txtMapData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMapData
            // 
            this.txtMapData.Location = new System.Drawing.Point(12, 23);
            this.txtMapData.Multiline = true;
            this.txtMapData.Name = "txtMapData";
            this.txtMapData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMapData.Size = new System.Drawing.Size(598, 393);
            this.txtMapData.TabIndex = 0;
            this.txtMapData.TextChanged += new System.EventHandler(this.txtMapData_TextChanged);
            // 
            // frmMapData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 428);
            this.Controls.Add(this.txtMapData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMapData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S2GDL Map Editor - Map Data";
            this.Load += new System.EventHandler(this.frmMapData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMapData;
    }
}