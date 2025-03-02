namespace Data_Base_Acess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            datagrid = new DataGridView();
            loadbtn = new Button();
            button2 = new Button();
            addbtn = new Button();
            deletebtn = new Button();
            refreshbtn = new Button();
            updatebtn = new Button();
            lastnamelbl = new Label();
            lastNametxtb = new TextBox();
            firstNametxtb = new TextBox();
            firstnamelbl = new Label();
            courselbl = new Label();
            yeartxtb = new TextBox();
            yearlbl = new Label();
            gradetxtb = new TextBox();
            gradelbl = new Label();
            subjecttxtb = new TextBox();
            subjectlbl = new Label();
            idlbl = new Label();
            panel2 = new Panel();
            studentPictureBox = new PictureBox();
            coursebx = new ComboBox();
            clearbtn = new Button();
            filebtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(datagrid);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(349, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 791);
            panel1.TabIndex = 1;
            // 
            // datagrid
            // 
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Dock = DockStyle.Right;
            datagrid.Location = new Point(2, 0);
            datagrid.Margin = new Padding(3, 4, 3, 4);
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            datagrid.Size = new Size(1001, 791);
            datagrid.TabIndex = 0;
            datagrid.RowHeaderMouseClick += datagrid_RowHeaderMouseClick;
            // 
            // loadbtn
            // 
            loadbtn.FlatStyle = FlatStyle.Flat;
            loadbtn.Image = (Image)resources.GetObject("loadbtn.Image");
            loadbtn.Location = new Point(47, 539);
            loadbtn.Margin = new Padding(3, 4, 3, 4);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(56, 52);
            loadbtn.TabIndex = 2;
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            loadbtn.MouseHover += loadbtn_MouseHover;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(111, 539);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(58, 52);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseHover += button2_MouseHover;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Azure;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Location = new Point(38, 624);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(125, 39);
            addbtn.TabIndex = 5;
            addbtn.Text = "Add Student";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Azure;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Location = new Point(185, 624);
            deletebtn.Margin = new Padding(3, 4, 3, 4);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(124, 39);
            deletebtn.TabIndex = 4;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click_1;
            // 
            // refreshbtn
            // 
            refreshbtn.FlatStyle = FlatStyle.Flat;
            refreshbtn.Image = (Image)resources.GetObject("refreshbtn.Image");
            refreshbtn.Location = new Point(175, 539);
            refreshbtn.Margin = new Padding(3, 4, 3, 4);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(58, 52);
            refreshbtn.TabIndex = 7;
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            refreshbtn.MouseHover += refreshbtn_MouseHover;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Azure;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Location = new Point(38, 671);
            updatebtn.Margin = new Padding(3, 4, 3, 4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(125, 39);
            updatebtn.TabIndex = 6;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // lastnamelbl
            // 
            lastnamelbl.AutoSize = true;
            lastnamelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lastnamelbl.Location = new Point(41, 150);
            lastnamelbl.Name = "lastnamelbl";
            lastnamelbl.Size = new Size(84, 20);
            lastnamelbl.TabIndex = 8;
            lastnamelbl.Text = "Last Name";
            // 
            // lastNametxtb
            // 
            lastNametxtb.Location = new Point(41, 174);
            lastNametxtb.Margin = new Padding(3, 4, 3, 4);
            lastNametxtb.Name = "lastNametxtb";
            lastNametxtb.Size = new Size(268, 27);
            lastNametxtb.TabIndex = 9;
            // 
            // firstNametxtb
            // 
            firstNametxtb.Location = new Point(41, 234);
            firstNametxtb.Margin = new Padding(3, 4, 3, 4);
            firstNametxtb.Name = "firstNametxtb";
            firstNametxtb.Size = new Size(268, 27);
            firstNametxtb.TabIndex = 11;
            // 
            // firstnamelbl
            // 
            firstnamelbl.AutoSize = true;
            firstnamelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            firstnamelbl.Location = new Point(41, 210);
            firstnamelbl.Name = "firstnamelbl";
            firstnamelbl.Size = new Size(86, 20);
            firstnamelbl.TabIndex = 10;
            firstnamelbl.Text = "First Name";
            // 
            // courselbl
            // 
            courselbl.AutoSize = true;
            courselbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            courselbl.Location = new Point(41, 274);
            courselbl.Name = "courselbl";
            courselbl.Size = new Size(57, 20);
            courselbl.TabIndex = 12;
            courselbl.Text = "Course";
            // 
            // yeartxtb
            // 
            yeartxtb.Location = new Point(41, 363);
            yeartxtb.Margin = new Padding(3, 4, 3, 4);
            yeartxtb.Name = "yeartxtb";
            yeartxtb.Size = new Size(268, 27);
            yeartxtb.TabIndex = 15;
            // 
            // yearlbl
            // 
            yearlbl.AutoSize = true;
            yearlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            yearlbl.Location = new Point(41, 339);
            yearlbl.Name = "yearlbl";
            yearlbl.Size = new Size(79, 20);
            yearlbl.TabIndex = 14;
            yearlbl.Text = "Year Level";
            // 
            // gradetxtb
            // 
            gradetxtb.Location = new Point(41, 487);
            gradetxtb.Margin = new Padding(3, 4, 3, 4);
            gradetxtb.Name = "gradetxtb";
            gradetxtb.Size = new Size(268, 27);
            gradetxtb.TabIndex = 20;
            // 
            // gradelbl
            // 
            gradelbl.AutoSize = true;
            gradelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gradelbl.Location = new Point(41, 463);
            gradelbl.Name = "gradelbl";
            gradelbl.Size = new Size(88, 20);
            gradelbl.TabIndex = 19;
            gradelbl.Text = "Final Grade";
            // 
            // subjecttxtb
            // 
            subjecttxtb.Location = new Point(41, 422);
            subjecttxtb.Margin = new Padding(3, 4, 3, 4);
            subjecttxtb.Name = "subjecttxtb";
            subjecttxtb.Size = new Size(268, 27);
            subjecttxtb.TabIndex = 18;
            // 
            // subjectlbl
            // 
            subjectlbl.AutoSize = true;
            subjectlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            subjectlbl.Location = new Point(41, 398);
            subjectlbl.Name = "subjectlbl";
            subjectlbl.Size = new Size(60, 20);
            subjectlbl.TabIndex = 17;
            subjectlbl.Text = "Subject";
            // 
            // idlbl
            // 
            idlbl.AutoSize = true;
            idlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            idlbl.Location = new Point(210, 127);
            idlbl.Name = "idlbl";
            idlbl.Size = new Size(88, 20);
            idlbl.TabIndex = 21;
            idlbl.Text = "Student ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(studentPictureBox);
            panel2.Location = new Point(41, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 135);
            panel2.TabIndex = 22;
            // 
            // studentPictureBox
            // 
            studentPictureBox.InitialImage = (Image)resources.GetObject("studentPictureBox.InitialImage");
            studentPictureBox.Location = new Point(3, 3);
            studentPictureBox.Name = "studentPictureBox";
            studentPictureBox.Size = new Size(157, 129);
            studentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPictureBox.TabIndex = 0;
            studentPictureBox.TabStop = false;
            // 
            // coursebx
            // 
            coursebx.DropDownStyle = ComboBoxStyle.DropDownList;
            coursebx.FormattingEnabled = true;
            coursebx.Items.AddRange(new object[] { "BSCPE", "BSCE", "BSEE", "BSECE", "BSME", "BSChE", "BSMetE", "BSAE", "BSIE", "BSArchi", "BSEnSE", "BSBio", "BSChem", "BSPsych", "BSPH", "BSCS", "BSChemE", "BSMath", "BSStat", "BSPh", "BSTM", "BSHM", "BSA", "BSBA", "BSHRM", "BSN", "BSMT", "BSIT", "BSIS" });
            coursebx.Location = new Point(41, 308);
            coursebx.Name = "coursebx";
            coursebx.Size = new Size(268, 28);
            coursebx.TabIndex = 23;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.Azure;
            clearbtn.FlatStyle = FlatStyle.Flat;
            clearbtn.Location = new Point(185, 671);
            clearbtn.Margin = new Padding(3, 4, 3, 4);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(124, 39);
            clearbtn.TabIndex = 24;
            clearbtn.Text = "Clear Fields";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // filebtn
            // 
            filebtn.FlatStyle = FlatStyle.Flat;
            filebtn.Image = (Image)resources.GetObject("filebtn.Image");
            filebtn.Location = new Point(240, 539);
            filebtn.Margin = new Padding(3, 4, 3, 4);
            filebtn.Name = "filebtn";
            filebtn.Size = new Size(58, 52);
            filebtn.TabIndex = 25;
            filebtn.UseVisualStyleBackColor = true;
            filebtn.Click += filebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1352, 791);
            Controls.Add(filebtn);
            Controls.Add(clearbtn);
            Controls.Add(coursebx);
            Controls.Add(panel2);
            Controls.Add(idlbl);
            Controls.Add(gradetxtb);
            Controls.Add(gradelbl);
            Controls.Add(subjecttxtb);
            Controls.Add(subjectlbl);
            Controls.Add(yeartxtb);
            Controls.Add(yearlbl);
            Controls.Add(courselbl);
            Controls.Add(firstNametxtb);
            Controls.Add(firstnamelbl);
            Controls.Add(lastNametxtb);
            Controls.Add(lastnamelbl);
            Controls.Add(refreshbtn);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(deletebtn);
            Controls.Add(button2);
            Controls.Add(loadbtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataBase with Access";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button loadbtn;
        private Button button2;
        private Button addbtn;
        private Button deletebtn;
        private Button refreshbtn;
        private Button updatebtn;
        private DataGridView datagrid;
        private Label lastnamelbl;
        private TextBox lastNametxtb;
        private TextBox firstNametxtb;
        private Label firstnamelbl;
        private Label courselbl;
        private TextBox yeartxtb;
        private Label yearlbl;
        private TextBox gradetxtb;
        private Label gradelbl;
        private TextBox subjecttxtb;
        private Label subjectlbl;
        private Label idlbl;
        private Panel panel2;
        private PictureBox studentPictureBox;
        private ComboBox coursebx;
        private Button clearbtn;
        private Button filebtn;
    }
}
