
namespace WindowsFormsApp1
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.shader = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.IblStatus = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // shader
            // 
            this.shader.Location = new System.Drawing.Point(43, 126);
            this.shader.Name = "shader";
            this.shader.Size = new System.Drawing.Size(88, 22);
            this.shader.TabIndex = 0;
            this.shader.Text = "셰이더";
            this.shader.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "경로 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "찾아보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(467, 126);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(98, 30);
            this.download.TabIndex = 5;
            this.download.Text = "다운로드";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.button2_Click);
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(100, 92);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(465, 28);
            this.link.TabIndex = 2;
            this.link.Text = "경로";
            this.link.TextChanged += new System.EventHandler(this.link_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IblStatus
            // 
            this.IblStatus.AutoSize = true;
            this.IblStatus.Location = new System.Drawing.Point(251, 170);
            this.IblStatus.Name = "IblStatus";
            this.IblStatus.Size = new System.Drawing.Size(104, 18);
            this.IblStatus.TabIndex = 7;
            this.IblStatus.Text = "진행도...0%";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 198);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(522, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(599, 245);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.IblStatus);
            this.Controls.Add(this.download);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.shader);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(599, 245);
            this.MinimumSize = new System.Drawing.Size(599, 245);
            this.Name = "main";
            this.Text = "마크 아포칼립스팩 다운로더";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox shader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label IblStatus;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

