#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d45ee01eda81d2c694152f115355c9272e9b64a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongtinBaivietThanhvien_Index), @"mvc.1.0.view", @"/Views/ThongtinBaivietThanhvien/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45ee01eda81d2c694152f115355c9272e9b64a4", @"/Views/ThongtinBaivietThanhvien/Index.cshtml")]
    public class Views_ThongtinBaivietThanhvien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Models.StoreContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
 if (Model.Laythanhvien().EMAIL == null)
{
    Layout = "~/Views/Shared/_Layoutuser-trang.cshtml";
}
else
{
    Layout = "~/Views/Shared/_Layoutuser-" + Model.Laythanhvien().MAUNEN + ".cshtml";
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header id=""header"" class=""d-flex align-items-center"">
    <div class=""container d-flex align-items-center justify-content-between"">
        <h1 class=""logo""><a href=""/Index/Index"">Phoenix Blog<span>.</span></a></h1>
        <nav id=""navbar"" class=""navbar"">
            <ul>
                <li><a class=""nav-link scrollto"" href=""/Index/Index"">Trang chủ</a></li>
                <li class=""dropdown"">
                    <a href=""#""><span>Thể Loại</span> <i class=""bi bi-chevron-down""></i></a>
                    <ul>
");
#nullable restore
#line 19 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                         foreach (var theloai in Model.Laytheloai())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 904, "\"", 952, 2);
            WriteAttributeValue("", 911, "/TheloaiBaiviet/Index/?MATL=", 911, 28, true);
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 939, theloai.MATL, 939, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                                               Write(theloai.TENTL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 22 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n                <li><a class=\"nav-link scrollto\" href=\"/ThongtinDoanhnghiep/Index\">Giới thiệu</a></li>\r\n");
#nullable restore
#line 26 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                 if (Model.Laythanhvien().EMAIL == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Index\">Đăng nhập</a></li>\r\n                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Dangki\">Đăng kí</a></li>\r\n");
#nullable restore
#line 30 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                }
                else
                {
                    if (Model.Laythanhvien().QUYENDN == 1 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto\"");
            BeginWriteAttribute("href", " href=\"", 1680, "\"", 1742, 2);
            WriteAttributeValue("", 1687, "/Admin/IndexAdmin/Index?MATV=", 1687, 29, true);
#nullable restore
#line 35 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 1716, Model.Laythanhvien().MATV, 1716, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chào Quản Trị Viên</a></li>\r\n");
#nullable restore
#line 36 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                    }
                    else if (Model.Laythanhvien().QUYENDN == 0 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto active\" href=\"/ThongtinThanhvien/Index\">Chào ");
#nullable restore
#line 39 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                                                                Write(Model.Laythanhvien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 40 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
            <i class=""bi bi-list mobile-nav-toggle""></i>
        </nav>
    </div>
</header>
<main id=""main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <aside id=""sidebar"" class=""sidebar"">
                    <ul class=""sidebar-nav"" id=""sidebar-nav"">
                        <li class=""nav-item"">
                            <a class=""nav-link collapsed"" href=""/ThongtinThanhvien/Index"">
                                <i class=""bi bi-person""></i>
                                <span>Thông tin cá nhân</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/ThongtinBaivietThanhvien/Index"">
                                <i class=""bi bi-card-list""></i>
                                <span>Bài viết hiện có</span>
                            </a>
                        </li>
                      ");
            WriteLiteral(@"  <li class=""nav-item"">
                            <a class=""nav-link collapsed"" href=""/ThongtinTaobaivietThanhvien/Index"">
                                <i class=""bi bi-card-list""></i>
                                <span>Tạo bài viết mới</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link collapsed"" href=""/ThongtinBaivietThanhvien/Dangxuat"">
                                <i class=""bi bi-box-arrow-in-right""></i>
                                <span>Đăng xuất</span>
                            </a>
                        </li>
                    </ul>
                </aside>
            </div>
            <div class=""col-lg-9"">
                <section class=""section"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""card"">
                                <div class=""card-body"">
               ");
            WriteLiteral(@"                     <h5 class=""card-title"">Các bài viết bị từ chối</h5>
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th scope=""col"">Tiêu đề</th>
                                                <th scope=""col"">Lượt thích</th>
                                                <th scope=""col"">Bình luận</th>
                                                <th scope=""col"">Trạng thái</th>
                                                <th scope=""col"" colspan=""2"" style=""text-align: center;"">Chức năng</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 98 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                             foreach (var baiviettuchoi in Model.LaybaivietThanhvien())
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                 if (baiviettuchoi.MADUYET == 3)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <th scope=\"row\" style=\"width:400px\"><a");
            BeginWriteAttribute("href", " href=\"", 5420, "\"", 5507, 2);
            WriteAttributeValue("", 5427, "/ThongtinBaivietThanhvien/XembaivietThanhvien?MABAIDANG=", 5427, 56, true);
#nullable restore
#line 103 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 5483, baiviettuchoi.MABAIDANG, 5483, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 103 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                                                                                                                                                  Write(baiviettuchoi.TIEUDE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                                                        <td>");
#nullable restore
#line 104 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                       Write(baiviettuchoi.SOLUOTTHICH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 105 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                       Write(baiviettuchoi.SOLUONGBINHLUAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td><span class=\"badge bg-danger\">Từ chối</span></td>\r\n                                                        <th scope=\"col\"><a");
            BeginWriteAttribute("href", " href=\"", 5916, "\"", 6010, 2);
            WriteAttributeValue("", 5923, "/ThongtinBaivietThanhvien/XembaivietcapnhatThanhvien?MABAIDANG=", 5923, 63, true);
#nullable restore
#line 107 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 5986, baiviettuchoi.MABAIDANG, 5986, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Cập nhật</a></th>\r\n                                                        <th scope=\"col\"><a");
            BeginWriteAttribute("href", " href=\"", 6129, "\"", 6216, 2);
            WriteAttributeValue("", 6136, "/ThongtinBaivietThanhvien/XoaBaivietMABAIDANG?MABAIDANG=", 6136, 56, true);
#nullable restore
#line 108 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 6192, baiviettuchoi.MABAIDANG, 6192, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Xóa</a></th>\r\n                                                    </tr>\r\n");
#nullable restore
#line 110 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Các bài viết đang duyệt</h5>
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th scope=""col"">Tiêu đề</th>
                                                <th scope=""col"">Lượt thích</th>
                                                <th scope=""col"">Bình luận</th>
                                                <th scope=""col"">Trạng thái</th>
                                                <th scope=""col"" colspan=""2"" style=""text-align: center;"">Function</th>
                                            </tr>
          ");
            WriteLiteral("                              </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 130 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                             foreach (var baivietdangduyet in Model.LaybaivietThanhvien())
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                 if (baivietdangduyet.MADUYET == 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <th scope=\"row\" style=\"width:400px\"><a");
            BeginWriteAttribute("href", " href=\"", 7968, "\"", 8058, 2);
            WriteAttributeValue("", 7975, "/ThongtinBaivietThanhvien/XembaivietThanhvien?MABAIDANG=", 7975, 56, true);
#nullable restore
#line 135 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 8031, baivietdangduyet.MABAIDANG, 8031, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 135 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                                                                                                                                                     Write(baivietdangduyet.TIEUDE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                                                        <td>");
#nullable restore
#line 136 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                       Write(baivietdangduyet.SOLUOTTHICH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 137 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                       Write(baivietdangduyet.SOLUONGBINHLUAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td><span class=\"badge bg-warning\">Đang duyệt</span></td>\r\n                                                        <th scope=\"col\"><a");
            BeginWriteAttribute("href", " href=\"", 8480, "\"", 8577, 2);
            WriteAttributeValue("", 8487, "/ThongtinBaivietThanhvien/XembaivietcapnhatThanhvien?MABAIDANG=", 8487, 63, true);
#nullable restore
#line 139 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 8550, baivietdangduyet.MABAIDANG, 8550, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Cập nhật</a></th>\r\n                                                        <th scope=\"col\"><a");
            BeginWriteAttribute("href", " href=\"", 8696, "\"", 8786, 2);
            WriteAttributeValue("", 8703, "/ThongtinBaivietThanhvien/XoaBaivietMABAIDANG?MABAIDANG=", 8703, 56, true);
#nullable restore
#line 140 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 8759, baivietdangduyet.MABAIDANG, 8759, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Xóa</a></th>\r\n                                                    </tr>\r\n");
#nullable restore
#line 142 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Các bài viết đã duyệt</h5>
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th scope=""col"">Tiêu đề</th>
                                                <th scope=""col"">Lượt thích</th>
                                                <th scope=""col"">Bình luận</th>
                                                <th scope=""col"">Trạng thái</th>
                                                <th scope=""col"" colspan=""2"" style=""text-align: center;"">Function</th>
                                            </tr>
            ");
            WriteLiteral("                            </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 162 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                             foreach (var baivietdaduyet in Model.LaybaivietThanhvien())
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                 if (baivietdaduyet.MADUYET == 2)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <th scope=\"row\" style=\"width:400px\"><a");
            BeginWriteAttribute("href", " href=\"", 10532, "\"", 10620, 2);
            WriteAttributeValue("", 10539, "/ThongtinBaivietThanhvien/XembaivietThanhvien?MABAIDANG=", 10539, 56, true);
#nullable restore
#line 167 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 10595, baivietdaduyet.MABAIDANG, 10595, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 167 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                                                                                                                                                   Write(baivietdaduyet.TIEUDE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                                                        <td>");
#nullable restore
#line 168 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                       Write(baivietdaduyet.SOLUOTTHICH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 169 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                       Write(baivietdaduyet.SOLUONGBINHLUAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td><span class=\"badge bg-success\">Chấp nhận</span></td>\r\n                                                        <th scope=\"col\"><a");
            BeginWriteAttribute("href", " href=\"", 11035, "\"", 11130, 2);
            WriteAttributeValue("", 11042, "/ThongtinBaivietThanhvien/XembaivietcapnhatThanhvien?MABAIDANG=", 11042, 63, true);
#nullable restore
#line 171 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 11105, baivietdaduyet.MABAIDANG, 11105, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Cập nhật</a></th>\r\n                                                        <th scope=\"col\"><a");
            BeginWriteAttribute("href", " href=\"", 11249, "\"", 11337, 2);
            WriteAttributeValue("", 11256, "/ThongtinBaivietThanhvien/XoaBaivietMABAIDANG?MABAIDANG=", 11256, 56, true);
#nullable restore
#line 172 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 11312, baivietdaduyet.MABAIDANG, 11312, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Xóa</a></th>\r\n                                                    </tr>\r\n");
#nullable restore
#line 174 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </div>
</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blogcongnghe.Models.StoreContext> Html { get; private set; }
    }
}
#pragma warning restore 1591