namespace Reference
{
    partial class JournalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.mIText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.returnToManageReferencesButton = new System.Windows.Forms.Button();
            this.addAnotherJournalButton = new System.Windows.Forms.Button();
            this.libMedStyleButton = new System.Windows.Forms.Button();
            this.aPAStyleButton = new System.Windows.Forms.Button();
            this.mLAStyleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.volumeText = new System.Windows.Forms.TextBox();
            this.endPageNumberText = new System.Windows.Forms.TextBox();
            this.beginPageNumberText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.dayText = new System.Windows.Forms.TextBox();
            this.monthText = new System.Windows.Forms.TextBox();
            this.journalNameText = new System.Windows.Forms.TextBox();
            this.journalTitleText = new System.Windows.Forms.TextBox();
            this.addJournalButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMiddleInitial = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMonth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.authorOutput = new System.Windows.Forms.ListBox();
            this.styleOutput = new System.Windows.Forms.RichTextBox();
            this.addReferenceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMiddleInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).BeginInit();
            this.SuspendLayout();
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(344, 77);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.addAuthorButton.TabIndex = 39;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // lastNameText
            // 
            this.errorProviderLastName.SetIconPadding(this.lastNameText, 2);
            this.lastNameText.Location = new System.Drawing.Point(231, 80);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 37;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // mIText
            // 
            this.errorProviderMiddleInitial.SetIconPadding(this.mIText, 2);
            this.mIText.Location = new System.Drawing.Point(187, 80);
            this.mIText.Name = "mIText";
            this.mIText.Size = new System.Drawing.Size(27, 20);
            this.mIText.TabIndex = 36;
            this.mIText.TextChanged += new System.EventHandler(this.mIText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "List of Authors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Last";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "MI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "First";
            // 
            // firstNameText
            // 
            this.errorProviderFirstName.SetIconPadding(this.firstNameText, 2);
            this.firstNameText.Location = new System.Drawing.Point(43, 80);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(127, 20);
            this.firstNameText.TabIndex = 31;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add Authors";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(546, 650);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 47;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // returnToManageReferencesButton
            // 
            this.returnToManageReferencesButton.Location = new System.Drawing.Point(311, 650);
            this.returnToManageReferencesButton.Name = "returnToManageReferencesButton";
            this.returnToManageReferencesButton.Size = new System.Drawing.Size(213, 23);
            this.returnToManageReferencesButton.TabIndex = 46;
            this.returnToManageReferencesButton.Text = "Return to Manage References";
            this.returnToManageReferencesButton.UseVisualStyleBackColor = true;
            this.returnToManageReferencesButton.Click += new System.EventHandler(this.returnToManageReferencesButton_Click);
            // 
            // addAnotherJournalButton
            // 
            this.addAnotherJournalButton.Location = new System.Drawing.Point(176, 650);
            this.addAnotherJournalButton.Name = "addAnotherJournalButton";
            this.addAnotherJournalButton.Size = new System.Drawing.Size(113, 23);
            this.addAnotherJournalButton.TabIndex = 45;
            this.addAnotherJournalButton.Text = "Add Another Journal";
            this.addAnotherJournalButton.UseVisualStyleBackColor = true;
            this.addAnotherJournalButton.Click += new System.EventHandler(this.addAnotherJournalButton_Click);
            // 
            // libMedStyleButton
            // 
            this.libMedStyleButton.Location = new System.Drawing.Point(52, 621);
            this.libMedStyleButton.Name = "libMedStyleButton";
            this.libMedStyleButton.Size = new System.Drawing.Size(90, 23);
            this.libMedStyleButton.TabIndex = 43;
            this.libMedStyleButton.Text = "LibMed Style";
            this.libMedStyleButton.UseVisualStyleBackColor = true;
            this.libMedStyleButton.Click += new System.EventHandler(this.libMedStyleButton_Click);
            // 
            // aPAStyleButton
            // 
            this.aPAStyleButton.Location = new System.Drawing.Point(52, 578);
            this.aPAStyleButton.Name = "aPAStyleButton";
            this.aPAStyleButton.Size = new System.Drawing.Size(75, 23);
            this.aPAStyleButton.TabIndex = 42;
            this.aPAStyleButton.Text = "APA Style";
            this.aPAStyleButton.UseVisualStyleBackColor = true;
            this.aPAStyleButton.Click += new System.EventHandler(this.aPAStyleButton_Click);
            // 
            // mLAStyleButton
            // 
            this.mLAStyleButton.Location = new System.Drawing.Point(52, 536);
            this.mLAStyleButton.Name = "mLAStyleButton";
            this.mLAStyleButton.Size = new System.Drawing.Size(75, 23);
            this.mLAStyleButton.TabIndex = 41;
            this.mLAStyleButton.Text = "MLA Style";
            this.mLAStyleButton.UseVisualStyleBackColor = true;
            this.mLAStyleButton.Click += new System.EventHandler(this.mLAStyleButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "View Reference Styles";
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(317, 389);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(100, 20);
            this.numberText.TabIndex = 116;
            // 
            // volumeText
            // 
            this.volumeText.Location = new System.Drawing.Point(155, 389);
            this.volumeText.Name = "volumeText";
            this.volumeText.Size = new System.Drawing.Size(100, 20);
            this.volumeText.TabIndex = 115;
            // 
            // endPageNumberText
            // 
            this.endPageNumberText.Location = new System.Drawing.Point(362, 348);
            this.endPageNumberText.Name = "endPageNumberText";
            this.endPageNumberText.Size = new System.Drawing.Size(100, 20);
            this.endPageNumberText.TabIndex = 113;
            // 
            // beginPageNumberText
            // 
            this.beginPageNumberText.Location = new System.Drawing.Point(155, 348);
            this.beginPageNumberText.Name = "beginPageNumberText";
            this.beginPageNumberText.Size = new System.Drawing.Size(100, 20);
            this.beginPageNumberText.TabIndex = 112;
            // 
            // yearText
            // 
            this.errorProviderYear.SetIconPadding(this.yearText, 2);
            this.yearText.Location = new System.Drawing.Point(256, 303);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(58, 20);
            this.yearText.TabIndex = 111;
            // 
            // dayText
            // 
            this.errorProviderDay.SetIconPadding(this.dayText, 2);
            this.dayText.Location = new System.Drawing.Point(205, 303);
            this.dayText.Name = "dayText";
            this.dayText.Size = new System.Drawing.Size(30, 20);
            this.dayText.TabIndex = 110;
            // 
            // monthText
            // 
            this.errorProviderMonth.SetIconPadding(this.monthText, 2);
            this.monthText.Location = new System.Drawing.Point(155, 303);
            this.monthText.Name = "monthText";
            this.monthText.Size = new System.Drawing.Size(30, 20);
            this.monthText.TabIndex = 109;
            // 
            // journalNameText
            // 
            this.journalNameText.Location = new System.Drawing.Point(155, 255);
            this.journalNameText.Name = "journalNameText";
            this.journalNameText.Size = new System.Drawing.Size(253, 20);
            this.journalNameText.TabIndex = 107;
            // 
            // journalTitleText
            // 
            this.journalTitleText.Location = new System.Drawing.Point(155, 212);
            this.journalTitleText.Name = "journalTitleText";
            this.journalTitleText.Size = new System.Drawing.Size(253, 20);
            this.journalTitleText.TabIndex = 106;
            // 
            // addJournalButton
            // 
            this.addJournalButton.Location = new System.Drawing.Point(38, 427);
            this.addJournalButton.Name = "addJournalButton";
            this.addJournalButton.Size = new System.Drawing.Size(75, 23);
            this.addJournalButton.TabIndex = 105;
            this.addJournalButton.Text = "Add Journal";
            this.addJournalButton.UseVisualStyleBackColor = true;
            this.addJournalButton.Click += new System.EventHandler(this.addJournalButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(264, 392);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 104;
            this.label23.Text = "Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "MM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 92;
            this.label16.Text = "CCYY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(209, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "DD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "End Page Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 89;
            this.label13.Text = "Volume";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Begin Page Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Publication Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Journal Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Journal Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 29);
            this.label2.TabIndex = 117;
            this.label2.Text = "Add Journal Information";
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.BlinkRate = 1000;
            this.errorProviderFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderMiddleInitial
            // 
            this.errorProviderMiddleInitial.BlinkRate = 1000;
            this.errorProviderMiddleInitial.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMiddleInitial.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.BlinkRate = 1000;
            this.errorProviderLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderDay
            // 
            this.errorProviderDay.BlinkRate = 1000;
            this.errorProviderDay.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDay.ContainerControl = this;
            // 
            // errorProviderMonth
            // 
            this.errorProviderMonth.BlinkRate = 1000;
            this.errorProviderMonth.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMonth.ContainerControl = this;
            // 
            // errorProviderYear
            // 
            this.errorProviderYear.BlinkRate = 1000;
            this.errorProviderYear.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderYear.ContainerControl = this;
            // 
            // authorOutput
            // 
            this.authorOutput.FormattingEnabled = true;
            this.authorOutput.Location = new System.Drawing.Point(440, 28);
            this.authorOutput.Name = "authorOutput";
            this.authorOutput.Size = new System.Drawing.Size(120, 95);
            this.authorOutput.TabIndex = 118;
            // 
            // styleOutput
            // 
            this.styleOutput.Location = new System.Drawing.Point(155, 526);
            this.styleOutput.Name = "styleOutput";
            this.styleOutput.Size = new System.Drawing.Size(490, 118);
            this.styleOutput.TabIndex = 119;
            this.styleOutput.Text = "";
            // 
            // addReferenceButton
            // 
            this.addReferenceButton.Location = new System.Drawing.Point(254, 679);
            this.addReferenceButton.Name = "addReferenceButton";
            this.addReferenceButton.Size = new System.Drawing.Size(259, 23);
            this.addReferenceButton.TabIndex = 120;
            this.addReferenceButton.Text = "Add Reference to List";
            this.addReferenceButton.UseVisualStyleBackColor = true;
            this.addReferenceButton.Click += new System.EventHandler(this.addReferenceButton_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(703, 718);
            this.Controls.Add(this.addReferenceButton);
            this.Controls.Add(this.styleOutput);
            this.Controls.Add(this.authorOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.volumeText);
            this.Controls.Add(this.endPageNumberText);
            this.Controls.Add(this.beginPageNumberText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.monthText);
            this.Controls.Add(this.journalNameText);
            this.Controls.Add(this.journalTitleText);
            this.Controls.Add(this.addJournalButton);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnToManageReferencesButton);
            this.Controls.Add(this.addAnotherJournalButton);
            this.Controls.Add(this.libMedStyleButton);
            this.Controls.Add(this.aPAStyleButton);
            this.Controls.Add(this.mLAStyleButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.mIText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label1);
            this.Name = "JournalForm";
            this.Text = "References (Journal)";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMiddleInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox mIText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnToManageReferencesButton;
        private System.Windows.Forms.Button addAnotherJournalButton;
        private System.Windows.Forms.Button libMedStyleButton;
        private System.Windows.Forms.Button aPAStyleButton;
        private System.Windows.Forms.Button mLAStyleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.TextBox volumeText;
        private System.Windows.Forms.TextBox endPageNumberText;
        private System.Windows.Forms.TextBox beginPageNumberText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox dayText;
        private System.Windows.Forms.TextBox monthText;
        private System.Windows.Forms.TextBox journalNameText;
        private System.Windows.Forms.TextBox journalTitleText;
        private System.Windows.Forms.Button addJournalButton;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderMiddleInitial;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderMonth;
        private System.Windows.Forms.ErrorProvider errorProviderDay;
        private System.Windows.Forms.ErrorProvider errorProviderYear;
        private System.Windows.Forms.ListBox authorOutput;
        private System.Windows.Forms.RichTextBox styleOutput;
        private System.Windows.Forms.Button addReferenceButton;
    }
}