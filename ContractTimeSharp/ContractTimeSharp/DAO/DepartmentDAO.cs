using ContractTime.Model;
using ContractTimeSharp.DAO.Factory;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ContractTimeSharp.Utils;

namespace ContractTimeSharp.DAO
{
    class DepartmentDAO : DAO<Department>
    {
        private DAOFactory daoFactory = new FirebirdDAO();
        private static List<Department> departmentList = new List<Department>();
        public void delete(Department e)
        {
            throw new NotImplementedException();
        }


        public List<KeyValuePair> getComboBox()
        {

            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select DEPT_ID, DEPT_NAME || ' ' || Name_firm as dept_name from Depts "+
                "left join Firm on Depts.firm_id = Firm.id_firm order by DEPT_NAME";
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
                    KeyValuePair keyValuePair = new KeyValuePair(row["dept_id"].ToString(), row["dept_name"].ToString());
                    listResult.Add(keyValuePair);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Department getCombo ", e);
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

        public List<Department> getAll()
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select DEPT_ID, DEPT_NAME from Depts order by DEPT_NAME";
            
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    Department department = new Department();
                    department.idDepartment = int.Parse(row["dept_id"].ToString());
                    department.nameDepartment = row["dept_name"].ToString();
                    departmentList.Add(department);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Department getAll ", e);
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

        public Department getById(int id)
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select DEPT_ID, DEPT_NAME from Depts where DEPT_ID = @id_dept;";
            Department department = new Department();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                statment.Parameters.Add("@id_dept",  id);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    department.idDepartment = int.Parse(row["dept_id"].ToString());
                    department.nameDepartment = row["dept_name"].ToString();
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Department getById " + id, e);
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
            return department;
        }

        public Department insert(Department e)
        {
            throw new NotImplementedException();
        }

        public void update(Department e)
        {
            throw new NotImplementedException();
        }
    }
}
