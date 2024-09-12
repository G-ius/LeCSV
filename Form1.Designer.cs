namespace LeCSV
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
            path_tb = new TextBox();
            btn_seletor = new Button();
            caminho = new Label();
            data_table = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            seletor_filtro = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)data_table).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // path_tb
            // 
            path_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            path_tb.Location = new Point(110, 31);
            path_tb.Name = "path_tb";
            path_tb.ReadOnly = true;
            path_tb.Size = new Size(678, 23);
            path_tb.TabIndex = 0;
            // 
            // btn_seletor
            // 
            btn_seletor.Location = new Point(12, 12);
            btn_seletor.Name = "btn_seletor";
            btn_seletor.Size = new Size(92, 42);
            btn_seletor.TabIndex = 1;
            btn_seletor.Text = "Selecione o arquivo CSV";
            btn_seletor.UseVisualStyleBackColor = true;
            btn_seletor.Click += button1_Click;
            // 
            // caminho
            // 
            caminho.AutoSize = true;
            caminho.ForeColor = SystemColors.ControlLightLight;
            caminho.Location = new Point(109, 13);
            caminho.Name = "caminho";
            caminho.Size = new Size(119, 15);
            caminho.TabIndex = 2;
            caminho.Text = "Caminho do arquivo:";
            // 
            // data_table
            // 
            data_table.AllowUserToAddRows = false;
            data_table.AllowUserToDeleteRows = false;
            data_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data_table.BackgroundColor = SystemColors.ButtonHighlight;
            data_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_table.Location = new Point(12, 145);
            data_table.Name = "data_table";
            data_table.Size = new Size(776, 293);
            data_table.TabIndex = 3;
            data_table.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(seletor_filtro);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 68);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(418, 19);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 8;
            label2.Text = "Valor à filtrar:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(418, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(97, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Filtro:";
            // 
            // seletor_filtro
            // 
            seletor_filtro.FormattingEnabled = true;
            seletor_filtro.Location = new Point(98, 37);
            seletor_filtro.Name = "seletor_filtro";
            seletor_filtro.Size = new Size(232, 23);
            seletor_filtro.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(678, 13);
            button1.Name = "button1";
            button1.Size = new Size(92, 47);
            button1.TabIndex = 5;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(data_table);
            Controls.Add(caminho);
            Controls.Add(btn_seletor);
            Controls.Add(path_tb);
            Name = "Form1";
            Text = "Eu leio csv";
            ((System.ComponentModel.ISupportInitialize)data_table).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox path_tb;
        private Button btn_seletor;
        private Label caminho;
        private DataGridView data_table;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox seletor_filtro;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}
