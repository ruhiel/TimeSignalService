using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace TimeSignalService
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        static void Main(string[] args)
        {
            var service = new TimeSignalService();
            if (Environment.UserInteractive)
            {
                if (args.Length > 0)
                {
                    switch (args[0].ToLower())
                    {
                        case "/i":
                            Install(service);
                            StartService(service);
                            break;
                        case "/u":
                            StopService(service);
                            UnInstall(service);
                            break;
                    }
                }
                return;
            }
            else
            {
                var ServicesToRun = new ServiceBase[]
                {
                    service
                };
                ServiceBase.Run(ServicesToRun);
            }

        }

        private static void StopService(ServiceBase service)
        {
            using (var sc = new ServiceController(service.ServiceName))
            {
                //プロパティ値を更新
                sc.Refresh();

                if (sc.Status == ServiceControllerStatus.Running)
                {
                    // 停止
                    sc.Stop();
                }
            }
        }

        private static void StartService(ServiceBase service)
        {
            using (var sc = new ServiceController(service.ServiceName))
            {
                //プロパティ値を更新
                sc.Refresh();

                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    // 開始
                    sc.Start();
                }
            }
        }

        public static void Install(ServiceBase service)
        {
            var path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            if (IsServiceExists(service.ServiceName))
            {
                Console.WriteLine("既にインストールされています。");
            }
            else
            {
                ManagedInstallerClass.InstallHelper(new string[] { path });
            }
        }
        public static void UnInstall(ServiceBase service)
        {
            var path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            if (IsServiceExists(service.ServiceName))
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", path });
            }
            else
            {
                Console.WriteLine("インストールされていません。");
            }
        }

        private static bool IsServiceExists(string serviceName) => ServiceController.GetServices().Any(s => s.ServiceName == serviceName);
    }
}
