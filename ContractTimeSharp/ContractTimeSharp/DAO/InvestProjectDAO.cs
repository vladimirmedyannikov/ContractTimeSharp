using ContractTime.Model;
using ContractTimeSharp.DAO.Factory;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
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
                connection = daoFactory.getConnection();
                statement = new FbCommand(sql, connection);
                statement.Parameters.Add("@id_dept", FbDbType.Integer, id);

                statement.Parameters.Add("@name",FbDbType.Text, investProject.getNameProject());
                statement.Parameters.Add("@number", investProject.getNumberProject());
                statement.Parameters.Add("@idDep", investProject.getDepartment().getIdDepartment());
                statement.Parameters.Add("@idUser", investProject.getUser().getId());
                statement.Parameters.Add("@dateBegin", new java.sql.Date(investProject.getDateBegin().getTime()));
                statement.Parameters.Add("@dateEnd", new java.sql.Date(investProject.getDateEnd().getTime()));
                statement.Parameters.Add("@about", investProject.getAboutProject());
                statement.execute();
                resultSet = statement.getGeneratedKeys();
                resultSet.next();
                if (resultSet != null)
                {
                    investProject.setIdProject(resultSet.getInt("id_project"));
                }

            }
            catch (Exception e)
            {
                throw new DAOException("Insert Invest Project", e);
            }
            finally
            {
                try
                {
                    if (resultSet != null) resultSet.close();
                    if (statement != null) statement.close();
                    if (connection != null) connection.close();
                }
                catch (SQLException e)
                {
                    //throw new DAOException("InvestProject getAll SQL",e);
                }
            }
            return investProject;
        }

        public void update(InvestProject e)
        {
            throw new NotImplementedException();
        }
    }
}
