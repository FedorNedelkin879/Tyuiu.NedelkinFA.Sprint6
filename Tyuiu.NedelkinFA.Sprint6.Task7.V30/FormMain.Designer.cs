using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.NedelkinFA.Sprint6.Task7.V30;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        groupBox1 = new GroupBox();
        label1 = new Label();
        groupBoxOutPutData = new GroupBox();
        inputGrid = new DataGridView();
        first = new DataGridViewTextBoxColumn();
        second = new DataGridViewTextBoxColumn();
        Column2 = new DataGridViewTextBoxColumn();
        Column3 = new DataGridViewTextBoxColumn();
        Column4 = new DataGridViewTextBoxColumn();
        groupBox3 = new GroupBox();
        resultBox = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        buttonHelp = new Button();
        buttonRun = new Button();
        buttonOpenFile = new Button();
        openFileDialogTask = new OpenFileDialog();
        toolTip = new ToolTip(components);
        groupBox1.SuspendLayout();
        groupBoxOutPutData.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)inputGrid).BeginInit();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)resultBox).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(11, 87);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1053, 74);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F);
        label1.Location = new Point(6, 17);
        label1.Name = "label1";
        label1.Size = new Size(960, 57);
        label1.TabIndex = 0;
        label1.Text = resources.GetString("label1.Text");
        // 
        // groupBoxOutPutData
        // 
        groupBoxOutPutData.Controls.Add(inputGrid);
        groupBoxOutPutData.Location = new Point(11, 161);
        groupBoxOutPutData.Name = "groupBoxOutPutData";
        groupBoxOutPutData.Size = new Size(452, 420);
        groupBoxOutPutData.TabIndex = 13;
        groupBoxOutPutData.TabStop = false;
        groupBoxOutPutData.Text = "Ввод";
        // 
        // inputGrid
        // 
        inputGrid.AllowUserToAddRows = false;
        inputGrid.AllowUserToDeleteRows = false;
        inputGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        inputGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        inputGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
        inputGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        inputGrid.ColumnHeadersVisible = false;
        inputGrid.Columns.AddRange(new DataGridViewColumn[] { first, second, Column2, Column3, Column4 });
        inputGrid.Location = new Point(6, 49);
        inputGrid.Name = "inputGrid";
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.Padding = new Padding(10);
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        inputGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
        inputGrid.RowHeadersVisible = false;
        inputGrid.RowHeadersWidth = 40;
        inputGrid.Size = new Size(440, 365);
        inputGrid.TabIndex = 17;
        // 
        // first
        // 
        first.HeaderText = "Column2";
        first.Name = "first";
        first.Width = 5;
        // 
        // second
        // 
        second.HeaderText = "Column2";
        second.Name = "second";
        second.Width = 5;
        // 
        // Column2
        // 
        Column2.HeaderText = "Column2";
        Column2.Name = "Column2";
        Column2.Width = 5;
        // 
        // Column3
        // 
        Column3.HeaderText = "Column3";
        Column3.Name = "Column3";
        Column3.Width = 5;
        // 
        // Column4
        // 
        Column4.HeaderText = "Column4";
        Column4.Name = "Column4";
        Column4.Width = 5;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(resultBox);
        groupBox3.Location = new Point(469, 161);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(595, 420);
        groupBox3.TabIndex = 14;
        groupBox3.TabStop = false;
        groupBox3.Text = "Вывод";
        // 
        // resultBox
        // 
        resultBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        resultBox.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        resultBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resultBox.ColumnHeadersVisible = false;
        resultBox.Columns.AddRange(new DataGridViewColumn[] { Column1 });
        resultBox.Location = new Point(6, 49);
        resultBox.Name = "resultBox";
        resultBox.RowHeadersVisible = false;
        resultBox.Size = new Size(583, 365);
        resultBox.TabIndex = 16;
        // 
        // Column1
        // 
        Column1.HeaderText = "F(X)";
        Column1.Name = "Column1";
        Column1.Width = 21;
        // 
        // buttonHelp
        // 
        buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
        buttonHelp.Location = new Point(953, 12);
        buttonHelp.Name = "buttonHelp";
        buttonHelp.Size = new Size(111, 69);
        buttonHelp.TabIndex = 17;
        toolTip.SetToolTip(buttonHelp, "Информация о создателе приложения");
        buttonHelp.UseVisualStyleBackColor = true;
        buttonHelp.Click += buttonHelp_Click;
        // 
        // buttonRun
        // 
        buttonRun.Enabled = false;
        buttonRun.Image = (Image)resources.GetObject("buttonRun.Image");
        buttonRun.Location = new Point(122, 12);
        buttonRun.Name = "buttonRun";
        buttonRun.Size = new Size(111, 69);
        buttonRun.TabIndex = 16;
        toolTip.SetToolTip(buttonRun, "Запустить программу");
        buttonRun.UseVisualStyleBackColor = true;
        buttonRun.Click += buttonRun_Click;
        // 
        // buttonOpenFile
        // 
        buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
        buttonOpenFile.Location = new Point(11, 12);
        buttonOpenFile.Name = "buttonOpenFile";
        buttonOpenFile.Size = new Size(105, 69);
        buttonOpenFile.TabIndex = 15;
        toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
        buttonOpenFile.UseVisualStyleBackColor = true;
        buttonOpenFile.Click += buttonOpenFile_Click;
        // 
        // toolTip
        // 
        toolTip.ToolTipIcon = ToolTipIcon.Info;
        toolTip.ToolTipTitle = "Подсказка";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1076, 596);
        Controls.Add(groupBox1);
        Controls.Add(groupBoxOutPutData);
        Controls.Add(groupBox3);
        Controls.Add(buttonHelp);
        Controls.Add(buttonRun);
        Controls.Add(buttonOpenFile);
        Name = "FormMain";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBoxOutPutData.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)inputGrid).EndInit();
        groupBox3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)resultBox).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label1;
    private GroupBox groupBoxOutPutData;
    private GroupBox groupBox3;
    private Button buttonHelp;
    private ToolTip toolTip;
    private Button buttonRun;
    private Button buttonOpenFile;
    private OpenFileDialog openFileDialogTask;
    private DataGridView resultBox;
    private DataGridViewTextBoxColumn Column1;
    private DataGridView inputGrid;
    private DataGridViewTextBoxColumn first;
    private DataGridViewTextBoxColumn second;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
}