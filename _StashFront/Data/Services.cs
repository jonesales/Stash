using _StashLib;
using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using _StashFront.Pages;

namespace _StashFront.Data
{
    public  class Services
    {
        public static List<Livro> GetLista()
        {
            try
            {
                var url = "http://localhost:57804/livro";

                var httpClient = new HttpClient();

                var resultRequest = httpClient.GetAsync($"{url}/lista");
                var response = resultRequest.GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    var resultJson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var result = JsonConvert.DeserializeObject<List<Livro>>(resultJson);
                    return result;
                }
            }
            catch { }

            return null;
        }

        //public static void AddLivro()
        //{
        //    try
        //    {

        //        var novoLivroJson = JsonConvert.SerializeObject(novo);
        //        StringContent content = new StringContent(novoLivroJson, Encoding.UTF8, "application/json");

        //        var httpClient = new HttpClient();
        //        var url = "http://localhost:57804/livro/add";
        //        var resultRequest = httpClient.PostAsync($"{url}", content);
        //        resultRequest.GetAwaiter().GetResult();

        //        var response = resultRequest.Result.Content.ReadAsStringAsync();
        //        response.GetAwaiter().GetResult(); ;
        //    }
        //    catch { }

        //}


    //    public static Action Deletar(string nome)
    //    {
    //        var url = "http://localhost:57804/livro/excluir";

    //        var httpClient = new HttpClient();

    //        var resultRequest = httpClient.DeleteAsync($"{url}?nome={nome}");
    //        resultRequest.GetAwaiter().GetResult();

    //        var result = resultRequest.Result.Content.ReadAsStringAsync();
    //        result.Wait();
    //    }
     }
}
