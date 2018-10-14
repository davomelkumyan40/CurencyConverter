namespace Rate_General
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.generalPanel = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.general_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.menubar = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.PictureBox();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Button();
            this.more = new System.Windows.Forms.Button();
            this.exchangeButton = new System.Windows.Forms.Button();
            this.exchangePanel = new System.Windows.Forms.Panel();
            this.money_result = new System.Windows.Forms.RichTextBox();
            this.money = new System.Windows.Forms.RichTextBox();
            this.updateHistory = new System.Windows.Forms.Label();
            this.check_Auto = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.convert_money = new System.Windows.Forms.Button();
            this.change_money2 = new System.Windows.Forms.ComboBox();
            this.change_money = new System.Windows.Forms.ComboBox();
            this.autoChecker = new System.Windows.Forms.Timer(this.components);
            this.updateBoard = new System.Windows.Forms.RichTextBox();
            this.generalPanel.SuspendLayout();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.exchangePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalPanel
            // 
            this.generalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.generalPanel.Controls.Add(this.close);
            this.generalPanel.Controls.Add(this.button1);
            this.generalPanel.Controls.Add(this.general_label);
            this.generalPanel.Controls.Add(this.panel3);
            this.generalPanel.Controls.Add(this.update);
            this.generalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalPanel.Location = new System.Drawing.Point(0, 0);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(854, 68);
            this.generalPanel.TabIndex = 0;
            this.generalPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseDown);
            this.generalPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseMove);
            this.generalPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseUp);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(770, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(84, 68);
            this.close.TabIndex = 22;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(680, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 68);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.menubar_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.menubar_MouseLeave);
            // 
            // general_label
            // 
            this.general_label.AutoSize = true;
            this.general_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.general_label.ForeColor = System.Drawing.Color.White;
            this.general_label.Location = new System.Drawing.Point(67, 9);
            this.general_label.Name = "general_label";
            this.general_label.Size = new System.Drawing.Size(195, 29);
            this.general_label.TabIndex = 20;
            this.general_label.Text = "Auto Exchanger";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(230, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 307);
            this.panel3.TabIndex = 2;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(590, 0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(84, 68);
            this.update.TabIndex = 19;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            this.update.MouseEnter += new System.EventHandler(this.menubar_MouseEnter);
            this.update.MouseLeave += new System.EventHandler(this.menubar_MouseLeave);
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.menubar.Controls.Add(this.menu);
            this.menubar.Controls.Add(this.user);
            this.menubar.Controls.Add(this.buttonsPanel);
            this.menubar.Location = new System.Drawing.Point(-6, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(67, 376);
            this.menubar.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(6, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(61, 68);
            this.menu.TabIndex = 23;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(-161, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(67, 68);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user.TabIndex = 6;
            this.user.TabStop = false;
            this.user.MouseEnter += new System.EventHandler(this.user_MouseEnter);
            this.user.MouseLeave += new System.EventHandler(this.user_MouseLeave);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.buttonsPanel.Controls.Add(this.info);
            this.buttonsPanel.Controls.Add(this.more);
            this.buttonsPanel.Controls.Add(this.exchangeButton);
            this.buttonsPanel.Enabled = false;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 69);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(222, 304);
            this.buttonsPanel.TabIndex = 5;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Dock = System.Windows.Forms.DockStyle.Top;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(0, 202);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(222, 102);
            this.info.TabIndex = 4;
            this.info.Text = "Info";
            this.info.UseVisualStyleBackColor = false;
            this.info.MouseEnter += new System.EventHandler(this.menubar_MouseEnter);
            this.info.MouseLeave += new System.EventHandler(this.menubar_MouseLeave);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.more.Dock = System.Windows.Forms.DockStyle.Top;
            this.more.FlatAppearance.BorderSize = 0;
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.ForeColor = System.Drawing.Color.White;
            this.more.Location = new System.Drawing.Point(0, 101);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(222, 101);
            this.more.TabIndex = 3;
            this.more.Text = "More";
            this.more.UseVisualStyleBackColor = false;
            this.more.MouseEnter += new System.EventHandler(this.menubar_MouseEnter);
            this.more.MouseLeave += new System.EventHandler(this.menubar_MouseLeave);
            // 
            // exchangeButton
            // 
            this.exchangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.exchangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exchangeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exchangeButton.FlatAppearance.BorderSize = 0;
            this.exchangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exchangeButton.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeButton.ForeColor = System.Drawing.Color.White;
            this.exchangeButton.Location = new System.Drawing.Point(0, 0);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(222, 101);
            this.exchangeButton.TabIndex = 2;
            this.exchangeButton.Text = "   Exchange";
            this.exchangeButton.UseVisualStyleBackColor = false;
            this.exchangeButton.MouseEnter += new System.EventHandler(this.menubar_MouseEnter);
            this.exchangeButton.MouseLeave += new System.EventHandler(this.menubar_MouseLeave);
            // 
            // exchangePanel
            // 
            this.exchangePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.exchangePanel.Controls.Add(this.updateBoard);
            this.exchangePanel.Controls.Add(this.money_result);
            this.exchangePanel.Controls.Add(this.money);
            this.exchangePanel.Controls.Add(this.updateHistory);
            this.exchangePanel.Controls.Add(this.check_Auto);
            this.exchangePanel.Controls.Add(this.label4);
            this.exchangePanel.Controls.Add(this.label2);
            this.exchangePanel.Controls.Add(this.label1);
            this.exchangePanel.Controls.Add(this.convert_money);
            this.exchangePanel.Controls.Add(this.change_money2);
            this.exchangePanel.Controls.Add(this.change_money);
            this.exchangePanel.Location = new System.Drawing.Point(62, 68);
            this.exchangePanel.Name = "exchangePanel";
            this.exchangePanel.Size = new System.Drawing.Size(792, 307);
            this.exchangePanel.TabIndex = 2;
            // 
            // money_result
            // 
            this.money_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.money_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_result.Location = new System.Drawing.Point(333, 179);
            this.money_result.Name = "money_result";
            this.money_result.ReadOnly = true;
            this.money_result.Size = new System.Drawing.Size(185, 28);
            this.money_result.TabIndex = 28;
            this.money_result.Text = "";
            // 
            // money
            // 
            this.money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.Location = new System.Drawing.Point(459, 75);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(185, 28);
            this.money.TabIndex = 27;
            this.money.Text = "";
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_result_KeyPress);
            // 
            // updateHistory
            // 
            this.updateHistory.AutoSize = true;
            this.updateHistory.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateHistory.ForeColor = System.Drawing.Color.White;
            this.updateHistory.Location = new System.Drawing.Point(24, 31);
            this.updateHistory.Name = "updateHistory";
            this.updateHistory.Size = new System.Drawing.Size(133, 23);
            this.updateHistory.TabIndex = 26;
            this.updateHistory.Text = "Update Histroy";
            // 
            // check_Auto
            // 
            this.check_Auto.AutoSize = true;
            this.check_Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Auto.ForeColor = System.Drawing.Color.White;
            this.check_Auto.Location = new System.Drawing.Point(560, 179);
            this.check_Auto.Name = "check_Auto";
            this.check_Auto.Size = new System.Drawing.Size(72, 28);
            this.check_Auto.TabIndex = 24;
            this.check_Auto.Text = "Auto";
            this.check_Auto.UseVisualStyleBackColor = true;
            this.check_Auto.CheckedChanged += new System.EventHandler(this.check_Auto_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(506, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(668, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Convert To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Base";
            // 
            // convert_money
            // 
            this.convert_money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.convert_money.FlatAppearance.BorderSize = 0;
            this.convert_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_money.ForeColor = System.Drawing.Color.White;
            this.convert_money.Location = new System.Drawing.Point(653, 177);
            this.convert_money.Name = "convert_money";
            this.convert_money.Size = new System.Drawing.Size(125, 43);
            this.convert_money.TabIndex = 15;
            this.convert_money.Text = "Convert";
            this.convert_money.UseVisualStyleBackColor = false;
            this.convert_money.Click += new System.EventHandler(this.convert_money_Click);
            // 
            // change_money2
            // 
            this.change_money2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_money2.FormattingEnabled = true;
            this.change_money2.Items.AddRange(new object[] {
            "AMD",
            "RUB",
            "USD",
            "EUR"});
            this.change_money2.Location = new System.Drawing.Point(672, 75);
            this.change_money2.Name = "change_money2";
            this.change_money2.Size = new System.Drawing.Size(97, 28);
            this.change_money2.TabIndex = 14;
            this.change_money2.Text = "Money";
            // 
            // change_money
            // 
            this.change_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_money.FormattingEnabled = true;
            this.change_money.Items.AddRange(new object[] {
            "EUR"});
            this.change_money.Location = new System.Drawing.Point(333, 75);
            this.change_money.Name = "change_money";
            this.change_money.Size = new System.Drawing.Size(97, 28);
            this.change_money.TabIndex = 13;
            this.change_money.Text = "Money";
            // 
            // autoChecker
            // 
            this.autoChecker.Tick += new System.EventHandler(this.refreshAuto_Tick);
            // 
            // updateBoard
            // 
            this.updateBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateBoard.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBoard.ForeColor = System.Drawing.Color.White;
            this.updateBoard.Location = new System.Drawing.Point(28, 75);
            this.updateBoard.Name = "updateBoard";
            this.updateBoard.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.updateBoard.Size = new System.Drawing.Size(256, 198);
            this.updateBoard.TabIndex = 0;
            this.updateBoard.Text = "";
            // 
            // General
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(854, 375);
            this.Controls.Add(this.exchangePanel);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.generalPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rates For You";
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.menubar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.exchangePanel.ResumeLayout(false);
            this.exchangePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Panel menubar;
        private System.Windows.Forms.Button exchangeButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button more;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel exchangePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convert_money;
        private System.Windows.Forms.ComboBox change_money2;
        private System.Windows.Forms.ComboBox change_money;
        private System.Windows.Forms.CheckBox check_Auto;
        private System.Windows.Forms.Timer autoChecker;
        private System.Windows.Forms.Label general_label;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.Label updateHistory;
        private System.Windows.Forms.RichTextBox money_result;
        private System.Windows.Forms.RichTextBox money;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.RichTextBox updateBoard;
    }
}

