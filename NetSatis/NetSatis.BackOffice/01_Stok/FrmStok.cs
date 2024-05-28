using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities._5_Data_Access;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice._01_Stok
{
    public partial class FrmStok : Form
    {
        NetSatisContext context = new NetSatisContext();
        public FrmStok()
        {
            InitializeComponent();
        }

        public void GetAll()
        {
            //stokDal.GetALLJoin(context);
            //dataGridView1.DataSource = stokDal.GetALLJoin(context);

            //c=>c. contex expresion
            //lamda ile yeni bir tablo oluşturduk stok ve stok hareketlerindeni birleştirdik
            //yeni bir tabloda
            //!!!!!!! StokDal a taşıdık  !!!!!!!!!!!!!
            //stok tablosuna 

            //!!!TAŞIDIK!!!!

            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) =>
                   new
                   {
                       Stoklar.Id,
                       Stoklar.Durumu,
                       Stoklar.BarkodTürü,
                       Stoklar.StokKodu,
                       Stoklar.Birimi,
                       Stoklar.StokGrubu,
                       Stoklar.StokAltGrup,
                       Stoklar.Marka,
                       Stoklar.OzelKod1,
                       Stoklar.OzelKod2,
                       Stoklar.AlisKdv,
                       Stoklar.SatisKdv,
                       Stoklar.AlisFiyati1,
                       Stoklar.AlisFiyati2,
                       Stoklar.SatisFiyati1,
                       Stoklar.SatisFiyati2,
                       Stoklar.MinStokMiktari,
                       Stoklar.MaxStokMiktari,
                       Stoklar.Aciklama,
                       Stoklar.Barkod,
                       Stoklar.GarantiSüresi,
                       Stoklar.UreticiKodu,

                       //bu tablo içinde stokgiriş diye kolon oluştur. stokharekterlirnde hareketi stok giriş olanı toplam tutarını tople
                       //bütün stok girişi topla tüm stok girişleri toplamış olacak
                       //Mevcut stok girişlerden çıkışları çıkararak bulunurç
                       StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                       StokCıkıs = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                       MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) - StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,


                       //?? yapılmasının sebebi null sa demek. null sa değerini 0 yap ?? 0


                   }).ToList();
            //gridControl1.DataSource = tablo; //grid tabloya verileri gönderdik
            dataGridView1.Columns.Add("StokGiris", "Stok Giriş");
            dataGridView1.Columns.Add("StokCıkıs", "Stok Çıkış");
            dataGridView1.Columns.Add("MevcutStok", "Mevcut Stok");
            dataGridView1.Columns.Add("testest", "test test");
            
            dataGridView1.DataSource = tablo;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokIslem form = new FrmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void BtnKapatm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreleKapat_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btn_filterKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void bynAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void bynGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        StokDAL stokDal = new StokDAL();
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //stokDal.Delete(context, c => c.StokKodu == dataGridView1.GetFocusesRowCellValue(stokKoduDataGridViewTextBoxColumn).ToString());
                //stokDal.Delete(context, c => c.StokKodu == dataGridView1.CurrentRow.Cells("stokKoduDataGridViewTextBoxColumn").ToString());
                if (dataGridView1.CurrentRow != null)
                {
                    var cellValue = dataGridView1.CurrentRow.Cells["stokKoduDataGridViewTextBoxColumn"].Value;

                    if (cellValue != null)
                    {
                        stokDal.Delete(context, c => c.StokKodu == cellValue.ToString());
                    }
                }
                stokDal.Save(context);
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // İlgili sütunun adını belirleyin (örneğin "stokKoduDataGridViewTextBoxColumn")
                string columnName = "stokKoduDataGridViewTextBoxColumn";

                // İlgili hücrenin değerini alın
                object cellValue = dataGridView1.CurrentRow.Cells[columnName].Value;

                if (cellValue != null)
                {
                    // Hücre değerini string'e dönüştürün
                    string secilen = cellValue.ToString();

                    // Düzenleme formunu açın
                    FrmStokIslem form = new FrmStokIslem(stokDal.GetByFilter(context, c => c.StokKodu == secilen));
                    form.MdiParent = this;
                    form.ShowDialog();
                }
            }

        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // İlgili sütunun adını belirleyin (örneğin "stokKoduDataGridViewTextBoxColumn")
                string columnName = "stokKoduDataGridViewTextBoxColumn";

                // İlgili hücrenin değerini alın
                object cellValue = dataGridView1.CurrentRow.Cells[columnName].Value;

                if (cellValue != null)
                {
                    // Hücre değerini string'e dönüştürün
                    string secilen = cellValue.ToString();

                    // Düzenleme formunu açın
                    FrmStokIslem form = new FrmStokIslem(stokDal.GetByFilter(context, c => c.StokKodu == secilen));
                    form.MdiParent = this;
                    form.ShowDialog();
                }
            }
        }
    }
}
