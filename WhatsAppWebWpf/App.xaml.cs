using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows;

namespace WhatsAppWebWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            /*
                if (e.Args.Count() > 0)
                {
                    MessageBox.Show("You have the latest version.");
                    Shutdown();
                    return;
                }

                JumpTask task = new JumpTask
                {
                    Title = "Exit Google Chat",
                    Description = "Closes the App",
                    CustomCategory = "Actions",
                    IconResourcePath = Assembly.GetEntryAssembly().Location,
                    ApplicationPath = "pwsh.exe",
                    Arguments = "-WindowStyle Hidden -Command taskkill.exe /f /im GmailZero.exe",
                    //Assembly.GetEntryAssembly().Location
                };

                JumpList jumpList = new JumpList();
                jumpList.JumpItems.Add(task);
                jumpList.ShowFrequentCategory = false;
                jumpList.ShowRecentCategory = false;

                JumpList.SetJumpList(Application.Current, jumpList);
            */

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            //var services = new ServiceCollection();

            //services.AddSingleton<IConfiguration>(configuration);

            //var serviceProvider = services.BuildServiceProvider();

            (new MainWindow(configuration)).Show();
        }
    }
}
