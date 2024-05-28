using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities._5_Data_Access;

namespace NetSatis.BackOffice._01_Stok
{
    
    public partial class FrmStokIslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private NetSatisContext context = new NetSatisContext();
        public FrmStokIslem(Entities.Tables.Stok entity)
        {
            InitializeComponent();
            _entity = entity;
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod");
            txtBirimi.DataBindings.Add("Text", _entity, "Birimi");
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrup");
            btnMarka.DataBindings.Add("Text", _entity, "Marka");
            btnModel.DataBindings.Add("Text", _entity, "Modeli");
            calcMinStok.DataBindings.Add("Text", _entity, "MinStokMiktari");
            calcMaxStok.DataBindings.Add("Text", _entity, "MaxStokMiktari");

            calcAlışFiyatı1.DataBindings.Add("Text", _entity, "AlisFiyati1");
            calcAlışFiyatı1.DataBindings[0].FormattingEnabled = true;
            calcAlışFiyatı1.DataBindings[0].FormatString = "C2";

            calcAlışFiyatı2.DataBindings.Add("Text", _entity, "AlisFiyati2");
            calcAlışFiyatı1.DataBindings[0].FormattingEnabled = true;
            calcAlışFiyatı1.DataBindings[0].FormatString = "C2";

            calcSatışFiyatı1.DataBindings.Add("Text", _entity, "SatisFiyati1");
            calcAlışFiyatı1.DataBindings[0].FormattingEnabled = true;
            calcAlışFiyatı1.DataBindings[0].FormatString = "C2";

            calcSatışFiyatı2.DataBindings.Add("Text", _entity, "SatisFiyati2");
            calcAlışFiyatı1.DataBindings[0].FormattingEnabled = true;
            calcAlışFiyatı1.DataBindings[0].FormatString = "C2";

            calcAlışKdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcAlışFiyatı1.DataBindings[0].FormattingEnabled = true;
            calcAlışFiyatı1.DataBindings[0].FormatString = "C2";

            calcSatışKdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcAlışFiyatı1.DataBindings[0].FormattingEnabled = true;
            calcAlışFiyatı1.DataBindings[0].FormatString = "C2";
        }

        private void FrmStokIslem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stokDal.AddOrUpdate(context, _entity);
            stokDal.Save(context);
            this.Close();
        }

        private void BtnKapatm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
