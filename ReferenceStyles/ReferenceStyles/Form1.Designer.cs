namespace ReferenceStyles
{
    partial class Form1
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
            this.formatTitle = new System.Windows.Forms.Button();
            this.formatName = new System.Windows.Forms.Button();
            this.formatDate = new System.Windows.Forms.Button();
            this.titleOutput = new System.Windows.Forms.TextBox();
            this.nameOutputText = new System.Windows.Forms.TextBox();
            this.dateOutputText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.middleInitialText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.monthText = new System.Windows.Forms.TextBox();
            this.dayText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderDay = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDay)).BeginInit();
            this.SuspendLayout();
            // 
            // formatTitle
            // 
            this.formatTitle.Location = new System.Drawing.Point(267, 434);
            this.formatTitle.Name = "formatTitle";
            this.formatTitle.Size = new System.Drawing.Size(138, 23);
            this.formatTitle.TabIndex = 9;
            this.formatTitle.Text = "Show Title Formats";
            this.formatTitle.UseVisualStyleBackColor = true;
            this.formatTitle.Click += new System.EventHandler(this.formatTitle_Click);
            // 
            // formatName
            // 
            this.formatName.Location = new System.Drawing.Point(267, 284);
            this.formatName.Name = "formatName";
            this.formatName.Size = new System.Drawing.Size(138, 23);
            this.formatName.TabIndex = 8;
            this.formatName.Text = "Show Name Formats";
            this.formatName.UseVisualStyleBackColor = true;
            this.formatName.Click += new System.EventHandler(this.formatName_Click);
            // 
            // formatDate
            // 
            this.formatDate.Location = new System.Drawing.Point(267, 85);
            this.formatDate.Name = "formatDate";
            this.formatDate.Size = new System.Drawing.Size(138, 23);
            this.formatDate.TabIndex = 7;
            this.formatDate.Text = "Show Date Formats";
            this.formatDate.UseVisualStyleBackColor = true;
            this.formatDate.Click += new System.EventHandler(this.formatDate_Click);
            // 
            // titleOutput
            // 
            this.titleOutput.Location = new System.Drawing.Point(439, 404);
            this.titleOutput.Multiline = true;
            this.titleOutput.Name = "titleOutput";
            this.titleOutput.ReadOnly = true;
            this.titleOutput.Size = new System.Drawing.Size(185, 156);
            this.titleOutput.TabIndex = 12;
            this.titleOutput.TabStop = false;
            // 
            // nameOutputText
            // 
            this.nameOutputText.Location = new System.Drawing.Point(439, 203);
            this.nameOutputText.Multiline = true;
            this.nameOutputText.Name = "nameOutputText";
            this.nameOutputText.ReadOnly = true;
            this.nameOutputText.Size = new System.Drawing.Size(185, 177);
            this.nameOutputText.TabIndex = 11;
            this.nameOutputText.TabStop = false;
            // 
            // dateOutputText
            // 
            this.dateOutputText.Location = new System.Drawing.Point(439, 26);
            this.dateOutputText.Multiline = true;
            this.dateOutputText.Name = "dateOutputText";
            this.dateOutputText.Size = new System.Drawing.Size(185, 149);
            this.dateOutputText.TabIndex = 10;
            this.dateOutputText.TabStop = false;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(71, 436);
            this.titleText.MaxLength = 100;
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(165, 20);
            this.titleText.TabIndex = 6;
            this.titleText.TextChanged += new System.EventHandler(this.titleText_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(80, 312);
            this.lastNameText.MaxLength = 20;
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 5;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // middleInitialText
            // 
            this.middleInitialText.Location = new System.Drawing.Point(80, 286);
            this.middleInitialText.MaxLength = 1;
            this.middleInitialText.Name = "middleInitialText";
            this.middleInitialText.Size = new System.Drawing.Size(100, 20);
            this.middleInitialText.TabIndex = 4;
            this.middleInitialText.TextChanged += new System.EventHandler(this.middleInitialText_TextChanged);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(80, 260);
            this.firstNameText.MaxLength = 20;
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 20);
            this.firstNameText.TabIndex = 3;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(80, 87);
            this.yearText.MaxLength = 10;
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 20);
            this.yearText.TabIndex = 1;
            this.yearText.TextChanged += new System.EventHandler(this.yearText_TextChanged);
            // 
            // monthText
            // 
            this.monthText.Location = new System.Drawing.Point(80, 61);
            this.monthText.MaxLength = 10;
            this.monthText.Name = "monthText";
            this.monthText.Size = new System.Drawing.Size(100, 20);
            this.monthText.TabIndex = 0;
            this.monthText.TextChanged += new System.EventHandler(this.monthText_TextChanged);
            // 
            // dayText
            // 
            this.dayText.Location = new System.Drawing.Point(79, 113);
            this.dayText.MaxLength = 2;
            this.dayText.Name = "dayText";
            this.dayText.Size = new System.Drawing.Size(100, 20);
            this.dayText.TabIndex = 2;
            this.dayText.TextChanged += new System.EventHandler(this.dayText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Middle Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Day";
            // 
            // errorProviderDay
            // 
            this.errorProviderDay.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(691, 591);
            this.Controls.Add(this.formatTitle);
            this.Controls.Add(this.formatName);
            this.Controls.Add(this.formatDate);
            this.Controls.Add(this.titleOutput);
            this.Controls.Add(this.nameOutputText);
            this.Controls.Add(this.dateOutputText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.middleInitialText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.monthText);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Reference Styles: Date, Name, and Title Formats";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formatTitle;
        private System.Windows.Forms.Button formatName;
        private System.Windows.Forms.Button formatDate;
        private System.Windows.Forms.TextBox titleOutput;
        private System.Windows.Forms.TextBox nameOutputText;
        private System.Windows.Forms.TextBox dateOutputText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox middleInitialText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox monthText;
        private System.Windows.Forms.TextBox dayText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderDay;
        private System.Windows.Forms.ErrorProvider errorProviderMonth;
        private System.Windows.Forms.ErrorProvider errorProviderYear;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderMiddleInitial;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderTitle;
    }
}

