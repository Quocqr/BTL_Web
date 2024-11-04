using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trang_thong_tin_dien_tu_HOU
{
    public partial class Dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Lấy thông tin từ form
                string tendn = Request.Form["tendn"];
                string matkhau = Request.Form["matkhau"];
                string checkmk = Request.Form["checkmk"];

                // Đọc thông tin tài khoản từ file users.txt
                List<User> users = LoadUsersFromFile();

                // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                if (!users.Exists(u => u.Username == tendn))
                {
                    // Kiểm tra mật khẩu và xác nhận mật khẩu có khớp không
                    if (matkhau == checkmk)
                    {
                        // Thêm tài khoản mới vào danh sách
                        users.Add(new User(tendn, matkhau));

                        // Lưu tất cả tài khoản vào file users.txt
                        SaveAllUsersToFile(users);

                        // Hiển thị thông báo và chuyển hướng đến trang đăng nhập
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Đăng ký thành công!'); window.location='dangnhap.aspx';", true);
                    }
                    else
                    {
                        Response.Write("<script>alert('Mật khẩu và mật khẩu xác nhận không khớp!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Tên đăng ký đã tồn tại!');</script>");
                }
            }
        }
        // Hàm lưu tất cả tài khoản từ Application vào file users.txt
        private void SaveAllUsersToFile(List<User> users)
        {
            string path = Server.MapPath("~/data/users.txt");
            using (StreamWriter sw = new StreamWriter(path, false)) // 'false' để ghi đè nội dung cũ
            {
                foreach (var user in users)
                {
                    // Ghi thông tin vào file, định dạng: username,password
                    sw.WriteLine($"{user.Username},{user.Password}");
                }
            }
        }

        // Hàm tải danh sách người dùng từ file users.txt
        private List<User> LoadUsersFromFile()
        {
            List<User> users = new List<User>();
            string path = Server.MapPath("~/data/users.txt");

            // Kiểm tra nếu file tồn tại
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2) // Đảm bảo định dạng là username,password
                        {
                            users.Add(new User(parts[0], parts[1]));
                        }
                    }
                }
            }

            return users;
        }
    }
}