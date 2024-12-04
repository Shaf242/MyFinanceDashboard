using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MyProject
{
    public partial class DashboardForm : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Shafna Azhar\Documents\expense.mdf"";Integrated Security=True;Connect Timeout=30";

        public DashboardForm()
        {
            InitializeComponent();
            incomeTodayIncome();
            incomeYesterdayIncome();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void incomeTodayIncome()
        {

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);


                        income_totalIncome.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        income_totalIncome.Text = "$0.00";
                    }

                }

            }
        }

        public void incomeYesterdayIncome()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()),-1)";

                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        income_yesterdayIncome.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        income_yesterdayIncome.Text = "$0.00";
                    }
                }
            }
        }

        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

               
                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()),-1)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        income_yesterdayIncome.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        income_yesterdayIncome.Text = "$0.00";
                    }
                }
            }
        }
    }
}
