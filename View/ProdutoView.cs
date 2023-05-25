using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_MVC_Evento.Model;

namespace Projeto_MVC_Evento.View
{
    public class ProdutoView
    {
         // metodo para exibir os dados da lista de produtos
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Descricao do evento: {item.Descricao}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Data do evento: {item.Data}");
                Console.WriteLine();
                Console.ResetColor();
                
                
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe a descricao do evento: ");
            novoProduto.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe o nome do evento: ");
            novoProduto.Nome = (Console.ReadLine());

            Console.WriteLine($"Informe a data do evento: ");
            novoProduto.Data = Console.ReadLine();

            return novoProduto;
        }
    }
}