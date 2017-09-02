using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace maduka_QnAMaker.Base
{
    public class BaseForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// 訂閱的金鑰字串設定
        /// </summary>
        public string SubscriptionKey
        {
            get { return ConfigurationManager.AppSettings["SubscriptionKey"].ToString(); }
        }

        /// <summary>
        /// 呼叫API的動作
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="strHttpMethod"></param>
        /// <param name="strPostContent"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        protected string CallQnAMaker(string strUrl, string strHttpMethod, string strPostContent, out HttpStatusCode code)
        {
            strUrl = "https://westus.api.cognitive.microsoft.com/qnamaker/v2.0/knowledgebases" + strUrl;
            code = HttpStatusCode.OK;

            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = strHttpMethod;
            request.Headers.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);

            if (strPostContent != "" && strPostContent != string.Empty)
            {
                request.KeepAlive = true;
                request.ContentType = "application/json";

                byte[] bs = Encoding.UTF8.GetBytes(strPostContent);
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(bs, 0, bs.Length);
            }

            string strReturn = "";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var respStream = response.GetResponseStream();
                strReturn = new StreamReader(respStream).ReadToEnd();
                code = response.StatusCode;
            }
            catch (Exception e)
            {
                strReturn = e.Message;
                code = HttpStatusCode.NotFound;
            }

            return strReturn;
        }
        
        /// <summary>
        /// 設定內容的物件
        /// </summary>
        public List<Models.KBModel.KBListModel> KBList { get; set; }
        /// <summary>
        /// 設定檔存放的路徑
        /// </summary>
        public string ConfigurationFile { get { return ConfigurationManager.AppSettings["ConfigurationFilePath"].ToString(); } }

        /// <summary>
        /// 讀取設定檔的動作
        /// </summary>
        public void ReadKBList()
        {
            // 如果檔案不存在就建立空檔
            if (!File.Exists(this.ConfigurationFile))
                File.WriteAllText(this.ConfigurationFile, "");

            this.KBList = new List<Models.KBModel.KBListModel>();

            string strConfig = File.ReadAllText(this.ConfigurationFile);
            if (strConfig != "")
                this.KBList = JsonConvert.DeserializeObject<List<Models.KBModel.KBListModel>>(strConfig);
        }

        /// <summary>
        /// 寫入設定檔的動作
        /// </summary>
        public void WriteKBList()
        {
            string strConfig = JsonConvert.SerializeObject(this.KBList);
            File.WriteAllText(this.ConfigurationFile, strConfig);
        }
    }
}
