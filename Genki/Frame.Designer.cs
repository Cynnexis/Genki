﻿namespace Genki
{
	partial class Frame
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.mi_file = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_newGame = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_load = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_edit = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_help = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_about = new System.Windows.Forms.ToolStripMenuItem();
			this.p_header = new System.Windows.Forms.Panel();
			this.l_titleEnglish = new System.Windows.Forms.Label();
			this.l_titlerHirigana = new System.Windows.Forms.Label();
			this.l_titleKanji = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.StatusStrip();
			this.l_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.p_body = new System.Windows.Forms.Panel();
			this.dvg_grid = new System.Windows.Forms.DataGridView();
			this.p_stopwatch = new System.Windows.Forms.Panel();
			this.b_stopwatchControl = new System.Windows.Forms.Button();
			this.tb_stopwatch = new System.Windows.Forms.TextBox();
			this.l_stopwatch = new System.Windows.Forms.Label();
			this.p_control = new System.Windows.Forms.Panel();
			this.gb_cellOption = new System.Windows.Forms.GroupBox();
			this.b_editDraft = new System.Windows.Forms.Button();
			this.b_removeDraft = new System.Windows.Forms.Button();
			this.b_addDraft = new System.Windows.Forms.Button();
			this.lb_draft = new System.Windows.Forms.ListBox();
			this.l_cellDraft = new System.Windows.Forms.Label();
			this.n_cellValue = new System.Windows.Forms.NumericUpDown();
			this.l_cellValue = new System.Windows.Forms.Label();
			this.menu.SuspendLayout();
			this.p_header.SuspendLayout();
			this.status.SuspendLayout();
			this.p_body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvg_grid)).BeginInit();
			this.p_stopwatch.SuspendLayout();
			this.p_control.SuspendLayout();
			this.gb_cellOption.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.n_cellValue)).BeginInit();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_file,
            this.mi_edit,
            this.mi_help});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(747, 28);
			this.menu.TabIndex = 0;
			this.menu.Text = "menu";
			// 
			// mi_file
			// 
			this.mi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_newGame,
            this.mi_save,
            this.mi_load,
            this.mi_exit});
			this.mi_file.Name = "mi_file";
			this.mi_file.Size = new System.Drawing.Size(58, 24);
			this.mi_file.Text = "Genki";
			// 
			// mi_newGame
			// 
			this.mi_newGame.Name = "mi_newGame";
			this.mi_newGame.Size = new System.Drawing.Size(157, 26);
			this.mi_newGame.Text = "New Game";
			// 
			// mi_save
			// 
			this.mi_save.Name = "mi_save";
			this.mi_save.Size = new System.Drawing.Size(157, 26);
			this.mi_save.Text = "Save";
			// 
			// mi_load
			// 
			this.mi_load.Name = "mi_load";
			this.mi_load.Size = new System.Drawing.Size(157, 26);
			this.mi_load.Text = "Load";
			// 
			// mi_exit
			// 
			this.mi_exit.Name = "mi_exit";
			this.mi_exit.Size = new System.Drawing.Size(157, 26);
			this.mi_exit.Text = "Exit";
			// 
			// mi_edit
			// 
			this.mi_edit.Name = "mi_edit";
			this.mi_edit.Size = new System.Drawing.Size(47, 24);
			this.mi_edit.Text = "Edit";
			// 
			// mi_help
			// 
			this.mi_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_about});
			this.mi_help.Name = "mi_help";
			this.mi_help.Size = new System.Drawing.Size(53, 24);
			this.mi_help.Text = "Help";
			// 
			// mi_about
			// 
			this.mi_about.Name = "mi_about";
			this.mi_about.Size = new System.Drawing.Size(166, 26);
			this.mi_about.Text = "About Genki";
			this.mi_about.Click += new System.EventHandler(this.mi_about_Click);
			// 
			// p_header
			// 
			this.p_header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.p_header.BackColor = System.Drawing.Color.DarkSalmon;
			this.p_header.Controls.Add(this.l_titleEnglish);
			this.p_header.Controls.Add(this.l_titlerHirigana);
			this.p_header.Controls.Add(this.l_titleKanji);
			this.p_header.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_header.Location = new System.Drawing.Point(0, 28);
			this.p_header.Name = "p_header";
			this.p_header.Size = new System.Drawing.Size(747, 96);
			this.p_header.TabIndex = 1;
			// 
			// l_titleEnglish
			// 
			this.l_titleEnglish.AutoSize = true;
			this.l_titleEnglish.Location = new System.Drawing.Point(355, 63);
			this.l_titleEnglish.Name = "l_titleEnglish";
			this.l_titleEnglish.Size = new System.Drawing.Size(45, 17);
			this.l_titleEnglish.TabIndex = 2;
			this.l_titleEnglish.Text = "Genki";
			// 
			// l_titlerHirigana
			// 
			this.l_titlerHirigana.AutoSize = true;
			this.l_titlerHirigana.Location = new System.Drawing.Point(355, 14);
			this.l_titlerHirigana.Name = "l_titlerHirigana";
			this.l_titlerHirigana.Size = new System.Drawing.Size(42, 17);
			this.l_titlerHirigana.TabIndex = 1;
			this.l_titlerHirigana.Text = "げんき";
			// 
			// l_titleKanji
			// 
			this.l_titleKanji.AutoSize = true;
			this.l_titleKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_titleKanji.ForeColor = System.Drawing.Color.DarkRed;
			this.l_titleKanji.Location = new System.Drawing.Point(342, 31);
			this.l_titleKanji.Name = "l_titleKanji";
			this.l_titleKanji.Size = new System.Drawing.Size(73, 32);
			this.l_titleKanji.TabIndex = 0;
			this.l_titleKanji.Text = "元気";
			// 
			// status
			// 
			this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_status});
			this.status.Location = new System.Drawing.Point(0, 476);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(747, 25);
			this.status.TabIndex = 2;
			// 
			// l_status
			// 
			this.l_status.Name = "l_status";
			this.l_status.Size = new System.Drawing.Size(57, 20);
			this.l_status.Text = "Started";
			// 
			// p_body
			// 
			this.p_body.Controls.Add(this.dvg_grid);
			this.p_body.Controls.Add(this.p_stopwatch);
			this.p_body.Controls.Add(this.p_control);
			this.p_body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_body.Location = new System.Drawing.Point(0, 124);
			this.p_body.Name = "p_body";
			this.p_body.Size = new System.Drawing.Size(747, 352);
			this.p_body.TabIndex = 3;
			// 
			// dvg_grid
			// 
			this.dvg_grid.AccessibleDescription = this.dvg_grid.AccessibleName;
			this.dvg_grid.AccessibleName = "Sudoku Grid";
			this.dvg_grid.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			this.dvg_grid.AllowUserToAddRows = false;
			this.dvg_grid.AllowUserToDeleteRows = false;
			this.dvg_grid.AllowUserToResizeColumns = false;
			this.dvg_grid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.NullValue = "0";
			this.dvg_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dvg_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvg_grid.BackgroundColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = "0";
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvg_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dvg_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dvg_grid.ColumnHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.NullValue = "0";
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dvg_grid.DefaultCellStyle = dataGridViewCellStyle3;
			this.dvg_grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dvg_grid.EnableHeadersVisualStyles = false;
			this.dvg_grid.Location = new System.Drawing.Point(0, 70);
			this.dvg_grid.MultiSelect = false;
			this.dvg_grid.Name = "dvg_grid";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.NullValue = "0";
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvg_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dvg_grid.RowHeadersVisible = false;
			this.dvg_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dvg_grid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dvg_grid.RowTemplate.DefaultCellStyle.NullValue = "0";
			this.dvg_grid.RowTemplate.Height = 24;
			this.dvg_grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dvg_grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dvg_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dvg_grid.ShowCellErrors = false;
			this.dvg_grid.ShowEditingIcon = false;
			this.dvg_grid.ShowRowErrors = false;
			this.dvg_grid.Size = new System.Drawing.Size(592, 282);
			this.dvg_grid.TabIndex = 0;
			this.dvg_grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellValueChanged);
			this.dvg_grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellEnter);
			this.dvg_grid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellLeave);
			this.dvg_grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellValueChanged);
			// 
			// p_stopwatch
			// 
			this.p_stopwatch.Controls.Add(this.b_stopwatchControl);
			this.p_stopwatch.Controls.Add(this.tb_stopwatch);
			this.p_stopwatch.Controls.Add(this.l_stopwatch);
			this.p_stopwatch.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_stopwatch.Location = new System.Drawing.Point(0, 0);
			this.p_stopwatch.Name = "p_stopwatch";
			this.p_stopwatch.Size = new System.Drawing.Size(592, 70);
			this.p_stopwatch.TabIndex = 2;
			// 
			// b_stopwatchControl
			// 
			this.b_stopwatchControl.Location = new System.Drawing.Point(354, 21);
			this.b_stopwatchControl.Name = "b_stopwatchControl";
			this.b_stopwatchControl.Size = new System.Drawing.Size(75, 23);
			this.b_stopwatchControl.TabIndex = 2;
			this.b_stopwatchControl.Text = "❚❚\r\n►";
			this.b_stopwatchControl.UseVisualStyleBackColor = true;
			// 
			// tb_stopwatch
			// 
			this.tb_stopwatch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_stopwatch.Location = new System.Drawing.Point(247, 23);
			this.tb_stopwatch.Name = "tb_stopwatch";
			this.tb_stopwatch.Size = new System.Drawing.Size(100, 22);
			this.tb_stopwatch.TabIndex = 1;
			// 
			// l_stopwatch
			// 
			this.l_stopwatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_stopwatch.AutoSize = true;
			this.l_stopwatch.Location = new System.Drawing.Point(275, 4);
			this.l_stopwatch.Name = "l_stopwatch";
			this.l_stopwatch.Size = new System.Drawing.Size(44, 17);
			this.l_stopwatch.TabIndex = 0;
			this.l_stopwatch.Text = "Timer";
			// 
			// p_control
			// 
			this.p_control.AutoScroll = true;
			this.p_control.Controls.Add(this.gb_cellOption);
			this.p_control.Dock = System.Windows.Forms.DockStyle.Right;
			this.p_control.Location = new System.Drawing.Point(592, 0);
			this.p_control.Name = "p_control";
			this.p_control.Size = new System.Drawing.Size(155, 352);
			this.p_control.TabIndex = 1;
			// 
			// gb_cellOption
			// 
			this.gb_cellOption.Controls.Add(this.b_editDraft);
			this.gb_cellOption.Controls.Add(this.b_removeDraft);
			this.gb_cellOption.Controls.Add(this.b_addDraft);
			this.gb_cellOption.Controls.Add(this.lb_draft);
			this.gb_cellOption.Controls.Add(this.l_cellDraft);
			this.gb_cellOption.Controls.Add(this.n_cellValue);
			this.gb_cellOption.Controls.Add(this.l_cellValue);
			this.gb_cellOption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_cellOption.Location = new System.Drawing.Point(0, 0);
			this.gb_cellOption.Name = "gb_cellOption";
			this.gb_cellOption.Size = new System.Drawing.Size(155, 352);
			this.gb_cellOption.TabIndex = 0;
			this.gb_cellOption.TabStop = false;
			this.gb_cellOption.Text = "Selected Cell";
			// 
			// b_editDraft
			// 
			this.b_editDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.b_editDraft.Location = new System.Drawing.Point(10, 269);
			this.b_editDraft.Name = "b_editDraft";
			this.b_editDraft.Size = new System.Drawing.Size(133, 23);
			this.b_editDraft.TabIndex = 6;
			this.b_editDraft.Text = "Edit";
			this.b_editDraft.UseVisualStyleBackColor = true;
			this.b_editDraft.Click += new System.EventHandler(this.b_editDraft_Click);
			// 
			// b_removeDraft
			// 
			this.b_removeDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.b_removeDraft.Location = new System.Drawing.Point(72, 298);
			this.b_removeDraft.Name = "b_removeDraft";
			this.b_removeDraft.Size = new System.Drawing.Size(71, 23);
			this.b_removeDraft.TabIndex = 5;
			this.b_removeDraft.Text = "Remove";
			this.b_removeDraft.UseVisualStyleBackColor = true;
			this.b_removeDraft.Click += new System.EventHandler(this.b_removeDraft_Click);
			// 
			// b_addDraft
			// 
			this.b_addDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.b_addDraft.Location = new System.Drawing.Point(7, 298);
			this.b_addDraft.Name = "b_addDraft";
			this.b_addDraft.Size = new System.Drawing.Size(66, 23);
			this.b_addDraft.TabIndex = 4;
			this.b_addDraft.Text = "Add";
			this.b_addDraft.UseVisualStyleBackColor = true;
			this.b_addDraft.Click += new System.EventHandler(this.b_addDraft_Click);
			// 
			// lb_draft
			// 
			this.lb_draft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_draft.FormattingEnabled = true;
			this.lb_draft.ItemHeight = 16;
			this.lb_draft.Location = new System.Drawing.Point(7, 93);
			this.lb_draft.Name = "lb_draft";
			this.lb_draft.Size = new System.Drawing.Size(136, 164);
			this.lb_draft.TabIndex = 3;
			this.lb_draft.SelectedIndexChanged += new System.EventHandler(this.lb_draft_SelectedIndexChanged);
			// 
			// l_cellDraft
			// 
			this.l_cellDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_cellDraft.AutoSize = true;
			this.l_cellDraft.Location = new System.Drawing.Point(7, 72);
			this.l_cellDraft.Name = "l_cellDraft";
			this.l_cellDraft.Size = new System.Drawing.Size(39, 17);
			this.l_cellDraft.TabIndex = 2;
			this.l_cellDraft.Text = "Draft";
			// 
			// n_cellValue
			// 
			this.n_cellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.n_cellValue.Location = new System.Drawing.Point(7, 43);
			this.n_cellValue.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.n_cellValue.Name = "n_cellValue";
			this.n_cellValue.Size = new System.Drawing.Size(136, 22);
			this.n_cellValue.TabIndex = 1;
			this.n_cellValue.ValueChanged += new System.EventHandler(this.n_cellValue_ValueChanged);
			// 
			// l_cellValue
			// 
			this.l_cellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_cellValue.AutoSize = true;
			this.l_cellValue.Location = new System.Drawing.Point(7, 22);
			this.l_cellValue.Name = "l_cellValue";
			this.l_cellValue.Size = new System.Drawing.Size(44, 17);
			this.l_cellValue.TabIndex = 0;
			this.l_cellValue.Text = "Value";
			// 
			// Frame
			// 
			this.AccessibleName = "Main Window";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 501);
			this.Controls.Add(this.p_body);
			this.Controls.Add(this.status);
			this.Controls.Add(this.p_header);
			this.Controls.Add(this.menu);
			this.MainMenuStrip = this.menu;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Frame";
			this.Text = "Genki";
			this.Resize += new System.EventHandler(this.frame_Resize);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.p_header.ResumeLayout(false);
			this.p_header.PerformLayout();
			this.status.ResumeLayout(false);
			this.status.PerformLayout();
			this.p_body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dvg_grid)).EndInit();
			this.p_stopwatch.ResumeLayout(false);
			this.p_stopwatch.PerformLayout();
			this.p_control.ResumeLayout(false);
			this.gb_cellOption.ResumeLayout(false);
			this.gb_cellOption.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.n_cellValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem mi_file;
		private System.Windows.Forms.ToolStripMenuItem mi_newGame;
		private System.Windows.Forms.ToolStripMenuItem mi_save;
		private System.Windows.Forms.ToolStripMenuItem mi_load;
		private System.Windows.Forms.ToolStripMenuItem mi_exit;
		private System.Windows.Forms.ToolStripMenuItem mi_edit;
		private System.Windows.Forms.ToolStripMenuItem mi_help;
		private System.Windows.Forms.ToolStripMenuItem mi_about;
		private System.Windows.Forms.Panel p_header;
		private System.Windows.Forms.Label l_titleKanji;
		private System.Windows.Forms.Label l_titleEnglish;
		private System.Windows.Forms.Label l_titlerHirigana;
		private System.Windows.Forms.StatusStrip status;
		private System.Windows.Forms.ToolStripStatusLabel l_status;
		private System.Windows.Forms.Panel p_body;
		private System.Windows.Forms.Panel p_stopwatch;
		private System.Windows.Forms.Panel p_control;
		private System.Windows.Forms.DataGridView dvg_grid;
		private System.Windows.Forms.GroupBox gb_cellOption;
		private System.Windows.Forms.NumericUpDown n_cellValue;
		private System.Windows.Forms.Label l_cellValue;
		private System.Windows.Forms.Button b_removeDraft;
		private System.Windows.Forms.Button b_addDraft;
		private System.Windows.Forms.ListBox lb_draft;
		private System.Windows.Forms.Label l_cellDraft;
		private System.Windows.Forms.Button b_editDraft;
		private System.Windows.Forms.Label l_stopwatch;
		private System.Windows.Forms.TextBox tb_stopwatch;
		private System.Windows.Forms.Button b_stopwatchControl;
	}
}

