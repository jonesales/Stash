#pragma checksum "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b27562f23734681cbd55aa4e8b1f25816f65a09f"
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
#line 3 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
using _StashFront.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
using _StashLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista")]
    public partial class Lista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
       



    Livro livro = new Livro();

    //protected async Task GetLista()
    //{
    //    try
    //    {
    //        var url = "http://localhost:57804/livro/lista";

    //        var httpClient = new HttpClient();

    //        var resultRequest = await httpClient.GetAsync(url);

    //        if (resultRequest.IsSuccessStatusCode)
    //        {
    //            var resultJson = resultRequest.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    //            var result = JsonConvert.DeserializeObject<List<Livro>>(resultJson);
    //        }
    //    }
    //    catch { }

    //}


    protected async Task DeleteLivro(string nome)
    {
        var httpClient = new HttpClient();

        var url = "http://localhost:57804/livro/excluir";

        await httpClient.DeleteAsync($"{url}?nome={nome}");

    }

    protected async Task EditarLivro(string nome)
    {
        var httpClient = new HttpClient();

        var url = "http://localhost:57804/livro/editar";

        var novoLivroJson = JsonConvert.SerializeObject(livro);
        StringContent content = new StringContent(novoLivroJson, Encoding.UTF8, "application/json");

        await httpClient.PutAsync($"{url}?nome={nome}", content);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
