#pragma checksum "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ef5cd004168f1738d18e2ca5bea1de8cad42e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layout_Index), @"mvc.1.0.view", @"/Views/Layout/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Layout/Index.cshtml", typeof(AspNetCore.Views_Layout_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef5cd004168f1738d18e2ca5bea1de8cad42e5b", @"/Views/Layout/Index.cshtml")]
    public class Views_Layout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/switch/dist/js/bootstrap-switch.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-blue fixed sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
  
    ViewBag.JSCSSVision = "1.0.0";
    var isHaveListMore = ViewBag.isHaveListMore == true ? true : false;

#line default
#line hidden
            BeginContext(116, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(141, 2430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1f7d8ee87014b63bd9ae8908be51037", async() => {
                BeginContext(147, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(161, 13, false);
#line 8 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(174, 135, true);
                WriteLiteral("-权限管理系统</title>\r\n    <meta content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\" name=\"viewport\">\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 309, "\"", 382, 2);
                WriteAttributeValue("", 316, "/lib/bootstrap/dist/css/bootstrap.min.css?v=", 316, 44, true);
#line 10 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 360, ViewBag.JSCSSVision, 360, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(383, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 414, "\"", 484, 2);
                WriteAttributeValue("", 421, "/lib/font-awesome/css/font-awesome.css?v=", 421, 41, true);
#line 11 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 462, ViewBag.JSCSSVision, 462, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(485, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 516, "\"", 578, 2);
                WriteAttributeValue("", 523, "/lib/dist/css/adminlte.min.css?v=", 523, 33, true);
#line 12 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 556, ViewBag.JSCSSVision, 556, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(579, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 610, "\"", 680, 2);
                WriteAttributeValue("", 617, "/lib/dist/css/skins/_all-skins.min.css?v=", 617, 41, true);
#line 13 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 658, ViewBag.JSCSSVision, 658, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(681, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 712, "\"", 769, 2);
                WriteAttributeValue("", 719, "/lib/common/css/style.css?v=", 719, 28, true);
#line 14 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 747, ViewBag.JSCSSVision, 747, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(770, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 803, "\"", 868, 2);
                WriteAttributeValue("", 809, "/lib/jQuery/jquery-1.9.1.min.js?ver=", 809, 36, true);
#line 15 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 845, ViewBag.JSCSSVision , 845, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(869, 46, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 915, "\"", 987, 2);
                WriteAttributeValue("", 921, "/lib/bootstrap/dist/js/bootstrap.min.js?ver=", 921, 44, true);
#line 16 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 965, ViewBag.JSCSSVision, 965, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(988, 46, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1034, "\"", 1090, 2);
                WriteAttributeValue("", 1040, "/lib/dist/js/app.min.js?ver=", 1040, 28, true);
#line 17 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1068, ViewBag.JSCSSVision, 1068, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1091, 46, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1137, "\"", 1199, 2);
                WriteAttributeValue("", 1143, "/lib/dist/js/adminlte.min.js?ver=", 1143, 33, true);
#line 18 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1176, ViewBag.JSCSSVision , 1176, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1200, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1223, "\"", 1296, 2);
                WriteAttributeValue("", 1229, "/lib/Scrollbar/jquery.slimscroll.min.js?ver=", 1229, 44, true);
#line 19 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1273, ViewBag.JSCSSVision , 1273, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1297, 46, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1343, "\"", 1399, 2);
                WriteAttributeValue("", 1349, "/lib/dist/js/app.min.js?ver=", 1349, 28, true);
#line 20 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1377, ViewBag.JSCSSVision, 1377, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1400, 46, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1446, "\"", 1507, 2);
                WriteAttributeValue("", 1452, "/lib/template/artTemplate.js?ver=", 1452, 33, true);
#line 21 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1485, ViewBag.JSCSSVision, 1485, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1508, 38, true);
                WriteLiteral("></script>\r\n    <!--行内编辑-->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1546, "\"", 1655, 2);
                WriteAttributeValue("", 1553, "/lib/bootstrap/editable/dist/bootstrap3-editable/css/bootstrap-editable.css?ver=", 1553, 80, true);
#line 23 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1633, ViewBag.JSCSSVision, 1633, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1656, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1689, "\"", 1795, 2);
                WriteAttributeValue("", 1695, "/lib/bootstrap/editable/dist/bootstrap3-editable/js/bootstrap-editable.js?ver=", 1695, 78, true);
#line 24 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1773, ViewBag.JSCSSVision, 1773, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1796, 58, true);
                WriteLiteral("></script>\r\n    <!--行内编辑-->\r\n    <!--Checked-->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1854, "\"", 1950, 2);
                WriteAttributeValue("", 1861, "/lib/bootstrap/switch/dist/css/bootstrap3/bootstrap-switch.css?ver=", 1861, 67, true);
#line 27 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 1928, ViewBag.JSCSSVision, 1928, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1951, 26, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    ");
                EndContext();
                BeginContext(1977, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def3a4ff590d4cc8b8d611d6977c05f3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2055, 123, true);
                WriteLiteral("\r\n\r\n    <!--Checked-->\r\n    <!--Layui-->\r\n    <link href=\"/lib/common/css/layer-style.css\" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2178, "\"", 2230, 2);
                WriteAttributeValue("", 2184, "/lib/layer/layer.js?ver=", 2184, 24, true);
#line 33 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
WriteAttributeValue("", 2208, ViewBag.JSCSSVision, 2208, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2231, 94, true);
                WriteLiteral("></script>\r\n    <!--Layui-->\r\n    <script src=\"/lib/common/js/X-edittable-ajax.js\"></script>\r\n");
                EndContext();
#line 36 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
      
        if (isHaveListMore)
        {

#line default
#line hidden
                BeginContext(2373, 64, true);
                WriteLiteral("            <script src=\"/lib/common/js/LoadMore.js\"></script>\r\n");
                EndContext();
#line 40 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
        }
    

#line default
#line hidden
                BeginContext(2455, 109, true);
                WriteLiteral("    <script src=\"/lib/common/js/Toast.js\"></script>\r\n    <script src=\"/lib/common/js/SendAjax.js\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2571, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2573, 3729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea8d6276efdf4de899b490705f5e0a1c", async() => {
                BeginContext(2632, 1511, true);
                WriteLiteral(@"
    <div class=""wrapper"">
        <div class=""container-header"">
            <div class=""pro-zc-bg""></div>
            <header class=""main-header"">
                <a href=""javascript:;"" class=""logo"">
                    <span class=""logo-mini""><b>D</b>JWB</span>
                    <span class=""logo-lg"">
                        <span>
                            <b>JW</b>cms
                            <i class=""fa fa-angle-down static-nav-icon"" style=""display:none""></i>
                        </span>
                    </span>
                </a>
                <ul class=""static-nav dropdown-menu""></ul>
                <nav class=""navbar navbar-static-top"">
                    <a href=""javascript:;"" class=""sidebar-toggle"" data-toggle=""push-menu"" role=""button"">
                        <span class=""sr-only"">切换</span>
                    </a>

                    <div class=""collapse navbar-collapse pull-left"" id=""navbar-collapse"">
                        <ul class=""nav navbar-nav con");
                WriteLiteral(@"tacts-nav""></ul>

                    </div>
                    <div class=""navbar-custom-menu"">
                        <ul class=""nav navbar-nav"">
                            <li>
                                <a href=""javascript:;"" title=""点击查看"" data-toggle=""control-sidebar""><i class=""fa fa-gears""></i></a>
                            </li>
                        </ul>
                    </div>
                </nav>
            </header>
        </div>

        ");
                EndContext();
                BeginContext(4144, 29, false);
#line 80 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
   Write(Html.Action("Left", "Layout"));

#line default
#line hidden
                EndContext();
                BeginContext(4173, 14, true);
                WriteLiteral("\r\n\r\n\r\n        ");
                EndContext();
                BeginContext(4188, 12, false);
#line 83 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4200, 119, true);
                WriteLiteral("\r\n        <footer class=\"main-footer\">\r\n            <div class=\"pull-right hidden-xs\">\r\n                <b>Version</b> ");
                EndContext();
                BeginContext(4321, 17, false);
#line 86 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Layout\Index.cshtml"
                           Write(ViewBag.CMSVision);

#line default
#line hidden
                EndContext();
                BeginContext(4339, 1956, true);
                WriteLiteral(@"
            </div>
            <strong>Copyright © 2018 GVcms Soution.</strong> All rights
            reserved.
        </footer>

        <aside class=""control-sidebar control-sidebar-dark"" style=""background-color:#fff !important"">
            <div class=""tab-content"">
                <div id=""control-sidebar-theme-demo-options-tab"" class=""tab-pane active"">
                    <div class=""tab-pane"" id=""control-sidebar-stats-tab"">
                        <div class=""box"">
                            <div class=""box-header with-border"">
                                <h3 class=""box-title"">快捷区域</h3>
                                <div class=""box-tools pull-right"">

                                </div>
                            </div>
                            <div class=""box-body"">
                                <a href=""javascript:;"" class=""btn btn-primary btn-block btn-flat""><i class=""fa fa-delicious""></i>  查看主站</a>
                            </div>
                            ");
                WriteLiteral(@"<div class=""box-body"">
                                <a href=""/cloudAdmin/custom/password.html"" class=""btn btn-primary btn-block btn-flat""><i class=""fa fa-unlock""></i>  修改密码</a>
                            </div>

                            <div class=""box-body"">
                                <a href=""/cloudAdmin/custom/log.html"" class=""btn btn-primary btn-block btn-flat""><i class=""fa fa-file-text-o""></i>  查看日志</a>
                            </div>

                            <div class=""box-body"">
                                <a href=""javascript:;"" class=""btn btn-primary btn-block btn-flat btn-close-login"" onclick=""cloudSoultionCore.CloseLogin()""><i class=""fa fa-close""></i>  退出登录</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </aside>
        <div class=""control-sidebar-bg""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6302, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
