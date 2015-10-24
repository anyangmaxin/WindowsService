using System;
using System.IO;
using System.ServiceProcess;

namespace WindowsServiceTest
{
    public partial class ServiceTest : ServiceBase
    {
        private string path = "D:\\WindowsService\\log.txt";
        public ServiceTest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 启动方法
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+" Start.");
            }
        }


        /// <summary>
        /// 停止方法
        /// </summary>
        protected override void OnStop()
        {
            using (StreamWriter sw=new StreamWriter(path,true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+" Stop.");
            }
        }
    }
}
