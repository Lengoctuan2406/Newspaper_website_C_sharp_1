#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b68d99b357810100ef3fb4811a4ac0b340d9bfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongtinBaivietThanhvien_XembaivietcapnhatThanhvien), @"mvc.1.0.view", @"/Views/ThongtinBaivietThanhvien/XembaivietcapnhatThanhvien.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b68d99b357810100ef3fb4811a4ac0b340d9bfc", @"/Views/ThongtinBaivietThanhvien/XembaivietcapnhatThanhvien.cshtml")]
    public class Views_ThongtinBaivietThanhvien_XembaivietcapnhatThanhvien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Models.StoreContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
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
#line 19 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                         foreach (var theloai in Model.Laytheloai())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 904, "\"", 952, 2);
            WriteAttributeValue("", 911, "/TheloaiBaiviet/Index/?MATL=", 911, 28, true);
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
WriteAttributeValue("", 939, theloai.MATL, 939, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                                                                               Write(theloai.TENTL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 22 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n                <li><a class=\"nav-link scrollto\" href=\"/ThongtinDoanhnghiep/Index\">Giới thiệu</a></li>\r\n");
#nullable restore
#line 26 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                 if (Model.Laythanhvien().EMAIL == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Index\">Đăng nhập</a></li>\r\n                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Dangki\">Đăng kí</a></li>\r\n");
#nullable restore
#line 30 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
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
#line 35 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
WriteAttributeValue("", 1716, Model.Laythanhvien().MATV, 1716, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chào Quản Trị Viên</a></li>\r\n");
#nullable restore
#line 36 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                    }
                    else if (Model.Laythanhvien().QUYENDN == 0 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto active\" href=\"/ThongtinThanhvien/Index\">Chào ");
#nullable restore
#line 39 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                                                                                                Write(Model.Laythanhvien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 40 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
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
            WriteLiteral(@"      <li class=""nav-item"">
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
                <section class=""section profile"">
                    <div class=""row"">
                        <div class=""col-xl-12"">
                            <div class=""card"">
                                <div class=""card-body pt-3"">");
            WriteLiteral("\r\n                                    <div class=\"profile-edit pt-3\">\r\n");
#nullable restore
#line 89 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                                          
                                            var item = Model.LaydulieuBaivietchitiet1;
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <form action=""/ThongtinBaivietThanhvien/CapnhatBaiviet"" enctype=""multipart/form-data"" method=""post"">
                                            <div class=""row mb-3"">
                                                <label for=""profileImage"" class=""col-md-2 col-form-label"">Ảnh bài viết</label>
                                                <div class=""col-md-3"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b68d99b357810100ef3fb4811a4ac0b340d9bfc11857", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4879, "~/img_post/", 4879, 11, true);
#nullable restore
#line 96 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
AddHtmlAttributeValue("", 4890, item.GetType().GetProperty("ANH1").GetValue(item, null), 4890, 56, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <div class=\"pt-2\">\r\n                                                        <input name=\"ANH1\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5124, "\"", 5188, 1);
#nullable restore
#line 98 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
WriteAttributeValue("", 5132, item.GetType().GetProperty("ANH1").GetValue(item, null), 5132, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <input name=""ANH1"" type=""file"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                </div>
                                                <div class=""col-md-3"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b68d99b357810100ef3fb4811a4ac0b340d9bfc14574", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5586, "~/img_post/", 5586, 11, true);
#nullable restore
#line 103 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
AddHtmlAttributeValue("", 5597, item.GetType().GetProperty("ANH2").GetValue(item, null), 5597, 56, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <div class=\"pt-2\">\r\n                                                        <input name=\"ANH2\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5831, "\"", 5895, 1);
#nullable restore
#line 105 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
WriteAttributeValue("", 5839, item.GetType().GetProperty("ANH2").GetValue(item, null), 5839, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <input name=""ANH2"" type=""file"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                </div>
                                                <div class=""col-md-3"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b68d99b357810100ef3fb4811a4ac0b340d9bfc17293", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6293, "~/img_post/", 6293, 11, true);
#nullable restore
#line 110 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
AddHtmlAttributeValue("", 6304, item.GetType().GetProperty("ANH3").GetValue(item, null), 6304, 56, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <div class=\"pt-2\">\r\n                                                        <input name=\"ANH3\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6538, "\"", 6602, 1);
#nullable restore
#line 112 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
WriteAttributeValue("", 6546, item.GetType().GetProperty("ANH3").GetValue(item, null), 6546, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <input name=""ANH3"" type=""file"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""row mb-3"">
                                                <label for=""fullName"" class=""col-md-2 col-form-label"">Tiêu đề</label>
                                                <div class=""col-md-10"">
                                                    <input name=""MABAIDANG"" type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 7267, "\"", 7336, 1);
#nullable restore
#line 120 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
WriteAttributeValue("", 7275, item.GetType().GetProperty("MABAIDANG").GetValue(item, null), 7275, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <input name=\"TIEUDE\" type=\"text\" class=\"form-control\" id=\"fullName\"");
            BeginWriteAttribute("value", " value=\"", 7459, "\"", 7525, 1);
#nullable restore
#line 121 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
WriteAttributeValue("", 7467, item.GetType().GetProperty("TIEUDE").GetValue(item, null), 7467, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                </div>
                                            </div>
                                            <div class=""row mb-3"">
                                                <label for=""about"" class=""col-md-2 col-form-label"">Nội dung</label>
                                                <div class=""col-md-10"">
                                                    <textarea name=""NOIDUNG"" class=""form-control"" id=""about"" style=""height: 500px"">");
#nullable restore
#line 127 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinBaivietThanhvien\XembaivietcapnhatThanhvien.cshtml"
                                                                                                                              Write(item.GetType().GetProperty("NOIDUNG").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                                                </div>
                                            </div>
                                            <div class=""text-center"">
                                                <button type=""submit"" class=""btn btn-primary"">Cập nhật</button>
                                            </div>
                                        </form>
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
