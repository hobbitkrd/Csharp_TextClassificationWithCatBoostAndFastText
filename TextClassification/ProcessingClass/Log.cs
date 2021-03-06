using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextClassification.ProcessingClass
{
    public class Log
    {
        public async void Add(string Disc,string FuncName)
        {

            string AddToLog = "[" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") 
                               + Environment.UserName 
                               + FuncName
                               + Disc
                               + "]";

            await File.AppendAllTextAsync(Application.StartupPath + @"/Data/Logs/programLogs.txt","\r"+ AddToLog,Encoding.Default);
           
        }

    }
}
