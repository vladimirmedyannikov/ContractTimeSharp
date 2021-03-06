﻿using ContractTime.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContractTimeSharp.DAO.Factory;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using ContractTimeSharp.Utils;

namespace ContractTimeSharp.DAO
{
    class UserDAO : DAO<User>
    {
        private DAOFactory daoFactory = new FirebirdDAO();
        public void delete(User e)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair> getUserComboBox()
        {
            List<KeyValuePair> listBox = new List<KeyValuePair>();
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "select id_user, l_name || ' ' || f_name || ' ' || p_name || ' - ' || dept_name as fio from user_info u "+
                "left join depts on depts.dept_id = u.id_dept where date_out > cast('NOW' as date) order by fio";
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    KeyValuePair keyValuePair = new KeyValuePair(row["id_user"].ToString(), row["fio"].ToString());
                    listBox.Add(keyValuePair);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("User KeyValuePair ", e);
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
            return listBox;
        }

        public List<User> getAll()
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "Select id_user, id_dept, u.date_in, u.date_out, l_name, f_name, p_name, login, e_mail, sent_message, sent_date, dept_name, dept_id, type_user, post, password from user_info u " +
                " left join depts on depts.dept_id = u.id_dept order by f_name, l_name, p_name";
            List<User> userList = new List<User>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(row["id_user"].ToString());
                    user.FirstName = row["f_name"].ToString();
                    user.SecondName = row["l_name"].ToString();
                    user.ThirdName = row["p_name"].ToString();
                    user.TypeUser = Convert.ToInt32(row["type_user"].ToString());
                    user.Login = row["login"].ToString();
                    user.Email = row["e_mail"].ToString();
                    user.HashPass = row["e_mail"].ToString();
                    user.Appointment = row["post"].ToString();
                    user.Password = row["password"].ToString();

                    Department department = new Department();
                    department.idDepartment = Convert.ToInt32(row["id_dept"].ToString());
                    department.nameDepartment = row["dept_name"].ToString();
                    user.Department = department;
                    userList.Add(user);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("User getAll ", e);
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
            return userList;
        }

        public List<User> getUsersResponsible(AdvanceUtil.stageStatus status)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            string sql = "";
            if (status == AdvanceUtil.stageStatus.ALL)
            {
                sql = "Select distinct u.id_user, u.id_dept, u.date_in, u.date_out, l_name, f_name, p_name, login, e_mail, sent_message, sent_date, dept_name, dept_id, type_user, post from user_info u " +
                    " left join depts on depts.dept_id = u.id_dept " +
                    " right join stage_project sp on sp.id_user = u.id_user";
            }
            else {
                sql = "Select distinct u.id_user, u.id_dept, u.date_in, u.date_out, l_name, f_name, p_name, login, e_mail, sent_message, sent_date, dept_name, dept_id, type_user, post from user_info u " +
                    " left join depts on depts.dept_id = u.id_dept " +
                    " inner join stage_project sp on sp.id_user = u.id_user and sp.status_stage = @status";
            }
            // " where id_user = @id_user";
            List<User> userList = new List<User>();
            try
            {
                connection = daoFactory.getConnection();
                statement = new FbCommand(sql, connection);
                if (status != AdvanceUtil.stageStatus.ALL)
                {
                    statement.Parameters.Add("@status", (int)status);
                }
                FbDataAdapter da = new FbDataAdapter(statement);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(row["id_user"].ToString());
                    user.FirstName = row["f_name"].ToString();
                    user.SecondName = row["l_name"].ToString();
                    user.ThirdName = row["p_name"].ToString();
                    user.TypeUser = Convert.ToInt32(row["type_user"].ToString());
                    user.Login = row["login"].ToString();
                    user.Email = row["e_mail"].ToString();
                    user.HashPass = row["e_mail"].ToString();
                    user.Appointment = row["post"].ToString();

                    Department department = new Department();
                    department.idDepartment = Convert.ToInt32(row["id_dept"].ToString());
                    department.nameDepartment = row["dept_name"].ToString();
                    user.Department = department;
                    userList.Add(user);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("User getResponsible ", e);
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
            return userList;
        }

        public User getById(int id)
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "Select id_user, id_dept, u.date_in, u.date_out, l_name, f_name, p_name, login, e_mail, sent_message, sent_date, dept_name, dept_id, type_user, post from user_info u " +
                " left join depts on depts.dept_id = u.id_dept where id_user = @id_user";
            User user = null;
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                statment.Parameters.Add("@id_user", id);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    user = new User();
                    user.Id = Convert.ToInt32(row["id_user"].ToString());
                    user.FirstName = row["f_name"].ToString();
                    user.SecondName = row["l_name"].ToString();
                    user.ThirdName = row["p_name"].ToString();
                    user.TypeUser = Convert.ToInt32(row["type_user"].ToString());
                    user.Login = row["login"].ToString();
                    user.Email = row["e_mail"].ToString();
                    user.HashPass = row["e_mail"].ToString();
                    user.Appointment = row["post"].ToString();

