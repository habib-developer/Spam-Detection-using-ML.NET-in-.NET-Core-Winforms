// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Spam_Detection_WinformsML.Model
{
    public class ModelInput
    {
        [ColumnName("IsSpam"), LoadColumn(0)]
        public bool IsSpam { get; set; }


        [ColumnName("Message"), LoadColumn(1)]
        public string Message { get; set; }


    }
}
