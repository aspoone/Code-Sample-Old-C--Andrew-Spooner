using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class Journal : Reference
    {
        //--------------------------------------------------------------
        // Instance Data
        //--------------------------------------------------------------

        private string journalName;
        private int volume;
        private int number;
        private int beginningPage;
        private int endingPage;

        //--------------------------------------------------------------
        // JournalName Property
        //--------------------------------------------------------------
        public string JournalName
        {
            get { return journalName; }
            set
            {
                if (value.Trim() == "")
                {
                    journalName = "No Journal Name";
                }
                else
                {
                    journalName = value;
                }
            }
        }

        //--------------------------------------------------------------
        // Volume Property
        //--------------------------------------------------------------
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        //--------------------------------------------------------------
        // Number Property
        //--------------------------------------------------------------
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        //--------------------------------------------------------------
        // BeginningPage Property
        //--------------------------------------------------------------
        public int BeginningPage
        {
            get { return beginningPage; }
            set { beginningPage = value; }
        }

        //--------------------------------------------------------------
        // EndingPage Property
        //--------------------------------------------------------------
        public int EndingPage
        {
            get { return endingPage; }
            set { endingPage = value; }
        }

        //--------------------------------------------------------------
        // Provides MLA format for a journal.
        //--------------------------------------------------------------
        public override string formatMLA()
        {
            string MLAFormat = getLastFiMi_FirstMiLast(AuthorNames) + ". \"";

            MLAFormat += ReferenceTitle.getTitle(true) + ".\" ";
            MLAFormat += JournalName + " ";
            MLAFormat += Volume;
            MLAFormat += (Number == 0 ? "" : "." + Number) + " (";
            MLAFormat += ReferencePublicationDate.getFormattedDate("yyyy") + "): ";
            MLAFormat += BeginningPage + "-" + EndingPage + ".";

            return MLAFormat;
        }

        //--------------------------------------------------------------
        // Overrides APA format for a journal.
        //--------------------------------------------------------------
        public override string formatAPA()
        {
            string APAFormat = getLastFiMi(AuthorNames) + " (";

            APAFormat += ReferencePublicationDate.getFormattedDate("yyyy") + "). ";
            APAFormat += ReferenceTitle.getTitleFirstLetterCap(false) + ". ";
            APAFormat += "<i>" + JournalName + "</i>, " + Volume;
            APAFormat += (Number == 0 ? "" : " (" + Number + ")") + ", ";
            APAFormat += BeginningPage + "-" + EndingPage + ".";

            return APAFormat;
        }

        //--------------------------------------------------------------
        // Provides LibMed format for a journal.
        //--------------------------------------------------------------
        public override string formatLibMed()
        {
            string LibMedFormat = getLastFiMiNoCommaNoDot(AuthorNames) + ". ";

            LibMedFormat += ReferenceTitle.getTitle(false) + ". ";
            LibMedFormat += JournalName + ".";
            LibMedFormat += ReferencePublicationDate.getFormattedDate("yyyy") + "; ";
            LibMedFormat += Volume + ":" + BeginningPage + "-" + EndingPage + ".";

            return LibMedFormat;
        }

    }
}
