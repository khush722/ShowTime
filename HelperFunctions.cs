using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeShow
{
    class HelperFunctions
    {
        SqlConnection connHelper = new SqlConnection("Data Source = Cyber\\SQLExpress; Initial Catalog = Rent; Integrated Security = True");
        SqlCommand cmdHelper = new SqlCommand();

        string query;

            // find best customer
        public void findBestCustomer()
        {
            int Top = 0, Max = 0, Total = 0;
            string Value = "";
            try
            {
                cmdHelper.Parameters.Clear();
                cmdHelper.Connection = connHelper;
                string Val = "Select IDENT_CURRENT('Customer')";

                cmdHelper.CommandText = Val;
                connHelper.Open();
                Total = Convert.ToInt32(cmdHelper.ExecuteScalar());

                for (int i = 1; i <= Total; i++)
                {

                    Value = "select Count(*) from RentedMovies where CustIDFK= '" + i + "'";


                    cmdHelper.CommandText = Value;
                    int count = Convert.ToInt32(cmdHelper.ExecuteScalar());
                    if (count > Max)
                    {
                        Max = count;
                        Top = i;
                    }
                }
                this.query = "Select FirstName from Customer where CustID ='" + Top + "'";
                this.cmdHelper.CommandText = this.query;
                String FirstName = Convert.ToString(cmdHelper.ExecuteScalar());
                MessageBox.Show("Customer:  " + FirstName + "\n Rented Movies: " + Max, "Top Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception " + exception.Message);
            }
            finally
            {
                if (connHelper != null)
                {
                    connHelper.Close();
                }
            }

        }


            // find best movie 
        public void findBestMovie()
        {
            int Top = 0, Max = 0, Total = 0;
            string Value = "";
            try
            {
                cmdHelper.Parameters.Clear();
                cmdHelper.Connection = connHelper;
                string Val = "Select IDENT_CURRENT('Movies')";

                cmdHelper.CommandText = Val;
                connHelper.Open();
                Total = Convert.ToInt32(cmdHelper.ExecuteScalar());

                for (int i = 1; i <= Total; i++)
                {

                    Value = "select Count(*) from RentedMovies where MovieIDFK= '" + i + "'";


                    cmdHelper.CommandText = Value;
                    int count = Convert.ToInt32(cmdHelper.ExecuteScalar());
                    if (count > Max)
                    {
                        Max = count;
                        Top = i;
                    }
                }


                this.query = "Select Title from Movies where MovieID ='" + Top + "'";
                this.cmdHelper.CommandText = this.query;
                String Title = Convert.ToString(cmdHelper.ExecuteScalar());
                MessageBox.Show("Movie Name: " + Title + "\nRented: " + Max+" times", "Best Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception " + exception.Message);
            }
            finally
            {
                if (connHelper != null)
                {
                    connHelper.Close();
                }
            }

        }
    }
}
