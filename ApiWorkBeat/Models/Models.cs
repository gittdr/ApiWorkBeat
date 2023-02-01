using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkBeat.Models
{
    public class Models
    {
        public DataTable GetIdPersona(int idPersona)
        {
            DataTable dataTable = new DataTable();
            string cadena2 = @"Data source=DESKTOP-DILD9U7\SQLEXPRESS; Initial Catalog=DBCARGA; User ID=jdev; Password=tdr123;Trusted_Connection=false;MultipleActiveResultSets=true";
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("GetIdPersona", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;
                    selectCommand.Parameters.AddWithValue("@idPersona", (object)idPersona);
                    selectCommand.ExecuteNonQuery();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        try
                        {
                            //selectCommand.Connection.Open();
                            sqlDataAdapter.Fill(dataTable);
                        }
                        catch (SqlException ex)
                        {
                            connection.Close();
                            string message = ex.Message;
                        }
                    }
                }
            }
            return dataTable;
        }
        public void InsertIdPersona(int idTenant,
        int idPersona,
        string nombre,
        string Puesto,
        string RFC,
        string CURP,
        string NumEmpleado,
        string RegistroPatronal,
        string apellidoPat,
        string apellidoMat,
        string fechaIngreso,
        decimal SalarioDiarioIntegrado,
        decimal SalarioDiario,
        string SGUID,
        string GUIDExpediente,
        string email,
        string pass,
        string failedAttempts,
        string blockedUntil)
        {
            string cadena2 = @"Data source=DESKTOP-DILD9U7\SQLEXPRESS; Initial Catalog=DBCARGA; User ID=jdev; Password=tdr123;Trusted_Connection=false;MultipleActiveResultSets=true";
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(cadena2))
            {

                using (SqlCommand selectCommand = new SqlCommand("sp_InsertIdPersona", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;
                    selectCommand.Parameters.AddWithValue("@idTenant", (object)idTenant == null ? "" : (object)idTenant);
                    selectCommand.Parameters.AddWithValue("@idPersona", (object)idPersona == null ? "" : (object)idPersona);
                    selectCommand.Parameters.AddWithValue("@nombre", (object)nombre == null ? "" : (object)nombre);
                    selectCommand.Parameters.AddWithValue("@Puesto", (object)Puesto == null ? "" : (object)Puesto);
                    selectCommand.Parameters.AddWithValue("@RFC", (object)RFC == null ? "" : (object)RFC);
                    selectCommand.Parameters.AddWithValue("@CURP", (object)CURP == null ? "" : (object)CURP);
                    selectCommand.Parameters.AddWithValue("@NumEmpleado", (object)NumEmpleado == null ? "" : (object)NumEmpleado);
                    selectCommand.Parameters.AddWithValue("@RegistroPatronal", (object)RegistroPatronal == null ? "" : (object)RegistroPatronal);
                    selectCommand.Parameters.AddWithValue("@apellidoPat", (object)apellidoPat == null ? "" : (object)apellidoPat);
                    selectCommand.Parameters.AddWithValue("@apellidoMat", (object)apellidoMat == null ? "" : (object)apellidoMat);
                    selectCommand.Parameters.AddWithValue("@fechaIngreso", (object)fechaIngreso == null ? "" : (object)fechaIngreso);
                    selectCommand.Parameters.AddWithValue("@SalarioDiarioIntegrado", (object)SalarioDiarioIntegrado == null ? "" : (object)SalarioDiarioIntegrado);
                    selectCommand.Parameters.AddWithValue("@SalarioDiario", (object)SalarioDiario == null ? "" : (object)SalarioDiario);
                    selectCommand.Parameters.AddWithValue("@SGUID", (object)SGUID == null ? "" : (object)SGUID);
                    selectCommand.Parameters.AddWithValue("@GUIDExpediente", (object)GUIDExpediente == null ? "" : (object)GUIDExpediente);
                    selectCommand.Parameters.AddWithValue("@email", (object)email == null ? "" : (object)email);
                    selectCommand.Parameters.AddWithValue("@pass", (object)pass == null ? "" : (object)pass);
                    selectCommand.Parameters.AddWithValue("@failedAttempts", (object)failedAttempts == null ? "" : (object)failedAttempts);
                    selectCommand.Parameters.AddWithValue("@blockedUntil", (object)blockedUntil == null ? "" : (object)blockedUntil);

                    try
                    {
                        connection.Open();
                        selectCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        }
        public void InsertRazonSocial(int idPersona,int idRazonSocial, string nombreR, string idEmpleado, int IdPuesto, int idPosicion)
        {
            string cadena2 = @"Data source=DESKTOP-DILD9U7\SQLEXPRESS; Initial Catalog=DBCARGA; User ID=jdev; Password=tdr123;Trusted_Connection=false;MultipleActiveResultSets=true";
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(cadena2))
            {

                using (SqlCommand selectCommand = new SqlCommand("sp_InsertRazonSocial", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;
                    selectCommand.Parameters.AddWithValue("@idPersona", (object)idPersona == null ? 0 : (object)idPersona);
                    selectCommand.Parameters.AddWithValue("@idRazonSocial", (object)idRazonSocial == null ? 0 : (object)idRazonSocial);
                    selectCommand.Parameters.AddWithValue("@nombreR", (object)nombreR == null ? "" : (object)nombreR);
                    selectCommand.Parameters.AddWithValue("@idEmpleado", (object)idEmpleado == null ? "" : (object)idEmpleado);
                    selectCommand.Parameters.AddWithValue("@IdPuesto", (object)IdPuesto == null ? 0 : (object)IdPuesto);
                    selectCommand.Parameters.AddWithValue("@idPosicion", (object)idPosicion == null ? 0 : (object)idPosicion);

                    try
                    {
                        connection.Open();
                        selectCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        }
    }
}
