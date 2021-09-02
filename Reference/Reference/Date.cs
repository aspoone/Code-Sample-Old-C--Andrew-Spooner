// Originally coded by Paul Naas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reference
{
    class Date
    {
        //-----------------------------------------------------------------------------
        // Instance Data
        //-----------------------------------------------------------------------------
        private int month;
        private int day;
        private int year;

        //-----------------------------------------------------------------------------
        // Month Property
        // setter is private to prevent user from inserting date in wrong order
        //-----------------------------------------------------------------------------
        public int Month
        {
            get { return month; }
            private set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    month = 0;
                }
            }
        }

        //-----------------------------------------------------------------------------
        // Day Property
        // setter is private to prevent user from inserting date in wrong order
        //-----------------------------------------------------------------------------
        public int Day
        {
            get { return day; }
            private set
            {
                int[] daysPerMonth = {0, 31, 28, 31, 30, 31, 30, 
									  31, 31, 30, 31, 30, 31};

                if (Month >= 1 && Month <= 12 && value >= 1 && value <= daysPerMonth[Month])
                {
                    day = value;
                }
                else if (Month == 2 && value == 29)
                {
                    if ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
                    {
                        day = value;
                    }
                }
                else
                {
                    day = 0;
                }
            }
        }

        //-----------------------------------------------------------------------------
        // Year Property
        // setter is private to prevent user from inserting date in wrong order
        //-----------------------------------------------------------------------------
        public int Year
        {
            get { return year; }
            private set
            {
                if (value >= 1700 && value <= 10000)
                {
                    year = value;
                }
                else
                {
                    year = DateTime.Now.Year;
                }
            }
        }

        //-----------------------------------------------------------------------------
        // Public method to set the month, day, year in correct order
        // Force the client to set the month, year, and day in the correct order
        // because of the private mutators
        //-----------------------------------------------------------------------------
        public void setDate(int _month, int _day, int _year)
        {
            Month = _month;
            Year = _year;
            Day = _day;
        }

        //-----------------------------------------------------------------------------
        // Get a formatted date
        // Parameter specifies the date format
        // Example format parameters
        //    mm/dd/yy         10/22/1986
        //    month dd, yyyy   October 22, 1986
        //    mm/yyyy          10/1986
        //    month, yyyy      October, 1986
        //    yyyy             1986
        //-----------------------------------------------------------------------------

        public string getFormattedDate(string dateFormat)
        {
            string formattedDate = "";

            dateFormat = dateFormat.ToLower();

            switch (dateFormat)
            {
                case "mm/dd/yyyy":
                    formattedDate = dateFormatter(new string[] { "md", "/", "dd", "/", "yy" });
                    break;
                case "month dd, yyyy":
                    formattedDate = dateFormatter(new string[] { "mn", " ", "dd", ", ", "yy" });
                    break;
                case "mm/yyyy":
                    formattedDate = dateFormatter(new string[] { "md", "/", "yy" });
                    break;
                case "month, yyyy":
                    formattedDate = dateFormatter(new string[] { "mn", ", ", "yy" });
                    break;
                case "yyyy":
                    formattedDate = dateFormatter(new string[] { "yy" });
                    break;
            }

            return formattedDate;
        }

        //-----------------------------------------------------------------------------
        // Date formatter will return a formatted date
        // String array parameter contains the following formatting information
        //      md = numeric day of month
        //      mn = month name
        //      dd = day of month
        //      yy = year
        //      punctuation such as /, -, ., etc.
        //-----------------------------------------------------------------------------
        private string dateFormatter(string[] format)
        {
            string formattedDate = "";
            string fmt;
            string[] monthNames = {"January", "February", "March", "April", 
                                   "May", "June", "July", "August", 
                                   "September", "October", "November", "December"};

            try
            {
                for (int ndx = 0; ndx < format.Length; ndx++)
                {
                    fmt = format[ndx];

                    if (fmt == "md")
                    {
                        if (Month != 0)
                        {
                            formattedDate += Month.ToString();
                            format[ndx] = "t";
                        }
                    }
                    else if (fmt == "dd")
                    {
                        if (Day != 0)
                        {
                            formattedDate += Day.ToString();
                            format[ndx] = "t";
                        }
                    }
                    else if (fmt == "yy")
                    {
                        formattedDate += Year.ToString();
                        format[ndx] = "t";
                    }
                    else if (fmt == "mn")
                    {
                        if (month != 0)
                        {
                            formattedDate += monthNames[Month - 1];
                            format[ndx] = "t";
                        }
                    }
                    else
                    {
                        if (format[ndx - 1] == "t")
                        {
                            formattedDate += format[ndx];
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Format Error");
            }

            return formattedDate;
        }
    }
}
