using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace project3
{
    public partial class Form1 : Form
    {
        SqlConnection con;

        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection(
                @"Data Source=DESKTOP-4A2FR2S\SQLEXPRESS;
                  Initial Catalog=student;
                  Integrated Security=True;
                  Trust Server Certificate=True"
            );

            // IMPORTANT SETTINGS
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        // 🔹 FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        // 🔹 DISPLAY DATA
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

        // 🔹 CLEAR TEXTBOXES
        private void ResetFields()
        {
            Rollnotxt.Clear();
            Nametxt.Clear();
            Divtxt.Clear();
            Addresstxt.Clear();
            Contacttxt.Clear();
        }

        // 🔹 INSERT
        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO STU (RollNo, Sname, Division, SAddress, Contact)
                      VALUES (@RollNo, @Sname, @Division, @SAddress, @Contact)", con);

                cmd.Parameters.AddWithValue("@RollNo", Rollnotxt.Text);
                cmd.Parameters.AddWithValue("@Sname", Nametxt.Text);
                cmd.Parameters.AddWithValue("@Division", Divtxt.Text);
                cmd.Parameters.AddWithValue("@SAddress", Addresstxt.Text);
                cmd.Parameters.AddWithValue("@Contact", Contacttxt.Text);

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

        // 🔹 UPDATE
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please double-click a student to update");
                return;
            }

            int studentId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["StudentId"].Value);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE STU SET 
                        RollNo=@RollNo,
                        Sname=@Sname,
                        Division=@Division,
                        SAddress=@SAddress,
                        Contact=@Contact
                      WHERE StudentId=@StudentId", con);

                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@RollNo", Rollnotxt.Text);
                cmd.Parameters.AddWithValue("@Sname", Nametxt.Text);
                cmd.Parameters.AddWithValue("@Division", Divtxt.Text);
                cmd.Parameters.AddWithValue("@SAddress", Addresstxt.Text);
                cmd.Parameters.AddWithValue("@Contact", Contacttxt.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student updated successfully");
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

        // 🔹 DELETE
        private void Delbtnn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete");
                return;
            }

            int studentId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["StudentId"].Value);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM STU WHERE StudentId=@StudentId", con);

                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student deleted successfully");
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

        // 🔹 DOUBLE CLICK → LOAD DATA INTO TEXTBOXES (KEY PART)
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                Rollnotxt.Text = row.Cells["RollNo"].Value.ToString();
                Nametxt.Text = row.Cells["Sname"].Value.ToString();
                Divtxt.Text = row.Cells["Division"].Value.ToString();
                Addresstxt.Text = row.Cells["SAddress"].Value.ToString();
                Contacttxt.Text = row.Cells["Contact"].Value.ToString();
            }
        }

        // 🔹 CLEAR BUTTON
        private void Clrbtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delbtnn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete");
                return;
            }

            int studentId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["StudentId"].Value);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM STU WHERE StudentId=@StudentId", con);

                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student deleted successfully");
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
    }
}
