namespace Primera_Aplicacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            nombreLabel = new Label();
            cantidaLabel = new Label();
            BtnCrearCuenta = new Button();
            button1 = new Button();
            button2 = new Button();
            BankAccountGrid = new DataGridView();
            AmountNum = new NumericUpDown();
            inputName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 16F);
            nombreLabel.Location = new Point(12, 23);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(94, 30);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre";
            // 
            // cantidaLabel
            // 
            cantidaLabel.AutoSize = true;
            cantidaLabel.Font = new Font("Segoe UI", 16F);
            cantidaLabel.Location = new Point(12, 250);
            cantidaLabel.Name = "cantidaLabel";
            cantidaLabel.Size = new Size(99, 30);
            cantidaLabel.TabIndex = 3;
            cantidaLabel.Text = "Cantidad";
            // 
            // BtnCrearCuenta
            // 
            BtnCrearCuenta.Font = new Font("Segoe UI", 16F);
            BtnCrearCuenta.Location = new Point(114, 64);
            BtnCrearCuenta.Name = "BtnCrearCuenta";
            BtnCrearCuenta.Size = new Size(183, 42);
            BtnCrearCuenta.TabIndex = 4;
            BtnCrearCuenta.Text = "Crear Cuenta";
            BtnCrearCuenta.UseVisualStyleBackColor = true;
            BtnCrearCuenta.Click += crearCuentaClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(346, 238);
            button1.Name = "button1";
            button1.Size = new Size(183, 42);
            button1.TabIndex = 5;
            button1.Text = "Depositar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += depositarClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(535, 238);
            button2.Name = "button2";
            button2.Size = new Size(183, 42);
            button2.TabIndex = 6;
            button2.Text = "Retirar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += retirarClick;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(346, 21);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.Size = new Size(372, 202);
            BankAccountGrid.TabIndex = 7;
            // 
            // AmountNum
            // 
            AmountNum.Font = new Font("Segoe UI", 16F);
            AmountNum.Location = new Point(128, 244);
            AmountNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(183, 36);
            AmountNum.TabIndex = 8;
            // 
            // inputName
            // 
            inputName.Font = new Font("Segoe UI", 14F);
            inputName.Location = new Point(114, 21);
            inputName.Name = "inputName";
            inputName.Size = new Size(183, 32);
            inputName.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 304);
            Controls.Add(inputName);
            Controls.Add(AmountNum);
            Controls.Add(BankAccountGrid);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnCrearCuenta);
            Controls.Add(cantidaLabel);
            Controls.Add(nombreLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label nombreLabel;
        private Label cantidaLabel;
        private Button BtnCrearCuenta;
        private Button button1;
        private Button button2;
        private DataGridView BankAccountGrid;
        private NumericUpDown AmountNum;
        private TextBox inputName;
    }
}
