namespace project3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Rollnotxt = new TextBox();
            dataGridView1 = new DataGridView();
            Nametxt = new TextBox();
            label3 = new Label();
            Divtxt = new TextBox();
            label4 = new Label();
            Addresstxt = new TextBox();
            label5 = new Label();
            Contacttxt = new TextBox();
            label6 = new Label();
            insertbtn = new Button();
            Clrbtn = new Button();
            cross = new Label();
            delbtnn = new Button();
            updatebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label1.Location = new Point(364, 27);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 0;
            label1.Text = "Student Records Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 14.25F);
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 1;
            label2.Text = "Roll No";
            // 
            // Rollnotxt
            // 
            Rollnotxt.Location = new Point(47, 118);
            Rollnotxt.Name = "Rollnotxt";
            Rollnotxt.Size = new Size(134, 23);
            Rollnotxt.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(248, 239);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(433, 251);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(218, 118);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(137, 23);
            Nametxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 14.25F);
            label3.Location = new Point(218, 87);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 4;
            label3.Text = "Student Name";
            // 
            // Divtxt
            // 
            Divtxt.Location = new Point(395, 118);
            Divtxt.Name = "Divtxt";
            Divtxt.Size = new Size(137, 23);
            Divtxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 14.25F);
            label4.Location = new Point(395, 87);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 6;
            label4.Text = "Division";
            // 
            // Addresstxt
            // 
            Addresstxt.Location = new Point(562, 118);
            Addresstxt.Name = "Addresstxt";
            Addresstxt.Size = new Size(135, 23);
            Addresstxt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 14.25F);
            label5.Location = new Point(562, 87);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // Contacttxt
            // 
            Contacttxt.Location = new Point(730, 118);
            Contacttxt.Name = "Contacttxt";
            Contacttxt.Size = new Size(135, 23);
            Contacttxt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 14.25F);
            label6.Location = new Point(730, 87);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 10;
            label6.Text = "Contact No";
            // 
            // insertbtn
            // 
            insertbtn.Font = new Font("Segoe UI", 15.75F);
            insertbtn.Location = new Point(248, 179);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(93, 41);
            insertbtn.TabIndex = 11;
            insertbtn.Text = "Insert";
            insertbtn.Click += insertbtn_Click;
            // 
            // Clrbtn
            // 
            Clrbtn.Font = new Font("Segoe UI", 15.75F);
            Clrbtn.Location = new Point(588, 179);
            Clrbtn.Name = "Clrbtn";
            Clrbtn.Size = new Size(93, 41);
            Clrbtn.TabIndex = 14;
            Clrbtn.Text = "Clear";
            Clrbtn.Click += Clrbtn_Click;
            // 
            // cross
            // 
            cross.AutoSize = true;
            cross.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            cross.Location = new Point(887, -1);
            cross.Name = "cross";
            cross.Size = new Size(30, 32);
            cross.TabIndex = 16;
            cross.Text = "X";
            cross.Click += cross_Click;
            // 
            // delbtnn
            // 
            delbtnn.Font = new Font("Segoe UI", 15.75F);
            delbtnn.Location = new Point(476, 179);
            delbtnn.Name = "delbtnn";
            delbtnn.Size = new Size(93, 41);
            delbtnn.TabIndex = 13;
            delbtnn.Text = "Delete";
            delbtnn.Click += delbtnn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Font = new Font("Segoe UI", 15.75F);
            updatebtn.Location = new Point(362, 179);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(93, 41);
            updatebtn.TabIndex = 12;
            updatebtn.Text = "Update";
            updatebtn.Click += updatebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 245, 255);
            ClientSize = new Size(917, 539);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Rollnotxt);
            Controls.Add(Nametxt);
            Controls.Add(label3);
            Controls.Add(Divtxt);
            Controls.Add(label4);
            Controls.Add(Addresstxt);
            Controls.Add(label5);
            Controls.Add(Contacttxt);
            Controls.Add(label6);
            Controls.Add(insertbtn);
            Controls.Add(updatebtn);
            Controls.Add(delbtnn);
            Controls.Add(Clrbtn);
            Controls.Add(dataGridView1);
            Controls.Add(cross);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Rollnotxt;
        private DataGridView dataGridView1;
        private TextBox Nametxt;
        private Label label3;
        private TextBox Divtxt;
        private Label label4;
        private TextBox Addresstxt;
        private Label label5;
        private TextBox Contacttxt;
        private Label label6;
        private Button insertbtn;
        private Button updatebtn;
        private Button delbtnn;
        private Button Clrbtn;
        private Label cross;
    }
}
