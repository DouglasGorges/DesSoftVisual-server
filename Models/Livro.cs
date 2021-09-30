using System;
using System.Collections.Generic;

namespace server.Models
{
    public class Livro
    {
        public Livro() => CriadoEm = DateTime.Now;

        public int Id { get; set;}
        public string Autor { get; set;}
        public string Titulo { get; set;}
        public double Preco { get; set;}
        public DateTime DataPublicacao { get; set;}
        public DateTime CriadoEm { get; set;}

        public override string ToString() =>
            $"Autor: {Autor} | Titulo: {Titulo} | Preco: {Preco:C2} | DataPublicacao: {DataPublicacao}";
   
    }
}