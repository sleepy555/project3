using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace project3
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        int selectedStudentId = -1;

        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection(
                @"Data Source=DESKTOP-4A2FR2S\SQLEXPRESS;
                  Initial Catalog=student;
                  Integrated Security=True;
                  Trust Server Certificate=True");

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = false;
        }

        // ================= FORM LOAD =================
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayStudents();
            updatebtn.Enabled = false;
            delbtnn.Enabled = false;
            this.BackColor = Color.FromArgb(230, 245, 255); // sky blue

            label1.ForeColor = Color.FromArgb(40, 70, 120);
            label2.ForeColor = Color.FromArgb(40, 70, 120);
            label3.ForeColor = Color.FromArgb(40, 70, 120);
            label4.ForeColor = Color.FromArgb(40, 70, 120);
            label5.ForeColor = Color.FromArgb(40, 70, 120);
            label6.ForeColor = Color.FromArgb(40, 70, 120);

            insertbtn.BackColor = Color.White;
            updatebtn.BackColor = Color.White;
            Clrbtn.BackColor = Color.White;

            delbtnn.BackColor = Color.FromArgb(255, 159, 67); // orange pop
            delbtnn.ForeColor = Color.White;

        }

        // ================= DISPLAY =================
        private void DisplayStudents()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM STU", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= CLEAR =================
        private void ResetFields()
        {
            Rollnotxt.Clear();
            Nametxt.Clear();
            Divtxt.Clear();
            Addresstxt.Clear();
            Contacttxt.Clear();

            selectedStudentId = -1;
            updatebtn.Enabled = false;
            delbtnn.Enabled = false;
        }

        // ================= INSERT =================
        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO STU (RollNo, Sname, Division, SAddress, Contact)
                      VALUES (@RollNo, @Sname, @Division, @SAddress, @Contact)", con);

                cmd.Parameters.Add("@RollNo", SqlDbType.Int).Value = int.Parse(Rollnotxt.Text);
                cmd.Parameters.Add("@Sname", SqlDbType.VarChar).Value = Nametxt.Text;
                cmd.Parameters.Add("@Division", SqlDbType.VarChar).Value = Divtxt.Text;
                cmd.Parameters.Add("@SAddress", SqlDbType.VarChar).Value = Addresstxt.Text;
                cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = Contacttxt.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student inserted successfully");
                DisplayStudents();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ================= UPDATE =================
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student first");
                return;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE STU SET
                      RollNo = @RollNo,
                      Sname = @Sname,
                      Division = @Division,
                      SAddress = @SAddress,
                      Contact = @Contact
                      WHERE StudentId = @StudentId", con);

                cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = selectedStudentId;
                cmd.Parameters.Add("@RollNo", SqlDbType.Int).Value = int.Parse(Rollnotxt.Text);
                cmd.Parameters.Add("@Sname", SqlDbType.VarChar).Value = Nametxt.Text;
                cmd.Parameters.Add("@Division", SqlDbType.VarChar).Value = Divtxt.Text;
                cmd.Parameters.Add("@SAddress", SqlDbType.VarChar).Value = Addresstxt.Text;
                cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = Contacttxt.Text;

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Student updated successfully");
                else
                    MessageBox.Show("Update failed");

                DisplayStudents();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ================= DELETE =================
        private void delbtnn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete");
                return;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM STU WHERE StudentId = @StudentId", con);

                cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = selectedStudentId;

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Student deleted successfully");
                else
                    MessageBox.Show("Delete failed");

                DisplayStudents();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ================= CLEAR BUTTON =================
        private void Clrbtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        // ================= GRID CLICK =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedStudentId = Convert.ToInt32(row.Cells[0].Value);

                Rollnotxt.Text = row.Cells[1].Value?.ToString();
                Nametxt.Text = row.Cells[2].Value?.ToString();
                Divtxt.Text = row.Cells[3].Value?.ToString();
                Addresstxt.Text = row.Cells[4].Value?.ToString();
                Contacttxt.Text = row.Cells[5].Value?.ToString();

                updatebtn.Enabled = true;
                delbtnn.Enabled = true;
            }
        }

        // ================= CLOSE =================
        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
