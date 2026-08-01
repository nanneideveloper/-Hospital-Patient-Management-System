using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CaseStudy
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\Patient.mdf;Integrated Security=True;Connect Timeout=30";

                conn = new SqlConnection(constring);
                conn.Open();

                LoadIds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (tbname.Text == "")
            {
                MessageBox.Show("Please enter patient name.");
                return;
            }

            try
            {
                string gen = rdbmale.Checked ? "Male" : "Female";

                string birthdate = dtpbirth.Value.ToString("yyyy-MM-dd");
                string admissiondate = dtpadmission.Value.ToString("yyyy-MM-dd");

                string qry =
                $"Insert Into PatientRegistration(Name,BirthDate,Age,Gender,Contact,Address,EmergContact,EmergAdd,Relationship,BloodType,Disease,Doctor,DateofAdmission) " +
                $"values('{tbname.Text}','{birthdate}','{tbage.Text}','{gen}','{tbcontact.Text}','{tbadd.Text}','{tbemcontact.Text}','{tbemadd.Text}','{tbrelationship.Text}','{cmbblood.Text}','{cmbdisease.Text}','{cmbdoctor.Text}','{admissiondate}')";

                cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Saved Successfully.");

                LoadIds();
                btnclear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "")
            {
                MessageBox.Show("Select Record.");
                return;
            }

            try
            {
                string gen = rdbmale.Checked ? "Male" : "Female";

                string birthdate = dtpbirth.Value.ToString("yyyy-MM-dd");
                string admissiondate = dtpadmission.Value.ToString("yyyy-MM-dd");

                string qry =
                $"Update PatientRegistration Set " +
                $"Name='{tbname.Text}'," +
                $"BirthDate='{birthdate}'," +
                $"Age='{tbage.Text}'," +
                $"Gender='{gen}'," +
                $"Contact='{tbcontact.Text}'," +
                $"Address='{tbadd.Text}'," +
                $"EmergContact='{tbemcontact.Text}'," +
                $"EmergAdd='{tbemadd.Text}'," +
                $"Relationship='{tbrelationship.Text}'," +
                $"BloodType='{cmbblood.Text}'," +
                $"Disease='{cmbdisease.Text}'," +
                $"Doctor='{cmbdoctor.Text}'," +
                $"DateofAdmission='{admissiondate}' " +
                $"Where Id={tbid.Text}";

                cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully.");

                LoadIds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "")
            {
                MessageBox.Show("Select Record.");
                return;
            }

            if (MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string qry = $"Delete From PatientRegistration Where Id={tbid.Text}";

                    cmd = new SqlCommand(qry, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Deleted Successfully.");

                    LoadIds();
                    btnclear.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * From PatientRegistration";

                SqlDataAdapter da = new SqlDataAdapter(qry, conn);

                DataTable table = new DataTable();

                da.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbid.Clear();
            tbname.Clear();
            tbage.Clear();
            tbcontact.Clear();
            tbadd.Clear();
            tbemcontact.Clear();
            tbemadd.Clear();
            tbrelationship.Clear();

            cmbblood.SelectedIndex = -1;
            cmbdisease.SelectedIndex = -1;
            cmbdoctor.SelectedIndex = -1;

            rdbmale.Checked = true;
            rdbfemale.Checked = false;

            dtpbirth.Value = DateTime.Now;
            dtpadmission.Value = DateTime.Now;

            tbname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpbirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dtpbirth.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
                age--;

            tbage.Text = age.ToString();
        }

        private void LoadIds()
        {
            try
            {
                string qry = "Select * From PatientRegistration";

                SqlDataAdapter da = new SqlDataAdapter(qry, conn);

                dt.Clear();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    index = 0;
                    FillData(index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillData(int ind)
        {
            if (dt.Rows.Count == 0)
                return;

            tbid.Text = dt.Rows[ind]["Id"].ToString();
            tbname.Text = dt.Rows[ind]["Name"].ToString();

            dtpbirth.Value = Convert.ToDateTime(dt.Rows[ind]["BirthDate"]);

            tbage.Text = dt.Rows[ind]["Age"].ToString();

            string gender = dt.Rows[ind]["Gender"].ToString();

            rdbmale.Checked = gender == "Male";
            rdbfemale.Checked = gender == "Female";

            tbcontact.Text = dt.Rows[ind]["Contact"].ToString();
            tbadd.Text = dt.Rows[ind]["Address"].ToString();
            tbemcontact.Text = dt.Rows[ind]["EmergContact"].ToString();
            tbemadd.Text = dt.Rows[ind]["EmergAdd"].ToString();
            tbrelationship.Text = dt.Rows[ind]["Relationship"].ToString();

            cmbblood.Text = dt.Rows[ind]["BloodType"].ToString();
            cmbdisease.Text = dt.Rows[ind]["Disease"].ToString();
            cmbdoctor.Text = dt.Rows[ind]["Doctor"].ToString();

            dtpadmission.Value = Convert.ToDateTime(dt.Rows[ind]["DateofAdmission"]);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (index < dt.Rows.Count - 1)
            {
                index++;
                FillData(index);
            }
            else
            {
                MessageBox.Show("Last Record");
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                FillData(index);
            }
            else
            {
                MessageBox.Show("First Record");
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                index = 0;
                FillData(index);
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                index = dt.Rows.Count - 1;
                FillData(index);
            }
        }
    }
}