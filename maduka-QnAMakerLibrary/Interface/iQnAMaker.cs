using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace maduka_QnAMakerLibrary.Interface
{
    public interface iQnAMaker
    {
        KBModel.CreateKBResultModel CreateKB(KBModel.CreateKBModel objKb, out HttpStatusCode code);

        string DownloadKB(string strKbId, out HttpStatusCode code);

        string UpdateKB(string strKbId, KBModel.UpdateKBModel value, out HttpStatusCode code);

        string TrainKB(string strKbId, out HttpStatusCode code);
    }
}
