<%@ Page Title="Liên hệ" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Lienhe.aspx.cs" Inherits="Trang_thong_tin_dien_tu_HOU.Lienhe" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
    <link href="Content/Lienhe.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="containerbody-content">
    <main class="contact-main">
        <div class="contact-container">
            <div class="contact-info">
                <section>
                    <h2>Thông tin liên hệ</h2>
                    <p>Địa chỉ: Nhà B101, phố Nguyễn Hiền, phường Bách Khoa, quận Hai Bà Trưng, TP Hà Nội</p>
                    <p>Số điện thoại: 024.3868.2321</p>
                    <p>Email: mhn@hou.edu.vn</p>
                </section>
            </div>
            <div class="contact-map">
                <section>
                    <h2>Bản đồ</h2>
                    <!-- Embedding a Google Map -->
                    <iframe src="https://maps.google.com/maps?q=Tr%C6%B0%E1%BB%9Dng%20%C4%90%E1%BA%A1i%20h%E1%BB%8Dc%20M%E1%BB%9F%20H%C3%A0%20N%E1%BB%99i&t=&z=13&ie=UTF8&iwloc=&output=embed" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
                </section>
            </div>
        </div>
        <section>
            <h2>Liên hệ chúng tôi</h2>
            <div class="container">
                <div class="formBox">
                    <form>
                        <div class="inputBox">
                            <input type="text" name="" required="required" />
                            <span>Họ và tên</span>
                        </div>
                        <div class="inputBox">
                            <input type="email" name="" required="required" />
                            <span>Email</span>
                        </div>
                        <div class="inputBox">
                            <textarea name="" required="required"></textarea>
                            <span>Nội dung liên hệ</span>
                        </div>
                        <div class="inputBox">
                            <input type="Submit" name="" value="Gửi thông tin" />
                        </div>
                    </form>
                </div>
            </div>
        </section>
    </main>
        </div>
</asp:Content>
