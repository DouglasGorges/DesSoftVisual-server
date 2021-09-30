using System.Collections.Generic;
using System;
using System.Linq;
using server.Data;
using server.Models;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{

    [ApiController]
    [Route("server")]
    public class LivroController
    {
        private readonly DataContext _context;

        public LivroController(DataContext context) => _context = context;

        [HttpPost]
        [Route("create")]
        public Livro Create(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            return livro;
        }

        [HttpGet]
        [Route("list")]
        public List<Livro> List() => _context.Livros.ToList();

        [HttpGet]
        [Route("findById/{id?}")]
        public Livro GetById(int id) => _context.Livros.Find(id);

        [HttpPut]
        [Route("update")]
        public Livro Update(Livro livro)
        {
            Livro livroOriginal = GetById(livro.Id);

            livroOriginal.Autor = livro.Autor;
            livroOriginal.Titulo = livro.Titulo;
            livroOriginal.Preco = livro.Preco;
            livroOriginal.DataPublicacao = livro.DataPublicacao;

            _context.Livros.Update(livroOriginal);
            _context.SaveChanges();
            return livroOriginal;
        }

        [HttpDelete]
        [Route("delete/{id?}")]
        public Livro Delete(int id)
        {
            Livro livro = GetById(id);
            _context.Livros.Remove(livro);
            _context.SaveChanges();
            return livro;
        }
    }
}