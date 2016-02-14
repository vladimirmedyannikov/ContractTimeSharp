using ContractTime.Model;
using ContractTimeSharp.DAO.Factory;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ContractTimeSharp.Utils;
using System.Windows.Forms;

namespace ContractTimeSharp.DAO
{
    class DepartmentDAO : DAO<Department>
    {
        private DAOFactory daoFactory = new FirebirdDAO();
        private static List<Department> departmentList = new List<Department>();
        public void delete(Department department)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            String sql = "execute procedure delete_dept(@id_dept);";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                statement = new FbCommand(sql, connection);
                statement.Parameters.Add("@id_dept", department.idDepartment);

                int result = Convert.ToInt32(statement.ExecuteScalar());
                if (result == 0)
                {
                    MessageBox.Show("Удалить подразделение нельзя. Участвует в процессе прогнозирования");
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Departmnet delete ", e);
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
        }


        public List<KeyValuePair> getComboBox()
        {

            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select DEPT_ID, DEPT_NAME || ' ' || Name_firm as dept_name from Depts "+
                "left join Firm on Depts.firm_id = Firm.id_firm where date_dismiss >= cast('Now' as date) order by Depts.firm_id, DEPT_NAME";
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

        public List<KeyValuePair> getComboBox(int idFirm)
        {

            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select DEPT_ID, DEPT_NAME || ' ' || Name_firm as dept_name from Depts " +
                "left join Firm on Depts.firm_id = Firm.id_firm where depts.firm_id = @id_firm order by DEPT_NAME";
            List<KeyValuePair> listResult = new List<KeyValuePair>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                statment.Parameters.Add("@id_firm", idFirm);
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
            String sql = "select Depts.DEPT_ID, Depts.DEPT_NAME, Firm.id_firm, name_firm, coalesce(Depts.parent_dept, 0) parent_dept, D2.dept_name name2 from Depts " +
                " left join Firm on Firm.id_firm = Depts.firm_id "+
                " left join Depts D2 on D2.dept_id = Depts.parent_dept order by Name_firm, Depts.DEPT_NAME";
            
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    Department department = new Department();
                    department.idDepartment = int.Parse(row["dept_id"].ToString());
                    department.nameDepartment = row["dept_name"].ToString();
                    Firm firm = new Firm();
                    firm.IdFirm = Convert.ToInt32(row["id_firm"].ToString());
                    firm.NameFirm = row["name_firm"].ToString();
                    department.firmDepartment = firm;
                    Department parent = new Department();
                    parent.idDepartment = Convert.ToInt32(row["parent_dept"].ToString());
                    parent.nameDepartment = row["name2"].ToString();
                    department.parentDepartment = parent; 
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

        public Department insert(Department department)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            FbTransaction transaction = null;
            string sql = "execute procedure insert_dept(@dept_name, @parent_dept, @firm_id)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                transaction = connection.BeginTransaction();
                statement = new FbCommand(sql, connection,transaction);

                statement.Parameters.Add("@dept_name", department.nameDepartment);
                statement.Parameters.Add("@firm_id", department.firmDepartment.IdFirm);
                if (department.parentDepartment != null)
                {
                    statement.Parameters.Add("@parent_dept", department.parentDepartment.idDepartment);
                }
                else
                {
                    statement.Parameters.Add("@parent_dept", null);
                }

                int id = Convert.ToInt32(statement.ExecuteScalar());
                transaction.Commit();
                if (id != 0)
                {
                    department.idDepartment = (int)id;
                }

            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw new DAOException("Insert Department error ", e);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            return department;
        }

        public void update(Department department)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            string sql = "execute procedure update_dept(@id_dept,@dept_name, @parent_dept, @firm_id)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                //transaction = connection.BeginTransaction();
                statement = new FbCommand(sql, connection);

                statement.Parameters.Add("@id_dept", department.idDepartment);
                statement.Parameters.Add("@dept_name", department.nameDepartment);
                statement.Parameters.Add("@parent_dept", department.parentDepartment.idDepartment);
                statement.Parameters.Add("@firm_id", department.firmDepartment.IdFirm);

                statement.ExecuteNonQuery();
                //transaction.Commit();
            }
            catch (Exception e)
            {
                //transaction.Rollback();
                throw new DAOException("Update Department error ", e);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
    }
}
