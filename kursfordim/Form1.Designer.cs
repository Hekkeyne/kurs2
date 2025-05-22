using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursfordim
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewMachines = new DataGridView();
            dataGridViewOils = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            label3 = new Label();
            txtTotalPlanCost = new TextBox();
            label4 = new Label();
            txtTotalActualCost = new TextBox();
            label5 = new Label();
            txtMinCost = new TextBox();
            label6 = new Label();
            txtMaxCost = new TextBox();
            label7 = new Label();
            listBoxOilByStockCost = new ListBox();
            btnRandomFill = new Button();
            btnImport = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMachines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOils).BeginInit();
            SuspendLayout();

            // dataGridViewMachines
            dataGridViewMachines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMachines.Location = new Point(12, 36);
            dataGridViewMachines.Name = "dataGridViewMachines";
            dataGridViewMachines.Size = new Size(600, 150);
            dataGridViewMachines.TabIndex = 0;

            // dataGridViewOils
            dataGridViewOils.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOils.Location = new Point(12, 225);
            dataGridViewOils.Name = "dataGridViewOils";
            dataGridViewOils.Size = new Size(600, 150);
            dataGridViewOils.TabIndex = 1;

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(82, 13);
            label1.TabIndex = 2;
            label1.Text = "Виды станков:";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(12, 209);
            label2.Name = "label2";
            label2.Size = new Size(100, 13);
            label2.TabIndex = 3;
            label2.Text = "Марки масел (ГСМ):";

            // btnCalculate
            btnCalculate.Location = new Point(618, 36);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 40);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(618, 100);
            label3.Name = "label3";
            label3.Size = new Size(150, 13);
            label3.TabIndex = 5;
            label3.Text = "Общая плановая стоимость:";

            // txtTotalPlanCost
            txtTotalPlanCost.Location = new Point(618, 116);
            txtTotalPlanCost.Name = "txtTotalPlanCost";
            txtTotalPlanCost.ReadOnly = true;
            txtTotalPlanCost.Size = new Size(150, 20);
            txtTotalPlanCost.TabIndex = 6;

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(618, 150);
            label4.Name = "label4";
            label4.Size = new Size(154, 13);
            label4.TabIndex = 7;
            label4.Text = "Общая фактическая стоимость:";

            // txtTotalActualCost
            txtTotalActualCost.Location = new Point(618, 166);
            txtTotalActualCost.Name = "txtTotalActualCost";
            txtTotalActualCost.ReadOnly = true;
            txtTotalActualCost.Size = new Size(150, 20);
            txtTotalActualCost.TabIndex = 8;

            // label5
            label5.AutoSize = true;
            label5.Location = new Point(618, 200);
            label5.Name = "label5";
            label5.Size = new Size(113, 13);
            label5.TabIndex = 9;
            label5.Text = "Минимальная стоимость:";

            // txtMinCost
            txtMinCost.Location = new Point(618, 216);
            txtMinCost.Name = "txtMinCost";
            txtMinCost.ReadOnly = true;
            txtMinCost.Size = new Size(150, 20);
            txtMinCost.TabIndex = 10;

            // label6
            label6.AutoSize = true;
            label6.Location = new Point(618, 250);
            label6.Name = "label6";
            label6.Size = new Size(119, 13);
            label6.TabIndex = 11;
            label6.Text = "Максимальная стоимость:";

            // txtMaxCost
            txtMaxCost.Location = new Point(618, 266);
            txtMaxCost.Name = "txtMaxCost";
            txtMaxCost.ReadOnly = true;
            txtMaxCost.Size = new Size(150, 20);
            txtMaxCost.TabIndex = 12;

            // label7
            label7.AutoSize = true;
            label7.Location = new Point(618, 300);
            label7.Name = "label7";
            label7.Size = new Size(161, 13);
            label7.TabIndex = 13;
            label7.Text = "Масла по стоимости остатков:";

            // listBoxOilByStockCost
            listBoxOilByStockCost.FormattingEnabled = true;
            listBoxOilByStockCost.Location = new Point(618, 316);
            listBoxOilByStockCost.Name = "listBoxOilByStockCost";
            listBoxOilByStockCost.Size = new Size(150, 95);
            listBoxOilByStockCost.TabIndex = 14;

            // btnRandomFill
            btnRandomFill.Location = new Point(12, 381);
            btnRandomFill.Name = "btnRandomFill";
            btnRandomFill.Size = new Size(150, 30);
            btnRandomFill.TabIndex = 15;
            btnRandomFill.Text = "Случайное заполнение";
            btnRandomFill.UseVisualStyleBackColor = true;
            btnRandomFill.Click += btnRandomFill_Click;

            // btnImport
            btnImport.Location = new Point(168, 381);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(150, 30);
            btnImport.TabIndex = 16;
            btnImport.Text = "Импорт из файла";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;

            // btnExport
            btnExport.Location = new Point(324, 381);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 30);
            btnExport.TabIndex = 17;
            btnExport.Text = "Экспорт в файл";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;

            // Form1
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 421);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(btnRandomFill);
            Controls.Add(listBoxOilByStockCost);
            Controls.Add(label7);
            Controls.Add(txtMaxCost);
            Controls.Add(label6);
            Controls.Add(txtMinCost);
            Controls.Add(label5);
            Controls.Add(txtTotalActualCost);
            Controls.Add(label4);
            Controls.Add(txtTotalPlanCost);
            Controls.Add(label3);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewOils);
            Controls.Add(dataGridViewMachines);
            Name = "Form1";
            Text = "Учет технических масел для станков";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMachines).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOils).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridViewMachines;
        private DataGridView dataGridViewOils;
        private Label label1;
        private Label label2;
        private Button btnCalculate;
        private Label label3;
        private TextBox txtTotalPlanCost;
        private Label label4;
        private TextBox txtTotalActualCost;
        private Label label5;
        private TextBox txtMinCost;
        private Label label6;
        private TextBox txtMaxCost;
        private Label label7;
        private ListBox listBoxOilByStockCost;
        private Button btnRandomFill;
        private Button btnImport;
        private Button btnExport;
    }
}