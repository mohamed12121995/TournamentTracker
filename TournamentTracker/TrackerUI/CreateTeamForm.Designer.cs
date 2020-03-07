namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telephoneValue = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMember = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(19, 86);
            this.teamNameValue.Multiline = true;
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(319, 30);
            this.teamNameValue.TabIndex = 18;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.teamNameLabel.Location = new System.Drawing.Point(13, 46);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 17;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(13, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(157, 37);
            this.headerLabel.TabIndex = 16;
            this.headerLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(19, 179);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(319, 25);
            this.selectTeamMemberDropDown.TabIndex = 21;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(13, 129);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.selectTeamMemberLabel.TabIndex = 20;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamMemberButton.Location = new System.Drawing.Point(90, 221);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(152, 44);
            this.addTeamMemberButton.TabIndex = 22;
            this.addTeamMemberButton.Text = "Add Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telephoneValue);
            this.groupBox1.Controls.Add(this.telephoneLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.emailValue);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.lastNameValue);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.firstNameValue);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 273);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(156, 42);
            this.firstNameValue.Multiline = true;
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(169, 19);
            this.firstNameValue.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 32);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(157, 86);
            this.lastNameValue.Multiline = true;
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(169, 19);
            this.lastNameValue.TabIndex = 23;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 76);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.lastNameLabel.TabIndex = 22;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(157, 130);
            this.emailValue.Multiline = true;
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(169, 19);
            this.emailValue.TabIndex = 25;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emailLabel.Location = new System.Drawing.Point(7, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 37);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email";
            // 
            // telephoneValue
            // 
            this.telephoneValue.Location = new System.Drawing.Point(157, 176);
            this.telephoneValue.Multiline = true;
            this.telephoneValue.Name = "telephoneValue";
            this.telephoneValue.Size = new System.Drawing.Size(169, 19);
            this.telephoneValue.TabIndex = 27;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.telephoneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.telephoneLabel.Location = new System.Drawing.Point(7, 166);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(139, 37);
            this.telephoneLabel.TabIndex = 26;
            this.telephoneLabel.Text = "Telephone";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(101, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create Member";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 21;
            this.teamMembersListBox.Location = new System.Drawing.Point(379, 87);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(309, 466);
            this.teamMembersListBox.TabIndex = 25;
            // 
            // deleteSelectedMember
            // 
            this.deleteSelectedMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMember.Location = new System.Drawing.Point(716, 262);
            this.deleteSelectedMember.Name = "deleteSelectedMember";
            this.deleteSelectedMember.Size = new System.Drawing.Size(105, 79);
            this.deleteSelectedMember.TabIndex = 27;
            this.deleteSelectedMember.Text = "Delete Selected";
            this.deleteSelectedMember.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(359, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 30;
            this.button2.Text = "Create Team";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(839, 649);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteSelectedMember);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Button addTeamMemberButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox telephoneValue;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMember;
        private System.Windows.Forms.Button button2;
    }
}