#pragma checksum "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Log\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9008595de5fea71ea48d54e745e156afa3608000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log_Index), @"mvc.1.0.view", @"/Views/Log/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Log/Index.cshtml", typeof(AspNetCore.Views_Log_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9008595de5fea71ea48d54e745e156afa3608000", @"/Views/Log/Index.cshtml")]
    public class Views_Log_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Log\Index.cshtml"
  
    ViewData["Title"] = "日志列表页";
    Layout = "~/Views/Layout/Index.cshtml";
    ViewBag.isHaveListMore = true;//设置成true就可以引用js

#line default
#line hidden
            BeginContext(140, 2784, true);
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content"">
        <div class=""box"">
            <div class=""box box-default"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">日志列表</h3>
                    <div class=""box-tools pull-right"">
                    </div>
                </div>
                <div class=""box-body"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default group-list-all"">全选</button>
                        <button type=""button"" class=""btn btn-default group-list-delete"" onclick=""api.ActionDeleteInfo(delete_key.LogKey,this,1)"">删除</button>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""box box-info"">
                            <div class=""box-body table-responsive no-padding"">
                                <table class=""table table-hover table-bo");
            WriteLiteral(@"rdered "">
                                    <thead>
                                        <tr>
                                            <th>选择</th>
                                            <th>ID</th>
                                            <th>日志类型</th>
                                            <th>访问页面</th>
                                            <th>访问方式</th>
                                            <th>访问时间</th>
                                            <th>操作</th>
                                        </tr>
                                    </thead>
                                    <tbody class=""tbody-table""></tbody>
                                </table>
                            </div>
                        </div>
                        <div class=""box box-notborder"">
                            <input type=""button"" class=""btn btn-default big  form-control"" value=""加载更多..."" id=""ShowMoreInfo"" style=""display:none"" />
                        </div>
");
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
<script type=""text/html"" id=""append_html"">
    {{if list===null||list.length===0}}
    {{else}}
    {{each list as item}}
    <tr>
        <td>
            <input type=""checkbox"" class=""list-group-checked"" data-id=""{{item.id}}"" />
        </td>
        <td>{{item.id}}</td>
        <td>{{item.oper}}</td>
        <td>{{item.actionName}}</td>
        <td>{{item.respone}}</td>
        <td>{{item.time}}</td>
        <td>
            <a class=""btn btn-primary btn-xs"" href=""""><i class=""fa fa-edit""></i>查看详情</a>
        </td>
    </tr>
    {{/each}}
    {{/if}}
</script>

<script type=""text/javascript"">
");
            EndContext();
#line 73 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Log\Index.cshtml"
      
              var json=ViewData["firstList"].ToString();
    

#line default
#line hidden
            BeginContext(2997, 14, true);
            WriteLiteral("    jsonData= ");
            EndContext();
            BeginContext(3013, 28, false);
#line 76 "F:\Demo\_NetCore\AspNetCoreSoultion\AspNetCore.Mvc.Web\Views\Log\Index.cshtml"
          Write(Html.Raw(json==""?"''":json));

#line default
#line hidden
            EndContext();
            BeginContext(3042, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
            BeginContext(3382, 15, true);
            WriteLiteral("</script>\r\n\r\n\r\n");
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
