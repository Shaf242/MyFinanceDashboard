using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProject
{
    public partial class CategoryForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Shafna Azhar\Documents\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        public CategoryForm()
        {
            InitializeComponent();

            displayCategoryList();
        }

        public void displayCategoryList()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listData = cData.categoryListData();

            dataGridView1.DataSource = listData;

        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void category_addBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1) 
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO categories (category, type, status, date_insert) " +
                        "VALUES(@cat, @type, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", category_type.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", category_status.Text.Trim());

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields(); 

                        MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connect.Close();

                }
            }

            displayCategoryList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                category_category.Text = row.Cells[1].Value.ToString();
                category_type.SelectedItem = row.Cells[2].Value.ToString();
                category_status.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void category_updateBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
            else
            {

                if(MessageBox.Show("Are you sure you want to to Update ID:" + getID + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string insertData = "UPDATE categories SET category = @type, status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", category_type.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", category_status.Text.Trim());

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();

                    }
                }
                
            }

            displayCategoryList();

        }
        public void clearFields()
        {
            category_category.Text = "";
            category_type.SelectedIndex = -1;
            category_status.SelectedIndex = -1;
        }
        private void category_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_deleteBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
            else
            {

                if (MessageBox.Show("Are you sure you want to to Delete ID:" + getID + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string insertData = "DELETE FROM categories WHERE id =@id";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                           
                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();

                    }
                }

            }

            displayCategoryList();
        }
    }
}
