namespace Show
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBestCustomer = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.tbCustFirstName = new System.Windows.Forms.TextBox();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbCustLastName = new System.Windows.Forms.TextBox();
            this.tbCustPhone = new System.Windows.Forms.TextBox();
            this.tbCustAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnBestMoie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.tbMovieCopies = new System.Windows.Forms.TextBox();
            this.tbMovieGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMovieId = new System.Windows.Forms.TextBox();
            this.tbMovieRating = new System.Windows.Forms.TextBox();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMovieYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMoviePlot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRMID = new System.Windows.Forms.TextBox();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.tbDateRented = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lvRentedMovies = new System.Windows.Forms.ListView();
            this.RMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMovies = new System.Windows.Forms.ListView();
            this.MovieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Copies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.CustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCloseWin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBestCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBestCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnBestCustomer.Location = new System.Drawing.Point(16, 509);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.Size = new System.Drawing.Size(120, 41);
            this.btnBestCustomer.TabIndex = 14;
            this.btnBestCustomer.Text = "Most Frequent Customer";
            this.btnBestCustomer.UseVisualStyleBackColor = false;
            this.btnBestCustomer.Click += new System.EventHandler(this.BtnBestCustomer_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCust.ForeColor = System.Drawing.Color.Black;
            this.btnAddCust.Location = new System.Drawing.Point(1152, 360);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(53, 27);
            this.btnAddCust.TabIndex = 11;
            this.btnAddCust.Text = "ADD";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.BtnAddCust_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCust.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCust.Location = new System.Drawing.Point(1026, 390);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(95, 25);
            this.btnUpdateCust.TabIndex = 12;
            this.btnUpdateCust.Text = "UPDATE";
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.BtnUpdateCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCust.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCust.Location = new System.Drawing.Point(1126, 389);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(78, 26);
            this.btnDeleteCust.TabIndex = 13;
            this.btnDeleteCust.Text = "DELETE";
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            this.btnDeleteCust.Click += new System.EventHandler(this.BtnDeleteCust_Click);
            // 
            // tbCustFirstName
            // 
            this.tbCustFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCustFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustFirstName.Location = new System.Drawing.Point(796, 365);
            this.tbCustFirstName.Name = "tbCustFirstName";
            this.tbCustFirstName.Size = new System.Drawing.Size(139, 20);
            this.tbCustFirstName.TabIndex = 4;
            // 
            // tbCustID
            // 
            this.tbCustID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustID.Location = new System.Drawing.Point(660, 366);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.ReadOnly = true;
            this.tbCustID.Size = new System.Drawing.Size(63, 20);
            this.tbCustID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(637, 366);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(726, 368);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(938, 369);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // tbCustLastName
            // 
            this.tbCustLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCustLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustLastName.Location = new System.Drawing.Point(1006, 366);
            this.tbCustLastName.Name = "tbCustLastName";
            this.tbCustLastName.Size = new System.Drawing.Size(140, 20);
            this.tbCustLastName.TabIndex = 6;
            // 
            // tbCustPhone
            // 
            this.tbCustPhone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCustPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustPhone.Location = new System.Drawing.Point(688, 390);
            this.tbCustPhone.Name = "tbCustPhone";
            this.tbCustPhone.Size = new System.Drawing.Size(124, 20);
            this.tbCustPhone.TabIndex = 7;
            // 
            // tbCustAddress
            // 
            this.tbCustAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCustAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustAddress.Location = new System.Drawing.Point(881, 392);
            this.tbCustAddress.Name = "tbCustAddress";
            this.tbCustAddress.Size = new System.Drawing.Size(140, 20);
            this.tbCustAddress.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(639, 394);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(823, 394);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // btnBestMoie
            // 
            this.btnBestMoie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBestMoie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBestMoie.ForeColor = System.Drawing.Color.Black;
            this.btnBestMoie.Location = new System.Drawing.Point(13, 556);
            this.btnBestMoie.Name = "btnBestMoie";
            this.btnBestMoie.Size = new System.Drawing.Size(123, 39);
            this.btnBestMoie.TabIndex = 33;
            this.btnBestMoie.Text = "Most Frequent Movie";
            this.btnBestMoie.UseVisualStyleBackColor = false;
            this.btnBestMoie.Click += new System.EventHandler(this.BtnBestMoie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMovie.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovie.Location = new System.Drawing.Point(475, 367);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(68, 27);
            this.btnAddMovie.TabIndex = 24;
            this.btnAddMovie.Text = "ADD";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMovie.Location = new System.Drawing.Point(540, 367);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(84, 27);
            this.btnUpdateMovie.TabIndex = 25;
            this.btnUpdateMovie.Text = "UPDATE";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(381, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Copies";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMovie.Location = new System.Drawing.Point(475, 394);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(149, 27);
            this.btnDeleteMovie.TabIndex = 26;
            this.btnDeleteMovie.Text = "DELETE";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.BtnDeleteMovie_Click);
            // 
            // tbMovieCopies
            // 
            this.tbMovieCopies.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMovieCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieCopies.Location = new System.Drawing.Point(429, 396);
            this.tbMovieCopies.Name = "tbMovieCopies";
            this.tbMovieCopies.Size = new System.Drawing.Size(33, 20);
            this.tbMovieCopies.TabIndex = 31;
            // 
            // tbMovieGenre
            // 
            this.tbMovieGenre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMovieGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieGenre.Location = new System.Drawing.Point(258, 395);
            this.tbMovieGenre.Name = "tbMovieGenre";
            this.tbMovieGenre.Size = new System.Drawing.Size(116, 20);
            this.tbMovieGenre.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(382, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Rating";
            // 
            // tbMovieId
            // 
            this.tbMovieId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMovieId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieId.Location = new System.Drawing.Point(43, 371);
            this.tbMovieId.Name = "tbMovieId";
            this.tbMovieId.ReadOnly = true;
            this.tbMovieId.Size = new System.Drawing.Size(47, 20);
            this.tbMovieId.TabIndex = 14;
            // 
            // tbMovieRating
            // 
            this.tbMovieRating.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMovieRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieRating.Location = new System.Drawing.Point(429, 374);
            this.tbMovieRating.Name = "tbMovieRating";
            this.tbMovieRating.Size = new System.Drawing.Size(25, 20);
            this.tbMovieRating.TabIndex = 29;
            // 
            // tbMovieName
            // 
            this.tbMovieName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMovieName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieName.Location = new System.Drawing.Point(43, 395);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(168, 20);
            this.tbMovieName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(227, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Plot";
            // 
            // tbMovieYear
            // 
            this.tbMovieYear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMovieYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMovieYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieYear.Location = new System.Drawing.Point(128, 374);
            this.tbMovieYear.Name = "tbMovieYear";
            this.tbMovieYear.Size = new System.Drawing.Size(89, 20);
            this.tbMovieYear.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(89, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Year";
            // 
            // tbMoviePlot
            // 
            this.tbMoviePlot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMoviePlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMoviePlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoviePlot.Location = new System.Drawing.Point(258, 369);
            this.tbMoviePlot.Name = "tbMoviePlot";
            this.tbMoviePlot.Size = new System.Drawing.Size(116, 20);
            this.tbMoviePlot.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(296, 729);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Rented Movie ID";
            // 
            // tbRMID
            // 
            this.tbRMID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbRMID.Location = new System.Drawing.Point(405, 725);
            this.tbRMID.Name = "tbRMID";
            this.tbRMID.Size = new System.Drawing.Size(83, 20);
            this.tbRMID.TabIndex = 33;
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIssueMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Black;
            this.btnIssueMovie.Location = new System.Drawing.Point(1138, 556);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(122, 28);
            this.btnIssueMovie.TabIndex = 28;
            this.btnIssueMovie.Text = "ISSUE";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.BtnIssueMovie_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(568, 730);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Date Rented";
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReturnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnMovie.ForeColor = System.Drawing.Color.Black;
            this.btnReturnMovie.Location = new System.Drawing.Point(1138, 524);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(122, 26);
            this.btnReturnMovie.TabIndex = 27;
            this.btnReturnMovie.Text = "RETURN";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.BtnReturnMovie_Click);
            // 
            // tbDateRented
            // 
            this.tbDateRented.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDateRented.Location = new System.Drawing.Point(660, 725);
            this.tbDateRented.Name = "tbDateRented";
            this.tbDateRented.Size = new System.Drawing.Size(116, 20);
            this.tbDateRented.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(224, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 38);
            this.label10.TabIndex = 1;
            this.label10.Text = "MOVIES";
            // 
            // lvRentedMovies
            // 
            this.lvRentedMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RMID,
            this.MovieIDFK,
            this.CustIDFK,
            this.DateRented,
            this.DateReturned,
            this.Rented});
            this.lvRentedMovies.FullRowSelect = true;
            this.lvRentedMovies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRentedMovies.HideSelection = false;
            this.lvRentedMovies.Location = new System.Drawing.Point(159, 460);
            this.lvRentedMovies.Name = "lvRentedMovies";
            this.lvRentedMovies.Size = new System.Drawing.Size(962, 259);
            this.lvRentedMovies.TabIndex = 1;
            this.lvRentedMovies.UseCompatibleStateImageBehavior = false;
            this.lvRentedMovies.View = System.Windows.Forms.View.Details;
            this.lvRentedMovies.ItemActivate += new System.EventHandler(this.LvRentedMovies_ItemActivate);
            // 
            // RMID
            // 
            this.RMID.Text = "RMID";
            // 
            // MovieIDFK
            // 
            this.MovieIDFK.Text = "MovieIDFK";
            this.MovieIDFK.Width = 75;
            // 
            // CustIDFK
            // 
            this.CustIDFK.Text = "CustIDFK";
            this.CustIDFK.Width = 79;
            // 
            // DateRented
            // 
            this.DateRented.Text = "DateRented";
            this.DateRented.Width = 131;
            // 
            // DateReturned
            // 
            this.DateReturned.Text = "DateReturned";
            this.DateReturned.Width = 147;
            // 
            // Rented
            // 
            this.Rented.Text = "Rented";
            // 
            // lvMovies
            // 
            this.lvMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieID,
            this.Rating,
            this.Title,
            this.Year,
            this.Rental_Cost,
            this.Copies,
            this.Plot,
            this.Genre});
            this.lvMovies.FullRowSelect = true;
            this.lvMovies.HideSelection = false;
            this.lvMovies.Location = new System.Drawing.Point(12, 43);
            this.lvMovies.Name = "lvMovies";
            this.lvMovies.Size = new System.Drawing.Size(612, 317);
            this.lvMovies.TabIndex = 0;
            this.lvMovies.UseCompatibleStateImageBehavior = false;
            this.lvMovies.View = System.Windows.Forms.View.Details;
            this.lvMovies.ItemActivate += new System.EventHandler(this.LvMovies_ItemActivate);
            // 
            // MovieID
            // 
            this.MovieID.Text = "MovieID";
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 98;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.Text = "Cost";
            // 
            // Copies
            // 
            this.Copies.Text = "Copies";
            // 
            // Plot
            // 
            this.Plot.Text = "Plot";
            this.Plot.Width = 146;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            // 
            // lvCustomers
            // 
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustID,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone});
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.HideSelection = false;
            this.lvCustomers.Location = new System.Drawing.Point(636, 43);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(569, 317);
            this.lvCustomers.TabIndex = 1;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            this.lvCustomers.ItemActivate += new System.EventHandler(this.LvCustomers_ItemActivate);
            // 
            // CustID
            // 
            this.CustID.Text = "CustID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 71;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 146;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(805, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 38);
            this.label12.TabIndex = 43;
            this.label12.Text = "CUSTOMERS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(495, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 38);
            this.label11.TabIndex = 44;
            this.label11.Text = "MOVIES ON RENT";
            // 
            // btnCloseWin
            // 
            this.btnCloseWin.BackColor = System.Drawing.Color.Red;
            this.btnCloseWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWin.ForeColor = System.Drawing.Color.Black;
            this.btnCloseWin.Location = new System.Drawing.Point(1223, 2);
            this.btnCloseWin.Name = "btnCloseWin";
            this.btnCloseWin.Size = new System.Drawing.Size(58, 46);
            this.btnCloseWin.TabIndex = 45;
            this.btnCloseWin.Text = "X";
            this.btnCloseWin.UseVisualStyleBackColor = false;
            this.btnCloseWin.Click += new System.EventHandler(this.BtnCloseWin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1286, 749);
            this.Controls.Add(this.btnCloseWin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.tbCustAddress);
            this.Controls.Add(this.btnUpdateCust);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.tbCustFirstName);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbDateRented);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbMoviePlot);
            this.Controls.Add(this.tbCustID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCustPhone);
            this.Controls.Add(this.tbMovieCopies);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbMovieGenre);
            this.Controls.Add(this.tbCustLastName);
            this.Controls.Add(this.lvRentedMovies);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvMovies);
            this.Controls.Add(this.tbMovieId);
            this.Controls.Add(this.tbRMID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.tbMovieRating);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBestCustomer);
            this.Controls.Add(this.tbMovieYear);
            this.Controls.Add(this.btnBestMoie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOne Movie Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbCustFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbCustLastName;
        private System.Windows.Forms.TextBox tbCustPhone;
        private System.Windows.Forms.TextBox tbCustAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.TextBox tbMovieId;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.TextBox tbMovieGenre;
        private System.Windows.Forms.TextBox tbMovieYear;
        private System.Windows.Forms.TextBox tbMoviePlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.TextBox tbMovieRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMovieCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRMID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDateRented;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBestCustomer;
        private System.Windows.Forms.Button btnBestMoie;
        private System.Windows.Forms.ListView lvRentedMovies;
        private System.Windows.Forms.ColumnHeader RMID;
        private System.Windows.Forms.ColumnHeader MovieIDFK;
        private System.Windows.Forms.ColumnHeader CustIDFK;
        private System.Windows.Forms.ColumnHeader DateRented;
        private System.Windows.Forms.ColumnHeader DateReturned;
        private System.Windows.Forms.ColumnHeader Rented;
        private System.Windows.Forms.ListView lvMovies;
        private System.Windows.Forms.ColumnHeader MovieID;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Rental_Cost;
        private System.Windows.Forms.ColumnHeader Copies;
        private System.Windows.Forms.ColumnHeader Plot;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader CustID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCloseWin;
    }
}

