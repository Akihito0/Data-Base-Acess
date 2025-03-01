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
            button3 = new Button();
            deletebtn = new Button();
            button5 = new Button();
            button6 = new Button();
            lastnamelbl = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            firstnamelbl = new Label();
            textBox3 = new TextBox();
            courselbl = new Label();
            textBox4 = new TextBox();
            yearlbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(datagrid);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(463, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 791);
            panel1.TabIndex = 1;
            // 
            // datagrid
            // 
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Location = new Point(0, 0);
            datagrid.Margin = new Padding(3, 4, 3, 4);
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            datagrid.Size = new Size(889, 791);
            datagrid.TabIndex = 0;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(78, 514);
            loadbtn.Margin = new Padding(3, 4, 3, 4);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(121, 63);
            loadbtn.TabIndex = 2;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(224, 514);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(121, 63);
            button2.TabIndex = 3;
            button2.Text = "Test Connection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(224, 594);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(121, 63);
            button3.TabIndex = 5;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(78, 594);
            deletebtn.Margin = new Padding(3, 4, 3, 4);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(121, 63);
            deletebtn.TabIndex = 4;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(224, 678);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(121, 63);
            button5.TabIndex = 7;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(78, 678);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(121, 63);
            button6.TabIndex = 6;
            button6.Text = "Edit";
            button6.UseVisualStyleBackColor = true;
            // 
            // lastnamelbl
            // 
            lastnamelbl.AutoSize = true;
            lastnamelbl.Location = new Point(41, 150);
            lastnamelbl.Name = "lastnamelbl";
            lastnamelbl.Size = new Size(79, 20);
            lastnamelbl.TabIndex = 8;
            lastnamelbl.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 174);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 250);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 27);
            textBox2.TabIndex = 11;
            // 
            // firstnamelbl
            // 
            firstnamelbl.AutoSize = true;
            firstnamelbl.Location = new Point(41, 226);
            firstnamelbl.Name = "firstnamelbl";
            firstnamelbl.Size = new Size(80, 20);
            firstnamelbl.TabIndex = 10;
            firstnamelbl.Text = "First Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 329);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 27);
            textBox3.TabIndex = 13;
            // 
            // courselbl
            // 
            courselbl.AutoSize = true;
            courselbl.Location = new Point(41, 305);
            courselbl.Name = "courselbl";
            courselbl.Size = new Size(54, 20);
            courselbl.TabIndex = 12;
            courselbl.Text = "Course";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(41, 413);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 27);
            textBox4.TabIndex = 15;
            // 
            // yearlbl
            // 
            yearlbl.AutoSize = true;
            yearlbl.Location = new Point(41, 389);
            yearlbl.Name = "yearlbl";
            yearlbl.Size = new Size(37, 20);
            yearlbl.TabIndex = 14;
            yearlbl.Text = "Year";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 791);
            Controls.Add(textBox4);
            Controls.Add(yearlbl);
            Controls.Add(textBox3);
            Controls.Add(courselbl);
            Controls.Add(textBox2);
            Controls.Add(firstnamelbl);
            Controls.Add(textBox1);
            Controls.Add(lastnamelbl);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button loadbtn;
        private Button button2;
        private Button button3;
        private Button deletebtn;
        private Button button5;
        private Button button6;
        private DataGridView datagrid;
        private Label lastnamelbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label firstnamelbl;
        private TextBox textBox3;
        private Label courselbl;
        private TextBox textBox4;
        private Label yearlbl;
    }
}
