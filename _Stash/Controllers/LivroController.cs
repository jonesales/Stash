using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using _StashLib;
using _StashLib.Nova;
using LiteDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace _Stash.Controllers
{
    [ApiController]
    [Route("livro")]
    public class Livros : ControllerBase
    {
        private readonly ILiteDatabase db;
        private readonly ILiteCollection<Livro> livroColl;

        public Livros()
        {
            
            db = new LiteDatabase(AppContext.BaseDirectory + "stash.db");
            livroColl = db.GetCollection<Livro>("livros");
        }

        [HttpGet]                              //LISTA DE LIVROS COMPLETA
        [Route("lista")]
        public ActionResult GetAll()
        {
                var result = livroColl.FindAll().ToList();
                db.Dispose();
                return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult AddLivro(Livro novo)
        {

                livroColl.Insert(novo);
                var result = livroColl.FindAll().ToList();
                db.Dispose();
                return Ok(result);
        }

        [HttpGet]                               //RETORNA LISTA DE LIVROS DO AUTOR
        [Route("autor")]
        public ActionResult GetAutor(string q)
        {
            var retorno = new Result<List<Livro>>();
            using (var db = new LiteDatabase(@"C:\Users\jone.prado\source\repos\_Stash\_StashLib\Nova\stash.db"))
            {
                var livroColl = db.GetCollection<Livro>("livros");
                var result = livroColl.Find(x => x.Autor == q).ToList();

                if (result.Any())
                {
                    retorno.Data = result;
                    retorno.Status = HttpStatusCode.OK;
                }
                else
                {
                    retorno.Status = HttpStatusCode.BadRequest;
                    retorno.Error = true;
                    retorno.Message = "Não existe nenhum livro cadastrado desse autor.";
                }
                return Ok(retorno);
            }
        }

        [HttpGet]                               //RETORNA LISTA DE LIVROS DO GENERO
        [Route("genero")]
        public ActionResult GetGenero(string q)
        {
            var retorno = new Result<List<Livro>>();
            using (var db = new LiteDatabase(@"C:\Users\jone.prado\source\repos\_Stash\_StashLib\Nova\stash.db"))
            {
                var livroColl = db.GetCollection<Livro>("livros");
                var result = livroColl.Find(x => x.Genero == q).ToList();

                if (result.Any())
                {
                    retorno.Data = result;
                    retorno.Status = HttpStatusCode.OK;
                }
                else
                {
                    retorno.Status = HttpStatusCode.BadRequest;
                    retorno.Error = true;
                    retorno.Message = "Não existe nenhum livro cadastrado desse genero.";
                }
                return Ok(retorno);
            }
        }

        [HttpGet]                               //RETORNA LISTA DE LIVROS POR STATUS
        [Route("status")]
        public ActionResult GetStatus(string q)
        {
            var retorno = new Result<List<Livro>>();
            using (var db = new LiteDatabase(@"C:\Users\jone.prado\source\repos\_Stash\_StashLib\Nova\stash.db"))
            {
                var livroColl = db.GetCollection<Livro>("livros");
                var result = livroColl.Find(x => x.Status == q).ToList();

                if (result.Any())
                {
                    retorno.Data = result;
                    retorno.Status = HttpStatusCode.OK;
                }
                else
                {
                    retorno.Status = HttpStatusCode.BadRequest;
                    retorno.Error = true;
                    retorno.Message = "Não existe nenhum livro com esse status.";
                }
                return Ok(retorno);
            }
        }


        [HttpDelete]                            //DELETA UM LIVRO DO BANCO PELO NOME
        [Route("excluir")]
        public ActionResult Delete(string nome)
        {
            var retorno = new Result<List<Livro>>();


                var teste = livroColl.FindOne(x => x.Nome == nome);

                if (teste != null)
                {
                    livroColl.Delete(teste.Id);
                    retorno.Data = livroColl.FindAll().ToList();
                    retorno.Status = HttpStatusCode.OK;
                }
                else
                {
                    retorno.Status = HttpStatusCode.BadRequest;
                    retorno.Error = true;
                    retorno.Message = "Não existe nenhum livro com esse nome.";
                }
            db.Dispose();
                return Ok(retorno);
        }


        [HttpPut]                               //ATUALIZA O STATUS DO LIVRO PELO NOME
        [Route("atualizar")]
        public ActionResult UpdateStatus(string nome, string novo)
        {
            var retorno = new Result<List<Livro>>();

            using (var db = new LiteDatabase(@"C:\Users\jone.prado\source\repos\_Stash\_StashLib\Nova\stash.db"))
            {
                var livroColl = db.GetCollection<Livro>("livros");

                var livro = livroColl.FindOne(x => x.Nome == nome);

                if (livro != null)
                {
                    livro.Status = novo;

                    livroColl.Update(livro);

                    retorno.Data = livroColl.FindAll().ToList();
                    retorno.Status = HttpStatusCode.OK;
                }
                else
                {
                    retorno.Status = HttpStatusCode.BadRequest;
                    retorno.Error = true;
                    retorno.Message = "Não existe nenhum livro com esse nome.";
                }

                return Ok(retorno);
            }
        }

        [HttpPut]                               //ATUALIZA UM LIVRO PELO NOME
        [Route("editar")]
        public ActionResult Update(string nome, Livro novo)

        {
            var retorno = new Result<List<Livro>>();

            using (var db = new LiteDatabase(@"C:\Users\jone.prado\source\repos\_Stash\_StashLib\Nova\stash.db"))
            {
                var livroColl = db.GetCollection<Livro>("livros");

                var livro = livroColl.FindOne(x => x.Nome == nome);

                if (livro != null)
                {
                    livro.Nome = novo.Nome;
                    livro.Autor = novo.Autor;
                    livro.Genero = novo.Genero;
                    livro.Status = novo.Status;

                    livroColl.Update(livro);

                    retorno.Data = livroColl.FindAll().ToList();
                    retorno.Status = HttpStatusCode.OK;
                }
                else
                {
                    retorno.Status = HttpStatusCode.BadRequest;
                    retorno.Error = true;
                    retorno.Message = "Não existe nenhum livro com esse nome.";
                }

                return Ok(retorno);
            }
        }
    }
}