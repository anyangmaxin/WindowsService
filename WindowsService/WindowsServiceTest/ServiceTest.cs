using System;
using System.IO;
using System.ServiceProcess;

using System.Timers;


namespace WindowsServiceTest
{
    public partial class ServiceTest : ServiceBase
    {
        
        public ServiceTest()
        {
            InitializeComponent();
            ServiceName = "ServiceTest";
            CanStop = true;
            CanPauseAndContinue = true;
            AutoLog = true;

        }

        /// <summary>
        /// 启动方法
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            FileOperating.SaveRecord(string.Format(@"当前记录时间：{0},状态：启动", DateTime.Now));
        }


        /// <summary>
        /// 停止方法
        /// </summary>
        protected override void OnStop()
        {
            FileOperating.SaveRecord(string.Format(@"当前记录时间：{0},状态：停止", DateTime.Now));
        }


      
    }
}
