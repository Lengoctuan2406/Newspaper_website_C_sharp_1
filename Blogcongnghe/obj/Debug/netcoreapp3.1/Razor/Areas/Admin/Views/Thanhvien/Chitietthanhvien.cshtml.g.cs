#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756b4e839621316b8a36aceab2aa95929723b2dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Thanhvien_Chitietthanhvien), @"mvc.1.0.view", @"/Areas/Admin/Views/Thanhvien/Chitietthanhvien.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756b4e839621316b8a36aceab2aa95929723b2dd", @"/Areas/Admin/Views/Thanhvien/Chitietthanhvien.cshtml")]
    public class Areas_Admin_Views_Thanhvien_Chitietthanhvien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Areas.Admin.Models.StoreContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Không có"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header id=""header"" class=""header fixed-top d-flex align-items-center"">
    <div class=""d-flex align-items-center justify-content-between"">
        <i class=""bi bi-list toggle-sidebar-btn""></i>
    </div>
    <nav class=""header-nav ms-auto"">
        <ul class=""d-flex align-items-center"">
            <li class=""nav-item d-block d-lg-none"">
                <a class=""nav-link nav-icon search-bar-toggle "" href=""#"">
                    <i class=""bi bi-search""></i>
                </a>
            </li>
            <li class=""nav-item dropdown pe-3"">
                <a class=""nav-link nav-profile d-flex align-items-center pe-0"" href=""#"" data-bs-toggle=""dropdown"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "756b4e839621316b8a36aceab2aa95929723b2dd4810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 833, "~/img_add/", 833, 10, true);
