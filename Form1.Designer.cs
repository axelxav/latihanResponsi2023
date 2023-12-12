namespace latihanResponsi2023
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
            lbl_dataUsers = new Label();
            lbl_nama = new Label();
            lbl_alamat = new Label();
            lbl_noHandphone = new Label();
            txtNo_Handphone = new TextBox();
            txtAlamat = new TextBox();
            txtName = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            btnLoaddata = new Button();
            btnQr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lbl_dataUsers
            // 
            lbl_dataUsers.AutoSize = true;
            lbl_dataUsers.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dataUsers.Location = new Point(313, 24);
            lbl_dataUsers.Name = "lbl_dataUsers";
            lbl_dataUsers.Size = new Size(176, 37);
            lbl_dataUsers.TabIndex = 0;
            lbl_dataUsers.Text = "DATA USERS";
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nama.Location = new Point(25, 87);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(49, 19);
            lbl_nama.TabIndex = 1;
            lbl_nama.Text = "Nama";
            // 
            // lbl_alamat
            // 
            lbl_alamat.AutoSize = true;
            lbl_alamat.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_alamat.Location = new Point(25, 117);
            lbl_alamat.Name = "lbl_alamat";
            lbl_alamat.Size = new Size(59, 19);
            lbl_alamat.TabIndex = 2;
            lbl_alamat.Text = "Alamat";
            // 
            // lbl_noHandphone
            // 
            lbl_noHandphone.AutoSize = true;
            lbl_noHandphone.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_noHandphone.Location = new Point(25, 146);
            lbl_noHandphone.Name = "lbl_noHandphone";
            lbl_noHandphone.Size = new Size(114, 19);
            lbl_noHandphone.TabIndex = 3;
            lbl_noHandphone.Text = "No Handphone";
            // 
            // txtNo_Handphone
            // 
            txtNo_Handphone.Location = new Point(145, 145);
            txtNo_Handphone.Name = "txtNo_Handphone";
            txtNo_Handphone.Size = new Size(173, 23);
            txtNo_Handphone.TabIndex = 4;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(145, 113);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(173, 23);
            txtAlamat.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 23);
            txtName.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(404, 83);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(85, 85);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(524, 83);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 85);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(644, 84);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 85);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(25, 193);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(751, 184);
            dgvData.TabIndex = 10;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnLoaddata
            // 
            btnLoaddata.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoaddata.Location = new Point(675, 397);
            btnLoaddata.Name = "btnLoaddata";
            btnLoaddata.Size = new Size(101, 23);
            btnLoaddata.TabIndex = 11;
            btnLoaddata.Text = "Load Data";
            btnLoaddata.UseVisualStyleBackColor = true;
            btnLoaddata.Click += btnLoaddata_Click;
            // 
            // btnQr
            // 
            btnQr.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQr.Location = new Point(568, 397);
            btnQr.Name = "btnQr";
            btnQr.Size = new Size(101, 23);
            btnQr.TabIndex = 12;
            btnQr.Text = "QR";
            btnQr.UseVisualStyleBackColor = true;
            btnQr.Click += btnQr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQr);
            Controls.Add(btnLoaddata);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtName);
            Controls.Add(txtAlamat);
            Controls.Add(txtNo_Handphone);
            Controls.Add(lbl_noHandphone);
            Controls.Add(lbl_alamat);
            Controls.Add(lbl_nama);
            Controls.Add(lbl_dataUsers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_dataUsers;
        private Label lbl_nama;
        private Label lbl_alamat;
        private Label lbl_noHandphone;
        private TextBox txtNo_Handphone;
        private TextBox txtAlamat;
        private TextBox txtName;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoaddata;
        private Button btnQr;
    }
}