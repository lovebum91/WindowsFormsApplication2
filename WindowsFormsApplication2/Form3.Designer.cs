namespace WindowsFormsApplication2
{
    partial class frmProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunBtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbProSecLogo1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelBtnSicherheit = new System.Windows.Forms.Panel();
            this.panelBtnSystem = new System.Windows.Forms.Panel();
            this.panelBtnKontakt = new System.Windows.Forms.Panel();
            this.panelSichierheit01 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panelSichierheit01.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunBtnClose);
            this.panel1.Controls.Add(this.lbProSecLogo1);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 53);
            this.panel1.TabIndex = 0;
            // 
            // bunBtnClose
            // 
            this.bunBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.bunBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("bunBtnClose.Image")));
            this.bunBtnClose.ImageActive = null;
            this.bunBtnClose.Location = new System.Drawing.Point(833, 16);
            this.bunBtnClose.Name = "bunBtnClose";
            this.bunBtnClose.Size = new System.Drawing.Size(22, 19);
            this.bunBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunBtnClose.TabIndex = 1;
            this.bunBtnClose.TabStop = false;
            this.bunBtnClose.Zoom = 10;
            this.bunBtnClose.Click += new System.EventHandler(this.bunBtnClose_Click);
            // 
            // lbProSecLogo1
            // 
            this.lbProSecLogo1.AutoSize = true;
            this.lbProSecLogo1.BackColor = System.Drawing.Color.Transparent;
            this.lbProSecLogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProSecLogo1.ForeColor = System.Drawing.Color.White;
            this.lbProSecLogo1.Location = new System.Drawing.Point(61, 16);
            this.lbProSecLogo1.Name = "lbProSecLogo1";
            this.lbProSecLogo1.Size = new System.Drawing.Size(213, 22);
            this.lbProSecLogo1.TabIndex = 2;
            this.lbProSecLogo1.Text = "ProSec EKTEROS Agent";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(2, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(61, 34);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 0;
            // 
            // panelBtnSicherheit
            // 
            this.panelBtnSicherheit.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.head01_active;
            this.panelBtnSicherheit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBtnSicherheit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBtnSicherheit.Location = new System.Drawing.Point(1, 53);
            this.panelBtnSicherheit.Name = "panelBtnSicherheit";
            this.panelBtnSicherheit.Size = new System.Drawing.Size(300, 190);
            this.panelBtnSicherheit.TabIndex = 3;
            this.panelBtnSicherheit.Click += new System.EventHandler(this.panelBtnSicherheit_Click);
            // 
            // panelBtnSystem
            // 
            this.panelBtnSystem.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.head02;
            this.panelBtnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBtnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBtnSystem.Location = new System.Drawing.Point(295, 53);
            this.panelBtnSystem.Name = "panelBtnSystem";
            this.panelBtnSystem.Size = new System.Drawing.Size(289, 190);
            this.panelBtnSystem.TabIndex = 3;
            this.panelBtnSystem.Click += new System.EventHandler(this.panelBtnSystem_Click);
            // 
            // panelBtnKontakt
            // 
            this.panelBtnKontakt.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.head03;
            this.panelBtnKontakt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBtnKontakt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBtnKontakt.Location = new System.Drawing.Point(584, 53);
            this.panelBtnKontakt.Name = "panelBtnKontakt";
            this.panelBtnKontakt.Size = new System.Drawing.Size(300, 190);
            this.panelBtnKontakt.TabIndex = 3;
            this.panelBtnKontakt.Click += new System.EventHandler(this.panelBtnKontakt_Click);
            // 
            // panelSichierheit01
            // 
            this.panelSichierheit01.BackColor = System.Drawing.Color.Transparent;
            this.panelSichierheit01.Controls.Add(this.panel2);
            this.panelSichierheit01.Location = new System.Drawing.Point(0, 244);
            this.panelSichierheit01.Name = "panelSichierheit01";
            this.panelSichierheit01.Size = new System.Drawing.Size(885, 511);
            this.panelSichierheit01.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 511);
            this.panel2.TabIndex = 0;
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.bg02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 754);
            this.Controls.Add(this.panelSichierheit01);
            this.Controls.Add(this.panelBtnKontakt);
            this.Controls.Add(this.panelBtnSystem);
            this.Controls.Add(this.panelBtnSicherheit);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "frmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process";
            this.Load += new System.EventHandler(this.frmProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panelSichierheit01.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label lbProSecLogo1;
        private Bunifu.Framework.UI.BunifuImageButton bunBtnClose;
        private System.Windows.Forms.Panel panelBtnSicherheit;
        private System.Windows.Forms.Panel panelBtnSystem;
        private System.Windows.Forms.Panel panelBtnKontakt;
        private System.Windows.Forms.Panel panelSichierheit01;
        private System.Windows.Forms.Panel panel2;

    }
}