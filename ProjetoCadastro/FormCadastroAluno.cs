using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroAluno : MaterialForm
    {
        #region Variáveis
        public string alunosFileName = "alunos.txt";
        public bool isAlteracao = false;
        public int indexSelecionado = 0;
        #endregion

        #region Construtor
        public FormCadastroAluno()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos do Form
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario()) // método de validação
            {
                Save(); // método para salver em arq.txt
                TabControlCadastro.SelectedIndex = 1; // muda para segunda página
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void livAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Atenção: Informações não salvas serão perdidas.\nDeseja cancelar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (resposta)
            {
                LimparCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TabControlCadastro.SelectedIndex = 0;
        }
        private void buttonExclude_Click(object sender, EventArgs e)
        {
            if (livAlunos.SelectedIndices.Count > 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir o aluno selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (resposta)
                {
                    indexSelecionado = livAlunos.SelectedItems[0].Index;
                    Excluir();
                    CarregarListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        #endregion 

        #region Métodos
        private bool ValidaFormulario()
        {
            var erro = string.Empty;
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                erro += "Matricula Obrigatoria\n";
            }
            if (!DateTime.TryParse(txtData.Text, out _))
            {
                erro += "Data Invalida\n";
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                erro += "Endereço Obrigatorio\n";
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                erro += "Bairro Obrigatorio\n";
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                erro += "Cidade Obrigatoria\n";
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                erro += "Senha Obrigatória\n";
            }
            if (string.IsNullOrEmpty(erro))
            {
                return true;
            }
            else
            {
                MessageBox.Show(erro, "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }
        private void Save()
        {
            var recordLine = $"{txtMatricula.Text};{txtData.Text};{txtNome.Text};{txtEndereco.Text};" +
                             $"{txtBairro.Text};{txtCidade.Text};{txtEstado.Text};{txtSenha.Text}";
            if (!isAlteracao) // novo registro
            {
                var file = new StreamWriter(alunosFileName, true);
                file.WriteLine(recordLine);
                file.Close();
            }
            else // alteração de registro existente
            {
                var alunos = File.ReadAllLines(alunosFileName);
                alunos[indexSelecionado] = recordLine;
                File.WriteAllLines(alunosFileName, alunos);
            }
        }
        private void CarregarListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            livAlunos.View = View.Details;
            livAlunos.FullRowSelect = true;
            livAlunos.Items.Clear();
            livAlunos.Columns.Clear();
            livAlunos.Columns.Add("Prontuário");
            livAlunos.Columns.Add("Nascimento");
            livAlunos.Columns.Add("Nome");
            livAlunos.Columns.Add("Endereço");
            livAlunos.Columns.Add("Bairro");
            livAlunos.Columns.Add("Cidade");
            livAlunos.Columns.Add("Estado");
            var alunos = File.ReadAllLines(alunosFileName);
            foreach (var line in alunos)
            {
                var campos = line.Split(';');
                livAlunos.Items.Add(new ListViewItem(campos));
            }
            livAlunos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            Cursor.Current = Cursors.Default;
        }


        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregarListView();
        }
        private void Editar()
        {
            if (livAlunos.SelectedIndices.Count > 0)
            {
                indexSelecionado = livAlunos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = livAlunos.SelectedItems[0];
                txtMatricula.Text = item.SubItems[0].Text;
                txtData.Text = item.SubItems[1].Text;
                txtNome.Text = item.SubItems[2].Text;
                txtEndereco.Text = item.SubItems[3].Text;
                txtBairro.Text = item.SubItems[4].Text;
                txtCidade.Text = item.SubItems[5].Text;
                txtEstado.Text = item.SubItems[6].Text;
                txtSenha.Text = item.SubItems[7].Text;
                TabControlCadastro.SelectedIndex = 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimparCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
        private void Excluir()
        {
            if (livAlunos.SelectedIndices.Count > 0)
            {
                var alunos = File.ReadAllLines(alunosFileName).ToList();
                alunos.RemoveAt(indexSelecionado);
                File.WriteAllLines(alunosFileName, alunos);
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion





        
    }
}
