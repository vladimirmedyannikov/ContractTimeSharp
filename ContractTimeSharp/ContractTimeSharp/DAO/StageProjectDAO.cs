﻿using ContractTime.Model;
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
        public void delete(StageProject stage)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            String sql = "execute procedure delete_stage_project (@idStage);";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                statement = new FbCommand(sql, connection);

                statement.Parameters.Add("@idStage", stage.IdStage);
                int id = Convert.ToInt32(statement.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw new DAOException("Delete Stage "+ stage.IdStage, e);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public List<StageProject> getByDate(DateTime date)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            String sql = "select id_stage, id_project, name_stage, u.id_user, l_name, f_name, p_name, date_begin_plan, e_mail, " +
                "date_end_plan, date_begin_prog, date_end_prog, date_begin_user, date_end_user, " +
                "status_stage, comment_user, id_stage_parent, send_message from stage_project " +
                "left join user_info u on u.id_user = stage_project.id_user where date_begin_plan = @date";
            List<StageProject> stageProjectList = new List<StageProject>();
            try
            {
                connection = daoFactory.getConnection();
                statement = new FbCommand(sql, connection);
                statement.Parameters.Add("@date", date);
                FbDataAdapter da = new FbDataAdapter(statement);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    StageProject stageProject = generateStageProject(row);
                    stageProject.Project = new InvestProjectDAO().getById(stageProject.IdProject);
                    stageProjectList.Add(stageProject);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("GetAll stage project ", e);
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

        public List<StageProject> getAll()
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_stage, id_project, name_stage, u.id_user, l_name, f_name, p_name, date_begin_plan, e_mail, " +
                "date_end_plan, date_begin_prog, date_end_prog, date_begin_user, date_end_user, " +
                "status_stage, comment_user, id_stage_parent, send_message from stage_project " +
                "left join user_info u on u.id_user = stage_project.id_user";
            List<StageProject> stageProjectList = new List<StageProject>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    StageProject stageProject = generateStageProject(row);
                    stageProject.Project = new InvestProjectDAO().getById(stageProject.IdProject);
                    stageProjectList.Add(stageProject);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("GetAll stage project ", e);
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

        public List<StageProject> getByUser(User user)
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_stage, id_project, name_stage, u.id_user, l_name, f_name, p_name, date_begin_plan, e_mail, " +
                "date_end_plan, date_begin_prog, date_end_prog, date_begin_user, date_end_user, " +
                "status_stage, comment_user, id_stage_parent, send_message from stage_project " +
                "left join user_info u on u.id_user = stage_project.id_user where stage_project.id_user = @idUser;";
            List<StageProject> stageProjectList = new List<StageProject>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                statment.Parameters.Add("@idUser", user.Id);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    StageProject stageProject = generateStageProject(row);
                    stageProject.Project = new InvestProjectDAO().getById(stageProject.IdProject);
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

        public StageProject getById(int id)
        {
            throw new NotImplementedException();
        }

        public StageProject insert(StageProject stageProject)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            string sql = @"execute procedure insert_stage_project (@name_stage, @id_user, @date_begin_plan, @date_end_plan, @id_project, @id_stage_parent)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                statement = new FbCommand(sql, connection);
                statement.Parameters.Add("@name_stage", stageProject.NameStage);
                statement.Parameters.Add("@id_user", stageProject.User.Id);
                statement.Parameters.Add("@date_begin_plan", stageProject.DateBeginPlan);
                statement.Parameters.Add("@date_end_plan", stageProject.DateEndPlan);
                statement.Parameters.Add("@id_project", stageProject.IdProject);
                statement.Parameters.Add("@id_stage_parent", stageProject.IdParentStage);
                int id = Convert.ToInt32(statement.ExecuteScalar());
                if (id != 0) stageProject.IdStage = id;
            }
            catch (Exception e)
            {
                throw new DAOException("Insert Stage Project", e);
            }
            finally
            {
                connection.Close();
            }
            return stageProject;
        }

        public void update(StageProject stageProject)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            FbTransaction transaction = null;
            string sql = @"execute procedure update_stage_project_all(@id_stage ,@name_stage, @id_user, @date_begin_plan, @date_end_plan, @status_stage, @date_begin_user, @date_end_user, @comment_user)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                transaction = connection.BeginTransaction();
                statement = new FbCommand(sql, connection,transaction);
                statement.Parameters.Add("@id_stage", stageProject.IdStage);
                statement.Parameters.Add("@name_stage", stageProject.NameStage);
                statement.Parameters.Add("@id_user", stageProject.User.Id);
                statement.Parameters.Add("@date_begin_plan", stageProject.DateBeginPlan);
                statement.Parameters.Add("@date_end_plan", stageProject.DateEndPlan);            
                statement.Parameters.Add("@status_stage", stageProject.StatusStage);
                if (stageProject.DateBeginUser.CompareTo(new DateTime(1, 1, 1)) == 0)
                {
                    statement.Parameters.Add("@date_begin_user", null);
                }
                else { statement.Parameters.Add("@date_begin_user", stageProject.DateBeginUser); }
                if (stageProject.DateEndUser.CompareTo(new DateTime(1, 1, 1)) == 0)
                {
                    statement.Parameters.Add("@date_end_user", null);
                }
                else
                { statement.Parameters.Add("@date_end_user", stageProject.DateEndUser); }

                statement.Parameters.Add("@comment_user", stageProject.CommentUser);
                statement.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw new DAOException("Insert Stage Project", e);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<StageProject> getSubStageProject(int idProject)
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_stage, id_project, name_stage, u.id_user, l_name, f_name, p_name, date_begin_plan, e_mail, " +
                "date_end_plan, date_begin_prog, date_end_prog, date_begin_user, date_end_user, " +
                "status_stage, comment_user, id_stage_parent, send_message from stage_project " +
                "left join user_info u on u.id_user = stage_project.id_user where stage_project.id_stage_parent <> 0 and id_project = @idProject order by id_inner_index;";
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
                    stageProject.Project = new InvestProjectDAO().getById(stageProject.IdProject);
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
            String sql = "select id_stage, id_project, name_stage, u.id_user, l_name, f_name, p_name, date_begin_plan, e_mail, " +
                "date_end_plan, date_begin_prog, date_end_prog, date_begin_user, date_end_user, " +
                "status_stage, comment_user, id_stage_parent, send_message from stage_project " +
                "left join user_info u on u.id_user = stage_project.id_user where id_project = @idProject and stage_project.id_stage_parent = 0 order by id_inner_index;";
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
                    stageProject.Project = new InvestProjectDAO().getById(stageProject.IdProject);
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
            if (row["id_user"].ToString() != "") {
                user.Id = Convert.ToInt32(row["id_user"].ToString());
                user.FirstName = row["f_name"].ToString();
                user.SecondName = row["l_name"].ToString();
                user.ThirdName = row["p_name"].ToString();
                user.Email = row["e_mail"].ToString();
                
            }
            stageProject.User = user;
            DateTime dateBeginPlan;
            DateTime.TryParse(row["date_begin_plan"].ToString(), out dateBeginPlan);
            stageProject.DateBeginPlan = dateBeginPlan;

            DateTime dateEndPlan;
            DateTime.TryParse(row["date_end_plan"].ToString(),out dateEndPlan);
            stageProject.DateEndPlan = dateEndPlan;

            DateTime dateSend;
            DateTime.TryParse(row["send_message"].ToString(), out dateSend);
            stageProject.DateSend = dateSend;

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

        internal void sendMessage(List<StageProject> listSend)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            FbTransaction transaction = null;
            string sql = @"update stage_project set send_message = @date where id_stage = @id_stage ";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                foreach (StageProject stage in listSend)
                {
                    transaction = connection.BeginTransaction();
                    statement = new FbCommand(sql, connection, transaction);
                    statement.Parameters.Add("@id_stage", stage.IdStage);
                    statement.Parameters.Add("@date", DateTime.Now.ToShortDateString());
                    statement.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw new DAOException("Update send message Stage Project", e);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
