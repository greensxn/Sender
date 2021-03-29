namespace Sender {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbErrorMail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btClearFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHead = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.delayMsg = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.delayMsgAfter = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.checkDelay = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkRepeat = new System.Windows.Forms.CheckBox();
            this.repeat = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBy = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMsgAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.tbMessage.Location = new System.Drawing.Point(11, 10);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(770, 148);
            this.tbMessage.TabIndex = 5;
            this.tbMessage.Text = "";
            this.tbMessage.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label1.Location = new System.Drawing.Point(14, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сообщение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label2.Location = new System.Drawing.Point(54, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите Excel файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(63, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Почта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(51, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.panel1.Location = new System.Drawing.Point(15, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.panel2.Location = new System.Drawing.Point(15, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 1);
            this.panel2.TabIndex = 8;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Google Sans", 12F);
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.lbError.Location = new System.Drawing.Point(165, 89);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 20);
            this.lbError.TabIndex = 10;
            // 
            // delay
            // 
            this.delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.delay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.delay.Location = new System.Drawing.Point(364, 290);
            this.delay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(74, 22);
            this.delay.TabIndex = 6;
            this.delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delay.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label5.Location = new System.Drawing.Point(157, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Задержка отправки (сек):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(28, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Заголовок:";
            // 
            // lbErrorMail
            // 
            this.lbErrorMail.AutoSize = true;
            this.lbErrorMail.Font = new System.Drawing.Font("Google Sans", 12F);
            this.lbErrorMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.lbErrorMail.Location = new System.Drawing.Point(576, 185);
            this.lbErrorMail.Name = "lbErrorMail";
            this.lbErrorMail.Size = new System.Drawing.Size(70, 20);
            this.lbErrorMail.TabIndex = 10;
            this.lbErrorMail.Text = "Ошибка";
            this.lbErrorMail.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(78, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Имя:";
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Font = new System.Drawing.Font("Google Sans", 12F);
            this.checkPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.checkPass.Location = new System.Drawing.Point(443, 209);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(97, 24);
            this.checkPass.TabIndex = 14;
            this.checkPass.Text = "Показать";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.label9.Location = new System.Drawing.Point(804, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Результат:";
            // 
            // btClearFile
            // 
            this.btClearFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.btClearFile.FlatAppearance.BorderSize = 0;
            this.btClearFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.btClearFile.Location = new System.Drawing.Point(58, 87);
            this.btClearFile.Name = "btClearFile";
            this.btClearFile.Size = new System.Drawing.Size(91, 24);
            this.btClearFile.TabIndex = 0;
            this.btClearFile.Text = "Выбрать";
            this.btClearFile.UseVisualStyleBackColor = false;
            this.btClearFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(638, 794);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(164, 33);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.send_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Google Sans", 12F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.tbName.Location = new System.Drawing.Point(127, 530);
            this.tbName.MaxLength = 250;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(171, 20);
            this.tbName.TabIndex = 3;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbHead
            // 
            this.tbHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.tbHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHead.Font = new System.Drawing.Font("Google Sans", 12F);
            this.tbHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.tbHead.Location = new System.Drawing.Point(127, 567);
            this.tbHead.MaxLength = 250;
            this.tbHead.Name = "tbHead";
            this.tbHead.Size = new System.Drawing.Size(355, 20);
            this.tbHead.TabIndex = 4;
            this.tbHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Google Sans", 12F);
            this.tbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.tbPass.Location = new System.Drawing.Point(127, 211);
            this.tbPass.MaxLength = 250;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(310, 20);
            this.tbPass.TabIndex = 2;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Google Sans", 12F);
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.tbLogin.Location = new System.Drawing.Point(127, 161);
            this.tbLogin.MaxLength = 250;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(310, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.tbMessage);
            this.panel3.Location = new System.Drawing.Point(21, 626);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 161);
            this.panel3.TabIndex = 5;
            this.panel3.TabStop = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.Location = new System.Drawing.Point(1017, 794);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 33);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Hans Kendrick", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.btExit.Location = new System.Drawing.Point(1154, 6);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(34, 30);
            this.btExit.TabIndex = 21;
            this.btExit.Text = "X";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.label10.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.label10.Location = new System.Drawing.Point(12, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sender";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.panel4.Location = new System.Drawing.Point(16, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 1);
            this.panel4.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listBox1.Font = new System.Drawing.Font("Google Sans", 12F);
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.listBox1.GridLines = true;
            this.listBox1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listBox1.HideSelection = false;
            this.listBox1.Location = new System.Drawing.Point(16, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 695);
            this.listBox1.TabIndex = 23;
            this.listBox1.UseCompatibleStateImageBehavior = false;
            this.listBox1.View = System.Windows.Forms.View.SmallIcon;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Почта";
            this.columnHeader1.Width = 1000;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.panel5.Location = new System.Drawing.Point(16, 487);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(652, 1);
            this.panel5.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.label11.Location = new System.Drawing.Point(18, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Сообщение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.label12.Location = new System.Drawing.Point(17, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Почта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.label13.Location = new System.Drawing.Point(17, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Задержка";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label14.Location = new System.Drawing.Point(33, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "После каждого";
            // 
            // delayMsg
            // 
            this.delayMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.delayMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delayMsg.Enabled = false;
            this.delayMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delayMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.delayMsg.Location = new System.Drawing.Point(161, 339);
            this.delayMsg.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.delayMsg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayMsg.Name = "delayMsg";
            this.delayMsg.Size = new System.Drawing.Size(74, 22);
            this.delayMsg.TabIndex = 6;
            this.delayMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayMsg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayMsg.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label15.Location = new System.Drawing.Point(238, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "сообщения, задержка в ";
            // 
            // delayMsgAfter
            // 
            this.delayMsgAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.delayMsgAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delayMsgAfter.Enabled = false;
            this.delayMsgAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delayMsgAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.delayMsgAfter.Location = new System.Drawing.Point(432, 339);
            this.delayMsgAfter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.delayMsgAfter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayMsgAfter.Name = "delayMsgAfter";
            this.delayMsgAfter.Size = new System.Drawing.Size(74, 22);
            this.delayMsgAfter.TabIndex = 6;
            this.delayMsgAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayMsgAfter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayMsgAfter.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label16.Location = new System.Drawing.Point(512, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "сек";
            // 
            // checkDelay
            // 
            this.checkDelay.AutoSize = true;
            this.checkDelay.Font = new System.Drawing.Font("Google Sans", 12F);
            this.checkDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.checkDelay.Location = new System.Drawing.Point(564, 340);
            this.checkDelay.Name = "checkDelay";
            this.checkDelay.Size = new System.Drawing.Size(102, 24);
            this.checkDelay.TabIndex = 14;
            this.checkDelay.Text = "Включить";
            this.checkDelay.UseVisualStyleBackColor = true;
            this.checkDelay.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.panel6.Location = new System.Drawing.Point(21, 626);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 161);
            this.panel6.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.label17.Location = new System.Drawing.Point(17, 397);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "Повтор";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.panel7.Location = new System.Drawing.Point(15, 389);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(652, 1);
            this.panel7.TabIndex = 8;
            // 
            // checkRepeat
            // 
            this.checkRepeat.AutoSize = true;
            this.checkRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkRepeat.FlatAppearance.BorderSize = 0;
            this.checkRepeat.Font = new System.Drawing.Font("Google Sans", 12F);
            this.checkRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.checkRepeat.Location = new System.Drawing.Point(92, 396);
            this.checkRepeat.Name = "checkRepeat";
            this.checkRepeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkRepeat.Size = new System.Drawing.Size(102, 24);
            this.checkRepeat.TabIndex = 14;
            this.checkRepeat.Text = "Включить";
            this.checkRepeat.UseVisualStyleBackColor = true;
            this.checkRepeat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // repeat
            // 
            this.repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.repeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeat.Enabled = false;
            this.repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.repeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.repeat.Location = new System.Drawing.Point(424, 436);
            this.repeat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.repeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(74, 22);
            this.repeat.TabIndex = 6;
            this.repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeat.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label18.Location = new System.Drawing.Point(157, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(261, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Повторить операцию через (сек)";
            // 
            // txtBy
            // 
            this.txtBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.txtBy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBy.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.txtBy.Location = new System.Drawing.Point(999, 6);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(131, 19);
            this.txtBy.TabIndex = 24;
            this.txtBy.Text = "by @CMETAHKA";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.listBox1);
            this.panel8.Location = new System.Drawing.Point(808, 74);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(373, 713);
            this.panel8.TabIndex = 5;
            this.panel8.TabStop = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Google Sans", 12F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.label19.Location = new System.Drawing.Point(17, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "Данные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1193, 835);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbHead);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btClearFile);
            this.Controls.Add(this.checkRepeat);
            this.Controls.Add(this.checkDelay);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delayMsgAfter);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.delayMsg);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.lbErrorMail);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1193, 722);
            this.Name = "Form1";
            this.Text = "Sender";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delayMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMsgAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.NumericUpDown delay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbErrorMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btClearFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHead;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown delayMsg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown delayMsgAfter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkDelay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkRepeat;
        private System.Windows.Forms.NumericUpDown repeat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtBy;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label19;
    }
}

