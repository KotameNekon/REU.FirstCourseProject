namespace CourseProject
{
    partial class AccountingOfVolleyballEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingOfVolleyballEquipment));
            this.DataTableGrid = new System.Windows.Forms.DataGridView();
            this.Adding = new System.Windows.Forms.GroupBox();
            this.ButtonAdding = new System.Windows.Forms.Button();
            this.NumericAddingByNumber = new System.Windows.Forms.NumericUpDown();
            this.AddingByNumber = new System.Windows.Forms.RadioButton();
            this.AddingEnd = new System.Windows.Forms.RadioButton();
            this.AddingStart = new System.Windows.Forms.RadioButton();
            this.FirmName = new System.Windows.Forms.Label();
            this.ModelBallName = new System.Windows.Forms.Label();
            this.DeleteOrChange = new System.Windows.Forms.GroupBox();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxDelOrChangeByID = new System.Windows.Forms.TextBox();
            this.NumericDelOrChangeByNumber = new System.Windows.Forms.NumericUpDown();
            this.DelOrChangeByID = new System.Windows.Forms.RadioButton();
            this.DelOrChangeByNumber = new System.Windows.Forms.RadioButton();
            this.GeneralInformation = new System.Windows.Forms.GroupBox();
            this.YearGettingBall = new System.Windows.Forms.NumericUpDown();
            this.MonthGettingBall = new System.Windows.Forms.NumericUpDown();
            this.DayGettingBall = new System.Windows.Forms.NumericUpDown();
            this.TextBoxPriceOfBall = new System.Windows.Forms.TextBox();
            this.TextBoxModelBallName = new System.Windows.Forms.TextBox();
            this.TextBoxFirmName = new System.Windows.Forms.TextBox();
            this.DateGettingBall = new System.Windows.Forms.Label();
            this.PriceOfBall = new System.Windows.Forms.Label();
            this.ForButtonOne = new System.Windows.Forms.GroupBox();
            this.ButtonGraphic = new System.Windows.Forms.Button();
            this.ForButtonTwo = new System.Windows.Forms.GroupBox();
            this.ButtonCalculation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableGrid)).BeginInit();
            this.Adding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddingByNumber)).BeginInit();
            this.DeleteOrChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDelOrChangeByNumber)).BeginInit();
            this.GeneralInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearGettingBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthGettingBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayGettingBall)).BeginInit();
            this.ForButtonOne.SuspendLayout();
            this.ForButtonTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTableGrid
            // 
            this.DataTableGrid.AllowUserToAddRows = false;
            this.DataTableGrid.AllowUserToDeleteRows = false;
            this.DataTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableGrid.Location = new System.Drawing.Point(11, 180);
            this.DataTableGrid.Name = "DataTableGrid";
            this.DataTableGrid.ReadOnly = true;
            this.DataTableGrid.RowTemplate.Height = 25;
            this.DataTableGrid.Size = new System.Drawing.Size(846, 297);
            this.DataTableGrid.TabIndex = 0;
            // 
            // Adding
            // 
            this.Adding.Controls.Add(this.ButtonAdding);
            this.Adding.Controls.Add(this.NumericAddingByNumber);
            this.Adding.Controls.Add(this.AddingByNumber);
            this.Adding.Controls.Add(this.AddingEnd);
            this.Adding.Controls.Add(this.AddingStart);
            this.Adding.Location = new System.Drawing.Point(276, 12);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(203, 150);
            this.Adding.TabIndex = 1;
            this.Adding.TabStop = false;
            this.Adding.Text = "Добавление";
            // 
            // ButtonAdding
            // 
            this.ButtonAdding.Location = new System.Drawing.Point(6, 113);
            this.ButtonAdding.Name = "ButtonAdding";
            this.ButtonAdding.Size = new System.Drawing.Size(191, 31);
            this.ButtonAdding.TabIndex = 8;
            this.ButtonAdding.Text = "Добавить";
            this.ButtonAdding.UseVisualStyleBackColor = true;
            this.ButtonAdding.Click += new System.EventHandler(this.ButtonAdding_Click);
            // 
            // NumericAddingByNumber
            // 
            this.NumericAddingByNumber.Location = new System.Drawing.Point(151, 72);
            this.NumericAddingByNumber.Name = "NumericAddingByNumber";
            this.NumericAddingByNumber.Size = new System.Drawing.Size(45, 23);
            this.NumericAddingByNumber.TabIndex = 3;
            // 
            // AddingByNumber
            // 
            this.AddingByNumber.AutoSize = true;
            this.AddingByNumber.Location = new System.Drawing.Point(6, 72);
            this.AddingByNumber.Name = "AddingByNumber";
            this.AddingByNumber.Size = new System.Drawing.Size(149, 19);
            this.AddingByNumber.TabIndex = 2;
            this.AddingByNumber.TabStop = true;
            this.AddingByNumber.Text = "С заданным номером:";
            this.AddingByNumber.UseVisualStyleBackColor = true;
            // 
            // AddingEnd
            // 
            this.AddingEnd.AutoSize = true;
            this.AddingEnd.Location = new System.Drawing.Point(6, 47);
            this.AddingEnd.Name = "AddingEnd";
            this.AddingEnd.Size = new System.Drawing.Size(68, 19);
            this.AddingEnd.TabIndex = 1;
            this.AddingEnd.TabStop = true;
            this.AddingEnd.Text = "В конец";
            this.AddingEnd.UseVisualStyleBackColor = true;
            // 
            // AddingStart
            // 
            this.AddingStart.AutoSize = true;
            this.AddingStart.Location = new System.Drawing.Point(6, 22);
            this.AddingStart.Name = "AddingStart";
            this.AddingStart.Size = new System.Drawing.Size(75, 19);
            this.AddingStart.TabIndex = 0;
            this.AddingStart.TabStop = true;
            this.AddingStart.Text = "В начало";
            this.AddingStart.UseVisualStyleBackColor = true;
            // 
            // FirmName
            // 
            this.FirmName.AutoSize = true;
            this.FirmName.Location = new System.Drawing.Point(6, 23);
            this.FirmName.Name = "FirmName";
            this.FirmName.Size = new System.Drawing.Size(106, 15);
            this.FirmName.TabIndex = 4;
            this.FirmName.Text = "Название фирмы:";
            // 
            // ModelBallName
            // 
            this.ModelBallName.AutoSize = true;
            this.ModelBallName.Location = new System.Drawing.Point(6, 50);
            this.ModelBallName.Name = "ModelBallName";
            this.ModelBallName.Size = new System.Drawing.Size(138, 15);
            this.ModelBallName.TabIndex = 5;
            this.ModelBallName.Text = "Название модели мяча:";
            // 
            // DeleteOrChange
            // 
            this.DeleteOrChange.Controls.Add(this.ButtonChange);
            this.DeleteOrChange.Controls.Add(this.ButtonDelete);
            this.DeleteOrChange.Controls.Add(this.TextBoxDelOrChangeByID);
            this.DeleteOrChange.Controls.Add(this.NumericDelOrChangeByNumber);
            this.DeleteOrChange.Controls.Add(this.DelOrChangeByID);
            this.DeleteOrChange.Controls.Add(this.DelOrChangeByNumber);
            this.DeleteOrChange.Location = new System.Drawing.Point(485, 12);
            this.DeleteOrChange.Name = "DeleteOrChange";
            this.DeleteOrChange.Size = new System.Drawing.Size(187, 150);
            this.DeleteOrChange.TabIndex = 6;
            this.DeleteOrChange.TabStop = false;
            this.DeleteOrChange.Text = "Удаление/Изменение";
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(6, 111);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(175, 31);
            this.ButtonChange.TabIndex = 10;
            this.ButtonChange.Text = "Изменить";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(6, 74);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(175, 31);
            this.ButtonDelete.TabIndex = 9;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxDelOrChangeByID
            // 
            this.TextBoxDelOrChangeByID.Location = new System.Drawing.Point(60, 45);
            this.TextBoxDelOrChangeByID.Name = "TextBoxDelOrChangeByID";
            this.TextBoxDelOrChangeByID.Size = new System.Drawing.Size(118, 23);
            this.TextBoxDelOrChangeByID.TabIndex = 3;
            // 
            // NumericDelOrChangeByNumber
            // 
            this.NumericDelOrChangeByNumber.Location = new System.Drawing.Point(133, 20);
            this.NumericDelOrChangeByNumber.Name = "NumericDelOrChangeByNumber";
            this.NumericDelOrChangeByNumber.Size = new System.Drawing.Size(45, 23);
            this.NumericDelOrChangeByNumber.TabIndex = 2;
            // 
            // DelOrChangeByID
            // 
            this.DelOrChangeByID.AutoSize = true;
            this.DelOrChangeByID.Location = new System.Drawing.Point(6, 46);
            this.DelOrChangeByID.Name = "DelOrChangeByID";
            this.DelOrChangeByID.Size = new System.Drawing.Size(58, 19);
            this.DelOrChangeByID.TabIndex = 1;
            this.DelOrChangeByID.TabStop = true;
            this.DelOrChangeByID.Text = "По ID:";
            this.DelOrChangeByID.UseVisualStyleBackColor = true;
            // 
            // DelOrChangeByNumber
            // 
            this.DelOrChangeByNumber.AutoSize = true;
            this.DelOrChangeByNumber.Location = new System.Drawing.Point(6, 21);
            this.DelOrChangeByNumber.Name = "DelOrChangeByNumber";
            this.DelOrChangeByNumber.Size = new System.Drawing.Size(130, 19);
            this.DelOrChangeByNumber.TabIndex = 0;
            this.DelOrChangeByNumber.TabStop = true;
            this.DelOrChangeByNumber.Text = "По номеру записи:";
            this.DelOrChangeByNumber.UseVisualStyleBackColor = true;
            // 
            // GeneralInformation
            // 
            this.GeneralInformation.Controls.Add(this.YearGettingBall);
            this.GeneralInformation.Controls.Add(this.MonthGettingBall);
            this.GeneralInformation.Controls.Add(this.DayGettingBall);
            this.GeneralInformation.Controls.Add(this.TextBoxPriceOfBall);
            this.GeneralInformation.Controls.Add(this.TextBoxModelBallName);
            this.GeneralInformation.Controls.Add(this.TextBoxFirmName);
            this.GeneralInformation.Controls.Add(this.DateGettingBall);
            this.GeneralInformation.Controls.Add(this.PriceOfBall);
            this.GeneralInformation.Controls.Add(this.FirmName);
            this.GeneralInformation.Controls.Add(this.ModelBallName);
            this.GeneralInformation.Location = new System.Drawing.Point(12, 12);
            this.GeneralInformation.Name = "GeneralInformation";
            this.GeneralInformation.Size = new System.Drawing.Size(258, 150);
            this.GeneralInformation.TabIndex = 7;
            this.GeneralInformation.TabStop = false;
            this.GeneralInformation.Text = "Общие данные";
            // 
            // YearGettingBall
            // 
            this.YearGettingBall.Location = new System.Drawing.Point(200, 121);
            this.YearGettingBall.Name = "YearGettingBall";
            this.YearGettingBall.Size = new System.Drawing.Size(50, 23);
            this.YearGettingBall.TabIndex = 13;
            // 
            // MonthGettingBall
            // 
            this.MonthGettingBall.Location = new System.Drawing.Point(144, 121);
            this.MonthGettingBall.Name = "MonthGettingBall";
            this.MonthGettingBall.Size = new System.Drawing.Size(50, 23);
            this.MonthGettingBall.TabIndex = 12;
            // 
            // DayGettingBall
            // 
            this.DayGettingBall.Location = new System.Drawing.Point(88, 121);
            this.DayGettingBall.Name = "DayGettingBall";
            this.DayGettingBall.Size = new System.Drawing.Size(50, 23);
            this.DayGettingBall.TabIndex = 11;
            // 
            // TextBoxPriceOfBall
            // 
            this.TextBoxPriceOfBall.Location = new System.Drawing.Point(164, 73);
            this.TextBoxPriceOfBall.Name = "TextBoxPriceOfBall";
            this.TextBoxPriceOfBall.Size = new System.Drawing.Size(86, 23);
            this.TextBoxPriceOfBall.TabIndex = 10;
            // 
            // TextBoxModelBallName
            // 
            this.TextBoxModelBallName.Location = new System.Drawing.Point(150, 46);
            this.TextBoxModelBallName.Name = "TextBoxModelBallName";
            this.TextBoxModelBallName.Size = new System.Drawing.Size(100, 23);
            this.TextBoxModelBallName.TabIndex = 9;
            // 
            // TextBoxFirmName
            // 
            this.TextBoxFirmName.Location = new System.Drawing.Point(118, 20);
            this.TextBoxFirmName.Name = "TextBoxFirmName";
            this.TextBoxFirmName.Size = new System.Drawing.Size(132, 23);
            this.TextBoxFirmName.TabIndex = 8;
            // 
            // DateGettingBall
            // 
            this.DateGettingBall.AutoSize = true;
            this.DateGettingBall.Location = new System.Drawing.Point(6, 103);
            this.DateGettingBall.Name = "DateGettingBall";
            this.DateGettingBall.Size = new System.Drawing.Size(219, 15);
            this.DateGettingBall.TabIndex = 7;
            this.DateGettingBall.Text = "Дата приобретения мяча (ДД/ММ/ГГ):";
            // 
            // PriceOfBall
            // 
            this.PriceOfBall.AutoSize = true;
            this.PriceOfBall.Location = new System.Drawing.Point(6, 76);
            this.PriceOfBall.Name = "PriceOfBall";
            this.PriceOfBall.Size = new System.Drawing.Size(152, 15);
            this.PriceOfBall.TabIndex = 6;
            this.PriceOfBall.Text = "Цена приобритения мяча:";
            // 
            // ForButtonOne
            // 
            this.ForButtonOne.Controls.Add(this.ButtonGraphic);
            this.ForButtonOne.Location = new System.Drawing.Point(678, 12);
            this.ForButtonOne.Name = "ForButtonOne";
            this.ForButtonOne.Size = new System.Drawing.Size(180, 65);
            this.ForButtonOne.TabIndex = 8;
            this.ForButtonOne.TabStop = false;
            this.ForButtonOne.Text = "График соотношения кол-ва фирм";
            // 
            // ButtonGraphic
            // 
            this.ButtonGraphic.Location = new System.Drawing.Point(6, 33);
            this.ButtonGraphic.Name = "ButtonGraphic";
            this.ButtonGraphic.Size = new System.Drawing.Size(168, 23);
            this.ButtonGraphic.TabIndex = 10;
            this.ButtonGraphic.Text = "Вывод графика";
            this.ButtonGraphic.UseVisualStyleBackColor = true;
            this.ButtonGraphic.Click += new System.EventHandler(this.ButtonGraphic_Click);
            // 
            // ForButtonTwo
            // 
            this.ForButtonTwo.Controls.Add(this.ButtonCalculation);
            this.ForButtonTwo.Location = new System.Drawing.Point(678, 83);
            this.ForButtonTwo.Name = "ForButtonTwo";
            this.ForButtonTwo.Size = new System.Drawing.Size(180, 79);
            this.ForButtonTwo.TabIndex = 9;
            this.ForButtonTwo.TabStop = false;
            this.ForButtonTwo.Text = "Подсчёт суммарной стоимости мячей каждой фирмы";
            // 
            // ButtonCalculation
            // 
            this.ButtonCalculation.Location = new System.Drawing.Point(6, 50);
            this.ButtonCalculation.Name = "ButtonCalculation";
            this.ButtonCalculation.Size = new System.Drawing.Size(168, 23);
            this.ButtonCalculation.TabIndex = 0;
            this.ButtonCalculation.Text = "Вывод  расчётов";
            this.ButtonCalculation.UseVisualStyleBackColor = true;
            this.ButtonCalculation.Click += new System.EventHandler(this.ButtonCalculation_Click);
            // 
            // AccountingOfVolleyballEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 486);
            this.Controls.Add(this.ForButtonTwo);
            this.Controls.Add(this.ForButtonOne);
            this.Controls.Add(this.GeneralInformation);
            this.Controls.Add(this.DeleteOrChange);
            this.Controls.Add(this.Adding);
            this.Controls.Add(this.DataTableGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountingOfVolleyballEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Of Volleyball Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.DataTableGrid)).EndInit();
            this.Adding.ResumeLayout(false);
            this.Adding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddingByNumber)).EndInit();
            this.DeleteOrChange.ResumeLayout(false);
            this.DeleteOrChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDelOrChangeByNumber)).EndInit();
            this.GeneralInformation.ResumeLayout(false);
            this.GeneralInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearGettingBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthGettingBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayGettingBall)).EndInit();
            this.ForButtonOne.ResumeLayout(false);
            this.ForButtonTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataTableGrid;
        private GroupBox Adding;
        private NumericUpDown NumericAddingByNumber;
        private RadioButton AddingByNumber;
        private RadioButton AddingEnd;
        private RadioButton AddingStart;
        private Label FirmName;
        private Label ModelBallName;
        private GroupBox DeleteOrChange;
        private TextBox TextBoxDelOrChangeByID;
        private NumericUpDown NumericDelOrChangeByNumber;
        private RadioButton DelOrChangeByID;
        private RadioButton DelOrChangeByNumber;
        private GroupBox GeneralInformation;
        private Label DateGettingBall;
        private Label PriceOfBall;
        private NumericUpDown YearGettingBall;
        private NumericUpDown MonthGettingBall;
        private NumericUpDown DayGettingBall;
        private TextBox TextBoxPriceOfBall;
        private TextBox TextBoxModelBallName;
        private TextBox TextBoxFirmName;
        private Button ButtonAdding;
        private Button ButtonChange;
        private Button ButtonDelete;
        private GroupBox ForButtonOne;
        private GroupBox ForButtonTwo;
        private Button ButtonGraphic;
        private Button ButtonCalculation;
    }
}