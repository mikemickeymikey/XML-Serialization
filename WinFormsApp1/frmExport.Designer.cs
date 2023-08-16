namespace WinFormsApp1
{
    partial class frmExport
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
            this.txtEnunciat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEnunciat
            // 
            this.txtEnunciat.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnunciat.Location = new System.Drawing.Point(68, 33);
            this.txtEnunciat.Multiline = true;
            this.txtEnunciat.Name = "txtEnunciat";
            this.txtEnunciat.Size = new System.Drawing.Size(661, 312);
            this.txtEnunciat.TabIndex = 0;
            this.txtEnunciat.TextChanged += new System.EventHandler(this.txtEnunciat_TextChanged);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEnunciat);
            this.Name = "frmExport";
            this.Text = "frmExport";
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnunciat;
    }
}