using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Evento.Model
{
    public class Produto
    {
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }

        private const string PATH = "Database/Produto.csv";
        
        public Produto()
        {
           
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);  
            }
            
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                p.Descricao = atributos[0];             
                p.Nome = atributos[1];
                p.Data = atributos[2];

                
                produtos.Add(p);
            }
        
            return produtos;

        }

        public string prepararLinhaCSV(Produto p)
        {
            return $"{p.Descricao};{p.Nome};{p.Data};";
        }

        public void Inserir(Produto p)
        {
            string [] linhas = {prepararLinhaCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}