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
        public string alunosFileName = "alunos.txt";
        public bool isAlteracao = false;
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        #region Eventos do Form
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario()) // método de validação
            {
                Save(); // método para salver em arq.txt
                TabControlCadastro.SelectedIndex = 1; // muda para segunda página
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
        #endregion
        }
        private void Save()
        {
            var recordLine = $"{txtMatricula.Text};{txtData.Text};{txtEndereco.Text};" +
                             $"{txtBairro.Text};{txtCidade.Text};{txtSenha.Text}";
            if (!isAlteracao) // novo registro
            {
                var file = new StreamWriter(alunosFileName, true);
                file.WriteLine(recordLine);
                file.Close();
            }
            else // alteração de registro existente
            {

            }
        }
    }
}
