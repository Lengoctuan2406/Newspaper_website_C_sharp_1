#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5469d26fea6cae7022cc6e1f97da6b4c5636e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Thanhvien_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Thanhvien/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5469d26fea6cae7022cc6e1f97da6b4c5636e6", @"/Areas/Admin/Views/Thanhvien/Index.cshtml")]
    public class Areas_Admin_Views_Thanhvien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Areas.Admin.Models.StoreContext>
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
#line 1 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b5469d26fea6cae7022cc6e1f97da6b4c5636e64744", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 833, "~/img_add/", 833, 10, true);
#nullable restore
#line 18 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
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
#line 19 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
                                                                    Write(Model.Layquantrivien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </a>\r\n                <ul class=\"dropdown-menu dropdown-menu-end dropdown-menu-arrow profile\">\r\n                    <li class=\"dropdown-header\">\r\n                        <h6>");
#nullable restore
#line 23 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
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
    <section class=""section dashboard"">
        <div class=""col-12"">
            <div class=""card top-selling"">
                <div class=""card-body pb-0"">
                    <table class=""table table-borderless"">
                        <thead>
                            <tr>
                                <th scope=""col"">Hình ảnh</th>
                                <th scope=""col"">Tên thành viên</th>
           ");
            WriteLiteral("                     <th scope=\"col\">Email</th>\r\n                                <th scope=\"col\">Số điện thoại</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 144 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
                             foreach (var baivietchapnhan in Model.Laytatcathanhvien())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\"><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b5469d26fea6cae7022cc6e1f97da6b4c5636e613509", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6828, "~/img_add/", 6828, 10, true);
#nullable restore
#line 147 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
AddHtmlAttributeValue("", 6838, baivietchapnhan.ANHDD, 6838, 22, false);

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
            BeginWriteAttribute("href", " href=\"", 6930, "\"", 6997, 2);
            WriteAttributeValue("", 6937, "/Admin/Thanhvien/Chitietthanhvien?MATV=", 6937, 39, true);
#nullable restore
#line 148 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
WriteAttributeValue("", 6976, baivietchapnhan.MATV, 6976, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary fw-bold\">");
#nullable restore
#line 148 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
                                                                                                                                       Write(baivietchapnhan.TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                    <td>");
#nullable restore
#line 149 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
                                   Write(baivietchapnhan.EMAIL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"fw-bold\">");
#nullable restore
#line 150 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
                                                   Write(baivietchapnhan.SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 152 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Thanhvien\Index.cshtml"
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
