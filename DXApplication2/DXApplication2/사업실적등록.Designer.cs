namespace DXApplication2
{
    partial class 사업실적등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(사업실적등록));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo11 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo12 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo13 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo14 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings2 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions2 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings2);
            this.시설label = new DevExpress.XtraEditors.LabelControl();
            this.시행일label = new DevExpress.XtraEditors.LabelControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.tet = new DevExpress.XtraBars.Navigation.TabPane();
            this.사업실적등록_수정 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.수정시행일label = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.사업실적등록_등록 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.금액label = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.건label = new DevExpress.XtraEditors.LabelControl();
            this.단위프로그램text = new DevExpress.XtraEditors.ComboBoxEdit();
            this.단위label = new DevExpress.XtraEditors.LabelControl();
            this.등록시행일text = new DevExpress.XtraEditors.DateEdit();
            this.시설text = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.excelDataSource2 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.tet)).BeginInit();
            this.tet.SuspendLayout();
            this.사업실적등록_수정.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.사업실적등록_등록.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.단위프로그램text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.등록시행일text.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.등록시행일text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.시설text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // 시설label
            // 
            this.시설label.Location = new System.Drawing.Point(8, 17);
            this.시설label.Name = "시설label";
            this.시설label.Size = new System.Drawing.Size(24, 14);
            this.시설label.TabIndex = 0;
            this.시설label.Text = "시 설";
            // 
            // 시행일label
            // 
            this.시행일label.Location = new System.Drawing.Point(181, 18);
            this.시행일label.Name = "시행일label";
            this.시행일label.Size = new System.Drawing.Size(30, 14);
            this.시행일label.TabIndex = 4;
            this.시행일label.Text = "시행일";
            this.시행일label.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "D:\\proyks\\작업\\D 프로그램\\testExcelData\\testData_사업실적등록.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "Column1";
            fieldInfo1.Type = typeof(double);
            fieldInfo2.Name = "Column2";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "Column3";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "Column4";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "Column5";
            fieldInfo5.Type = typeof(double);
            fieldInfo6.Name = "Column6";
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "Column7";
            fieldInfo7.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Sheet1";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            excelSourceOptions1.UseFirstRowAsHeader = false;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // tet
            // 
            this.tet.Controls.Add(this.사업실적등록_수정);
            this.tet.Controls.Add(this.사업실적등록_등록);
            this.tet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tet.Location = new System.Drawing.Point(0, 0);
            this.tet.Name = "tet";
            this.tet.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tet.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.사업실적등록_등록,
            this.사업실적등록_수정});
            this.tet.RegularSize = new System.Drawing.Size(528, 336);
            this.tet.SelectedPage = this.사업실적등록_등록;
            this.tet.Size = new System.Drawing.Size(528, 336);
            this.tet.TabIndex = 6;
            this.tet.Text = "tabPane1";
            // 
            // 사업실적등록_수정
            // 
            this.사업실적등록_수정.Caption = "수정";
            this.사업실적등록_수정.Controls.Add(this.수정시행일label);
            this.사업실적등록_수정.Controls.Add(this.dateEdit1);
            this.사업실적등록_수정.Image = ((System.Drawing.Image)(resources.GetObject("사업실적등록_수정.Image")));
            this.사업실적등록_수정.Name = "사업실적등록_수정";
            this.사업실적등록_수정.Size = new System.Drawing.Size(699, 448);
            // 
            // 수정시행일label
            // 
            this.수정시행일label.Location = new System.Drawing.Point(13, 17);
            this.수정시행일label.Name = "수정시행일label";
            this.수정시행일label.Size = new System.Drawing.Size(30, 14);
            this.수정시행일label.TabIndex = 10;
            this.수정시행일label.Text = "시행일";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(49, 15);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEdit1.Properties.DisplayFormat.FormatString = "";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.EditFormat.FormatString = "";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(91, 20);
            this.dateEdit1.TabIndex = 11;
            // 
            // 사업실적등록_등록
            // 
            this.사업실적등록_등록.Caption = "등록";
            this.사업실적등록_등록.Controls.Add(this.금액label);
            this.사업실적등록_등록.Controls.Add(this.textEdit2);
            this.사업실적등록_등록.Controls.Add(this.건label);
            this.사업실적등록_등록.Controls.Add(this.단위프로그램text);
            this.사업실적등록_등록.Controls.Add(this.단위label);
            this.사업실적등록_등록.Controls.Add(this.시행일label);
            this.사업실적등록_등록.Controls.Add(this.시설label);
            this.사업실적등록_등록.Controls.Add(this.등록시행일text);
            this.사업실적등록_등록.Controls.Add(this.시설text);
            this.사업실적등록_등록.Controls.Add(this.textEdit1);
            this.사업실적등록_등록.Image = ((System.Drawing.Image)(resources.GetObject("사업실적등록_등록.Image")));
            this.사업실적등록_등록.Name = "사업실적등록_등록";
            this.사업실적등록_등록.Size = new System.Drawing.Size(510, 272);
            // 
            // 금액label
            // 
            this.금액label.Location = new System.Drawing.Point(181, 79);
            this.금액label.Name = "금액label";
            this.금액label.Size = new System.Drawing.Size(20, 14);
            this.금액label.TabIndex = 15;
            this.금액label.Text = "금액";
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "\\0";
            this.textEdit2.Location = new System.Drawing.Point(217, 76);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Mask.EditMask = "c0";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Size = new System.Drawing.Size(91, 20);
            this.textEdit2.TabIndex = 16;
            // 
            // 건label
            // 
            this.건label.Location = new System.Drawing.Point(22, 79);
            this.건label.Name = "건label";
            this.건label.Size = new System.Drawing.Size(10, 14);
            this.건label.TabIndex = 13;
            this.건label.Text = "건";
            // 
            // 단위프로그램text
            // 
            this.단위프로그램text.EditValue = "";
            this.단위프로그램text.Location = new System.Drawing.Point(78, 46);
            this.단위프로그램text.Name = "단위프로그램text";
            this.단위프로그램text.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.단위프로그램text.Properties.DropDownRows = 13;
            this.단위프로그램text.Properties.Items.AddRange(new object[] {
            "좋은프로그램1",
            "좋은프로그램2",
            "좋은프로그램3",
            "좋은프로그램4",
            "좋은프로그램5",
            "좋은프로그램6",
            "가정방문1",
            "가정방문2",
            "가정방문3",
            "가정방문4",
            "후원프로그램1",
            "후원프로그램2",
            "후원프로그램3"});
            this.단위프로그램text.Size = new System.Drawing.Size(230, 20);
            this.단위프로그램text.TabIndex = 12;
            // 
            // 단위label
            // 
            this.단위label.Location = new System.Drawing.Point(8, 49);
            this.단위label.Name = "단위label";
            this.단위label.Size = new System.Drawing.Size(64, 14);
            this.단위label.TabIndex = 8;
            this.단위label.Text = "단위 프로그램";
            // 
            // 등록시행일text
            // 
            this.등록시행일text.EditValue = null;
            this.등록시행일text.Location = new System.Drawing.Point(217, 16);
            this.등록시행일text.Name = "등록시행일text";
            this.등록시행일text.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.등록시행일text.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.등록시행일text.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.등록시행일text.Properties.DisplayFormat.FormatString = "";
            this.등록시행일text.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.등록시행일text.Properties.EditFormat.FormatString = "";
            this.등록시행일text.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.등록시행일text.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.등록시행일text.Size = new System.Drawing.Size(91, 20);
            this.등록시행일text.TabIndex = 9;
            // 
            // 시설text
            // 
            this.시설text.EditValue = "";
            this.시설text.Location = new System.Drawing.Point(38, 15);
            this.시설text.Name = "시설text";
            this.시설text.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.시설text.Properties.DropDownRows = 6;
            this.시설text.Properties.Items.AddRange(new object[] {
            "휴먼기관",
            "사람복지",
            "복지사람",
            "오복지",
            "SocialWelfare",
            "아름다운사람들",
            "의로운재단"});
            this.시설text.Size = new System.Drawing.Size(136, 20);
            this.시설text.TabIndex = 11;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "0";
            this.textEdit1.Location = new System.Drawing.Point(38, 76);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "n0";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Size = new System.Drawing.Size(42, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // excelDataSource2
            // 
            this.excelDataSource2.FileName = "D:\\proyks\\작업\\D 프로그램\\testExcelData\\testData_사업실적등록.xlsx";
            this.excelDataSource2.Name = "excelDataSource2";
            this.excelDataSource2.ResultSchemaSerializable = "PFZpZXc+PEZpZWxkIE5hbWU9IkNvbHVtbjQiIFR5cGU9IlN0cmluZyIgLz48L1ZpZXc+";
            fieldInfo8.Name = "Column1";
            fieldInfo8.Selected = false;
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "Column2";
            fieldInfo9.Selected = false;
            fieldInfo9.Type = typeof(string);
            fieldInfo10.Name = "Column3";
            fieldInfo10.Selected = false;
            fieldInfo10.Type = typeof(string);
            fieldInfo11.Name = "Column4";
            fieldInfo11.Type = typeof(string);
            fieldInfo12.Name = "Column5";
            fieldInfo12.Selected = false;
            fieldInfo12.Type = typeof(double);
            fieldInfo13.Name = "Column6";
            fieldInfo13.Selected = false;
            fieldInfo13.Type = typeof(double);
            fieldInfo14.Name = "Column7";
            fieldInfo14.Selected = false;
            fieldInfo14.Type = typeof(double);
            this.excelDataSource2.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo8,
            fieldInfo9,
            fieldInfo10,
            fieldInfo11,
            fieldInfo12,
            fieldInfo13,
            fieldInfo14});
            excelWorksheetSettings2.CellRange = null;
            excelWorksheetSettings2.WorksheetName = "Sheet1";
            excelSourceOptions2.ImportSettings = excelWorksheetSettings2;
            excelSourceOptions2.UseFirstRowAsHeader = false;
            this.excelDataSource2.SourceOptions = excelSourceOptions2;
            // 
            // 사업실적등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 336);
            this.Controls.Add(this.tet);
            this.Name = "사업실적등록";
            this.Text = "사업실적등록";
            ((System.ComponentModel.ISupportInitialize)(this.tet)).EndInit();
            this.tet.ResumeLayout(false);
            this.사업실적등록_수정.ResumeLayout(false);
            this.사업실적등록_수정.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.사업실적등록_등록.ResumeLayout(false);
            this.사업실적등록_등록.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.단위프로그램text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.등록시행일text.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.등록시행일text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.시설text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl 시설label;
        private DevExpress.XtraEditors.LabelControl 시행일label;
        private DevExpress.XtraBars.Navigation.TabPane tet;
        private DevExpress.XtraBars.Navigation.TabNavigationPage 사업실적등록_수정;
        private DevExpress.XtraBars.Navigation.TabNavigationPage 사업실적등록_등록;
        private DevExpress.XtraEditors.LabelControl 단위label;
        private DevExpress.XtraEditors.DateEdit 등록시행일text;
        private DevExpress.XtraEditors.ComboBoxEdit 시설text;
        private DevExpress.XtraEditors.ComboBoxEdit 단위프로그램text;
        private DevExpress.XtraEditors.LabelControl 금액label;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl 건label;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl 수정시행일label;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource2;
    }
}