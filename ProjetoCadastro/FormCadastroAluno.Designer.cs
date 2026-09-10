namespace ProjetoCadastro
{
    partial class FormCadastroAluno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            buttonSave = new ReaLTaiizor.Controls.MaterialButton();
            buttonCancel = new ReaLTaiizor.Controls.MaterialButton();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            buttonExclude = new ReaLTaiizor.Controls.MaterialButton();
            buttonEditar = new ReaLTaiizor.Controls.MaterialButton();
            buttonNew = new ReaLTaiizor.Controls.MaterialButton();
            livAlunos = new ListView();
            imageList = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.ImageList = imageList;
            TabControlCadastro.Location = new Point(6, 81);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(522, 580);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(buttonSave);
            tabPageCadastro.Controls.Add(buttonCancel);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtEstado);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtData);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.ImageKey = "registered.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(514, 545);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonSave.Depth = 0;
            buttonSave.HighEmphasis = true;
            buttonSave.Icon = null;
            buttonSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonSave.Location = new Point(407, 491);
            buttonSave.Margin = new Padding(4, 6, 4, 6);
            buttonSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonSave.Name = "buttonSave";
            buttonSave.NoAccentTextColor = Color.Empty;
            buttonSave.Size = new Size(91, 45);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "SALVAR";
            buttonSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonSave.UseAccentColor = false;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonCancel.Depth = 0;
            buttonCancel.HighEmphasis = true;
            buttonCancel.Icon = null;
            buttonCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonCancel.Location = new Point(283, 491);
            buttonCancel.Margin = new Padding(4, 6, 4, 6);
            buttonCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.NoAccentTextColor = Color.Empty;
            buttonCancel.Size = new Size(116, 45);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "CANCELAR";
            buttonCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonCancel.UseAccentColor = false;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            txtSenha.Location = new Point(6, 395);
            txtSenha.MaxLength = 8;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(312, 60);
            txtSenha.TabIndex = 8;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // txtEstado
            // 
            txtEstado.AutoResize = false;
            txtEstado.BackColor = Color.FromArgb(255, 255, 255);
            txtEstado.Depth = 0;
            txtEstado.DrawMode = DrawMode.OwnerDrawVariable;
            txtEstado.DropDownHeight = 218;
            txtEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.DropDownWidth = 121;
            txtEstado.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtEstado.FormattingEnabled = true;
            txtEstado.Hint = "Estado";
            txtEstado.IntegralHeight = false;
            txtEstado.ItemHeight = 54;
            txtEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txtEstado.Location = new Point(347, 306);
            txtEstado.MaxDropDownItems = 4;
            txtEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(151, 60);
            txtEstado.StartIndex = 0;
            txtEstado.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(6, 306);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(312, 60);
            txtCidade.TabIndex = 6;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(6, 204);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(312, 60);
            txtBairro.TabIndex = 5;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(6, 138);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(312, 60);
            txtEndereco.TabIndex = 4;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtData
            // 
            txtData.AllowPromptAsInput = true;
            txtData.AnimateReadOnly = false;
            txtData.AsciiOnly = false;
            txtData.BackgroundImageLayout = ImageLayout.None;
            txtData.BeepOnError = false;
            txtData.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtData.Depth = 0;
            txtData.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtData.HidePromptOnLeave = false;
            txtData.HideSelection = true;
            txtData.Hint = "Data de Nascimento";
            txtData.InsertKeyMode = InsertKeyMode.Default;
            txtData.LeadingIcon = null;
            txtData.Location = new Point(324, 6);
            txtData.Mask = "99/99/9999";
            txtData.MaxLength = 32767;
            txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.PrefixSuffixText = null;
            txtData.PromptChar = '_';
            txtData.ReadOnly = false;
            txtData.RejectInputOnFirstFailure = false;
            txtData.ResetOnPrompt = true;
            txtData.ResetOnSpace = true;
            txtData.RightToLeft = RightToLeft.No;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.ShortcutsEnabled = true;
            txtData.Size = new Size(174, 60);
            txtData.SkipLiterals = true;
            txtData.TabIndex = 3;
            txtData.TabStop = false;
            txtData.Text = "  /  /";
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            txtData.ValidatingType = null;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 72);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(312, 60);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matrícula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(6, 6);
            txtMatricula.MaxLength = 9;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(312, 60);
            txtMatricula.TabIndex = 1;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(buttonExclude);
            tabPageConsulta.Controls.Add(buttonEditar);
            tabPageConsulta.Controls.Add(buttonNew);
            tabPageConsulta.Controls.Add(livAlunos);
            tabPageConsulta.ImageKey = "lupa.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(514, 545);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // buttonExclude
            // 
            buttonExclude.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonExclude.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonExclude.Depth = 0;
            buttonExclude.HighEmphasis = true;
            buttonExclude.Icon = null;
            buttonExclude.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonExclude.Location = new Point(408, 479);
            buttonExclude.Margin = new Padding(4, 6, 4, 6);
            buttonExclude.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonExclude.Name = "buttonExclude";
            buttonExclude.NoAccentTextColor = Color.Empty;
            buttonExclude.Size = new Size(96, 45);
            buttonExclude.TabIndex = 3;
            buttonExclude.Text = "EXCLUIR";
            buttonExclude.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonExclude.UseAccentColor = false;
            buttonExclude.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEditar.Depth = 0;
            buttonEditar.HighEmphasis = true;
            buttonEditar.Icon = null;
            buttonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonEditar.Location = new Point(315, 479);
            buttonEditar.Margin = new Padding(4, 6, 4, 6);
            buttonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonEditar.Name = "buttonEditar";
            buttonEditar.NoAccentTextColor = Color.Empty;
            buttonEditar.Size = new Size(85, 45);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "EDITAR";
            buttonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEditar.UseAccentColor = false;
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            buttonNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNew.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonNew.Depth = 0;
            buttonNew.HighEmphasis = true;
            buttonNew.Icon = null;
            buttonNew.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonNew.Location = new Point(217, 479);
            buttonNew.Margin = new Padding(4, 6, 4, 6);
            buttonNew.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonNew.Name = "buttonNew";
            buttonNew.NoAccentTextColor = Color.Empty;
            buttonNew.Size = new Size(80, 45);
            buttonNew.TabIndex = 1;
            buttonNew.Text = "NOVO";
            buttonNew.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonNew.UseAccentColor = false;
            buttonNew.UseVisualStyleBackColor = true;
            // 
            // livAlunos
            // 
            livAlunos.Dock = DockStyle.Top;
            livAlunos.Location = new Point(3, 3);
            livAlunos.Name = "livAlunos";
            livAlunos.Size = new Size(508, 441);
            livAlunos.TabIndex = 0;
            livAlunos.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "lupa.png");
            imageList.Images.SetKeyName(1, "registered.png");
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 667);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "FormCadastroAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastroAluno";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialComboBox txtEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialButton buttonSave;
        private ReaLTaiizor.Controls.MaterialButton buttonCancel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialButton buttonExclude;
        private ReaLTaiizor.Controls.MaterialButton buttonEditar;
        private ReaLTaiizor.Controls.MaterialButton buttonNew;
        private ListView livAlunos;
    }
}