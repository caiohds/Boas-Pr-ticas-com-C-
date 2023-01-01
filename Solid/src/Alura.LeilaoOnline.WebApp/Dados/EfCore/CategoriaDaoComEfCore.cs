using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class CategoriaDaoComEfCore : ICategoriaDao
    {
        AppDbContext _context;
        public CategoriaDaoComEfCore()
        {
            _context = new AppDbContext();
        }
        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias.Include(categoria => categoria.Leiloes).FirstOrDefault(categoria => categoria.Id == id); 
        }
        public IEnumerable<Categoria> BuscarTodos()
        {

            return _context.Categorias.Include(categoria => categoria.Leiloes).ToList();
        } 
    }
}
