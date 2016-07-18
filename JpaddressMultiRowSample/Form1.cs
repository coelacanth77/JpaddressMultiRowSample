using GrapeCity.Win.MultiRow;
using GrapeCity.Win.MultiRow.InputMan;
using GrapeCity.Win.MultiRow.PlusPak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpaddressMultiRowSample
{
    public partial class Form1 : Form
    {
        private List<AddressData> data;
        public Form1()
        {
            InitializeComponent();

            this.data = new List<AddressData>();
            this.data.Add(new AddressData() { postal = "9200021", address1 = "石川県金沢市七ツ屋町", address_kana = "ｲｼｶﾜｹﾝｶﾅｻﾞﾜｼﾅﾅﾂﾔﾏﾁ" });
            this.data.Add(new AddressData() { postal = "2140021", address1 = "神奈川県川崎市多摩区宿河原", address_kana = "ｶﾅｶﾞﾜｹﾝｶﾜｻｷｼﾀﾏｸｼｭｸｶﾞﾜﾗ" });

            this.gcMultiRow1.DataSource = data;
        }
    }
}
