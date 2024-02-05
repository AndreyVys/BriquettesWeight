namespace BriquettesWeight
{
    partial class BriquettesWeight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BriquettesWeight));
            this.labelWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.Location = new System.Drawing.Point(98, 37);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWeight.Size = new System.Drawing.Size(0, 36);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BriquettesWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 103);
            this.Controls.Add(this.labelWeight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "BriquettesWeight";
            this.Text = "Масса брикетов";
            this.Load += new System.EventHandler(this.BriquettesWeight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeight;
    }
}

