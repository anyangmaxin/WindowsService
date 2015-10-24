using System;
using System.IO;
using System.ServiceProcess;
using System.Threading;


namespace WindowsServiceTest
{
    public partial class ServiceTest : ServiceBase
    {
        private readonly Timer timer;
        
        public ServiceTest()
        {
            InitializeComponent();
            ServiceName = "ServiceTest";
            CanStop = true;
            CanPauseAndContinue = true;
            AutoLog = true;

            timer=new Timer(test,null,5000,5*1000);

        }

        private void test(object state)
        {
            FileOperating.SaveRecord(string.Format(@"当前记录时间：{0},状态：正在运行", DateTime.Now));
        }

        /// <summary>
        /// 启动方法
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            FileOperating.SaveRecord(string.Format(@"当前记录时间：{0},状态：启动", DateTime.Now));
        }

        protected override void OnContinue()
        {
            FileOperating.SaveRecord(string.Format(@"当前记录时间：{0},状态：继续", DateTime.Now));
        }

        protected override void OnPause()
        {
            FileOperating.SaveRecord(string.Format(@"当前记录时间：{0},状态：暂停", DateTime.Now));
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
