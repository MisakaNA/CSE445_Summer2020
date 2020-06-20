namespace WebBrowser
{
    partial class Web_browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prevBut = new System.Windows.Forms.Button();
            this.forwardBut = new System.Windows.Forms.Button();
            this.refreshBut = new System.Windows.Forms.Button();
            this.goBut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.URL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.decryptRes = new System.Windows.Forms.TextBox();
            this.encryptRes = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.encryptBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.imageVer = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.submitBut = new System.Windows.Forms.Button();
            this.enterStr = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.opChoice = new System.Windows.Forms.ComboBox();
            this.fstNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sndNum = new System.Windows.Forms.TextBox();
            this.calRes = new System.Windows.Forms.Label();
            this.equBut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageVer)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // prevBut
            // 
            this.prevBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prevBut.Location = new System.Drawing.Point(3, 3);
            this.prevBut.Name = "prevBut";
            this.prevBut.Size = new System.Drawing.Size(48, 28);
            this.prevBut.TabIndex = 0;
            this.prevBut.Text = "< ";
            this.prevBut.UseVisualStyleBackColor = true;
            this.prevBut.Click += new System.EventHandler(this.prevBut_Click);
            // 
            // forwardBut
            // 
            this.forwardBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forwardBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forwardBut.Location = new System.Drawing.Point(57, 3);
            this.forwardBut.Name = "forwardBut";
            this.forwardBut.Size = new System.Drawing.Size(48, 28);
            this.forwardBut.TabIndex = 1;
            this.forwardBut.Text = ">";
            this.forwardBut.UseVisualStyleBackColor = true;
            this.forwardBut.Click += new System.EventHandler(this.forwardBut_Click);
            // 
            // refreshBut
            // 
            this.refreshBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refreshBut.Location = new System.Drawing.Point(111, 3);
            this.refreshBut.Name = "refreshBut";
            this.refreshBut.Size = new System.Drawing.Size(90, 28);
            this.refreshBut.TabIndex = 2;
            this.refreshBut.Text = "Refresh";
            this.refreshBut.UseVisualStyleBackColor = true;
            this.refreshBut.Click += new System.EventHandler(this.refreshBut_Click);
            // 
            // goBut
            // 
            this.goBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.goBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goBut.Location = new System.Drawing.Point(1090, 3);
            this.goBut.Name = "goBut";
            this.goBut.Size = new System.Drawing.Size(58, 28);
            this.goBut.TabIndex = 4;
            this.goBut.Text = "GO !";
            this.goBut.UseVisualStyleBackColor = true;
            this.goBut.Click += new System.EventHandler(this.goBut_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Controls.Add(this.refreshBut, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.forwardBut, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.prevBut, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.goBut, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.URL, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // URL
            // 
            this.URL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.URL.Location = new System.Drawing.Point(207, 3);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(876, 26);
            this.URL.TabIndex = 5;
            this.URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.URL_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.webBrowser1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.52023F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.47977F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1151, 569);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1145, 367);
            this.webBrowser1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1145, 151);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.68539F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.31461F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel4.Controls.Add(this.decryptRes, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.encryptRes, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.msg, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.encryptBut, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1139, 83);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // decryptRes
            // 
            this.decryptRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.decryptRes.Location = new System.Drawing.Point(971, 3);
            this.decryptRes.Multiline = true;
            this.decryptRes.Name = "decryptRes";
            this.decryptRes.ReadOnly = true;
            this.decryptRes.Size = new System.Drawing.Size(165, 77);
            this.decryptRes.TabIndex = 18;
            this.decryptRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // encryptRes
            // 
            this.encryptRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.encryptRes.Location = new System.Drawing.Point(596, 3);
            this.encryptRes.Multiline = true;
            this.encryptRes.Name = "encryptRes";
            this.encryptRes.ReadOnly = true;
            this.encryptRes.Size = new System.Drawing.Size(182, 77);
            this.encryptRes.TabIndex = 16;
            this.encryptRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msg
            // 
            this.msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msg.Location = new System.Drawing.Point(200, 3);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(178, 77);
            this.msg.TabIndex = 10;
            // 
            // encryptBut
            // 
            this.encryptBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.encryptBut.Location = new System.Drawing.Point(384, 3);
            this.encryptBut.Name = "encryptBut";
            this.encryptBut.Size = new System.Drawing.Size(97, 77);
            this.encryptBut.TabIndex = 11;
            this.encryptBut.Text = "Encrypt Now";
            this.encryptBut.UseVisualStyleBackColor = true;
            this.encryptBut.Click += new System.EventHandler(this.encryptBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(487, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 83);
            this.label2.TabIndex = 12;
            this.label2.Text = "     Encrypted Result:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 83);
            this.label1.TabIndex = 14;
            this.label1.Text = "Please enter your message here:  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(784, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 83);
            this.label3.TabIndex = 17;
            this.label3.Text = "Automatic decrypted message for confirmation: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.10417F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.89583F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayoutPanel6.Controls.Add(this.imageVer, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.submitBut, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.enterStr, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 92);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1139, 56);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // imageVer
            // 
            this.imageVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageVer.Location = new System.Drawing.Point(3, 3);
            this.imageVer.Name = "imageVer";
            this.imageVer.Size = new System.Drawing.Size(148, 50);
            this.imageVer.TabIndex = 3;
            this.imageVer.TabStop = false;
            this.imageVer.Click += new System.EventHandler(this.imageVer_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(157, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(223, 50);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.58685F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.41315F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.length, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(217, 27);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter string length = ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // length
            // 
            this.length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.length.Location = new System.Drawing.Point(145, 3);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(40, 23);
            this.length.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "<< Click here to show a new code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(386, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 56);
            this.label8.TabIndex = 5;
            this.label8.Text = "Enter the captcha here: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitBut
            // 
            this.submitBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitBut.Location = new System.Drawing.Point(689, 3);
            this.submitBut.Name = "submitBut";
            this.submitBut.Size = new System.Drawing.Size(101, 50);
            this.submitBut.TabIndex = 7;
            this.submitBut.Text = "Submit";
            this.submitBut.UseVisualStyleBackColor = true;
            this.submitBut.Click += new System.EventHandler(this.submitBut_Click);
            // 
            // enterStr
            // 
            this.enterStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterStr.Location = new System.Drawing.Point(527, 3);
            this.enterStr.Multiline = true;
            this.enterStr.Name = "enterStr";
            this.enterStr.Size = new System.Drawing.Size(156, 50);
            this.enterStr.TabIndex = 6;
            this.enterStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.84211F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.15789F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel7.Controls.Add(this.opChoice, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.fstNum, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.sndNum, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.calRes, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.equBut, 4, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 376);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1145, 33);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // opChoice
            // 
            this.opChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opChoice.FormattingEnabled = true;
            this.opChoice.IntegralHeight = false;
            this.opChoice.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.opChoice.Location = new System.Drawing.Point(372, 3);
            this.opChoice.Name = "opChoice";
            this.opChoice.Size = new System.Drawing.Size(87, 26);
            this.opChoice.TabIndex = 3;
            this.opChoice.Text = " operator ";
            // 
            // fstNum
            // 
            this.fstNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fstNum.Location = new System.Drawing.Point(231, 3);
            this.fstNum.Name = "fstNum";
            this.fstNum.Size = new System.Drawing.Size(135, 24);
            this.fstNum.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Calculator:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sndNum
            // 
            this.sndNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sndNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sndNum.Location = new System.Drawing.Point(465, 3);
            this.sndNum.Name = "sndNum";
            this.sndNum.Size = new System.Drawing.Size(139, 24);
            this.sndNum.TabIndex = 4;
            // 
            // calRes
            // 
            this.calRes.AutoSize = true;
            this.calRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calRes.Location = new System.Drawing.Point(649, 0);
            this.calRes.Name = "calRes";
            this.calRes.Size = new System.Drawing.Size(253, 33);
            this.calRes.TabIndex = 6;
            this.calRes.Text = " ";
            this.calRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equBut
            // 
            this.equBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equBut.Location = new System.Drawing.Point(610, 3);
            this.equBut.Name = "equBut";
            this.equBut.Size = new System.Drawing.Size(32, 24);
            this.equBut.TabIndex = 7;
            this.equBut.Text = " =";
            this.equBut.UseVisualStyleBackColor = true;
            this.equBut.Click += new System.EventHandler(this.equBut_Click);
            // 
            // Web_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 603);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Web_browser";
            this.Text = "Web Browser";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageVer)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button prevBut;
        private System.Windows.Forms.Button forwardBut;
        private System.Windows.Forms.Button refreshBut;
        private System.Windows.Forms.Button goBut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Button encryptBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptRes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox imageVer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox enterStr;
        private System.Windows.Forms.Button submitBut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox opChoice;
        private System.Windows.Forms.TextBox fstNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sndNum;
        private System.Windows.Forms.Label calRes;
        private System.Windows.Forms.Button equBut;
        private System.Windows.Forms.TextBox decryptRes;
        private System.Windows.Forms.Label label3;
    }
}

