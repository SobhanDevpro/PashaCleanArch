#pragma checksum "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\Admin\Views\Shared\Components\AdminLeftSide\AdminLeftSide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe98a12a067df630be7e8585151153361ac8f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_AdminLeftSide_AdminLeftSide), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/AdminLeftSide/AdminLeftSide.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\Admin\Views\_ViewImports.cshtml"
using PashaMarket.web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe98a12a067df630be7e8585151153361ac8f64", @"/Areas/Admin/Views/Shared/Components/AdminLeftSide/AdminLeftSide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42c9da14289e53db2921a61682d20430799833d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_AdminLeftSide_AdminLeftSide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <!-- Right Sidebar -->
<aside id=""rightsidebar"" class=""right-sidebar"">
    <ul class=""nav nav-tabs"">
        <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#setting""><i class=""zmdi zmdi-settings zmdi-hc-spin""></i></a></li>
        <li class=""nav-item""><a class=""nav-link"" data-toggle=""tab"" href=""#chat""><i class=""zmdi zmdi-comments""></i></a></li>
        <li class=""nav-item""><a class=""nav-link"" data-toggle=""tab"" href=""#activity"">فعالیت</a></li>
    </ul>
    <div class=""tab-content"">
        <div class=""tab-pane active slideRight"" id=""setting"">
            <div class=""slim_scroll"">
                <div class=""card"">
                    <h6>پوسته</h6>
                    <ul class=""choose-skin list-unstyled"">
                        <li data-theme=""purple"">
                            <div class=""purple""></div>
                        </li>
                        <li data-theme=""blue"">
                            <div class=""blue""></div>
                        </li>
            WriteLiteral(@"
                        <li data-theme=""cyan"" class=""active"">
                            <div class=""cyan""></div>
                        </li>
                        <li data-theme=""green"">
                            <div class=""green""></div>
                        </li>
                        <li data-theme=""orange"">
                            <div class=""orange""></div>
                        </li>
                        <li data-theme=""blush"">
                            <div class=""blush""></div>
                        </li>
                    </ul>
                </div>
                <div class=""card"">
                    <h6> منوی سمت چپ </h6>
                    <ul class=""list-unstyled theme-light-dark"">
                        <li>
                            <div class=""t-light btn btn-default btn-simple btn-round"">روشن</div>
                        </li>
                        <li>
                            <div class=""t-dark btn btn-default btn-round"">تاریک</di");
            WriteLiteral(@"v>
                        </li>
                    </ul>
                </div>
                <div class=""card"">
                    <h6>تنظیمات عمومی</h6>
                    <ul class=""setting-list list-unstyled"">
                        <li>
                            <div class=""checkbox"">
                                <input id=""checkbox1"" type=""checkbox"">
                                <label for=""checkbox1"">گزارش استفاده از پانل</label>
                            </div>
                        </li>
                        <li>
                            <div class=""checkbox"">
                                <input id=""checkbox2"" type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 2733, "\"", 2743, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <label for=""checkbox2"">تغییر مسیر ایمیل</label>
                            </div>
                        </li>
                        <li>
                            <div class=""checkbox"">
                                <input id=""checkbox3"" type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 3046, "\"", 3056, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <label for=""checkbox3"">اعلان ها</label>
                            </div>
                        </li>
                        <li>
                            <div class=""checkbox"">
                                <input id=""checkbox4"" type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 3351, "\"", 3361, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <label for=""checkbox4"">به روز رسانی خودکار</label>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class=""card"">
                    <h6>تنظیمات حساب</h6>
                    <ul class=""setting-list list-unstyled"">
                        <li>
                            <div class=""checkbox"">
                                <input id=""checkbox5"" type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 3858, "\"", 3868, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <label for=""checkbox5"">آفلاین</label>
                            </div>
                        </li>
                        <li>
                            <div class=""checkbox"">
                                <input id=""checkbox6"" type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 4161, "\"", 4171, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <label for=""checkbox6"">مجوز موقعیت مکانی</label>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""tab-pane right_chat pullUp"" id=""chat"">
            <div class=""slim_scroll"">
                <div class=""card"">
                    <div class=""search"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""جستجو..."">
                            <span class=""input-group-addon"">
                                <i class=""zmdi zmdi-search""></i>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <h6>اخیر</h6>
                    <ul class=""list-unstyled"">
                        <li class=""online"">
                            <a href=""javascript:voi");
            WriteLiteral("d(0);\">\r\n                                <div class=\"media\">\r\n                                    <img class=\"media-object \" src=\"/admin-assets/assets/images/xs/avatar4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5369, "\"", 5375, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""name"">س ناصر</span>
                                        <span class=""message"">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.</span>
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""online"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6186, "\"", 6192, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""name"">س غلامی</span>
                                        <span class=""message"">در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد</span>
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7013, "\"", 7019, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""name"">ا احمدی</span>
                                        <span class=""message"">با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</span>
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""me"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7850, "\"", 7856, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""name"">ث قاسمی</span>
                                        <span class=""message"">کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد</span>
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""online"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8665, "\"", 8671, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""name"">ف رحمتی</span>
                                        <span class=""message"">ریچارد مک کلینتوک ، استاد لاتین</span>
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
                <div class=""card"">
                    <h6> مخاطبین </h6>
                    <ul class=""list-unstyled"">
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9611, "\"", 9617, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10204, "\"", 10210, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10797, "\"", 10803, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11390, "\"", 11396, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar9.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11983, "\"", 11989, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""online inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12575, "\"", 12581, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13168, "\"", 13174, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13761, "\"", 13767, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""online inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14353, "\"", 14359, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""offline inlineblock"">
                            <a href=""javascript:void(0);"">
                                <div class=""media"">
                                    <img class=""media-object "" src=""/admin-assets/assets/images/xs/avatar1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14946, "\"", 14952, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <span class=""badge badge-outline status""></span>
                                    </div>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""tab-pane slideRight"" id=""activity"">
            <div class=""slim_scroll"">
                <div class=""card"">
                    <h6> فعالیتهای  اخیر </h6>
                    <ul class=""list-unstyled activity"">
                        <li>
                            <a href=""javascript:void(0)"">
                                <i class=""zmdi zmdi-cake bg-blue""></i>
                                <div class=""info"">
                                    <h4> تولد مدیر </h4>
                                    <small>21 آبان خواهد بود </small>
                                </div>
              ");
            WriteLiteral(@"              </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
                                <i class=""zmdi zmdi-file-text bg-red""></i>
                                <div class=""info"">
                                    <h4> تغییر کد </h4>
                                    <small>22 آبان خواهد بود </small>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
                                <i class=""zmdi zmdi-account-box-phone bg-green""></i>
                                <div class=""info"">
                                    <h4> مخاطب جدید اضافه کنید </h4>
                                    <small>23 آذر خواهد بود </small>
                                </div>
                            </a>
                        </li>
                        <li>
                     ");
            WriteLiteral(@"       <a href=""javascript:void(0)"">
                                <i class=""zmdi zmdi-email bg-amber""></i>
                                <div class=""info"">
                                    <h4>ایمیل جدید</h4>
                                    <small>28 دی خواهد بود </small>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
                <div class=""card"">
                    <h6> وضعیت پروژه </h6>
                    <div class=""progress-container progress-primary"">
                        <span class=""progress-badge"">وب سایت تجارت الکترونیک</span>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-warning"" role=""progressbar"" aria-valuenow=""86"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 86%;"">
                                <span class=""progress-value"">86%</span>
                            </div>
            ");
            WriteLiteral(@"            </div>
                        <ul class=""list-unstyled team-info"">
                            <li class=""m-l-15""><small>تیم</small></li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar2.jpg"" alt=""آواتار"">
                            </li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar3.jpg"" alt=""آواتار"">
                            </li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar4.jpg"" alt=""آواتار"">
                            </li>
                        </ul>
                    </div>
                    <div class=""progress-container"">
                        <span class=""progress-badge"">توسعه بازی ios </span>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-warning"" role=""progressbar"" aria-valuenow=""45"" aria-valu");
            WriteLiteral(@"emin=""0"" aria-valuemax=""100"" style=""width: 45%;"">
                                <span class=""progress-value"">45%</span>
                            </div>
                        </div>
                        <ul class=""list-unstyled team-info"">
                            <li class=""m-l-15""><small>تیم</small></li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar10.jpg"" alt=""آواتار"">
                            </li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar9.jpg"" alt=""آواتار"">
                            </li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar8.jpg"" alt=""آواتار"">
                            </li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar7.jpg"" alt=""آواتار"">
                            </li>
                 ");
            WriteLiteral(@"           <li>
                                <img src=""/admin-assets/assets/images/xs/avatar6.jpg"" alt=""آواتار"">
                            </li>
                        </ul>
                    </div>
                    <div class=""progress-container progress-warning"">
                        <span class=""progress-badge"">توسعه خانگی</span>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-warning"" role=""progressbar"" aria-valuenow=""29"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 29%;"">
                                <span class=""progress-value"">29%</span>
                            </div>
                        </div>
                        <ul class=""list-unstyled team-info"">
                            <li class=""m-l-15""><small>تیم</small></li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar5.jpg"" alt=""آواتار"">
                            </li>
  ");
            WriteLiteral(@"                          <li>
                                <img src=""/admin-assets/assets/images/xs/avatar2.jpg"" alt=""آواتار"">
                            </li>
                            <li>
                                <img src=""/admin-assets/assets/images/xs/avatar7.jpg"" alt=""آواتار"">
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591