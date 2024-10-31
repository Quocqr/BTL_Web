using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trang_thong_tin_dien_tu_HOU
{
    public class TinTuc
    {
        public string id { get; set; }
        public string tieu_de { get; set; }
        public string img { get; set; }
        public string noi_dung { get; set; }

        public TinTuc(string id, string tieu_de, string img, string noi_dung)
        {
            this.id = id;
            this.tieu_de = tieu_de;
            this.img = img;
            this.noi_dung = noi_dung;
        }
    }
}