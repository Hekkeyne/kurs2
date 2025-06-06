using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursfordim
{
    public partial class Form1 : Form
    {
        private DataTable machinesTable;
        private DataTable oilsTable;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeDataTables();
            dataGridViewOils.RowsAdded += (s, e) => UpdateControlsPosition();
            dataGridViewOils.ColumnAdded += (s, e) => UpdateControlsPosition();
            dataGridViewMachines.RowsAdded += (s, e) => UpdateControlsPosition();
            dataGridViewMachines.ColumnAdded += (s, e) => UpdateControlsPosition();
            Resize += (s, e) => UpdateControlsPosition();
        }
        private void UpdateControlsPosition()
        {
            int datawidth = dataGridViewMachines.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dataGridViewMachines.RowHeadersWidth + 10;
            int dataheight = dataGridViewMachines.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dataGridViewMachines.ColumnHeadersHeight + 10;
            int maxwidth = ClientSize.Width - dataGridViewMachines.Left - 20;
            int maxheight = ClientSize.Height - dataGridViewMachines.Top - 20;
            dataGridViewMachines.Size = new Size(
                Math.Min(datawidth, Math.Max(100, maxwidth)),
                Math.Min(dataheight, Math.Max(100, maxheight))
            );
            datawidth = dataGridViewOils.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dataGridViewOils.RowHeadersWidth + 10;
            dataheight = dataGridViewOils.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dataGridViewOils.ColumnHeadersHeight + 10;
            maxwidth = ClientSize.Width - dataGridViewOils.Left - 20;
            maxheight = ClientSize.Height - dataGridViewOils.Top - 20;
            dataGridViewOils.Size = new Size(
                Math.Min(datawidth, Math.Max(100, maxwidth)),
                Math.Min(dataheight, Math.Max(100, maxheight))
            );
        }
        private void proverkaoil(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is System.Windows.Forms.TextBox tb)
            {
                tb.KeyPress += oil_KeyPress;
            }
        }
        private void proverkamachine(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is System.Windows.Forms.TextBox tb)
            {
                tb.KeyPress += machine_KeyPress;
            }
        }
        private void oil_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridView d = dataGridViewOils;
            if (d.CurrentCell.ColumnIndex == 1 || d.CurrentCell.ColumnIndex == 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void machine_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridView d = dataGridViewMachines;
            if (d.CurrentCell.ColumnIndex == 1 || d.CurrentCell.ColumnIndex == 3 || d.CurrentCell.ColumnIndex == 4)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void InitializeDataTables()
        {
            // ������� �������
            machinesTable = new DataTable();
            machinesTable.Columns.Add("��� ������", typeof(string));
            machinesTable.Columns.Add("����������", typeof(int));
            machinesTable.Columns.Add("����� �����", typeof(string));
            machinesTable.Columns.Add("�������� ������", typeof(decimal));
            machinesTable.Columns.Add("����������� ������", typeof(decimal));

            dataGridViewMachines.DataSource = machinesTable;

            // ������� �����
            oilsTable = new DataTable();
            oilsTable.Columns.Add("����� �����", typeof(string));
            oilsTable.Columns.Add("���������� �� ������", typeof(decimal));
            oilsTable.Columns.Add("��������� �� �������", typeof(decimal));

            dataGridViewOils.DataSource = oilsTable;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateCosts();
            CalculateMinMaxCosts();
            DisplayOilsByStockCost();
        }

        private void CalculateCosts()
        {
            decimal totalPlanCost = 0;
            decimal totalActualCost = 0;

            foreach (DataRow machineRow in machinesTable.Rows)
            {
                string oilBrand = machineRow["����� �����"].ToString();
                decimal planConsumption = Convert.ToDecimal(machineRow["�������� ������"]);
                decimal actualConsumption = Convert.ToDecimal(machineRow["����������� ������"]);
                int machineCount = Convert.ToInt32(machineRow["����������"]);

                DataRow[] oilRows = oilsTable.Select($"[����� �����] = '{oilBrand}'");
                if (oilRows.Length > 0)
                {
                    decimal oilPrice = Convert.ToDecimal(oilRows[0]["��������� �� �������"]);
                    totalPlanCost += planConsumption * oilPrice * machineCount;
                    totalActualCost += actualConsumption * oilPrice * machineCount;
                }
            }

            txtTotalPlanCost.Text = totalPlanCost.ToString("N2");
            txtTotalActualCost.Text = totalActualCost.ToString("N2");
        }

        private void CalculateMinMaxCosts()
        {
            List<decimal> costs = new List<decimal>();

            foreach (DataRow machineRow in machinesTable.Rows)
            {
                string oilBrand = machineRow["����� �����"].ToString();
                decimal actualConsumption = Convert.ToDecimal(machineRow["����������� ������"]);
                int machineCount = Convert.ToInt32(machineRow["����������"]);

                DataRow[] oilRows = oilsTable.Select($"[����� �����] = '{oilBrand}'");
                if (oilRows.Length > 0)
                {
                    decimal oilPrice = Convert.ToDecimal(oilRows[0]["��������� �� �������"]);
                    decimal cost = actualConsumption * oilPrice * machineCount;
                    costs.Add(cost);
                }
            }

            if (costs.Count > 0)
            {
                txtMinCost.Text = costs.Min().ToString("N2");
                txtMaxCost.Text = costs.Max().ToString("N2");
            }
        }

        private void DisplayOilsByStockCost()
        {
            listBoxOilByStockCost.Items.Clear();

            var oils = oilsTable.AsEnumerable()
                .OrderBy(row => Convert.ToDecimal(row["���������� �� ������"]) *
                               Convert.ToDecimal(row["��������� �� �������"]))
                .Select(row => $"{row["����� �����"]} - {Convert.ToDecimal(row["���������� �� ������"]) *
                              Convert.ToDecimal(row["��������� �� �������"]):N2}");

            foreach (var oil in oils)
            {
                listBoxOilByStockCost.Items.Add(oil);
            }
        }

        private void btnRandomFill_Click(object sender, EventArgs e)
        {
            // ������� �������
            machinesTable.Rows.Clear();
            oilsTable.Rows.Clear();

            // ��������� ����� �����
            string[] oilBrands = { "����� A", "����� B", "����� C", "����� D", "����� E" };
            string[] machineTypes = { "��������", "���������", "�����������", "������������", "��������-��������" };

            // ��������� �����
            foreach (string brand in oilBrands)
            {
                oilsTable.Rows.Add(
                    brand,
                    Convert.ToDecimal(Math.Round(random.Next(50, 200) + random.NextDouble(), 2)), // ����������
                    Convert.ToDecimal(Math.Round(random.Next(500, 2000) + random.NextDouble(), 2)) // ����
                );
            }

            // ��������� ������
            for (int i = 0; i < 5; i++)
            {
                machinesTable.Rows.Add(
                    machineTypes[i],
                    random.Next(1, 10), // ���������� �������
                    oilBrands[random.Next(oilBrands.Length)], // ����� �����
                    Math.Round(random.Next(1, 20) + random.NextDouble(), 2), // �������� ������
                    Math.Round(random.Next(1, 20) + random.NextDouble(), 2) // ����������� ������
                );
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "��������� ����� (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    if (lines.Length < 2) return;

                    // ������� �������
                    machinesTable.Rows.Clear();
                    oilsTable.Rows.Clear();

                    // ������ ����� (������ ������ - ���������)
                    int i = 1;
                    while (i < lines.Length && !string.IsNullOrWhiteSpace(lines[i]))
                    {
                        string[] parts = lines[i].Split('|');
                        if (parts.Length >= 3)
                        {
                            oilsTable.Rows.Add(parts[0].Trim(), decimal.Parse(parts[1].Trim()), decimal.Parse(parts[2].Trim()));
                        }
                        i++;
                    }

                    // ���������� ������ ������
                    i++;

                    // ������ ������ (������ ����� ������)
                    i++;
                    while (i < lines.Length)
                    {
                        string[] parts = lines[i].Split('|');
                        if (parts.Length >= 5)
                        {
                            machinesTable.Rows.Add(
                                parts[0].Trim(),
                                int.Parse(parts[1].Trim()),
                                parts[2].Trim(),
                                decimal.Parse(parts[3].Trim()),
                                decimal.Parse(parts[4].Trim()));
                        }
                        i++;
                    }

                    MessageBox.Show("������ ������� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� �������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "��������� ����� (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> lines = new List<string>();

                    // ������� �����
                    lines.Add("����� �����|���������� �� ������|����");
                    foreach (DataRow row in oilsTable.Rows)
                    {
                        lines.Add($"{row["����� �����"]}|{row["���������� �� ������"]}|{row["��������� �� �������"]}");
                    }

                    // ������ ������ ��� �����������
                    lines.Add("");

                    // ������� �������
                    lines.Add("��� ������|����������|����� �����|�������� ������|����������� ������");
                    foreach (DataRow row in machinesTable.Rows)
                    {
                        lines.Add($"{row["��� ������"]}|{row["����������"]}|{row["����� �����"]}|" +
                                $"{row["�������� ������"]}|{row["����������� ������"]}");
                    }

                    File.WriteAllLines(saveFileDialog.FileName, lines);
                    MessageBox.Show("������ ������� ��������������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ��������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ����� �������� ��������� �������� ������, ���� �����
        }
    }
}