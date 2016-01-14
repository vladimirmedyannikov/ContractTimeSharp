using ContractTime.Model;
using ContractTimeSharp.DAO.Factory;
using ContractTimeSharp.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ContractTimeSharp.DAO
{
    class StageProjectDAO : DAO<StageProject>
    {
        private DAOFactory daoFactory = new FirebirdDAO();
        public void delete(StageProject e)
        {
            throw new NotImplementedException();
        }

        public List<StageProject> getAll()
        {
            throw new NotImplementedException();
        }

        public StageProject getById(int id)
        {
            throw new NotImplementedException();
        }

        public StageProject insert(StageProject e)
        {
            throw new NotImplementedException();
        }

        public void update(StageProject e)
        {
            throw new NotImplementedException();
        }

        public List<StageProject> getSubStageProject(int idProject)
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_stage, id_project, name_stage, u.id_user, l_name, f_name, p_name, date_begin_plan, " +
                "date_end_plan, date_begin_prog, date_end_prog, date_begin_user, date_end_user, " +
                "status_stage, comment_user, id_stage_parent from stage_project " +
                "inner join user_info u on u.id_user = stage_project.id_user where stage_project.id_stage_parent <> 0 and id_project = @idProject;";
            List<StageProject> stageProjectList = new List<StageProject>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                statment.Parameters.Add("@idProject", idProject);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    StageProject stageProject = generateStageProject(row);
                    stageProjectList.Add(stageProject);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("SubStageProject ", e);
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
            return stageProjectList;

        }

        public List<StageProject> getByProject(int idProject)
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_stage, id_project, name_stage, u.id_user, l_name, f_name, p_name, date_begin_plan, " +
                "date_end_plan, date_begin_prog, date_end_prog, date_begin_user, date_end_user, " +
                "status_stage, comment_user, id_stage_parent from stage_project " +
                "inner join user_info u on u.id_user = stage_project.id_user where id_project = @idProject and stage_project.id_stage_parent = 0;";
            List<StageProject> stageProjectList = new List<StageProject>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                statment.Parameters.Add("@idProject", idProject);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                List<StageProject> subStage = getSubStageProject(idProject);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    StageProject stageProject = generateStageProject(row);
                    stageProject.SubStage = subStage.Where(s=>s.IdParentStage == stageProject.IdStage).ToList();
                    stageProjectList.Add(stageProject);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Get stage project ", e);
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
            return stageProjectList;
        }

        private StageProject generateStageProject(DataRow row)
        {
            StageProject stageProject = new StageProject();
            stageProject.IdStage = Convert.ToInt32(row["id_stage"].ToString());
            stageProject.IdProject = Convert.ToInt32(row["id_project"].ToString());
            stageProject.NameStage = row["name_stage"].ToString();

            User user = new User();
            user.Id = Convert.ToInt32(row["id_user"].ToString());
            user.FirstName = row["f_name"].ToString();
            user.SecondName = row["l_name"].ToString();
            user.ThirdName = row["p_name"].ToString();

            stageProject.User = user;
            DateTime dateBeginPlan;
            DateTime.TryParse(row["date_begin_plan"].ToString(), out dateBeginPlan);
            stageProject.DateBeginPlan = dateBeginPlan;

            DateTime dateEndPlan;
            DateTime.TryParse(row["date_end_plan"].ToString(),out dateEndPlan);
            stageProject.DateEndPlan = dateEndPlan;

            if (row["date_begin_user"] != null)
            {
                DateTime dateBeginProg;
                DateTime.TryParse(row["date_begin_prog"].ToString(), out dateBeginProg);
                stageProject.DateBeginProg = dateBeginProg;

                DateTime dateEndProg;
                DateTime.TryParse(row["date_end_prog"].ToString(),out dateEndProg);
                stageProject.DateEndProg = dateEndProg;

            
                DateTime dateBeginUser;
                DateTime.TryParse(row["date_begin_user"].ToString(), out dateBeginUser);
                stageProject.DateBeginUser = dateBeginUser;

                DateTime dateEndUser;
                DateTime.TryParse(row["date_end_user"].ToString(), out dateEndUser);
                stageProject.DateEndUser = dateEndUser;
            }


            stageProject.StatusStage = Convert.ToInt32(row["status_stage"].ToString());
            stageProject.CommentUser = row["comment_user"].ToString();
            stageProject.IdParentStage = Convert.ToInt32(row["id_stage_parent"].ToString());
            return stageProject;
        }
    }
}
