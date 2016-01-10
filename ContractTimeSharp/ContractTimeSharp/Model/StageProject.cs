using ContractTime.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractTimeSharp.Model
{
    class StageProject
    {
        private int idStage;
        private int idProject;
        private int idParentStage;
        private String nameStage { get; set; }
        private User user { get; set; }
        private DateTime dateBeginPlan { get; set; }
        private DateTime dateEndPlan { get; set; }
        private DateTime dateBeginProg { get; set; }
        private DateTime dateEndProg { get; set; }
        private DateTime dateBeginUser {get;set;}
        private DateTime dateEndUser {get; set;}
        private int statusStage { get; set; }
        private String commentUser {get;set;}

        private List<StageProject> subStage = new List<StageProject>();
    }
}
