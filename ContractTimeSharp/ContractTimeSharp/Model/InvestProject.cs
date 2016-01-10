using ContractTimeSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractTime.Model
{
    class InvestProject
    {
        private int idProject;
        private String nameProject { get; set; }
        private String numberProject { get; set; }
        private Department department { get; set; }
        private User user { get; set; }
        private DateTime dateBegin { get; set; }
        private DateTime dateEnd { get; set; }
        private DateTime dateBeginProg { get; set; }
        private DateTime dateEndProg { get; set; }
        private String aboutProject { get; set; }
        private List<StageProject> projectList;

        public List<StageProject> getProjectList()
        {
            /* StageProjectDAO dao = new StageProjectDAO();
             projectList = dao.getByProject(this.getIdProject());
             return projectList;*/
            return null;
        }
    }
}
