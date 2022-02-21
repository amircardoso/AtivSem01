using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    interface IOperacoesBD
    {
        void Inserir();
        void Alterar();
        void Deletar();
        void Pesquisar();
    }

    abstract class Cadastros : IOperacoesBD
       {
        #region IOperacoesBD
        public void Inserir()
        {
            Console.WriteLine("Executando o método Inserir da classe Cadastros para IOperacoesBD");
        }

        public void Alterar()
        {
            Console.WriteLine("Executando o método Alterar da classe Cadastros para IOperacoesBD");
        }

        public void Deletar()
        {
            Console.WriteLine("Executando o método Deletar da classe Cadastros para IOperacoesBD");
        }

        public void Pesquisar()
        {
            Console.WriteLine("Executando o método Pesquisar da classe Cadastros para IOperacoesBD");
        }

        {
          private readonly string _Conexao                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ;
        }

    public class Clientes;
    public class Pedidos;
}