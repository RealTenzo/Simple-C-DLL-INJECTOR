namespace Dll_Inj
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
            this.gunaComboBoxProcesses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDllPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelectDll = new Guna.UI2.WinForms.Guna2Button();
            this.btnInject = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaComboBoxProcesses
            // 
            this.gunaComboBoxProcesses.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxProcesses.BorderRadius = 4;
            this.gunaComboBoxProcesses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBoxProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBoxProcesses.FillColor = System.Drawing.Color.Black;
            this.gunaComboBoxProcesses.FocusedColor = System.Drawing.Color.White;
            this.gunaComboBoxProcesses.FocusedState.BorderColor = System.Drawing.Color.White;
            this.gunaComboBoxProcesses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBoxProcesses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gunaComboBoxProcesses.ItemHeight = 30;
            this.gunaComboBoxProcesses.Location = new System.Drawing.Point(12, 41);
            this.gunaComboBoxProcesses.Name = "gunaComboBoxProcesses";
            this.gunaComboBoxProcesses.Size = new System.Drawing.Size(346, 36);
            this.gunaComboBoxProcesses.TabIndex = 0;
            // 
            // txtDllPath
            // 
            this.txtDllPath.Animated = true;
            this.txtDllPath.BorderRadius = 4;
            this.txtDllPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDllPath.DefaultText = "";
            this.txtDllPath.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txtDllPath.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.txtDllPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDllPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDllPath.FillColor = System.Drawing.Color.Black;
            this.txtDllPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDllPath.Location = new System.Drawing.Point(12, 83);
            this.txtDllPath.Name = "txtDllPath";
            this.txtDllPath.PasswordChar = '\0';
            this.txtDllPath.PlaceholderText = "Dll Location";
            this.txtDllPath.ReadOnly = true;
            this.txtDllPath.SelectedText = "";
            this.txtDllPath.Size = new System.Drawing.Size(346, 36);
            this.txtDllPath.TabIndex = 1;
            // 
            // btnSelectDll
            // 
            this.btnSelectDll.BorderColor = System.Drawing.Color.White;
            this.btnSelectDll.BorderRadius = 6;
            this.btnSelectDll.BorderThickness = 1;
            this.btnSelectDll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectDll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectDll.FillColor = System.Drawing.Color.Black;
            this.btnSelectDll.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelectDll.ForeColor = System.Drawing.Color.White;
            this.btnSelectDll.Location = new System.Drawing.Point(12, 126);
            this.btnSelectDll.Name = "btnSelectDll";
            this.btnSelectDll.Size = new System.Drawing.Size(164, 45);
            this.btnSelectDll.TabIndex = 2;
            this.btnSelectDll.Text = "Select Dll";
            this.btnSelectDll.Click += new System.EventHandler(this.btnSelectDll_Click);
            // 
            // btnInject
            // 
            this.btnInject.BorderColor = System.Drawing.Color.White;
            this.btnInject.BorderRadius = 6;
            this.btnInject.BorderThickness = 1;
            this.btnInject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInject.FillColor = System.Drawing.Color.Black;
            this.btnInject.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnInject.ForeColor = System.Drawing.Color.White;
            this.btnInject.Location = new System.Drawing.Point(12, 177);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(346, 45);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "Inject Dll";
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.IsContextMenuEnabled = false;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(171, 23);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Tenzo\'s Basic Dll Injector";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(194, 126);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(164, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Refresh Process";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2HtmlLabel1;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(-6, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(378, 38);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(341, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 36);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(308, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 36);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 234);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.btnSelectDll);
            this.Controls.Add(this.txtDllPath);
            this.Controls.Add(this.gunaComboBoxProcesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dll Injector By Tenzo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox gunaComboBoxProcesses;
        private Guna.UI2.WinForms.Guna2TextBox txtDllPath;
        private Guna.UI2.WinForms.Guna2Button btnSelectDll;
        private Guna.UI2.WinForms.Guna2Button btnInject;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}

