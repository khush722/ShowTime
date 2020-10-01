using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeShow
{
   public class TimeShowDBHelper
    {
        // SQLClient objects for db operations
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8PLOII5;Initial Catalog=ShowTime;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=ShowTime;Integrated Security=True");
        SqlDataReader reader;
        SqlCommand cmd = new SqlCommand();
        string q = "";

        // function to get all the records of rented movies from database
        public DataTable getAllRecordsOfRentedMovies()
        {
            DataTable tmp = new DataTable();
            try
            {
                cmd.Connection = conn;
                q = "SELECT * FROM RentedMovies Order by RMID DESC";
                cmd.CommandText = q;
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    tmp.Load(reader);
                }
                return tmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        // function to add a new rented record with rented status =1
        public void addNewRentedVideoRecord(int MovieIDFK, int CustIDFK, DateTime dateRented, int copies, int rented)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                // Query to insert data into rentedmovies table
                q = "INSERT INTO RentedMovies(MovieIDFK, CustIDFK, DateRented,Rented) VALUES (@MovieIDFK,@CustIDFK,@DateRented,@Rented)";
                cmd.Parameters.AddWithValue("@MovieIDFK", MovieIDFK);
                cmd.Parameters.AddWithValue("@CustIDFK", CustIDFK);
                cmd.Parameters.AddWithValue("@DateRented", dateRented);
                cmd.Parameters.AddWithValue("@Rented", rented);
                cmd.CommandText = q;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        // function to update rented movie record with date returned ( Return Movie)
        public void updateRentedRecord(int RMID, int MovieID, DateTime dateRented, DateTime dateReturned)
        {
            try
            {
                // clear previous parameters
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                int totalRent = 0, MovieCost = 0;
                // customer movie rented days
                double rentedDays = (dateReturned - dateRented).TotalDays;
                q = "SELECT Rental_Cost FROM Movies WHERE MovieID = @MovieIDFK";
                cmd.Parameters.AddWithValue("@MovieIDFK", MovieID);
                cmd.CommandText = q;
                conn.Open();
                MovieCost = Convert.ToInt32(cmd.ExecuteScalar());
              
                if (Convert.ToInt32(rentedDays) == 0)
                {
                   // if movie is rented for one day only
                    totalRent = MovieCost;
                }
                else
                // if movie is rented for more than one day
                {
                    totalRent = Convert.ToInt32(rentedDays) * MovieCost;
                }
                // update date of return in db
                q = "UPDATE RentedMovies SET DateReturned = @DateReturned WHERE RMID = @RMID";
                cmd.Parameters.AddWithValue("@DateReturned", dateReturned);
                cmd.Parameters.AddWithValue("@RMID", RMID);
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();

                // copies = copies-1
                q = "UPDATE Movies SET copies = copies+1 WHERE MovieID = @MovieIDFK";
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                // Update rented status
                q = "UPDATE RentedMovies SET Rented = 0 WHERE RMID = @RMID";
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                // Total rent of customer
                MessageBox.Show("Please Collect  Rent " + totalRent+" From customer","total rent",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Exception: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    
            //show movies in list view
        public DataTable getAllRecordsFromMovies()
        { 
            DataTable tmp = new DataTable();
            try
            {
                cmd.Connection = conn;
                q = "Select * from Movies";

                cmd.CommandText = q;
                //open connection
                conn.Open();

                // reader execute from command
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    tmp.Load(reader);
                }
                return tmp;
            }
            catch (Exception ex)
            {
                // display message
                MessageBox.Show("Database Exception" + ex.Message);
                return null;
            }
            finally
            {
                // close reader object
                if (reader != null)
                {
                    reader.Close();
                }

                // connection close finally
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

            // add new movie record in database
        public void addNewMovieRecord(string Rating, string Title, string Year, string Rental_Cost, string Plot, string Genre, int copies)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                //query to insert record
                q = "Insert into Movies(Rating, Title, Year, Rental_Cost, Plot, Genre, copies) Values( @Rating, @Title, @Year, @Rental_Cost, @Plot, @Genre, @copies)";
                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Year", Year);
                cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                cmd.Parameters.AddWithValue("@Plot", Plot);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@copies", copies);

                cmd.CommandText = q;

                // open connection
                conn.Open();

                // query execute
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // display error
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // close connection finally
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // function to delete movie record by using id
        public void deleteMovieRecordByID(int MovieID)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = conn;


                // check if movie is rented before deleting it
                String q = "select Count(*) from RentedMovies where MovieIDFK = @MovieID and Rented ='1' ";
                SqlParameter[] parameterArray = new SqlParameter[] { new SqlParameter("@MovieID", MovieID) };
                cmd.Parameters.Add(parameterArray[0]);

                cmd.CommandText = q;
                conn.Open();
                //delete movie if !rented
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    String k = "Delete from Movies where MovieID like @MovieID";
                    cmd.CommandText = k;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie Deleted", "total rent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //display the message if he has a movie on rent 
                    MessageBox.Show("Movie is not deleted because is rented by a customer", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception" + exception.Message);
            }
            finally
            {
                if (this.conn != null)
                {
                    this.conn.Close();
                }

            }
        }



            //function to change moive Record in  database
        public void changeMovieRecord(int MovieID, string Rating, string Title, int Year, string Plot, string Genre, int copies)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                // query to update movies record
                q = "Update Movies Set Rating = @Rating, Title = @Title, Year = @Year,  Plot = @Plot, Genre = @Genre, copies = @copies where MovieID like @MovieID";
               // set movie parameters
                cmd.Parameters.AddWithValue("@MovieID", MovieID);
                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Year", Year);
                cmd.Parameters.AddWithValue("@Plot", Plot);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@copies", copies);

                cmd.CommandText = q;

                //open db connection
                conn.Open();

                // Execute non query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // display error exception
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // close connection finally
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
 
        public DataTable getAllCustomerRecords()
        {
            DataTable dtAllCustomerRecords = new DataTable();
            try
            {
                cmd.Connection = conn;
                q = "SELECT * from Customer";
                cmd.CommandText = q;
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dtAllCustomerRecords.Load(reader);
                }
                return dtAllCustomerRecords;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // function to insert new customer record
        public void addNewCustomerRecord(string firstname, string lastname, string address, string phone)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                q = "INSERT INTO Customer(FirstName,LastName,Address,Phone) VALUES (@fname,@lname,@addr,@phone)";
                cmd.Parameters.AddWithValue("@fname", firstname);
                cmd.Parameters.AddWithValue("@lname", lastname);
                cmd.Parameters.AddWithValue("@addr", address);
                cmd.Parameters.AddWithValue("@phone", phone);

                cmd.CommandText = q;

                conn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                // close objects finally
                if (conn != null)
                {
                    conn.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        // function to delete customer record by id
        public void deleteCustomerRecordById(int id)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                q = "SELECT Count(*) FROM RentedMovies WHERE CustIDFK=@custid";
                cmd.Parameters.AddWithValue("@custid", id);
                cmd.CommandText = q;
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    q = "DELETE FROM Customer WHERE CustID = @custid";
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Record cannot be deleted. customer has rented a movie", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
            //function to update customer record in db
        public void changeCustomerRecord(int CustID, string FirstName, string LastName, string Address, string Phone)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                q = "Update Customer Set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone where CustID = @CustID";


                cmd.Parameters.AddWithValue("@CustID", CustID);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone", Phone);

                cmd.CommandText = q;

                //connection opened
                conn.Open();

                // Executed query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // show error Message
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
       
        // function to test database connection
        public bool testDatabaseConnection()
        {
            if(conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            return true;
        }
       
    }
}
