namespace Dự_án_cuối_kì_OOP
{
    partial class PersonalScheduleManager
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
            System.Windows.Forms.DataGridView dataGridView1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalScheduleManager));
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sựKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeBackGround = new System.Windows.Forms.Button();
            this.gbRemind = new System.Windows.Forms.GroupBox();
            this.cboInterval = new System.Windows.Forms.ComboBox();
            this.lblQuet = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.btnChonNguoiDung = new System.Windows.Forms.Button();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.rbUuTien = new System.Windows.Forms.RadioButton();
            this.rbTheoTuan = new System.Windows.Forms.RadioButton();
            this.rbTheoNgay = new System.Windows.Forms.RadioButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.menuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbRemind.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colStart,
            this.colEnd,
            this.colType,
            this.colPriority});
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridView1.Location = new System.Drawing.Point(516, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1135, 695);
            dataGridView1.TabIndex = 1;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.FillWeight = 250F;
            this.colTitle.HeaderText = "Tiêu đề";
            this.colTitle.MinimumWidth = 10;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Bắt đầu";
            this.colStart.MinimumWidth = 10;
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            this.colStart.Width = 200;
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "Kết thúc";
            this.colEnd.MinimumWidth = 10;
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            this.colEnd.Width = 200;
            // 
            // colType
            // 
            this.colType.HeaderText = "Loại";
            this.colType.MinimumWidth = 10;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 200;
            // 
            // colPriority
            // 
            this.colPriority.FillWeight = 80F;
            this.colPriority.HeaderText = "Ưu tiên";
            this.colPriority.MinimumWidth = 10;
            this.colPriority.Name = "colPriority";
            this.colPriority.ReadOnly = true;
            this.colPriority.Width = 200;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.Transparent;
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tệpToolStripMenuItem,
            this.sựKiệnToolStripMenuItem,
            this.xemToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1654, 40);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            this.tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            this.tệpToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.tệpToolStripMenuItem.Text = "Tệp ";
            // 
            // sựKiệnToolStripMenuItem
            // 
            this.sựKiệnToolStripMenuItem.Name = "sựKiệnToolStripMenuItem";
            this.sựKiệnToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.sựKiệnToolStripMenuItem.Text = "Sự Kiện";
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.xemToolStripMenuItem.Text = "Xem ";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton7,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1654, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(111, 36);
            this.toolStripButton1.Text = "Thêm";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(96, 36);
            this.toolStripButton4.Text = "Lưu ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton5.Text = "Sửa";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(148, 36);
            this.toolStripButton6.Text = "Xuất CSV";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(81, 36);
            this.toolStripButton7.Text = "Tải";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(148, 36);
            this.toolStripButton3.Text = "Xuất CSV";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 513F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(dataGridView1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.7692308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1654, 707);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnChangeBackGround);
            this.panel1.Controls.Add(this.gbRemind);
            this.panel1.Controls.Add(this.gbUser);
            this.panel1.Controls.Add(this.gbFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 695);
            this.panel1.TabIndex = 0;
            // 
            // btnChangeBackGround
            // 
            this.btnChangeBackGround.Location = new System.Drawing.Point(125, 638);
            this.btnChangeBackGround.Name = "btnChangeBackGround";
            this.btnChangeBackGround.Size = new System.Drawing.Size(226, 49);
            this.btnChangeBackGround.TabIndex = 3;
            this.btnChangeBackGround.Text = "Đổi BackGround";
            this.btnChangeBackGround.UseVisualStyleBackColor = true;
            this.btnChangeBackGround.Click += new System.EventHandler(this.btnChangeBackGround_Click_1);
            // 
            // gbRemind
            // 
            this.gbRemind.BackColor = System.Drawing.Color.Transparent;
            this.gbRemind.Controls.Add(this.cboInterval);
            this.gbRemind.Controls.Add(this.lblQuet);
            this.gbRemind.Location = new System.Drawing.Point(-3, 518);
            this.gbRemind.Name = "gbRemind";
            this.gbRemind.Size = new System.Drawing.Size(510, 114);
            this.gbRemind.TabIndex = 2;
            this.gbRemind.TabStop = false;
            this.gbRemind.Text = "Nhắc việc";
            // 
            // cboInterval
            // 
            this.cboInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterval.FormattingEnabled = true;
            this.cboInterval.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "30",
            "60"});
            this.cboInterval.Location = new System.Drawing.Point(261, 53);
            this.cboInterval.Name = "cboInterval";
            this.cboInterval.Size = new System.Drawing.Size(170, 45);
            this.cboInterval.TabIndex = 1;
            // 
            // lblQuet
            // 
            this.lblQuet.AutoSize = true;
            this.lblQuet.BackColor = System.Drawing.Color.Transparent;
            this.lblQuet.Location = new System.Drawing.Point(34, 53);
            this.lblQuet.Name = "lblQuet";
            this.lblQuet.Size = new System.Drawing.Size(191, 37);
            this.lblQuet.TabIndex = 0;
            this.lblQuet.Text = "Quét nhắc việc";
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.Transparent;
            this.gbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbUser.Controls.Add(this.btnChonNguoiDung);
            this.gbUser.Controls.Add(this.lblUserTitle);
            this.gbUser.Location = new System.Drawing.Point(-3, 319);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(510, 176);
            this.gbUser.TabIndex = 1;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Người dùng";
            // 
            // btnChonNguoiDung
            // 
            this.btnChonNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.btnChonNguoiDung.Location = new System.Drawing.Point(45, 103);
            this.btnChonNguoiDung.Name = "btnChonNguoiDung";
            this.btnChonNguoiDung.Size = new System.Drawing.Size(397, 59);
            this.btnChonNguoiDung.TabIndex = 1;
            this.btnChonNguoiDung.Text = "Chọn người dùng";
            this.btnChonNguoiDung.UseVisualStyleBackColor = false;
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUserTitle.Location = new System.Drawing.Point(60, 52);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(161, 37);
            this.lblUserTitle.TabIndex = 0;
            this.lblUserTitle.Text = "Người dùng";
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.Transparent;
            this.gbFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbFilter.Controls.Add(this.rbUuTien);
            this.gbFilter.Controls.Add(this.rbTheoTuan);
            this.gbFilter.Controls.Add(this.rbTheoNgay);
            this.gbFilter.Controls.Add(this.dtpNgay);
            this.gbFilter.Controls.Add(this.lblNgay);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(507, 313);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Bộ lọc";
            // 
            // rbUuTien
            // 
            this.rbUuTien.AutoSize = true;
            this.rbUuTien.BackColor = System.Drawing.Color.Transparent;
            this.rbUuTien.Checked = true;
            this.rbUuTien.Location = new System.Drawing.Point(42, 258);
            this.rbUuTien.Name = "rbUuTien";
            this.rbUuTien.Size = new System.Drawing.Size(134, 41);
            this.rbUuTien.TabIndex = 4;
            this.rbUuTien.TabStop = true;
            this.rbUuTien.Text = "Ưu tiên";
            this.rbUuTien.UseVisualStyleBackColor = false;
            // 
            // rbTheoTuan
            // 
            this.rbTheoTuan.AutoSize = true;
            this.rbTheoTuan.BackColor = System.Drawing.Color.Transparent;
            this.rbTheoTuan.Location = new System.Drawing.Point(38, 211);
            this.rbTheoTuan.Name = "rbTheoTuan";
            this.rbTheoTuan.Size = new System.Drawing.Size(167, 41);
            this.rbTheoTuan.TabIndex = 3;
            this.rbTheoTuan.Text = "Theo tuần";
            this.rbTheoTuan.UseVisualStyleBackColor = false;
            // 
            // rbTheoNgay
            // 
            this.rbTheoNgay.AutoSize = true;
            this.rbTheoNgay.BackColor = System.Drawing.Color.Transparent;
            this.rbTheoNgay.Location = new System.Drawing.Point(38, 164);
            this.rbTheoNgay.Name = "rbTheoNgay";
            this.rbTheoNgay.Size = new System.Drawing.Size(172, 41);
            this.rbTheoNgay.TabIndex = 2;
            this.rbTheoNgay.Text = "Theo ngày";
            this.rbTheoNgay.UseVisualStyleBackColor = false;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(38, 115);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(188, 43);
            this.dtpNgay.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblNgay.Location = new System.Drawing.Point(31, 59);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(93, 37);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày :";
            // 
            // PersonalScheduleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 789);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonalScheduleManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THỜI GIAN  BIỂU CÁ NHÂN ";
            this.Load += new System.EventHandler(this.PersonalScheduleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbRemind.ResumeLayout(false);
            this.gbRemind.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem tệpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sựKiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.RadioButton rbUuTien;
        private System.Windows.Forms.RadioButton rbTheoTuan;
        private System.Windows.Forms.RadioButton rbTheoNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnChonNguoiDung;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.GroupBox gbRemind;
        private System.Windows.Forms.ComboBox cboInterval;
        private System.Windows.Forms.Label lblQuet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.Button btnChangeBackGround;
    }
}

