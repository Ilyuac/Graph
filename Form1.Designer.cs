namespace Graph
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DrowerPanel = new System.Windows.Forms.PictureBox();
            this.HorisontalSpliter = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butAMatrix = new System.Windows.Forms.Button();
            this.butIMatrix = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butSimpleR = new System.Windows.Forms.Button();
            this.butPaintGrath = new System.Windows.Forms.Button();
            this.VerticalSpliter = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butClear = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butVertex = new System.Windows.Forms.Button();
            this.butEdge = new System.Windows.Forms.Button();
            this.butArrow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сщхранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неориентированныйГрафToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ориентированныйГрафToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butTriper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrowerPanel)).BeginInit();
            this.HorisontalSpliter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.VerticalSpliter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrowerPanel
            // 
            this.DrowerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrowerPanel.Location = new System.Drawing.Point(0, 0);
            this.DrowerPanel.MaximumSize = new System.Drawing.Size(1000, 1500);
            this.DrowerPanel.Name = "DrowerPanel";
            this.DrowerPanel.Size = new System.Drawing.Size(972, 734);
            this.DrowerPanel.TabIndex = 2;
            this.DrowerPanel.TabStop = false;
            this.DrowerPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrowerPanel_MouseClick);
            // 
            // HorisontalSpliter
            // 
            this.HorisontalSpliter.ColumnCount = 1;
            this.HorisontalSpliter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HorisontalSpliter.Controls.Add(this.listBoxMatrix, 0, 1);
            this.HorisontalSpliter.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.HorisontalSpliter.Controls.Add(this.panel3, 0, 2);
            this.HorisontalSpliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorisontalSpliter.Location = new System.Drawing.Point(1100, 3);
            this.HorisontalSpliter.Name = "HorisontalSpliter";
            this.HorisontalSpliter.RowCount = 3;
            this.HorisontalSpliter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71195F));
            this.HorisontalSpliter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.28806F));
            this.HorisontalSpliter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.HorisontalSpliter.Size = new System.Drawing.Size(259, 734);
            this.HorisontalSpliter.TabIndex = 0;
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 16;
            this.listBoxMatrix.Location = new System.Drawing.Point(3, 99);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(253, 509);
            this.listBoxMatrix.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.butAMatrix);
            this.flowLayoutPanel1.Controls.Add(this.butIMatrix);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 90);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // butAMatrix
            // 
            this.butAMatrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butAMatrix.Image = global::Graph.Properties.Resources.smezh;
            this.butAMatrix.Location = new System.Drawing.Point(3, 3);
            this.butAMatrix.Name = "butAMatrix";
            this.butAMatrix.Size = new System.Drawing.Size(123, 78);
            this.butAMatrix.TabIndex = 2;
            this.butAMatrix.UseVisualStyleBackColor = false;
            this.butAMatrix.Click += new System.EventHandler(this.butAMatrix_Click);
            // 
            // butIMatrix
            // 
            this.butIMatrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butIMatrix.Image = global::Graph.Properties.Resources.inc;
            this.butIMatrix.Location = new System.Drawing.Point(132, 3);
            this.butIMatrix.Name = "butIMatrix";
            this.butIMatrix.Size = new System.Drawing.Size(116, 78);
            this.butIMatrix.TabIndex = 3;
            this.butIMatrix.UseVisualStyleBackColor = false;
            this.butIMatrix.Click += new System.EventHandler(this.butIMatrix_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butTriper);
            this.panel3.Controls.Add(this.butSimpleR);
            this.panel3.Controls.Add(this.butPaintGrath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 614);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 117);
            this.panel3.TabIndex = 4;
            // 
            // butSimpleR
            // 
            this.butSimpleR.Location = new System.Drawing.Point(51, 45);
            this.butSimpleR.Name = "butSimpleR";
            this.butSimpleR.Size = new System.Drawing.Size(160, 29);
            this.butSimpleR.TabIndex = 5;
            this.butSimpleR.Text = "Найти простые цыклы";
            this.butSimpleR.UseVisualStyleBackColor = true;
            this.butSimpleR.Click += new System.EventHandler(this.butSimpleR_Click);
            // 
            // butPaintGrath
            // 
            this.butPaintGrath.Location = new System.Drawing.Point(49, 3);
            this.butPaintGrath.Name = "butPaintGrath";
            this.butPaintGrath.Size = new System.Drawing.Size(162, 36);
            this.butPaintGrath.TabIndex = 4;
            this.butPaintGrath.Text = "Раскрасить граф";
            this.butPaintGrath.UseVisualStyleBackColor = true;
            this.butPaintGrath.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerticalSpliter
            // 
            this.VerticalSpliter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerticalSpliter.ColumnCount = 3;
            this.VerticalSpliter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.VerticalSpliter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VerticalSpliter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.VerticalSpliter.Controls.Add(this.HorisontalSpliter, 2, 0);
            this.VerticalSpliter.Controls.Add(this.panel1, 0, 0);
            this.VerticalSpliter.Controls.Add(this.panel2, 1, 0);
            this.VerticalSpliter.Location = new System.Drawing.Point(0, 28);
            this.VerticalSpliter.Name = "VerticalSpliter";
            this.VerticalSpliter.RowCount = 1;
            this.VerticalSpliter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VerticalSpliter.Size = new System.Drawing.Size(1362, 740);
            this.VerticalSpliter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butClear);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butVertex);
            this.panel1.Controls.Add(this.butEdge);
            this.panel1.Controls.Add(this.butArrow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 734);
            this.panel1.TabIndex = 3;
            // 
            // butClear
            // 
            this.butClear.Image = global::Graph.Properties.Resources.Backet75x75f;
            this.butClear.Location = new System.Drawing.Point(9, 350);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(89, 85);
            this.butClear.TabIndex = 4;
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butDelete
            // 
            this.butDelete.Image = ((System.Drawing.Image)(resources.GetObject("butDelete.Image")));
            this.butDelete.Location = new System.Drawing.Point(9, 269);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(89, 75);
            this.butDelete.TabIndex = 3;
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butVertex
            // 
            this.butVertex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butVertex.Image = ((System.Drawing.Image)(resources.GetObject("butVertex.Image")));
            this.butVertex.Location = new System.Drawing.Point(9, 99);
            this.butVertex.Name = "butVertex";
            this.butVertex.Size = new System.Drawing.Size(89, 86);
            this.butVertex.TabIndex = 2;
            this.butVertex.UseVisualStyleBackColor = false;
            this.butVertex.Click += new System.EventHandler(this.butVertex_Click);
            // 
            // butEdge
            // 
            this.butEdge.Image = ((System.Drawing.Image)(resources.GetObject("butEdge.Image")));
            this.butEdge.Location = new System.Drawing.Point(9, 188);
            this.butEdge.Name = "butEdge";
            this.butEdge.Size = new System.Drawing.Size(89, 75);
            this.butEdge.TabIndex = 1;
            this.butEdge.UseVisualStyleBackColor = true;
            this.butEdge.Click += new System.EventHandler(this.butEdge_Click);
            // 
            // butArrow
            // 
            this.butArrow.Image = global::Graph.Properties.Resources.cursor;
            this.butArrow.Location = new System.Drawing.Point(9, 9);
            this.butArrow.Name = "butArrow";
            this.butArrow.Size = new System.Drawing.Size(89, 84);
            this.butArrow.TabIndex = 0;
            this.butArrow.UseVisualStyleBackColor = true;
            this.butArrow.Click += new System.EventHandler(this.butArrow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DrowerPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(122, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 734);
            this.panel2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.графыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripSeparator1,
            this.сщхранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // сщхранитьToolStripMenuItem
            // 
            this.сщхранитьToolStripMenuItem.Name = "сщхранитьToolStripMenuItem";
            this.сщхранитьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сщхранитьToolStripMenuItem.Text = "Сохранить";
            this.сщхранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // графыToolStripMenuItem
            // 
            this.графыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.неориентированныйГрафToolStripMenuItem,
            this.ориентированныйГрафToolStripMenuItem});
            this.графыToolStripMenuItem.Name = "графыToolStripMenuItem";
            this.графыToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.графыToolStripMenuItem.Text = "Графы";
            // 
            // неориентированныйГрафToolStripMenuItem
            // 
            this.неориентированныйГрафToolStripMenuItem.Checked = true;
            this.неориентированныйГрафToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.неориентированныйГрафToolStripMenuItem.Name = "неориентированныйГрафToolStripMenuItem";
            this.неориентированныйГрафToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.неориентированныйГрафToolStripMenuItem.Text = "Неориентированный граф";
            this.неориентированныйГрафToolStripMenuItem.Click += new System.EventHandler(this.неориентированныйГрафToolStripMenuItem_Click);
            // 
            // ориентированныйГрафToolStripMenuItem
            // 
            this.ориентированныйГрафToolStripMenuItem.Name = "ориентированныйГрафToolStripMenuItem";
            this.ориентированныйГрафToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.ориентированныйГрафToolStripMenuItem.Text = "Ориентированный граф";
            this.ориентированныйГрафToolStripMenuItem.Click += new System.EventHandler(this.ориентированныйГрафToolStripMenuItem_Click);
            // 
            // butTriper
            // 
            this.butTriper.Location = new System.Drawing.Point(51, 80);
            this.butTriper.Name = "butTriper";
            this.butTriper.Size = new System.Drawing.Size(160, 31);
            this.butTriper.TabIndex = 6;
            this.butTriper.Text = "Коммивояжер";
            this.butTriper.UseVisualStyleBackColor = true;
            this.butTriper.Click += new System.EventHandler(this.butTriper_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 768);
            this.Controls.Add(this.VerticalSpliter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.DrowerPanel)).EndInit();
            this.HorisontalSpliter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.VerticalSpliter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrowerPanel;
        private System.Windows.Forms.TableLayoutPanel HorisontalSpliter;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.TableLayoutPanel VerticalSpliter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butVertex;
        private System.Windows.Forms.Button butEdge;
        private System.Windows.Forms.Button butArrow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butAMatrix;
        private System.Windows.Forms.Button butIMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сщхранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неориентированныйГрафToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ориентированныйГрафToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butPaintGrath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butSimpleR;
        private System.Windows.Forms.Button butTriper;
    }
}

