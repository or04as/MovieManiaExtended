namespace MovieMania
{
    partial class Rental
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
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.lblReturnDateVal = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblDateRentedVal = new System.Windows.Forms.Label();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.rdo3Days = new System.Windows.Forms.RadioButton();
            this.rdo7Days = new System.Windows.Forms.RadioButton();
            this.rdo14Days = new System.Windows.Forms.RadioButton();
            this.btnCurrentRentalReturn0 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSearchContainer = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pboSearchIcon = new System.Windows.Forms.PictureBox();
            this.pboMov0 = new System.Windows.Forms.PictureBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMov0)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblHomeTitle.Location = new System.Drawing.Point(12, 9);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(214, 50);
            this.lblHomeTitle.TabIndex = 11;
            this.lblHomeTitle.Text = "Rent Movie";
            // 
            // lblReturnDateVal
            // 
            this.lblReturnDateVal.AutoSize = true;
            this.lblReturnDateVal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblReturnDateVal.Location = new System.Drawing.Point(221, 308);
            this.lblReturnDateVal.Name = "lblReturnDateVal";
            this.lblReturnDateVal.Size = new System.Drawing.Size(106, 25);
            this.lblReturnDateVal.TabIndex = 20;
            this.lblReturnDateVal.Text = "28/04/2024";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblReturnDate.Location = new System.Drawing.Point(221, 278);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(120, 25);
            this.lblReturnDate.TabIndex = 21;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblDateRentedVal
            // 
            this.lblDateRentedVal.AutoSize = true;
            this.lblDateRentedVal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRentedVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblDateRentedVal.Location = new System.Drawing.Point(221, 248);
            this.lblDateRentedVal.Name = "lblDateRentedVal";
            this.lblDateRentedVal.Size = new System.Drawing.Size(106, 25);
            this.lblDateRentedVal.TabIndex = 22;
            this.lblDateRentedVal.Text = "21/04/2024";
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblDateRented.Location = new System.Drawing.Point(221, 218);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(117, 25);
            this.lblDateRented.TabIndex = 19;
            this.lblDateRented.Text = "Rental Date:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblCustomer.Location = new System.Drawing.Point(221, 86);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(101, 25);
            this.lblCustomer.TabIndex = 23;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblDuration.Location = new System.Drawing.Point(221, 154);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(93, 25);
            this.lblDuration.TabIndex = 25;
            this.lblDuration.Text = "Duration:";
            // 
            // rdo3Days
            // 
            this.rdo3Days.AutoSize = true;
            this.rdo3Days.Checked = true;
            this.rdo3Days.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rdo3Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.rdo3Days.Location = new System.Drawing.Point(226, 184);
            this.rdo3Days.Name = "rdo3Days";
            this.rdo3Days.Size = new System.Drawing.Size(85, 29);
            this.rdo3Days.TabIndex = 26;
            this.rdo3Days.TabStop = true;
            this.rdo3Days.Text = "3 Days";
            this.rdo3Days.UseVisualStyleBackColor = true;
            // 
            // rdo7Days
            // 
            this.rdo7Days.AutoSize = true;
            this.rdo7Days.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rdo7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.rdo7Days.Location = new System.Drawing.Point(317, 184);
            this.rdo7Days.Name = "rdo7Days";
            this.rdo7Days.Size = new System.Drawing.Size(85, 29);
            this.rdo7Days.TabIndex = 27;
            this.rdo7Days.Text = "7 Days";
            this.rdo7Days.UseVisualStyleBackColor = true;
            // 
            // rdo14Days
            // 
            this.rdo14Days.AutoSize = true;
            this.rdo14Days.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rdo14Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.rdo14Days.Location = new System.Drawing.Point(408, 184);
            this.rdo14Days.Name = "rdo14Days";
            this.rdo14Days.Size = new System.Drawing.Size(95, 29);
            this.rdo14Days.TabIndex = 28;
            this.rdo14Days.Text = "14 Days";
            this.rdo14Days.UseVisualStyleBackColor = true;
            // 
            // btnCurrentRentalReturn0
            // 
            this.btnCurrentRentalReturn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnCurrentRentalReturn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.btnCurrentRentalReturn0.FlatAppearance.BorderSize = 0;
            this.btnCurrentRentalReturn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCurrentRentalReturn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentRentalReturn0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentRentalReturn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnCurrentRentalReturn0.Location = new System.Drawing.Point(365, 347);
            this.btnCurrentRentalReturn0.Name = "btnCurrentRentalReturn0";
            this.btnCurrentRentalReturn0.Size = new System.Drawing.Size(120, 40);
            this.btnCurrentRentalReturn0.TabIndex = 29;
            this.btnCurrentRentalReturn0.Text = "Rent";
            this.btnCurrentRentalReturn0.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnCancel.Location = new System.Drawing.Point(226, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.pnlContent.Controls.Add(this.pnlSearchContainer);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.lblHomeTitle);
            this.pnlContent.Controls.Add(this.btnCurrentRentalReturn0);
            this.pnlContent.Controls.Add(this.pboMov0);
            this.pnlContent.Controls.Add(this.rdo14Days);
            this.pnlContent.Controls.Add(this.lblDateRented);
            this.pnlContent.Controls.Add(this.rdo7Days);
            this.pnlContent.Controls.Add(this.lblDateRentedVal);
            this.pnlContent.Controls.Add(this.rdo3Days);
            this.pnlContent.Controls.Add(this.lblReturnDate);
            this.pnlContent.Controls.Add(this.lblDuration);
            this.pnlContent.Controls.Add(this.lblReturnDateVal);
            this.pnlContent.Controls.Add(this.lblCustomer);
            this.pnlContent.Location = new System.Drawing.Point(20, 20);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(544, 431);
            this.pnlContent.TabIndex = 31;
            // 
            // pnlSearchContainer
            // 
            this.pnlSearchContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchContainer.Controls.Add(this.txtSearch);
            this.pnlSearchContainer.Controls.Add(this.pboSearchIcon);
            this.pnlSearchContainer.Location = new System.Drawing.Point(227, 116);
            this.pnlSearchContainer.Name = "pnlSearchContainer";
            this.pnlSearchContainer.Size = new System.Drawing.Size(223, 33);
            this.pnlSearchContainer.TabIndex = 31;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.txtSearch.Location = new System.Drawing.Point(33, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search....";
            // 
            // pboSearchIcon
            // 
            this.pboSearchIcon.Image = global::MovieMania.Properties.Resources.SearchImage;
            this.pboSearchIcon.Location = new System.Drawing.Point(8, 8);
            this.pboSearchIcon.Name = "pboSearchIcon";
            this.pboSearchIcon.Size = new System.Drawing.Size(17, 17);
            this.pboSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboSearchIcon.TabIndex = 0;
            this.pboSearchIcon.TabStop = false;
            // 
            // pboMov0
            // 
            this.pboMov0.ImageLocation = "https://media.themoviedb.org/t/p/w440_and_h660_face/ombsmhYUqR4qqOLOxAyr5V8hbyv.j" +
    "pg";
            this.pboMov0.Location = new System.Drawing.Point(21, 81);
            this.pboMov0.Name = "pboMov0";
            this.pboMov0.Size = new System.Drawing.Size(175, 263);
            this.pboMov0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboMov0.TabIndex = 12;
            this.pboMov0.TabStop = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnAddCustomer.Image = global::MovieMania.Properties.Resources.Plus;
            this.btnAddCustomer.Location = new System.Drawing.Point(476, 135);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(35, 35);
            this.btnAddCustomer.TabIndex = 31;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(583, 468);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.pnlContent);
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlSearchContainer.ResumeLayout(false);
            this.pnlSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMov0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.PictureBox pboMov0;
        private System.Windows.Forms.Label lblReturnDateVal;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblDateRentedVal;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.RadioButton rdo3Days;
        private System.Windows.Forms.RadioButton rdo7Days;
        private System.Windows.Forms.RadioButton rdo14Days;
        private System.Windows.Forms.Button btnCurrentRentalReturn0;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel pnlSearchContainer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pboSearchIcon;
    }
}