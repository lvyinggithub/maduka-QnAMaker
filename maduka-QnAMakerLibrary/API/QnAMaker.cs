using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace maduka_QnAMakerLibrary.API
{
    public class QnAMaker : Interface.iQnAMaker
    {
        /// <summary>
        /// 金鑰值
        /// </summary>
        public string SubscriptionKey { get; set; }

        /// <summary>
        /// 呼叫API進行KB建立的動作
        /// </summary>
        /// <param name="objKb">要建立KB的物件</param>
        /// <param name="strSubscriptionKey">存取金鑰</param>
        /// <returns></returns>
        public KBModel.CreateKBResultModel CreateKB(KBModel.CreateKBModel objKb, out HttpStatusCode code)
        {
            KBModel.CreateKBResultModel result = null;
            string strMsg = Utility.CallQnAMaker("/create", "POST", JsonConvert.SerializeObject(objKb), this.SubscriptionKey, out code);

            if (code == HttpStatusCode.Created)
                result = JsonConvert.DeserializeObject<KBModel.CreateKBResultModel>(strMsg);

            return result;
        }

        /// <summary>
        /// 下取得KB的問答資料tsv檔的Blob路徑
        /// </summary>
        /// <param name="strKbId"></param>
        /// <param name="code"></param>
        public string DownloadKB(string strKbId, out HttpStatusCode code)
        {
            return Utility.CallQnAMaker("/" + strKbId, "GET", "", this.SubscriptionKey, out code).Replace("\"", "");
        }

        /// <summary>
        /// 更新KB的資料
        /// </summary>
        /// <param name="strKbId"></param>
        /// <param name="value"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public string UpdateKB(string strKbId, KBModel.UpdateKBModel value, out HttpStatusCode code)
        {
            return Utility.CallQnAMaker("/" + strKbId, "PATCH", JsonConvert.SerializeObject(value), this.SubscriptionKey, out code);
        }

        /// <summary>
        /// 進行KB訓練的動作
        /// </summary>
        /// <param name="strKbId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public string TrainKB(string strKbId, out HttpStatusCode code)
        {
            KBModel.TrainKBModel objModel = new KBModel.TrainKBModel()
            {
                feedbackRecords = new List<KBModel.TrainKBModel.Feedbackrecord>()
                {
                    new KBModel.TrainKBModel.Feedbackrecord()
                    {
                        userId = "1",
                        userQuestion = "hey",
                        kbQuestion = "hi",
                        kbAnswer = "hey",
                    }
                }
            };

            string strUrl = $"/{strKbId}/train";
            return Utility.CallQnAMaker(strUrl, "PATCH", JsonConvert.SerializeObject(objModel), this.SubscriptionKey, out code);
        }

        /// <summary>
        /// 詢問問題的動作
        /// </summary>
        /// <param name="value"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public KBModel.GenerateAnswerResultModel GenerateAnswer(string strKbId, KBModel.GenerateAnswerModel value, out HttpStatusCode code)
        {
            KBModel.GenerateAnswerResultModel result = null;
            string strUrl = $"/{strKbId}/generateAnswer";
            string strResult = Utility.CallQnAMaker(strUrl, "POST", JsonConvert.SerializeObject(value), this.SubscriptionKey, out code);

            if (code == HttpStatusCode.OK)
                result = JsonConvert.DeserializeObject<KBModel.GenerateAnswerResultModel>(strResult);

            return result;
        }

        /// <summary>
        /// Publish KB的動作
        /// </summary>
        /// <param name="strKbId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public string PublishKB(string strKbId, out HttpStatusCode code)
        {
            return Utility.CallQnAMaker("/" + strKbId, "PUT", "", this.SubscriptionKey, out code);
        }
    }
}
