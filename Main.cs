using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using TimeShow;

namespace Show
{
    public partial class frmMain : Form
    {
        // Aone shop helper class object

        TimeShowDBHelper showTimeShop = new TimeShowDBHelper();
  
        public frmMain()
        {
            InitializeComponent();
  
        }
        
        private void BtnUpdateCust_Click(object sender, EventArgs e)
        {   // check if customer fileds are empty
            if (tbCustFirstName.Text != "" && tbCustLastName.Text != "" && tbCustAddress.Text != "" && tbCustPhone.Text != "")
            {
                // create variables from inputs
                string firstname = tbCustFirstName.Text;
                string lastname = tbCustLastName.Text;
                string address = tbCustAddress.Text;
                string phone = tbCustPhone.Text;
                int custId = Convert.ToInt32(tbCustID.Text);
                showTimeShop.changeCustomerRecord(custId, firstname, lastname, address, phone);
                refreshCustomerListView(showTimeShop.getAllCustomerRecords());
                resetAllInputFields();    
            } else
            {
                MessageBox.Show("Customer Fields are empty","Problem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        // method to reset all input  fields
        private void resetAllInputFields()
        {
            tbCustID.Text = "";
            tbCustFirstName.Text = "";
            tbCustAddress.Text = "";
            tbCustLastName.Text = "";
            tbCustPhone.Text = "";
            tbMovieId.Text = ""; tbMovieName.Text = ""; tbMovieGenre.Text = "";
            tbMovieRating.Text = "";
            tbMovieYear.Text = ""; tbMovieCopies.Text = ""; tbMoviePlot.Text = "";
        }
        private void BtnAddCust_Click(object sender, EventArgs e)
        {
            if (tbCustFirstName.Text != "" && tbCustLastName.Text != "" && tbCustAddress.Text != "" && tbCustPhone.Text != "")
            {
        
                showTimeShop.addNewCustomerRecord(tbCustFirstName.Text, tbCustLastName.Text, tbCustAddress.Text, tbCustPhone.Text);
                refreshCustomerListView(showTimeShop.getAllCustomerRecords()); 
                resetAllInputFields();
            }
            else
            {
                MessageBox.Show("Customer Fields are empty", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteCust_Click(object sender, EventArgs e)
        {
            if(tbCustID.Text!="")
            {
                // confirm to delete customer
                int custId = Convert.ToInt32(tbCustID.Text);
                DialogResult mbresult = MessageBox.Show("Confirm to delete?", "customer", MessageBoxButtons.YesNo);
                if(mbresult.ToString()=="Yes")
                {
                    showTimeShop.deleteCustomerRecordById(custId);
                    MessageBox.Show("Deleted!");
                    refreshCustomerListView(showTimeShop.getAllCustomerRecords());
                    resetAllInputFields();
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
    // refresh all list view on form load     
            refreshCustomerListView(showTimeShop.getAllCustomerRecords());
            refreshMoviesListView(showTimeShop.getAllRecordsFromMovies());
            refreshRentsListView(showTimeShop.getAllRecordsOfRentedMovies()); // update list view


        }

    
        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            // check empty fields
            if(tbMovieName.Text!="" && tbMovieGenre.Text!="" && tbMovieRating.Text!="" && tbMovieYear.Text!="" && tbMovieCopies.Text!="" && tbMoviePlot.Text!="")
            {
                int movieYear = Convert.ToInt32(tbMovieYear.Text);
                int copies = Convert.ToInt32(tbMovieCopies.Text);
                string rent;
               // old movie rent =  2 and new movie rent =  5
               
                if(DateTime.Now.Date.Year-movieYear > 5) 
                {
                    rent = "2";
                }else
                {
                    rent = "5";
                }
                showTimeShop.addNewMovieRecord(tbMovieRating.Text, tbMovieName.Text, tbMovieYear.Text, rent, tbMoviePlot.Text, tbMovieGenre.Text, copies);
                refreshMoviesListView(showTimeShop.getAllRecordsFromMovies());
                resetAllInputFields();
            }else
            {
                MessageBox.Show("Movie Fields are empty", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            // perform check on empty fields
            if (tbMovieId.Text != "" && tbMovieName.Text != "" && tbMovieGenre.Text != "" && tbMovieRating.Text != "" && tbMovieYear.Text != "" && tbMovieCopies.Text != "" && tbMoviePlot.Text != "")
            {
                // creater variables frominputs
                int movieId = Convert.ToInt32(tbMovieId.Text);
                int copies = Convert.ToInt32(tbMovieCopies.Text);
                int year = Convert.ToInt32(tbMovieYear.Text);

                string title = tbMovieName.Text;
                string rating = tbMovieRating.Text;
                string genre = tbMovieGenre.Text;
                string plot = tbMoviePlot.Text;
                //updates movie record
                showTimeShop.changeMovieRecord(movieId, rating, title, year, plot, genre, copies);
                MessageBox.Show("Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshMoviesListView(showTimeShop.getAllRecordsFromMovies());
                resetAllInputFields();
            }else
            {
                MessageBox.Show("Movie Fileds are Empty", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnDeleteMovie_Click(object sender, EventArgs e)
        {
            if(tbMovieId.Text!="")
            {
                // confirm to delete
                DialogResult result = MessageBox.Show("Confirm to delete?", "Confirm", MessageBoxButtons.YesNo);
                if(result.ToString()=="Yes")
                {
                    int movieId = Convert.ToInt32(tbMovieId.Text);
                    // delete a movie by movieid
                    showTimeShop.deleteMovieRecordByID(movieId); 
                    refreshMoviesListView(showTimeShop.getAllRecordsFromMovies());
                    resetAllInputFields();
                }
            }
            else
            {
                MessageBox.Show("Select a movie first");
            }
        }


        private void BtnIssueMovie_Click(object sender, EventArgs e)
        {
            // check empty movie id and custid
            if(tbMovieId.Text !="" && tbCustID.Text!="")
            {
                if(tbMovieCopies.Text!="0")
                {
                    int movieId = Convert.ToInt32(tbMovieId.Text);
                    int custId = Convert.ToInt32(tbCustID.Text);
                    int copies = Convert.ToInt32(tbMovieCopies.Text);
                    //set  Dateof issue = current date and ented value to 1
                    showTimeShop.addNewRentedVideoRecord(movieId, custId, DateTime.Now, copies, 1); // adds rented movie
                    refreshRentsListView(showTimeShop.getAllRecordsOfRentedMovies()); // update list view
                    // reset all textboxes
                    resetAllInputFields();
                    

                }
                else
                {
                    MessageBox.Show("No copies of movies", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Select a customer and movie", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnReturnMovie_Click(object sender, EventArgs e)
        {
            // perform check
            if(tbMovieId.Text!="" && tbDateRented.Text!="" && tbRMID.Text!="")
            {
                int rmid = Convert.ToInt32(tbRMID.Text);
                int movieId = Convert.ToInt32(tbMovieId.Text);
                String date = tbDateRented.Text;
                // set rented = 0 and data of return = current date
                showTimeShop.updateRentedRecord(rmid, movieId, Convert.ToDateTime(date), DateTime.Now);
                
                refreshCustomerListView(showTimeShop.getAllCustomerRecords());
                refreshMoviesListView(showTimeShop.getAllRecordsFromMovies());
                refreshRentsListView(showTimeShop.getAllRecordsOfRentedMovies());
                // clears all inputs
                resetAllInputFields(); 
                resetAllInputFields(); 
                tbRMID.Text = ""; 
                tbDateRented.Text = "";
            }else
            {
                MessageBox.Show("first select a Movie to return", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // closes the main application on form closing
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        HelperFunctions helperFunctions = new HelperFunctions();

        private void BtnBestCustomer_Click(object sender, EventArgs e)
        {
            helperFunctions.findBestCustomer();
        }

        private void BtnBestMoie_Click(object sender, EventArgs e)
        {
            helperFunctions.findBestMovie();
        }

        private void LvRentedMovies_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item= lvRentedMovies.SelectedItems[0];
            tbRMID.Text = item.SubItems[0].Text;
            tbDateRented.Text = item.SubItems[3].Text;
            tbMovieId.Text = item.SubItems[1].Text;
        }

        private void LvMovies_ItemActivate(object sender, EventArgs e)
        {
     

            ListViewItem item = lvMovies.SelectedItems[0];
            tbMovieId.Text = item.SubItems[0].Text;
            tbMovieRating.Text = item.SubItems[1].Text;
            tbMovieName.Text = item.SubItems[2].Text;
            tbMovieYear.Text = item.SubItems[3].Text;
            tbMovieCopies.Text = item.SubItems[5].Text;
            tbMoviePlot.Text =  item.SubItems[6].Text;
            tbMovieGenre.Text = item.SubItems[7].Text;

        }

        private void LvCustomers_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = lvCustomers.SelectedItems[0];
            tbCustID.Text = item.SubItems[0].Text;
            tbCustFirstName.Text = item.SubItems[1].Text;
            tbCustLastName.Text = item.SubItems[2].Text;
            tbCustAddress.Text = item.SubItems[3].Text;
            tbCustPhone.Text = item.SubItems[4].Text;
        }

        private void refreshCustomerListView(DataTable d)
        {
            lvCustomers.Items.Clear();

            for (int i = 0; i < d.Rows.Count; i++)
            {


                lvCustomers.Items.Add(d.Rows[i].ItemArray[0].ToString());
                lvCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[1].ToString());
                lvCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[2].ToString());
                lvCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[3].ToString());
                lvCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[4].ToString());
            }


        }
        private void refreshMoviesListView(DataTable d)
        {
            lvMovies.Items.Clear();

            foreach (DataRow row in d.Rows)
            {
                string[] items = { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString() };
                lvMovies.Items.Add(new ListViewItem(items));
            }

        }
        private void refreshRentsListView(DataTable d)
        {
            lvRentedMovies.Items.Clear();
            foreach (DataRow row in d.Rows)
            {
                string[] items = { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() };
                lvRentedMovies.Items.Add(new ListViewItem(items));
            }

        }

        private void BtnCloseWin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
