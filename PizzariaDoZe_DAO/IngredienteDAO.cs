﻿using System.Data;
using System.Data.Common;

namespace PizzariaDoZe_DAO
{
    // é necessario referenciar o DAO no PizzariaDoZe -> botão direito + Adicionar + Referencia de Projeto 
    // Model
    public class Ingrediente
    {
        public int Id_ingrediente { get; set; }
        public string Nome { get; set; }

        public Ingrediente(int id_ingrediente = 0, string nome = "")
        {
            Id_ingrediente = id_ingrediente;
            Nome = nome;
        }

        public override string ToString()
        {
        return Nome;
        }
    }
    public class IngredienteDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public IngredienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        //inserir ingrediente
        public void InserirDbProvider(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão

            //Adiciona parâmetro (@campo e valor) - lida com o SQL Injection
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = ingrediente.Nome; comando.Parameters.Add(nome);
            
            conexao.Open();

            comando.CommandText = @"INSERT INTO tb_ingrediente(nome) VALUES (@nome)";
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public DataTable Buscar(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (ingrediente.Id_ingrediente > 0)
            {
                auxSqlFiltro = "WHERE i.Id_ingrediente = " + ingrediente.Id_ingrediente + " ";
            }
            else if (ingrediente.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE i.nome like '%" + ingrediente.Nome + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.Id_ingrediente AS ID, i.nome AS Nome " +
            "FROM tb_ingrediente AS i " +
            auxSqlFiltro +
            "ORDER BY i.nome;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}