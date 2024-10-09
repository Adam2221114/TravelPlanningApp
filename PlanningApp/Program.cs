using System;
using System.Windows.Forms;

namespace PlanningApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login()); // 设置登录表单为启动表单
        }
    }
}
