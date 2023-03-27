namespace App_WindowsForm_Suma
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
            label3 = new Label();
            text_Numero1 = new TextBox();
            text_Numero2 = new TextBox();
            text_Numero3 = new TextBox();
            txt_Resultado = new TextBox();
            label4 = new Label();
            Sumando = new Button();
            button1 = new Button();
            Salir_Programa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 105);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 171);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 228);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese un numero";
            // 
            // text_Numero1
            // 
            text_Numero1.Location = new Point(265, 98);
            text_Numero1.Name = "text_Numero1";
            text_Numero1.Size = new Size(125, 27);
            text_Numero1.TabIndex = 3;
            // 
            // text_Numero2
            // 
            text_Numero2.Location = new Point(265, 164);
            text_Numero2.Name = "text_Numero2";
            text_Numero2.Size = new Size(125, 27);
            text_Numero2.TabIndex = 4;
            // 
            // text_Numero3
            // 
            text_Numero3.Location = new Point(265, 228);
            text_Numero3.Name = "text_Numero3";
            text_Numero3.Size = new Size(125, 27);
            text_Numero3.TabIndex = 5;
            // 
            // txt_Resultado
            // 
            txt_Resultado.Location = new Point(265, 291);
            txt_Resultado.Name = "txt_Resultado";
            txt_Resultado.Size = new Size(125, 27);
            txt_Resultado.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 298);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Resultado";
            // 
            // Sumando
            // 
            Sumando.Location = new Point(454, 162);
            Sumando.Name = "Sumando";
            Sumando.Size = new Size(167, 39);
            Sumando.TabIndex = 8;
            Sumando.Text = "Sumar";
            Sumando.UseVisualStyleBackColor = true;
            Sumando.Click += Sumando_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(454, 105);
            button1.Name = "button1";
            button1.Size = new Size(167, 37);
            button1.TabIndex = 9;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Salir_Programa
            // 
            Salir_Programa.Location = new Point(454, 228);
            Salir_Programa.Name = "Salir_Programa";
            Salir_Programa.Size = new Size(167, 34);
            Salir_Programa.TabIndex = 10;
            Salir_Programa.Text = "Salir";
            Salir_Programa.UseVisualStyleBackColor = true;
            Salir_Programa.Click += Salir_Programa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 429);
            Controls.Add(Salir_Programa);
            Controls.Add(button1);
            Controls.Add(Sumando);
            Controls.Add(label4);
            Controls.Add(txt_Resultado);
            Controls.Add(text_Numero3);
            Controls.Add(text_Numero2);
            Controls.Add(text_Numero1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_Numero1;
        private TextBox text_Numero2;
        private TextBox text_Numero3;
        private TextBox txt_Resultado;
        private Label label4;
        private Button Sumando;
        private Button button1;
        private Button Salir_Programa;
    }
}