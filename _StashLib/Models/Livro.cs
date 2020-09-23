using System;

namespace _StashLib
{
    public class Livro
    {
        public Livro()
        {
            Id = new Guid();
        }
      
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Genero { get; set; }

        public string Autor { get; set; }

        public string Status { get; set; }

        public string Emp { get; set; }

        public float Nota { get; set; }
    }
}
