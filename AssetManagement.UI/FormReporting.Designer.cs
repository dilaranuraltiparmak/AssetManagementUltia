namespace AssetManagement.UI
{
    partial class FormReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.assetDBDataSet = new AssetManagement.UI.AssetDBDataSet();
            this.assetDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetDBDataSet1 = new AssetManagement.UI.AssetDBDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new AssetManagement.UI.AssetDBDataSet1TableAdapters.LoginTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 454);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // assetDBDataSet
            // 
            this.assetDBDataSet.DataSetName = "AssetDBDataSet";
            this.assetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetDBDataSetBindingSource
            // 
            this.assetDBDataSetBindingSource.DataSource = this.assetDBDataSet;
            this.assetDBDataSetBindingSource.Position = 0;
            // 
            // assetDBDataSet1
            // 
            this.assetDBDataSet1.DataSetName = "AssetDBDataSet1";
            this.assetDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.assetDBDataSet1;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kayıtlı Kullanıcı Ekranı";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(90, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 315);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rolu";
            this.columnHeader2.Width = 150;
            // 
            // FormReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormReporting";
            this.Text = "Rapor Ekranı";
            this.Load += new System.EventHandler(this.FormReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource assetDBDataSetBindingSource;
        private AssetDBDataSet assetDBDataSet;
        private AssetDBDataSet1 assetDBDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private AssetDBDataSet1TableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}