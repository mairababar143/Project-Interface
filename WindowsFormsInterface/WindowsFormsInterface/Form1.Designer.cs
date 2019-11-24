namespace WindowsFormsInterface
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
            this.StartPanel = new System.Windows.Forms.Panel();
            this.labelBluetooth = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SigninUsername = new System.Windows.Forms.TextBox();
            this.SigninPassword = new System.Windows.Forms.TextBox();
            this.Signin = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            this.SigninPanel = new System.Windows.Forms.Panel();
            this.AvailableConnection = new System.Windows.Forms.Button();
            this.IncommingRquest = new System.Windows.Forms.Button();
            this.SignupPanel = new System.Windows.Forms.Panel();
            this.labelSignup = new System.Windows.Forms.Label();
            this.SUfirst = new System.Windows.Forms.Label();
            this.SUlast = new System.Windows.Forms.Label();
            this.SUuser = new System.Windows.Forms.Label();
            this.SUpass = new System.Windows.Forms.Label();
            this.SUfirstname = new System.Windows.Forms.TextBox();
            this.SUsecondname = new System.Windows.Forms.TextBox();
            this.SUusername = new System.Windows.Forms.TextBox();
            this.SUpassword = new System.Windows.Forms.TextBox();
            this.CreateAcount = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.AvailablePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelavailableconnection = new System.Windows.Forms.Label();
            this.ACfirstname = new System.Windows.Forms.Label();
            this.AClastname = new System.Windows.Forms.Label();
            this.ACusername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Request = new System.Windows.Forms.Button();
            this.RequestPanel = new System.Windows.Forms.Panel();
            this.IncommingRequest = new System.Windows.Forms.Label();
            this.IRfirst = new System.Windows.Forms.Label();
            this.IRlast = new System.Windows.Forms.Label();
            this.IRuser = new System.Windows.Forms.Label();
            this.IRfirstname = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.IRlastname = new System.Windows.Forms.TextBox();
            this.IRusername = new System.Windows.Forms.TextBox();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.Texting = new System.Windows.Forms.RichTextBox();
            this.messageType = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartPanel.SuspendLayout();
            this.SigninPanel.SuspendLayout();
            this.SignupPanel.SuspendLayout();
            this.AvailablePanel.SuspendLayout();
            this.RequestPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.Window;
            this.StartPanel.Controls.Add(this.SignupPanel);
            this.StartPanel.Controls.Add(this.SigninPanel);
            this.StartPanel.Controls.Add(this.Signup);
            this.StartPanel.Controls.Add(this.Signin);
            this.StartPanel.Controls.Add(this.SigninPassword);
            this.StartPanel.Controls.Add(this.SigninUsername);
            this.StartPanel.Controls.Add(this.labelPassword);
            this.StartPanel.Controls.Add(this.labelUsername);
            this.StartPanel.Controls.Add(this.labelBluetooth);
            this.StartPanel.Location = new System.Drawing.Point(-1, 0);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(798, 452);
            this.StartPanel.TabIndex = 0;
            // 
            // labelBluetooth
            // 
            this.labelBluetooth.AutoSize = true;
            this.labelBluetooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBluetooth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBluetooth.Location = new System.Drawing.Point(223, 58);
            this.labelBluetooth.Name = "labelBluetooth";
            this.labelBluetooth.Size = new System.Drawing.Size(376, 40);
            this.labelBluetooth.TabIndex = 0;
            this.labelBluetooth.Text = "Bluetooth Messenger";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelUsername.Location = new System.Drawing.Point(190, 139);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(124, 29);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPassword.Location = new System.Drawing.Point(190, 206);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(120, 29);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // SigninUsername
            // 
            this.SigninUsername.Location = new System.Drawing.Point(340, 143);
            this.SigninUsername.Name = "SigninUsername";
            this.SigninUsername.Size = new System.Drawing.Size(304, 26);
            this.SigninUsername.TabIndex = 3;
            // 
            // SigninPassword
            // 
            this.SigninPassword.Location = new System.Drawing.Point(339, 206);
            this.SigninPassword.Name = "SigninPassword";
            this.SigninPassword.PasswordChar = '*';
            this.SigninPassword.Size = new System.Drawing.Size(305, 26);
            this.SigninPassword.TabIndex = 4;
            // 
            // Signin
            // 
            this.Signin.Location = new System.Drawing.Point(392, 270);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(118, 44);
            this.Signin.TabIndex = 5;
            this.Signin.Text = "Sign In";
            this.Signin.UseVisualStyleBackColor = true;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(158, 315);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(118, 44);
            this.Signup.TabIndex = 6;
            this.Signup.Text = "Sign Up";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // SigninPanel
            // 
            this.SigninPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SigninPanel.Controls.Add(this.MessagePanel);
            this.SigninPanel.Controls.Add(this.RequestPanel);
            this.SigninPanel.Controls.Add(this.AvailablePanel);
            this.SigninPanel.Controls.Add(this.pictureBox1);
            this.SigninPanel.Controls.Add(this.IncommingRquest);
            this.SigninPanel.Controls.Add(this.AvailableConnection);
            this.SigninPanel.Location = new System.Drawing.Point(3, 0);
            this.SigninPanel.Name = "SigninPanel";
            this.SigninPanel.Size = new System.Drawing.Size(798, 452);
            this.SigninPanel.TabIndex = 7;
            // 
            // AvailableConnection
            // 
            this.AvailableConnection.Location = new System.Drawing.Point(90, 101);
            this.AvailableConnection.Name = "AvailableConnection";
            this.AvailableConnection.Size = new System.Drawing.Size(198, 66);
            this.AvailableConnection.TabIndex = 0;
            this.AvailableConnection.Text = "Available Connection";
            this.AvailableConnection.UseVisualStyleBackColor = true;
            this.AvailableConnection.Click += new System.EventHandler(this.AvailableConnection_Click);
            // 
            // IncommingRquest
            // 
            this.IncommingRquest.Location = new System.Drawing.Point(90, 206);
            this.IncommingRquest.Name = "IncommingRquest";
            this.IncommingRquest.Size = new System.Drawing.Size(198, 66);
            this.IncommingRquest.TabIndex = 1;
            this.IncommingRquest.Text = "Incomming Requests";
            this.IncommingRquest.UseVisualStyleBackColor = true;
            this.IncommingRquest.Click += new System.EventHandler(this.IncommingRquest_Click);
            // 
            // SignupPanel
            // 
            this.SignupPanel.Controls.Add(this.Back);
            this.SignupPanel.Controls.Add(this.CreateAcount);
            this.SignupPanel.Controls.Add(this.SUpassword);
            this.SignupPanel.Controls.Add(this.SUusername);
            this.SignupPanel.Controls.Add(this.SUsecondname);
            this.SignupPanel.Controls.Add(this.SUfirstname);
            this.SignupPanel.Controls.Add(this.SUpass);
            this.SignupPanel.Controls.Add(this.SUuser);
            this.SignupPanel.Controls.Add(this.SUlast);
            this.SignupPanel.Controls.Add(this.SUfirst);
            this.SignupPanel.Controls.Add(this.labelSignup);
            this.SignupPanel.Location = new System.Drawing.Point(0, 0);
            this.SignupPanel.Name = "SignupPanel";
            this.SignupPanel.Size = new System.Drawing.Size(791, 452);
            this.SignupPanel.TabIndex = 8;
            // 
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSignup.Location = new System.Drawing.Point(304, 30);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSignup.Size = new System.Drawing.Size(152, 40);
            this.labelSignup.TabIndex = 0;
            this.labelSignup.Text = "Sign Up";
            // 
            // SUfirst
            // 
            this.SUfirst.AutoSize = true;
            this.SUfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUfirst.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SUfirst.Location = new System.Drawing.Point(206, 116);
            this.SUfirst.Name = "SUfirst";
            this.SUfirst.Size = new System.Drawing.Size(131, 29);
            this.SUfirst.TabIndex = 1;
            this.SUfirst.Text = "First Name";
            // 
            // SUlast
            // 
            this.SUlast.AutoSize = true;
            this.SUlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUlast.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SUlast.Location = new System.Drawing.Point(206, 168);
            this.SUlast.Name = "SUlast";
            this.SUlast.Size = new System.Drawing.Size(128, 29);
            this.SUlast.TabIndex = 2;
            this.SUlast.Text = "Last Name";
            // 
            // SUuser
            // 
            this.SUuser.AutoSize = true;
            this.SUuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUuser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SUuser.Location = new System.Drawing.Point(206, 222);
            this.SUuser.Name = "SUuser";
            this.SUuser.Size = new System.Drawing.Size(124, 29);
            this.SUuser.TabIndex = 3;
            this.SUuser.Text = "Username";
            // 
            // SUpass
            // 
            this.SUpass.AutoSize = true;
            this.SUpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUpass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SUpass.Location = new System.Drawing.Point(206, 270);
            this.SUpass.Name = "SUpass";
            this.SUpass.Size = new System.Drawing.Size(120, 29);
            this.SUpass.TabIndex = 4;
            this.SUpass.Text = "Password";
            // 
            // SUfirstname
            // 
            this.SUfirstname.Location = new System.Drawing.Point(373, 121);
            this.SUfirstname.Name = "SUfirstname";
            this.SUfirstname.Size = new System.Drawing.Size(238, 26);
            this.SUfirstname.TabIndex = 5;
            // 
            // SUsecondname
            // 
            this.SUsecondname.Location = new System.Drawing.Point(373, 171);
            this.SUsecondname.Name = "SUsecondname";
            this.SUsecondname.Size = new System.Drawing.Size(238, 26);
            this.SUsecondname.TabIndex = 6;
            // 
            // SUusername
            // 
            this.SUusername.Location = new System.Drawing.Point(373, 222);
            this.SUusername.Name = "SUusername";
            this.SUusername.Size = new System.Drawing.Size(238, 26);
            this.SUusername.TabIndex = 7;
            // 
            // SUpassword
            // 
            this.SUpassword.Location = new System.Drawing.Point(373, 270);
            this.SUpassword.Name = "SUpassword";
            this.SUpassword.Size = new System.Drawing.Size(238, 26);
            this.SUpassword.TabIndex = 8;
            // 
            // CreateAcount
            // 
            this.CreateAcount.Location = new System.Drawing.Point(336, 329);
            this.CreateAcount.Name = "CreateAcount";
            this.CreateAcount.Size = new System.Drawing.Size(154, 43);
            this.CreateAcount.TabIndex = 9;
            this.CreateAcount.Text = "Create Account";
            this.CreateAcount.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(90, 365);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 40);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AvailablePanel
            // 
            this.AvailablePanel.Controls.Add(this.Request);
            this.AvailablePanel.Controls.Add(this.textBox3);
            this.AvailablePanel.Controls.Add(this.textBox2);
            this.AvailablePanel.Controls.Add(this.textBox1);
            this.AvailablePanel.Controls.Add(this.ACusername);
            this.AvailablePanel.Controls.Add(this.AClastname);
            this.AvailablePanel.Controls.Add(this.ACfirstname);
            this.AvailablePanel.Controls.Add(this.labelavailableconnection);
            this.AvailablePanel.Controls.Add(this.label1);
            this.AvailablePanel.Location = new System.Drawing.Point(0, 0);
            this.AvailablePanel.Name = "AvailablePanel";
            this.AvailablePanel.Size = new System.Drawing.Size(798, 452);
            this.AvailablePanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // labelavailableconnection
            // 
            this.labelavailableconnection.AutoSize = true;
            this.labelavailableconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelavailableconnection.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelavailableconnection.Location = new System.Drawing.Point(219, 43);
            this.labelavailableconnection.Name = "labelavailableconnection";
            this.labelavailableconnection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelavailableconnection.Size = new System.Drawing.Size(375, 40);
            this.labelavailableconnection.TabIndex = 1;
            this.labelavailableconnection.Text = "Available Connection";
            // 
            // ACfirstname
            // 
            this.ACfirstname.AutoSize = true;
            this.ACfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACfirstname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ACfirstname.Location = new System.Drawing.Point(219, 149);
            this.ACfirstname.Name = "ACfirstname";
            this.ACfirstname.Size = new System.Drawing.Size(131, 29);
            this.ACfirstname.TabIndex = 2;
            this.ACfirstname.Text = "First Name";
            // 
            // AClastname
            // 
            this.AClastname.AutoSize = true;
            this.AClastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AClastname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AClastname.Location = new System.Drawing.Point(222, 203);
            this.AClastname.Name = "AClastname";
            this.AClastname.Size = new System.Drawing.Size(128, 29);
            this.AClastname.TabIndex = 3;
            this.AClastname.Text = "Last Name";
            // 
            // ACusername
            // 
            this.ACusername.AutoSize = true;
            this.ACusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACusername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ACusername.Location = new System.Drawing.Point(222, 259);
            this.ACusername.Name = "ACusername";
            this.ACusername.Size = new System.Drawing.Size(124, 29);
            this.ACusername.TabIndex = 4;
            this.ACusername.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 26);
            this.textBox3.TabIndex = 8;
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(297, 337);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(124, 43);
            this.Request.TabIndex = 9;
            this.Request.Text = "Request";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // RequestPanel
            // 
            this.RequestPanel.Controls.Add(this.IRusername);
            this.RequestPanel.Controls.Add(this.IRlastname);
            this.RequestPanel.Controls.Add(this.Accept);
            this.RequestPanel.Controls.Add(this.IRfirstname);
            this.RequestPanel.Controls.Add(this.IRuser);
            this.RequestPanel.Controls.Add(this.IRlast);
            this.RequestPanel.Controls.Add(this.IRfirst);
            this.RequestPanel.Controls.Add(this.IncommingRequest);
            this.RequestPanel.Location = new System.Drawing.Point(-3, 0);
            this.RequestPanel.Name = "RequestPanel";
            this.RequestPanel.Size = new System.Drawing.Size(801, 452);
            this.RequestPanel.TabIndex = 4;
            // 
            // IncommingRequest
            // 
            this.IncommingRequest.AutoSize = true;
            this.IncommingRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncommingRequest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IncommingRequest.Location = new System.Drawing.Point(195, 30);
            this.IncommingRequest.Name = "IncommingRequest";
            this.IncommingRequest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IncommingRequest.Size = new System.Drawing.Size(353, 40);
            this.IncommingRequest.TabIndex = 2;
            this.IncommingRequest.Text = "Incomming Request";
            // 
            // IRfirst
            // 
            this.IRfirst.AutoSize = true;
            this.IRfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRfirst.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IRfirst.Location = new System.Drawing.Point(183, 127);
            this.IRfirst.Name = "IRfirst";
            this.IRfirst.Size = new System.Drawing.Size(131, 29);
            this.IRfirst.TabIndex = 3;
            this.IRfirst.Text = "First Name";
            // 
            // IRlast
            // 
            this.IRlast.AutoSize = true;
            this.IRlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRlast.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IRlast.Location = new System.Drawing.Point(182, 178);
            this.IRlast.Name = "IRlast";
            this.IRlast.Size = new System.Drawing.Size(128, 29);
            this.IRlast.TabIndex = 4;
            this.IRlast.Text = "Last Name";
            // 
            // IRuser
            // 
            this.IRuser.AutoSize = true;
            this.IRuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRuser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IRuser.Location = new System.Drawing.Point(183, 229);
            this.IRuser.Name = "IRuser";
            this.IRuser.Size = new System.Drawing.Size(124, 29);
            this.IRuser.TabIndex = 5;
            this.IRuser.Text = "Username";
            // 
            // IRfirstname
            // 
            this.IRfirstname.Location = new System.Drawing.Point(356, 127);
            this.IRfirstname.Name = "IRfirstname";
            this.IRfirstname.Size = new System.Drawing.Size(238, 26);
            this.IRfirstname.TabIndex = 8;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(262, 306);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(124, 43);
            this.Accept.TabIndex = 10;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // IRlastname
            // 
            this.IRlastname.Location = new System.Drawing.Point(356, 181);
            this.IRlastname.Name = "IRlastname";
            this.IRlastname.Size = new System.Drawing.Size(238, 26);
            this.IRlastname.TabIndex = 11;
            // 
            // IRusername
            // 
            this.IRusername.Location = new System.Drawing.Point(356, 233);
            this.IRusername.Name = "IRusername";
            this.IRusername.Size = new System.Drawing.Size(238, 26);
            this.IRusername.TabIndex = 12;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Controls.Add(this.logout);
            this.MessagePanel.Controls.Add(this.Send);
            this.MessagePanel.Controls.Add(this.messageType);
            this.MessagePanel.Controls.Add(this.Texting);
            this.MessagePanel.Location = new System.Drawing.Point(0, 0);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(792, 452);
            this.MessagePanel.TabIndex = 5;
            // 
            // Texting
            // 
            this.Texting.Location = new System.Drawing.Point(27, 12);
            this.Texting.Name = "Texting";
            this.Texting.Size = new System.Drawing.Size(738, 260);
            this.Texting.TabIndex = 0;
            this.Texting.Text = "";
            // 
            // messageType
            // 
            this.messageType.Location = new System.Drawing.Point(27, 313);
            this.messageType.Name = "messageType";
            this.messageType.Size = new System.Drawing.Size(649, 26);
            this.messageType.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(682, 308);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(95, 36);
            this.Send.TabIndex = 11;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(287, 374);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(111, 43);
            this.logout.TabIndex = 12;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsInterface.Properties.Resources._7__2_;
            this.pictureBox1.Location = new System.Drawing.Point(373, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 291);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth Messenger";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.SigninPanel.ResumeLayout(false);
            this.SignupPanel.ResumeLayout(false);
            this.SignupPanel.PerformLayout();
            this.AvailablePanel.ResumeLayout(false);
            this.AvailablePanel.PerformLayout();
            this.RequestPanel.ResumeLayout(false);
            this.RequestPanel.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.TextBox SigninPassword;
        private System.Windows.Forms.TextBox SigninUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelBluetooth;
        private System.Windows.Forms.Panel SigninPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button IncommingRquest;
        private System.Windows.Forms.Button AvailableConnection;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Signin;
        private System.Windows.Forms.Panel SignupPanel;
        private System.Windows.Forms.Label SUlast;
        private System.Windows.Forms.Label SUfirst;
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button CreateAcount;
        private System.Windows.Forms.TextBox SUpassword;
        private System.Windows.Forms.TextBox SUusername;
        private System.Windows.Forms.TextBox SUsecondname;
        private System.Windows.Forms.TextBox SUfirstname;
        private System.Windows.Forms.Label SUpass;
        private System.Windows.Forms.Label SUuser;
        private System.Windows.Forms.Panel AvailablePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ACusername;
        private System.Windows.Forms.Label AClastname;
        private System.Windows.Forms.Label ACfirstname;
        private System.Windows.Forms.Label labelavailableconnection;
        private System.Windows.Forms.Panel RequestPanel;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.TextBox IRfirstname;
        private System.Windows.Forms.Label IRuser;
        private System.Windows.Forms.Label IRlast;
        private System.Windows.Forms.Label IRfirst;
        private System.Windows.Forms.Label IncommingRequest;
        private System.Windows.Forms.TextBox IRusername;
        private System.Windows.Forms.TextBox IRlastname;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox messageType;
        private System.Windows.Forms.RichTextBox Texting;
        private System.Windows.Forms.Button logout;
    }
}

