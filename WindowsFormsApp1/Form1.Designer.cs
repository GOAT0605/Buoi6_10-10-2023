
namespace WindowsFormsApp1
{
    partial class Form1
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
        private void InitializeComponent() { 
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVictim = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.cmbInfected = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.truyVếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(306, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin ca bệnh covid 19  tại Việt Nam";
            // 
            // dgvVictim
            // 
            this.dgvVictim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVictim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.TenBN,
            this.TinhTrang,
            this.F});
            this.dgvVictim.Location = new System.Drawing.Point(387, 139);
            this.dgvVictim.Name = "dgvVictim";
            this.dgvVictim.Size = new System.Drawing.Size(766, 406);
            this.dgvVictim.TabIndex = 2;
            this.dgvVictim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVictim_CellClick);
            this.dgvVictim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVictim_CellContentClick);
            // 
            // MaBN
            // 
            this.MaBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBN.HeaderText = "Mã BN";
            this.MaBN.Name = "MaBN";
            // 
            // TenBN
            // 
            this.TenBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenBN.FillWeight = 130F;
            this.TenBN.HeaderText = "Tên Bn";
            this.TenBN.Name = "TenBN";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // F
            // 
            this.F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F.HeaderText = "F";
            this.F.Name = "F";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(120, 522);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Cập nhật";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(224, 522);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.truyVếtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // TxtNote
            // 
            this.TxtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtNote.Location = new System.Drawing.Point(124, 232);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtNote.Size = new System.Drawing.Size(175, 95);
            this.TxtNote.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtName.Location = new System.Drawing.Point(124, 113);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(147, 26);
            this.TxtName.TabIndex = 4;
            // 
            // cmbInfected
            // 
            this.cmbInfected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbInfected.FormattingEnabled = true;
            this.cmbInfected.Location = new System.Drawing.Point(124, 347);
            this.cmbInfected.Name = "cmbInfected";
            this.cmbInfected.Size = new System.Drawing.Size(165, 28);
            this.cmbInfected.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(9, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(-4, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lây nhiễm từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(10, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên BN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(10, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã BN";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtID.Location = new System.Drawing.Point(124, 56);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 26);
            this.TxtID.TabIndex = 4;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbState);
            this.groupBox1.Controls.Add(this.cmbInfected);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtNote);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBox1.Location = new System.Drawing.Point(27, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 385);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(10, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ghi Chú";
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(124, 173);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(165, 28);
            this.cmbState.TabIndex = 5;
            // 
            // truyVếtToolStripMenuItem
            // 
            this.truyVếtToolStripMenuItem.Name = "truyVếtToolStripMenuItem";
            this.truyVếtToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+T";
            this.truyVếtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.truyVếtToolStripMenuItem.Text = "Truy vết";
            this.truyVếtToolStripMenuItem.Click += new System.EventHandler(this.truyVếtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.dgvVictim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvVictim;
    private System.Windows.Forms.Button BtnEdit;
    private System.Windows.Forms.Button BtnExit;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
    private System.Windows.Forms.TextBox TxtNote;
    private System.Windows.Forms.TextBox TxtName;
    private System.Windows.Forms.ComboBox cmbInfected;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox TxtID;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
    private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
    private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    private System.Windows.Forms.DataGridViewTextBoxColumn F;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbState;
        #endregion

        private System.Windows.Forms.ToolStripMenuItem truyVếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

