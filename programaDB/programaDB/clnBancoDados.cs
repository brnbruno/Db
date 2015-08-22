/*
 * Created by SharpDevelop.
 * User: bruno
 * Date: 22/08/2015
 * Time: 06:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace programaDB
{
	/// <summary>
	/// Description of clnBancoDados.
	/// </summary>
	public class clnBancoDados
	{
		 public OracleConnection AbreBanco()
        {
            string StringConexao = "Data Source=(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER==xe)));"
            + "User Id=pizzaria;Password=123456 DBA Privilege=SYSDBA;;";  //String de conexao oracle;
            try
            {
                OracleConnection conn = new OracleConnection(StringConexao);
                conn.Open();
                return conn;

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void ExecutarComando(string strQuery)
        {
            OracleConnection conn;
            conn = AbreBanco();
            try
            {
                OracleCommand sqlComm = new OracleCommand(strQuery, conn);
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                FecharBanco(conn);
            }

        }
        public void FecharBanco(OracleConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public OracleDataReader RetornaDataReader(string strQuery)
        {
            try
            {
                OracleDataReader dr;
                OracleCommand sqlComando = new OracleCommand(strQuery, AbreBanco());
                dr = sqlComando.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public DataSet RetornaDataSet(string strQuery)
        {
            OracleConnection conn;
            conn = AbreBanco();
            try
            {
                DataSet ds = new DataSet();
                OracleCommand cmdComando = new OracleCommand(strQuery, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmdComando);
                da.Fill(ds);
                return ds;

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                FecharBanco(conn);
            }

        }
           
    }
}