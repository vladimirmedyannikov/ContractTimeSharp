using ContractTime.Model;
using ContractTimeSharp.DAO.Factory;
using ContractTimeSharp.Utils;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ContractTimeSharp.DAO
{
    class FirmDAO : DAO<Firm>
    {
        private DAOFactory daoFactory = new FirebirdDAO();
        private static List<Firm> departmentList = new List<Firm>();
        public List<KeyValuePair> getComboBox()
        {

            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_firm, name_firm from Firm";
            List<KeyValuePair> listResult = new List<KeyValuePair>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    KeyValuePair keyValuePair = new KeyValuePair(row["id_firm"].ToString(), row["name_firm"].ToString());
                    listResult.Add(keyValuePair);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Firm getCombo ", e);
            }
            finally
            {
                try
                {
                    if (connection != null) connection.Close();
                }
                catch (System.Data.DataException e)
                {

                }
            }
            return listResult;
        }

        public void delete(Firm e)
        {
            throw new NotImplementedException();
        }

        public List<Firm> getAll()
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_firm, name_firm from Firm order by name_firm";

            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    Firm firm = new Firm();
                    firm.IdFirm = int.Parse(row["id_firm"].ToString());
                    firm.NameFirm = row["name_firm"].ToString();
                    departmentList.Add(firm);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Firm getAll ", e);
            }
            finally
            {
                try
                {
                    if (connection != null) connection.Close();
                }
                catch (System.Data.DataException e)
                {

                }
            }
            return departmentList;
        }

        public Firm getById(int id)
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_firm, name_firm from Firm where id_firm = @id_firm;";
            Firm firm = new Firm();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                statment.Parameters.Add("@id_firm", id);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    firm.IdFirm = int.Parse(row["id_firm"].ToString());
                    firm.NameFirm = row["name_firm"].ToString();
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Firm getById " + id, e);
            }
            finally
            {
                try
                {
                    if (connection != null) connection.Close();
                }
                catch (System.Data.DataException e)
                {

                }
            }
            return firm;
        }

        public Firm insert(Firm e)
        {
            throw new NotImplementedException();
        }

        public void update(Firm e)
        {
            throw new NotImplementedException();
        }
    }
}
