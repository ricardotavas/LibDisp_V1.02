namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_call = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_repeat = new System.Windows.Forms.Button();
            this.button_adjust = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_alpha = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_ticket = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_row = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_mesa = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox_ipserver = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ins = new System.Windows.Forms.Button();
            this.button_exc = new System.Windows.Forms.Button();
            this.button_inf = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_depName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mesa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 398);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(318, 170);
            this.textBox1.TabIndex = 5;
            // 
            // button_call
            // 
            this.button_call.Location = new System.Drawing.Point(13, 179);
            this.button_call.Name = "button_call";
            this.button_call.Size = new System.Drawing.Size(316, 23);
            this.button_call.TabIndex = 7;
            this.button_call.Text = "Clique para exibir chamada especifica no painel";
            this.button_call.UseVisualStyleBackColor = true;
            this.button_call.Click += new System.EventHandler(this.button_call_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(13, 223);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(318, 23);
            this.button_next.TabIndex = 10;
            this.button_next.Text = "Clique para solicitar ao painel chamar o próximo";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_repeat
            // 
            this.button_repeat.Location = new System.Drawing.Point(13, 252);
            this.button_repeat.Name = "button_repeat";
            this.button_repeat.Size = new System.Drawing.Size(318, 23);
            this.button_repeat.TabIndex = 11;
            this.button_repeat.Text = "Clique para repetir a chamada  no painel";
            this.button_repeat.UseVisualStyleBackColor = true;
            this.button_repeat.Click += new System.EventHandler(this.button_repeat_Click);
            // 
            // button_adjust
            // 
            this.button_adjust.Location = new System.Drawing.Point(13, 281);
            this.button_adjust.Name = "button_adjust";
            this.button_adjust.Size = new System.Drawing.Size(316, 23);
            this.button_adjust.TabIndex = 12;
            this.button_adjust.Text = "Clique para ajustar o número da chamada";
            this.button_adjust.UseVisualStyleBackColor = true;
            this.button_adjust.Click += new System.EventHandler(this.button_adjust_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(30, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Comandos para gerenciamento no  painel :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(35, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Comando para chamar número especifico:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_depName);
            this.groupBox2.Controls.Add(this.comboBox_alpha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDown_ticket);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown_row);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_mesa);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(13, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 90);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // comboBox_alpha
            // 
            this.comboBox_alpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_alpha.FormattingEnabled = true;
            this.comboBox_alpha.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox_alpha.Location = new System.Drawing.Point(98, 30);
            this.comboBox_alpha.Name = "comboBox_alpha";
            this.comboBox_alpha.Size = new System.Drawing.Size(52, 21);
            this.comboBox_alpha.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Letra:";
            // 
            // numericUpDown_ticket
            // 
            this.numericUpDown_ticket.Location = new System.Drawing.Point(168, 31);
            this.numericUpDown_ticket.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_ticket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ticket.Name = "numericUpDown_ticket";
            this.numericUpDown_ticket.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_ticket.TabIndex = 56;
            this.numericUpDown_ticket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ticket:";
            // 
            // numericUpDown_row
            // 
            this.numericUpDown_row.Location = new System.Drawing.Point(23, 31);
            this.numericUpDown_row.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_row.Name = "numericUpDown_row";
            this.numericUpDown_row.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_row.TabIndex = 54;
            this.numericUpDown_row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Linha:";
            // 
            // numericUpDown_mesa
            // 
            this.numericUpDown_mesa.Location = new System.Drawing.Point(245, 31);
            this.numericUpDown_mesa.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_mesa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_mesa.Name = "numericUpDown_mesa";
            this.numericUpDown_mesa.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_mesa.TabIndex = 49;
            this.numericUpDown_mesa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Mesa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "IP do Display:";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(205, 16);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 60;
            this.button_apply.Text = "Aplicar";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox_ipserver
            // 
            this.textBox_ipserver.Location = new System.Drawing.Point(99, 18);
            this.textBox_ipserver.Name = "textBox_ipserver";
            this.textBox_ipserver.Size = new System.Drawing.Size(100, 20);
            this.textBox_ipserver.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_ipserver);
            this.groupBox1.Controls.Add(this.button_apply);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 50);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(65, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Comando de chamada de fiscal:";
            // 
            // button_ins
            // 
            this.button_ins.Location = new System.Drawing.Point(13, 325);
            this.button_ins.Name = "button_ins";
            this.button_ins.Size = new System.Drawing.Size(143, 23);
            this.button_ins.TabIndex = 63;
            this.button_ins.Text = "Inserir mesa";
            this.button_ins.UseVisualStyleBackColor = true;
            this.button_ins.Click += new System.EventHandler(this.button_ins_Click);
            // 
            // button_exc
            // 
            this.button_exc.Location = new System.Drawing.Point(186, 325);
            this.button_exc.Name = "button_exc";
            this.button_exc.Size = new System.Drawing.Size(143, 23);
            this.button_exc.TabIndex = 64;
            this.button_exc.Text = "Retirar mesa";
            this.button_exc.UseVisualStyleBackColor = true;
            this.button_exc.Click += new System.EventHandler(this.button_exc_Click);
            // 
            // button_inf
            // 
            this.button_inf.Location = new System.Drawing.Point(100, 369);
            this.button_inf.Name = "button_inf";
            this.button_inf.Size = new System.Drawing.Size(143, 23);
            this.button_inf.TabIndex = 65;
            this.button_inf.Text = "Informação Atendimento";
            this.button_inf.UseVisualStyleBackColor = true;
            this.button_inf.Click += new System.EventHandler(this.button_inf_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(42, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "Comando para leitura de tempo de atd:";
            // 
            // textBox_depName
            // 
            this.textBox_depName.Location = new System.Drawing.Point(125, 57);
            this.textBox_depName.Name = "textBox_depName";
            this.textBox_depName.Size = new System.Drawing.Size(176, 20);
            this.textBox_depName.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Nome atendimento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 583);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_inf);
            this.Controls.Add(this.button_exc);
            this.Controls.Add(this.button_ins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_adjust);
            this.Controls.Add(this.button_repeat);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_call);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mesa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_call;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_repeat;
        private System.Windows.Forms.Button button_adjust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_mesa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_row;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TextBox textBox_ipserver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_ticket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_alpha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ins;
        private System.Windows.Forms.Button button_exc;
        private System.Windows.Forms.Button button_inf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_depName;
    }
}

