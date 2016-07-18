using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpaddressMultiRowSample
{
    class AddressData
    {
        /**
         * 郵便番号
         */
        public string postal { get; set; }

        /**
         * 住所（漢字）
         */
        public string address1 { get; set; }

        /**
         * 住所（カナ）
         */
        public string address_kana { get; set; }
    }
}
