namespace Water.bill
{
    partial class billcreate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rate = new System.Windows.Forms.TextBox();
            this.curr = new System.Windows.Forms.TextBox();
            this.prev = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.acc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rec = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterDataSet = new Water.waterDataSet();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.bal = new System.Windows.Forms.TextBox();
            this.tot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userTableAdapter = new Water.waterDataSetTableAdapters.userTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 472);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer1.Panel1.Controls.Add(this.rate);
            this.splitContainer1.Panel1.Controls.Add(this.curr);
            this.splitContainer1.Panel1.Controls.Add(this.prev);
            this.splitContainer1.Panel1.Controls.Add(this.name);
            this.splitContainer1.Panel1.Controls.Add(this.acc);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer1.Panel2.Controls.Add(this.rec);
            this.splitContainer1.Panel2.Controls.Add(this.bdate);
            this.splitContainer1.Panel2.Controls.Add(this.bal);
            this.splitContainer1.Panel2.Controls.Add(this.tot);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(795, 472);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(152, 274);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(227, 25);
            this.rate.TabIndex = 10;
            this.rate.TextChanged += new System.EventHandler(this.rate_TextChanged);
            // 
            // curr
            // 
            this.curr.Location = new System.Drawing.Point(152, 217);
            this.curr.Name = "curr";
            this.curr.Size = new System.Drawing.Size(227, 25);
            this.curr.TabIndex = 9;
            this.curr.TextChanged += new System.EventHandler(this.curr_TextChanged);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(152, 157);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(227, 25);
            this.prev.TabIndex = 8;
            this.prev.TextChanged += new System.EventHandler(this.prev_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(152, 89);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(227, 25);
            this.name.TabIndex = 7;
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(152, 29);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(227, 25);
            this.acc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Previous Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Reading";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account No";
            // 
            // rec
            // 
            this.rec.DataSource = this.userBindingSource;
            this.rec.DisplayMember = "fullname";
            this.rec.FormattingEnabled = true;
            this.rec.Location = new System.Drawing.Point(125, 217);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(227, 28);
            this.rec.TabIndex = 11;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.waterDataSet;
            // 
            // waterDataSet
            // 
            this.waterDataSet.DataSetName = "waterDataSet";
            this.waterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdate
            // 
            this.bdate.CustomFormat = "dd/mm/yyyy";
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdate.Location = new System.Drawing.Point(125, 157);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(142, 25);
            this.bdate.TabIndex = 10;
            this.bdate.Value = new System.DateTime(2015, 7, 2, 0, 1, 39, 0);
            // 
            // bal
            // 
            this.bal.Location = new System.Drawing.Point(125, 92);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(227, 25);
            this.bal.TabIndex = 9;
            this.bal.TextChanged += new System.EventHandler(this.bal_TextChanged);
            // 
            // tot
            // 
            this.tot.Location = new System.Drawing.Point(125, 29);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(227, 25);
            this.tot.TabIndex = 8;
            this.tot.TextChanged += new System.EventHandler(this.tot_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Recorded By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Billing Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(797, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 177);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save and View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save and New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // billcreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(991, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "billcreate";
            this.Text = "RECORD CONSUMPTION";
            this.Load += new System.EventHandler(this.billcreate_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox acc;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox curr;
        private System.Windows.Forms.TextBox prev;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox bal;
        private System.Windows.Forms.TextBox tot;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.ComboBox rec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private waterDataSet waterDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private waterDataSetTableAdapters.userTableAdapter userTableAdapter;

    }
}