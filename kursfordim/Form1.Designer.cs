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
            menuStrip1 = new MenuStrip();
            импортToolStripMenuItem = new ToolStripMenuItem();
            экспортToolStripMenuItem = new ToolStripMenuItem();
            рассчитатьToolStripMenuItem = new ToolStripMenuItem();
            случайноеЗаполнениеToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMachines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOils).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMachines
            // 
            dataGridViewMachines.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMachines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMachines.Location = new Point(14, 42);
            dataGridViewMachines.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMachines.Name = "dataGridViewMachines";
            dataGridViewMachines.Size = new Size(700, 200);
            dataGridViewMachines.TabIndex = 0;
            dataGridViewMachines.EditingControlShowing += proverkamachine;
            dataGridViewMachines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMachines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // 
            // dataGridViewOils
            // 
            dataGridViewOils.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOils.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOils.Location = new Point(14, 280);
            dataGridViewOils.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOils.Name = "dataGridViewOils";
            dataGridViewOils.Size = new Size(700, 150);
            dataGridViewOils.TabIndex = 1;
            dataGridViewOils.EditingControlShowing += proverkaoil;
            dataGridViewOils.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOils.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Виды станков:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 260);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 3;
            label2.Text = "Марки масел (ГСМ):";
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCalculate.Location = new Point(721, 42);
            btnCalculate.Margin = new Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(175, 46);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(721, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 5;
            label3.Text = "Общая плановая стоимость:";
            // 
            // txtTotalPlanCost
            // 
            txtTotalPlanCost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalPlanCost.Location = new Point(721, 134);
            txtTotalPlanCost.Margin = new Padding(4, 3, 4, 3);
            txtTotalPlanCost.Name = "txtTotalPlanCost";
            txtTotalPlanCost.ReadOnly = true;
            txtTotalPlanCost.Size = new Size(174, 23);
            txtTotalPlanCost.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(721, 173);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 15);
            label4.TabIndex = 7;
            label4.Text = "Общая фактическая стоимость:";
            // 
            // txtTotalActualCost
            // 
            txtTotalActualCost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalActualCost.Location = new Point(721, 192);
            txtTotalActualCost.Margin = new Padding(4, 3, 4, 3);
            txtTotalActualCost.Name = "txtTotalActualCost";
            txtTotalActualCost.ReadOnly = true;
            txtTotalActualCost.Size = new Size(174, 23);
            txtTotalActualCost.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(721, 231);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 9;
            label5.Text = "Минимальная стоимость:";
            // 
            // txtMinCost
            // 
            txtMinCost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMinCost.Location = new Point(721, 249);
            txtMinCost.Margin = new Padding(4, 3, 4, 3);
            txtMinCost.Name = "txtMinCost";
            txtMinCost.ReadOnly = true;
            txtMinCost.Size = new Size(174, 23);
            txtMinCost.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(721, 288);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 15);
            label6.TabIndex = 11;
            label6.Text = "Максимальная стоимость:";
            // 
            // txtMaxCost
            // 
            txtMaxCost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMaxCost.Location = new Point(721, 307);
            txtMaxCost.Margin = new Padding(4, 3, 4, 3);
            txtMaxCost.Name = "txtMaxCost";
            txtMaxCost.ReadOnly = true;
            txtMaxCost.Size = new Size(174, 23);
            txtMaxCost.TabIndex = 12;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(721, 346);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 15);
            label7.TabIndex = 13;
            label7.Text = "Масла по стоимости остатков:";
            // 
            // listBoxOilByStockCost
            // 
            listBoxOilByStockCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxOilByStockCost.FormattingEnabled = true;
            listBoxOilByStockCost.ItemHeight = 15;
            listBoxOilByStockCost.Location = new Point(721, 365);
            listBoxOilByStockCost.Margin = new Padding(4, 3, 4, 3);
            listBoxOilByStockCost.Name = "listBoxOilByStockCost";
            listBoxOilByStockCost.Size = new Size(174, 109);
            listBoxOilByStockCost.TabIndex = 14;
            // 
            // btnRandomFill
            // 
            btnRandomFill.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRandomFill.Location = new Point(14, 440);
            btnRandomFill.Margin = new Padding(4, 3, 4, 3);
            btnRandomFill.Name = "btnRandomFill";
            btnRandomFill.Size = new Size(175, 35);
            btnRandomFill.TabIndex = 15;
            btnRandomFill.Text = "Случайное заполнение";
            btnRandomFill.UseVisualStyleBackColor = true;
            btnRandomFill.Click += btnRandomFill_Click;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImport.Location = new Point(196, 440);
            btnImport.Margin = new Padding(4, 3, 4, 3);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(175, 35);
            btnImport.TabIndex = 16;
            btnImport.Text = "Импорт из файла";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExport.Location = new Point(378, 440);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(175, 35);
            btnExport.TabIndex = 17;
            btnExport.Text = "Экспорт в файл";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { импортToolStripMenuItem, экспортToolStripMenuItem, рассчитатьToolStripMenuItem, случайноеЗаполнениеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(915, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // импортToolStripMenuItem
            // 
            импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            импортToolStripMenuItem.Size = new Size(63, 20);
            импортToolStripMenuItem.Text = "Импорт";
            импортToolStripMenuItem.Click += btnImport_Click;
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size = new Size(64, 20);
            экспортToolStripMenuItem.Text = "Экспорт";
            экспортToolStripMenuItem.Click += btnExport_Click;
            // 
            // рассчитатьToolStripMenuItem
            // 
            рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            рассчитатьToolStripMenuItem.Size = new Size(80, 20);
            рассчитатьToolStripMenuItem.Text = "Рассчитать";
            рассчитатьToolStripMenuItem.Click += btnCalculate_Click;
            // 
            // случайноеЗаполнениеToolStripMenuItem
            // 
            случайноеЗаполнениеToolStripMenuItem.Name = "случайноеЗаполнениеToolStripMenuItem";
            случайноеЗаполнениеToolStripMenuItem.Size = new Size(148, 20);
            случайноеЗаполнениеToolStripMenuItem.Text = "Случайное заполнение";
            случайноеЗаполнениеToolStripMenuItem.Click += btnRandomFill_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 486);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            Text = "Учет технических масел для станков";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMachines).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOils).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem импортToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private ToolStripMenuItem рассчитатьToolStripMenuItem;
        private ToolStripMenuItem случайноеЗаполнениеToolStripMenuItem;
    }
}