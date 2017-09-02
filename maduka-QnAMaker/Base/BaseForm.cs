using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace maduka_QnAMaker.Base
{
    public class BaseForm : System.Windows.Forms.Form
    {
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
    }
}
