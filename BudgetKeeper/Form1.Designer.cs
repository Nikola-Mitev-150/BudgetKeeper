namespace BudgetKeaper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PeriodButton = new System.Windows.Forms.Button();
            this.RadButMonth = new System.Windows.Forms.RadioButton();
            this.RadButWeek = new System.Windows.Forms.RadioButton();
            this.RadButDay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AddExpenseButton = new System.Windows.Forms.Button();
            this.CostTxtBox = new System.Windows.Forms.RichTextBox();
            this.ItemNameBox = new System.Windows.Forms.RichTextBox();
            this.MainBudgetLbl = new System.Windows.Forms.Label();
            this.SetBudgetButton = new System.Windows.Forms.Button();
            this.BudgetTxtBox = new System.Windows.Forms.TextBox();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.NoEditbutton = new System.Windows.Forms.Button();
            this.YesEditbutton = new System.Windows.Forms.Button();
            this.CautionLabel = new System.Windows.Forms.Label();
            this.SliderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HistoryList = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nullifyProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PeriodButton);
            this.panel1.Controls.Add(this.RadButMonth);
            this.panel1.Controls.Add(this.RadButWeek);
            this.panel1.Controls.Add(this.RadButDay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddExpenseButton);
            this.panel1.Controls.Add(this.CostTxtBox);
            this.panel1.Controls.Add(this.ItemNameBox);
            this.panel1.Controls.Add(this.MainBudgetLbl);
            this.panel1.Controls.Add(this.SetBudgetButton);
            this.panel1.Controls.Add(this.BudgetTxtBox);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(33, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 362);
            this.panel1.TabIndex = 0;
            // 
            // PeriodButton
            // 
            this.PeriodButton.Location = new System.Drawing.Point(242, 80);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(104, 28);
            this.PeriodButton.TabIndex = 11;
            this.PeriodButton.Text = "Time Period";
            this.PeriodButton.UseVisualStyleBackColor = true;
            this.PeriodButton.Click += new System.EventHandler(this.PeriodButton_Click);
            // 
            // RadButMonth
            // 
            this.RadButMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadButMonth.AutoSize = true;
            this.RadButMonth.Location = new System.Drawing.Point(242, 171);
            this.RadButMonth.Name = "RadButMonth";
            this.RadButMonth.Size = new System.Drawing.Size(101, 27);
            this.RadButMonth.TabIndex = 10;
            this.RadButMonth.TabStop = true;
            this.RadButMonth.Text = "1 Month";
            this.RadButMonth.UseVisualStyleBackColor = true;
            this.RadButMonth.Visible = false;
            this.RadButMonth.Click += new System.EventHandler(this.RadButMonth_Click);
            // 
            // RadButWeek
            // 
            this.RadButWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadButWeek.AutoSize = true;
            this.RadButWeek.Location = new System.Drawing.Point(242, 142);
            this.RadButWeek.Name = "RadButWeek";
            this.RadButWeek.Size = new System.Drawing.Size(95, 27);
            this.RadButWeek.TabIndex = 9;
            this.RadButWeek.TabStop = true;
            this.RadButWeek.Text = "1 Week";
            this.RadButWeek.UseVisualStyleBackColor = true;
            this.RadButWeek.Visible = false;
            this.RadButWeek.Click += new System.EventHandler(this.RadButWeel_Click);
            // 
            // RadButDay
            // 
            this.RadButDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadButDay.AutoSize = true;
            this.RadButDay.Location = new System.Drawing.Point(242, 114);
            this.RadButDay.Name = "RadButDay";
            this.RadButDay.Size = new System.Drawing.Size(80, 27);
            this.RadButDay.TabIndex = 8;
            this.RadButDay.TabStop = true;
            this.RadButDay.Text = "1 Day";
            this.RadButDay.UseVisualStyleBackColor = true;
            this.RadButDay.Visible = false;
            this.RadButDay.Click += new System.EventHandler(this.RadButDay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(322, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Item and it\'s cost here:\r\n";
            // 
            // AddExpenseButton
            // 
            this.AddExpenseButton.Enabled = false;
            this.AddExpenseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpenseButton.Location = new System.Drawing.Point(618, 277);
            this.AddExpenseButton.Name = "AddExpenseButton";
            this.AddExpenseButton.Size = new System.Drawing.Size(121, 56);
            this.AddExpenseButton.TabIndex = 6;
            this.AddExpenseButton.Text = "Confirm";
            this.AddExpenseButton.UseVisualStyleBackColor = true;
            this.AddExpenseButton.Click += new System.EventHandler(this.AddExpenseButton_Click);
            // 
            // CostTxtBox
            // 
            this.CostTxtBox.Location = new System.Drawing.Point(543, 277);
            this.CostTxtBox.Name = "CostTxtBox";
            this.CostTxtBox.Size = new System.Drawing.Size(69, 56);
            this.CostTxtBox.TabIndex = 5;
            this.CostTxtBox.Text = "";
            this.CostTxtBox.TextChanged += new System.EventHandler(this.CostTxtBox_TextChanged);
            this.CostTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTxtBoxPress);
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Location = new System.Drawing.Point(318, 277);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(201, 56);
            this.ItemNameBox.TabIndex = 4;
            this.ItemNameBox.Text = "";
            this.ItemNameBox.TextChanged += new System.EventHandler(this.ItemBoxChanged);
            // 
            // MainBudgetLbl
            // 
            this.MainBudgetLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBudgetLbl.AutoSize = true;
            this.MainBudgetLbl.Location = new System.Drawing.Point(382, 52);
            this.MainBudgetLbl.Name = "MainBudgetLbl";
            this.MainBudgetLbl.Size = new System.Drawing.Size(20, 23);
            this.MainBudgetLbl.TabIndex = 2;
            this.MainBudgetLbl.Text = "0";
            // 
            // SetBudgetButton
            // 
            this.SetBudgetButton.Enabled = false;
            this.SetBudgetButton.Location = new System.Drawing.Point(543, 82);
            this.SetBudgetButton.Name = "SetBudgetButton";
            this.SetBudgetButton.Size = new System.Drawing.Size(104, 27);
            this.SetBudgetButton.TabIndex = 1;
            this.SetBudgetButton.Text = "Confirm";
            this.SetBudgetButton.UseVisualStyleBackColor = true;
            this.SetBudgetButton.Click += new System.EventHandler(this.SetBudgetButton_Click);
            // 
            // BudgetTxtBox
            // 
            this.BudgetTxtBox.Location = new System.Drawing.Point(386, 84);
            this.BudgetTxtBox.Name = "BudgetTxtBox";
            this.BudgetTxtBox.Size = new System.Drawing.Size(131, 30);
            this.BudgetTxtBox.TabIndex = 0;
            this.BudgetTxtBox.Text = "  ";
            this.BudgetTxtBox.TextChanged += new System.EventHandler(this.BudgetTxtBox_TextChanged);
            this.BudgetTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BudgetTextBoxPress);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.NoEditbutton);
            this.EditPanel.Controls.Add(this.YesEditbutton);
            this.EditPanel.Controls.Add(this.CautionLabel);
            this.EditPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.EditPanel.Location = new System.Drawing.Point(94, 14);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1001, 427);
            this.EditPanel.TabIndex = 15;
            this.EditPanel.Visible = false;
            // 
            // NoEditbutton
            // 
            this.NoEditbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.NoEditbutton.ForeColor = System.Drawing.Color.Black;
            this.NoEditbutton.Location = new System.Drawing.Point(544, 196);
            this.NoEditbutton.Name = "NoEditbutton";
            this.NoEditbutton.Size = new System.Drawing.Size(75, 23);
            this.NoEditbutton.TabIndex = 2;
            this.NoEditbutton.Text = "NO";
            this.NoEditbutton.UseVisualStyleBackColor = true;
            this.NoEditbutton.Click += new System.EventHandler(this.NoEditButtonClick);
            // 
            // YesEditbutton
            // 
            this.YesEditbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.YesEditbutton.ForeColor = System.Drawing.Color.Black;
            this.YesEditbutton.Location = new System.Drawing.Point(192, 196);
            this.YesEditbutton.Name = "YesEditbutton";
            this.YesEditbutton.Size = new System.Drawing.Size(75, 23);
            this.YesEditbutton.TabIndex = 1;
            this.YesEditbutton.Text = "YES";
            this.YesEditbutton.UseVisualStyleBackColor = true;
            this.YesEditbutton.Click += new System.EventHandler(this.YesEditButtonClick);
            // 
            // CautionLabel
            // 
            this.CautionLabel.AutoSize = true;
            this.CautionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CautionLabel.Location = new System.Drawing.Point(222, 78);
            this.CautionLabel.Name = "CautionLabel";
            this.CautionLabel.Size = new System.Drawing.Size(60, 23);
            this.CautionLabel.TabIndex = 0;
            this.CautionLabel.Text = "label1";
            // 
            // SliderButton
            // 
            this.SliderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SliderButton.Location = new System.Drawing.Point(1000, 31);
            this.SliderButton.Name = "SliderButton";
            this.SliderButton.Size = new System.Drawing.Size(143, 52);
            this.SliderButton.TabIndex = 1;
            this.SliderButton.Text = "Options";
            this.SliderButton.UseVisualStyleBackColor = true;
            this.SliderButton.Click += new System.EventHandler(this.SlideButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HistoryList);
            this.panel2.Location = new System.Drawing.Point(184, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 566);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // HistoryList
            // 
            this.HistoryList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.HistoryList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.HistoryList.HideSelection = false;
            this.HistoryList.Location = new System.Drawing.Point(18, 16);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(739, 470);
            this.HistoryList.TabIndex = 0;
            this.HistoryList.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 116);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.nullifyProgramToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.editToolStripMenuItem.Text = "Edit Information";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // nullifyProgramToolStripMenuItem
            // 
            this.nullifyProgramToolStripMenuItem.Name = "nullifyProgramToolStripMenuItem";
            this.nullifyProgramToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.nullifyProgramToolStripMenuItem.Text = "Nullify Program";
            this.nullifyProgramToolStripMenuItem.Click += new System.EventHandler(this.nullifyProgramToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.SliderButton);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SliderButton;
        private System.Windows.Forms.Label MainBudgetLbl;
        private System.Windows.Forms.Button SetBudgetButton;
        private System.Windows.Forms.TextBox BudgetTxtBox;
        private System.Windows.Forms.Button AddExpenseButton;
        private System.Windows.Forms.RichTextBox CostTxtBox;
        private System.Windows.Forms.RichTextBox ItemNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView HistoryList;
        private System.Windows.Forms.Button PeriodButton;
        private System.Windows.Forms.RadioButton RadButMonth;
        private System.Windows.Forms.RadioButton RadButWeek;
        private System.Windows.Forms.RadioButton RadButDay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nullifyProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button NoEditbutton;
        private System.Windows.Forms.Button YesEditbutton;
        private System.Windows.Forms.Label CautionLabel;
    }
}

