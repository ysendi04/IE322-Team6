namespace LoginForm1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            chkShow = new CheckBox();
            btnCancle = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(446, 202);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(446, 273);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(568, 412);
            button1.Name = "button1";
            button1.Size = new Size(110, 63);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShow.ForeColor = SystemColors.ActiveCaptionText;
            chkShow.Location = new Point(607, 333);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(168, 32);
            chkShow.TabIndex = 4;
            chkShow.Text = "Show Password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Red;
            btnCancle.ForeColor = SystemColors.ButtonFace;
            btnCancle.Location = new Point(731, 412);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(100, 63);
            btnCancle.TabIndex = 5;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(607, 195);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(162, 27);
            txtUser.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(607, 274);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(162, 27);
            txtPass.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(931, 616);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnCancle);
            Controls.Add(chkShow);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox chkShow;
        private Button btnCancle;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}
