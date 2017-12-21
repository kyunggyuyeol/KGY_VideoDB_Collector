namespace Video_DB_Collecter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_fileSearch = new System.Windows.Forms.TextBox();
            this.btn_userSearch = new System.Windows.Forms.Button();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.btn_msgSave = new System.Windows.Forms.Button();
            this.txt_msg3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_msg2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_msg1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.list_userTag = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_Naver = new System.Windows.Forms.RadioButton();
            this.rb_google = new System.Windows.Forms.RadioButton();
            this.txt_transe = new System.Windows.Forms.TextBox();
            this.txt_userInput = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Clip04 = new System.Windows.Forms.TextBox();
            this.txt_Clip03 = new System.Windows.Forms.TextBox();
            this.txt_Clip02 = new System.Windows.Forms.TextBox();
            this.txt_Clip01 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_masterREWrite = new System.Windows.Forms.TextBox();
            this.cmb_MasterCat = new System.Windows.Forms.ComboBox();
            this.btn_MasterSelect = new System.Windows.Forms.Button();
            this.btn_MasterSave = new System.Windows.Forms.Button();
            this.txt_Tag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MasterMessage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_Tag = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_clinetID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_clientScret = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_filePath = new System.Windows.Forms.TextBox();
            this.btn_SetPath = new System.Windows.Forms.Button();
            this.btn_conntest = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.MediaPlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 425F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 908);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(1069, 477);
            this.MediaPlayer.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 486);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1069, 419);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1061, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VideoDBInsert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 387);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_fileSearch);
            this.groupBox1.Controls.Add(this.btn_userSearch);
            this.groupBox1.Controls.Add(this.cmb_cat);
            this.groupBox1.Controls.Add(this.btn_msgSave);
            this.groupBox1.Controls.Add(this.txt_msg3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_msg2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_msg1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // txt_fileSearch
            // 
            this.txt_fileSearch.Location = new System.Drawing.Point(216, 20);
            this.txt_fileSearch.Name = "txt_fileSearch";
            this.txt_fileSearch.Size = new System.Drawing.Size(100, 21);
            this.txt_fileSearch.TabIndex = 13;
            this.txt_fileSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fileSearch_KeyDown);
            // 
            // btn_userSearch
            // 
            this.btn_userSearch.Location = new System.Drawing.Point(135, 18);
            this.btn_userSearch.Name = "btn_userSearch";
            this.btn_userSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_userSearch.TabIndex = 12;
            this.btn_userSearch.Text = "Search";
            this.btn_userSearch.UseVisualStyleBackColor = true;
            this.btn_userSearch.Click += new System.EventHandler(this.btn_userSearch_Click);
            // 
            // cmb_cat
            // 
            this.cmb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Location = new System.Drawing.Point(8, 20);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(121, 20);
            this.cmb_cat.TabIndex = 11;
            // 
            // btn_msgSave
            // 
            this.btn_msgSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_msgSave.Location = new System.Drawing.Point(745, 302);
            this.btn_msgSave.Name = "btn_msgSave";
            this.btn_msgSave.Size = new System.Drawing.Size(104, 47);
            this.btn_msgSave.TabIndex = 10;
            this.btn_msgSave.Text = "SAVE";
            this.btn_msgSave.UseVisualStyleBackColor = true;
            this.btn_msgSave.Click += new System.EventHandler(this.btn_msgSave_Click);
            // 
            // txt_msg3
            // 
            this.txt_msg3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_msg3.Location = new System.Drawing.Point(85, 224);
            this.txt_msg3.Multiline = true;
            this.txt_msg3.Name = "txt_msg3";
            this.txt_msg3.Size = new System.Drawing.Size(764, 50);
            this.txt_msg3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Message 3 :";
            // 
            // txt_msg2
            // 
            this.txt_msg2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_msg2.Location = new System.Drawing.Point(85, 140);
            this.txt_msg2.Multiline = true;
            this.txt_msg2.Name = "txt_msg2";
            this.txt_msg2.Size = new System.Drawing.Size(764, 50);
            this.txt_msg2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Message 2 :";
            // 
            // txt_msg1
            // 
            this.txt_msg1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_msg1.Location = new System.Drawing.Point(85, 61);
            this.txt_msg1.Multiline = true;
            this.txt_msg1.Name = "txt_msg1";
            this.txt_msg1.Size = new System.Drawing.Size(764, 50);
            this.txt_msg1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Message 1 :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.list_userTag);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(855, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 387);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FileList";
            // 
            // list_userTag
            // 
            this.list_userTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_userTag.FormattingEnabled = true;
            this.list_userTag.ItemHeight = 12;
            this.list_userTag.Location = new System.Drawing.Point(3, 17);
            this.list_userTag.Name = "list_userTag";
            this.list_userTag.Size = new System.Drawing.Size(194, 367);
            this.list_userTag.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rb_Naver);
            this.tabPage2.Controls.Add(this.rb_google);
            this.tabPage2.Controls.Add(this.txt_transe);
            this.tabPage2.Controls.Add(this.txt_userInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "번역기";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_Naver
            // 
            this.rb_Naver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_Naver.AutoSize = true;
            this.rb_Naver.Location = new System.Drawing.Point(949, 6);
            this.rb_Naver.Name = "rb_Naver";
            this.rb_Naver.Size = new System.Drawing.Size(106, 16);
            this.rb_Naver.TabIndex = 14;
            this.rb_Naver.TabStop = true;
            this.rb_Naver.Text = "네이버번역(F4)";
            this.rb_Naver.UseVisualStyleBackColor = true;
            // 
            // rb_google
            // 
            this.rb_google.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_google.AutoSize = true;
            this.rb_google.Checked = true;
            this.rb_google.Location = new System.Drawing.Point(830, 6);
            this.rb_google.Name = "rb_google";
            this.rb_google.Size = new System.Drawing.Size(94, 16);
            this.rb_google.TabIndex = 13;
            this.rb_google.TabStop = true;
            this.rb_google.Text = "구글번역(F3)";
            this.rb_google.UseVisualStyleBackColor = true;
            // 
            // txt_transe
            // 
            this.txt_transe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_transe.Location = new System.Drawing.Point(577, 85);
            this.txt_transe.Multiline = true;
            this.txt_transe.Name = "txt_transe";
            this.txt_transe.Size = new System.Drawing.Size(478, 176);
            this.txt_transe.TabIndex = 12;
            // 
            // txt_userInput
            // 
            this.txt_userInput.Location = new System.Drawing.Point(6, 85);
            this.txt_userInput.Multiline = true;
            this.txt_userInput.Name = "txt_userInput";
            this.txt_userInput.Size = new System.Drawing.Size(452, 176);
            this.txt_userInput.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1061, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MasterInput";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 387);
            this.panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Clip04);
            this.groupBox3.Controls.Add(this.txt_Clip03);
            this.groupBox3.Controls.Add(this.txt_Clip02);
            this.groupBox3.Controls.Add(this.txt_Clip01);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 272);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UserInput";
            // 
            // txt_Clip04
            // 
            this.txt_Clip04.Location = new System.Drawing.Point(58, 203);
            this.txt_Clip04.Multiline = true;
            this.txt_Clip04.Name = "txt_Clip04";
            this.txt_Clip04.ReadOnly = true;
            this.txt_Clip04.Size = new System.Drawing.Size(814, 57);
            this.txt_Clip04.TabIndex = 7;
            // 
            // txt_Clip03
            // 
            this.txt_Clip03.Location = new System.Drawing.Point(58, 142);
            this.txt_Clip03.Multiline = true;
            this.txt_Clip03.Name = "txt_Clip03";
            this.txt_Clip03.ReadOnly = true;
            this.txt_Clip03.Size = new System.Drawing.Size(814, 57);
            this.txt_Clip03.TabIndex = 6;
            // 
            // txt_Clip02
            // 
            this.txt_Clip02.Location = new System.Drawing.Point(58, 81);
            this.txt_Clip02.Multiline = true;
            this.txt_Clip02.Name = "txt_Clip02";
            this.txt_Clip02.ReadOnly = true;
            this.txt_Clip02.Size = new System.Drawing.Size(814, 57);
            this.txt_Clip02.TabIndex = 5;
            // 
            // txt_Clip01
            // 
            this.txt_Clip01.Location = new System.Drawing.Point(58, 20);
            this.txt_Clip01.Multiline = true;
            this.txt_Clip01.Name = "txt_Clip01";
            this.txt_Clip01.ReadOnly = true;
            this.txt_Clip01.Size = new System.Drawing.Size(814, 57);
            this.txt_Clip01.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "clip04";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "clip03";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "clip02";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "Clip01";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_masterREWrite);
            this.groupBox4.Controls.Add(this.cmb_MasterCat);
            this.groupBox4.Controls.Add(this.btn_MasterSelect);
            this.groupBox4.Controls.Add(this.btn_MasterSave);
            this.groupBox4.Controls.Add(this.txt_Tag);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txt_MasterMessage);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(878, 115);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MasterInput";
            // 
            // txt_masterREWrite
            // 
            this.txt_masterREWrite.Location = new System.Drawing.Point(211, 88);
            this.txt_masterREWrite.Name = "txt_masterREWrite";
            this.txt_masterREWrite.Size = new System.Drawing.Size(100, 21);
            this.txt_masterREWrite.TabIndex = 17;
            this.txt_masterREWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // cmb_MasterCat
            // 
            this.cmb_MasterCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MasterCat.FormattingEnabled = true;
            this.cmb_MasterCat.Location = new System.Drawing.Point(3, 88);
            this.cmb_MasterCat.Name = "cmb_MasterCat";
            this.cmb_MasterCat.Size = new System.Drawing.Size(121, 20);
            this.cmb_MasterCat.TabIndex = 16;
            // 
            // btn_MasterSelect
            // 
            this.btn_MasterSelect.Location = new System.Drawing.Point(130, 88);
            this.btn_MasterSelect.Name = "btn_MasterSelect";
            this.btn_MasterSelect.Size = new System.Drawing.Size(75, 23);
            this.btn_MasterSelect.TabIndex = 15;
            this.btn_MasterSelect.Text = "Search";
            this.btn_MasterSelect.UseVisualStyleBackColor = true;
            this.btn_MasterSelect.Click += new System.EventHandler(this.btn_MasterSelect_Click);
            // 
            // btn_MasterSave
            // 
            this.btn_MasterSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MasterSave.Location = new System.Drawing.Point(797, 85);
            this.btn_MasterSave.Name = "btn_MasterSave";
            this.btn_MasterSave.Size = new System.Drawing.Size(75, 23);
            this.btn_MasterSave.TabIndex = 14;
            this.btn_MasterSave.Text = "Save";
            this.btn_MasterSave.UseVisualStyleBackColor = true;
            this.btn_MasterSave.Click += new System.EventHandler(this.btn_MasterSave_Click);
            // 
            // txt_Tag
            // 
            this.txt_Tag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tag.Location = new System.Drawing.Point(97, 56);
            this.txt_Tag.Name = "txt_Tag";
            this.txt_Tag.Size = new System.Drawing.Size(775, 21);
            this.txt_Tag.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tag :";
            // 
            // txt_MasterMessage
            // 
            this.txt_MasterMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MasterMessage.Location = new System.Drawing.Point(97, 29);
            this.txt_MasterMessage.Multiline = true;
            this.txt_MasterMessage.Name = "txt_MasterMessage";
            this.txt_MasterMessage.Size = new System.Drawing.Size(775, 21);
            this.txt_MasterMessage.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "Master Msg :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(881, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 387);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_Tag);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 387);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tag_Create";
            // 
            // list_Tag
            // 
            this.list_Tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Tag.FormattingEnabled = true;
            this.list_Tag.ItemHeight = 12;
            this.list_Tag.Location = new System.Drawing.Point(3, 17);
            this.list_Tag.Name = "list_Tag";
            this.list_Tag.Size = new System.Drawing.Size(171, 367);
            this.list_Tag.TabIndex = 0;
            this.list_Tag.SelectedIndexChanged += new System.EventHandler(this.list_Tag_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1061, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.64602F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.35398F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel2.Controls.Add(this.txt_clinetID, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_server, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_user, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_pw, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_clientScret, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_filePath, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_SetPath, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_conntest, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_port, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1061, 393);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_clinetID
            // 
            this.txt_clinetID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_clinetID.Location = new System.Drawing.Point(444, 3);
            this.txt_clinetID.Name = "txt_clinetID";
            this.txt_clinetID.Size = new System.Drawing.Size(243, 21);
            this.txt_clinetID.TabIndex = 8;
            this.txt_clinetID.Text = "yi8PacuIJvqx_FQLiqdV";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "API ID :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "PW :";
            // 
            // txt_server
            // 
            this.txt_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_server.Location = new System.Drawing.Point(109, 3);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(245, 21);
            this.txt_server.TabIndex = 3;
            // 
            // txt_user
            // 
            this.txt_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_user.Location = new System.Drawing.Point(109, 28);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(245, 21);
            this.txt_user.TabIndex = 4;
            this.txt_user.Text = "user";
            // 
            // txt_pw
            // 
            this.txt_pw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pw.Location = new System.Drawing.Point(109, 52);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(245, 21);
            this.txt_pw.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "API PW :";
            // 
            // txt_clientScret
            // 
            this.txt_clientScret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_clientScret.Location = new System.Drawing.Point(444, 28);
            this.txt_clientScret.Name = "txt_clientScret";
            this.txt_clientScret.Size = new System.Drawing.Size(243, 21);
            this.txt_clientScret.TabIndex = 9;
            this.txt_clientScret.Text = "EkKqDoiZyR";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "FilePath :";
            // 
            // txt_filePath
            // 
            this.txt_filePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_filePath.Location = new System.Drawing.Point(444, 78);
            this.txt_filePath.Name = "txt_filePath";
            this.txt_filePath.ReadOnly = true;
            this.txt_filePath.Size = new System.Drawing.Size(243, 21);
            this.txt_filePath.TabIndex = 12;
            // 
            // btn_SetPath
            // 
            this.btn_SetPath.Location = new System.Drawing.Point(693, 78);
            this.btn_SetPath.Name = "btn_SetPath";
            this.btn_SetPath.Size = new System.Drawing.Size(75, 23);
            this.btn_SetPath.TabIndex = 13;
            this.btn_SetPath.Text = "...";
            this.btn_SetPath.UseVisualStyleBackColor = true;
            this.btn_SetPath.Click += new System.EventHandler(this.btn_SetPath_Click);
            // 
            // btn_conntest
            // 
            this.btn_conntest.Location = new System.Drawing.Point(693, 52);
            this.btn_conntest.Name = "btn_conntest";
            this.btn_conntest.Size = new System.Drawing.Size(75, 20);
            this.btn_conntest.TabIndex = 14;
            this.btn_conntest.Text = "DB_TEST";
            this.btn_conntest.UseVisualStyleBackColor = true;
            this.btn_conntest.Click += new System.EventHandler(this.btn_conntest_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "Port :";
            // 
            // txt_port
            // 
            this.txt_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_port.Location = new System.Drawing.Point(109, 78);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(245, 21);
            this.txt_port.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 908);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Video_DB_Collector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_clinetID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_clientScret;
        private System.Windows.Forms.RadioButton rb_Naver;
        private System.Windows.Forms.RadioButton rb_google;
        private System.Windows.Forms.TextBox txt_transe;
        private System.Windows.Forms.TextBox txt_userInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_msg2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_msg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_msg3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_msgSave;
        private System.Windows.Forms.ComboBox cmb_cat;
        private System.Windows.Forms.Button btn_userSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_filePath;
        private System.Windows.Forms.Button btn_SetPath;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_MasterSave;
        private System.Windows.Forms.TextBox txt_Tag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MasterMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_Tag;
        private System.Windows.Forms.Button btn_MasterSelect;
        private System.Windows.Forms.ComboBox cmb_MasterCat;
        private System.Windows.Forms.Button btn_conntest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Clip04;
        private System.Windows.Forms.TextBox txt_Clip03;
        private System.Windows.Forms.TextBox txt_Clip02;
        private System.Windows.Forms.TextBox txt_Clip01;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_fileSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox list_userTag;
        private System.Windows.Forms.TextBox txt_masterREWrite;
    }
}

