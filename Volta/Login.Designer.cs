namespace Volta
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            Server = new Label();
            textBoxServer = new TextBox();
            textBoxUser = new TextBox();
            Username = new Label();
            btnCancel = new Button();
            btnConnect = new Button();
            textBoxPass = new TextBox();
            Password = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // Server
            // 
            Server.AutoSize = true;
            Server.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Server.Location = new Point(69, 42);
            Server.Name = "Server";
            Server.Size = new Size(70, 20);
            Server.TabIndex = 0;
            Server.Text = "Server";
            // 
            // textBoxServer
            // 
            textBoxServer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxServer.BackColor = SystemColors.ControlLightLight;
            textBoxServer.Location = new Point(69, 64);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(674, 27);
            textBoxServer.TabIndex = 1;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUser.BackColor = SystemColors.ControlLightLight;
            textBoxUser.Location = new Point(69, 160);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(674, 27);
            textBoxUser.TabIndex = 2;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(69, 137);
            Username.Name = "Username";
            Username.Size = new Size(104, 20);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(594, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConnect.BackColor = Color.Silver;
            btnConnect.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnect.Location = new Point(423, 358);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(149, 36);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPass.BackColor = SystemColors.ControlLightLight;
            textBoxPass.Location = new Point(69, 265);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(674, 27);
            textBoxPass.TabIndex = 7;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = SystemColors.ControlDark;
            Password.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(69, 242);
            Password.Name = "Password";
            Password.Size = new Size(101, 20);
            Password.TabIndex = 8;
            Password.Text = "Password";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(textBoxPass);
            Controls.Add(btnConnect);
            Controls.Add(btnCancel);
            Controls.Add(Username);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxServer);
            Controls.Add(Server);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Server;
        private TextBox textBoxServer;
        private TextBox textBoxUser;
        private Label Username;
        private Button btnCancel;
        private Button btnConnect;
        private TextBox textBoxPass;
        private Label Password;
        private ContextMenuStrip contextMenuStrip1;
    }
}