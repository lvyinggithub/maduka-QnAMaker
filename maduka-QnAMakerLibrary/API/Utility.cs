using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace maduka_QnAMakerLibrary.API
{
    internal static class Utility
    {
        /// <summary>
        /// 呼叫API的動作
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="strHttpMethod"></param>
        /// <param name="strPostContent"></param>
        /// <param name="strSubscriptionKey"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        internal static string CallQnAMaker(string strUrl, string strHttpMethod, string strPostContent, string strSubscriptionKey, out HttpStatusCode code)
        {
            strUrl = "https://westus.api.cognitive.microsoft.com/qnamaker/v2.0/knowledgebases" + strUrl;
            code = HttpStatusCode.OK;
            byte[] bs = Encoding.UTF8.GetBytes(strPostContent);

            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = strHttpMethod;
            request.Headers.Add("Ocp-Apim-Subscription-Key", strSubscriptionKey);
            request.ContentType = "application/json";
            request.ContentLength = bs.Length;
            request.KeepAlive = true;

            if (!string.IsNullOrEmpty(strPostContent))
            {
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
                code = HttpStatusCode.BadRequest;
            }

            return strReturn;
        }
    }
}
