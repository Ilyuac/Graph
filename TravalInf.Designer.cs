namespace Graph
{
    partial class TravalInf
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatrixPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MatrixPanel
            // 
            this.MatrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixPanel.Location = new System.Drawing.Point(0, 0);
            this.MatrixPanel.Name = "MatrixPanel";
            this.MatrixPanel.Size = new System.Drawing.Size(719, 530);
            this.MatrixPanel.TabIndex = 0;
            // 
            // TriperInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MatrixPanel);
            this.Name = "TriperInf";
            this.Size = new System.Drawing.Size(719, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MatrixPanel;
    }
}
