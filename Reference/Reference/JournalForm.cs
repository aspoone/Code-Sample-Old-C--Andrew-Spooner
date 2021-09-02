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
    public partial class JournalForm : Form
    {

        Journal myJournal = new Journal();

        public JournalForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            string userInput = firstNameText.Text;

            foreach (char letter in userInput)
            {
                if (char.IsLetter(letter))
                {
                    errorProviderFirstName.Clear();
                }
                else
                {
                    errorProviderFirstName.SetError(this.firstNameText, "Must only contain letters.");
                    firstNameText.Clear();
                }
            }
        }

        private void mIText_TextChanged(object sender, EventArgs e)
        {
            string userInput = mIText.Text;

            foreach (char letter in userInput)
            {
                if (char.IsLetter(letter))
                {
                    errorProviderMiddleInitial.Clear();
                }
                else
                {
                    errorProviderMiddleInitial.SetError(this.mIText, "Must only contain one letter.");
                    mIText.Clear();
                }
            }
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            string userInput = lastNameText.Text;

            foreach (char letter in userInput)
            {
                if (char.IsLetter(letter))
                {
                    errorProviderLastName.Clear();
                }
                else
                {
                    errorProviderLastName.SetError(this.lastNameText, "Must only contain letters.");
                    lastNameText.Clear();
                }
            }
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            myJournal.addAuthor(firstNameText.Text, mIText.Text, lastNameText.Text);
            authorOutput.Items.Add(firstNameText.Text + " " + mIText.Text + " " + lastNameText.Text);

            firstNameText.Clear();
            mIText.Clear();
            lastNameText.Clear();
            firstNameText.Focus();  
        }

        private void addJournalButton_Click(object sender, EventArgs e)
        {
            int month;
            int day;
            int year;

            int beginPage;
            int endPage;
            int volume;
            int number;

            int.TryParse(monthText.Text, out month);
            int.TryParse(dayText.Text, out day);
            int.TryParse(yearText.Text, out year);

            int.TryParse(beginPageNumberText.Text, out beginPage);
            int.TryParse(endPageNumberText.Text, out endPage);
            int.TryParse(volumeText.Text, out volume);
            int.TryParse(numberText.Text, out number);

            myJournal.ReferencePublicationDate.setDate(month, day, year);

            myJournal.ReferenceTitle.Name = journalTitleText.Text;
            myJournal.JournalName = journalNameText.Text;
            myJournal.BeginningPage = beginPage;
            myJournal.EndingPage = endPage;
            myJournal.Volume = volume;
            myJournal.Number = number;

            if (myJournal.AuthorNames.Count > 0)
            {
                mLAStyleButton.Enabled = true;
                aPAStyleButton.Enabled = true;
                libMedStyleButton.Enabled = true;
                addReferenceButton.Enabled = true;
            }
        }

        private void returnToManageReferencesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAnotherJournalButton_Click(object sender, EventArgs e)
        {
            styleOutput.Clear();
            mLAStyleButton.Enabled = false;
            aPAStyleButton.Enabled = false;
            libMedStyleButton.Enabled = false;
            numberText.Clear();
            volumeText.Clear();
            endPageNumberText.Clear();
            beginPageNumberText.Clear();
            yearText.Clear();
            monthText.Clear();
            dayText.Clear();
            journalNameText.Clear();
            journalTitleText.Clear();
            authorOutput.Items.Clear();
            lastNameText.Clear();
            mIText.Clear();
            firstNameText.Clear();
            firstNameText.Focus();

            myJournal = null;

            myJournal = new Journal();
        }

        private void mLAStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Clear();
            string reference = myJournal.formatMLA();
            myJournal.setItalicTitle(styleOutput, reference);
        }

        private void aPAStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Clear();
            string reference = myJournal.formatAPA();
            myJournal.setItalicTitle(styleOutput, reference);
        }

        private void libMedStyleButton_Click(object sender, EventArgs e)
        {
            styleOutput.Text = myJournal.formatLibMed();
        }

        private void addReferenceButton_Click(object sender, EventArgs e)
        {
            ManageList myList = new ManageList();
            myList.ReferenceList.Add(myJournal);
        }
    }
}
