#pragma checksum "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7936c197d6afbdb9922d78db362d27ac507a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Form), @"mvc.1.0.view", @"/Views/Client/Form.cshtml")]
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
#line 1 "/home/vsonline/workspace/faegtodo/Views/_ViewImports.cshtml"
using faegtodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/vsonline/workspace/faegtodo/Views/_ViewImports.cshtml"
using faegtodo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7936c197d6afbdb9922d78db362d27ac507a0b", @"/Views/Client/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7bfab2a696b00d56379ef319e92896ae40cdca6", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<faegtodo.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   
    ViewData["Title"] = "Cliente"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Cliente</h2> \n\n");
#nullable restore
#line 9 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
 using (Html.BeginForm("Form","Client")){ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\"> \n        ");
#nullable restore
#line 11 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        ");
#nullable restore
#line 12 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        ");
#nullable restore
#line 13 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n    </div> \n    <div class=\"form-group\"> \n        ");
#nullable restore
#line 16 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        ");
#nullable restore
#line 17 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.EditorFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        ");
#nullable restore
#line 18 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.ValidationMessageFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n    </div> \n    <div class=\"form-group\"> \n        ");
#nullable restore
#line 21 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.LabelFor(m => m.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        ");
#nullable restore
#line 22 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.EditorFor(m => m.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        ");
#nullable restore
#line 23 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
   Write(Html.ValidationMessageFor(m => m.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n    </div> \n    <div class=\"form-group\"> \n        <button type=\"submit\" class=\"btn btn-primary\">Save</button> \n    </div> \n");
#nullable restore
#line 28 "/home/vsonline/workspace/faegtodo/Views/Client/Form.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<faegtodo.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591