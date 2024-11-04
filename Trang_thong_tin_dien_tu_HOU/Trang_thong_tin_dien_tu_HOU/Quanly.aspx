<%@ Page Title="Quản lý" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Quanly.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Quanly" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
   <link  rel="stylesheet" type="text/css"  />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="containerbody-content">
    

    <main class="contact-main">
        <h1>Quản lý Bài Viết</h1>
        <div class="button-container">
            <button onclick="location.href='Them.aspx';">Thêm Bài Viết</button>
            <button onclick="location.href='Xoa.aspx';">Xóa Bài Viết</button>
            <button onclick="location.href='Sua.aspx';">Sửa Bài Viết</button>
        </div>
    </main>
        </div>
</asp:Content>
