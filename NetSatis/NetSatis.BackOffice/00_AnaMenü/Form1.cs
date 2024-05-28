using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using NetSatis.Entities._5_Data_Access;
using NetSatis.BackOffice._01_Stok;
using NetSatis.BackOffice._02_Cari;

namespace NetSatis.BackOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new NetSatisContext())
            {
                context.Database.CreateIfNotExists();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetSatisContext context = new NetSatisContext();
            Cari entity = new Cari()
            {
                CariKodu="123456789",
               // CariAdi="test test",
                //YetkiliKisi="bengisu bostancı",
                //FaturaUnvani="benim fatura"
                
            };
            CariDAL cariDal = new CariDAL();
            cariDal.AddOrUpdate(context, entity);
            cariDal.Save(context);
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmStok form = new FrmStok();
            form.Show();

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            FrmStokHareket form = new FrmStokHareket();
            form.Show();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            FrmCari form = new FrmCari();
            form.Show();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            FrmCariKart form = new FrmCariKart();
            form.Show();
        }
    }
}
