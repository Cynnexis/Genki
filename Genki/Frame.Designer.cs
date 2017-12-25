namespace Genki
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.mi_file = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_newGame = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mi_open = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mi_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_window = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_displayHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_debug = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_breakNow = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_printGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_printVirtualGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_printPhysicalGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_printSolutionGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_forceCopyDebug = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_solveSudokuDebug = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_setDefaultGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_help = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_helpMe = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mi_about = new System.Windows.Forms.ToolStripMenuItem();
			this.p_header = new System.Windows.Forms.Panel();
			this.l_titleEnglish = new System.Windows.Forms.Label();
			this.l_titleHirigana = new System.Windows.Forms.Label();
			this.l_titleKanji = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.StatusStrip();
			this.l_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.p_body = new System.Windows.Forms.Panel();
			this.dvg_grid = new System.Windows.Forms.DataGridView();
			this.p_stopwatch = new System.Windows.Forms.Panel();
			this.p_stopwatchControls = new System.Windows.Forms.Panel();
			this.tb_stopwatch = new System.Windows.Forms.TextBox();
			this.b_stopwatchControl = new System.Windows.Forms.Button();
			this.l_stopwatch = new System.Windows.Forms.Label();
			this.p_control = new System.Windows.Forms.Panel();
			this.gb_cellOption = new System.Windows.Forms.GroupBox();
			this.p_draft = new System.Windows.Forms.Panel();
			this.l_cellDraft = new System.Windows.Forms.Label();
			this.lb_draft = new System.Windows.Forms.ListBox();
			this.p_valueControl = new System.Windows.Forms.Panel();
			this.l_cellValue = new System.Windows.Forms.Label();
			this.n_cellValue = new System.Windows.Forms.NumericUpDown();
			this.p_controlButtons = new System.Windows.Forms.Panel();
			this.b_addDraft = new System.Windows.Forms.Button();
			this.b_editDraft = new System.Windows.Forms.Button();
			this.b_removeDraft = new System.Windows.Forms.Button();
			this.tp_pronunciation = new System.Windows.Forms.ToolTip(this.components);
			this.menu.SuspendLayout();
			this.p_header.SuspendLayout();
			this.status.SuspendLayout();
			this.p_body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvg_grid)).BeginInit();
			this.p_stopwatch.SuspendLayout();
			this.p_stopwatchControls.SuspendLayout();
			this.p_control.SuspendLayout();
			this.gb_cellOption.SuspendLayout();
			this.p_draft.SuspendLayout();
			this.p_valueControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.n_cellValue)).BeginInit();
			this.p_controlButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_file,
            this.mi_window,
            this.mi_debug,
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
            this.toolStripSeparator1,
            this.mi_open,
            this.mi_save,
            this.toolStripSeparator2,
            this.mi_exit});
			this.mi_file.Name = "mi_file";
			this.mi_file.Size = new System.Drawing.Size(58, 24);
			this.mi_file.Text = "&Genki";
			// 
			// mi_newGame
			// 
			this.mi_newGame.Name = "mi_newGame";
			this.mi_newGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.mi_newGame.Size = new System.Drawing.Size(210, 26);
			this.mi_newGame.Text = "&New Game";
			this.mi_newGame.Click += new System.EventHandler(this.mi_newGame_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
			// 
			// mi_open
			// 
			this.mi_open.Name = "mi_open";
			this.mi_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mi_open.Size = new System.Drawing.Size(210, 26);
			this.mi_open.Text = "&Open";
			this.mi_open.Click += new System.EventHandler(this.mi_open_Click);
			// 
			// mi_save
			// 
			this.mi_save.Name = "mi_save";
			this.mi_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mi_save.Size = new System.Drawing.Size(210, 26);
			this.mi_save.Text = "&Save";
			this.mi_save.Click += new System.EventHandler(this.mi_save_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
			// 
			// mi_exit
			// 
			this.mi_exit.Name = "mi_exit";
			this.mi_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.mi_exit.Size = new System.Drawing.Size(210, 26);
			this.mi_exit.Text = "Exit";
			this.mi_exit.Click += new System.EventHandler(this.mi_exit_Click);
			// 
			// mi_window
			// 
			this.mi_window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_displayHeader});
			this.mi_window.Name = "mi_window";
			this.mi_window.Size = new System.Drawing.Size(76, 24);
			this.mi_window.Text = "&Window";
			// 
			// mi_displayHeader
			// 
			this.mi_displayHeader.Checked = true;
			this.mi_displayHeader.CheckOnClick = true;
			this.mi_displayHeader.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mi_displayHeader.Name = "mi_displayHeader";
			this.mi_displayHeader.Size = new System.Drawing.Size(186, 26);
			this.mi_displayHeader.Text = "Display Header";
			this.mi_displayHeader.CheckedChanged += new System.EventHandler(this.mi_displayHeader_CheckedChanged);
			// 
			// mi_debug
			// 
			this.mi_debug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_breakNow,
            this.mi_printGrid,
            this.mi_forceCopyDebug,
            this.mi_solveSudokuDebug,
            this.mi_setDefaultGrid});
			this.mi_debug.Name = "mi_debug";
			this.mi_debug.Size = new System.Drawing.Size(66, 24);
			this.mi_debug.Text = "&Debug";
			// 
			// mi_breakNow
			// 
			this.mi_breakNow.Name = "mi_breakNow";
			this.mi_breakNow.Size = new System.Drawing.Size(205, 26);
			this.mi_breakNow.Text = "Break Now";
			this.mi_breakNow.Click += new System.EventHandler(this.mi_breakNow_Click);
			// 
			// mi_printGrid
			// 
			this.mi_printGrid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_printVirtualGrid,
            this.mi_printPhysicalGrid,
            this.mi_printSolutionGrid});
			this.mi_printGrid.Name = "mi_printGrid";
			this.mi_printGrid.Size = new System.Drawing.Size(205, 26);
			this.mi_printGrid.Text = "Print Grid";
			// 
			// mi_printVirtualGrid
			// 
			this.mi_printVirtualGrid.Name = "mi_printVirtualGrid";
			this.mi_printVirtualGrid.Size = new System.Drawing.Size(205, 26);
			this.mi_printVirtualGrid.Text = "Print Virtual Grid";
			this.mi_printVirtualGrid.Click += new System.EventHandler(this.mi_printVirtualGrid_Click);
			// 
			// mi_printPhysicalGrid
			// 
			this.mi_printPhysicalGrid.Name = "mi_printPhysicalGrid";
			this.mi_printPhysicalGrid.Size = new System.Drawing.Size(205, 26);
			this.mi_printPhysicalGrid.Text = "Print Physical Grid";
			this.mi_printPhysicalGrid.Click += new System.EventHandler(this.mi_printPhysicalGrid_Click);
			// 
			// mi_printSolutionGrid
			// 
			this.mi_printSolutionGrid.Name = "mi_printSolutionGrid";
			this.mi_printSolutionGrid.Size = new System.Drawing.Size(205, 26);
			this.mi_printSolutionGrid.Text = "Print Solution Grid";
			this.mi_printSolutionGrid.Click += new System.EventHandler(this.mi_printSolutionGrid_Click);
			// 
			// mi_forceCopyDebug
			// 
			this.mi_forceCopyDebug.Name = "mi_forceCopyDebug";
			this.mi_forceCopyDebug.Size = new System.Drawing.Size(205, 26);
			this.mi_forceCopyDebug.Text = "Force DVG <- grid";
			this.mi_forceCopyDebug.ToolTipText = "Force the copy of the virtual grid into the DataGridView display below";
			this.mi_forceCopyDebug.Click += new System.EventHandler(this.mi_forceCopyDebug_Click);
			// 
			// mi_solveSudokuDebug
			// 
			this.mi_solveSudokuDebug.Name = "mi_solveSudokuDebug";
			this.mi_solveSudokuDebug.Size = new System.Drawing.Size(205, 26);
			this.mi_solveSudokuDebug.Text = "Solve It";
			this.mi_solveSudokuDebug.ToolTipText = "Solve the soduku for you.\r\nWhy would you waste your time when a computer can do i" +
    "t?";
			this.mi_solveSudokuDebug.Click += new System.EventHandler(this.mi_solveSudokuDebug_Click);
			// 
			// mi_setDefaultGrid
			// 
			this.mi_setDefaultGrid.Name = "mi_setDefaultGrid";
			this.mi_setDefaultGrid.Size = new System.Drawing.Size(205, 26);
			this.mi_setDefaultGrid.Text = "Set Default Grid";
			this.mi_setDefaultGrid.Click += new System.EventHandler(this.mi_setDefaultGrid_Click);
			// 
			// mi_help
			// 
			this.mi_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_helpMe,
            this.toolStripSeparator3,
            this.mi_about});
			this.mi_help.Name = "mi_help";
			this.mi_help.Size = new System.Drawing.Size(53, 24);
			this.mi_help.Text = "&Help";
			// 
			// mi_helpMe
			// 
			this.mi_helpMe.Name = "mi_helpMe";
			this.mi_helpMe.Size = new System.Drawing.Size(257, 26);
			this.mi_helpMe.Text = "Help me to solve the grid!";
			this.mi_helpMe.Click += new System.EventHandler(this.mi_helpMe_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(254, 6);
			// 
			// mi_about
			// 
			this.mi_about.Name = "mi_about";
			this.mi_about.Size = new System.Drawing.Size(257, 26);
			this.mi_about.Text = "&About Genki";
			this.mi_about.Click += new System.EventHandler(this.mi_about_Click);
			// 
			// p_header
			// 
			this.p_header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.p_header.BackColor = System.Drawing.Color.DarkSalmon;
			this.p_header.Controls.Add(this.l_titleEnglish);
			this.p_header.Controls.Add(this.l_titleHirigana);
			this.p_header.Controls.Add(this.l_titleKanji);
			this.p_header.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_header.Location = new System.Drawing.Point(0, 28);
			this.p_header.Name = "p_header";
			this.p_header.Size = new System.Drawing.Size(747, 96);
			this.p_header.TabIndex = 1;
			// 
			// l_titleEnglish
			// 
			this.l_titleEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.l_titleEnglish.AutoSize = true;
			this.l_titleEnglish.Location = new System.Drawing.Point(355, 63);
			this.l_titleEnglish.Name = "l_titleEnglish";
			this.l_titleEnglish.Size = new System.Drawing.Size(45, 17);
			this.l_titleEnglish.TabIndex = 2;
			this.l_titleEnglish.Text = "Genki";
			this.tp_pronunciation.SetToolTip(this.l_titleEnglish, "元気");
			// 
			// l_titleHirigana
			// 
			this.l_titleHirigana.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.l_titleHirigana.AutoSize = true;
			this.l_titleHirigana.Location = new System.Drawing.Point(355, 14);
			this.l_titleHirigana.Name = "l_titleHirigana";
			this.l_titleHirigana.Size = new System.Drawing.Size(42, 17);
			this.l_titleHirigana.TabIndex = 1;
			this.l_titleHirigana.Text = "げんき";
			this.tp_pronunciation.SetToolTip(this.l_titleHirigana, "ge-n-ki");
			// 
			// l_titleKanji
			// 
			this.l_titleKanji.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.l_titleKanji.AutoSize = true;
			this.l_titleKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_titleKanji.ForeColor = System.Drawing.Color.DarkRed;
			this.l_titleKanji.Location = new System.Drawing.Point(342, 31);
			this.l_titleKanji.Name = "l_titleKanji";
			this.l_titleKanji.Size = new System.Drawing.Size(73, 32);
			this.l_titleKanji.TabIndex = 0;
			this.l_titleKanji.Text = "元気";
			this.tp_pronunciation.SetToolTip(this.l_titleKanji, "gen-ki");
			// 
			// status
			// 
			this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_status,
            this.progressBar});
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
			// progressBar
			// 
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(200, 19);
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
			this.dvg_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
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
			this.dvg_grid.Margin = new System.Windows.Forms.Padding(10);
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
			this.dvg_grid.Size = new System.Drawing.Size(577, 282);
			this.dvg_grid.TabIndex = 0;
			this.dvg_grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellValueChanged);
			this.dvg_grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellEnter);
			this.dvg_grid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellLeave);
			this.dvg_grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_grid_CellValueChanged);
			this.dvg_grid.SizeChanged += new System.EventHandler(this.dvg_grid_SizeChanged);
			// 
			// p_stopwatch
			// 
			this.p_stopwatch.Controls.Add(this.p_stopwatchControls);
			this.p_stopwatch.Controls.Add(this.l_stopwatch);
			this.p_stopwatch.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_stopwatch.Location = new System.Drawing.Point(0, 0);
			this.p_stopwatch.Name = "p_stopwatch";
			this.p_stopwatch.Size = new System.Drawing.Size(577, 70);
			this.p_stopwatch.TabIndex = 2;
			// 
			// p_stopwatchControls
			// 
			this.p_stopwatchControls.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.p_stopwatchControls.Controls.Add(this.tb_stopwatch);
			this.p_stopwatchControls.Controls.Add(this.b_stopwatchControl);
			this.p_stopwatchControls.Location = new System.Drawing.Point(201, 21);
			this.p_stopwatchControls.Name = "p_stopwatchControls";
			this.p_stopwatchControls.Size = new System.Drawing.Size(188, 36);
			this.p_stopwatchControls.TabIndex = 3;
			// 
			// tb_stopwatch
			// 
			this.tb_stopwatch.Location = new System.Drawing.Point(3, 3);
			this.tb_stopwatch.Name = "tb_stopwatch";
			this.tb_stopwatch.ReadOnly = true;
			this.tb_stopwatch.Size = new System.Drawing.Size(100, 22);
			this.tb_stopwatch.TabIndex = 1;
			// 
			// b_stopwatchControl
			// 
			this.b_stopwatchControl.Location = new System.Drawing.Point(109, 3);
			this.b_stopwatchControl.Name = "b_stopwatchControl";
			this.b_stopwatchControl.Size = new System.Drawing.Size(75, 22);
			this.b_stopwatchControl.TabIndex = 2;
			this.b_stopwatchControl.Text = "❚❚\r\n";
			this.b_stopwatchControl.UseVisualStyleBackColor = true;
			this.b_stopwatchControl.Click += new System.EventHandler(this.b_stopwatchControl_Click);
			// 
			// l_stopwatch
			// 
			this.l_stopwatch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.l_stopwatch.AutoSize = true;
			this.l_stopwatch.Location = new System.Drawing.Point(254, 3);
			this.l_stopwatch.Name = "l_stopwatch";
			this.l_stopwatch.Size = new System.Drawing.Size(73, 17);
			this.l_stopwatch.TabIndex = 0;
			this.l_stopwatch.Text = "Stopwatch";
			// 
			// p_control
			// 
			this.p_control.AutoScroll = true;
			this.p_control.Controls.Add(this.gb_cellOption);
			this.p_control.Dock = System.Windows.Forms.DockStyle.Right;
			this.p_control.Location = new System.Drawing.Point(577, 0);
			this.p_control.Name = "p_control";
			this.p_control.Size = new System.Drawing.Size(170, 352);
			this.p_control.TabIndex = 1;
			// 
			// gb_cellOption
			// 
			this.gb_cellOption.Controls.Add(this.p_draft);
			this.gb_cellOption.Controls.Add(this.p_valueControl);
			this.gb_cellOption.Controls.Add(this.p_controlButtons);
			this.gb_cellOption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_cellOption.Location = new System.Drawing.Point(0, 0);
			this.gb_cellOption.Name = "gb_cellOption";
			this.gb_cellOption.Size = new System.Drawing.Size(170, 352);
			this.gb_cellOption.TabIndex = 0;
			this.gb_cellOption.TabStop = false;
			this.gb_cellOption.Text = "Selected Cell";
			// 
			// p_draft
			// 
			this.p_draft.Controls.Add(this.l_cellDraft);
			this.p_draft.Controls.Add(this.lb_draft);
			this.p_draft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_draft.Location = new System.Drawing.Point(3, 76);
			this.p_draft.Name = "p_draft";
			this.p_draft.Size = new System.Drawing.Size(164, 216);
			this.p_draft.TabIndex = 9;
			// 
			// l_cellDraft
			// 
			this.l_cellDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_cellDraft.AutoSize = true;
			this.l_cellDraft.Location = new System.Drawing.Point(3, 0);
			this.l_cellDraft.Name = "l_cellDraft";
			this.l_cellDraft.Size = new System.Drawing.Size(39, 17);
			this.l_cellDraft.TabIndex = 2;
			this.l_cellDraft.Text = "Draft";
			// 
			// lb_draft
			// 
			this.lb_draft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lb_draft.FormattingEnabled = true;
			this.lb_draft.ItemHeight = 16;
			this.lb_draft.Location = new System.Drawing.Point(3, 20);
			this.lb_draft.Name = "lb_draft";
			this.lb_draft.Size = new System.Drawing.Size(158, 180);
			this.lb_draft.TabIndex = 3;
			this.lb_draft.SelectedIndexChanged += new System.EventHandler(this.lb_draft_SelectedIndexChanged);
			// 
			// p_valueControl
			// 
			this.p_valueControl.Controls.Add(this.l_cellValue);
			this.p_valueControl.Controls.Add(this.n_cellValue);
			this.p_valueControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_valueControl.Location = new System.Drawing.Point(3, 18);
			this.p_valueControl.Name = "p_valueControl";
			this.p_valueControl.Size = new System.Drawing.Size(164, 58);
			this.p_valueControl.TabIndex = 8;
			// 
			// l_cellValue
			// 
			this.l_cellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_cellValue.AutoSize = true;
			this.l_cellValue.Location = new System.Drawing.Point(3, 0);
			this.l_cellValue.Name = "l_cellValue";
			this.l_cellValue.Size = new System.Drawing.Size(44, 17);
			this.l_cellValue.TabIndex = 0;
			this.l_cellValue.Text = "Value";
			// 
			// n_cellValue
			// 
			this.n_cellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.n_cellValue.Location = new System.Drawing.Point(3, 20);
			this.n_cellValue.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.n_cellValue.Name = "n_cellValue";
			this.n_cellValue.Size = new System.Drawing.Size(158, 22);
			this.n_cellValue.TabIndex = 1;
			this.n_cellValue.ValueChanged += new System.EventHandler(this.n_cellValue_ValueChanged);
			// 
			// p_controlButtons
			// 
			this.p_controlButtons.Controls.Add(this.b_addDraft);
			this.p_controlButtons.Controls.Add(this.b_editDraft);
			this.p_controlButtons.Controls.Add(this.b_removeDraft);
			this.p_controlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p_controlButtons.Location = new System.Drawing.Point(3, 292);
			this.p_controlButtons.Name = "p_controlButtons";
			this.p_controlButtons.Size = new System.Drawing.Size(164, 57);
			this.p_controlButtons.TabIndex = 7;
			// 
			// b_addDraft
			// 
			this.b_addDraft.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.b_addDraft.Location = new System.Drawing.Point(3, 29);
			this.b_addDraft.Name = "b_addDraft";
			this.b_addDraft.Size = new System.Drawing.Size(74, 23);
			this.b_addDraft.TabIndex = 4;
			this.b_addDraft.Text = "Add";
			this.b_addDraft.UseVisualStyleBackColor = true;
			this.b_addDraft.Click += new System.EventHandler(this.b_addDraft_Click);
			// 
			// b_editDraft
			// 
			this.b_editDraft.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.b_editDraft.Location = new System.Drawing.Point(3, 3);
			this.b_editDraft.Name = "b_editDraft";
			this.b_editDraft.Size = new System.Drawing.Size(158, 23);
			this.b_editDraft.TabIndex = 6;
			this.b_editDraft.Text = "Edit";
			this.b_editDraft.UseVisualStyleBackColor = true;
			this.b_editDraft.Click += new System.EventHandler(this.b_editDraft_Click);
			// 
			// b_removeDraft
			// 
			this.b_removeDraft.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.b_removeDraft.Location = new System.Drawing.Point(83, 29);
			this.b_removeDraft.Name = "b_removeDraft";
			this.b_removeDraft.Size = new System.Drawing.Size(78, 23);
			this.b_removeDraft.TabIndex = 5;
			this.b_removeDraft.Text = "Remove";
			this.b_removeDraft.UseVisualStyleBackColor = true;
			this.b_removeDraft.Click += new System.EventHandler(this.b_removeDraft_Click);
			// 
			// tp_pronunciation
			// 
			this.tp_pronunciation.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.tp_pronunciation.ToolTipTitle = "Pronunciation";
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
			this.Icon = global::Genki.Properties.Resources.Icon64;
			this.MainMenuStrip = this.menu;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Frame";
			this.Text = "Genki";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frame_FormClosed);
			this.Shown += new System.EventHandler(this.Frame_Shown);
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
			this.p_stopwatchControls.ResumeLayout(false);
			this.p_stopwatchControls.PerformLayout();
			this.p_control.ResumeLayout(false);
			this.gb_cellOption.ResumeLayout(false);
			this.p_draft.ResumeLayout(false);
			this.p_draft.PerformLayout();
			this.p_valueControl.ResumeLayout(false);
			this.p_valueControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.n_cellValue)).EndInit();
			this.p_controlButtons.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem mi_file;
		private System.Windows.Forms.ToolStripMenuItem mi_newGame;
		private System.Windows.Forms.ToolStripMenuItem mi_save;
		private System.Windows.Forms.ToolStripMenuItem mi_open;
		private System.Windows.Forms.ToolStripMenuItem mi_exit;
		private System.Windows.Forms.ToolStripMenuItem mi_help;
		private System.Windows.Forms.ToolStripMenuItem mi_about;
		private System.Windows.Forms.Panel p_header;
		private System.Windows.Forms.Label l_titleKanji;
		private System.Windows.Forms.Label l_titleEnglish;
		private System.Windows.Forms.Label l_titleHirigana;
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
		private System.Windows.Forms.ToolStripMenuItem mi_debug;
		private System.Windows.Forms.ToolStripMenuItem mi_breakNow;
		private System.Windows.Forms.ToolStripMenuItem mi_printGrid;
		private System.Windows.Forms.ToolStripMenuItem mi_printVirtualGrid;
		private System.Windows.Forms.ToolStripMenuItem mi_printPhysicalGrid;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolTip tp_pronunciation;
		private System.Windows.Forms.ToolStripMenuItem mi_forceCopyDebug;
		private System.Windows.Forms.ToolStripMenuItem mi_solveSudokuDebug;
		private System.Windows.Forms.ToolStripProgressBar progressBar;
		private System.Windows.Forms.ToolStripMenuItem mi_window;
		private System.Windows.Forms.ToolStripMenuItem mi_displayHeader;
		private System.Windows.Forms.Panel p_controlButtons;
		private System.Windows.Forms.Panel p_draft;
		private System.Windows.Forms.Panel p_valueControl;
		private System.Windows.Forms.ToolStripMenuItem mi_helpMe;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.Panel p_stopwatchControls;
		private System.Windows.Forms.ToolStripMenuItem mi_printSolutionGrid;
		private System.Windows.Forms.ToolStripMenuItem mi_setDefaultGrid;
	}
}