                    Department department = new Department();
                    department.idDepartment = Convert.ToInt32(row["dept_id"].ToString());
                    department.nameDepartment = row["dept_name"].ToString();
                    user.Department = department;
                }
            }
            catch (Exception e)
            {
                throw new DAOException("User getById " + id, e);
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
            return user;
        }

        public User insert(User user)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            FbTransaction transaction = null;
            string sql = "execute procedure insert_user(@first_name, @second_name, @third_name, @app, @id_dept, @type, @login, @pass, @e_mail, @hash_pass)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                transaction = connection.BeginTransaction();
                statement = new FbCommand(sql, connection);

                statement.Parameters.Add("@first_name", user.FirstName);
                statement.Parameters.Add("@second_name", user.SecondName);
                statement.Parameters.Add("@third_name", user.ThirdName);
                statement.Parameters.Add("@app", user.Appointment);
                statement.Parameters.Add("@id_dept", user.Department.idDepartment);
                statement.Parameters.Add("@type", user.TypeUser);
                statement.Parameters.Add("@login", user.Login);
                statement.Parameters.Add("@pass", user.Password);
                statement.Parameters.Add("@e_mail", user.Email);
                statement.Parameters.Add("@hash_pass", user.HashPass);

                int id = Convert.ToInt32(statement.ExecuteScalar());
                transaction.Commit();
                if (id != 0)
                {
                    user.Id = (int)id;
                }

            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw new DAOException("Insert User error ", e);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            return user;
        }

        public void update(User user)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            FbTransaction transaction = null;
            string sql = "execute procedure update_user_all(@id_user,@first_name, @second_name, @third_name, @app, @id_dept, @type, @login, @pass, @e_mail, @hash_pass)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                //transaction = connection.BeginTransaction();
                statement = new FbCommand(sql, connection);

                statement.Parameters.Add("@id_user", user.Id);
                statement.Parameters.Add("@first_name", user.FirstName);
                statement.Parameters.Add("@second_name", user.SecondName);
                statement.Parameters.Add("@third_name", user.ThirdName);
                statement.Parameters.Add("@app", user.Appointment);
                statement.Parameters.Add("@id_dept", user.Department.idDepartment);
                statement.Parameters.Add("@type", user.TypeUser);
                statement.Parameters.Add("@login", user.Login);
                statement.Parameters.Add("@pass", user.Password);
                statement.Parameters.Add("@e_mail", user.Email);
                statement.Parameters.Add("@hash_pass", user.HashPass);

                statement.ExecuteNonQuery();
                //transaction.Commit();

            }
            catch (Exception e)
            {
                throw new DAOException("Update User error ", e);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public User auth(string login, string hashPass)
        {
            FbConnection connection = null;
            FbCommand statement = null;
            String sql = "Select id_user, id_dept, u.date_in, u.date_out, l_name, f_name, p_name, login, e_mail, sent_message, sent_date, dept_name, dept_id, type_user, post from user_info u " +
                " left join depts on depts.dept_id = u.id_dept where login = @login and password = @password";
            String sqlLog = "execute procedure insert_log(@type, @id_user, @date)";
            User user = null;
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                statement = new FbCommand(sql, connection);
                statement.Parameters.Add("@login", login);
                statement.Parameters.Add("@password", hashPass);
                FbDataAdapter da = new FbDataAdapter(statement);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    user = new User();
                    user.Id = Convert.ToInt32(row["id_user"].ToString());
                    user.FirstName = row["f_name"].ToString();
                    user.SecondName = row["l_name"].ToString();
                    user.ThirdName = row["p_name"].ToString();
                    user.TypeUser = Convert.ToInt32(row["type_user"].ToString());
                    user.Login = row["login"].ToString();
                    user.Email = row["e_mail"].ToString();
                    user.HashPass = row["e_mail"].ToString();
                    user.Appointment = row["post"].ToString();

                    Department department = new Department();
                    department.idDepartment = Convert.ToInt32(row["dept_id"].ToString());
                    department.nameDepartment = row["dept_name"].ToString();
                    user.Department = department;
                }

                /*statement = new FbCommand(sqlLog, connection);
                statement.Parameters.Add("@type", 1);
                statement.Parameters.Add("@id_user", user.Id);
                statement.Parameters.Add("@date", DateTime.Now);
                statement.ExecuteNonQuery();*/
                if (user != null) insertLogInfo(1, user);

            }
            catch (Exception e)
            {
                throw new DAOException("User by login " + login, e);
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
            return user;
        }

        public void insertLogInfo(int typeLog, User user)
        {
            FbConnection connection = null;
            FbCommand statement = null;

            String sqlLog = "execute procedure insert_log(@type, @id_user, @date)";
            try
            {
                connection = daoFactory.getConnection();
                connection.Open();
                statement = new FbCommand(sqlLog, connection);
                statement.Parameters.Add("@type", typeLog);
                statement.Parameters.Add("@id_user", user.Id);
                statement.Parameters.Add("@date", DateTime.Now);
                statement.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new DAOException("Insert LOg info " + user.Id.ToString(), e);
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

    }
}
