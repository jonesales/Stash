#pragma checksum "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Novo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e82955367c022bfad4fb023fd8252282579c5b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace _StashFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using _StashFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\_Imports.razor"
using _StashFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Novo.razor"
using _StashFront.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Novo.razor"
using _StashLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Novo.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Novo.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Novo.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class Novo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Novo.razor"
       

    Livro[] _livros;

    Livro livro = new Livro();

    public async Task AddLivro()
    {
        try
        {
            var novoLivroJson = JsonConvert.SerializeObject(livro);
            StringContent content = new StringContent(novoLivroJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var url = "http://localhost:57804/livro/add";
            var resultRequest =await httpClient.PostAsync($"{url}", content);

        }
        catch { }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
