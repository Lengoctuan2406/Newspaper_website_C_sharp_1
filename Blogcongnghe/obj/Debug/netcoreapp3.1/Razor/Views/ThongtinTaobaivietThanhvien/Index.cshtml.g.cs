#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e137b93e1a25995dcd4ad3aea48937622cc72b6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongtinTaobaivietThanhvien_Index), @"mvc.1.0.view", @"/Views/ThongtinTaobaivietThanhvien/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e137b93e1a25995dcd4ad3aea48937622cc72b6d", @"/Views/ThongtinTaobaivietThanhvien/Index.cshtml")]
    public class Views_ThongtinTaobaivietThanhvien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Models.StoreContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
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
#line 19 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                         foreach (var theloai in Model.Laytheloai())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 904, "\"", 952, 2);
            WriteAttributeValue("", 911, "/TheloaiBaiviet/Index/?MATL=", 911, 28, true);
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 939, theloai.MATL, 939, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                               Write(theloai.TENTL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 22 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n                <li><a class=\"nav-link scrollto\" href=\"/ThongtinDoanhnghiep/Index\">Giới thiệu</a></li>\r\n");
#nullable restore
#line 26 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                 if (Model.Laythanhvien().EMAIL == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Index\">Đăng nhập</a></li>\r\n                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Dangki\">Đăng kí</a></li>\r\n");
#nullable restore
#line 30 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
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
#line 35 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 1716, Model.Laythanhvien().MATV, 1716, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chào Quản Trị Viên</a></li>\r\n");
#nullable restore
#line 36 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                    }
                    else if (Model.Laythanhvien().QUYENDN == 0 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto active\" href=\"/ThongtinThanhvien/Index\">Chào ");
#nullable restore
#line 39 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                                                Write(Model.Laythanhvien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 40 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
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
                            <a class=""nav-link collapsed"" href=""/ThongtinBaivietThanhvien/Index"">
                                <i class=""bi bi-card-list""></i>
                                <span>Bài viết hiện có</span>
                            </a>
                        </li>
            ");
            WriteLiteral(@"            <li class=""nav-item"">
                            <a class=""nav-link"" href=""/ThongtinTaobaivietThanhvien/Index"">
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
                <section class=""section profile"">
                    <div class=""row"">
                        <div class=""col-xl-12"">
                            <div class=""card"">
                                <div class=""card-body pt-3"">
  ");
            WriteLiteral(@"                                  <ul class=""nav nav-tabs nav-tabs-bordered"">
                                        <li class=""nav-item"">
                                            <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#create-post"">Tạo bài viết</button>
                                        </li>
                                    </ul>
                                    <div class=""tab-content pt-2"">
                                        <div class=""tab-pane fade show active profile-edit pt-3"" id=""create-post"">
                                            <form action=""/ThongtinTaobaivietThanhvien/Taobaiviet"" enctype=""multipart/form-data"" method=""post"">
                                                <div class=""row mb-3"">
                                                    <label class=""col-sm-3 col-form-label"">Chọn thể loại</label>
                                                    <div class=""col-sm-9"">
                                                   ");
            WriteLiteral("     <select name=\"MATL\" class=\"form-select\">\r\n");
#nullable restore
#line 98 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                             foreach (var theloai in Model.Laytheloai())
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <option");
            BeginWriteAttribute("value", " value=\"", 5472, "\"", 5493, 1);
#nullable restore
#line 100 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 5480, theloai.MATL, 5480, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                                         Write(theloai.TENTL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 101 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </select>
                                                    </div>
                                                </div>
                                                <div class=""row mb-3"">
                                                    <label for=""profileImage"" class=""col-md-4 col-lg-3 col-form-label"">Ảnh bài viết</label>
                                                    <div class=""col-md-3"">
                                                        <input type=""file"" name=""ANH1"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                    <div class=""col-md-3"">
                                                        <input type=""file"" name=""ANH2"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                    <div class=""col-");
            WriteLiteral(@"md-3"">
                                                        <input type=""file"" name=""ANH3"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                </div>
                                                <div class=""row mb-3"">
                                                    <label for=""tieude"" class=""col-md-4 col-lg-3 col-form-label"">Tiêu đề</label>
                                                    <div class=""col-md-8 col-lg-9"">
                                                        <input name=""MATV"" type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 7250, "\"", 7284, 1);
#nullable restore
#line 120 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 7258, Model.Laythanhvien().MATV, 7258, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                        <input name=""TIEUDE"" type=""text"" class=""form-control"" id=""tieude"" value=""Viết gì đó..."">
                                                    </div>
                                                </div>
                                                <div class=""row mb-3"">
                                                    <label for=""noidung"" class=""col-md-4 col-lg-3 col-form-label"">Nội dung</label>
                                                    <div class=""col-md-8 col-lg-9"">
                                                        <textarea name=""NOIDUNG"" class=""form-control"" id=""noidung"" style=""height: 500px"">Viết gì đó...</textarea>
                                                    </div>
                                                </div>
                                                <div class=""text-center"">
                                                    <button type=""submit"" class=""btn btn-primary"">Tạo bài viết</bu");
            WriteLiteral(@"tton>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
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
