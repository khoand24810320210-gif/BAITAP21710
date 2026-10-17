namespace WinFormsApp4._10_
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            groupBoxInput = new GroupBox();
            chkReturned = new CheckBox();
            dtpReturn = new DateTimePicker();
            label9 = new Label();
            btnMarkReturned = new Button();
            btnExport = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dtpDue = new DateTimePicker();
            dtpBorrow = new DateTimePicker();
            numQuantity = new NumericUpDown();
            comboEquipment = new ComboBox();
            txtStudentName = new TextBox();
            txtStudentId = new TextBox();
            txtId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxList = new GroupBox();
            dgvRecords = new DataGridView();
            panelTop = new Panel();
            comboFilter = new ComboBox();
            label10 = new Label();
            txtSearch = new TextBox();
            label11 = new Label();
            statusStrip = new StatusStrip();
            toolStripStatusLabelTotal = new ToolStripStatusLabel();
            toolStripStatusLabelOverdue = new ToolStripStatusLabel();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            panelTop.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxInput);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxList);
            splitContainer1.Size = new Size(1000, 600);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(chkReturned);
            groupBoxInput.Controls.Add(dtpReturn);
            groupBoxInput.Controls.Add(label9);
            groupBoxInput.Controls.Add(btnMarkReturned);
            groupBoxInput.Controls.Add(btnExport);
            groupBoxInput.Controls.Add(btnDelete);
            groupBoxInput.Controls.Add(btnUpdate);
            groupBoxInput.Controls.Add(btnAdd);
            groupBoxInput.Controls.Add(dtpDue);
            groupBoxInput.Controls.Add(dtpBorrow);
            groupBoxInput.Controls.Add(numQuantity);
            groupBoxInput.Controls.Add(comboEquipment);
            groupBoxInput.Controls.Add(txtStudentName);
            groupBoxInput.Controls.Add(txtStudentId);
            groupBoxInput.Controls.Add(txtId);
            groupBoxInput.Controls.Add(label8);
            groupBoxInput.Controls.Add(label7);
            groupBoxInput.Controls.Add(label6);
            groupBoxInput.Controls.Add(label5);
            groupBoxInput.Controls.Add(label4);
            groupBoxInput.Controls.Add(label3);
            groupBoxInput.Controls.Add(label2);
            groupBoxInput.Controls.Add(label1);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(350, 600);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Phiếu mượn";
            // 
            // chkReturned
            // 
            chkReturned.AutoSize = true;
            chkReturned.Location = new Point(120, 260);
            chkReturned.Name = "chkReturned";
            chkReturned.Size = new Size(72, 24);
            chkReturned.TabIndex = 12;
            chkReturned.Text = "Đã trả";
            chkReturned.UseVisualStyleBackColor = true;
            // 
            // dtpReturn
            // 
            dtpReturn.Format = DateTimePickerFormat.Short;
            dtpReturn.Location = new Point(120, 285);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(200, 27);
            dtpReturn.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 290);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 18;
            label9.Text = "Ngày trả thực:";
            // 
            // btnMarkReturned
            // 
            btnMarkReturned.Location = new Point(20, 330);
            btnMarkReturned.Name = "btnMarkReturned";
            btnMarkReturned.Size = new Size(140, 30);
            btnMarkReturned.TabIndex = 14;
            btnMarkReturned.Text = "Đánh dấu đã trả";
            btnMarkReturned.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(180, 330);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(140, 30);
            btnExport.TabIndex = 15;
            btnExport.Text = "Xuất CSV";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(180, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 30);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(100, 380);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(70, 30);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 30);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtpDue
            // 
            dtpDue.Format = DateTimePickerFormat.Short;
            dtpDue.Location = new Point(120, 220);
            dtpDue.Name = "dtpDue";
            dtpDue.Size = new Size(200, 27);
            dtpDue.TabIndex = 11;
            // 
            // dtpBorrow
            // 
            dtpBorrow.Format = DateTimePickerFormat.Short;
            dtpBorrow.Location = new Point(120, 185);
            dtpBorrow.Name = "dtpBorrow";
            dtpBorrow.Size = new Size(200, 27);
            dtpBorrow.TabIndex = 10;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(120, 145);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(200, 27);
            numQuantity.TabIndex = 9;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboEquipment
            // 
            comboEquipment.FormattingEnabled = true;
            comboEquipment.Location = new Point(120, 105);
            comboEquipment.Name = "comboEquipment";
            comboEquipment.Size = new Size(200, 28);
            comboEquipment.TabIndex = 8;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(120, 70);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(200, 27);
            txtStudentName.TabIndex = 7;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(120, 40);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(200, 27);
            txtStudentId.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(120, 16);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 225);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 7;
            label8.Text = "Hạn trả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 190);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày mượn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 150);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 110);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Thiết bị:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 75);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Họ tên sv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 45);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(dgvRecords);
            groupBoxList.Controls.Add(panelTop);
            groupBoxList.Controls.Add(statusStrip);
            groupBoxList.Dock = DockStyle.Fill;
            groupBoxList.Location = new Point(0, 0);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(646, 600);
            groupBoxList.TabIndex = 0;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Danh sách";
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(6, 60);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.RowTemplate.Height = 25;
            dgvRecords.Size = new Size(634, 480);
            dgvRecords.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(comboFilter);
            panelTop.Controls.Add(label10);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(label11);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(3, 23);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(640, 35);
            panelTop.TabIndex = 2;
            // 
            // comboFilter
            // 
            comboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilter.FormattingEnabled = true;
            comboFilter.Location = new Point(430, 6);
            comboFilter.Name = "comboFilter";
            comboFilter.Size = new Size(160, 28);
            comboFilter.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(380, 9);
            label10.Name = "label10";
            label10.Size = new Size(35, 20);
            label10.TabIndex = 2;
            label10.Text = "Lọc:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 27);
            txtSearch.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 9);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 0;
            label11.Text = "Tìm kiếm:";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTotal, toolStripStatusLabelOverdue });
            statusStrip.Location = new Point(3, 571);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(640, 26);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotal
            // 
            toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            toolStripStatusLabelTotal.Size = new Size(58, 20);
            toolStripStatusLabelTotal.Text = "Tổng: 0";
            // 
            // toolStripStatusLabelOverdue
            // 
            toolStripStatusLabelOverdue.Name = "toolStripStatusLabelOverdue";
            toolStripStatusLabelOverdue.Size = new Size(79, 20);
            toolStripStatusLabelOverdue.Text = "Quá hạn: 0";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new Size(1000, 600);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Lab Equipment Checkout";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            groupBoxList.ResumeLayout(false);
            groupBoxList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOverdue;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ComboBox comboEquipment;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnMarkReturned;
        private System.Windows.Forms.CheckBox chkReturned;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label label9;
    }
}

