namespace pedra__papel__tesoura_visual
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
            buttonpedra = new Button();
            buttonpapel = new Button();
            buttontesoura = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonpedra
            // 
            buttonpedra.Location = new Point(120, 96);
            buttonpedra.Name = "buttonpedra";
            buttonpedra.Size = new Size(112, 34);
            buttonpedra.TabIndex = 0;
            buttonpedra.Text = "Pedra";
            buttonpedra.UseVisualStyleBackColor = true;
            buttonpedra.Click += buttonpedra_Click;
            // 
            // buttonpapel
            // 
            buttonpapel.Location = new Point(252, 96);
            buttonpapel.Name = "buttonpapel";
            buttonpapel.Size = new Size(112, 34);
            buttonpapel.TabIndex = 1;
            buttonpapel.Text = "Papel";
            buttonpapel.UseVisualStyleBackColor = true;
            buttonpapel.Click += buttonpapel_Click;
            // 
            // buttontesoura
            // 
            buttontesoura.Location = new Point(383, 96);
            buttontesoura.Name = "buttontesoura";
            buttontesoura.Size = new Size(112, 34);
            buttontesoura.TabIndex = 2;
            buttontesoura.Text = "Tesoura";
            buttontesoura.UseVisualStyleBackColor = true;
            buttontesoura.Click += buttontesoura_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 31);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 55);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 5;
            label1.Text = "Escolha as opções abaixo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 222);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 179);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(328, 31);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(252, 268);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 9;
            label4.Text = "Resultado";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 139);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 10;
            label5.Text = "Escolha do Usúario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 219);
            label6.Name = "label6";
            label6.Size = new Size(205, 25);
            label6.TabIndex = 11;
            label6.Text = "Escolha do Computador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttontesoura);
            Controls.Add(buttonpapel);
            Controls.Add(buttonpedra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonpedra;
        private Button buttonpapel;
        private Button buttontesoura;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}