using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class Chapter : Book
    {
        //--------------------------------------------------------------
        // Instance data
        //--------------------------------------------------------------

        private List<Name> editorNames = new List<Name>();
        private Title chapterTitle = new Title();
        private int beginningPage;
        private int endingPage;

        //--------------------------------------------------------------
        // EditorNames Property
        //--------------------------------------------------------------
        public List<Name> EditorNames
        {
            get { return editorNames; }
        }

        //--------------------------------------------------------------
        // ChapterTitle Property
        //--------------------------------------------------------------
        public Title ChapterTitle
        {
            get { return chapterTitle; }
        }

        //--------------------------------------------------------------
        // BeginningPage Property
        //--------------------------------------------------------------
        public int BeginningPage
        {
            get { return beginningPage; }
            set
            {
                beginningPage = value;
            }
        }

        //--------------------------------------------------------------
        // EndingPage Property
        //--------------------------------------------------------------
        public int EndingPage
        {
            get { return endingPage; }
            set
            {
                endingPage = value;
            }
        }

        //-----------------------------------------------------------------
        // Method to add a Name object to the list of editors
        //-----------------------------------------------------------------
        public void addEditor(string first, string mi, string last)
        {
            if (mi.Trim() == "")
            {
                editorNames.Add(new Name(first, last));
            }
            else
            {
                editorNames.Add(new Name(first, mi, last));
            }
        }

        //--------------------------------------------------------------
        // Provides MLA format for a Chapter.
        //--------------------------------------------------------------
        public override string formatMLA()
        {
            string MLAFormat = getLastFirstMi_FirstMiLast(AuthorNames);

            MLAFormat += (getLastFirstMi_FirstMiLast(AuthorNames).Substring(getLastFirstMi_FirstMiLast(AuthorNames).Length - 1) == "." ? " " : ". ");
            MLAFormat += "\"" + ChapterTitle.getTitle(false) + "." + "\" " + ReferenceTitle.getTitle(true);
            MLAFormat += ", Eds. " + getFirstMiLast(EditorNames) + ". ";
            MLAFormat += City;
            MLAFormat += (string.IsNullOrEmpty(State) ? "" : ", " + State) + ": ";
            MLAFormat += Publisher + ", " + ReferencePublicationDate.getFormattedDate("yyyy") + ", ";
            MLAFormat += BeginningPage + "-" + EndingPage + ".";

            return MLAFormat;
        }

        //--------------------------------------------------------------
        // Provides APA format for a Chapter.
        //--------------------------------------------------------------
        public override string formatAPA()
        {
            string APAFormat = getLastFiMi(AuthorNames);

            APAFormat += (getLastFiMi(AuthorNames).Substring(getLastFiMi(AuthorNames).Length - 1) == "." ? " " : ". ");
            APAFormat += " (" + ReferencePublicationDate.getFormattedDate("yyyy") + "). ";
            APAFormat += ChapterTitle.getTitleFirstLetterCap(false) + ". In ";
            APAFormat += getFiMiLast(EditorNames) + " (Eds.), ";
            APAFormat += ReferenceTitle.getTitle(true) + " (pp. ";
            APAFormat += BeginningPage + "-" + EndingPage + "). " + City;
            APAFormat += (string.IsNullOrEmpty(State) ? "" : ", " + State) + ": ";
            APAFormat += Publisher + ".";

            return APAFormat;
        }

        //--------------------------------------------------------------
        // Provides LibMed format for a Chapter.
        //--------------------------------------------------------------
        public override string formatLibMed()
        {
            string libMedFormat = getLastFiMiNoCommaNoDot(AuthorNames) + ". ";

            libMedFormat += ChapterTitle.getTitle(false) + "." + " In ";
            libMedFormat += getLastFiMiNoCommaNoDot(EditorNames) + ", Editors. ";
            libMedFormat += ReferenceTitle.getTitle(false) + ". ";
            libMedFormat += City + ": " + Publisher + "; ";
            libMedFormat += ReferencePublicationDate.getFormattedDate("yyyy") + ". " + "P. ";
            libMedFormat += BeginningPage + "-" + EndingPage + ".";

            return libMedFormat;
        }
    }
}
