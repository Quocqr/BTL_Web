using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; // Thêm thư viện này để làm việc với JSON

namespace Trang_thong_tin_dien_tu_HOU
{
    public partial class Tintuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Đọc dữ liệu JSON từ file
            string jsonFilePath = Server.MapPath("~/data/Tin-tuc_and_thong_bao.json");
            string jsonData = File.ReadAllText(jsonFilePath);

            // Parse đối tượng JSON
            var jsonObject = JObject.Parse(jsonData);

            // Lấy danh sách TinTuc từ JSON
            var tinTucList = jsonObject["TinTuc"].ToObject<List<TinTuc>>();

            foreach (var tinTuc in tinTucList)
            {
                khoi1.InnerHtml += $@"
                    <div id='{tinTuc.id}' class='event-class'>
                        <img src='{tinTuc.img}' alt='{tinTuc.tieu_de}'  />
                        <div class='event-content'>
                            <p class='event-title'>{tinTuc.tieu_de}</p>
                            <a href='chinh.aspx?id={tinTuc.id}' class='read-more' >Đọc thêm</a>
                        </div>
                    </div>";
            }
            // Lấy danh sách ThongBao từ JSON
            var thongBaoList = jsonObject["Thong_bao"].ToObject<List<TinTuc>>();
            foreach (var thongBao in thongBaoList)
            {
                khoi2.InnerHtml += $@"<div id='{thongBao.id}' class='event-class'>
                                        <img src='{thongBao.img}' alt='{thongBao.tieu_de}'  />
                                        <div class='event-content'>
                                            <p class='event-title'>{thongBao.tieu_de}</p>
                                            <a href='chinh.aspx?id={thongBao.id}' class='read-more'>Đọc thêm</a>
                                        </div>
                                     </div>";

            }

            // Khai báo phần tử server control
            //protected global::System.Web.UI.HtmlControls.HtmlGenericControl khoi1;
        }
    }
}
