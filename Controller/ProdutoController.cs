using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_MVC_Evento.Model;
using Projeto_MVC_Evento.View;

namespace Projeto_MVC_Evento.Controller
{
    public class ProdutoController
    {
    //instância de objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

    //método controlador para acessar a listagem de produtos
    public void ListarEventos()
    {
        //lista de produtos que recebe os itens obtidos pelo método Ler da model
        List<Produto> produtos = produto.Ler();

        //chamada do metodo de exibicao (VIEW) recebendo como argumento a 
        produtoView.Listar(produtos);
    }

    // Metodo controlado para acessar o cadastro de produtos
    public void CadastrarEventos()
    {
        // Chamada para view que recebe cada objeto a ser inserido no csv
        Produto novoProduto = produtoView.Cadastrar();

        // chamada para a model para inserir esse objeto no csv
        produto.Inserir(novoProduto);
    }

    }
}

