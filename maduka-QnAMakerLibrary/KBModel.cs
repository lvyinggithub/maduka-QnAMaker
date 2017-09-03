using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maduka_QnAMakerLibrary
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
            public List<string> urls { set; get; }
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

        /// <summary>
        /// 送出修改動作的模型
        /// </summary>
        public class UpdateKBModel
        {
            public Add add { get; set; }
            public Delete delete { get; set; }

            public class Add
            {
                public List<QnAList> qnaPairs { get; set; }
                public List<string> urls { get; set; }
            }

            public class Delete
            {
                public List<QnAList> qnaPairs { get; set; }
            }
        }

        /// <summary>
        /// 送出訓練用的物件
        /// </summary>
        public class TrainKBModel
        {
            public List<Feedbackrecord> feedbackRecords { get; set; }

            public class Feedbackrecord
            {
                public string userId { get; set; }
                public string userQuestion { get; set; }
                public string kbQuestion { get; set; }
                public string kbAnswer { get; set; }
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
