namespace VolumenC
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
            prisma = new Button();
            cili = new Button();
            resultadocili = new Label();
            resultadopris = new Label();
            L = new Label();
            a = new Label();
            h = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            r = new Label();
            textBox4 = new TextBox();
            hh = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 45);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "CALCULO DE: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 121);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "CILINDRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 121);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "PRISMA";
            // 
            // prisma
            // 
            prisma.Location = new Point(549, 273);
            prisma.Name = "prisma";
            prisma.Size = new Size(94, 29);
            prisma.TabIndex = 3;
            prisma.Text = "calcular ";
            prisma.UseVisualStyleBackColor = true;
            prisma.Click += prisma_Click;
            // 
            // cili
            // 
            cili.Location = new Point(124, 273);
            cili.Name = "cili";
            cili.Size = new Size(94, 29);
            cili.TabIndex = 4;
            cili.Text = "calcular ";
            cili.UseVisualStyleBackColor = true;
            cili.Click += cili_Click;
            // 
            // resultadocili
            // 
            resultadocili.AutoSize = true;
            resultadocili.Location = new Point(124, 353);
            resultadocili.Name = "resultadocili";
            resultadocili.Size = new Size(71, 20);
            resultadocili.TabIndex = 5;
            resultadocili.Text = "resultado";
            resultadocili.Click += resultadocili_Click;
            // 
            // resultadopris
            // 
            resultadopris.AutoSize = true;
            resultadopris.Location = new Point(563, 353);
            resultadopris.Name = "resultadopris";
            resultadopris.Size = new Size(71, 20);
            resultadopris.TabIndex = 6;
            resultadopris.Text = "resultado";
            // 
            // L
            // 
            L.AutoSize = true;
            L.Location = new Point(540, 152);
            L.Name = "L";
            L.Size = new Size(16, 20);
            L.TabIndex = 7;
            L.Text = "L";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(540, 181);
            a.Name = "a";
            a.Size = new Size(17, 20);
            a.TabIndex = 8;
            a.Text = "a";
            // 
            // h
            // 
            h.AutoSize = true;
            h.Location = new Point(540, 213);
            h.Name = "h";
            h.Size = new Size(17, 20);
            h.TabIndex = 9;
            h.Text = "h";
            h.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(562, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(563, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(563, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // r
            // 
            r.AutoSize = true;
            r.Location = new Point(105, 159);
            r.Name = "r";
            r.Size = new Size(14, 20);
            r.TabIndex = 13;
            r.Text = "r";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // hh
            // 
            hh.AutoSize = true;
            hh.Location = new Point(105, 203);
            hh.Name = "hh";
            hh.Size = new Size(17, 20);
            hh.TabIndex = 15;
            hh.Text = "h";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 200);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(hh);
            Controls.Add(textBox4);
            Controls.Add(r);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(h);
            Controls.Add(a);
            Controls.Add(L);
            Controls.Add(resultadopris);
            Controls.Add(resultadocili);
            Controls.Add(cili);
            Controls.Add(prisma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button prisma;
        private Button cili;
        private Label resultadocili;
        private Label resultadopris;
        private Label L;
        private Label a;
        private Label h;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label r;
        private TextBox textBox4;
        private Label hh;
        private TextBox textBox5;
    }
}
