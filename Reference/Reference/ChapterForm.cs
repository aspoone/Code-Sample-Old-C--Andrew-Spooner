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
    public partial class ChapterForm : Form
    {
        public ChapterForm()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------
        // Global Chapter object
        //----------------------------------------------------------

        Chapter myChapter = new Chapter();

        //----------------------------------------------------------
        // Add author names to Chapter object and list box
        // Clear text boxes for additional names
        //----------------------------------------------------------
        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            myChapter.addAuthor(firstNameText.Text, mIText.Text, lastNameText.Text);
            authorOutput.Items.Add(firstNameText.Text + " " + mIText.Text + " " + lastNameText.Text);

            firstNameText.Clear();
            mIText.Clear();
            lastNameText.Clear();
            firstNameText.Focus();  
        }

        //----------------------------------------------------------
        // Add editor names to Chapter object and list box
        // Clear text boxes for additional names
        //----------------------------------------------------------
        private void addEditorButton_Click(object sender, EventArgs e)
        {
            myChapter.addEditor(editorFirstNameText.Text, editorMIText.Text, editorLastNameText.Text);
            editorOutput.Items.Add(editorFirstNameText.Text + " " + editorMIText.Text + " " + editorLastNameText.Text);

            editorFirstNameText.Clear();
            editorMIText.Clear();
            editorLastNameText.Clear();
            editorFirstNameText.Focus();  
        }

        //----------------------------------------------------------
        // Add Chapter information to Chapter object
        // Enable button to view reference styles
        //----------------------------------------------------------
        private void addChapterButton_Click(object sender, EventArgs e)
        {
            int month;
            int day;
            int year;

            int beginPage;
            int endPage;

            int.TryParse(monthText.Text, out month);
            int.TryParse(dayText.Text, out day);
            int.TryParse(yearText.Text, out year);

            int.TryParse(beginPageNumberText.Text, out beginPage);
            int.TryParse(endPageNumberText.Text, out endPage);

            myChapter.ReferencePublicationDate.setDate(month, day, year);

            myChapter.Publisher = bookPublisherText.Text;
            myChapter.City = publisherCityText.Text;
            myChapter.State = publisherStateText.Text;
            myChapter.Country = publisherCountryText.Text;

            myChapter.ReferenceTitle.Name = bookTitleText.Text;
            myChapter.ChapterTitle.Name = chapterTitleText.Text;
            
            myChapter.BeginningPage = beginPage;
            myChapter.EndingPage = endPage;

            if (myChapter.AuthorNames.Count > 0 && myChapter.EditorNames.Count > 0)
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
            string reference = myChapter.formatMLA();
            myChapter.setItalicTitle(styleOutput, reference);
        }

        //----------------------------------------------------------
        // Show the APA style
        // In the rich text box
        //----------------------------------------------------------
        private void aPAStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Clear();
            string reference = myChapter.formatAPA();
            myChapter.setItalicTitle(styleOutput, reference);
        }

        //----------------------------------------------------------
        // Show the LibMed style
        // In the rich text box
        //----------------------------------------------------------
        private void libMedStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Text = myChapter.formatLibMed();
        }
 
        //----------------------------------------------------------
        // Clear the form
        // In preparation for another Chapter reference
        //----------------------------------------------------------
        private void addAnotherChapterButton_Click(object sender, EventArgs e)
        {
            firstNameText.Clear();
            mIText.Clear();
            lastNameText.Clear();
            editorFirstNameText.Clear();
            editorMIText.Clear();
            editorLastNameText.Clear();
            chapterTitleText.Clear();
            bookPublisherText.Clear();
            bookTitleText.Clear();
            monthText.Clear();
            dayText.Clear();
            yearText.Clear();
            publisherCityText.Clear();
            publisherStateText.Clear();
            publisherCountryText.Clear();
            beginPageNumberText.Clear();
            endPageNumberText.Clear();
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
            myList.ReferenceList.Add(myChapter);
        }
    }
}
