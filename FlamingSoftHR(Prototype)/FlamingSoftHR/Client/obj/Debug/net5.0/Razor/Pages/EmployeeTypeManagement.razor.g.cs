#pragma checksum "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca53e055e954a07265bb43498299df20e1d6fe2"
// <auto-generated/>
#pragma warning disable 1591
namespace FlamingSoftHR.Client.Pages
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
#nullable restore
#line 3 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
using FlamingSoftHR.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
using FlamingSoftHR.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EmployeeTypeManagement")]
    public partial class EmployeeTypeManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Employee Type Management</h1>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "onsubmit", "return false;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group input-group-md mb-2");
            __builder.AddMarkupContent(5, "<span class=\"input-group-text\">Search by Description</span>\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                                             filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filter = __value, filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                                  Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
 if (null == eTypes)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<p><em>Loading employee types. Please wait...</em></p>");
#nullable restore
#line 20 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "table-responsive");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table table-hover table-striped");
            __builder.AddMarkupContent(21, "<thread><tr><th>Description</th></tr></thread>\r\n        ");
            __builder.OpenElement(22, "tbody");
            __Blazor.FlamingSoftHR.Client.Pages.EmployeeTypeManagement.TypeInference.CreateListDisplayComponent_0(__builder, 23, 24, 
#nullable restore
#line 28 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                         eTypes

#line default
#line hidden
#nullable disable
            , 25, (etype) => (__builder2) => {
                __builder2.OpenElement(26, "tr");
                __builder2.OpenElement(27, "td");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "value", 
#nullable restore
#line 32 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                                                            etype.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                                                                                            (ChangeEventArgs e) => Save(e, etype, "Description")

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "td");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "class", "btn btn-5m btn-danger");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                                                              () => Delete(etype.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(38, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenElement(40, "form");
            __builder.AddAttribute(41, "class", "mt-5");
            __builder.AddAttribute(42, "onsubmit", "return false;");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "input-group input-group-md mb-2");
            __builder.AddMarkupContent(45, "<span class=\"input-group-text\">Description</span>\r\n        ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "autocomplete", "off");
            __builder.AddAttribute(50, "required");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                                                                          newetype.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newetype.Description = __value, newetype.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-success");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
                                                  Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Add employee type");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\mgzzg\OneDrive\Escritorio\CodingChallengeFS\FlamingSoftHR\FlamingSoftHR\Client\Pages\EmployeeTypeManagement.razor"
       
    private List<EmployeeType> eTypes;
    private EmployeeType newetype = new EmployeeType();
    private string filter;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        eTypes = await http.GetFromJsonAsync<List<EmployeeType>>("/api/EmployeeType");
    }

    protected async Task Search()
    {
        eTypes = await http.GetFromJsonAsync<List<EmployeeType>>($"/api/EmployeeType?UserId={Uri.EscapeDataString(filter)}");
    }

    protected async Task Add()
    {
        using (var msg = await http.PostAsJsonAsync<EmployeeType>("/api/EmployeeType", newetype, System.Threading.CancellationToken.None))
        {
            if (msg.IsSuccessStatusCode)
            {
                newetype.Description = null;
            }
        }
    }

    protected async Task Save(ChangeEventArgs e, EmployeeType etype, string propfield)
    {
        PropertyInfo pInfo = typeof(EmployeeType).GetProperty(propfield);
        pInfo.SetValue(etype, e);

        using (var msg = await http.PutAsJsonAsync<EmployeeType>($"/api/EmployeeType/{etype.Id}", etype, System.Threading.CancellationToken.None))
        {
            if (msg.IsSuccessStatusCode) { }
            else
            {
                //Mostrar estado de error
            }
        }
    }

    protected async Task Delete(Guid Id)
    {
        using (var msg = await http.DeleteAsync($"/api/EmployeeType/{Id}"))
        {
            if (msg.IsSuccessStatusCode)
            {
                int i;
                for (i = 0; eTypes.Count > i && Id != eTypes[i].Id; i++) ;
                eTypes.RemoveAt(i);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.FlamingSoftHR.Client.Pages.EmployeeTypeManagement
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListDisplayComponent_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::FlamingSoftHR.Client.Components.ListDisplayComponent<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Row", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
