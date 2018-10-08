using Belatrix.Logger.Entities;
using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Belatrix.Logger.Handlers
{
    public class LogToDB : AbstractLogger
    {
        public override void LogMessage(LoggerEntity logger)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Logger"].ToString());
            SqlCommand cmd = new SqlCommand("ups_InsertLog", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;            
            cmd.Parameters.Add("@pLevel", SqlDbType.NVarChar, 50).Value = logger.Level.ToString();
            cmd.Parameters.Add("@pLogger", SqlDbType.NVarChar, 255).Value = "DB";
            cmd.Parameters.Add("@pMessage", SqlDbType.NVarChar, 4000).Value = logger.Message;
            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally {
                cnx.Close();
            }
        }
    }
}
