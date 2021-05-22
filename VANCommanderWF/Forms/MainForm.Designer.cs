
namespace VANCommanderWF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbx_LocalDrive1 = new System.Windows.Forms.ComboBox();
            this.btn_copy1 = new System.Windows.Forms.Button();
            this.btn_move1 = new System.Windows.Forms.Button();
            this.btn_delete1 = new System.Windows.Forms.Button();
            this.btn_newFolder1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_path1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPanel1 = new System.Windows.Forms.ListBox();
            this.btn_search1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_search1 = new System.Windows.Forms.TextBox();
            this.btn_update1 = new System.Windows.Forms.Button();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.btn_Ld1 = new System.Windows.Forms.Button();
            this.btn_copy2 = new System.Windows.Forms.Button();
            this.btn_ftp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_search2 = new System.Windows.Forms.TextBox();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPanel2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Ld2 = new System.Windows.Forms.Button();
            this.btn_back2 = new System.Windows.Forms.Button();
            this.cbx_LocalDrive2 = new System.Windows.Forms.ComboBox();
            this.txb_path2 = new System.Windows.Forms.TextBox();
            this.btn_update2 = new System.Windows.Forms.Button();
            this.btn_newFolder2 = new System.Windows.Forms.Button();
            this.btn_delete2 = new System.Windows.Forms.Button();
            this.btn_move2 = new System.Windows.Forms.Button();
            this.btn_openVanZonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_LocalDrive1
            // 
            this.cbx_LocalDrive1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbx_LocalDrive1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LocalDrive1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_LocalDrive1.FormattingEnabled = true;
            this.cbx_LocalDrive1.Location = new System.Drawing.Point(16, 5);
            this.cbx_LocalDrive1.Name = "cbx_LocalDrive1";
            this.cbx_LocalDrive1.Size = new System.Drawing.Size(52, 33);
            this.cbx_LocalDrive1.TabIndex = 1;
            this.cbx_LocalDrive1.SelectedIndexChanged += new System.EventHandler(this.cbx_LocalDrive1_SelectedIndexChanged);
            // 
            // btn_copy1
            // 
            this.btn_copy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_copy1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_copy1.Image = ((System.Drawing.Image)(resources.GetObject("btn_copy1.Image")));
            this.btn_copy1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_copy1.Location = new System.Drawing.Point(10, 460);
            this.btn_copy1.Name = "btn_copy1";
            this.btn_copy1.Size = new System.Drawing.Size(106, 39);
            this.btn_copy1.TabIndex = 3;
            this.btn_copy1.Text = "Копировать";
            this.btn_copy1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copy1.UseVisualStyleBackColor = false;
            this.btn_copy1.Click += new System.EventHandler(this.btn_copy1_Click);
            // 
            // btn_move1
            // 
            this.btn_move1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_move1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move1.Image = ((System.Drawing.Image)(resources.GetObject("btn_move1.Image")));
            this.btn_move1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_move1.Location = new System.Drawing.Point(122, 460);
            this.btn_move1.Name = "btn_move1";
            this.btn_move1.Size = new System.Drawing.Size(116, 38);
            this.btn_move1.TabIndex = 4;
            this.btn_move1.Text = "Переместить";
            this.btn_move1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_move1.UseVisualStyleBackColor = false;
            this.btn_move1.Click += new System.EventHandler(this.btn_move1_Click);
            // 
            // btn_delete1
            // 
            this.btn_delete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete1.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete1.Image")));
            this.btn_delete1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete1.Location = new System.Drawing.Point(244, 460);
            this.btn_delete1.Name = "btn_delete1";
            this.btn_delete1.Size = new System.Drawing.Size(106, 38);
            this.btn_delete1.TabIndex = 5;
            this.btn_delete1.Text = "Удалить";
            this.btn_delete1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete1.UseVisualStyleBackColor = false;
            this.btn_delete1.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_newFolder1
            // 
            this.btn_newFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_newFolder1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_newFolder1.Image = ((System.Drawing.Image)(resources.GetObject("btn_newFolder1.Image")));
            this.btn_newFolder1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_newFolder1.Location = new System.Drawing.Point(356, 460);
            this.btn_newFolder1.Name = "btn_newFolder1";
            this.btn_newFolder1.Size = new System.Drawing.Size(106, 38);
            this.btn_newFolder1.TabIndex = 6;
            this.btn_newFolder1.Text = "Каталог";
            this.btn_newFolder1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newFolder1.UseVisualStyleBackColor = false;
            this.btn_newFolder1.Click += new System.EventHandler(this.btn_newFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Путь";
            // 
            // txb_path1
            // 
            this.txb_path1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txb_path1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_path1.Location = new System.Drawing.Point(161, 5);
            this.txb_path1.Name = "txb_path1";
            this.txb_path1.ReadOnly = true;
            this.txb_path1.Size = new System.Drawing.Size(370, 33);
            this.txb_path1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(598, 285);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(387, 226);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_search1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_search1);
            this.panel1.Controls.Add(this.btn_update1);
            this.panel1.Controls.Add(this.btn_back1);
            this.panel1.Controls.Add(this.btn_Ld1);
            this.panel1.Controls.Add(this.txb_path1);
            this.panel1.Controls.Add(this.cbx_LocalDrive1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_newFolder1);
            this.panel1.Controls.Add(this.btn_copy1);
            this.panel1.Controls.Add(this.btn_delete1);
            this.panel1.Controls.Add(this.btn_move1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 503);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPanel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 362);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель 1";
            // 
            // lbPanel1
            // 
            this.lbPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPanel1.FormattingEnabled = true;
            this.lbPanel1.ItemHeight = 21;
            this.lbPanel1.Location = new System.Drawing.Point(6, 28);
            this.lbPanel1.Name = "lbPanel1";
            this.lbPanel1.Size = new System.Drawing.Size(520, 319);
            this.lbPanel1.TabIndex = 0;
            this.lbPanel1.Click += new System.EventHandler(this.lbPanel1_Click);
            this.lbPanel1.DoubleClick += new System.EventHandler(this.lbPanel1_DoubleClick);
            // 
            // btn_search1
            // 
            this.btn_search1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search1.Image = ((System.Drawing.Image)(resources.GetObject("btn_search1.Image")));
            this.btn_search1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search1.Location = new System.Drawing.Point(446, 43);
            this.btn_search1.Name = "btn_search1";
            this.btn_search1.Size = new System.Drawing.Size(85, 42);
            this.btn_search1.TabIndex = 14;
            this.btn_search1.Text = "Поиск";
            this.btn_search1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search1.UseVisualStyleBackColor = false;
            this.btn_search1.Click += new System.EventHandler(this.btn_search1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Поиск";
            // 
            // txb_search1
            // 
            this.txb_search1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_search1.Location = new System.Drawing.Point(161, 50);
            this.txb_search1.Name = "txb_search1";
            this.txb_search1.PlaceholderText = "Введите текст";
            this.txb_search1.Size = new System.Drawing.Size(279, 29);
            this.txb_search1.TabIndex = 12;
            // 
            // btn_update1
            // 
            this.btn_update1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update1.Image = ((System.Drawing.Image)(resources.GetObject("btn_update1.Image")));
            this.btn_update1.Location = new System.Drawing.Point(468, 460);
            this.btn_update1.Name = "btn_update1";
            this.btn_update1.Size = new System.Drawing.Size(63, 38);
            this.btn_update1.TabIndex = 11;
            this.btn_update1.UseVisualStyleBackColor = false;
            this.btn_update1.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back1
            // 
            this.btn_back1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back1.Image = ((System.Drawing.Image)(resources.GetObject("btn_back1.Image")));
            this.btn_back1.Location = new System.Drawing.Point(15, 44);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(53, 42);
            this.btn_back1.TabIndex = 10;
            this.btn_back1.UseVisualStyleBackColor = false;
            this.btn_back1.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Ld1
            // 
            this.btn_Ld1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ld1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ld1.Image")));
            this.btn_Ld1.Location = new System.Drawing.Point(74, 5);
            this.btn_Ld1.Name = "btn_Ld1";
            this.btn_Ld1.Size = new System.Drawing.Size(42, 33);
            this.btn_Ld1.TabIndex = 9;
            this.btn_Ld1.UseVisualStyleBackColor = false;
            this.btn_Ld1.Click += new System.EventHandler(this.btn_Ld_Click);
            // 
            // btn_copy2
            // 
            this.btn_copy2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_copy2.Image = ((System.Drawing.Image)(resources.GetObject("btn_copy2.Image")));
            this.btn_copy2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_copy2.Location = new System.Drawing.Point(11, 460);
            this.btn_copy2.Name = "btn_copy2";
            this.btn_copy2.Size = new System.Drawing.Size(106, 38);
            this.btn_copy2.TabIndex = 15;
            this.btn_copy2.Text = "Копировать";
            this.btn_copy2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copy2.UseVisualStyleBackColor = false;
            this.btn_copy2.Click += new System.EventHandler(this.btn_copy2_Click);
            // 
            // btn_ftp
            // 
            this.btn_ftp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ftp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ftp.Image = ((System.Drawing.Image)(resources.GetObject("btn_ftp.Image")));
            this.btn_ftp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ftp.Location = new System.Drawing.Point(12, 12);
            this.btn_ftp.Name = "btn_ftp";
            this.btn_ftp.Size = new System.Drawing.Size(75, 36);
            this.btn_ftp.TabIndex = 10;
            this.btn_ftp.Text = "FTP";
            this.btn_ftp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ftp.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(933, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Настройки";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(1050, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 36);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Выход";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txb_search2);
            this.panel2.Controls.Add(this.btn_search2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_Ld2);
            this.panel2.Controls.Add(this.btn_back2);
            this.panel2.Controls.Add(this.cbx_LocalDrive2);
            this.panel2.Controls.Add(this.txb_path2);
            this.panel2.Controls.Add(this.btn_update2);
            this.panel2.Controls.Add(this.btn_newFolder2);
            this.panel2.Controls.Add(this.btn_delete2);
            this.panel2.Controls.Add(this.btn_move2);
            this.panel2.Controls.Add(this.btn_copy2);
            this.panel2.Location = new System.Drawing.Point(580, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 503);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(102, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Поиск";
            // 
            // txb_search2
            // 
            this.txb_search2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_search2.Location = new System.Drawing.Point(162, 50);
            this.txb_search2.Name = "txb_search2";
            this.txb_search2.PlaceholderText = "Введите текст";
            this.txb_search2.Size = new System.Drawing.Size(280, 29);
            this.txb_search2.TabIndex = 16;
            // 
            // btn_search2
            // 
            this.btn_search2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search2.Image = ((System.Drawing.Image)(resources.GetObject("btn_search2.Image")));
            this.btn_search2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search2.Location = new System.Drawing.Point(448, 44);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(84, 42);
            this.btn_search2.TabIndex = 16;
            this.btn_search2.Text = "Поиск";
            this.btn_search2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search2.UseVisualStyleBackColor = false;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPanel2);
            this.groupBox2.Location = new System.Drawing.Point(11, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 362);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Панель 2";
            // 
            // lbPanel2
            // 
            this.lbPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPanel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPanel2.FormattingEnabled = true;
            this.lbPanel2.ItemHeight = 21;
            this.lbPanel2.Location = new System.Drawing.Point(6, 26);
            this.lbPanel2.Name = "lbPanel2";
            this.lbPanel2.Size = new System.Drawing.Size(520, 319);
            this.lbPanel2.TabIndex = 0;
            this.lbPanel2.Click += new System.EventHandler(this.lbPanel2_Click);
            this.lbPanel2.DoubleClick += new System.EventHandler(this.lbPanel2_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Путь";
            // 
            // btn_Ld2
            // 
            this.btn_Ld2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ld2.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ld2.Image")));
            this.btn_Ld2.Location = new System.Drawing.Point(75, 5);
            this.btn_Ld2.Name = "btn_Ld2";
            this.btn_Ld2.Size = new System.Drawing.Size(42, 33);
            this.btn_Ld2.TabIndex = 15;
            this.btn_Ld2.UseVisualStyleBackColor = false;
            this.btn_Ld2.Click += new System.EventHandler(this.btn_Ld2_Click);
            // 
            // btn_back2
            // 
            this.btn_back2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back2.Image = ((System.Drawing.Image)(resources.GetObject("btn_back2.Image")));
            this.btn_back2.Location = new System.Drawing.Point(16, 44);
            this.btn_back2.Name = "btn_back2";
            this.btn_back2.Size = new System.Drawing.Size(53, 42);
            this.btn_back2.TabIndex = 21;
            this.btn_back2.UseVisualStyleBackColor = false;
            this.btn_back2.Click += new System.EventHandler(this.btn_back2_Click);
            // 
            // cbx_LocalDrive2
            // 
            this.cbx_LocalDrive2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbx_LocalDrive2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LocalDrive2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_LocalDrive2.FormattingEnabled = true;
            this.cbx_LocalDrive2.Location = new System.Drawing.Point(17, 5);
            this.cbx_LocalDrive2.Name = "cbx_LocalDrive2";
            this.cbx_LocalDrive2.Size = new System.Drawing.Size(52, 33);
            this.cbx_LocalDrive2.TabIndex = 20;
            this.cbx_LocalDrive2.SelectedIndexChanged += new System.EventHandler(this.cbx_LocalDrive2_SelectedIndexChanged);
            // 
            // txb_path2
            // 
            this.txb_path2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txb_path2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_path2.Location = new System.Drawing.Point(162, 5);
            this.txb_path2.Name = "txb_path2";
            this.txb_path2.ReadOnly = true;
            this.txb_path2.Size = new System.Drawing.Size(370, 35);
            this.txb_path2.TabIndex = 19;
            // 
            // btn_update2
            // 
            this.btn_update2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update2.Image = ((System.Drawing.Image)(resources.GetObject("btn_update2.Image")));
            this.btn_update2.Location = new System.Drawing.Point(479, 460);
            this.btn_update2.Name = "btn_update2";
            this.btn_update2.Size = new System.Drawing.Size(63, 38);
            this.btn_update2.TabIndex = 15;
            this.btn_update2.UseVisualStyleBackColor = false;
            this.btn_update2.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_newFolder2
            // 
            this.btn_newFolder2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_newFolder2.Image = ((System.Drawing.Image)(resources.GetObject("btn_newFolder2.Image")));
            this.btn_newFolder2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_newFolder2.Location = new System.Drawing.Point(362, 460);
            this.btn_newFolder2.Name = "btn_newFolder2";
            this.btn_newFolder2.Size = new System.Drawing.Size(111, 39);
            this.btn_newFolder2.TabIndex = 18;
            this.btn_newFolder2.Text = "Каталог";
            this.btn_newFolder2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newFolder2.UseVisualStyleBackColor = false;
            this.btn_newFolder2.Click += new System.EventHandler(this.btn_newFolder2_Click);
            // 
            // btn_delete2
            // 
            this.btn_delete2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete2.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete2.Image")));
            this.btn_delete2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete2.Location = new System.Drawing.Point(245, 460);
            this.btn_delete2.Name = "btn_delete2";
            this.btn_delete2.Size = new System.Drawing.Size(111, 38);
            this.btn_delete2.TabIndex = 17;
            this.btn_delete2.Text = "Удалить";
            this.btn_delete2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete2.UseVisualStyleBackColor = false;
            this.btn_delete2.Click += new System.EventHandler(this.btn_delete2_Click);
            // 
            // btn_move2
            // 
            this.btn_move2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move2.Image = ((System.Drawing.Image)(resources.GetObject("btn_move2.Image")));
            this.btn_move2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_move2.Location = new System.Drawing.Point(123, 460);
            this.btn_move2.Name = "btn_move2";
            this.btn_move2.Size = new System.Drawing.Size(116, 38);
            this.btn_move2.TabIndex = 16;
            this.btn_move2.Text = "Переместить";
            this.btn_move2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_move2.UseVisualStyleBackColor = false;
            this.btn_move2.Click += new System.EventHandler(this.btn_move2_Click);
            // 
            // btn_openVanZonder
            // 
            this.btn_openVanZonder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_openVanZonder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_openVanZonder.Image = ((System.Drawing.Image)(resources.GetObject("btn_openVanZonder.Image")));
            this.btn_openVanZonder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_openVanZonder.Location = new System.Drawing.Point(816, 12);
            this.btn_openVanZonder.Name = "btn_openVanZonder";
            this.btn_openVanZonder.Size = new System.Drawing.Size(111, 36);
            this.btn_openVanZonder.TabIndex = 14;
            this.btn_openVanZonder.Text = "Van Zonder";
            this.btn_openVanZonder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openVanZonder.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 569);
            this.Controls.Add(this.btn_openVanZonder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_ftp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1156, 608);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VANCommander";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_LocalDrive1;
        private System.Windows.Forms.Button btn_copy1;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_newFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_path1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Ld1;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_search1;
        private System.Windows.Forms.Button btn_ftp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbPanel2;
        private System.Windows.Forms.ListBox lbPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_update2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txb_path2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Ld2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_search2;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_back2;
        private System.Windows.Forms.ComboBox cbx_LocalDrive2;
        private System.Windows.Forms.Button btn_move1;
        private System.Windows.Forms.Button btn_delete1;
        private System.Windows.Forms.Button btn_newFolder1;
        private System.Windows.Forms.Button btn_copy2;
        private System.Windows.Forms.Button btn_newFolder2;
        private System.Windows.Forms.Button btn_delete2;
        private System.Windows.Forms.Button btn_move2;
        private System.Windows.Forms.Button btn_update1;
        private System.Windows.Forms.Button btn_openVanZonder;
    }
}

