using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trang_thong_tin_dien_tu_HOU
{
    public partial class Trangchu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPosts();
                LoadAllPosts();
            }
            if (Application["Posts"] != null)
            {
                Repeater rptPosts = (Repeater)FindControl("rptPosts");
                List<Post> posts = (List<Post>)Application["Posts"];
                rptPosts.DataSource = posts; // Gán danh sách bài viết cho Repeater
                rptPosts.DataBind(); // Liên kết dữ liệu
            }
        }
        private void BindPosts()
        {
            var posts = (List<Post>)Application["Posts"];
            Repeater rptPosts = (Repeater)FindControl("rptPosts");
            if (rptPosts != null)
            {
                rptPosts.DataSource = posts;
                rptPosts.DataBind();
            }
        }


        private void LoadAllPosts()
        {
            var posts = (List<Post>)Application["Posts"];
            Repeater rptPosts = (Repeater)FindControl("rptPosts");
            if (rptPosts != null)
            {
                rptPosts.DataSource = posts;
                rptPosts.DataBind();
            }
        }
        protected void btnSearch_ServerClick(object sender, EventArgs e)
        {
            string keyword = Request.Form["txtSearch"];
            string searchTerm = Request.Form["txtSearch"];
            Repeater rptPosts = (Repeater)FindControl("rptPosts");
            if (!string.IsNullOrEmpty(keyword))
            {
                // Lấy danh sách bài viết từ Application
                List<Post> posts = (List<Post>)Application["Posts"];
                if (posts != null)
                {
                    // Lọc danh sách bài viết chứa từ khóa
                    var filteredPosts = posts.Where(p => p.Title.Equals(keyword, StringComparison.OrdinalIgnoreCase) ||
                                                          p.Content.Equals(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (filteredPosts.Any())
                    {
                        Response.Write("<script>alert('Kết quả tìm kiếm cho: " + keyword + "');</script>");
                        rptPosts.DataSource = filteredPosts;
                    }
                    else
                    {
                        Response.Write("<script>alert('Không tìm thấy kết quả tìm kiếm cho: " + keyword + "');</script>");
                        rptPosts.DataSource = null;
                    }
                    rptPosts.DataBind();
                }
            }
            else
            {
                LoadAllPosts();
            }
        }
    }
}