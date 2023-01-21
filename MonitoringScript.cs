using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace PptxtoPdf
{
    public class MonitoringScript
    {
      public string  inputDirectory;
        public    MonitoringScript(string inputDirectory)
        {
            this.inputDirectory = inputDirectory;
        }
        public string CatchPptxFiles()
        {
                string[] files = Directory.GetFiles(inputDirectory);
                // Check if there is any file in the directory 
            {
               //Checks is it pptx file or not 
               //Checking null is important because if there is no file in the directory, it will throw an exception.
              if (files != null && files.Length > 0)
                {
                for (int i =0 ; i < files.Length; i++)
                {
                    if (files[i].EndsWith(".pptx"))
                    {
                        return files[i];
                    }
                }
                }
                else
                {
                    throw new DllNotFoundException("There is no file in the directory");
                }
            }   
            return "";     
            //That empty string is beacasue of the return type of the method is string even though there is no file in the directory we should return something.    
            



        }
    }
}