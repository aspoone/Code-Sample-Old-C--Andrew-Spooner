// Originally coded by Paul Naas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reference
{
    class Name : IComparable
    {
        //-----------------------------------------------------------------------------
        // Instance Data
        //-----------------------------------------------------------------------------

        private string firstName;
        private string middleInitial;
        private string lastName;

        //-----------------------------------------------------------------------------
        // noarg Constructor
        //-----------------------------------------------------------------------------

        public Name()
        {
            FirstName = "";
            MiddleInitial = "";
            LastName = "";
        }

        //-----------------------------------------------------------------------------
        // Three arg constructor
        //-----------------------------------------------------------------------------

        public Name(string first, string initial, string last)
        {
            FirstName = first;
            MiddleInitial = initial;
            LastName = last;
        }

        //-----------------------------------------------------------------------------
        // Two arg constructor
        //-----------------------------------------------------------------------------

        public Name(string first, string last)
        {
            FirstName = first;
            MiddleInitial = "";
            LastName = last;
        }

        //-----------------------------------------------------------------------------
        // First Name Property
        //-----------------------------------------------------------------------------

        public string FirstName
        {
            get { return firstName; }
            set
            {
                string first = value.Trim();
                bool valid = System.Text.RegularExpressions.Regex.IsMatch(first, "^[- a-zA-Z]+$");

                if (valid)
                {
                    firstName = value;
                }
                else
                {
                    firstName = "";
                }
            }
        }

        //-----------------------------------------------------------------------------
        // Middle Initial Property
        //-----------------------------------------------------------------------------

        public string MiddleInitial
        {
            get { return middleInitial; }
            set
            {
                string initial = value.Trim();
                bool valid = System.Text.RegularExpressions.Regex.IsMatch(initial, "^[a-zA-Z]*$");

                if (valid)
                {
                    middleInitial = value;
                }
                else
                {
                    middleInitial = "";
                }
            }
        }

        //-----------------------------------------------------------------------------
        // Last Name Property
        //-----------------------------------------------------------------------------

        public string LastName
        {
            get { return lastName; }
            set
            {
                string last = value.Trim();
                bool valid = System.Text.RegularExpressions.Regex.IsMatch(last, "^[A-Z]'?[- a-zA-Z]+$");

                if (valid)
                {
                    lastName = value;
                }
                else
                {
                    lastName = "";
                }
            }
        }

        //-----------------------------------------------------------------------------
        // Get a formatted name
        // Parameter specifies the name format
        // Examples using name of "Alfred E Newman"
        //    fi. mi.ln    A. E. Newman
        //    fn mi. ln    Alfred E. Newman
        //    ln, fi. mi.  Newman, A. E.
        //    ln, fn mi.   Newman, Alfred E.
        //    ln fimi      Newman AE
        //-----------------------------------------------------------------------------

        public string getFormattedName(string nameFormat)
        {
            string formattedName = "";

            nameFormat = nameFormat.ToLower();

            switch (nameFormat)
            {
                case "fi. mi.ln":
                    formattedName = nameFormatter(new string[] { "fi", ". ", "mi", ". ", "ln" });
                    break;
                case "fn mi. ln":
                    formattedName = nameFormatter(new string[] { "fn", " ", "mi", ". ", "ln" });
                    break;
                case "ln, fi. mi.":
                    formattedName = nameFormatter(new string[] { "ln", ", ", "fi", ". ", "mi", "." });
                    break;
                case "ln, fn mi.":
                    formattedName = nameFormatter(new string[] { "ln", ", ", "fn", " ", "mi", "." });
                    break;
                case "ln fimi":
                    formattedName = nameFormatter(new string[] { "ln", " ", "fi", "mi" });
                    break;
                case "fi mi ln":
                    formattedName = nameFormatter(new string[] { "fi", " ", "mi", " ", "ln" });
                    break;
                case "fn mi ln":
                    formattedName = nameFormatter(new string[] { "fn", " ", "mi", " ", "ln" });
                    break;
            }

            return formattedName;
        }


        //-----------------------------------------------------------------------------
        // nameFormatter method will return a formatted name
        // string array parameter contains formatting information as follows:
        //   fn = first name
        //   ln = last name
        //   mi = middle initial
        //   fi = first initial
        //   other punctuation such as spaces, commas, periods, etc.
        //-----------------------------------------------------------------------------
        private string nameFormatter(string[] format)
        {
            string formattedName = "";
            string fmt;
            string stringToInsert;

            try
            {
                for (int ndx = 0; ndx < format.Length; ndx++)
                {
                    fmt = format[ndx];

                    if (fmt == "fn")
                    {
                        stringToInsert = FirstName;
                        if (stringToInsert.Length != 0)
                        {
                            formattedName += stringToInsert;
                            format[ndx] = "t";
                        }

                    }
                    else if (fmt == "mi")
                    {
                        stringToInsert = getFirstLetter(MiddleInitial);
                        if (stringToInsert.Length != 0)
                        {
                            formattedName += stringToInsert;
                            format[ndx] = "t";
                        }
                    }
                    else if (fmt == "ln")
                    {
                        stringToInsert = LastName;
                        if (stringToInsert.Length != 0)
                        {
                            formattedName += stringToInsert;
                            format[ndx] = "t";
                        }
                    }
                    else if (fmt == "fi")
                    {
                        stringToInsert = getFirstLetter(FirstName);
                        if (stringToInsert.Length != 0)
                        {
                            formattedName += stringToInsert;
                            format[ndx] = "t";
                        }
                    }
                    else
                    {
                        if (format[ndx - 1] == "t")
                        {
                            formattedName += fmt;
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Format error");
            }

            return formattedName;
        }

        //-----------------------------------------------------------------------------
        // Method to return the first letter of a string
        //-----------------------------------------------------------------------------
        private string getFirstLetter(string name)
        {
            if (name.Length == 0)
            {
                return "";
            }
            else
            {

                return name.Substring(0, 1);
            }
        }

        //-----------------------------------------------------------------------------
        // compareTo method
        // Required when using the IComparable interface
        // Return results of comparing two Name objects
        //-----------------------------------------------------------------------------

        public int CompareTo(object obj)
        {
            Name tempObj = (Name)obj;

            string thisName = this.getFormattedName("ln, fn mi.");
            string parameterName = tempObj.getFormattedName("ln, fn mi.");
            return String.Compare(thisName, parameterName);
        }
    }
}
