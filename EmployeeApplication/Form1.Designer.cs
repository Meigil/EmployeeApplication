namespace EmployeeApplication
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            EmployeeID = new TextBox();
            Fname = new TextBox();
            Lname = new TextBox();
            Position = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(441, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(8, 8);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(159, 23);
            label1.TabIndex = 1;
            label1.Text = " Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(90, 16);
            label2.TabIndex = 2;
            label2.Text = "Employee ID *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 3;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 165);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 4;
            label4.Text = "Last name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 223);
            label5.Name = "label5";
            label5.Size = new Size(63, 16);
            label5.TabIndex = 5;
            label5.Text = "Position *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(227, 19);
            label6.Name = "label6";
            label6.Size = new Size(102, 18);
            label6.TabIndex = 6;
            label6.Text = "Employee List:";
            // 
            // EmployeeID
            // 
            EmployeeID.Location = new Point(12, 78);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(196, 23);
            EmployeeID.TabIndex = 7;
            // 
            // Fname
            // 
            Fname.Location = new Point(12, 132);
            Fname.Name = "Fname";
            Fname.Size = new Size(196, 23);
            Fname.TabIndex = 8;
            // 
            // Lname
            // 
            Lname.Location = new Point(13, 188);
            Lname.Name = "Lname";
            Lname.Size = new Size(196, 23);
            Lname.TabIndex = 9;
            // 
            // Position
            // 
            Position.Location = new Point(12, 243);
            Position.Name = "Position";
            Position.Size = new Size(196, 23);
            Position.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(49, 284);
            button1.Name = "button1";
            button1.Size = new Size(120, 28);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Location = new Point(227, 40);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(441, 272);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "firstName";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "lastName";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "position";
            Column4.Name = "Column4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 318);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(Position);
            Controls.Add(Lname);
            Controls.Add(Fname);
            Controls.Add(EmployeeID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = " Employee Database";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EmployeeID;
        private TextBox Fname;
        private TextBox Lname;
        private TextBox Position;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
