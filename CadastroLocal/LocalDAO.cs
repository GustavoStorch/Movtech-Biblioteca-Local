using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLocal
{
    internal class LocalDAO
    {
        private SqlConnection Connection { get; }

        public LocalDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(LocalModel local)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibLocal(descricaoLocal) VALUES(@descricaoLocal)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@descricaoLocal", local.NomeLocal));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Editar(LocalModel local)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibLocal SET descricaoLocal = @descricaoLocal WHERE codLocal = @codLocal");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codLocal", local.CodLocal);
                    command.Parameters.Add(new SqlParameter("@descricaoLocal", local.NomeLocal));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(LocalModel local, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibLocal WHERE codLocal = @codLocal");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codLocal", local.CodLocal));
                command.ExecuteNonQuery();
            }
        }

        public int VerificaRegistros(LocalModel local)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codLocal) FROM mvtBibLocal WHERE codLocal = @codLocal");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codLocal", local.CodLocal);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }

        public List<LocalModel> GetLocais() 
        {
            List<LocalModel> locais = new List<LocalModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT LOC.codLocal, LOC.descricaoLocal FROM mvtBibLocal LOC ORDER BY LOC.codLocal");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        locais.Add(PopulateDr(dr));
                    }
                }
            }
            return locais;
        }

        public LocalModel PopulateDr(SqlDataReader dr)
        {
            string codLocal = "";
            string nomeLocal = "";

            if (DBNull.Value != dr["codLocal"])
            {
                codLocal = dr["codLocal"] + "";
            }
            if (DBNull.Value != dr["descricaoLocal"])
            {
                nomeLocal = dr["descricaoLocal"] + "";
            }
            return new LocalModel()
            {
                CodLocal = codLocal,
                NomeLocal = nomeLocal
            };
        }
    }
}
