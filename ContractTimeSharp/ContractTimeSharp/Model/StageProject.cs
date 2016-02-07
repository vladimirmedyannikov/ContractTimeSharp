using ContractTime.Model;
using ContractTimeSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractTimeSharp.Model
{
    class StageProject
    {
        private int idStage { get; set; }
        private int idProject { get; set; }
        private int idParentStage { get; set; }
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
        private InvestProject project;
        private DateTime dateSend { get; set; }

        public DateTime DateSend
        {
            get { return dateSend; }
            set { dateSend = value; }
        }

        public InvestProject Project {
            get { return project; }
            set { project = value; }
        }

        public int IdStage {
            get { return idStage; }
            set { idStage = value; }
        }
        public int IdProject {
            get { return idProject; }
            set { idProject = value; }
        }
        public int IdParentStage {
            get { return idParentStage; }
            set { idParentStage = value; }
        }
        public String NameStage {
            get { return nameStage; }
            set { nameStage = value; }
        }
        public User User {
            get { return user; }
            set { user = value; }
        }
        public DateTime DateBeginPlan {
            get { return dateBeginPlan; }
            set { dateBeginPlan = value; }
        }
        public DateTime DateEndPlan {
            get { return dateEndPlan; }
            set { dateEndPlan = value; }
        }
        public DateTime DateBeginProg {
            get { return dateBeginProg; }
            set { dateBeginProg = value; }
        }
        public DateTime DateEndProg {
            get { return dateEndProg; }
            set { dateEndProg = value; }
        }
        public DateTime DateBeginUser {
            get { return dateBeginUser; }
            set { dateBeginUser = value; }
        }
        public DateTime DateEndUser {
            get
            {
                return dateEndUser;
                /*if (dateEndUser.CompareTo(new DateTime(1, 1, 1)) == 0) {
                    return dateEndPlan;
                }
                else
                {
                    return dateEndUser;
                }*/
            }
            set { dateEndUser = value; }
        }
        public int StatusStage {
            get { return statusStage; }
            set { statusStage = value; }
        }

        public String StatusStageStr
        {
            get
            {
                if (statusStage == (int)AdvanceUtil.stageStatus.FACT)
                {
                    return "Факт";
                }
                else
                    return "Прогноз";
            }
        }
   
        public String CommentUser {
            get { return commentUser; }
            set { commentUser = value; }
        }


        private List<StageProject> subStage = new List<StageProject>();

        public List<StageProject> SubStage
        {
            get { return subStage; }
            set { subStage = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(StageProject))
            {
                return (((StageProject)obj).idStage == this.idStage) ? true : false;
            }
            else return false;
        }
    }
}
