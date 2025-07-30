namespace DesafioFocare1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }

        private List<Pessoa> pessoas = new List<Pessoa>();

        private void Form1_Load(object sender, EventArgs e)
        {
            pessoasListView.View = View.Details;
            pessoasListView.FullRowSelect = true;
            pessoasListView.GridLines = true;
            pessoasListView.Columns.Add("Idade", 50, HorizontalAlignment.Center);
            pessoasListView.Columns.Add("Sexo", -2, HorizontalAlignment.Left);
        }

        private void sexoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            int idade;
            string sexo;


            if (string.IsNullOrWhiteSpace(idadeTextBox.Text) || string.IsNullOrWhiteSpace(sexoTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idadeTextBox.Text, out idade) || idade < 0 || idade > 120)
            {
                MessageBox.Show("Idade inválida.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sexoTextBox.Text.ToUpper() != "M" && sexoTextBox.Text.ToUpper() != "F")
            {
                MessageBox.Show("Sexo inválido. Digite apenas 'M' ou 'F'.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sexo = sexoTextBox.Text.ToUpper();

            var pessoa = new Pessoa(idade, sexo);
            pessoas.Add(pessoa);

            ListViewItem lvi = new ListViewItem(pessoa.Idade.ToString());
            lvi.SubItems.Add(pessoa.Sexo);
            pessoasListView.Items.Add(lvi);

            idadeTextBox.Text = string.Empty;
            sexoTextBox.Text = string.Empty;

        }

        private void AdicionarListView(Pessoa p)
        {
            ListViewItem lvi = new ListViewItem(p.Idade.ToString());
            lvi.SubItems.Add(p.Sexo);
            pessoasListView.Items.Add(lvi);
        }

        private void FiltrarListView()
        {
            pessoasListView.Items.Clear();

            if (!FcheckBox.Checked && !McheckBox.Checked)
            {
                foreach (var p in pessoas)
                {
                    AdicionarListView(p);
                }
                return;
            }

            foreach (var p in pessoas)
            {
                if ((McheckBox.Checked && p.Sexo == "M") || (FcheckBox.Checked && p.Sexo == "F"))
                {
                    AdicionarListView(p);
                }
            }


        }

        private void McheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarListView();
        }

        private void FcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarListView();
        }

        private void idadeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FcheckBox.Checked || McheckBox.Checked)
            {
                FiltrarListView();
            }
            
        }
    }
}
