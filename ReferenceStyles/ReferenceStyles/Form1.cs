/* 
 * ReferenceStyles.cs
 * Andrew Spooner
 * CS 1182 - 01
 * To show different formats of dates, names, and titles.
*/ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceStyles
{
    public partial class Form1 : Form
    {
        bool validDay;
        bool validMonth;
        bool validYear;
        bool validFirst;
        bool validMid;
        bool validLast;
        string month;
        int monthNumb;
        int day;
        int year;
        string firstName;
        string middleInitial;
        string lastName;
        string title;
        int x;
        int y;
        
        public Form1()
        {
            InitializeComponent();

            //Create Error Providers

            errorProviderDay = new System.Windows.Forms.ErrorProvider();
            errorProviderDay.SetIconAlignment(this.dayText, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            errorProviderDay.SetIconPadding(this.dayText, 2);
            errorProviderDay.BlinkRate = 1000;
            errorProviderDay.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            errorProviderMonth = new System.Windows.Forms.ErrorProvider();
            errorProviderMonth.SetIconAlignment(this.monthText, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            errorProviderMonth.SetIconPadding(this.monthText, 2);
            errorProviderMonth.BlinkRate = 1000;
            errorProviderMonth.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            errorProviderYear = new System.Windows.Forms.ErrorProvider();
            errorProviderYear.SetIconAlignment(this.yearText, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            errorProviderYear.SetIconPadding(this.yearText, 2);
            errorProviderYear.BlinkRate = 1000;
            errorProviderYear.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            errorProviderFirstName = new System.Windows.Forms.ErrorProvider();
            errorProviderFirstName.SetIconAlignment(this.firstNameText, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            errorProviderFirstName.SetIconPadding(this.firstNameText, 2);
            errorProviderFirstName.BlinkRate = 1000;
            errorProviderFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            errorProviderMiddleInitial = new System.Windows.Forms.ErrorProvider();
            errorProviderMiddleInitial.SetIconAlignment(this.middleInitialText, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            errorProviderMiddleInitial.SetIconPadding(this.middleInitialText, 2);
            errorProviderMiddleInitial.BlinkRate = 1000;
            errorProviderMiddleInitial.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            errorProviderLastName = new System.Windows.Forms.ErrorProvider();
            errorProviderLastName.SetIconAlignment(this.lastNameText, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            errorProviderLastName.SetIconPadding(this.lastNameText, 2);
            errorProviderLastName.BlinkRate = 1000;
            errorProviderLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            errorProviderTitle = new System.Windows.Forms.ErrorProvider();
            errorProviderTitle.SetIconAlignment(this.titleText, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            errorProviderTitle.SetIconPadding(this.titleText, 2);
            errorProviderTitle.BlinkRate = 1000;
            errorProviderTitle.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        }

        // Verify Day Text Box
        private void dayText_TextChanged(object sender, EventArgs e)
        {
            string userInput = dayText.Text;
            bool inputCheck = int.TryParse(userInput, out x);

            foreach (char number in userInput)
            {
                if (inputCheck && x > 0 && x < 32)
                {
                    validDay = true;
                    errorProviderDay.Clear();
                }
                else
                {
                    validDay = false;
                    errorProviderDay.SetError(this.dayText, "Must only contain numbers and be a valid day.");
                    dayText.Clear();
                    x = 0;
                }
            }
            day = x;

            if (monthNumb == 1 || monthNumb == 3 || monthNumb == 5 || monthNumb == 7 || monthNumb == 8 || monthNumb == 10 || monthNumb == 12)
            {
                if (day > 31 || day < 1)
                {
                    dayText.Clear();
                    errorProviderDay.GetError(this.dayText);
                }
                else
                {
                    errorProviderDay.Clear();
                }
            }
            else if (monthNumb == 4 || monthNumb == 6 || monthNumb == 9 || monthNumb == 11)
            {
                if (day > 30 || day < 1)
                {
                    dayText.Clear();
                    errorProviderDay.GetError(this.dayText);
                }
                else
                {
                    errorProviderDay.Clear();
                }
            }

            int leapYear = year % 4;

            if (leapYear == 0 && monthNumb == 2)
            {
                if (day > 29 || day < 1)
                {
                    dayText.Clear();
                    errorProviderDay.GetError(this.dayText);
                }
                else
                {
                    errorProviderDay.Clear();
                }
            }
            else if (leapYear != 0 && monthNumb == 2)
            {
                if (day > 28 || day < 1)
                {
                    dayText.Clear();
                    errorProviderDay.GetError(this.dayText);
                }
                else
                {
                    errorProviderDay.Clear();
                }
            }
        }
        // Verify Month Text Box
        private void monthText_TextChanged(object sender, EventArgs e)
        {
            string userInput = monthText.Text;
                
            foreach (char letter in userInput)            
            {            
                if (char.IsLetter(letter))                
                {                
                    validMonth = true;                    
                    errorProviderMonth.Clear();                    
                }                
                else                
                {                
                    validMonth = false;                    
                    errorProviderMonth.SetError(this.monthText, "First letter must be capitalized with the rest being lowercase.");                    
                    monthText.Clear();                    
                }            
            }
                
            month = userInput;
            monthNumb = 0;
            
            switch (month)            
            {            
                case "January": monthNumb = 1;                
                    break;                    
                case "February": monthNumb = 2;                
                    break;                    
                case "March": monthNumb = 3;                
                    break;                    
                case "April": monthNumb = 4;                
                    break;                    
                case "May": monthNumb = 5;                
                    break;                    
                case "June": monthNumb = 6;                
                    break;                    
                case "July": monthNumb = 7;                
                    break;                    
                case "August": monthNumb = 8;                
                    break;                    
                case "September": monthNumb = 9;                
                    break;                    
                case "October": monthNumb = 10;                
                    break;                    
                case "November": monthNumb = 11;                
                    break;                    
                case "December": monthNumb = 12;                
                    break;
            }
        }

        // Verify Year Text Box
        private void yearText_TextChanged(object sender, EventArgs e)
        {
            string userInput = yearText.Text;
            bool inputCheck = int.TryParse(userInput, out y);

            foreach (char number in userInput)
            {
                if (inputCheck)
                {
                    validYear = true;
                    errorProviderYear.Clear();
                }
                else
                {
                    validYear = false;
                    errorProviderYear.SetError(this.yearText, "Must only contain numbers.");
                    yearText.Clear();
                }
            }

            year = y;
        }
        // Verify First Name Text Box
        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            string userInput = firstNameText.Text;

            foreach (char letter in userInput)
            {
                if (char.IsLetter(letter))
                {
                    validFirst = true;
                    errorProviderFirstName.Clear();
                }
                else
                {
                    validFirst = false;
                    errorProviderFirstName.SetError(this.firstNameText, "Must only contain letters.");
                    firstNameText.Clear();
                }
            }
            firstName = userInput;            
        }

        // Verify Middle Initial Text Box
        private void middleInitialText_TextChanged(object sender, EventArgs e)
        {
            string userInput = middleInitialText.Text;

            foreach (char letter in userInput)
            {
                if (char.IsLetter(letter))
                {
                    validMid = true;
                    errorProviderMiddleInitial.Clear();
                }
                else
                {
                    validMid = false;
                    errorProviderMiddleInitial.SetError(this.middleInitialText, "Must only contain one letter.");
                    middleInitialText.Clear();
                }
            }
            middleInitial = userInput.ToUpper();
        }

        // Verify Last Name Text Box
        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            string userInput = lastNameText.Text;

            foreach (char letter in userInput)
            {
                if (char.IsLetter(letter))
                {
                    validLast = true;
                    errorProviderLastName.Clear();
                }
                else
                {
                    validLast = false;
                    errorProviderLastName.SetError(this.lastNameText, "Must only contain letters.");
                    lastNameText.Clear();
                }
            }
            lastName = userInput;
        }

        // Verify Title Text Box
        private void titleText_TextChanged(object sender, EventArgs e)
        {
            title = titleText.Text;
        }

        // Display Formatted Dates
        private void formatDate_Click(object sender, EventArgs e)
        {           
            if (validDay && validMonth && validYear)
            {
                if (day != 0 && monthNumb != 0)
                {
                    dateOutputText.Text = monthNumb + "/" + day + "/" + year;
                    dateOutputText.Text += System.Environment.NewLine + month + " " + day + ", " + year;
                    dateOutputText.Text += System.Environment.NewLine + monthNumb + "/" + year;
                    dateOutputText.Text += System.Environment.NewLine + month + ", " + year;
                    dateOutputText.Text += System.Environment.NewLine + year;
                }
                else if (day == 0 && monthNumb != 0)
                {
                    dateOutputText.Text = monthNumb + "/" + year;
                    dateOutputText.Text += System.Environment.NewLine + month + " " + year;
                    dateOutputText.Text += System.Environment.NewLine + monthNumb + "/" + year;
                    dateOutputText.Text += System.Environment.NewLine + month + ", " + year;
                    dateOutputText.Text += System.Environment.NewLine + year;
                }
                else if (monthNumb == 0)
                {
                    dateOutputText.Text = year.ToString();
                    dateOutputText.Text += System.Environment.NewLine + year;
                    dateOutputText.Text += System.Environment.NewLine + year;
                    dateOutputText.Text += System.Environment.NewLine + year;
                    dateOutputText.Text += System.Environment.NewLine + year;
                }
            }            
        }

        // Display Formatted Names
        private void formatName_Click(object sender, EventArgs e)
        {
            string firstLetter = firstName.Substring(0, 1).ToUpper();
            string firstEnd = firstName.Substring(1).ToLower();
            string lastLetter = lastName.Substring(0, 1).ToUpper();
            string lastEnd = lastName.Substring(1).ToLower();

            if (validMid && validFirst && validLast)
            {
                nameOutputText.Text = firstLetter + ". " + middleInitial + ". " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + firstLetter + " " + middleInitial + " " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + firstLetter + firstEnd + " " + middleInitial + " " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + firstLetter + firstEnd + " " + middleInitial + ". " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd + ", " + firstLetter + ". " + middleInitial + ".";
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd + ", " + firstLetter + firstEnd + " " + middleInitial + ".";
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd + " " + firstLetter + middleInitial;
            }
            else if (!validMid)
            {
                nameOutputText.Text = firstLetter + ". " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + firstLetter + " " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + firstLetter + firstEnd + " " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + firstLetter + firstEnd + " " + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd + ", " + firstLetter + ". ";
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd + ", " + firstLetter + firstEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd + " " + firstLetter;
            }
            else
            {
                nameOutputText.Text = lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd;
                nameOutputText.Text += System.Environment.NewLine + lastLetter + lastEnd;
            }
        }

        // Display Formatted Titles
        private void formatTitle_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo titleCase = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo extra = titleCase.TextInfo;

            titleOutput.Text = title;
            titleOutput.Text += System.Environment.NewLine + extra.ToTitleCase(title.ToLower());
            titleOutput.Text += System.Environment.NewLine + title.Substring(0, 1).ToUpper() + title.Substring(1).ToLower();
            titleOutput.Text += System.Environment.NewLine + title.ToLower();
            titleOutput.Text += System.Environment.NewLine + "<i>" + title + "</i>";
        }
    }
}
