using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        BLL bLL;
        public Form1()
        {
            bLL = new BLL();
            InitializeComponent();
        }

        private void btnTumliste_Click(object sender, EventArgs e)
        {
            GetTransactionList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GetTransactionListByCode(txtCode.Text);
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            int Tarih1 = Convert.ToInt32(dtTarih1.Value.ToOADate());
            int Tarih2 = Convert.ToInt32(dtTarih2.Value.ToOADate());
            GetTransactionListByDate(Tarih1, Tarih2);
        }

        private void GetTransactionList()
        {
            List<Transaction> transactions = bLL.GetTransactionList();
            dgvList.DataSource = transactions;
        }

        private void GetTransactionListByCode(string MalKodu)
        {
            List<Transaction> transactions = bLL.GetTransactionListByCode(MalKodu);
            dgvList.DataSource = transactions;
        }

        public void GetTransactionListByDate(int Tarih1, int Tarih2)
        {
            List<Transaction> transactions = bLL.GetTransactionListByDate(Tarih1, Tarih2);
            dgvList.DataSource = transactions;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);


                for (int i = 1; i < dgvList.Columns.Count + 1; i++)
                {
                    application.Cells[1, i] = dgvList.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvList.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvList.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dgvList.Rows[i].Cells[j].Value.ToString();
                    }
                }
                application.Columns.AutoFit();
                application.Visible = true;
            }
        }
    }
}
