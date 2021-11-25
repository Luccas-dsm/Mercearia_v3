namespace Mercearia_v3
{
    partial class AlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCliente));
            this.bconf = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbend = new System.Windows.Forms.TextBox();
            this.tbcep = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.pbimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).BeginInit();
            this.SuspendLayout();
            // 
            // bconf
            // 
            this.bconf.BackColor = System.Drawing.Color.Transparent;
            this.bconf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bconf.BackgroundImage")));
            this.bconf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bconf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bconf.FlatAppearance.BorderSize = 0;
            this.bconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bconf.Location = new System.Drawing.Point(22, 233);
            this.bconf.Name = "bconf";
            this.bconf.Size = new System.Drawing.Size(200, 40);
            this.bconf.TabIndex = 0;
            this.bconf.UseVisualStyleBackColor = false;
            this.bconf.Click += new System.EventHandler(this.bconf_Click);
            // 
            // bcancel
            // 
            this.bcancel.BackColor = System.Drawing.Color.Transparent;
            this.bcancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcancel.BackgroundImage")));
            this.bcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcancel.FlatAppearance.BorderSize = 0;
            this.bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancel.Location = new System.Drawing.Point(241, 233);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(200, 40);
            this.bcancel.TabIndex = 1;
            this.bcancel.UseVisualStyleBackColor = false;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "End:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cep:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label4.Location = new System.Drawing.Point(38, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // tbnome
            // 
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbnome.Location = new System.Drawing.Point(84, 9);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(357, 29);
            this.tbnome.TabIndex = 7;
            this.tbnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnome_KeyPress);
            // 
            // tbend
            // 
            this.tbend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbend.Location = new System.Drawing.Point(84, 50);
            this.tbend.Name = "tbend";
            this.tbend.Size = new System.Drawing.Size(357, 29);
            this.tbend.TabIndex = 8;
            this.tbend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbend_KeyPress);
            // 
            // tbcep
            // 
            this.tbcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbcep.Location = new System.Drawing.Point(84, 96);
            this.tbcep.Name = "tbcep";
            this.tbcep.Size = new System.Drawing.Size(357, 29);
            this.tbcep.TabIndex = 9;
            this.tbcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcep_KeyPress);
            // 
            // tbtel
            // 
            this.tbtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbtel.Location = new System.Drawing.Point(84, 140);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(357, 29);
            this.tbtel.TabIndex = 10;
            this.tbtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtel_KeyPress);
            // 
            // tbmail
            // 
            this.tbmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbmail.Location = new System.Drawing.Point(84, 184);
            this.tbmail.Name = "tbmail";
            this.tbmail.Size = new System.Drawing.Size(357, 29);
            this.tbmail.TabIndex = 11;
            this.tbmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmail_KeyPress);
            // 
            // pbimg
            // 
            this.pbimg.BackColor = System.Drawing.Color.Transparent;
            this.pbimg.Location = new System.Drawing.Point(485, 0);
            this.pbimg.Name = "pbimg";
            this.pbimg.Size = new System.Drawing.Size(193, 220);
            this.pbimg.TabIndex = 12;
            this.pbimg.TabStop = false;
            this.pbimg.Click += new System.EventHandler(this.pbimg_Click);
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.pbimg);
            this.Controls.Add(this.tbmail);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.tbcep);
            this.Controls.Add(this.tbend);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bconf);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bconf;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbend;
        private System.Windows.Forms.TextBox tbcep;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.PictureBox pbimg;
    }
}