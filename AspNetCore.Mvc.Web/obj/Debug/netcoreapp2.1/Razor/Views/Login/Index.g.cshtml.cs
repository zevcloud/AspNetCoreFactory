#pragma checksum "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb6ab2905d254644fdca93923f9824f2e6a591d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb6ab2905d254644fdca93923f9824f2e6a591d", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 708, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777a8b59bf4a47159bc5427b24802518", async() => {
                BeginContext(33, 695, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>登录-网站管理系统</title>
    <meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
    <link href=""/lib/bootstrap/dist/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""/lib/font-awesome/css/font-awesome.min.css"" rel=""stylesheet"" />
    <link href=""/lib/dist/css/AdminLTE.min.css"" rel=""stylesheet"" />
    <link href=""/lib/common/css/style.css"" rel=""stylesheet"" />
    <script src=""/lib/jQuery/jquery-1.9.1.min.js""></script>
    <link href=""/lib/lock/iconfont.css"" rel=""stylesheet"" />
    <script src=""/lib/lock/lock.js""></script>


");
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
            BeginContext(735, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(737, 3260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7be2695998c8466f9fedd51cbb871c99", async() => {
                BeginContext(799, 3191, true);
                WriteLiteral(@"
    <div class=""pro-zc-bg""></div>
    <div class=""login-box"">
        <div class=""login-logo""><a href=""javascript:;"">后台管理系统</a></div>
        <div class=""login-box-body"">
            <p class=""login-box-msg"">请填写用户名密码登录系统</p>
            <div class=""form-group has-feedback"">
                <input type=""text"" class=""form-control"" id=""txtloginName"" name=""LoginName"" asp-for=""LoginName"" placeholder=""帐号"">
                <span class=""glyphicon form-control-feedback fa fa-user fa-lg""></span>
            </div>
            <div class=""form-group has-feedback"">
                <input type=""password"" class=""form-control"" id=""txtloginPass"" name=""LoginPwd"" placeholder=""密码"">
                <span class=""glyphicon form-control-feedback fa fa-lock fa-lg""></span>
            </div>

            <div class=""form-group"">
                <div id=""slide_box"">
                    <div id=""slide_xbox"" style=""width: 50px;"">
                        <div id=""btn"">
                            <i class=""iconfont ic");
                WriteLiteral(@"on-double-right""></i>

                        </div>
                    </div>
                    请按住滑块，拖动到最右边
                </div>
            </div>

            <div class=""row"">
                <div class=""col-xs-8""></div>
                <div class=""col-xs-4"">
                    <button type=""button"" onclick=""clickLogin(this)"" class=""btn btn-primary btn-block btn-flat login"" data-loading-text=""&lt;i class='fa fa-spinner fa-spin '&gt;&lt;/i&gt; 登录"">登录</button>
                </div>
            </div>

            <input type=""hidden"" value="""" name=""loginRawUrlPath"" />
        </div>
    </div>


    <script>

        function clickLogin(_this) {
            var loginName = $(""input[name='LoginName']"").val();
            var loginPwd = $(""input[name='LoginPwd']"").val();
            var i = 1;
            $.ajax({
                url: ""/api/views/login"",
                data: { ""loginName"": loginName, ""loginPwd"": loginPwd, ""i"": i },
                dataType: ""json"",
    ");
                WriteLiteral(@"            type: ""post"",
                beforeSend: function () {
                    $(_this).attr(""disabled"", true);
                    $(_this).text(""登录中..."");
                    $("".pro-zc-bg"").fadeIn(200);
                },
                success: function (_result) {
                    if (_result.HttpCode == 1) {
                        window.location.href = ""/backstage/nav"";  //先进入的是导航页面，后期加入首页
                    }
                    else {
                        $(""#code"").trigger(""click"");
                        alert(_result.Message);
                        return false;
                    }
                }, error: function (xmlRequest) {
                    console.log(xmlRequest.responseText);
                    $(""#code"").trigger(""click"");
                    alert(""服务器开了个小差,请耐心等待一会儿~"");
                    return false;
                }, complete: function () {
                    $(_this).removeAttr(""disabled"", true);
                    $(_this).text(""登");
                WriteLiteral("录\");\r\n                    $(\".pro-zc-bg\").fadeOut(200);\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3997, 9, true);
            WriteLiteral("\r\n</html>");
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
