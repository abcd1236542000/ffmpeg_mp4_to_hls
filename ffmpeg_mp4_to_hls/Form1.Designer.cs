
namespace ffmpeg_mp4_to_hls
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox200p = new System.Windows.Forms.CheckBox();
            this.checkBox360p = new System.Windows.Forms.CheckBox();
            this.checkBox480p = new System.Windows.Forms.CheckBox();
            this.checkBox720p = new System.Windows.Forms.CheckBox();
            this.checkBox1080p = new System.Windows.Forms.CheckBox();
            this.checkBox1440p = new System.Windows.Forms.CheckBox();
            this.checkBox2160p = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "瀏覽";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入MP4檔路徑 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "輸出m3u8檔路徑";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(443, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "開始編碼";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "解析度選擇";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox200p
            // 
            this.checkBox200p.AutoSize = true;
            this.checkBox200p.Location = new System.Drawing.Point(123, 142);
            this.checkBox200p.Name = "checkBox200p";
            this.checkBox200p.Size = new System.Drawing.Size(48, 16);
            this.checkBox200p.TabIndex = 5;
            this.checkBox200p.Text = "200p";
            this.checkBox200p.UseVisualStyleBackColor = true;
            // 
            // checkBox360p
            // 
            this.checkBox360p.AutoSize = true;
            this.checkBox360p.Checked = true;
            this.checkBox360p.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox360p.Location = new System.Drawing.Point(123, 109);
            this.checkBox360p.Name = "checkBox360p";
            this.checkBox360p.Size = new System.Drawing.Size(48, 16);
            this.checkBox360p.TabIndex = 5;
            this.checkBox360p.Text = "360p";
            this.checkBox360p.UseVisualStyleBackColor = true;
            // 
            // checkBox480p
            // 
            this.checkBox480p.AutoSize = true;
            this.checkBox480p.Checked = true;
            this.checkBox480p.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox480p.Location = new System.Drawing.Point(201, 109);
            this.checkBox480p.Name = "checkBox480p";
            this.checkBox480p.Size = new System.Drawing.Size(48, 16);
            this.checkBox480p.TabIndex = 5;
            this.checkBox480p.Text = "480p";
            this.checkBox480p.UseVisualStyleBackColor = true;
            // 
            // checkBox720p
            // 
            this.checkBox720p.AutoSize = true;
            this.checkBox720p.Checked = true;
            this.checkBox720p.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox720p.Location = new System.Drawing.Point(282, 109);
            this.checkBox720p.Name = "checkBox720p";
            this.checkBox720p.Size = new System.Drawing.Size(48, 16);
            this.checkBox720p.TabIndex = 5;
            this.checkBox720p.Text = "720p";
            this.checkBox720p.UseVisualStyleBackColor = true;
            // 
            // checkBox1080p
            // 
            this.checkBox1080p.AutoSize = true;
            this.checkBox1080p.Checked = true;
            this.checkBox1080p.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1080p.Location = new System.Drawing.Point(363, 108);
            this.checkBox1080p.Name = "checkBox1080p";
            this.checkBox1080p.Size = new System.Drawing.Size(54, 16);
            this.checkBox1080p.TabIndex = 5;
            this.checkBox1080p.Text = "1080p";
            this.checkBox1080p.UseVisualStyleBackColor = true;
            // 
            // checkBox1440p
            // 
            this.checkBox1440p.AutoSize = true;
            this.checkBox1440p.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox1440p.Location = new System.Drawing.Point(201, 142);
            this.checkBox1440p.Name = "checkBox1440p";
            this.checkBox1440p.Size = new System.Drawing.Size(54, 16);
            this.checkBox1440p.TabIndex = 5;
            this.checkBox1440p.Text = "1440p";
            this.checkBox1440p.UseVisualStyleBackColor = true;
            // 
            // checkBox2160p
            // 
            this.checkBox2160p.AutoSize = true;
            this.checkBox2160p.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox2160p.Location = new System.Drawing.Point(282, 142);
            this.checkBox2160p.Name = "checkBox2160p";
            this.checkBox2160p.Size = new System.Drawing.Size(54, 16);
            this.checkBox2160p.TabIndex = 5;
            this.checkBox2160p.Text = "2160p";
            this.checkBox2160p.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(224, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(180, 15);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "D:/20201201/chapter1-0/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "範例　：　";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox2160p);
            this.Controls.Add(this.checkBox1440p);
            this.Controls.Add(this.checkBox1080p);
            this.Controls.Add(this.checkBox720p);
            this.Controls.Add(this.checkBox480p);
            this.Controls.Add(this.checkBox360p);
            this.Controls.Add(this.checkBox200p);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MP4 To HLS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox200p;
        private System.Windows.Forms.CheckBox checkBox360p;
        private System.Windows.Forms.CheckBox checkBox480p;
        private System.Windows.Forms.CheckBox checkBox720p;
        private System.Windows.Forms.CheckBox checkBox1080p;
        private System.Windows.Forms.CheckBox checkBox1440p;
        private System.Windows.Forms.CheckBox checkBox2160p;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