#nullable restore
#line 18 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
AddHtmlAttributeValue("", 843, Model.Layquantrivien().ANHDD, 843, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <span class=\"d-none d-md-block dropdown-toggle ps-2\">");
#nullable restore
#line 19 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                                    Write(Model.Layquantrivien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </a>\r\n                <ul class=\"dropdown-menu dropdown-menu-end dropdown-menu-arrow profile\">\r\n                    <li class=\"dropdown-header\">\r\n                        <h6>");
#nullable restore
#line 23 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                       Write(Model.Layquantrivien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    </li>
                    <li>
                        <hr class=""dropdown-divider"">
                    </li>
                    <li>
                        <a class=""dropdown-item d-flex align-items-center"" href=""/Admin/IndexAdmin/Thongtinquantrivien"">
                            <i class=""bi bi-person""></i>
                            <span>Thông tin của tôi</span>
                        </a>
                    </li>
                    <li>
                        <hr class=""dropdown-divider"">
                    </li>
                    <li>
                        <a class=""dropdown-item d-flex align-items-center"" href=""/Index/Index"">
                            <i class=""bi bi-person""></i>
                            <span>Trang chủ</span>
                        </a>
                    </li>
                    <li>
                        <hr class=""dropdown-divider"">
                    </li>
                    <li>
                        <a ");
            WriteLiteral(@"class=""dropdown-item d-flex align-items-center"" href=""/Admin/IndexAdmin/Dangxuat"">
                            <i class=""bi bi-box-arrow-right""></i>
                            <span>Đăng xuất</span>
                        </a>
                    </li>
                </ul>
            </li>
        </ul>
    </nav>
</header>
<aside id=""sidebar"" class=""sidebar"">
    <ul class=""sidebar-nav"" id=""sidebar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""/Admin/IndexAdmin/Index"">
                <i class=""bi bi-grid""></i>
                <span>Tổng quát</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""/Admin/Taobaiviet/Index"">
                <i class=""bi bi-layout-text-window-reverse""></i>
                <span>Tạo bài viết</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" data-bs-target=""#tables-nav"" data-bs-toggle=""collapse"" ");
            WriteLiteral(@"href=""#"">
                <i class=""bi bi-layout-text-window-reverse""></i><span>Bài viết</span><i class=""bi bi-chevron-down ms-auto""></i>
            </a>
            <ul id=""tables-nav"" class=""nav-content collapse"" data-bs-parent=""#sidebar-nav"">
                <li>
                    <a href=""/Admin/BaivietAdmin/IndexBaivietDangduyet"">
                        <i class=""bi bi-circle""></i><span>Đang duyệt</span>
                    </a>
                </li>
                <li>
                    <a href=""/Admin/BaivietAdmin/IndexBaivietTuchoi"">
                        <i class=""bi bi-circle""></i><span>Từ chối</span>
                    </a>
                </li>
                <li>
                    <a href=""/Admin/BaivietAdmin/IndexBaivietChapnhan"">
                        <i class=""bi bi-circle""></i><span>Đã duyệt</span>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" data-bs-t");
            WriteLiteral(@"arget=""#tables-nav1"" data-bs-toggle=""collapse"" href=""#"">
                <i class=""bi bi-layout-text-window-reverse""></i><span>Bình luận</span><i class=""bi bi-chevron-down ms-auto""></i>
            </a>
            <ul id=""tables-nav1"" class=""nav-content collapse "" data-bs-parent=""#sidebar-nav"">
                <li>
                    <a href=""/Admin/Binhluan/IndexBinhluanDangduyet"">
                        <i class=""bi bi-circle""></i><span>Đang duyệt</span>
                    </a>
                </li>
                <li>
                    <a href=""/Admin/Binhluan/IndexBinhluanChapnhan"">
                        <i class=""bi bi-circle""></i><span>Đã duyệt</span>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-bs-target=""#tables-nav2"" data-bs-toggle=""collapse"" href=""#"">
                <i class=""bi bi-person""></i><span>Thành viên</span><i class=""bi bi-chevron-down ms-auto""></i>
            <");
            WriteLiteral(@"/a>
            <ul id=""tables-nav2"" class=""nav-content collapse "" data-bs-parent=""#sidebar-nav"">
                <li>
                    <a href=""/Admin/Thanhvien/Index"">
                        <i class=""bi bi-circle""></i><span>Tất cả</span>
                    </a>
                </li>
                <li>
                    <a href=""/Admin/Thanhvien/IndexTinnhan"">
                        <i class=""bi bi-circle""></i><span>Tin nhắn</span>
                    </a>
                </li>
            </ul>
        </li>
    </ul>
</aside>
<main id=""main"" class=""main"">
    <section class=""section profile"">
        <div class=""row"">
            <div class=""col-xl-4"">
                <div class=""card"">
                    <div class=""card-body profile-card pt-4 d-flex flex-column align-items-center"">

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "756b4e839621316b8a36aceab2aa95929723b2dd12712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6221, "~/img_add/", 6221, 10, true);
#nullable restore
#line 136 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
AddHtmlAttributeValue("", 6231, Model.LaythanhvienMATV1.ANHDD, 6231, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h2>");
#nullable restore
#line 137 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                       Write(Model.LaythanhvienMATV1.TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div class=\"social-links mt-2\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 6461, "\"", 6500, 1);
#nullable restore
#line 139 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
WriteAttributeValue("", 6468, Model.LaythanhvienMATV1.TWITTER, 6468, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"twitter\"><i class=\"bi bi-twitter\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 6583, "\"", 6623, 1);
#nullable restore
#line 140 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
WriteAttributeValue("", 6590, Model.LaythanhvienMATV1.FACEBOOK, 6590, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"facebook\"><i class=\"bi bi-facebook\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 6708, "\"", 6749, 1);
#nullable restore
#line 141 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
WriteAttributeValue("", 6715, Model.LaythanhvienMATV1.INSTAGRAM, 6715, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"instagram\"><i class=\"bi bi-instagram\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 6836, "\"", 6876, 1);
#nullable restore
#line 142 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
WriteAttributeValue("", 6843, Model.LaythanhvienMATV1.LINKEDIN, 6843, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""linkedin""><i class=""bi bi-linkedin""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-8"">
                <div class=""card"">
                    <div class=""card-body pt-3"">
                        <ul class=""nav nav-tabs nav-tabs-bordered"">
                            <li class=""nav-item"">
                                <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#profile-overview"">Thông tin</button>
                            </li>
                        </ul>
                        <div class=""tab-content pt-2"">
                            <div class=""tab-pane fade show active profile-overview"" id=""profile-overview"">
                                <h5 class=""card-title"">Giới thiệu</h5>
                                <p class=""small fst-italic"">");
#nullable restore
#line 158 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                       Write(Model.LaythanhvienMATV1.BIO);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <h5 class=""card-title"">Thông tin chi tiết</h5>
                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label "">Họ và tên</div>
                                    <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 162 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-3 col-md-4 label\">Địa chỉ</div>\r\n                                    <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 166 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.DIACHI);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label"">Số điện thoại</div>
                                    <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 170 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-3 col-md-4 label\">Twitter</div>\r\n                                    <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 174 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.TWITTER);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-3 col-md-4 label\">Facebook</div>\r\n                                    <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 178 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.FACEBOOK);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label"">Instagram</div>
                                    <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 182 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.INSTAGRAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-3 col-md-4 label\">Linkedin</div>\r\n                                    <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 186 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.LINKEDIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-3 col-md-4 label\">Email</div>\r\n                                    <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 190 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                              Write(Model.LaythanhvienMATV1.EMAIL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""section dashboard"">
        <div class=""col-12"">
            <div class=""card top-selling"">
                <div class=""card-body pb-0"">
                    <table class=""table table-borderless"">
                        <thead>
                            <tr>
                                <th scope=""col"">Hình ảnh</th>
                                <th scope=""col"">Tiêu đề</th>
                                <th scope=""col"">Số lượt thích</th>
                                <th scope=""col"">Số bình luận</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 213 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                             foreach (var baivietchapnhan in Model.LaybaivietMATV1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\"><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "756b4e839621316b8a36aceab2aa95929723b2dd24481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11244, "~/img_post/", 11244, 11, true);
#nullable restore
#line 216 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
AddHtmlAttributeValue("", 11255, baivietchapnhan.ANH1, 11255, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></th>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 11346, "\"", 11420, 2);
            WriteAttributeValue("", 11353, "/Admin/BaivietAdmin/Xembaiviet?MABAIDANG=", 11353, 41, true);
#nullable restore
#line 217 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
WriteAttributeValue("", 11394, baivietchapnhan.MABAIDANG, 11394, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary fw-bold\">");
#nullable restore
#line 217 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                                                                                                              Write(baivietchapnhan.TIEUDE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                    <td>");
#nullable restore
#line 218 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                   Write(baivietchapnhan.SOLUOTTHICH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"fw-bold\">");
#nullable restore
#line 219 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                                                   Write(baivietchapnhan.SOLUONGBINHLUAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 221 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Chitietthanhvien.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blogcongnghe.Areas.Admin.Models.StoreContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
