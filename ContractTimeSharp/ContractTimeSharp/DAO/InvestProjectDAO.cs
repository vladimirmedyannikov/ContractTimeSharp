using ContractTime.Model;
using ContractTimeSharp.DAO.Factory;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ContractTimeSharp.DAO
{
    class InvestProjectDAO : DAO<InvestProject>
    {
        private DAOFactory daoFactory = new FirebirdDAO();
        public void delete(InvestProject e)
        {
            throw new NotImplementedException();
        }

        public List<InvestProject> getAll()
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select invest_project.*, l_name, f_name, p_name, dept_name from invest_project " +
                "left join depts on depts.dept_id = invest_project.id_dept " +
                "left join user_info u on u.id_user = invest_project.id_user";
            List<InvestProject> investProjectList = new List<InvestProject>();

            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    InvestProject investProject = new InvestProject();
                    investProject.idProject = Convert.ToInt32(row["id_project"].ToString());

                    Department department = new Department();
                    department.nameDepartment = row["dept_name"].ToString();
                    department.idDepartment = Convert.ToInt32(row["id_dept"].ToString());
                    investProject.department = department;

                    investProject.aboutProject = row["about_project"].ToString();
                    investProject.dateBegin = DateTime.Parse(row["date_begin_plan"].ToString());

                    investProject.dateEnd = DateTime.Parse(row["date_end_plan"].ToString());
                    investProject.dateBeginProg = DateTime.Parse(row["date_begin_prog"].ToString());
                    investProject.dateEndProg = DateTime.Parse(row["date_end_prog"].ToString());
                    investProject.numberProject = row["number_project"].ToString();

                    User user = new User();
                    user.FirstName = row["f_name"].ToString();
                    user.SecondName = row["l_name"].ToString();
                    user.ThirdName = row["p_name"].ToString();
                    user.Id = Convert.ToInt32(row["id_user"].ToString());
             
                    investProject.user = user;
                    //investProject.setUser(userDAO.getById(resultSet.getInt("id_user")));
                    investProject.nameProject = row["name_project"].ToString();
                    investProjectList.Add(investProject);
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
            return investProjectList;
        }

        public InvestProject getById(int id)
        {
            throw new NotImplementedException();
        }

        public InvestProject insert(InvestProject investProject)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            String sql = "execute procedure insert_invest_project (@name, @number, @idDep, @idUser, @dateBegin, @dateEnd, @about);";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                statement = new FbCommand(sql, connection);

                statement.Parameters.Add("@name", investProject.nameProject);
                statement.Parameters.Add("@number", investProject.numberProject);
                statement.Parameters.Add("@idDep", investProject.department.idDepartment);
                statement.Parameters.Add("@idUser", investProject.user.Id);
                statement.Parameters.Add("@dateBegin", investProject.dateBegin);
                statement.Parameters.Add("@dateEnd", investProject.dateEnd);
                statement.Parameters.Add("@about", investProject.aboutProject);
                int id = Convert.ToInt32(statement.ExecuteScalar());


                if (id != 0)
                {
                    investProject.idProject = (int)id;
                }
                
            }
            catch (Exception e)
            {
                throw new DAOException("Insert Invest Project", e);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            return investProject;
        }

        /// <summary>
        /// UPDATE_INVEST_PROJECT_ALL(
        ///ID_PROJECT integer,
        ///NAME_PROJECT NAME_PROJECT_DOMAIN,
        ///NUMBER_PROJECT NUMBER_PROJECT,
        ///ID_DEPT integer,
        ///ID_USER integer,
        ///DATE_BEGIN_PLAN date,
        ///DATE_END_PLAN date,
        ///DATE_BEGIN_PROG date,
        ///DATE_END_PROG date,
        ///ABOUT_PROJECT ABOUT)
        /// </summary>
        /// <param name="NAME_PROJECT"></param>
        /// <param name="NUMBER_PROJECT"></param>
        /// <param name="integer"></param>
        /// <param name="integer"></param>
        /// <param name="date"></param>
        /// <param name="date"></param>
        /// <param name="date"></param>
        /// <param name="date"></param>
        /// <param name="ABOUT"></param>
        
        public void update(InvestProject investProject)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            FbTransaction transaction = null;
            string sql = @"execute procedure update_invest_project_all (@id_project, @name_project, @number_project, @id_dept, @id_user, 
                         @date_begin, @date_end, @date_begin_prog, @date_end_prog, @about)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                transaction = connection.BeginTransaction();
                statement = new FbCommand(sql, connection, transaction);
                statement.Parameters.Add("@id_project", investProject.idProject);
                statement.Parameters.Add("@name_project", investProject.nameProject);
                statement.Parameters.Add("@number_project", investProject.numberProject);
                statement.Parameters.Add("@id_dept", investProject.department.idDepartment);
                statement.Parameters.Add("id_user", investProject.user.Id);
                statement.Parameters.Add("@date_begin", investProject.dateBegin);
                statement.Parameters.Add("@date_end", investProject.dateEnd);
                statement.Parameters.Add("date_begin_prog", investProject.dateBeginProg);
                statement.Parameters.Add("@date_end_prog", investProject.dateEndProg);
                statement.Parameters.Add("@about", investProject.aboutProject);
                statement.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
