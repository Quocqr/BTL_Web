using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trang_thong_tin_dien_tu_HOU
{
    public partial class Them : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string title = Request.Form["txtTitle"];
            string content = Request.Form["txtContent"];
            string imageUrl = Request.Form["txtImageUrl"];




            Post newPost = new Post(title, content);

            if (Application["Posts"] == null)
            {
                Application["Posts"] = new List<Post>();
            }
            ((List<Post>)Application["Posts"]).Add(newPost);

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
            {
                // Lưu bài viết vào bộ nhớ tạm hoặc database (nếu có)
                // Giả lập lưu vào Session để hiển thị trên Trang chủ

                Session["NewPostTitle"] = title;
                Session["NewPostContent"] = content;
                Session["NewPostImageUrl"] = imageUrl;

                // Chuyển hướng về trang chủ
                Response.Redirect("Trangchu.aspx");
            }
            else
            {
                // Thông báo lỗi nếu thiếu thông tin
                Response.Write("<script>alert('Vui lòng nhập đầy đủ tiêu đề và nội dung');</script>");
            }
        }

    }
}