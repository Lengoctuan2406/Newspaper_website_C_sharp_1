#pragma checksum "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "929fd28866ed118105dbbd18eee4e0144de02426"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929fd28866ed118105dbbd18eee4e0144de02426", @"/Views/ThongtinTaobaivietThanhvien/Index.cshtml")]
    public class Views_ThongtinTaobaivietThanhvien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogcongnghe.Models.StoreContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header id=""header"" class=""d-flex align-items-center"">
    <div class=""container d-flex align-items-center justify-content-between"">
        <h1 class=""logo""><a href=""/Index/Index"">Phoenix Blog<span>.</span></a></h1>
        <nav id=""navbar"" class=""navbar"">
            <ul>
                <li><a class=""nav-link scrollto"" href=""/Index/Index"">Home</a></li>
                <li class=""dropdown"">
                    <a href=""#""><span>Thể Loại</span> <i class=""bi bi-chevron-down""></i></a>
                    <ul>
");
#nullable restore
#line 14 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                         foreach (var theloai in Model.Laytheloai())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 801, 2);
            WriteAttributeValue("", 760, "/TheloaiBaiviet/Index/?MATL=", 760, 28, true);
#nullable restore
#line 16 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 788, theloai.MATL, 788, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                               Write(theloai.TENTL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 17 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n                <li><a class=\"nav-link scrollto\" href=\"/ThongtinDoanhnghiep/Index\">Giới thiệu</a></li>\r\n");
#nullable restore
#line 21 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                 if (Model.Laythanhvien().EMAIL == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Index\">Đăng nhập</a></li>\r\n                    <li><a class=\"nav-link scrollto\" href=\"/DangnhapDangki/Dangki\">Đăng kí</a></li>\r\n");
#nullable restore
#line 25 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                }
                else
                {
                    if (Model.Laythanhvien().QUYENDN == 1 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto\"");
            BeginWriteAttribute("href", " href=\"", 1529, "\"", 1591, 2);
            WriteAttributeValue("", 1536, "/Admin/IndexAdmin/Index?MATV=", 1536, 29, true);
#nullable restore
#line 30 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 1565, Model.Laythanhvien().MATV, 1565, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">chào Admin</a></li>\r\n");
#nullable restore
#line 31 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                    }
                    else if (Model.Laythanhvien().QUYENDN == 0 && Model.Laythanhvien().TINHTRANGDN == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a class=\"nav-link scrollto active\" href=\"/ThongtinThanhvien/Index\">Chào ");
#nullable restore
#line 34 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                                                Write(Model.Laythanhvien().TENTHANHVIEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 35 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
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
                        <li class=""nav-heading"">Pages</li>
                        <li class=""nav-item"">
                            <a class=""nav-link collapsed"" href=""/ThongtinThanhvien/Index"">
                                <i class=""bi bi-person""></i>
                                <span>Profile</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/ThongtinBaivietThanhvien/Index"">
                                <i class=""bi bi-card-list""></i>
                                <span>Post</span>
                            </a>
               ");
            WriteLiteral(@"         </li>
                        <li class=""nav-item"">
                            <a class=""nav-link collapsed"" href=""/ThongtinTaobaivietThanhvien/Index"">
                                <i class=""bi bi-card-list""></i>
                                <span>Create post</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link collapsed"" href=""/ThongtinBaivietThanhvien/Dangxuat"">
                                <i class=""bi bi-box-arrow-in-right""></i>
                                <span>Logout</span>
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
                          ");
            WriteLiteral(@"      <div class=""card-body pt-3"">
                                    <ul class=""nav nav-tabs nav-tabs-bordered"">
                                        <li class=""nav-item"">
                                            <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#create-post"">Create post</button>
                                        </li>
                                        <li class=""nav-item"">
                                            <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#guide"">Guide</button>
                                        </li>
                                    </ul>
                                    <div class=""tab-content pt-2"">
                                        <div class=""tab-pane fade show active profile-edit pt-3"" id=""create-post"">
                                            <form action=""/ThongtinTaobaivietThanhvien/Taobaiviet"" enctype=""multipart/form-data"" method=""post"">
                                    ");
            WriteLiteral(@"            <div class=""row mb-3"">
                                                        <label class=""col-sm-3 col-form-label"">Select</label>
                                                        <div class=""col-sm-9"">
                                                            <select name=""MATL"" class=""form-select"">
                                                                <option value=""2"" selected>Font end</option>
");
#nullable restore
#line 102 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                 foreach (var theloai in Model.Laytheloai())
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <option");
            BeginWriteAttribute("value", " value=\"", 5717, "\"", 5738, 1);
#nullable restore
#line 104 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 5725, theloai.MATL, 5725, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 104 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                                             Write(theloai.TENTL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 105 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </select>
                                                        </div>
                                                </div>

                                                <div class=""row mb-3"">
                                                    <label for=""profileImage"" class=""col-md-4 col-lg-3 col-form-label"">Image</label>
                                                    <div class=""col-md-3"">
                                                        <input type=""file"" name=""ANH1"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                    <div class=""col-md-3"">
                                                        <input type=""file"" name=""ANH2"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                    <div class=""c");
            WriteLiteral(@"ol-md-3"">
                                                        <input type=""file"" name=""ANH3"" style=""width: 210px;"" class=""btn btn-primary btn-sm"" />
                                                    </div>
                                                </div>

                                                <div class=""row mb-3"">
                                                    <label for=""tieude"" class=""col-md-4 col-lg-3 col-form-label"">Tiêu đề</label>
                                                    <div class=""col-md-8 col-lg-9"">
                                                        <input name=""MATV"" type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 7504, "\"", 7538, 1);
#nullable restore
#line 126 "D:\OneDrive - cloudor\PC Main\Desktop\[Xây dựng HTTT trên các framework - IS220.M12.HTCL]\(Đồ án)\BlogHtml\Blogcongnghe\Blogcongnghe\Views\ThongtinTaobaivietThanhvien\Index.cshtml"
WriteAttributeValue("", 7512, Model.Laythanhvien().MATV, 7512, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                                                        <input name=""TIEUDE"" type=""text"" class=""form-control"" id=""tieude"" value=""Viết gì đó..."">
                                                    </div>
                                                </div>

                                                <div class=""row mb-3"">
                                                    <label for=""noidung"" class=""col-md-4 col-lg-3 col-form-label"">Content</label>
                                                    <div class=""col-md-8 col-lg-9"">
                                                        <textarea name=""NOIDUNG"" class=""form-control"" id=""noidung"" style=""height: 500px"">Viết gì đó...</textarea>
                                                    </div>
                                                </div>

                                                <div class=""text-center"">
                                                    <button type=""submit"" class=""btn btn-primary"">Tạo bài viết</");
            WriteLiteral(@"button>
                                                </div>
                                            </form>
                                        </div>

                                        <div class=""tab-pane fade pt-3"" id=""guide"">
                                            <section id=""faq"" class=""faq"">
                                                <div class=""container"">
                                                    <div class=""section-title"">
                                                        <h3>Hướng dẫn <span>HTML</span></h3>
                                                        <p>Giúp bạn hiểu hơn về cách tạo post đẹp bằng ngôn ngữ html cơ bản</p>
                                                    </div>
                                                    <div class=""row justify-content-center"">
                                                        <div class=""col-xl-10"">
                                                            <ul class=""faq-list"">
");
            WriteLiteral(@"                                                                <li>
                                                                    <div data-bs-toggle=""collapse"" class=""collapsed question"" href=""#faq1"">Thẻ tiêu đề h1, h2,... <i class=""bi bi-chevron-down icon-show""></i><i class=""bi bi-chevron-up icon-close""></i></div>
                                                                    <div id=""faq1"" class=""collapse"" data-bs-parent="".faq-list"">
                                                                        <p>
                                                                            <h1>Thẻ h1</h1>
                                                                            <h2>Thẻ h2</h2>
                                                                            <h3>Thẻ h3</h3>
                                                                            <h4>Thẻ h4</h4>
                                                                            <h5>Thẻ h5</h5>
                          ");
            WriteLiteral(@"                                                  <h6>Thẻ h6</h6>
                                                                            <hr>
                                                                            Thẻ h1 sẽ có kích thước to nhất và thẻ h6 sẽ có kích thước nhỏ nhất. Nếu sau này bạn có soạn thảo một bài viết bằng HTML thì sử dụng các thẻ tiêu đề này để làm văn bản trở nên chuyên nghiệp.
                                                                        </p>
                                                                    </div>
                                                                </li>

                                                                <li>
                                                                    <div data-bs-toggle=""collapse"" href=""#faq2"" class=""collapsed question"">Thẻ đoạn văn p<i class=""bi bi-chevron-down icon-show""></i><i class=""bi bi-chevron-up icon-close""></i></div>
                                                              ");
            WriteLiteral(@"      <div id=""faq2"" class=""collapse"" data-bs-parent="".faq-list"">
                                                                        <p>
                                                                            Thẻ p
                                                                            <hr>
                                                                            Đoạn văn bản thì nó sẽ được khai báo bằng cặp thẻ p. Các văn bản nằm trong cặp thẻ này sẽ được hiểu là một đoạn văn bản, mỗi đoạn văn bản sẽ được xuống dòng và cách nhau với tỷ lệ nhất định.
                                                                        </p>
                                                                    </div>
                                                                </li>

                                                                <li>
                                                                    <div data-bs-toggle=""collapse"" href=""#faq3"" class=""collapsed question"">Thẻ strong<");
            WriteLiteral(@"i class=""bi bi-chevron-down icon-show""></i><i class=""bi bi-chevron-up icon-close""></i></div>
                                                                    <div id=""faq3"" class=""collapse"" data-bs-parent="".faq-list"">
                                                                        <p>
                                                                            <strong>Thẻ strong</strong>
                                                                            <hr>
                                                                            Dùng để in đậm chữ viết trong văn bản
                                                                        </p>
                                                                    </div>
                                                                </li>

                                                                <li>
                                                                    <div data-bs-toggle=""collapse"" href=""#faq4"" class=""collap");
            WriteLiteral(@"sed question"">Ac odio tempor orci dapibus. Aliquam eleifend mi in nulla? <i class=""bi bi-chevron-down icon-show""></i><i class=""bi bi-chevron-up icon-close""></i></div>
                                                                    <div id=""faq4"" class=""collapse"" data-bs-parent="".faq-list"">
                                                                        <p>
                                                                            Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi. Id interdum velit laoreet id donec ultrices. Fringilla phasellus faucibus scelerisque eleifend donec pretium. Est pellentesque elit ullamcorper dignissim. Mauris ultrices eros in cursus turpis massa tincidunt dui.
                                                                        </p>
                                                                    </div>
                                                                </li>

                                                            ");
            WriteLiteral(@"    <li>
                                                                    <div data-bs-toggle=""collapse"" href=""#faq5"" class=""collapsed question"">Tempus quam pellentesque nec nam aliquam sem et tortor consequat? <i class=""bi bi-chevron-down icon-show""></i><i class=""bi bi-chevron-up icon-close""></i></div>
                                                                    <div id=""faq5"" class=""collapse"" data-bs-parent="".faq-list"">
                                                                        <p>
                                                                            Molestie a iaculis at erat pellentesque adipiscing commodo. Dignissim suspendisse in est ante in. Nunc vel risus commodo viverra maecenas accumsan. Sit amet nisl suscipit adipiscing bibendum est. Purus gravida quis blandit turpis cursus in
                                                                        </p>
                                                                    </div>
                                     ");
            WriteLiteral(@"                           </li>

                                                                <li>
                                                                    <div data-bs-toggle=""collapse"" href=""#faq6"" class=""collapsed question"">Tortor vitae purus faucibus ornare. Varius vel pharetra vel turpis nunc eget lorem dolor? <i class=""bi bi-chevron-down icon-show""></i><i class=""bi bi-chevron-up icon-close""></i></div>
                                                                    <div id=""faq6"" class=""collapse"" data-bs-parent="".faq-list"">
                                                                        <p>
                                                                            Laoreet sit amet cursus sit amet dictum sit amet justo. Mauris vitae ultricies leo integer malesuada nunc vel. Tincidunt eget nullam non nisi est sit amet. Turpis nunc eget lorem dolor sed. Ut venenatis tellus in metus vulputate eu scelerisque. Pellentesque diam volutpat commodo sed egestas egestas fringilla ph");
            WriteLiteral(@"asellus faucibus. Nibh tellus molestie nunc non blandit massa enim nec.
                                                                        </p>
                                                                    </div>
                                                                </li>

                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                            </section>
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
