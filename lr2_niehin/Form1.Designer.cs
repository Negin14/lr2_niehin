namespace lr2_niehin
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();

            this.txtn.Location = new System.Drawing.Point(30, 45);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(150, 26);
            this.txtn.TabIndex = 0;

            this.txtRez.Location = new System.Drawing.Point(30, 130);
            this.txtRez.Multiline = true;
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(250, 150);
            this.txtRez.TabIndex = 1;

            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(310, 45);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 24;
            this.dgvMass.Size = new System.Drawing.Size(420, 235);
            this.dgvMass.TabIndex = 2;

            this.cmdStart.Location = new System.Drawing.Point(30, 310);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(130, 40);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Вичислити";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);

            this.cmdClear.Location = new System.Drawing.Point(300, 310);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(130, 40);
            this.cmdClear.TabIndex = 4;
            this.cmdClear.Text = "Очистка полів";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);

            this.cmdExit.Location = new System.Drawing.Point(600, 310);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(130, 40);
            this.cmdExit.TabIndex = 5;
            this.cmdExit.Text = "Завершити роботу";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Розмір матриці n=";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результат:";

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.dgvMass);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.txtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Двовимірні масиви";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}