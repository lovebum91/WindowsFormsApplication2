using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
            this.Size = new Size(900, 793);
            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            //this.panelSicherheit.Location = new Point(0, 240);
            //this.panelSystem.Location = new Point(0, 240);
            //this.panelKontakt.Location = new Point(0, 240);
            // this.panelKontakt.Visible = false;
        }

        private void bunBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show gi do!");
        }

        private void panelBtnSicherheit_Click(object sender, EventArgs e)
        {
            this.panelBtnSicherheit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head01_active));
            this.panelBtnSystem.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head02));
            this.panelBtnKontakt.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head03));
            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
        }

        private void panelBtnSystem_Click(object sender, EventArgs e)
        {
            this.panelBtnSicherheit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head01));
            this.panelBtnSystem.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head02_active));
            this.panelBtnKontakt.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head03));
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = true;
            this.groupBox3.Visible = false;
        }

        private void panelBtnKontakt_Click(object sender, EventArgs e)
        {
            this.panelBtnSicherheit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head01));
            this.panelBtnSystem.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head02));
            this.panelBtnKontakt.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.head03_active));
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = true;
        }
    }
}
