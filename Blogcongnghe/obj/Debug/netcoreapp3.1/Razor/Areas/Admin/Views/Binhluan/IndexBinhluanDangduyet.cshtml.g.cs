#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e122effbe8feb4d1b058964357354510b1d1ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Binhluan_IndexBinhluanDangduyet), @"mvc.1.0.view", @"/Areas/Admin/Views/Binhluan/IndexBinhluanDangduyet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e122effbe8feb4d1b058964357354510b1d1ff1", @"/Areas/Admin/Views/Binhluan/IndexBinhluanDangduyet.cshtml")]
    public class Areas_Admin_Views_Binhluan_IndexBinhluanDangduyet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Areas.Admin.Models.StoreContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4e122effbe8feb4d1b058964357354510b1d1ff14494", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 833, "~/img_add/", 833, 10, true);
#nullable restore
#line 18 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
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
#line 19 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
                                                                    Write(Model.Layquantrivien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </a>\r\n                <ul class=\"dropdown-menu dropdown-menu-end dropdown-menu-arrow profile\">\r\n                    <li class=\"dropdown-header\">\r\n                        <h6>");
#nullable restore
#line 23 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
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
                        <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                            <i class=""bi bi-person""></i>
                            <span>My Profile</span>
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
                        <a class=""dropdown-item d-fle");
            WriteLiteral(@"x align-items-center"" href=""/Admin/IndexAdmin/Dangxuat"">
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
            <a class=""nav-link collapsed"" data-bs-target=""#tables-nav"" data-bs-toggle=""collapse"" href=""#"">
               ");
            WriteLiteral(@" <i class=""bi bi-layout-text-window-reverse""></i><span>Bài viết</span><i class=""bi bi-chevron-down ms-auto""></i>
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
            <a class=""nav-link"" data-bs-target=""#tables-nav1"" data-bs-toggle=");
            WriteLiteral(@"""collapse"" href=""#"">
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
            <a class=""nav-link collapsed"" data-bs-target=""#tables-nav2"" data-bs-toggle=""collapse"" href=""#"">
                <i class=""bi bi-person""></i><span>Thành viên</span><i class=""bi bi-chevron-down ms-auto""></i>
            </a>
            <ul id=""t");
            WriteLiteral(@"ables-nav2"" class=""nav-content collapse "" data-bs-parent=""#sidebar-nav"">
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
    <div class=""card"">
        <div class=""card-body"" style=""padding:20px;"">
            <form action=""/Admin/Binhluan/DuyetBinhluan"" method=""post"">
                <div class=""row mb-3"">
                    <label for=""inputPassword"" class=""col-sm-2 col-form-label"">Lọc bình luận</label>
                    <div class=""col-sm-10"">
                        <input type=""hidden"" name=""MADUYET""");
            BeginWriteAttribute("value", " value=\"", 6318, "\"", 6358, 1);
#nullable restore
#line 136 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
WriteAttributeValue("", 6326, Model.Layxulybinhluan().MADUYET, 6326, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <textarea name=\"TENDUYET\" class=\"form-control\" style=\"height: 100px\">");
#nullable restore
#line 137 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
                                                                                        Write(Model.Layxulybinhluan().TENDUYET);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>
                <button type=""submit"" class=""btn btn-primary"">Duyệt bình luận</button>
            </form>
        </div>
    </div>
    <section class=""section"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Các bình luận đang duyệt</h5>
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Tên thành viên</th>
                                    <th scope=""col"">Nội dung bình luận</th>
                                    <th scope=""col"">Ngày bình luận</th>
                                    <th scope=""col"">Trạng thái</th>
                                    <th scope=""col"" colspan=""2"" style=""text-align: center;"">Chức năng</th>
                                </tr>
       ");
            WriteLiteral("                     </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 161 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
                                 foreach (var binhluandangduyet in Model.Laybinhluandangduyet())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 164 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
                                                   Write(binhluandangduyet.GetType().GetProperty("TENTHANHVIEN").GetValue(binhluandangduyet, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td style=\"width:350px\">");
#nullable restore
#line 165 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
                                                           Write(binhluandangduyet.GetType().GetProperty("NOIDUNG").GetValue(binhluandangduyet, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 166 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
                                       Write(binhluandangduyet.GetType().GetProperty("NGAYBINHLUAN").GetValue(binhluandangduyet, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><span class=\"badge bg-warning\">Đang duyệt</span></td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 8352, "\"", 8479, 2);
            WriteAttributeValue("", 8359, "/Admin/Binhluan/ChapnhanBinhluan?MABL=", 8359, 38, true);
#nullable restore
#line 168 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
WriteAttributeValue("", 8397, binhluandangduyet.GetType().GetProperty("MABL").GetValue(binhluandangduyet, null), 8397, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Chấp nhận</a></td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 8571, "\"", 8693, 2);
            WriteAttributeValue("", 8578, "/Admin/Binhluan/XoaBinhluan?MABL=", 8578, 33, true);
#nullable restore
#line 169 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
WriteAttributeValue("", 8611, binhluandangduyet.GetType().GetProperty("MABL").GetValue(binhluandangduyet, null), 8611, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Xóa</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 171 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Areas\Admin\Views\Binhluan\IndexBinhluanDangduyet.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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