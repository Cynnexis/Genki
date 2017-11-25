namespace Genki
{
	partial class AboutDialogBox
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialogBox));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.pb_logo = new System.Windows.Forms.PictureBox();
			this.l_productName = new System.Windows.Forms.Label();
			this.l_version = new System.Windows.Forms.Label();
			this.l_copyright = new System.Windows.Forms.Label();
			this.l_companyName = new System.Windows.Forms.Label();
			this.tb_description = new System.Windows.Forms.TextBox();
			this.b_ok = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
			this.tableLayoutPanel.Controls.Add(this.pb_logo, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.l_productName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.l_version, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.l_copyright, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.l_companyName, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.tb_description, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.b_ok, 1, 5);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(12, 11);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(556, 326);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// pb_logo
			// 
			this.pb_logo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
			this.pb_logo.Location = new System.Drawing.Point(4, 4);
			this.pb_logo.Margin = new System.Windows.Forms.Padding(4);
			this.pb_logo.Name = "pb_logo";
			this.tableLayoutPanel.SetRowSpan(this.pb_logo, 6);
			this.pb_logo.Size = new System.Drawing.Size(175, 318);
			this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_logo.TabIndex = 12;
			this.pb_logo.TabStop = false;
			// 
			// l_productName
			// 
			this.l_productName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l_productName.Location = new System.Drawing.Point(191, 0);
			this.l_productName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.l_productName.MaximumSize = new System.Drawing.Size(0, 21);
			this.l_productName.Name = "l_productName";
			this.l_productName.Size = new System.Drawing.Size(361, 21);
			this.l_productName.TabIndex = 19;
			this.l_productName.Text = "Genki";
			this.l_productName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// l_version
			// 
			this.l_version.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l_version.Location = new System.Drawing.Point(191, 32);
			this.l_version.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.l_version.MaximumSize = new System.Drawing.Size(0, 21);
			this.l_version.Name = "l_version";
			this.l_version.Size = new System.Drawing.Size(361, 21);
			this.l_version.TabIndex = 0;
			this.l_version.Text = "Version 1.0";
			this.l_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// l_copyright
			// 
			this.l_copyright.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l_copyright.Location = new System.Drawing.Point(191, 64);
			this.l_copyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.l_copyright.MaximumSize = new System.Drawing.Size(0, 21);
			this.l_copyright.Name = "l_copyright";
			this.l_copyright.Size = new System.Drawing.Size(361, 21);
			this.l_copyright.TabIndex = 21;
			this.l_copyright.Text = "No Copyright (not yet)";
			this.l_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// l_companyName
			// 
			this.l_companyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l_companyName.Location = new System.Drawing.Point(191, 96);
			this.l_companyName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.l_companyName.MaximumSize = new System.Drawing.Size(0, 21);
			this.l_companyName.Name = "l_companyName";
			this.l_companyName.Size = new System.Drawing.Size(361, 21);
			this.l_companyName.TabIndex = 22;
			this.l_companyName.Text = "Polytech Project";
			this.l_companyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb_description
			// 
			this.tb_description.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_description.Location = new System.Drawing.Point(191, 132);
			this.tb_description.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
			this.tb_description.Multiline = true;
			this.tb_description.Name = "tb_description";
			this.tb_description.ReadOnly = true;
			this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb_description.Size = new System.Drawing.Size(361, 155);
			this.tb_description.TabIndex = 23;
			this.tb_description.TabStop = false;
			this.tb_description.Text = "Genki is an application to generate a Sudoku Grid and play with it.";
			// 
			// b_ok
			// 
			this.b_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.b_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.b_ok.Location = new System.Drawing.Point(452, 295);
			this.b_ok.Margin = new System.Windows.Forms.Padding(4);
			this.b_ok.Name = "b_ok";
			this.b_ok.Size = new System.Drawing.Size(100, 27);
			this.b_ok.TabIndex = 24;
			this.b_ok.Text = "&OK";
			this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
			// 
			// AboutDialogBox
			// 
			this.AcceptButton = this.b_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 348);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialogBox";
			this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Genki...";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox pb_logo;
		private System.Windows.Forms.Label l_productName;
		private System.Windows.Forms.Label l_version;
		private System.Windows.Forms.Label l_copyright;
		private System.Windows.Forms.Label l_companyName;
		private System.Windows.Forms.TextBox tb_description;
		private System.Windows.Forms.Button b_ok;
	}
}
