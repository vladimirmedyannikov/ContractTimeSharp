using Aga.Controls.Tree;
using ContractTimeSharp.Model;
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
            DateBeginUser = dateBeginUser;
            DateEndUser = dateEndUser;
            User = user;
            Status = status.ToString();
            
        }
    }
}
