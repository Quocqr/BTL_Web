using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trang_thong_tin_dien_tu_HOU
{
    public partial class Xoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            string title = Request.Form["txtTitle"]; // Lấy giá trị từ ô nhập

            if (string.IsNullOrEmpty(title))
            {
                Response.Write("<script>alert('Lỗi !!!');</script>"); // Hiển thị thông báo lỗi
                return; // Dừng lại nếu không có tiêu đề
            }

            // Lấy danh sách bài viết từ Application
            List<Post> posts = (List<Post>)Application["Posts"];

            // Kiểm tra xem posts có giá trị không
            if (posts == null)
            {
                Response.Write("<script>alert('Không có bài viết nào để xóa!');</script>");
                return;
            }

            // Tìm bài viết theo tiêu đề
            Post postToDelete = posts.Find(p => p.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (postToDelete != null)
            {
                posts.Remove(postToDelete);
                Application["Posts"] = posts; // Cập nhật danh sách bài viết
                Response.Write("<script>alert('Đã xóa bài viết: " + title + "');</script>");
                Response.Redirect("Trangchu.aspx");
            }
            else
            {
                Response.Write("<script>alert('Không tìm thấy bài viết với tiêu đề: " + title + "');</script>");
            }
        }
    }
}