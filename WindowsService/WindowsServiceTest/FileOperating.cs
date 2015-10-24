using System;
using System.IO;

namespace WindowsServiceTest
{
   public class FileOperating
    {
       public static void SaveRecord(string content)
       {
           if(string.IsNullOrWhiteSpace(content))
               return;

           FileStream fileStream = null;
           StreamWriter streamWriter = null;

           try
           {
               string path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                   string.Format("{0:yyyyMMdd}.txt",DateTime.Now));
              // string path = "E:\\WindowsService\\a.txt";

               using (fileStream=new FileStream(path,FileMode.Append,FileAccess.Write))
               {
                   using (streamWriter=new StreamWriter(fileStream))
                   {
                       streamWriter.WriteLine(content);
                       if(streamWriter!=null)
                           streamWriter.Close();
                   }
               }

               if(fileStream!=null)
                   fileStream.Close();
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
