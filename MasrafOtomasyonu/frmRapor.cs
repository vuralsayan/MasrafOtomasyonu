using Ganss.Excel;
using System;
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
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        public Action<string> ExcelAktarimMetot { get; set; }

        private void btnExcelAktarim_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();   
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dialog.Title = "Rapor Excel Aktarım";
            dialog.FileName = this.Text.Replace("Rapor : ", "");
            dialog.OverwritePrompt = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ExcelAktarimMetot(dialog.FileName);
            }

        }
    }
}
