using ContractTimeSharp.DAO;
using ContractTimeSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ContractTime.Model
{
    class InvestProject
    {
        public int idProject {get;set;}
        public String nameProject { get; set; }
        public string numberProject { get; set; }
        public Department department { get; set; }
        public User user { get; set; }
        public DateTime dateBegin { get; set; }
        public DateTime dateEnd { get; set; }
        public DateTime dateBeginProg { get; set; }
        public DateTime dateEndProg { get; set; }
        public string aboutProject { get; set; }
        List<StageProject> projectList { get; set; }

        public List<StageProject> getProjectList()
        {
             StageProjectDAO dao = new StageProjectDAO();
             projectList = dao.getByProject(this.idProject);
             return projectList;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(InvestProject))
            {
                return (this.idProject == ((InvestProject)obj).idProject) ? true : false;
            }
            return false;
        }

        public override string ToString()
        {
            return nameProject + " #"+ numberProject;
        }
    }
}
