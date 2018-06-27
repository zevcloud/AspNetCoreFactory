#pragma checksum "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19d4a1cce9e25f8aff9c713bedf4c22b8fa35da8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Detail), @"mvc.1.0.view", @"/Views/Manager/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/Detail.cshtml", typeof(AspNetCore.Views_Manager_Detail))]
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
#line 12 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
using AspNetCore.Mvc.Entities;

#line default
#line hidden
#line 13 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
using AspNetCore.Mvc.Utils;

#line default
#line hidden
#line 14 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
using static AspNetCore.Mvc.Utils.Enum.EnumStatus;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d4a1cce9e25f8aff9c713bedf4c22b8fa35da8", @"/Views/Manager/Detail.cshtml")]
    public class Views_Manager_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ManagerRoleId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select-select2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select-choose"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ManagerStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("gvcms-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
  
    var roleList = ViewData["baseRoleList"] as IEnumerable<SelectListItem>;
    var titleName = "管理员详情";
    Layout = "~/Views/Layout/Index.cshtml";
    var editModel = ViewData["editModel"] as ManagerModel;
    editModel = editModel == null ? new ManagerModel() : editModel;
    titleName = editModel == new ManagerModel() ? "新增管理员" : editModel.ManagerName + "-管理员详情";
    ViewData["Title"] = titleName;


#line default
#line hidden
            BeginContext(593, 1390, true);
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content"">
        <div class=""box"">
            <div class=""box box-default"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">编辑管理员</h3>
                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                    </div>
                </div>
                <div class=""box-body"">
                    <a href=""/backstage/manager/index.html"" class=""btn btn-info"">返回列表页</a>
                </div>

                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""box box-info"">
                            <ul id=""myTab"" class=""nav nav-tabs"">
                                <li class=""active"">
                                    <a h");
            WriteLiteral(@"ref=""#Info"" data-toggle=""tab"">
                                        基本信息
                                    </a>
                                </li>
                            </ul>
                            <div class=""tab-content"">
                                <div class=""tab-pane fade in active"" id=""Info"">
                                    ");
            EndContext();
            BeginContext(1983, 4879, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90795bec33154ad2b274f189d1e100a8", async() => {
                BeginContext(2008, 390, true);
                WriteLiteral(@"
                                        <div class=""box-body"">
                                            <div class=""form-group"">
                                                <label class=""col-sm-2 control-label"">管理角色组<i class=""required-red"">*</i></label>
                                                <div class=""col-sm-7"">
                                                    ");
                EndContext();
                BeginContext(2398, 281, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5f1973d9e394ea489761b816ab8f5ea", async() => {
                    BeginContext(2524, 58, true);
                    WriteLiteral("\r\n                                                        ");
                    EndContext();
                    BeginContext(2582, 34, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "389568c86fa04b9a81803ae1e3bff9db", async() => {
                        BeginContext(2600, 7, true);
                        WriteLiteral("==请选择==");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2616, 54, true);
                    WriteLiteral("\r\n                                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 49 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (roleList);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => (editModel.ManagerRoleId));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2679, 678, true);
                WriteLiteral(@"
                                                </div>
                                                <div class=""col-sm-3"">

                                                </div>
                                            </div>
                                        </div>

                                        <div class=""box-body"">
                                            <div class=""form-group "">
                                                <label class=""col-sm-2 control-label"">是否启用<i class=""required-red"">*</i></label>
                                                <div class=""col-sm-7"">
                                                    ");
                EndContext();
                BeginContext(3357, 164, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb927f42905745ce9b1b3750643baee8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 63 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => (editModel.ManagerStatus));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 63 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (Html.GetEnumSelectList(typeof(Status)));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3521, 791, true);
                WriteLiteral(@"
                                                </div>
                                                <div class=""col-sm-3"">
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""box-body"">
                                            <div class=""form-group "">
                                                <label for="""" class=""col-sm-2 control-label"">管理用户名称<i class=""required-red"">*</i></label>
                                                <div class=""col-sm-7"">
                                                    <input type=""text"" datatype=""*2-20"" sucmsg="""" name=""ManagerName"" class=""form-control"" placeholder=""管理用户名称""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4312, "\"", 4363, 1);
#line 74 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
WriteAttributeValue("", 4320, editModel==null?"":editModel.ManagerName, 4320, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4364, 789, true);
                WriteLiteral(@">
                                                </div>
                                                <div class=""col-sm-3"">
                                                </div>
                                            </div>
                                        </div>


                                        <div class=""box-body"">
                                            <div class=""form-group "">
                                                <label class=""col-sm-2 control-label"">登录密码<i class=""required-red"">*</i></label>
                                                <div class=""col-sm-7"">
                                                    <input type=""password"" datatype=""*6-20"" sucmsg="""" name=""ManagerPass"" class=""form-control"" placeholder=""管理登录密码""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5153, "\"", 5204, 1);
#line 86 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
WriteAttributeValue("", 5161, editModel==null?"":editModel.ManagerPass, 5161, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5205, 787, true);
                WriteLiteral(@">
                                                </div>
                                                <div class=""col-sm-3"">
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""box-body"">
                                            <div class=""form-group "">
                                                <label class=""col-sm-2 control-label"">确认密码<i class=""required-red"">*</i></label>
                                                <div class=""col-sm-7"">
                                                    <input type=""password"" datatype=""*6-20"" sucmsg="""" name=""ManagerREPass"" class=""form-control"" placeholder=""确认密码""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5992, "\"", 6043, 1);
#line 97 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
WriteAttributeValue("", 6000, editModel==null?"":editModel.ManagerPass, 6000, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6044, 436, true);
                WriteLiteral(@">
                                                </div>
                                                <div class=""col-sm-3"">
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""box-footer"">
                                            <input type=""hidden"" name=""ManagerId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6480, "\"", 6528, 1);
#line 105 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Manager\Detail.cshtml"
WriteAttributeValue("", 6488, editModel==null?0:editModel.ManagerId, 6488, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6529, 326, true);
                WriteLiteral(@" />
                                            <button type=""reset"" class=""btn btn-default"">重置</button>
                                            <input type=""button"" class=""btn btn-info"" onclick=""api.managerEdit(this)"" value=""提交保存"" />
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6862, 224, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n");
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
