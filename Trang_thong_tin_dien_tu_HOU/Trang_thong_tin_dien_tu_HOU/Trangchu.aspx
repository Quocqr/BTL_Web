<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trangchu.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Trangchu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Chủ</title>
<link rel="stylesheet" type="text/css" href="Content/Trangchu.css" />
<link rel="icon" href="data:;base64,iVBORw0KGgo=">
</head>
<body>
    <form id="form1" runat="server">
        <header>  
    <nav class="navbar">
        <img src="img/logo.png" alt="Logo" class="logo">
        <div class="hamburger" onclick="toggleMenu()">☰</div>

        <ul class="nav-list">
            <li><a href="Trangchu.aspx">Trang chủ</a></li>
            <li><a href="Quanly.aspx">Quản lý</a></li>
            <li><a href="Gioithieu.aspx">Giới thiệu</a></li>
            <li><a href="Tintuc.aspx">Tin tức</a></li>
            <li><a href="Lienhe.aspx">Liên Hệ</a></li>
            <li><a href="Dangky.aspx">Đăng Ký</a></li>
            <li><a href="Dangnhap.aspx">Đăng Nhập</a></li>
        </ul>
        
        <!-- Thanh tìm kiếm -->
        <div>
            <asp:TextBox ID="txtSearch" runat="server" placeholder="Nhập từ khóa..." />
            <asp:Button ID="btnSearch" runat="server" Text="Tìm" OnClick="btnSearch_ServerClick" CssClass="search-button" />
        </div>
    </nav>
</header>

<h1>Chào mừng đến với Trang thông tin của Trường Đại học Mở Hà Nội</h1>

<!-- Hiển thị bài viết -->
<asp:Repeater ID="rptPosts" runat="server">
    <ItemTemplate>
        <div class="img-grid">
            <h3><%# Eval("Title") %></h3>
            <p><%# Eval("Content") %></p>
            <hr />
        </div>
    </ItemTemplate>
</asp:Repeater>

<footer class="footer">
    <div class="footer-logo">
        <img src="img/logo.png" alt="Logo dưới" class="logo-footer">
    </div>
    <div class="footer-content">
        <h3>Trường Đại học Mở Hà Nội</h3>
        <p>Địa chỉ: Nhà B101, phố Nguyễn Hiền, phường Bách Khoa, quận Hai Bà Trưng, TP Hà Nội</p>
        <p>Điện thoại: 024.38682321</p>
        <p>Email: mhn@hou.edu.vn</p>
    </div>
</footer>
    </form>
</body>
</html>
