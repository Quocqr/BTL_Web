<%@ Page Title="Đăng nhập" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Dangnhap.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Dangnhap" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
   <link href="Content/Dangnhap.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="containerbody-content">
        <form action="Dangnhap.aspx" id="form1" method="post" runat="server" onsubmit="return check();">
        <div class="container">
            <h1 align="center">ĐĂNG NHẬP</h1>
            <div class="form-field">
                <label for="tendn">Tên đăng nhập:</label>
                <input type="text" id="tendn" name="tendn" placeholder="Nhập tên đăng nhập" required ="required" aria-describedby="loitendn" />
                <span id="loitendn" class="error"></span>
            </div>

            <div class="form-field">
                <label for="matkhau">Mật khẩu:</label>
                <input type="password" id="matkhau" name="matkhau" placeholder="Nhập mật khẩu" required ="required" aria-describedby="loimk"/>
                <span id="loimk" class="error"></span>
            </div>

            <div class="button-container">
                <button type="submit">Đăng Nhập</button>
                <button type="reset">Hủy</button>
            </div>
        </div>
    </form>
        </div>

    <script>
        function check() {
            let isValid = true;

            // Tên đăng nhập
            const tendn = document.getElementById("tendn").value;
            const loitendn = document.getElementById("loitendn");
            if (tendn.length < 5 || tendn.length > 20) {
                loitendn.textContent = "Tên đăng nhập phải từ 5 đến 20 ký tự.";
                isValid = false;
            } else {
                loitendn.textContent = "";
            }


            // Mật khẩu
            const matkhau = document.getElementById("matkhau").value;
            const loimk = document.getElementById("loimk");
            if (matkhau.length < 6) {
                loimk.textContent = "Mật khẩu phải có ít nhất 6 ký tự.";
                isValid = false;
            } else {
                loimk.textContent = "";
            }


            // Ngăn form được gửi nếu không hợp lệ
            return isValid;
        }
    </script>
</asp:Content>
