namespace GradeManagmentSystem
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            logsToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            txtStdID = new TextBox();
            txtMarks = new TextBox();
            listBox1 = new ListBox();
            rbCompulsory = new RadioButton();
            rbOptional = new RadioButton();
            txtGrade = new TextBox();
            Add = new Button();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 108);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 168);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Course Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 225);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 286);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Marks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 338);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Grade";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(111, 28);
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(110, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem1, logsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(55, 24);
            viewToolStripMenuItem1.Text = "View";
            viewToolStripMenuItem1.Click += viewToolStripMenuItem1_Click;
            // 
            // logsToolStripMenuItem
            // 
            logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            logsToolStripMenuItem.Size = new Size(54, 24);
            logsToolStripMenuItem.Text = "Logs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(189, 0);
            label6.Name = "label6";
            label6.Size = new Size(463, 37);
            label6.TabIndex = 9;
            label6.Text = "Student Grade Managment System";
            // 
            // txtStdID
            // 
            txtStdID.Location = new Point(223, 108);
            txtStdID.Name = "txtStdID";
            txtStdID.Size = new Size(399, 27);
            txtStdID.TabIndex = 10;
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(223, 286);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(399, 27);
            txtMarks.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "COSC 31102", "COST 31112", "BECS 32242" });
            listBox1.Location = new Point(223, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 24);
            listBox1.TabIndex = 12;
            // 
            // rbCompulsory
            // 
            rbCompulsory.AutoSize = true;
            rbCompulsory.Location = new Point(233, 230);
            rbCompulsory.Name = "rbCompulsory";
            rbCompulsory.Size = new Size(108, 24);
            rbCompulsory.TabIndex = 13;
            rbCompulsory.TabStop = true;
            rbCompulsory.Text = "Compulsary";
            rbCompulsory.UseVisualStyleBackColor = true;
            // 
            // rbOptional
            // 
            rbOptional.AutoSize = true;
            rbOptional.Location = new Point(443, 230);
            rbOptional.Name = "rbOptional";
            rbOptional.Size = new Size(88, 24);
            rbOptional.TabIndex = 14;
            rbOptional.TabStop = true;
            rbOptional.Text = "Optional";
            rbOptional.UseVisualStyleBackColor = true;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(223, 338);
            txtGrade.Name = "txtGrade";
            txtGrade.ReadOnly = true;
            txtGrade.Size = new Size(399, 27);
            txtGrade.TabIndex = 15;
            // 
            // Add
            // 
            Add.Location = new Point(615, 401);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 16;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add);
            Controls.Add(txtGrade);
            Controls.Add(rbOptional);
            Controls.Add(rbCompulsory);
            Controls.Add(listBox1);
            Controls.Add(txtMarks);
            Controls.Add(txtStdID);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem logsToolStripMenuItem;
        private Label label6;
        private TextBox txtStdID;
        private TextBox txtMarks;
        private ListBox listBox1;
        private RadioButton rbCompulsory;
        private RadioButton rbOptional;
        public TextBox txtGrade;
        private Button Add;
    }
}
