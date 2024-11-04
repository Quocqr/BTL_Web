<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xoa.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Xoa" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Xóa Bài Viết</title>
    <link rel="stylesheet" type="text/css" href="Content/Xoa.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Xóa Bài Viết</h2>
            <label for="txtTitle">Nhập Tiêu Đề Bài Viết Cần Xóa:</label>
            <input type="text" id="txtTitle" runat="server" class="form-input" />
            <button type="button" id="btnDelete" runat="server" onserverclick="btnDelete_ServerClick">Xóa bài</button>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>