
namespace Downloader
{
    partial class Downloader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_downloadSync = new System.Windows.Forms.Button();
            this.button_downloadAsync = new System.Windows.Forms.Button();
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.Label();
            this.duration_label = new System.Windows.Forms.Label();
            this.duration_value = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.duration_v = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_downloadSync
            // 
            this.button_downloadSync.Location = new System.Drawing.Point(54, 120);
            this.button_downloadSync.Name = "button_downloadSync";
            this.button_downloadSync.Size = new System.Drawing.Size(392, 34);
            this.button_downloadSync.TabIndex = 0;
            this.button_downloadSync.Text = "Download Synchronously";
            this.button_downloadSync.UseVisualStyleBackColor = true;
            this.button_downloadSync.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_downloadAsync
            // 
            this.button_downloadAsync.Location = new System.Drawing.Point(54, 161);
            this.button_downloadAsync.Name = "button_downloadAsync";
            this.button_downloadAsync.Size = new System.Drawing.Size(392, 34);
            this.button_downloadAsync.TabIndex = 1;
            this.button_downloadAsync.Text = "Download Asyncronously";
            this.button_downloadAsync.UseVisualStyleBackColor = true;
            this.button_downloadAsync.Click += new System.EventHandler(this.button2_Click);
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(120, 64);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(326, 31);
            this.url_textbox.TabIndex = 2;
            this.url_textbox.TextChanged += new System.EventHandler(this.url_textbox_TextChanged);
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(54, 64);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(43, 25);
            this.url.TabIndex = 3;
            this.url.Text = "URL";
            // 
            // duration_label
            // 
            this.duration_label.AutoSize = true;
            this.duration_label.Location = new System.Drawing.Point(54, 209);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(90, 25);
            this.duration_label.TabIndex = 4;
            this.duration_label.Text = "Duration: ";
            // 
            // duration_value
            // 
            this.duration_value.AutoSize = true;
            this.duration_value.Location = new System.Drawing.Point(151, 209);
            this.duration_value.Name = "duration_value";
            this.duration_value.Size = new System.Drawing.Size(0, 25);
            this.duration_value.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_tick);
            // 
            // duration_v
            // 
            this.duration_v.AutoSize = true;
            this.duration_v.Location = new System.Drawing.Point(151, 209);
            this.duration_v.Name = "duration_v";
            this.duration_v.Size = new System.Drawing.Size(0, 25);
            this.duration_v.TabIndex = 6;
            // 
            // Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.duration_v);
            this.Controls.Add(this.duration_value);
            this.Controls.Add(this.duration_label);
            this.Controls.Add(this.url);
            this.Controls.Add(this.url_textbox);
            this.Controls.Add(this.button_downloadAsync);
            this.Controls.Add(this.button_downloadSync);
            this.Name = "Downloader";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_downloadSync;
        private System.Windows.Forms.Button button_downloadAsync;
        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Label duration_label;
        private System.Windows.Forms.Label duration_value;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label duration_v;
    }
}

