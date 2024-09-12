using System.Data;

namespace LeCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecionaArquivo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Se o arquivo CSV não foi selecionado, seleciona o arquivo
            if (path_tb.Text == "")
            {
                selecionaArquivo();
            }

            //verifica se existe algum item selecionado no seletor_filtro
            if (seletor_filtro.SelectedItem != null)
            {
                //descobre o indice da coluna selecionada
                int columnIndex = data_table.Columns[seletor_filtro.SelectedItem.ToString()].Index;

                //obte o valor digitado na textBox1
                string filtro = textBox1.Text;

                //Verficica se o filtro está vazio, se estiver, mostra todas as linhas
                if (filtro == "")
                {
                    foreach (DataGridViewRow row in data_table.Rows)
                    {
                        row.Visible = true;
                    }
                    return;
                }


                //seleciona no dataset do data_table as linhas que contém o valor digitado na coluna selecionada
                foreach (DataGridViewRow row in data_table.Rows)
                {
                    

                    if (row.Cells[columnIndex].Value.ToString().Contains(filtro))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        try
                        {
                            row.Visible = false;
                        }catch (Exception)
                        {
                            //Ignora exceção
                        }
                    }
                }
            }
        }

        private void selecionaArquivo()
        {
            //Abre um seletor de arquivo, que busca um arquivo CSV e coloca o caminho no path_tb
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV Files|*.csv";
            openFile.Title = "Selecione o arquivo CSV";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path_tb.Text = openFile.FileName;

                //Lê o arquivo CSV e coloca no data_table, criando coluna nova para cada propriedade dos elementos do arquivo CSV
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(openFile.FileName);
                if (lines.Length > 0)
                {
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        //Cria uma coluna para cada propriedade dos elementos do arquivo CSV
                        dt.Columns.Add(new DataColumn(headerWord));

                        //Cria um item no combobox para cada propriedade dos elementos do arquivo CSV
                        seletor_filtro.Items.Add(headerWord);
                    }
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                }

                //Atualiza o datasource do data_table para mostrar os dados
                data_table.DataSource = dt;



            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
