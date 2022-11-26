using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroWinFormsDotNet
{
    internal class Empregado
    {
        public string nomeColaborador;
        public string idGerente;
        public string funcao;
        public string idDepartamento;
        public string dataAdmissao;
        public string salario;
        public string comissao;

        public Empregado(string nomeColaborador, string idGerente, string funcao, string idDepartamento, string dataAdmissao, string salario, string comissao)
        {
            this.nomeColaborador = nomeColaborador;
            this.idGerente = idGerente;
            this.funcao = funcao;
            this.idDepartamento = idDepartamento;
            this.dataAdmissao = dataAdmissao;
            this.salario = salario;
            this.comissao = comissao;
        }
        public bool gravarEmpregado()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "insert into Empregado values (@nomeColaborador, @idGerente, @funcao, @idDepartamento, @dataAdmissao, @salario, @comissao):";
            cmd.Parameters.Add("@nomeColaborador", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@idGerente", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@funcao", System.Data.SqlDbType.VarChar); 
            cmd.Parameters.Add("@idDepartamento", System.Data.SqlDbType.VarChar);//SqlDbType.Int
            cmd.Parameters.Add("@dataAdmissao", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@salario", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@comissao", System.Data.SqlDbType.VarChar);
            cmd.Parameters[0].Value = nomeColaborador;
            cmd.Parameters[1].Value = idGerente;
            cmd.Parameters[2].Value = funcao;
            cmd.Parameters[3].Value = idDepartamento;
            cmd.Parameters[4].Value = dataAdmissao;
            cmd.Parameters[5].Value = salario;
            cmd.Parameters[6].Value = comissao;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
            return true;
        }



    }

    
}
