namespace Water.customers
{
    partial class appcreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.appname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.appplot = new System.Windows.Forms.TextBox();
            this.apppin = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.RichTextBox();
            this.prod = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterDataSet = new Water.waterDataSet();
            this.appdate = new System.Windows.Forms.DateTimePicker();
            this.rec = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.actions = new System.Windows.Forms.GroupBox();
            this.savebtn1 = new System.Windows.Forms.Button();
            this.savebtn2 = new System.Windows.Forms.Button();
            this.productsTableAdapter = new Water.waterDataSetTableAdapters.productsTableAdapter();
            this.userTableAdapter = new Water.waterDataSetTableAdapters.userTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.nat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applicants Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recorded By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plot No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 467);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Applicant\'s PIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Application Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Product/Service";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Area";
            // 
            // appname
            // 
            this.appname.Location = new System.Drawing.Point(169, 51);
            this.appname.Margin = new System.Windows.Forms.Padding(4);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(242, 25);
            this.appname.TabIndex = 8;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(578, 121);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(242, 25);
            this.email.TabIndex = 10;
            // 
            // appplot
            // 
            this.appplot.Location = new System.Drawing.Point(578, 51);
            this.appplot.Margin = new System.Windows.Forms.Padding(4);
            this.appplot.Name = "appplot";
            this.appplot.Size = new System.Drawing.Size(242, 25);
            this.appplot.TabIndex = 11;
            // 
            // apppin
            // 
            this.apppin.Location = new System.Drawing.Point(169, 461);
            this.apppin.Margin = new System.Windows.Forms.Padding(4);
            this.apppin.Name = "apppin";
            this.apppin.Size = new System.Drawing.Size(242, 25);
            this.apppin.TabIndex = 12;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(169, 117);
            this.area.Margin = new System.Windows.Forms.Padding(4);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(242, 104);
            this.area.TabIndex = 13;
            this.area.Text = "";
            // 
            // prod
            // 
            this.prod.DataSource = this.productsBindingSource;
            this.prod.DisplayMember = "product";
            this.prod.FormattingEnabled = true;
            this.prod.Location = new System.Drawing.Point(169, 268);
            this.prod.Margin = new System.Windows.Forms.Padding(4);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(242, 28);
            this.prod.TabIndex = 14;
            this.prod.ValueMember = "product";
            this.prod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.waterDataSet;
            // 
            // waterDataSet
            // 
            this.waterDataSet.DataSetName = "waterDataSet";
            this.waterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appdate
            // 
            this.appdate.CustomFormat = "dd/mm/yyyy";
            this.appdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appdate.Location = new System.Drawing.Point(169, 351);
            this.appdate.Margin = new System.Windows.Forms.Padding(4);
            this.appdate.Name = "appdate";
            this.appdate.Size = new System.Drawing.Size(159, 25);
            this.appdate.TabIndex = 15;
            // 
            // rec
            // 
            this.rec.DataSource = this.userBindingSource;
            this.rec.DisplayMember = "fullname";
            this.rec.FormattingEnabled = true;
            this.rec.Location = new System.Drawing.Point(578, 276);
            this.rec.Margin = new System.Windows.Forms.Padding(4);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(250, 28);
            this.rec.TabIndex = 16;
            this.rec.ValueMember = "fullname";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.waterDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(369, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "RECORD NEW APPLICANT\'S DETAILS";
            // 
            // actions
            // 
            this.actions.Controls.Add(this.savebtn1);
            this.actions.Controls.Add(this.savebtn2);
            this.actions.Location = new System.Drawing.Point(509, 461);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(319, 100);
            this.actions.TabIndex = 18;
            this.actions.TabStop = false;
            this.actions.Text = "ACTIONS";
            // 
            // savebtn1
            // 
            this.savebtn1.Location = new System.Drawing.Point(19, 55);
            this.savebtn1.Name = "savebtn1";
            this.savebtn1.Size = new System.Drawing.Size(110, 28);
            this.savebtn1.TabIndex = 1;
            this.savebtn1.Text = "save and new";
            this.savebtn1.UseVisualStyleBackColor = true;
            this.savebtn1.Click += new System.EventHandler(this.savebtn1_Click);
            // 
            // savebtn2
            // 
            this.savebtn2.Location = new System.Drawing.Point(187, 55);
            this.savebtn2.Name = "savebtn2";
            this.savebtn2.Size = new System.Drawing.Size(110, 28);
            this.savebtn2.TabIndex = 0;
            this.savebtn2.Text = "save and view";
            this.savebtn2.UseVisualStyleBackColor = true;
            this.savebtn2.Click += new System.EventHandler(this.savebtn2_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "National ID";
            // 
            // nat
            // 
            this.nat.Location = new System.Drawing.Point(578, 201);
            this.nat.Margin = new System.Windows.Forms.Padding(4);
            this.nat.Name = "nat";
            this.nat.Size = new System.Drawing.Size(242, 25);
            this.nat.TabIndex = 20;
            // 
            // appcreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 588);
            this.Controls.Add(this.nat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.appdate);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.area);
            this.Controls.Add(this.apppin);
            this.Controls.Add(this.appplot);
            this.Controls.Add(this.email);
            this.Controls.Add(this.appname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "appcreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Record New Customer Application";
            this.Load += new System.EventHandler(this.appcreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox appname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox appplot;
        private System.Windows.Forms.TextBox apppin;
        private System.Windows.Forms.RichTextBox area;
        private System.Windows.Forms.ComboBox prod;
        private System.Windows.Forms.DateTimePicker appdate;
        private System.Windows.Forms.ComboBox rec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox actions;
        private System.Windows.Forms.Button savebtn2;
        private System.Windows.Forms.Button savebtn1;
        private waterDataSet waterDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private waterDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private waterDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nat;
    }
}