using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICommand<T>
    {
       
        void incluir(T obj);
        void Excluir(T obj);
        void Alterar(T obj);
    }
}
