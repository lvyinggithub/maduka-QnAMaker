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

namespace maduka_QnAMaker.Base
{
    public class BaseForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// 訂閱的金鑰字串設定
        /// </summary>
        public string SubscriptionKey = ConfigurationManager.AppSettings["SubscriptionKey"].ToString();

        /// <summary>
        /// 呼叫 QnAMaker API的動作
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="strAction"></param>
        /// <param name="strContent"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> CallQnAMaker(string strUrl, string strAction, string strContent)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);

            var uri = "https://westus.api.cognitive.microsoft.com/qnamaker/v2.0/knowledgebases" + strUrl;

            HttpResponseMessage response;
            byte[] byteData = Encoding.UTF8.GetBytes(strContent);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                switch (strAction.ToUpper())
                {
                    default: response = await client.GetAsync(uri); break;
                    case "GET": response = await client.GetAsync(uri); break;
                    case "POST": response = await client.PostAsync(uri, content); break;
                    case "PATCH": response = await client.PutAsync(uri, content); break;
                    case "PUT": response = await client.PutAsync(uri, content); break;
                    case "DELETE": response = await client.DeleteAsync(uri); break;
                }
            }

            return response;
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
