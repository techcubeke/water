namespace Water.bill
{
    partial class billdetails
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
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.waterDataSet = new Water.waterDataSet();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new Water.waterDataSetTableAdapters.billTableAdapter();
            this.tableAdapterManager = new Water.waterDataSetTableAdapters.TableAdapterManager();
            this.accountnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousreadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentreadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // billDataGridView
            // 
            this.billDataGridView.AutoGenerateColumns = false;
            this.billDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountnoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.previousreadingDataGridViewTextBoxColumn,
            this.currentreadingDataGridViewTextBoxColumn,
            this.consumptionDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.billdateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.recordedbyDataGridViewTextBoxColumn});
            this.billDataGridView.DataSource = this.billBindingSource;
            this.billDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billDataGridView.Location = new System.Drawing.Point(0, 0);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.Size = new System.Drawing.Size(1370, 464);
            this.billDataGridView.TabIndex = 1;
            // 
            // waterDataSet
            // 
            this.waterDataSet.DataSetName = "waterDataSet";
            this.waterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.waterDataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.applicationsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.billTableAdapter = this.billTableAdapter;
            this.tableAdapterManager.customerTableAdapter = null;
         //   this.tableAdapterManager.disconnectionsTableAdapter = null;
            this.tableAdapterManager.feesTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
          //  this.tableAdapterManager.recconectTableAdapter = null;
            this.tableAdapterManager.saleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Water.waterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // accountnoDataGridViewTextBoxColumn
            // 
            this.accountnoDataGridViewTextBoxColumn.DataPropertyName = "accountno";
            this.accountnoDataGridViewTextBoxColumn.HeaderText = "Account No";
            this.accountnoDataGridViewTextBoxColumn.Name = "accountnoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // previousreadingDataGridViewTextBoxColumn
            // 
            this.previousreadingDataGridViewTextBoxColumn.DataPropertyName = "previousreading";
            this.previousreadingDataGridViewTextBoxColumn.HeaderText = "Previous Reading";
            this.previousreadingDataGridViewTextBoxColumn.Name = "previousreadingDataGridViewTextBoxColumn";
            // 
            // currentreadingDataGridViewTextBoxColumn
            // 
            this.currentreadingDataGridViewTextBoxColumn.DataPropertyName = "currentreading";
            this.currentreadingDataGridViewTextBoxColumn.HeaderText = "Current Reading";
            this.currentreadingDataGridViewTextBoxColumn.Name = "currentreadingDataGridViewTextBoxColumn";
            // 
            // consumptionDataGridViewTextBoxColumn
            // 
            this.consumptionDataGridViewTextBoxColumn.DataPropertyName = "consumption";
            this.consumptionDataGridViewTextBoxColumn.HeaderText = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.Name = "consumptionDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // billdateDataGridViewTextBoxColumn
            // 
            this.billdateDataGridViewTextBoxColumn.DataPropertyName = "billdate";
            this.billdateDataGridViewTextBoxColumn.HeaderText = "Bill Date";
            this.billdateDataGridViewTextBoxColumn.Name = "billdateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // recordedbyDataGridViewTextBoxColumn
            // 
            this.recordedbyDataGridViewTextBoxColumn.DataPropertyName = "recordedby";
            this.recordedbyDataGridViewTextBoxColumn.HeaderText = "Recorded by";
            this.recordedbyDataGridViewTextBoxColumn.Name = "recordedbyDataGridViewTextBoxColumn";
            // 
            // billdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 464);
            this.Controls.Add(this.billDataGridView);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "billdetails";
            this.Text = "BILL DETAILS";
            this.Load += new System.EventHandler(this.billdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView billDataGridView;
        private waterDataSet waterDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private waterDataSetTableAdapters.billTableAdapter billTableAdapter;
        private waterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousreadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentreadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordedbyDataGridViewTextBoxColumn;
    }
}