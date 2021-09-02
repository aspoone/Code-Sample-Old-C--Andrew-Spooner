using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------
        // Global Book object
        //----------------------------------------------------------

        Book myBook = new Book();

        //----------------------------------------------------------
        // Add author names to Book object and list box
        // Clear text box for additional names
        //----------------------------------------------------------
        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            myBook.addAuthor(firstNameText.Text, mIText.Text, lastNameText.Text);
            authorOutput.Items.Add(firstNameText.Text + " " + mIText.Text + " " + lastNameText.Text);

            firstNameText.Clear();
            mIText.Clear();
            lastNameText.Clear();
            firstNameText.Focus();
        }

        //----------------------------------------------------------
        // Add Book information to Book object
        // Enable button to view reference styles
        //----------------------------------------------------------
        private void addBookButton_Click(object sender, EventArgs e)
        {
            int month;
            int day;
            int year;

            int.TryParse(monthText.Text, out month);
            int.TryParse(dayText.Text, out day);
            int.TryParse(yearText.Text, out year);

            myBook.ReferencePublicationDate.setDate(month, day, year);

            myBook.ReferenceTitle.Name = bookTitleText.Text;


            myBook.Publisher = bookPublisherText.Text;
            myBook.City = cityText.Text;
            myBook.State = stateText.Text;
            myBook.Country = countryText.Text;

            if (myBook.AuthorNames.Count > 0)
            {
                mLAStyleButton.Enabled = true;
                aPAStyleButton.Enabled = true;
                libMedStyleButton.Enabled = true;
                addReferenceButton.Enabled = true;
            }
        }

        //----------------------------------------------------------
        // Show the MLA style
        // In the rich text box
        //----------------------------------------------------------
        private void mLAStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Clear();
            string reference = myBook.formatMLA();
            myBook.setItalicTitle(styleOutput, reference);
        }

        //----------------------------------------------------------
        // Show the APA style
        // In the rich text box
        //----------------------------------------------------------
        private void aPAStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Clear();
            string reference = myBook.formatAPA();
            myBook.setItalicTitle(styleOutput, reference);
        }

        //----------------------------------------------------------
        // Show the LibMed style
        // In the rich text box
        //----------------------------------------------------------
        private void libMedStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Text = myBook.formatLibMed();
        }

        //----------------------------------------------------------
        // Clear the form
        // In preparation for another Book reference
        //----------------------------------------------------------
        private void addAnotherBookButton_Click(object sender, EventArgs e)
        {            
            styleOutput.Clear();
            mLAStyleButton.Enabled = false;
            aPAStyleButton.Enabled = false;
            libMedStyleButton.Enabled = false;
            countryText.Clear();
            stateText.Clear();
            cityText.Clear();
            yearText.Clear();
            monthText.Clear();
            dayText.Clear();
            bookPublisherText.Clear();
            bookTitleText.Clear();
            authorOutput.Items.Clear();
            lastNameText.Clear();
            mIText.Clear();
            firstNameText.Clear();
            firstNameText.Focus();

            myBook = null;

            myBook = new Book();
        }

        //----------------------------------------------------------
        // Return to the options form
        //----------------------------------------------------------
        private void returnToManageReferencesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------------------------------------------------
        // Close down
        // Everyone out of the pool
        //----------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addReferenceButton_Click(object sender, EventArgs e)
        {
            ManageList myList = new ManageList();
            myList.ReferenceList.Add(myBook);
        }


    }
}
