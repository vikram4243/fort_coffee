namespace fort_coffee
{
    partial class Form3
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
            button1 = new Button();
            name = new TextBox();
            mobile = new TextBox();
            user_id = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(895, 420);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.Location = new Point(793, 199);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(283, 27);
            name.TabIndex = 1;
            // 
            // mobile
            // 
            mobile.Location = new Point(793, 255);
            mobile.Name = "mobile";
            mobile.PlaceholderText = "Mobile_number";
            mobile.Size = new Size(283, 27);
            mobile.TabIndex = 2;
            // 
            // user_id
            // 
            user_id.Location = new Point(793, 306);
            user_id.Name = "user_id";
            user_id.PlaceholderText = "Username";
            user_id.Size = new Size(283, 27);
            user_id.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(793, 360);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(283, 27);
            password.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(803, 137);
            label1.Name = "label1";
            label1.Size = new Size(261, 35);
            label1.TabIndex = 5;
            label1.Text = "New User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(895, 473);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_main;
            ClientSize = new Size(1203, 664);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(user_id);
            Controls.Add(mobile);
            Controls.Add(name);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox name;
        private TextBox mobile;
        private TextBox user_id;
        private TextBox password;
        private Label label1;
        private Label label2;
    }
}