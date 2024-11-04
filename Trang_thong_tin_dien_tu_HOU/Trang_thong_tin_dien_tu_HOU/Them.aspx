<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Them.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Them" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thêm Bài Viết Mới</title>
    <link rel="stylesheet" type="text/css" href="Content/Them.css" />
</head>
<body>

    <form id="form1" runat="server" enctype="multipart/form-data">
        <div class="form-container">
            <div class="main-content">
            <h2>Thêm Bài Viết Mới</h2>
            <hr/>
                <asp:TextBox ID="txtTitle" runat="server" CssClass="title" Placeholder="Nhập tiêu đề" />

                <asp:TextBox ID="txtContent" runat="server" CssClass="content" Placeholder="Nhập nội dung" Rows="10" />
                <br /><br />

                <asp:FileUpload ID="uploadControl" runat="server" CssClass="file-upload" />
                <br /><br />

                <asp:Button ID="btnSubmit" runat="server" Text="Đăng bài" OnClick="BtnSubmit_Click" CssClass="btn-submit" />
            </div>
            </div>

    </form>
</body>
</html>