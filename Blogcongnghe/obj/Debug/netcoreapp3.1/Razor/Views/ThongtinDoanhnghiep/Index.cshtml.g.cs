#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ffe1c04af95aa9385e22f16a3218da5d74b626c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongtinDoanhnghiep_Index), @"mvc.1.0.view", @"/Views/ThongtinDoanhnghiep/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ffe1c04af95aa9385e22f16a3218da5d74b626c", @"/Views/ThongtinDoanhnghiep/Index.cshtml")]
    public class Views_ThongtinDoanhnghiep_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Models.StoreContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
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
#line 19 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                         foreach (var theloai in Model.Laytheloai())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 904, "\"", 952, 2);
            WriteAttributeValue("", 911, "/TheloaiBaiviet/Index/?MATL=", 911, 28, true);
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
WriteAttributeValue("", 939, theloai.MATL, 939, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                                                                               Write(theloai.TENTL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 22 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n                <li><a class=\"nav-link scrollto active\" href=\"/ThongtinDoanhnghiep/Index\">Giới thiệu</a></li>\r\n");
#nullable restore
#line 26 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                 if (Model.Laythanhvien().EMAIL == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Index\">Đăng nhập</a></li>\r\n                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Dangki\">Đăng kí</a></li>\r\n");
#nullable restore
#line 30 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                }
                else
                {
                    if (Model.Laythanhvien().QUYENDN == 1 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto\"");
            BeginWriteAttribute("href", " href=\"", 1687, "\"", 1749, 2);
            WriteAttributeValue("", 1694, "/Admin/IndexAdmin/Index?MATV=", 1694, 29, true);
#nullable restore
#line 35 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
WriteAttributeValue("", 1723, Model.Laythanhvien().MATV, 1723, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chào Quản Trị Viên</a></li>\r\n");
#nullable restore
#line 36 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                    }
                    else if (Model.Laythanhvien().QUYENDN == 0 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto\" href=\"/ThongtinThanhvien/Index\">Chào ");
#nullable restore
#line 39 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                                                                                         Write(Model.Laythanhvien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 40 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
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
    <section id=""testimonials"" class=""testimonials"">
        <div class=""container"">
            <div class=""testimonials-slider swiper"">
                <div class=""swiper-wrapper"">
");
#nullable restore
#line 52 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                     foreach (var thanhvienadmin in Model.LaytatcaQuantrivien())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"swiper-slide\">\r\n                            <div class=\"testimonial-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ffe1c04af95aa9385e22f16a3218da5d74b626c9796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2693, "~/img_add/", 2693, 10, true);
#nullable restore
#line 56 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
AddHtmlAttributeValue("", 2703, thanhvienadmin.ANHDD, 2703, 21, false);

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
            WriteLiteral("\r\n                                <h3>");
#nullable restore
#line 57 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                               Write(thanhvienadmin.TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <h4>Thành Viên</h4>\r\n                                <p>\r\n                                    <i class=\"bx bxs-quote-alt-left quote-icon-left\"></i>\r\n                                    ");
#nullable restore
#line 61 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                               Write(thanhvienadmin.BIO);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <i class=\"bx bxs-quote-alt-right quote-icon-right\"></i>\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 66 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""swiper-pagination""></div>
            </div>
        </div>
    </section>
    <section id=""team"" class=""team section-bg"">
        <div class=""container"">
            <div class=""section-title"">
                <h2>Team</h2>
                <h3>Thông Tin <span>Thành Viên</span></h3>
                <p>Môn: Xây Dựng Hệ Thống Thông Tin Trên Các Framework</p>
                <p>GVHD: Mai Xuân Hùng</p>
            </div>
            <div class=""row"">
");
#nullable restore
#line 81 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                 foreach (var thanhvienadmin in Model.LaytatcaQuantrivien())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3 d-flex align-items-stretch\" style=\"margin: 55px;\">\r\n                        <div class=\"member\">\r\n                            <div class=\"member-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ffe1c04af95aa9385e22f16a3218da5d74b626c13915", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4138, "~/img_add/", 4138, 10, true);
#nullable restore
#line 86 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
AddHtmlAttributeValue("", 4148, thanhvienadmin.ANHDD, 4148, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"social\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4290, "\"", 4320, 1);
#nullable restore
#line 88 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
WriteAttributeValue("", 4297, thanhvienadmin.TWITTER, 4297, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4395, "\"", 4426, 1);
#nullable restore
#line 89 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
WriteAttributeValue("", 4402, thanhvienadmin.FACEBOOK, 4402, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4502, "\"", 4534, 1);
#nullable restore
#line 90 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
WriteAttributeValue("", 4509, thanhvienadmin.INSTAGRAM, 4509, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4611, "\"", 4642, 1);
#nullable restore
#line 91 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
WriteAttributeValue("", 4618, thanhvienadmin.LINKEDIN, 4618, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"member-info\">\r\n                                <h4>");
#nullable restore
#line 95 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                               Write(thanhvienadmin.TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <span>Thành Viên</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 100 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <section id=""contact"" class=""contact"">
        <div class=""container"">
            <div class=""section-title"">
                <h2>Liên Hệ</h2>
                <h3><span>Thông tin liên hệ</span></h3>
                <p>
                    Nếu có vấn đề hay câu hỏi về trang blog,
                    hãy liên lạc với chúng tôi
                </p>
            </div>
");
#nullable restore
#line 114 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
              
                var item = (from s in Model.LaytatcaQuantrivien()
                            where s.MATV == 2
                            select s);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"info-box mb-4\">\r\n                        <i class=\"bx bx-map\"></i>\r\n                        <h3>Địa chỉ</h3>\r\n                        <p>");
#nullable restore
#line 124 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                      Write(item.First().DIACHI);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6"">
                    <div class=""info-box  mb-4"">
                        <i class=""bx bx-envelope""></i>
                        <h3>Địa Chỉ Email</h3>
                        <p>");
#nullable restore
#line 131 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                      Write(item.First().EMAIL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6"">
                    <div class=""info-box  mb-4"">
                        <i class=""bx bx-phone-call""></i>
                        <h3>Số Điện Thoại</h3>
                        <p>");
#nullable restore
#line 138 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                      Write(item.First().SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6 "">
                    <iframe class=""mb-4 mb-lg-0""
                            src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d955.3537225337262!2d108.69582318822715!3d11.828761492088207!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x317118c4142816eb%3A0x7fa9ebcd3cc81572!2zQ2jhu6MgU8O0bmcgUGhh!5e0!3m2!1svi!2s!4v1640155182478!5m2!1svi!2s""
                            frameborder=""0"" style=""border:0; width: 100%; height: 384px;"" allowfullscreen></iframe>
                </div>
                <div class=""col-lg-6"">
");
#nullable restore
#line 149 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                     if (Model.Laythanhvien().EMAIL == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <form action=""/ThongtinDoanhnghiep/Xulyguitinkhac"" method=""post"" role=""form"" class=""php-email-form"">
                            <div class=""row"">
                                <div class=""col form-group"">
                                    <input type=""text"" name=""TENTHANHVIEN"" class=""form-control"" id=""name"" placeholder=""Họ và tên"" required>
                                </div>
                                <div class=""col form-group"">
                                    <input type=""email"" class=""form-control"" name=""EMAIL"" id=""email"" placeholder=""Địa Chỉ Email"" required>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <textarea class=""form-control"" name=""TINNHAN"" rows=""5"" placeholder=""Tin nhắn"" required></textarea>
                            </div>
                            <div class=""my-3"">
                                <div class=""loading"">Đang Gử");
            WriteLiteral(@"i</div>
                                <div class=""error-message""></div>
                                <div class=""sent-message"">Cảm ơn bạn. Tin nhắn của bạn đã được gửi.</div>
                            </div>
                            <div class=""text-center""><button type=""submit"">Send Message</button></div>
                        </form>
");
#nullable restore
#line 170 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <form action=""/ThongtinDoanhnghiep/Xulyguitin"" method=""post"" role=""form"" class=""php-email-form"">
                            <div class=""form-group"">
                                <textarea class=""form-control"" name=""TINNHAN"" rows=""5"" placeholder=""Tin nhắn"" required></textarea>
                            </div>
                            <div class=""my-3"">
                                <div class=""loading"">Đang Gửi</div>
                                <div class=""error-message""></div>
                                <div class=""sent-message"">Cảm ơn bạn. Tin nhắn của bạn đã được gửi.</div>
                            </div>
                            <div class=""text-center""><button type=""submit"">Send Message</button></div>
                        </form>
");
#nullable restore
#line 184 "D:\OneDrive - cloudor\PC Main\Desktop\Đồ án Framework\Blogcongnghe\Blogcongnghe\Views\ThongtinDoanhnghiep\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
