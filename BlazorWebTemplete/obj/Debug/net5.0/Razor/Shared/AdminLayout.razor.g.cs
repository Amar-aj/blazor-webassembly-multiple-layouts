#pragma checksum "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b762aed695da6cb969eb9076cf7668e8979c79cc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebTemplete.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using BlazorWebTemplete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using BlazorWebTemplete.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenComponent<BlazorWebTemplete.Shared.AdminNavMenu>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddContent(5, 
#nullable restore
#line 7 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\AdminLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.AddMarkupContent(7, "<footer class=\"border-top footer text-muted fixed-bottom\"><div class=\"container mt-4 mb-4\">\r\n        &copy; 2021 - Admin Layout\r\n    </div></footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
