<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tintuc.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Tintuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link href="Content/Tintuc.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main-conten-off">
        <h2>TIN TỨC </h2><br />
        <div class="event" id="khoi1" runat="server">
            
            <!-- <div id="event-id" class="event-class">

             </div>-->
        </div><br />
        <h2>THÔNG BÁO</h2><br />
        <div class="event" id="khoi2" runat="server">
            
            <!--<div id="Notification-id" class="Notification-class">

            </div>-->

        </div>
    </div>
</asp:Content>
