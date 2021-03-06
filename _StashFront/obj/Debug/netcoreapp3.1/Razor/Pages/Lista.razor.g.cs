#pragma checksum "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b27562f23734681cbd55aa4e8b1f25816f65a09f"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Lista de livros.</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<table width=""100%"" style=""background:#0A2464;color:honeydew"">
    <tr class=""flex-row"">
        <td width=""20"">&nbsp;</td>
        <td class=""d-sm-inline-flex align-content-between"">
        </td>
    </tr>
    <tr>
        <td colspan=""2""></td>
    </tr>
</table>

");
#nullable restore
#line 29 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
 if (Services.GetLista() == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 32 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, @"<thead>
            <tr>
                <th>Título</th>
                <th>Autor</th>
                <th>Genero</th>
                <th>Locação</th>
                <th>Nota</th>
                <th>Status</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 47 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
             foreach (var liv in Services.GetLista())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 50 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                         liv.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 51 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                         liv.Autor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 52 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                         liv.Genero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 53 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                         liv.Emp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 54 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                         liv.Nota

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 55 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                         liv.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                                                                    async () => await EditarLivro(liv.Nome) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "style", "width:110px;");
            __builder.AddContent(37, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-danger");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
                                                                   async () => await DeleteLivro(liv.Nome)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Deletar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 60 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 63 "C:\Users\jone.prado\source\repos\_Stash\_StashFront\Pages\Lista.razor"
}

#line default
#line hidden
#nullable disable
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
