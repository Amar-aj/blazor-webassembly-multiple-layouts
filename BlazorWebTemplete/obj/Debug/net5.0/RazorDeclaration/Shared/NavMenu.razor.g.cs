// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;
    private bool expandSubMenu;
    private bool expandTimeSubMenu;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void CollapseNavMenu()
    {
        collapseNavMenu = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
