namespace Inscricoes
{
    partial class Alunos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_alunoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_de_nascimentoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alunos));
            this.database1DataSet = new Inscricoes.Database1DataSet();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new Inscricoes.Database1DataSetTableAdapters.AlunosTableAdapter();
            this.tableAdapterManager = new Inscricoes.Database1DataSetTableAdapters.TableAdapterManager();
            this.alunosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alunosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_alunoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_de_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            id_alunoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_de_nascimentoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).BeginInit();
            this.alunosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_alunoLabel
            // 
            id_alunoLabel.AutoSize = true;
            id_alunoLabel.Location = new System.Drawing.Point(43, 105);
            id_alunoLabel.Name = "id_alunoLabel";
            id_alunoLabel.Size = new System.Drawing.Size(57, 16);
            id_alunoLabel.TabIndex = 1;
            id_alunoLabel.Text = "id aluno:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(43, 133);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // data_de_nascimentoLabel
            // 
            data_de_nascimentoLabel.AutoSize = true;
            data_de_nascimentoLabel.Location = new System.Drawing.Point(43, 164);
            data_de_nascimentoLabel.Name = "data_de_nascimentoLabel";
            data_de_nascimentoLabel.Size = new System.Drawing.Size(130, 16);
            data_de_nascimentoLabel.TabIndex = 5;
            data_de_nascimentoLabel.Text = "Data de nascimento:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(43, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "email:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(43, 217);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(58, 16);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "telefone:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.database1DataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inscricoes.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunosBindingNavigator
            // 
            this.alunosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunosBindingNavigator.BindingSource = this.alunosBindingSource;
            this.alunosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.alunosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alunosBindingNavigatorSaveItem});
            this.alunosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alunosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunosBindingNavigator.Name = "alunosBindingNavigator";
            this.alunosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunosBindingNavigator.Size = new System.Drawing.Size(677, 27);
            this.alunosBindingNavigator.TabIndex = 0;
            this.alunosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // alunosBindingNavigatorSaveItem
            // 
            this.alunosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosBindingNavigatorSaveItem.Image")));
            this.alunosBindingNavigatorSaveItem.Name = "alunosBindingNavigatorSaveItem";
            this.alunosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.alunosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.alunosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunosBindingNavigatorSaveItem_Click);
            // 
            // id_alunoTextBox
            // 
            this.id_alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "id_aluno", true));
            this.id_alunoTextBox.Location = new System.Drawing.Point(179, 102);
            this.id_alunoTextBox.Name = "id_alunoTextBox";
            this.id_alunoTextBox.Size = new System.Drawing.Size(342, 22);
            this.id_alunoTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(179, 130);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(342, 22);
            this.nomeTextBox.TabIndex = 4;
            // 
            // data_de_nascimentoDateTimePicker
            // 
            this.data_de_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunosBindingSource, "Data de nascimento", true));
            this.data_de_nascimentoDateTimePicker.Location = new System.Drawing.Point(179, 158);
            this.data_de_nascimentoDateTimePicker.Name = "data_de_nascimentoDateTimePicker";
            this.data_de_nascimentoDateTimePicker.Size = new System.Drawing.Size(342, 22);
            this.data_de_nascimentoDateTimePicker.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(179, 186);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(342, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(179, 214);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(342, 22);
            this.telefoneTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_alunoLabel);
            this.Controls.Add(this.id_alunoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_de_nascimentoLabel);
            this.Controls.Add(this.data_de_nascimentoDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.alunosBindingNavigator);
            this.Name = "Alunos";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).EndInit();
            this.alunosBindingNavigator.ResumeLayout(false);
            this.alunosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private Database1DataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alunosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_alunoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_de_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Button button1;
    }
}