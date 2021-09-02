using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class Book : Reference
    {
        //-----------------------------------------------------------------
        // Instance data
        //-----------------------------------------------------------------

        private string publisher;
        private string city;
        private string state;
        private string country;

        //-----------------------------------------------------------------
        // noarg constructor
        //-----------------------------------------------------------------
        public Book()
        {
            Publisher = "";
            City = "";
            State = "";
            Country = "";
        }


        //-----------------------------------------------------------------
        // Publisher Property
        //-----------------------------------------------------------------
        public string Publisher
        {
            get { return publisher; }
            set
            {
                if (value.Trim() == "")
                {
                    publisher = "No Publisher";
                }
                else
                {
                    publisher = value;
                }
            }
        }

        //-----------------------------------------------------------------
        // City Property
        //-----------------------------------------------------------------
        public string City
        {
            get { return city; }
            set
            {
                if (value.Trim() == "")
                {
                    city = "No City";
                }
                else
                {
                    city = value;
                }
            }
        }

        //-----------------------------------------------------------------
        // State Property
        //-----------------------------------------------------------------
        public string State
        {
            get { return state; }
            set
            {
                if (value.Trim() == "")
                {
                    state = "No State";
                }
                else
                {
                    state = value;
                }
            }
        }

        //-----------------------------------------------------------------
        // Country Property
        //-----------------------------------------------------------------
        public string Country
        {
            get { return country; }
            set
            {
                if (value.Trim() == "")
                {
                    country = "No Country";
                }
                else
                {
                    country = value;
                }
            }
        }

        //--------------------------------------------------------------
        // Provides MLA format for a book.
        //--------------------------------------------------------------
        public override string formatMLA()
        {
            string MLAFormat = getLastFirstMi_FirstMiLast(AuthorNames);

            if (MLAFormat.Substring(MLAFormat.Length - 1) == ".")
            {
                MLAFormat += " ";
            }
            else
            {
                MLAFormat += ". ";
            }

            MLAFormat += ReferenceTitle.getTitleAllWordsCap(true) + ". ";
            MLAFormat += City + ": ";
            MLAFormat += Publisher + ", ";
            MLAFormat += ReferencePublicationDate.getFormattedDate("yyyy") + ".";

            return MLAFormat;
        }

        //--------------------------------------------------------------
        //Provides APA format for a book.
        //--------------------------------------------------------------
        public override string formatAPA()
        {
            string APAFormat = getLastFiMi(AuthorNames) + " (";

            APAFormat += ReferencePublicationDate.getFormattedDate("yyyy") + "). ";
            APAFormat += ReferenceTitle.getTitleFirstLetterCap(true) + ". ";
            APAFormat += City + ": ";
            APAFormat += Publisher + ".";

            return APAFormat;
        }

        //--------------------------------------------------------------
        // Provides Library of Medicine format for a book.
        //--------------------------------------------------------------
        public override string formatLibMed()
        {
            string libMedFormat = getLastFiMiNoCommaNoDot(AuthorNames) + ". ";

            libMedFormat += ReferenceTitle.getTitleAllWordsCap(false) + ". ";
            libMedFormat += City + ": ";
            libMedFormat += Publisher + "; ";
            libMedFormat += ReferencePublicationDate.getFormattedDate("yyyy") + ".";

            return libMedFormat;

        }
    }
}
