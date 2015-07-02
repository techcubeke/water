namespace Water.bill
{
    partial class consumption
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.acc1 = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterDataSet = new Water.waterDataSet();
            this.cons = new System.Windows.Forms.TextBox();
            this.curr = new System.Windows.Forms.TextBox();
            this.prev = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pdate = new System.Windows.Forms.DateTimePicker();
            this.rec = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status = new System.Windows.Forms.ComboBox();
            this.paid = new System.Windows.Forms.TextBox();
            this.bal = new System.Windows.Forms.TextBox();
            this.tot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userTableAdapter = new Water.waterDataSetTableAdapters.userTableAdapter();
            this.customerTableAdapter = new Water.waterDataSetTableAdapters.customerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.acc1);
            this.splitContainer1.Panel1.Controls.Add(this.cons);
            this.splitContainer1.Panel1.Controls.Add(this.curr);
            this.splitContainer1.Panel1.Controls.Add(this.prev);
            this.splitContainer1.Panel1.Controls.Add(this.rate);
            this.splitContainer1.Panel1.Controls.Add(this.name);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.pdate);
            this.splitContainer1.Panel2.Controls.Add(this.rec);
            this.splitContainer1.Panel2.Controls.Add(this.status);
            this.splitContainer1.Panel2.Controls.Add(this.paid);
            this.splitContainer1.Panel2.Controls.Add(this.bal);
            this.splitContainer1.Panel2.Controls.Add(this.tot);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(871, 601);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // acc1
            // 
            this.acc1.DataSource = this.customerBindingSource;
            this.acc1.DisplayMember = "account";
            this.acc1.FormattingEnabled = true;
            this.acc1.Location = new System.Drawing.Point(192, 48);
            this.acc1.Name = "acc1";
            this.acc1.Size = new System.Drawing.Size(197, 27);
            this.acc1.TabIndex = 12;
            this.acc1.SelectedIndexChanged += new System.EventHandler(this.acc1_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.waterDataSet;
            // 
            // waterDataSet
            // 
            this.waterDataSet.DataSetName = "waterDataSet";
            this.waterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cons
            // 
            this.cons.Location = new System.Drawing.Point(652, 162);
            this.cons.Name = "cons";
            this.cons.Size = new System.Drawing.Size(197, 27);
            this.cons.TabIndex = 11;
            // 
            // curr
            // 
            this.curr.Location = new System.Drawing.Point(652, 105);
            this.curr.Name = "curr";
            this.curr.Size = new System.Drawing.Size(197, 27);
            this.curr.TabIndex = 10;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(652, 48);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(197, 27);
            this.prev.TabIndex = 9;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(192, 162);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(197, 27);
            this.rate.TabIndex = 8;
            this.rate.Text = "100";
            this.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(192, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 27);
            this.name.TabIndex = 7;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(426, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "CONSUMPTION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(426, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "CURRENT READING";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "CUSTOMER NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "RATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(426, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "PREVIOUS READING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACCOUNT NUMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECORD BILL PAYMENT ";
            // 
            // pdate
            // 
            this.pdate.CustomFormat = "dd/M/yyyy";
            this.pdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pdate.Location = new System.Drawing.Point(652, 109);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(163, 27);
            this.pdate.TabIndex = 19;
            // 
            // rec
            // 
            this.rec.DataSource = this.userBindingSource;
            this.rec.DisplayMember = "fullname";
            this.rec.FormattingEnabled = true;
            this.rec.Location = new System.Drawing.Point(652, 181);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(197, 27);
            this.rec.TabIndex = 18;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.waterDataSet;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Partial",
            "Paid"});
            this.status.Location = new System.Drawing.Point(192, 198);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(160, 27);
            this.status.TabIndex = 17;
            // 
            // paid
            // 
            this.paid.Location = new System.Drawing.Point(652, 36);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(197, 27);
            this.paid.TabIndex = 16;
            this.paid.Text = "0";
            this.paid.TextChanged += new System.EventHandler(this.paid_TextChanged);
            // 
            // bal
            // 
            this.bal.Location = new System.Drawing.Point(192, 119);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(197, 27);
            this.bal.TabIndex = 14;
            // 
            // tot
            // 
            this.tot.Location = new System.Drawing.Point(192, 39);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(197, 27);
            this.tot.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(421, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "RECORDED BY";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(12, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "STATUS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(421, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "PAYMENT DATE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(12, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "BALANCE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(421, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "AMOUNT PAID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "UNPAID AMOUNT";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Pay and New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Pay and View";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // consumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(871, 601);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "consumption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONSUMPTION";
            this.Load += new System.EventHandler(this.consumption_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cons;
        private System.Windows.Forms.TextBox curr;
        private System.Windows.Forms.TextBox prev;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox acc1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.TextBox bal;
        private System.Windows.Forms.TextBox tot;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox rec;
        private System.Windows.Forms.DateTimePicker pdate;
        private waterDataSet waterDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private waterDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private waterDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;


    }
}