#pragma checksum "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Components\ListDisplayComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db7ec0fbd6787edb102c6a0d51c5643fa69882c"
// <auto-generated/>
#pragma warning disable 1591
namespace FlamingSoftHR.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using FlamingSoftHR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\_Imports.razor"
using FlamingSoftHR.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class ListDisplayComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Components\ListDisplayComponent.razor"
 if(null != Items)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Components\ListDisplayComponent.razor"
                 foreach(var item in Items)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Components\ListDisplayComponent.razor"
                     Row(item)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Components\ListDisplayComponent.razor"
                              
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Components\ListDisplayComponent.razor"
                 
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Components\ListDisplayComponent.razor"
 
    [Parameter]
    public RenderFragment<TItem> Row { get; set; }

    [Parameter]
    public List<TItem> Items { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
