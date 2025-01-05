namespace RapidApiCurrencyApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.Location = new System.Drawing.Point(127, 19);
            this.lblDolarAlis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(51, 21);
            this.lblDolarAlis.TabIndex = 0;
            this.lblDolarAlis.Text = "label1";
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.Location = new System.Drawing.Point(127, 65);
            this.lblDolarSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(54, 21);
            this.lblDolarSatis.TabIndex = 1;
            this.lblDolarSatis.Text = "label2";
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.Location = new System.Drawing.Point(364, 28);
            this.lblEuroAlis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(54, 21);
            this.lblEuroAlis.TabIndex = 2;
            this.lblEuroAlis.Text = "label3";
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.Location = new System.Drawing.Point(364, 65);
            this.lblEuroSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(54, 21);
            this.lblEuroSatis.TabIndex = 3;
            this.lblEuroSatis.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(222, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birim Tutar:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(157, 113);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 25);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dolar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 25);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Euro";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(330, 113);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 25);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sterlin";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(213, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "İşlemi Yap";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ödenecek Tutar:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(222, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 32);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.lblDolarAlis);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Kuru Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

