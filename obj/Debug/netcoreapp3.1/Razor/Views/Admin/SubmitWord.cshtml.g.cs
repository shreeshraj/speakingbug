#pragma checksum "C:\Users\Shreesh\Desktop\SpeakingBug\Views\Admin\SubmitWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81549c26fc2bf9073d942a867a10add65bb9b7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SubmitWord), @"mvc.1.0.view", @"/Views/Admin/SubmitWord.cshtml")]
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
#line 1 "C:\Users\Shreesh\Desktop\SpeakingBug\Views\_ViewImports.cshtml"
using CoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shreesh\Desktop\SpeakingBug\Views\_ViewImports.cshtml"
using CoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81549c26fc2bf9073d942a867a10add65bb9b7e2", @"/Views/Admin/SubmitWord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eef958cfa2a73942bbe1330b5d72b088dccf54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SubmitWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreProject.Models.WordEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("NewWordForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("NewWordForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Shreesh\Desktop\SpeakingBug\Views\Admin\SubmitWord.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""margin-top:5%;"">
    <!-- Material form contact -->
    <div class=""card"">

        <h5 class=""card-header primary-color white-text text-center py-4"">
            <strong>Submit New Word</strong>
        </h5>

        <!--Card content-->
        <div class=""card-body px-lg-5 pt-0"">

            <!-- Form -->
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81549c26fc2bf9073d942a867a10add65bb9b7e25148", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"md-form\">\r\n\r\n                    ");
#nullable restore
#line 23 "C:\Users\Shreesh\Desktop\SpeakingBug\Views\Admin\SubmitWord.cshtml"
               Write(Html.TextBoxFor(x => x.Word, new { @class = "form-control md-textarea", @rows = "1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label for=\"Word\">Word</label>\r\n\r\n                </div>\r\n                ");
#nullable restore
#line 27 "C:\Users\Shreesh\Desktop\SpeakingBug\Views\Admin\SubmitWord.cshtml"
           Write(Html.ValidationMessageFor(x => x.Word));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!--Message-->\r\n                <div class=\"md-form\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\Shreesh\Desktop\SpeakingBug\Views\Admin\SubmitWord.cshtml"
               Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control md-textarea", @rows = "5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label for=\"Description\">Description</label>\r\n\r\n                </div>\r\n                ");
#nullable restore
#line 34 "C:\Users\Shreesh\Desktop\SpeakingBug\Views\Admin\SubmitWord.cshtml"
           Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- Send button -->\r\n                <input type=\"button\" class=\"btn  btn-rounded btn-block z-depth-0 my-4 waves-effect btn-primary\" id=\"btnSubmit\"  style=\"margin-top:10%\" value=\"Send\">\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <!-- Form -->\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <!-- Material form contact -->\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
   
    <script>

        $(document).ready(function () {
            $(""#btnSubmit"").click(function () {
                addNewWord();
            });
        });

        function addNewWord() {
            if ($(""#NewWordForm"").valid()) {
              var data={};
              data.Word=$(""#Word"").val();
              data.Description=$(""#Description"").val();
             
                $.ajax({
                    type: ""POST"",
                    url: ""/api/AdminApi/Word"",
                    data: JSON.stringify(data),
                    dataType: ""json"",
                    contentType: ""application/json"",
                    success: function (res) {
                        alert(res);
                    }
                });
            }
        }
    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreProject.Models.WordEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
