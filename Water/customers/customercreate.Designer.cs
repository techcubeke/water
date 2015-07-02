namespace Water.customers
{
    partial class customercreate
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
            this.actions = new System.Windows.Forms.GroupBox();
            this.savebtn1 = new System.Windows.Forms.Button();
            this.savebtn2 = new System.Windows.Forms.Button();
            this.prod = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterDataSet = new Water.waterDataSet();
            this.area = new System.Windows.Forms.RichTextBox();
            this.apppin = new System.Windows.Forms.TextBox();
            this.appplot = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.appname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.nat = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new Water.waterDataSetTableAdapters.productsTableAdapter();
            this.actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // actions
            // 
            this.actions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actions.Controls.Add(this.savebtn1);
            this.actions.Controls.Add(this.savebtn2);
            this.actions.Location = new System.Drawing.Point(622, 466);
            this.actions.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.actions.Name = "actions";
            this.actions.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.actions.Size = new System.Drawing.Size(372, 146);
            this.actions.TabIndex = 35;
            this.actions.TabStop = false;
            this.actions.Text = "ACTIONS";
            // 
            // savebtn1
            // 
            this.savebtn1.Location = new System.Drawing.Point(27, 49);
            this.savebtn1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.savebtn1.Name = "savebtn1";
            this.savebtn1.Size = new System.Drawing.Size(128, 43);
            this.savebtn1.TabIndex = 1;
            this.savebtn1.Text = "save and new";
            this.savebtn1.UseVisualStyleBackColor = true;
            this.savebtn1.Click += new System.EventHandler(this.savebtn1_Click);
            // 
            // savebtn2
            // 
            this.savebtn2.Location = new System.Drawing.Point(218, 49);
            this.savebtn2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.savebtn2.Name = "savebtn2";
            this.savebtn2.Size = new System.Drawing.Size(128, 43);
            this.savebtn2.TabIndex = 0;
            this.savebtn2.Text = "save and view";
            this.savebtn2.UseVisualStyleBackColor = true;
            this.savebtn2.Click += new System.EventHandler(this.savebtn2_Click);
            // 
            // prod
            // 
            this.prod.DataSource = this.productsBindingSource;
            this.prod.DisplayMember = "product";
            this.prod.FormattingEnabled = true;
            this.prod.Location = new System.Drawing.Point(209, 466);
            this.prod.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(282, 28);
            this.prod.TabIndex = 32;
            this.prod.ValueMember = "product";
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
            // area
            // 
            this.area.Location = new System.Drawing.Point(686, 102);
            this.area.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(282, 91);
            this.area.TabIndex = 31;
            this.area.Text = "";
            this.area.TextChanged += new System.EventHandler(this.area_TextChanged);
            // 
            // apppin
            // 
            this.apppin.Location = new System.Drawing.Point(209, 533);
            this.apppin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.apppin.Name = "apppin";
            this.apppin.Size = new System.Drawing.Size(282, 25);
            this.apppin.TabIndex = 30;
            // 
            // appplot
            // 
            this.appplot.Location = new System.Drawing.Point(686, 242);
            this.appplot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.appplot.Name = "appplot";
            this.appplot.Size = new System.Drawing.Size(282, 25);
            this.appplot.TabIndex = 29;
            this.appplot.TextChanged += new System.EventHandler(this.appplot_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(209, 307);
            this.email.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(282, 25);
            this.email.TabIndex = 28;
            // 
            // appname
            // 
            this.appname.Location = new System.Drawing.Point(209, 29);
            this.appname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(282, 25);
            this.appname.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(541, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Area";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 466);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Product/Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 542);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Applicant\'s PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Plot No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Applicants Name";
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(686, 40);
            this.acc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(282, 25);
            this.acc.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Account No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "National ID";
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(209, 176);
            this.addr.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(282, 91);
            this.addr.TabIndex = 41;
            this.addr.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Address";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(209, 397);
            this.tel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(282, 25);
            this.tel.TabIndex = 42;
            // 
            // nat
            // 
            this.nat.Location = new System.Drawing.Point(209, 105);
            this.nat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nat.Name = "nat";
            this.nat.Size = new System.Drawing.Size(282, 25);
            this.nat.TabIndex = 43;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // customercreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 612);
            this.Controls.Add(this.nat);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.area);
            this.Controls.Add(this.apppin);
            this.Controls.Add(this.appplot);
            this.Controls.Add(this.email);
            this.Controls.Add(this.appname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "customercreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADD NEW CUSTOMER";
            this.Load += new System.EventHandler(this.customers_Load);
            this.actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox actions;
        private System.Windows.Forms.Button savebtn1;
        private System.Windows.Forms.Button savebtn2;
        private System.Windows.Forms.ComboBox prod;
        private System.Windows.Forms.RichTextBox area;
        private System.Windows.Forms.TextBox apppin;
        private System.Windows.Forms.TextBox appplot;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox appname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox addr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox nat;
        private waterDataSet waterDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private waterDataSetTableAdapters.productsTableAdapter productsTableAdapter;

    }
}