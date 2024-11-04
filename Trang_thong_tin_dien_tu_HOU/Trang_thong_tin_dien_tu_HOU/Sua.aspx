<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sua.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Sua" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Sửa Bài Đăng</title>
    <link rel="stylesheet" type="text/css" href="Content/Sua.css" />
</head>
<body>
    <div class="form-container">
        <h2>Sửa Bài Đăng</h2>
        <form runat="server">
            <label for="txtTitle">Tiêu đề bài đăng cần sửa:</label>
            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-input" />

            <label for="txtNewContent">Nội dung mới:</label>
            <asp:TextBox ID="txtNewContent" TextMode="MultiLine" runat="server" CssClass="form-input" Rows="6" />

            <asp:Button ID="btnUpdate" Text="Cập nhật" runat="server" CssClass="btn-submit" OnClick="btnUpdate_Click" />

            <asp:Label ID="lblMessage" runat="server" CssClass="message-label"></asp:Label>
        </form>
    </div>
</body>
</html>
