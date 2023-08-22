namespace P00196751_Aminur_Rahman_ExpenseTracker
{
    partial class frmMainMenu
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnExpenseCategory = new System.Windows.Forms.Button();
            this.btnExpenseItem = new System.Windows.Forms.Button();
            this.btnExpenseRecord = new System.Windows.Forms.Button();
            this.btnManagerUser = new System.Windows.Forms.Button();
            this.btnBarChat = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusWelcome,
            this.statusClock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // statusWelcome
            // 
            this.statusWelcome.Name = "statusWelcome";
            this.statusWelcome.Size = new System.Drawing.Size(746, 17);
            this.statusWelcome.Spring = true;
            // 
            // statusClock
            // 
            this.statusClock.Name = "statusClock";
            this.statusClock.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 57);
            this.pnlTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(148, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(478, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Aminur\'s Expense Tracker System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnBarChat);
            this.pnlMenu.Controls.Add(this.btnManagerUser);
            this.pnlMenu.Controls.Add(this.btnExpenseRecord);
            this.pnlMenu.Controls.Add(this.btnExpenseItem);
            this.pnlMenu.Controls.Add(this.btnExpenseCategory);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 57);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(158, 371);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Gray;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(158, 60);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(158, 34);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.Location = new System.Drawing.Point(0, 94);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(158, 34);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnExpenseCategory
            // 
            this.btnExpenseCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenseCategory.Location = new System.Drawing.Point(0, 128);
            this.btnExpenseCategory.Name = "btnExpenseCategory";
            this.btnExpenseCategory.Size = new System.Drawing.Size(158, 34);
            this.btnExpenseCategory.TabIndex = 3;
            this.btnExpenseCategory.Text = "Expense Category";
            this.btnExpenseCategory.UseVisualStyleBackColor = true;
            // 
            // btnExpenseItem
            // 
            this.btnExpenseItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenseItem.Location = new System.Drawing.Point(0, 162);
            this.btnExpenseItem.Name = "btnExpenseItem";
            this.btnExpenseItem.Size = new System.Drawing.Size(158, 34);
            this.btnExpenseItem.TabIndex = 4;
            this.btnExpenseItem.Text = "Expense Item";
            this.btnExpenseItem.UseVisualStyleBackColor = true;
            // 
            // btnExpenseRecord
            // 
            this.btnExpenseRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenseRecord.Location = new System.Drawing.Point(0, 196);
            this.btnExpenseRecord.Name = "btnExpenseRecord";
            this.btnExpenseRecord.Size = new System.Drawing.Size(158, 34);
            this.btnExpenseRecord.TabIndex = 5;
            this.btnExpenseRecord.Text = "Expense Record";
            this.btnExpenseRecord.UseVisualStyleBackColor = true;
            // 
            // btnManagerUser
            // 
            this.btnManagerUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagerUser.Location = new System.Drawing.Point(0, 230);
            this.btnManagerUser.Name = "btnManagerUser";
            this.btnManagerUser.Size = new System.Drawing.Size(158, 34);
            this.btnManagerUser.TabIndex = 6;
            this.btnManagerUser.Text = "Manager User";
            this.btnManagerUser.UseVisualStyleBackColor = true;
            // 
            // btnBarChat
            // 
            this.btnBarChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarChat.Location = new System.Drawing.Point(0, 264);
            this.btnBarChat.Name = "btnBarChat";
            this.btnBarChat.Size = new System.Drawing.Size(158, 34);
            this.btnBarChat.TabIndex = 7;
            this.btnBarChat.Text = "Bar Chat";
            this.btnBarChat.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.Location = new System.Drawing.Point(0, 298);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(158, 34);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(158, 57);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(642, 371);
            this.pnlContainer.TabIndex = 4;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusWelcome;
        private System.Windows.Forms.ToolStripStatusLabel statusClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBarChat;
        private System.Windows.Forms.Button btnManagerUser;
        private System.Windows.Forms.Button btnExpenseRecord;
        private System.Windows.Forms.Button btnExpenseItem;
        private System.Windows.Forms.Button btnExpenseCategory;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlContainer;
    }
}