namespace DragDropQueryBuilder
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.selectedFieldLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectedFieldComboBox = new System.Windows.Forms.ComboBox();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.AddConditionButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.logicComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.opLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeConditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.queryStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 195);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // selectedFieldLayoutPanel
            // 
            this.selectedFieldLayoutPanel.AllowDrop = true;
            this.selectedFieldLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedFieldLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this.selectedFieldLayoutPanel.Name = "selectedFieldLayoutPanel";
            this.selectedFieldLayoutPanel.Size = new System.Drawing.Size(212, 508);
            this.selectedFieldLayoutPanel.TabIndex = 1;
            this.selectedFieldLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel2_DragDrop);
            this.selectedFieldLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel2_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(38, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fields";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectedFieldLayoutPanel);
            this.groupBox2.Location = new System.Drawing.Point(296, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 529);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query Box";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel);
            this.groupBox3.Location = new System.Drawing.Point(41, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Size = new System.Drawing.Size(230, 90);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.QueryTextBox.Location = new System.Drawing.Point(9, 18);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(560, 148);
            this.QueryTextBox.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.QueryTextBox);
            this.groupBox4.Location = new System.Drawing.Point(552, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 172);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query Text";
            // 
            // selectedFieldComboBox
            // 
            this.selectedFieldComboBox.FormattingEnabled = true;
            this.selectedFieldComboBox.Location = new System.Drawing.Point(136, 182);
            this.selectedFieldComboBox.Name = "selectedFieldComboBox";
            this.selectedFieldComboBox.Size = new System.Drawing.Size(121, 24);
            this.selectedFieldComboBox.TabIndex = 7;
            this.selectedFieldComboBox.Text = "Field";
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "LIKE",
            "STARTS WITH",
            "IS NULL",
            "IS NOT NULL"});
            this.operatorComboBox.Location = new System.Drawing.Point(263, 182);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(89, 24);
            this.operatorComboBox.TabIndex = 8;
            this.operatorComboBox.Text = "Relation";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(358, 183);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(116, 22);
            this.conditionTextBox.TabIndex = 9;
            // 
            // AddConditionButton
            // 
            this.AddConditionButton.Location = new System.Drawing.Point(480, 182);
            this.AddConditionButton.Name = "AddConditionButton";
            this.AddConditionButton.Size = new System.Drawing.Size(75, 24);
            this.AddConditionButton.TabIndex = 10;
            this.AddConditionButton.Text = "Add";
            this.AddConditionButton.UseVisualStyleBackColor = true;
            this.AddConditionButton.Click += new System.EventHandler(this.AddConditionButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.logicComboBox);
            this.groupBox5.Controls.Add(this.listView1);
            this.groupBox5.Controls.Add(this.AddConditionButton);
            this.groupBox5.Controls.Add(this.selectedFieldComboBox);
            this.groupBox5.Controls.Add(this.conditionTextBox);
            this.groupBox5.Controls.Add(this.operatorComboBox);
            this.groupBox5.Location = new System.Drawing.Point(552, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(575, 213);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Conditions";
            // 
            // logicComboBox
            // 
            this.logicComboBox.FormattingEnabled = true;
            this.logicComboBox.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.logicComboBox.Location = new System.Drawing.Point(49, 182);
            this.logicComboBox.Name = "logicComboBox";
            this.logicComboBox.Size = new System.Drawing.Size(81, 24);
            this.logicComboBox.TabIndex = 12;
            this.logicComboBox.SelectedIndexChanged += new System.EventHandler(this.logicComboBox_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(546, 153);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.opLayoutPanel);
            this.groupBox7.Location = new System.Drawing.Point(41, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(236, 177);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operation";
            // 
            // opLayoutPanel
            // 
            this.opLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this.opLayoutPanel.Name = "opLayoutPanel";
            this.opLayoutPanel.Size = new System.Drawing.Size(230, 156);
            this.opLayoutPanel.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeConditionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 28);
            // 
            // removeConditionToolStripMenuItem
            // 
            this.removeConditionToolStripMenuItem.Name = "removeConditionToolStripMenuItem";
            this.removeConditionToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.removeConditionToolStripMenuItem.Text = "Remove Condition";
            this.removeConditionToolStripMenuItem.Click += new System.EventHandler(this.removeConditionToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.Maroon;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(561, 444);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 96);
            this.listBox1.TabIndex = 14;
            // 
            // queryStatus
            // 
            this.queryStatus.AutoSize = true;
            this.queryStatus.ForeColor = System.Drawing.Color.Maroon;
            this.queryStatus.Location = new System.Drawing.Point(558, 417);
            this.queryStatus.Name = "queryStatus";
            this.queryStatus.Size = new System.Drawing.Size(0, 17);
            this.queryStatus.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 608);
            this.Controls.Add(this.queryStatus);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel selectedFieldLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox selectedFieldComboBox;
        private System.Windows.Forms.ComboBox operatorComboBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Button AddConditionButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.FlowLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel opLayoutPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeConditionToolStripMenuItem;
        private System.Windows.Forms.ComboBox logicComboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label queryStatus;
    }
}

