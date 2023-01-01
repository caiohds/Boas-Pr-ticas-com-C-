using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore : ILeilaoDao
    {
        AppDbContext _context;
        public LeilaoDaoComEfCore()
        {
            _context = new AppDbContext();
        }

        public void Alterar(Leilao obj)
        {
            _context.Leiloes.Update(obj);
            _context.SaveChanges();
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.FirstOrDefault(leilao => leilao.Id == id);
        }

        public IEnumerable<Leilao> BuscarTodos()
        {
            return _context.Leiloes.Include(leilao => leilao.Categoria);
        }

        public void Excluir(Leilao obj)
        {
            _context.Leiloes.Remove(obj);
            _context.SaveChanges();
        }

        public void incluir(Leilao obj)
        {
            _context.Leiloes.Add(obj);
            _context.SaveChanges();
        }
    }
}
