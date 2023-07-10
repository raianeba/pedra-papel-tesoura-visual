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
            textBox1.Location = new Point(202, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 216);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}