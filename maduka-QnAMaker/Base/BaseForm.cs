﻿using System;
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
using maduka_QnAMakerLibrary;
using maduka_QnAMakerLibrary.Interface;

namespace maduka_QnAMaker.Base
{
    public class BaseForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// 存取QnAMaker的介面物件，於頁面讀取時進行初使化
        /// </summary>
        public iQnAMaker iQnAMaker { get; set; }

        /// <summary>
        /// 訂閱的金鑰字串設定
        /// </summary>
        public string SubscriptionKey
        {
            get { return ConfigurationManager.AppSettings["SubscriptionKey"].ToString(); }
        }

        /// <summary>
        /// 設定內容的物件
        /// </summary>
        public List<KBModel.KBListModel> KBList { get; set; }

        /// <summary>
        /// 設定檔存放的路徑
        /// </summary>
        public string ConfigurationFile { get { return ConfigurationManager.AppSettings["ConfigurationFilePath"].ToString(); } }

        /// <summary>
        /// 頁面讀取的動作
        /// </summary>
        public BaseForm()
        {
            this.iQnAMaker = new maduka_QnAMakerLibrary.API.QnAMaker()
            {
                SubscriptionKey = this.SubscriptionKey
            };
        }

        /// <summary>
        /// 讀取設定檔的動作
        /// </summary>
        public void ReadKBList()
        {
            // 如果檔案不存在就建立空檔
            if (!File.Exists(this.ConfigurationFile))
                File.WriteAllText(this.ConfigurationFile, "");

            this.KBList = new List<KBModel.KBListModel>();

            string strConfig = File.ReadAllText(this.ConfigurationFile);
            if (strConfig != "")
                this.KBList = JsonConvert.DeserializeObject<List<KBModel.KBListModel>>(strConfig);
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
