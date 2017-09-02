using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maduka_QnAMaker.Models
{
    public class KBModel
    {
        public class KBListModel
        {
            public string name { get; set; }
            public string kbId { get; set; }
        }

        /// <summary>
        /// 建立新KB的模型
        /// </summary>
        public class CreateKBModel
        {
            public string name { get; set; }
            public string urls { set; get; }
            public List<QnAList> qnaPairs { get; set; }
        }

        /// <summary>
        /// 新KB建立完成後回傳的模型
        /// </summary>
        public class CreateKBResultModel
        {
            public string kbId { get; set; }
            public Dataextractionresult[] dataExtractionResults { get; set; }
            public class Dataextractionresult
            {
                public string sourceType { get; set; }
                public string extractionStatusCode { get; set; }
                public string source { get; set; }
            }
        }

        public class QnAQueryList : QnAList
        {
            public string source { get; set; }
        }

        public class QnAList
        {
            public string question { get; set; }
            public string answer { get; set; }
        }
    }
}
