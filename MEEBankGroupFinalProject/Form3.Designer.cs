using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MEEBankGroupFinalProject
{
    public partial class Form3 : Form
    {
        private Label lblBrand;
        private Panel cardPanel;
        private Label lblWelcome;
        private Button btnSignInTab;
        private Button btnSignUpTab;
        private Button btnPrimary;
        private RoundedTextBox txtUsername;
        private RoundedTextBox txtPassword;
        private RoundedTextBox txtName;
        private RoundedTextBox txtEmail;

        private void InitializeComponent()
        {
            SuspendLayout();

            BackColor = Color.FromArgb(167, 218, 187);
            ClientSize = new Size(380, 700);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEEBank";
            DoubleBuffered = true;

            lblBrand = new Label
            {
                Text = "MEEBank",
                Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((ClientSize.Width - 180) / 2, 60)
            };
            Controls.Add(lblBrand);

            cardPanel = new Panel
            {
                BackColor = Color.FromArgb(6, 31, 27),
                Size = new Size(300, 420),
                Location = new Point((ClientSize.Width - 300) / 2, 140)
            };
            cardPanel.Paint += (_, e) =>
            {
                using var path = Form3.RoundedRect(cardPanel.ClientRectangle, 24);
                cardPanel.Region = new Region(path);
            };
            Controls.Add(cardPanel);

            btnSignInTab = CreateTopTab("Sign in", true, new Point(30, 20));
            btnSignUpTab = CreateTopTab("Sign up", false, new Point(200, 20));
            cardPanel.Controls.Add(btnSignInTab);
            cardPanel.Controls.Add(btnSignUpTab);

            lblWelcome = new Label
            {
                Text = "Welcome",
                ForeColor = Color.White,
                Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point),
                AutoSize = true,
                Location = new Point((cardPanel.Width - 130) / 2, 80)
            };
            cardPanel.Controls.Add(lblWelcome);

            txtUsername = new RoundedTextBox("Username");
            txtPassword = new RoundedTextBox("Password", true);
            txtName = new RoundedTextBox("Full name");
            txtEmail = new RoundedTextBox("Email");

            PositionInputsForSignIn();

            btnPrimary = new Button
            {
                Text = "Log In",
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point),
                Size = new Size(120, 40),
                Location = new Point((cardPanel.Width - 120) / 2, 320)
            };
            btnPrimary.FlatAppearance.BorderSize = 0;
            cardPanel.Controls.Add(btnPrimary);

            ResumeLayout(false);
        }

        private Button CreateTopTab(string text, bool active, Point location)
        {
            var btn = new Button
            {
                Text = text,
                ForeColor = active ? Color.White : Color.FromArgb(120, 153, 141),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point),
                Location = location,
                Size = new Size(80, 30),
                TabStop = false
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (_, __) =>
            {
                bool isSignIn = text.Equals("Sign in", System.StringComparison.OrdinalIgnoreCase);
                btnSignInTab.ForeColor = isSignIn ? Color.White : Color.FromArgb(120, 153, 141);
                btnSignUpTab.ForeColor = isSignIn ? Color.FromArgb(120, 153, 141) : Color.White;
                if (isSignIn)
                {
                    PositionInputsForSignIn();
                    btnPrimary.Text = "Log In";
                }
                else
                {
                    PositionInputsForSignUp();
                    btnPrimary.Text = "Sign Up";
                }
            };
            return btn;
        }

        private void PositionInputsForSignIn()
        {
            cardPanel.Controls.Clear();
            cardPanel.Controls.AddRange(new Control[]
            {
                btnSignInTab, btnSignUpTab, lblWelcome, btnPrimary
            });

            txtUsername.Location = new Point(30, 150);
            txtPassword.Location = new Point(30, 220);

            cardPanel.Controls.Add(txtUsername.Container);
            cardPanel.Controls.Add(txtPassword.Container);
        }

        private void PositionInputsForSignUp()
        {
            cardPanel.Controls.Clear();
            cardPanel.Controls.AddRange(new Control[]
            {
                btnSignInTab, btnSignUpTab, lblWelcome, btnPrimary
            });

            txtName.Location = new Point(30, 130);
            txtEmail.Location = new Point(30, 200);
            txtPassword.Location = new Point(30, 270);

            cardPanel.Controls.Add(txtName.Container);
            cardPanel.Controls.Add(txtEmail.Container);
            cardPanel.Controls.Add(txtPassword.Container);
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    internal class RoundedTextBox
    {
        public Panel Container { get; }
        public TextBox TextBox { get; }

        public Point Location
        {
            get => Container.Location;
            set => Container.Location = value;
        }

        public RoundedTextBox(string placeholder, bool isPassword = false)
        {
            Container = new Panel
            {
                Size = new Size(240, 55),
                BackColor = Color.FromArgb(10, 52, 45)
            };
            Container.Paint += (_, e) =>
            {
                using var path = Form3.RoundedRect(Container.ClientRectangle, 24);
                Container.Region = new Region(path);
            };

            TextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Container.BackColor,
                ForeColor = Color.FromArgb(120, 153, 141),
                Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(12, 18),
                Size = new Size(210, 20),
                Text = placeholder
            };

            TextBox.GotFocus += (_, __) =>
            {
                if (TextBox.Text == placeholder)
                {
                    TextBox.Text = "";
                    TextBox.ForeColor = Color.White;
                    TextBox.UseSystemPasswordChar = isPassword;
                }
            };

            TextBox.LostFocus += (_, __) =>
            {
                if (string.IsNullOrWhiteSpace(TextBox.Text))
                {
                    TextBox.Text = placeholder;
                    TextBox.ForeColor = Color.FromArgb(120, 153, 141);
                    TextBox.UseSystemPasswordChar = false;
                }
            };

            Container.Controls.Add(TextBox);
        }
    }
}