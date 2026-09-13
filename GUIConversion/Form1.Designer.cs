namespace GUIConversion
{
    partial class FormMovieDiscount
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
            lblWelcome = new Label();
            lblAge = new Label();
            lblRating = new Label();
            txtAge = new TextBox();
            txtRating = new TextBox();
            btnCalc = new Button();
            lblResults = new Label();
            lblOutput = new Label();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AccessibleRole = AccessibleRole.MenuBar;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F);
            lblWelcome.Location = new Point(97, 31);
            lblWelcome.MaximumSize = new Size(500, 100);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(450, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome! Enter the patron's age and the movie rating to calculate.";
            // 
            // lblAge
            // 
            lblAge.Anchor = AnchorStyles.Left;
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 11F);
            lblAge.Location = new Point(85, 124);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(85, 20);
            lblAge.TabIndex = 1;
            lblAge.Text = "Patron Age:";
            // 
            // lblRating
            // 
            lblRating.Anchor = AnchorStyles.Left;
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 11F);
            lblRating.Location = new Point(74, 162);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(100, 20);
            lblRating.TabIndex = 2;
            lblRating.Text = "Movie Rating:";
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Left;
            txtAge.Location = new Point(177, 121);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 3;
            // 
            // txtRating
            // 
            txtRating.Anchor = AnchorStyles.Left;
            txtRating.Location = new Point(177, 159);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(100, 23);
            txtRating.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Anchor = AnchorStyles.Left;
            btnCalc.Font = new Font("Segoe UI", 11F);
            btnCalc.Location = new Point(177, 207);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(100, 31);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += BtnCalc_Click;
            // 
            // lblResults
            // 
            lblResults.Anchor = AnchorStyles.Right;
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 11F);
            lblResults.Location = new Point(444, 124);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(58, 20);
            lblResults.TabIndex = 6;
            lblResults.Text = "Results:";
            // 
            // lblOutput
            // 
            lblOutput.Anchor = AnchorStyles.Right;
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 11F);
            lblOutput.Location = new Point(524, 120);
            lblOutput.MaximumSize = new Size(250, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Padding = new Padding(0, 0, 50, 0);
            lblOutput.Size = new Size(50, 20);
            lblOutput.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 11F);
            btnClear.Location = new Point(457, 249);
            btnClear.Margin = new Padding(3, 3, 100, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 36);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuit.Font = new Font("Segoe UI", 11F);
            btnQuit.Location = new Point(590, 249);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(120, 36);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // FormMovieDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 297);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(lblOutput);
            Controls.Add(lblResults);
            Controls.Add(btnCalc);
            Controls.Add(txtRating);
            Controls.Add(txtAge);
            Controls.Add(lblRating);
            Controls.Add(lblAge);
            Controls.Add(lblWelcome);
            Name = "FormMovieDiscount";
            Text = "Movie Discount Calculator";
            Load += FormMovieDiscount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblAge;
        private Label lblRating;
        private TextBox txtAge;
        private TextBox txtRating;
        private Button btnCalc;
        private Label lblResults;
        private Label lblOutput;
        private Button btnClear;
        private Button btnQuit;
    }
}
