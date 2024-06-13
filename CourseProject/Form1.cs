using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProject
{
    public partial class AccountingOfVolleyballEquipment : Form
    {
        DataTable databaseTable = new DataTable();

        public AccountingOfVolleyballEquipment()
        {
            InitializeComponent();

            CheckIfDataExists();
            //InitializeDatabaseTable();
        }

        private void InitializeDatabaseTable()
        {
            databaseTable.Columns.Add("ID", typeof(int));
            databaseTable.Columns.Add("BallFirm", typeof(string));
            databaseTable.Columns.Add("BallModel", typeof(string));
            databaseTable.Columns.Add("BallPrice", typeof(double));
            databaseTable.Columns.Add("DayGet", typeof(int));
            databaseTable.Columns.Add("MonthGet", typeof(int));
            databaseTable.Columns.Add("YearGet", typeof(int));
        }

        private void CheckIfDataExists()
        {
            if(!File.Exists("volleyballDB.db"))
            {
                SQLiteConnection.CreateFile("volleyballDB.db");

                using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
                {
                    string commandstring = "CREATE TABLE volleyballs (ID INTEGER PRIMARY KEY, firm_name TEXT, model_name TEXT, price REAL, day INTEGER, month INTEGER, year INTEGER)";
                    using (SQLiteCommand cmd = new SQLiteCommand(commandstring, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                LoadContactDataGridView();
            }
        }

        private void LoadContactDataGridView()
        {
            DataTableGrid.DataSource = GetDataFromDatabase();
        }

        private DataTable GetDataFromDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
            {
                string commandstring = "SELECT * FROM volleyballs";
                using (SQLiteCommand cmd = new SQLiteCommand(commandstring, conn))
                {
                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    databaseTable.Load(reader);
                }
            }
            return databaseTable;
        }

        // ДОБАВЛЕНИЕ
        private void ButtonAdding_Click(object sender, EventArgs e)
        {
            string ballFirm = TextBoxFirmName.Text;
            string ballModel = TextBoxModelBallName.Text;
            double ballPrice;
            int getDay = (int)DayGettingBall.Value;
            int getMonth = (int)MonthGettingBall.Value;
            int getYear = (int)YearGettingBall.Value;

            if (!double.TryParse(TextBoxPriceOfBall.Text, out ballPrice))
            {
                MessageBox.Show("Недопустимое значение стоимости");
                return;
            }

            if (AddingStart.Checked)
            {
                AddRecordToBeginning(ballFirm, ballModel, ballPrice, getDay, getMonth, getYear);
            }

            else if (AddingEnd.Checked)
            {
                AddRecordToEnd(ballFirm, ballModel, ballPrice, getDay, getMonth, getYear);
            }

            else if (AddingByNumber.Checked)
            {
                int recordNumberToAdd = (int)NumericAddingByNumber.Value;
                AddRecordAtPosition(ballFirm, ballModel, ballPrice, getDay, getMonth, getYear, recordNumberToAdd);
            }

            else
            {
                MessageBox.Show("Вы не выбрали способ добавления записи");
            }

            LoadContactDataGridView();
        }

        private void AddRecordToBeginning(string ballFirm, string ballModel, double ballPrice, int getDay, int getMonth, int getYear)
        {
            DataRow newRow = databaseTable.NewRow();

            newRow[1] = ballFirm;
            newRow[2] = ballModel;
            newRow[3] = ballPrice;

            if (getDay > 0 && getDay < 32)
            {
                newRow[4] = getDay;
            }
            else
            {
                MessageBox.Show("Такого дня не существует");
                return;
            }

            if (getMonth > 0 && getMonth < 13)
            {
                newRow[5] = getMonth;
            }
            else
            {
                MessageBox.Show("Такого месяца не существует");
                return;
            }

            if (getYear > 9 && getYear < 100)
            {
                newRow[6] = getYear;
            }
            else
            {
                MessageBox.Show("Некорректный ввод года");
                return;
            }

            databaseTable.Rows.InsertAt(newRow, 0);
            InsertRecordIntoDatabase(ballFirm, ballModel, ballPrice, getDay, getMonth, getYear);
        }

        private void AddRecordToEnd(string ballFirm, string ballModel, double ballPrice, int getDay, int getMonth, int getYear)
        {
            DataRow newRow = databaseTable.NewRow();

            newRow[1] = ballFirm;
            newRow[2] = ballModel;
            newRow[3] = ballPrice;

            if (getDay > 0 && getDay < 32)
            {
                newRow[4] = getDay;
            }
            else
            {
                MessageBox.Show("Такого дня не существует");
                return;
            }

            if (getMonth > 0 && getMonth < 13)
            {
                newRow[5] = getMonth;
            }
            else
            {
                MessageBox.Show("Такого месяца не существует");
                return;
            }

            if (getYear > 9 && getYear < 100)
            {
                newRow[6] = getYear;
            }
            else
            {
                MessageBox.Show("Некорректный ввод года");
                return;
            }

            databaseTable.Rows.Add(newRow);
            InsertRecordIntoDatabase(ballFirm, ballModel, ballPrice, getDay, getMonth, getYear);
        }

        private void AddRecordAtPosition(string ballFirm, string ballModel, double ballPrice, int getDay, int getMonth, int getYear, int position)
        {
            if (position > 0 && position <= databaseTable.Rows.Count + 1)
            {
                DataRow newRow = databaseTable.NewRow();

                newRow[1] = ballFirm;
                newRow[2] = ballModel;
                newRow[3] = ballPrice;

                if (getDay > 0 && getDay < 32)
                {
                    newRow[4] = getDay;
                }
                else
                {
                    MessageBox.Show("Такого дня не существует");
                    return;
                }

                if (getMonth > 0 && getMonth < 13)
                {
                    newRow[5] = getMonth;
                }
                else
                {
                    MessageBox.Show("Такого месяца не существует");
                    return;
                }

                if (getYear > 9 && getYear < 100)
                {
                    newRow[6] = getYear;
                }
                else
                {
                    MessageBox.Show("Некорректный ввод года");
                    return;
                }

                databaseTable.Rows.InsertAt(newRow, position - 1);
                InsertRecordIntoDatabase(ballFirm, ballModel, ballPrice, getDay, getMonth, getYear);
            }

            else
            {
                MessageBox.Show("Номер записи неверен");
            }
        }

        private void InsertRecordIntoDatabase(string ballFirm, string ballModel, double ballPrice, int getDay, int getMonth, int getYear)
        {
            using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
            {
                string commandString = "INSERT INTO volleyballs (firm_name, model_name, price, day, month, year) VALUES (@Firm, @Model, @Price, @Day, @Month, @Year)";
                using (SQLiteCommand cmd = new SQLiteCommand(commandString, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Firm", ballFirm);
                    cmd.Parameters.AddWithValue("@Model", ballModel);
                    cmd.Parameters.AddWithValue("@Price", ballPrice);
                    cmd.Parameters.AddWithValue("@Day", getDay);
                    cmd.Parameters.AddWithValue("@Month", getMonth);
                    cmd.Parameters.AddWithValue("@Year", getYear);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int GetNextID()
        {
            int maxID = 0;

            if (databaseTable.Columns.Contains("ID"))
            {
                var idValues = databaseTable.AsEnumerable().Where(row => row["ID"] != DBNull.Value).Select(row => Convert.ToInt32(row["ID"]));

                maxID = idValues.Any() ? idValues.Max() : 0;
            }

            return maxID + 1;
        }

        // УДАЛЕНИЕ
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (DelOrChangeByNumber.Checked)
            {
                int positionToDelete = (int)NumericDelOrChangeByNumber.Value - 1;

                if (positionToDelete < 0 || positionToDelete >= databaseTable.Rows.Count)
                {
                    MessageBox.Show("Недопустимая позиция");
                    return;
                }

                DeleteRecordByPosition(positionToDelete);
            }

            else if (DelOrChangeByID.Checked)
            {
                int idToDelete;

                if (!int.TryParse(TextBoxDelOrChangeByID.Text, out idToDelete))
                {
                    MessageBox.Show("Неверное значение ID");
                    return;
                }

                DeleteRecordByID(idToDelete);
            }

            else
            {
                MessageBox.Show("Вы не выбрали способ удаления записи");
            }

            LoadContactDataGridView();
        }

        private void DeleteRecordByPosition(int position)
        {
            DataRow rowToDelete = databaseTable.Rows[position];
            int idToDelete = (int)(long)rowToDelete["ID"];
            databaseTable.Rows.RemoveAt(position);

            using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
            {
                string commandString = "DELETE FROM volleyballs WHERE ID = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(commandString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ID", idToDelete);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteRecordByID(int id)
        {
            DataRow rowToDelete = databaseTable.Rows.Find(id);
            if (rowToDelete != null)
            {
                databaseTable.Rows.Remove(rowToDelete);
                using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
                {
                    string commandString = "DELETE FROM volleyballs WHERE ID = @ID";
                    using (SQLiteCommand cmd = new SQLiteCommand(commandString, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Запись с таким ID не найдена");
            }
        }

        // ИЗМЕНЕНИЕ
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (DelOrChangeByNumber.Checked)
            {
                int positionToUpdate;
                string ballFirm = TextBoxFirmName.Text;
                string ballModel = TextBoxModelBallName.Text;
                double ballPrice;
                int getDay = (int)DayGettingBall.Value;
                int getMonth = (int)MonthGettingBall.Value;
                int getYear = (int)YearGettingBall.Value;

                if (!int.TryParse(NumericDelOrChangeByNumber.Text, out positionToUpdate))
                {
                    MessageBox.Show("Некорректная позиция");
                    return;
                }

                if (!double.TryParse(TextBoxPriceOfBall.Text, out ballPrice))
                {
                    MessageBox.Show("Недопустимое значение стоимости");
                    return;
                }

                UpdateRecordByPosition(positionToUpdate, ballFirm, ballModel, ballPrice, getDay, getMonth, getYear);
            }

            else if (DelOrChangeByID.Checked)
            {
                int idToUpdate;
                string ballFirm = TextBoxFirmName.Text;
                string ballModel = TextBoxModelBallName.Text;
                double ballPrice;
                int getDay = (int)DayGettingBall.Value;
                int getMonth = (int)MonthGettingBall.Value;
                int getYear = (int)YearGettingBall.Value;

                if (!int.TryParse(TextBoxDelOrChangeByID.Text, out idToUpdate))
                {
                    MessageBox.Show("Неверное значение ID");
                    return;
                }

                if (!double.TryParse(TextBoxPriceOfBall.Text, out ballPrice))
                {
                    MessageBox.Show("Недопустимое значение стоимости");
                    return;
                }

                UpdateRecordByID(ballFirm, ballModel, ballPrice, getDay, getMonth, getYear, idToUpdate);
            }

            else
            {
                MessageBox.Show("Вы не выбрали способ изменения записи");
            }

            LoadContactDataGridView();
        }

        private void UpdateRecordByPosition(int position, string ballFirm, string ballModel, double ballPrice, int getDay, int getMonth, int getYear)
        {
            position -= 1;
            if (position < 0 || position >= databaseTable.Rows.Count)
            {
                MessageBox.Show("Недопустимая позиция");
                return;
            }

            DataRow rowToUpdate = databaseTable.Rows[position];
            int idToUpdate = (int)(long)rowToUpdate["ID"];

            rowToUpdate[1] = ballFirm;
            rowToUpdate[2] = ballModel;
            rowToUpdate[3] = ballPrice;

            if (getDay > 0 && getDay < 32)
            {
                rowToUpdate[4] = getDay;
            }
            else
            {
                MessageBox.Show("Такого дня не существует");
                return;
            }

            if (getMonth > 0 && getMonth < 13)
            {
                rowToUpdate[5] = getMonth;
            }
            else
            {
                MessageBox.Show("Такого месяца не существует");
                return;
            }

            if (getYear > 9 && getYear < 100)
            {
                rowToUpdate[6] = getYear;
            }
            else
            {
                MessageBox.Show("Некорректный ввод года");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
            {
                string commandString = "UPDATE volleyballs SET firm_name = @Firm, model_name = @Model, price = @Price, day = @Day, month = @Month, year = @Year WHERE ID = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(commandString, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Firm", ballFirm);
                    cmd.Parameters.AddWithValue("@Model", ballModel);
                    cmd.Parameters.AddWithValue("@Price", ballPrice);
                    cmd.Parameters.AddWithValue("@Day", getDay);
                    cmd.Parameters.AddWithValue("@Month", getMonth);
                    cmd.Parameters.AddWithValue("@Year", getYear);
                    cmd.Parameters.AddWithValue("@ID", idToUpdate);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateRecordByID(string ballFirm, string ballModel, double ballPrice, int getDay, int getMonth, int getYear, int id)
        {
            DataRow rowToUpdate = databaseTable.Rows.Find(id);
            if (rowToUpdate != null)
            {
                rowToUpdate[1] = ballFirm;
                rowToUpdate[2] = ballModel;
                rowToUpdate[3] = ballPrice;

                if (getDay > 0 && getDay < 32)
                {
                    rowToUpdate[4] = getDay;
                }
                else
                {
                    MessageBox.Show("Такого дня не существует");
                    return;
                }

                if (getMonth > 0 && getMonth < 13)
                {
                    rowToUpdate[5] = getMonth;
                }
                else
                {
                    MessageBox.Show("Такого месяца не существует");
                    return;
                }

                if (getYear > 9 && getYear < 100)
                {
                    rowToUpdate[6] = getYear;
                }
                else
                {
                    MessageBox.Show("Некорректный ввод года");
                    return;
                }

                using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
                {
                    string commandString = "UPDATE volleyballs SET firm_name = @Firm, model_name = @Model, price = @Price, day = @Day, month = @Month, year = @Year WHERE ID = @ID";
                    using (SQLiteCommand cmd = new SQLiteCommand(commandString, conn))
                    {
                        conn.Open();

                        cmd.Parameters.AddWithValue("@Firm", ballFirm);
                        cmd.Parameters.AddWithValue("@Model", ballModel);
                        cmd.Parameters.AddWithValue("@Price", ballPrice);
                        cmd.Parameters.AddWithValue("@Day", getDay);
                        cmd.Parameters.AddWithValue("@Month", getMonth);
                        cmd.Parameters.AddWithValue("@Year", getYear);
                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Запись с таким ID не найдена");
            }
        }

        //кнопка 1 (график по соотношению количества фирм/моделей мячей)

        private void ButtonGraphic_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm(databaseTable);
            chartForm.Show();
        }

        public class ChartForm : Form
        {
            private DataTable data;

            public ChartForm(DataTable dataTable)
            {
                data = dataTable;
                InitializeChart();
            }

            private void InitializeChart()
            {
                Chart chart = new Chart();
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                Series series = new Series
                {
                    ChartType = SeriesChartType.Pie
                };

                var firmGroups = data.AsEnumerable().GroupBy(row => row[1]);
                foreach (var group in firmGroups)
                {
                    series.Points.AddXY(group.Key, group.Count());
                }

                chart.Series.Add(series);
                chart.Dock = DockStyle.Fill;
                Controls.Add(chart);
            }
        }

        //кнопка 2 (окно с наглядным подсчётом суммарной стоимости мячей каждой фирмы (модели))

        private void ButtonCalculation_Click(object sender, EventArgs e)
        {
            SummaryCostForm summaryCostForm = new SummaryCostForm(databaseTable);
            summaryCostForm.Show();
        }

        public class SummaryCostForm : Form
        {
            private DataTable data;

            public SummaryCostForm(DataTable dataTable)
            {
                data = dataTable;
                InitializeSummary();
            }

            private void InitializeSummary()
            {
                System.Windows.Forms.ListView listView = new System.Windows.Forms.ListView
                {
                    Dock = DockStyle.Fill,
                    View = View.Details
                };

                listView.Columns.Add("Firm", -2, HorizontalAlignment.Left);
                listView.Columns.Add("Total Cost", -2, HorizontalAlignment.Left);

                var firmGroups = data.AsEnumerable().GroupBy(row => row[1]);
                foreach (var group in firmGroups)
                {
                    double totalCost = group.Sum(row => Convert.ToDouble(row[3]));
                    ListViewItem item = new ListViewItem(new[] { group.Key.ToString(), totalCost.ToString("C") });
                    listView.Items.Add(item);
                }

                Controls.Add(listView);
            }
        }
    }
}