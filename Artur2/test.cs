using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

public class MainForm : Form
{
	public MainForm ()
	{
		// 
		// _tableLayoutPanel
		// 
		_tableLayoutPanel = new TableLayoutPanel ();
		_tableLayoutPanel.AutoScroll = true;
		_tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		_tableLayoutPanel.ColumnCount = 5;
		_tableLayoutPanel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.Dock = DockStyle.Fill;
		_tableLayoutPanel.RowCount = 5;
		_tableLayoutPanel.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		_tableLayoutPanel.TabIndex = 0;
		Controls.Add (_tableLayoutPanel);
		// 
		// Form2
		// 
		AutoScaleDimensions = new SizeF (6F, 13F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size (401, 368);
		Location = new Point (200, 100);
		StartPosition = FormStartPosition.Manual;
		Text = "bug #332892";
		Load += new EventHandler (MainForm_Load);
		ResumeLayout (false);
	}

	[STAThread]
	static void Main ()
	{
		Application.EnableVisualStyles ();
		Application.SetCompatibleTextRenderingDefault (false);
		Application.Run (new MainForm ());
	}

	void MainForm_Load (object sender, EventArgs e)
	{
		for (int i = 0; i <= 4; i++)
			AddButton (i);

		// InstructionsForm instructionsForm = new InstructionsForm ();
		// instructionsForm.Show ();
	}

	void AddButton (int row)
	{
		Button button = new Button ();
		button.Dock = DockStyle.Top;
		button.Height = 200;
		button.Text = row.ToString ();
		button.Click += new EventHandler (Button_Click);
		_tableLayoutPanel.Controls.Add (button, 2, row);
	}

	void Button_Click (object sender, EventArgs args)
	{
		((Control) sender).Visible = false;
	}

	private TableLayoutPanel _tableLayoutPanel;
}

public class InstructionsForm : Form
{
	public InstructionsForm ()
	{
		// 
		// _tabControl
		// 
		_tabControl = new TabControl ();
		_tabControl.Dock = DockStyle.Fill;
		Controls.Add (_tabControl);
		// 
		// _bugDescriptionText1
		// 
		_bugDescriptionText1 = new TextBox ();
		_bugDescriptionText1.Dock = DockStyle.Fill;
		_bugDescriptionText1.Multiline = true;
		_bugDescriptionText1.Text = string.Format (CultureInfo.InvariantCulture,
			"Expected result on start-up:{0}{0}" +
			"1. Five numbered buttons (0 - 4) are added to the " +
			"TableLayoutPanel.{0}{0}" +
			"2. The buttons are added in order.",
			Environment.NewLine);
		// 
		// _tabPage1
		// 
		_tabPage1 = new TabPage ();
		_tabPage1.Text = "#1";
		_tabPage1.Controls.Add (_bugDescriptionText1);
		_tabControl.Controls.Add (_tabPage1);
		// 
		// _bugDescriptionText2
		// 
		_bugDescriptionText2 = new TextBox ();
		_bugDescriptionText2.Dock = DockStyle.Fill;
		_bugDescriptionText2.Multiline = true;
		_bugDescriptionText2.Text = string.Format (CultureInfo.InvariantCulture,
			"Steps to execute:{0}{0}" +
			"1. Scroll down.{0}{0}" +
			"2. Click button 3.{0}{0}" +
			"3. Scroll up.{0}{0}" +
			"Expected result:{0}{0}" +
			"2. No gap is displayed between buttons 2 and 4.",
			Environment.NewLine);
		// 
		// _tabPage2
		// 
		_tabPage2 = new TabPage ();
		_tabPage2.Text = "#2";
		_tabPage2.Controls.Add (_bugDescriptionText2);
		_tabControl.Controls.Add (_tabPage2);
		// 
		// InstructionsForm
		// 
		ClientSize = new Size (300, 200);
		Location = new Point (650, 100);
		StartPosition = FormStartPosition.Manual;
		Text = "Instructions - bug #332892";
	}

	private TextBox _bugDescriptionText1;
	private TextBox _bugDescriptionText2;
	private TabControl _tabControl;
	private TabPage _tabPage1;
	private TabPage _tabPage2;
}
