namespace StudentManagerCSharpXamppMySQL
{
	partial class frmListViewStd
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
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
			this.lvStdRecords = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvStdRecords
			// 
			this.lvStdRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lvStdRecords.HideSelection = false;
			this.lvStdRecords.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
			this.lvStdRecords.Location = new System.Drawing.Point(12, 12);
			this.lvStdRecords.Name = "lvStdRecords";
			this.lvStdRecords.Size = new System.Drawing.Size(1237, 587);
			this.lvStdRecords.TabIndex = 13;
			this.lvStdRecords.UseCompatibleStateImageBehavior = false;
			this.lvStdRecords.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "SID";
			this.columnHeader1.Width = 75;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "First Name";
			this.columnHeader2.Width = 141;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Last Name";
			this.columnHeader3.Width = 129;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "SSN";
			this.columnHeader4.Width = 122;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "DOB";
			this.columnHeader5.Width = 123;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Gender";
			this.columnHeader6.Width = 102;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Race";
			this.columnHeader7.Width = 106;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Avatar";
			this.columnHeader8.Width = 107;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Submissions";
			this.columnHeader9.Width = 284;
			// 
			// frmListViewStd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1261, 611);
			this.Controls.Add(this.lvStdRecords);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "frmListViewStd";
			this.Text = "List View of Students Data";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvStdRecords;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
	}
}