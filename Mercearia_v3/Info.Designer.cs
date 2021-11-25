namespace Mercearia_v3
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.pnpdf = new System.Windows.Forms.Panel();
            this.adbPdf = new AxAcroPDFLib.AxAcroPDF();
            this.bsobre = new System.Windows.Forms.Button();
            this.bdesen = new System.Windows.Forms.Button();
            this.pndesen = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnpdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adbPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // pnpdf
            // 
            this.pnpdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnpdf.BackgroundImage")));
            this.pnpdf.Controls.Add(this.adbPdf);
            this.pnpdf.Location = new System.Drawing.Point(199, 0);
            this.pnpdf.Name = "pnpdf";
            this.pnpdf.Size = new System.Drawing.Size(661, 450);
            this.pnpdf.TabIndex = 0;
            // 
            // adbPdf
            // 
            this.adbPdf.Enabled = true;
            this.adbPdf.Location = new System.Drawing.Point(21, 0);
            this.adbPdf.Name = "adbPdf";
            this.adbPdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("adbPdf.OcxState")));
            this.adbPdf.Size = new System.Drawing.Size(640, 445);
            this.adbPdf.TabIndex = 0;
            // 
            // bsobre
            // 
            this.bsobre.BackColor = System.Drawing.Color.Transparent;
            this.bsobre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsobre.BackgroundImage")));
            this.bsobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsobre.FlatAppearance.BorderSize = 0;
            this.bsobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsobre.Location = new System.Drawing.Point(-1, 145);
            this.bsobre.Name = "bsobre";
            this.bsobre.Size = new System.Drawing.Size(200, 40);
            this.bsobre.TabIndex = 4;
            this.bsobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bsobre.UseVisualStyleBackColor = false;
            this.bsobre.Click += new System.EventHandler(this.bsobre_Click);
            // 
            // bdesen
            // 
            this.bdesen.BackColor = System.Drawing.Color.Transparent;
            this.bdesen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdesen.BackgroundImage")));
            this.bdesen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdesen.FlatAppearance.BorderSize = 0;
            this.bdesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdesen.Location = new System.Drawing.Point(-1, 205);
            this.bdesen.Name = "bdesen";
            this.bdesen.Size = new System.Drawing.Size(200, 40);
            this.bdesen.TabIndex = 5;
            this.bdesen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bdesen.UseVisualStyleBackColor = false;
            this.bdesen.Click += new System.EventHandler(this.bdesen_Click);
            // 
            // pndesen
            // 
            this.pndesen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pndesen.BackgroundImage")));
            this.pndesen.Enabled = false;
            this.pndesen.Location = new System.Drawing.Point(199, 0);
            this.pndesen.Name = "pndesen";
            this.pndesen.Size = new System.Drawing.Size(661, 450);
            this.pndesen.TabIndex = 6;
            this.pndesen.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Informações";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bdesen);
            this.Controls.Add(this.bsobre);
            this.Controls.Add(this.pndesen);
            this.Controls.Add(this.pnpdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.pnpdf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adbPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnpdf;
        private System.Windows.Forms.Button bsobre;
        private System.Windows.Forms.Button bdesen;
        private System.Windows.Forms.Panel pndesen;
        private System.Windows.Forms.Label label10;
        private AxAcroPDFLib.AxAcroPDF adbPdf;
    }
}