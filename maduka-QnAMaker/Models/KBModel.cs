using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maduka_QnAMaker.Models
{
    public class KBModel
    {
        public class CreateKBModel
        {
            public string name { get; set; }
            public string urls { set; get; }
            public List<QnAList> qnaPairs { get; set; }
        }


        public class QnAList
        {
            public string question { get; set; }
            public string answer { get; set; }
        }
    }
}
