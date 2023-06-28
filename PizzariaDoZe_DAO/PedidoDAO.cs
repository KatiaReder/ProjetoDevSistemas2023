using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO
{

    public class Pedido
    { 
        public int Id { get; set; } 
        public string Cpf_cliente { get; set; }
        public string Cpf_funcionario { get; set; }
        public DateTime Data_pedido { get; set; } = DateTime.Now;
        public string Entrega { get; set; }
        public string Status_pedido { get; set; }
        public decimal Valor_total { get; set; }
        public string Tipo_pagamento { get; set; }

        public Pedido(int id = 0, string Cpf_cliente = "", string Cpf_funcionario = "", string entrega = "" , string status_pedido = "", decimal valor_total = 0, string tipo_pagamento = "")
        {
            Id = id;
            Cpf_cliente = Cpf_cliente;
            Cpf_funcionario = Cpf_funcionario;
            Entrega = entrega;
            Status_pedido = status_pedido;
            Valor_total = valor_total;
            Tipo_pagamento = tipo_pagamento;
        }
    }

    public class PedidoDAO
    {

        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }

        public PedidoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão

            var cpfCliente = comando.CreateParameter(); cpfCliente.ParameterName = "@cpfCliente";
            cpfCliente.Value = pedido.Cpf_cliente; comando.Parameters.Add(cpfCliente);
            var cpfFuncionario = comando.CreateParameter(); cpfFuncionario.ParameterName = "@cpfFuncionario";
            cpfFuncionario.Value = pedido.Cpf_funcionario; comando.Parameters.Add(cpfFuncionario);
            var entrega = comando.CreateParameter(); entrega.ParameterName = "@entrega";
            entrega.Value = pedido.Entrega; comando.Parameters.Add(entrega);
            var statusPedido = comando.CreateParameter(); statusPedido.ParameterName = "@statusPedido";
            statusPedido.Value = pedido.Status_pedido; comando.Parameters.Add(statusPedido);
            var valorTotal = comando.CreateParameter(); valorTotal.ParameterName = "@valorTotal";
            valorTotal.Value = pedido.Valor_total; comando.Parameters.Add(valorTotal);
            var tipoPagamento = comando.CreateParameter(); tipoPagamento.ParameterName = "@tipoPagamento";
            tipoPagamento.Value = pedido.Tipo_pagamento; comando.Parameters.Add(tipoPagamento);
            conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            comando.CommandText = @"INSERT INTO cad_pedidos (cpf_cliente, cpf_funcionario, entrega, status_pedido, valor_total, tipo_pagamento)
VALUES(@cpfCliente, @cpfFuncionario, @entrega, @statusPedido, @valorTotal, @tipoPagamento);" + auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdGerado = comando.ExecuteScalar();
            return Convert.ToInt32(IdGerado);
        }

        public void Editar(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter(); id.ParameterName = "@id"; id.Value = pedido.Id; comando.Parameters.Add(id);
            var cpfCliente = comando.CreateParameter(); cpfCliente.ParameterName = "@cpfCliente"; cpfCliente.Value = pedido.Cpf_cliente; comando.Parameters.Add(cpfCliente);
            var cpfFuncionario = comando.CreateParameter(); cpfFuncionario.ParameterName = "@cpfFuncionario"; cpfFuncionario.Value = pedido.Cpf_funcionario; comando.Parameters.Add(cpfFuncionario);
            var entrega = comando.CreateParameter(); entrega.ParameterName = "@entrega"; entrega.Value = pedido.Entrega; comando.Parameters.Add(entrega);
            var statusPedido = comando.CreateParameter(); statusPedido.ParameterName = "@statusPedido"; statusPedido.Value = pedido.Status_pedido; comando.Parameters.Add(statusPedido);
            var valorTotal = comando.CreateParameter(); valorTotal.ParameterName = "@valorTotal"; valorTotal.Value = pedido.Valor_total; comando.Parameters.Add(valorTotal);
            var tipoPagamento = comando.CreateParameter(); tipoPagamento.ParameterName = "@tipoPagamento"; tipoPagamento.Value = pedido.Tipo_pagamento; comando.Parameters.Add(tipoPagamento);
            conexao.Open();
            //realiza o UPDATE
            comando.CommandText = @"UPDATE cad_pedidos SET " +
            "cpf_cliente = @cpfCliente, " +
            "cpf_funcionario = @cpfFuncionario, " +
            "cpf_funcionario = @cpfFuncionario, " +
            "entrega = @entrega, " +
            "status_pedido = @statusPedido, " +
            "valor_total = @valorTotal, " +
            "tipo_pagamento = @tipoPagamento, " +
            "WHERE id_pedido = @id;";
            //executa o comando no banco de dados
            _ = comando.ExecuteNonQuery();
        }


        public DataTable Buscar(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (pedido.Id > 0)
            {
                auxSqlFiltro = "WHERE p.id_pedido = " + pedido.Id + " ";
            }
            else if (pedido.Status_pedido.Length > 0)
            {
                auxSqlFiltro = "WHERE p.status_pedido like '%" + pedido.Status_pedido + "%' ";
            }

            conexao.Open();
            comando.CommandText = @" " +
            "SELECT p.id_pedido AS ID, p.cpf_cliente AS Cliente, p.cpf_funcionario AS Funcionario, p.entrega AS entrega, p.status_pedido AS StatusPedido, p.valor_total AS ValorTotal, p.tipo_pagamento AS TipoPagamento " + "FROM cad_pedidos AS p ";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public void Excluir(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = pedido.Id;
            comando.Parameters.Add(id);
            conexao.Open();
            //realiza o DELETE
            comando.CommandText = @"DELETE FROM cad_pedidos WHERE id_pedido = @id;";
            //executa o comando no banco de dados
            _ = comando.ExecuteNonQuery();
        }

    }
}
