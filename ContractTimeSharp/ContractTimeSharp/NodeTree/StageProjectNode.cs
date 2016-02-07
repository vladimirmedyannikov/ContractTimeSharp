using Aga.Controls.Tree;
using ContractTimeSharp.Model;
using ContractTimeSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ContractTimeSharp.NodeTree
{
    class StageProjectNode : Node
    {
        public string NameStage = "";
        
        public string DateBegin = "";
        public string DateEnd = "";
        public string User = "";
        public string DateBeginProg = "";
        public string DateEndProg = "";
        public string DateBeginUser = "";
        public string DateEndUser = "";
        public string Status = "";
        public string CommentUser = "";

        public StageProject stage;

        public StageProjectNode(string name, string comment, string dateBegin, string dateEnd, string dateBeginProg, string dateEndProg, string dateBeginUser, string dateEndUser,
            string user, string status, StageProject stage) : base()
        {
            this.stage = stage;
            NameStage = name;
            CommentUser = comment;
            DateBegin = dateBegin;
            DateEnd = dateEnd;
            DateBeginProg = dateBeginProg;
            DateEndProg = dateEndProg;
            DateBeginUser =  (dateBeginUser.Equals("01.01.0001")) ? "" : dateBeginUser;
            DateEndUser = (dateEndUser.Equals("01.01.0001")) ? "" : dateEndUser;
            User = user;
            Status = (status.Equals(((int)AdvanceUtil.stageStatus.FACT).ToString()) == true) ? "Факт" : "Прогноз" ;
            
        }

        public override string ToString()
        {
            return String.Format("Название {0} | Дата начала {1} | Дата завершения {2} | Дата начала(прогноз) {3} | Дата завершения(прогноз) {4} | Статус {5} | Ответственный {6} | {7} | {8}", NameStage, DateBegin, DateEnd, DateBeginProg, DateEndProg, Status, User, DateEndUser, DateBeginUser);
        }
    }
}
