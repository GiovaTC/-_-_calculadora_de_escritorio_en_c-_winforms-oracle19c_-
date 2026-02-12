using Oracle.ManagedDataAccess.Client;
using calculadora_oracle.Model;

namespace calculadora_oracle.Data
{
    public class OperacionDAO
    {
        private readonly string cadena =
            "User Id=system;Password=Tapiero123;Data Source=localhost:1521/orcl";

        public void GuardarOperacion(Operacion op)
        {
            using (OracleConnection cn = new OracleConnection(cadena))
            {
                cn.Open();

                OracleCommand cmd = new OracleCommand(
                    "SP_GUARDAR_OPERACION", cn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("P_OP1", op.Operando1);
                cmd.Parameters.Add("P_OP2", op.Operando2);
                cmd.Parameters.Add("P_OPERACION", op.Tipo);
                cmd.Parameters.Add("P_RESULTADO", op.Resultado);

                cmd.ExecuteNonQuery();
            }
        }
    }   
}   
