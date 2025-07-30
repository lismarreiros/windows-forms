namespace DesafioFocare1
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
            idadeLabel = new Label();
            sexoLabel = new Label();
            adicionarButton = new Button();
            idadeTextBox = new TextBox();
            sexoTextBox = new TextBox();
            pessoasListView = new ListView();
            filtrarLabel = new Label();
            McheckBox = new CheckBox();
            FcheckBox = new CheckBox();
            SuspendLayout();
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new Point(10, 20);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new Size(39, 15);
            idadeLabel.TabIndex = 0;
            idadeLabel.Text = "Idade:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new Point(126, 20);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new Size(34, 15);
            sexoLabel.TabIndex = 1;
            sexoLabel.Text = "Sexo:";
            // 
            // adicionarButton
            // 
            adicionarButton.Location = new Point(265, 38);
            adicionarButton.Name = "adicionarButton";
            adicionarButton.Size = new Size(75, 23);
            adicionarButton.TabIndex = 2;
            adicionarButton.Text = "Adicionar";
            adicionarButton.UseVisualStyleBackColor = true;
            adicionarButton.Click += adicionarButton_Click;
            // 
            // idadeTextBox
            // 
            idadeTextBox.Location = new Point(12, 38);
            idadeTextBox.Name = "idadeTextBox";
            idadeTextBox.Size = new Size(100, 23);
            idadeTextBox.TabIndex = 3;
            idadeTextBox.TextChanged += idadeTextBox_TextChanged;
            // 
            // sexoTextBox
            // 
            sexoTextBox.Location = new Point(127, 38);
            sexoTextBox.Name = "sexoTextBox";
            sexoTextBox.PlaceholderText = "'M' ou 'F'";
            sexoTextBox.Size = new Size(100, 23);
            sexoTextBox.TabIndex = 4;
            sexoTextBox.TextChanged += sexoTextBox_TextChanged;
            // 
            // pessoasListView
            // 
            pessoasListView.Location = new Point(10, 103);
            pessoasListView.Name = "pessoasListView";
            pessoasListView.Size = new Size(405, 223);
            pessoasListView.TabIndex = 5;
            pessoasListView.UseCompatibleStateImageBehavior = false;
            // 
            // filtrarLabel
            // 
            filtrarLabel.AutoSize = true;
            filtrarLabel.Location = new Point(12, 78);
            filtrarLabel.Name = "filtrarLabel";
            filtrarLabel.Size = new Size(40, 15);
            filtrarLabel.TabIndex = 6;
            filtrarLabel.Text = "Filtrar:";
            // 
            // McheckBox
            // 
            McheckBox.AutoSize = true;
            McheckBox.Location = new Point(75, 78);
            McheckBox.Name = "McheckBox";
            McheckBox.Size = new Size(37, 19);
            McheckBox.TabIndex = 7;
            McheckBox.Text = "M";
            McheckBox.UseVisualStyleBackColor = true;
            McheckBox.CheckedChanged += McheckBox_CheckedChanged;
            // 
            // FcheckBox
            // 
            FcheckBox.AutoSize = true;
            FcheckBox.Location = new Point(125, 78);
            FcheckBox.Name = "FcheckBox";
            FcheckBox.Size = new Size(32, 19);
            FcheckBox.TabIndex = 8;
            FcheckBox.Text = "F";
            FcheckBox.UseVisualStyleBackColor = true;
            FcheckBox.CheckedChanged += FcheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 338);
            Controls.Add(FcheckBox);
            Controls.Add(McheckBox);
            Controls.Add(filtrarLabel);
            Controls.Add(pessoasListView);
            Controls.Add(sexoTextBox);
            Controls.Add(idadeTextBox);
            Controls.Add(adicionarButton);
            Controls.Add(sexoLabel);
            Controls.Add(idadeLabel);
            Name = "Form1";
            Text = "Formulário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idadeLabel;
        private Label sexoLabel;
        private Button adicionarButton;
        private TextBox idadeTextBox;
        private TextBox sexoTextBox;
        private ListView pessoasListView;
        private Label filtrarLabel;
        private CheckBox McheckBox;
        private CheckBox FcheckBox;
    }
}
