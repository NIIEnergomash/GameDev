namespace Lesson72
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
            this.tbEnterValue = new System.Windows.Forms.TextBox();
            this.lblChoosen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRand = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEnterValue
            // 
            this.tbEnterValue.Enabled = false;
            this.tbEnterValue.Location = new System.Drawing.Point(121, 49);
            this.tbEnterValue.Name = "tbEnterValue";
            this.tbEnterValue.Size = new System.Drawing.Size(100, 20);
            this.tbEnterValue.TabIndex = 0;
            this.tbEnterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEnterValue_KeyPress);
            // 
            // lblChoosen
            // 
            this.lblChoosen.AutoSize = true;
            this.lblChoosen.Location = new System.Drawing.Point(132, 22);
            this.lblChoosen.Name = "lblChoosen";
            this.lblChoosen.Size = new System.Drawing.Size(89, 13);
            this.lblChoosen.TabIndex = 1;
            this.lblChoosen.Text = "Число загадано";
            this.lblChoosen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(26, 17);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(100, 23);
            this.btnRand.TabIndex = 4;
            this.btnRand.Text = "Загадать число";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.BtnRand_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Результат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 169);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChoosen);
            this.Controls.Add(this.tbEnterValue);
            this.Name = "MainForm";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnterValue;
        private System.Windows.Forms.Label lblChoosen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Label lblResult;
    }
}

