﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasrafOtomasyonu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            frmKullaniciYonetimi frm = new frmKullaniciYonetimi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
