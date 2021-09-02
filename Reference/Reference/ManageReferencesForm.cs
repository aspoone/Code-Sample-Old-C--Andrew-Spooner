/*
 * Project Deliverable 4
 * Andrew Spooner
 * CS 1182 - 01
 * To show different reference styles for names, dates, and titles
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference
{
    public partial class ManageReferencesForm : Form
    {
        ManageList myReferenceList = new ManageList();
        PrintDocument printDocument = new PrintDocument();

        public ManageReferencesForm()
        {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm myBookForm = new BookForm();
            myBookForm.Show();
        }

        private void chapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChapterForm myChapterForm = new ChapterForm();
            myChapterForm.Show();
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalForm myJournalForm = new JournalForm();
            myJournalForm.Show();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pageSetupDialog1.ShowNetwork = false;
            DialogResult result = pageSetupDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                object[] results = new object[]{ 
				pageSetupDialog1.PageSettings.Margins, 
				pageSetupDialog1.PageSettings.PaperSize, 
				pageSetupDialog1.PageSettings.Landscape, 
				pageSetupDialog1.PrinterSettings.PrinterName,
                pageSetupDialog1.PrinterSettings.MaximumCopies,
				pageSetupDialog1.PrinterSettings.PrintRange};
                ListBox listBox1 = new ListBox();
                listBox1.Items.AddRange(results);
            }
        }

        private void openReferencesFromADataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageList ReferenceList = new ManageList();            
                try
                {                      
                    openFileDialog1.FileName = "";
                    openFileDialog1.Filter = "data files (*.dat)|*.dat|All files (*.*)|*.*";
                    openFileDialog1.Title = "Select the data file to open";
                    openFileDialog1.ShowDialog();

                    

                    // Open the file containing the data that you want to deserialize.
                    FileStream fs = new FileStream("ReferenceList.dat", FileMode.Open, FileAccess.Read);
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        ReferenceList = (ManageList)formatter.Deserialize(fs);
                    }
                    catch (SerializationException c)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + c.Message);
                        throw;
                    }
                    finally
                    {
                        fs.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Error reading from file");
                } 
            
        }

        private void saveReferencesToADataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter dataFormatter = new BinaryFormatter();
            ManageList ReferenceList = new ManageList();

            try
            {
                FileStream dataFileStream = new FileStream("ReferenceList.dat", FileMode.OpenOrCreate, FileAccess.Write);
                SaveFileDialog fileChooser = new SaveFileDialog();

                if (styleOutput.TextLength == 0)
                {
                    MessageBox.Show("Display References Before Saving");
                }
                else
                {
                    fileChooser.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                    fileChooser.Filter = "data files (*.dat)|*.dat|All files (*.*)|*.*";
                    fileChooser.Title = "Select the data file to hold your formatted references";

                    DialogResult result = fileChooser.ShowDialog();
                    string fileName = null;

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    fileName = fileChooser.FileName;
                }
                dataFormatter.Serialize(dataFileStream, ReferenceList);
                dataFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file " + ex.Message);
            }
            
        }

        private void startNewReferenceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            styleOutput.Clear();
            myReferenceList.ReferenceList.Clear();
        }

        private void printReferencesToADocumentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileChooser = new SaveFileDialog();

            if (styleOutput.TextLength == 0)
            {
                MessageBox.Show("Display References Before Saving");
            }
            else
            {
                fileChooser.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                fileChooser.Filter = "rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
                fileChooser.Title = "Select the rtf file to hold your formatted references";

                DialogResult result = fileChooser.ShowDialog();
                string fileName = null;

                if (result == DialogResult.Cancel)
                {
                    return;
                }

                fileName = fileChooser.FileName;

                if (fileName == String.Empty || fileName == null)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        styleOutput.SaveFile(fileName);
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message + "\n",
                                          "Problem Saving the Results " + ex.Message, MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message + "\n",
                                        "Problem Saving the Results: " + ex.Message, MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            printPreviewDialog.Document = printDocument;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }          
        }

        private void printReferencesToAPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addReferencesToRichTextBox()
        {
            styleOutput.Clear();

            string reference;

            myReferenceList.ReferenceList.Sort();

            for (int ndx = 0; ndx < myReferenceList.ReferenceList.Count; ndx++)
            {
                reference = getReference(ndx);

                if (reference.IndexOf("<i>", 0) >= 0)
                {
                    myReferenceList.ReferenceList[ndx].setItalicTitle(styleOutput, reference);
                    styleOutput.AppendText("\r\n\r\n");
                }
                else
                {
                    styleOutput.AppendText(reference + "\r\n\r\n");
                }

            }
        }

        private string getReference(int refNumber)
        {
            string reference = "";

            if (mLAButton.Checked)
            {
                reference = myReferenceList.ReferenceList[refNumber].formatMLA();
            }
            else if (aPAButton.Checked)
            {
                reference = myReferenceList.ReferenceList[refNumber].formatAPA();
            }
            else
            {
                reference = myReferenceList.ReferenceList[refNumber].formatLibMed();
            }

            return reference;
        }

        private void mLAButton_CheckedChanged(object sender, EventArgs e)
        {
            addReferencesToRichTextBox();
        }

        private void aPAButton_CheckedChanged(object sender, EventArgs e)
        {
            addReferencesToRichTextBox();
        }

        private void libMedStyle_CheckedChanged(object sender, EventArgs e)
        {
            addReferencesToRichTextBox();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is used for formatting book,\r\nchapter, and journal references.\r\nCreated by Andrew Spooner");
        }

        private void ManageReferencesForm_Activated(object sender, EventArgs e)
        {
            if (myReferenceList.ReferenceList.Count > 0)
            {
                addReferencesToRichTextBox();
            }
        }

        private void ManageReferencesForm_Load(object sender, EventArgs e)
        {
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(styleOutput.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            float XPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            System.Drawing.FontStyle italic = System.Drawing.FontStyle.Italic;
            //Font PrintFont = this.myRichTextBox.Font;
            Font PrintFont = new Font("Courier New", 12);
            Font PrintFontItalic = new System.Drawing.Font(PrintFont.FontFamily, PrintFont.Size, italic);
            SolidBrush PrintBrush = new SolidBrush(Color.Black);
            char ch;
            int chCount = 0;

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                XPosition = LeftMargin;

                for (int ndx = 0; ndx < Line.Length; ndx++)
                {
                    ch = Line[ndx];

                    styleOutput.SelectionStart = chCount;
                    styleOutput.SelectionLength = 1;
                    if (styleOutput.SelectionFont.Italic)
                    {
                        e.Graphics.DrawString(ch.ToString(), PrintFontItalic, PrintBrush, XPosition, YPosition - 1, new StringFormat());
                        XPosition += (int)e.Graphics.MeasureString(ch.ToString(), PrintFontItalic).Width - 5;
                    }
                    else
                    {
                        e.Graphics.DrawString(ch.ToString(), PrintFont, PrintBrush, XPosition, YPosition, new StringFormat());
                        XPosition += (int)e.Graphics.MeasureString(ch.ToString(), PrintFont).Width - 5;
                    }
                    chCount++;

                }
                Count++;
                chCount++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }
    }
}
