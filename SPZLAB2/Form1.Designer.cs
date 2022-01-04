
namespace SPZLAB2
{
    partial class Form1
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
            this.lbxCampuses = new System.Windows.Forms.ListBox();
            this.AddCampBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCampuses
            // 
            this.lbxCampuses.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbxCampuses.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxCampuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxCampuses.FormattingEnabled = true;
            this.lbxCampuses.ItemHeight = 31;
            this.lbxCampuses.Location = new System.Drawing.Point(0, 0);
            this.lbxCampuses.Name = "lbxCampuses";
            this.lbxCampuses.Size = new System.Drawing.Size(477, 376);
            this.lbxCampuses.TabIndex = 0;
            this.lbxCampuses.DoubleClick += new System.EventHandler(this.lbxCampuses_DoubleClick);
            // 
            // AddCampBtn
            // 
            this.AddCampBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCampBtn.Location = new System.Drawing.Point(171, 397);
            this.AddCampBtn.Name = "AddCampBtn";
            this.AddCampBtn.Size = new System.Drawing.Size(129, 41);
            this.AddCampBtn.TabIndex = 1;
            this.AddCampBtn.Text = "Add Campus";
            this.AddCampBtn.UseVisualStyleBackColor = true;
            this.AddCampBtn.Click += new System.EventHandler(this.AddCampBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.AddCampBtn);
            this.Controls.Add(this.lbxCampuses);
            this.Name = "Form1";
            this.Text = "ЛБ2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCampuses;
        private System.Windows.Forms.Button AddCampBtn;
    }
}

