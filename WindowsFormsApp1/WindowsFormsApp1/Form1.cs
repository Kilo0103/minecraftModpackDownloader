using MetroFramework.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace WindowsFormsApp1
{
    public partial class main : MetroForm
    {
        public main()
        {
            InitializeComponent();

            this.button1.Click += button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dasf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        Task ProcessImport(List<string> data, IProgress<ProgressReport> progress)
        {
            int totalProgress = data.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                WebClient wc = new WebClient();

                if (shader.Checked)
                {
                    DirectoryInfo di1 = new DirectoryInfo(link.Text + "/shaderpacks");
                    if (!di1.Exists)
                    {
                        di1.Create();
                    }
                    wc.DownloadFile("https://media.forgecdn.net/files/3080/242/Exposa+3.15+Noise+Fix.zip", link.Text + "/shaderpacks/Exposa+3.15+Noise+Fix.zip");
                    progressReport.PercentComplete = 2; progress.Report(progressReport);
                }
                DirectoryInfo di2 = new DirectoryInfo(link.Text + "/mods");
                if (!di2.Exists)
                {
                    di2.Create();
                }
                wc.DownloadFile("https://media.forgecdn.net/files/2806/390/zombiehs_1.12-2.1.jar", link.Text + "/mods/zombiehs_1.12-2.1.jar");
                progressReport.PercentComplete = 6; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2663/393/zombieawareness-1.12.1-1.11.16.jar", link.Text + "/mods/zombieawareness-1.12.1-1.11.16.jar");
                progressReport.PercentComplete = 8; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2644/652/ToughAsNails-1.12.2-3.1.0.139-universal.jar", link.Text + "/mods/ToughAsNails-1.12.2-3.1.0.139-universal.jar");
                progressReport.PercentComplete = 13; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2763/46/tektopia-1.1.0.jar", link.Text + "/mods/tektopia-1.1.0.jar");
                progressReport.PercentComplete = 14; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2706/899/roughmobs2-1.12.2_2.0.15.jar", link.Text + "/mods/roughmobs2.jar");
                progressReport.PercentComplete = 20; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2904/825/Pam%27s+HarvestCraft+1.12.2zg.jar", link.Text + "/mods/pam'sHavestCreaft.jar");
                progressReport.PercentComplete = 22; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2820/815/OreLib-1.12.2-3.6.0.1.jar", link.Text + "/mods/OreLib.jar");
                progressReport.PercentComplete = 28; progress.Report(progressReport);
                wc.DownloadFile("https://optifine.net/downloadx?f=OptiFine_1.12.2_HD_U_F5.jar&x=bb09b6947928b5ebe48fff211801321d", link.Text + "/mods/OptiFine_1.12.2_HD_U_F5.jar");
                progressReport.PercentComplete = 30; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/3061/229/openmodularturrets-1.12.2-3.1.12-378.jar", link.Text + "/mods/openmodularTurrets-1.12.2.jar");
                progressReport.PercentComplete = 36; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2871/957/omlib-1.12.2-3.1.4-249.jar", link.Text + "/mods/omlib.1.12.2.jar");
                progressReport.PercentComplete = 40; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/3016/704/mw_2.0-0.4.5.2_mc1.12.2.jar", link.Text + "/mods/mw_2_mc1.12.2.jar");
                progressReport.PercentComplete = 47; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/3039/432/mobsunscreen-1.12.2-2.1.3.jar", link.Text + "/mods/mobsunscreen-1.12.2.jar");
                progressReport.PercentComplete = 50; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2984/182/MoBends_1.12.2-1.0.0-beta-20.06.20.jar", link.Text + "/mods/moBends_1.12.2.jar");
                progressReport.PercentComplete = 54; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2939/100/MobAmputation-1.12.2-7.0.1.jar", link.Text + "/mods/mobAmputation-1.12.2.jar");
                progressReport.PercentComplete = 60; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2861/574/lostcities-1.12-2.0.22.jar", link.Text + "/mods/lostcities-1.12.2.jar");
                progressReport.PercentComplete = 63; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2801/262/iChunUtil-1.12.2-7.2.2.jar", link.Text + "/mods/iChunUtil-1.12.2.jar");
                progressReport.PercentComplete = 70; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2874/756/EpicSiegeMod-13.167.jar", link.Text + "/mods/EpicSiegeMod.jar");
                progressReport.PercentComplete = 78; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2922/489/DynamicSurroundings-1.12.2-3.6.1.0.jar", link.Text + "/mods/DynamicSurroundings-1.12.2.jar");
                progressReport.PercentComplete = 79; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/3010/808/corpse-1.12.2-1.0.8.jar", link.Text + "/mods/corpse-1.12.2.jar");
                progressReport.PercentComplete = 83; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2902/920/coroutil-1.12.1-1.2.37.jar", link.Text + "/mods/coroutil1.12.2.jar");
                progressReport.PercentComplete = 95; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2537/917/Bloodmoon-MC1.12.2-1.5.3.jar", link.Text + "/mods/Bloodmoon-1.12.2.jar");
                progressReport.PercentComplete = 99; progress.Report(progressReport);
                wc.DownloadFile("https://media.forgecdn.net/files/2810/152/BadMobs-1.12.2-1.1.40.jar", link.Text + "/mods/BadMobs-1.12.2.jar");
                progressReport.PercentComplete = 100; progress.Report(progressReport);
            });
        }

        /// <summary>
        /// 다운로드 시작 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {

            



            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());
            IblStatus.Text = "진행중...";
            var progressReport = new Progress<ProgressReport>();
            progressReport.ProgressChanged += (o, report) =>
            {
                IblStatus.Text = string.Format("진행중...{0}%", report.PercentComplete);
                progressBar1.Value = report.PercentComplete;
                progressBar1.Update();
            };
            await ProcessImport(list, progressReport);
            IblStatus.Text = "완료 !!!";
        }

        /// <summary>
        /// 파일 경로를 찾을 수 있게 하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            //dialog.InitialDirectory = "/AppData/Roaming/.minecraft";
            dialog.IsFolderPicker = true;
            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                link.Text = dialog.FileName;
            }

        }

        private void link_TextChanged(object sender, EventArgs e)
        {

        }
    }
}