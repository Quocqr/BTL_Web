using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trang_thong_tin_dien_tu_HOU
{
    public partial class Sua : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = Request.Form["txtTitle"];
            string newContent = Request.Form["txtNewContent"];

            if (string.IsNullOrEmpty(title))
            {
                Response.Write("<script>alert('Lỗi !!!');</script>");
                return;
            }

            List<Post> posts = (List<Post>)Application["Posts"];

            if (posts == null)
            {
                Response.Write("<script>alert('Không có bài viết nào để sửa!');</script>");
                return;
            }

            Post postToEdit = posts.Find(p => p.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (postToEdit != null)
            {
                postToEdit.Content = newContent;
                Application["Posts"] = posts;  // Cập nhật lại Application
                Response.Write("<script>alert('Đã cập nhật nội dung bài viết: " + title + "');</script>");
                Response.Redirect("Trangchu.aspx");
            }
            else
            {
                Response.Write("<script>alert('Không tìm thấy bài viết với tiêu đề: " + title + "');</script>");
            }
        }
    }
}