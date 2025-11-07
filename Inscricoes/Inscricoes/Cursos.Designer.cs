namespace Inscricoes
{
    partial class Cursos
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
            System.Windows.Forms.Label id_cursoLabel;
            System.Windows.Forms.Label nome_cursoLabel;
            System.Windows.Forms.Label duração_mesesLabel;
            System.Windows.Forms.Label preçoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.database1DataSet = new Inscricoes.Database1DataSet();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Inscricoes.Database1DataSetTableAdapters.CursoTableAdapter();
            this.tableAdapterManager = new Inscricoes.Database1DataSetTableAdapters.TableAdapterManager();
            this.cursoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cursoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_cursoTextBox = new System.Windows.Forms.TextBox();
            this.nome_cursoTextBox = new System.Windows.Forms.TextBox();
            this.duração_mesesTextBox = new System.Windows.Forms.TextBox();
            this.preçoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            id_cursoLabel = new System.Windows.Forms.Label();
            nome_cursoLabel = new System.Windows.Forms.Label();
            duração_mesesLabel = new System.Windows.Forms.Label();
            preçoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).BeginInit();
            this.cursoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_cursoLabel
            // 
            id_cursoLabel.AutoSize = true;
            id_cursoLabel.Location = new System.Drawing.Point(92, 104);
            id_cursoLabel.Name = "id_cursoLabel";
            id_cursoLabel.Size = new System.Drawing.Size(57, 16);
            id_cursoLabel.TabIndex = 1;
            id_cursoLabel.Text = "Id curso:";
            // 
            // nome_cursoLabel
            // 
            nome_cursoLabel.AutoSize = true;
            nome_cursoLabel.Location = new System.Drawing.Point(92, 132);
            nome_cursoLabel.Name = "nome_cursoLabel";
            nome_cursoLabel.Size = new System.Drawing.Size(80, 16);
            nome_cursoLabel.TabIndex = 3;
            nome_cursoLabel.Text = "nome curso:";
            // 
            // duração_mesesLabel
            // 
            duração_mesesLabel.AutoSize = true;
            duração_mesesLabel.Location = new System.Drawing.Point(92, 160);
            duração_mesesLabel.Name = "duração_mesesLabel";
            duração_mesesLabel.Size = new System.Drawing.Size(104, 16);
            duração_mesesLabel.TabIndex = 5;
            duração_mesesLabel.Text = "duração meses:";
            // 
            // preçoLabel
            // 
            preçoLabel.AutoSize = true;
            preçoLabel.Location = new System.Drawing.Point(92, 188);
            preçoLabel.Name = "preçoLabel";
            preçoLabel.Size = new System.Drawing.Size(45, 16);
            preçoLabel.TabIndex = 7;
            preçoLabel.Text = "preço:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.database1DataSet;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = this.cursoTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inscricoes.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursoBindingNavigator
            // 
            this.cursoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursoBindingNavigator.BindingSource = this.cursoBindingSource;
            this.cursoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cursoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cursoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cursoBindingNavigatorSaveItem});
            this.cursoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursoBindingNavigator.Name = "cursoBindingNavigator";
            this.cursoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursoBindingNavigator.Size = new System.Drawing.Size(653, 27);
            this.cursoBindingNavigator.TabIndex = 0;
            this.cursoBindingNavigator.Text = "bindingNavigator1";
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
            // cursoBindingNavigatorSaveItem
            // 
            this.cursoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursoBindingNavigatorSaveItem.Image")));
            this.cursoBindingNavigatorSaveItem.Name = "cursoBindingNavigatorSaveItem";
            this.cursoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cursoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cursoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursoBindingNavigatorSaveItem_Click);
            // 
            // id_cursoTextBox
            // 
            this.id_cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Id_curso", true));
            this.id_cursoTextBox.Location = new System.Drawing.Point(202, 101);
            this.id_cursoTextBox.Name = "id_cursoTextBox";
            this.id_cursoTextBox.Size = new System.Drawing.Size(277, 22);
            this.id_cursoTextBox.TabIndex = 2;
            // 
            // nome_cursoTextBox
            // 
            this.nome_cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "nome_curso", true));
            this.nome_cursoTextBox.Location = new System.Drawing.Point(202, 129);
            this.nome_cursoTextBox.Name = "nome_cursoTextBox";
            this.nome_cursoTextBox.Size = new System.Drawing.Size(277, 22);
            this.nome_cursoTextBox.TabIndex = 4;
            // 
            // duração_mesesTextBox
            // 
            this.duração_mesesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "duração_meses", true));
            this.duração_mesesTextBox.Location = new System.Drawing.Point(202, 157);
            this.duração_mesesTextBox.Name = "duração_mesesTextBox";
            this.duração_mesesTextBox.Size = new System.Drawing.Size(277, 22);
            this.duração_mesesTextBox.TabIndex = 6;
            // 
            // preçoTextBox
            // 
            this.preçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "preço", true));
            this.preçoTextBox.Location = new System.Drawing.Point(202, 185);
            this.preçoTextBox.Name = "preçoTextBox";
            this.preçoTextBox.Size = new System.Drawing.Size(277, 22);
            this.preçoTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_cursoLabel);
            this.Controls.Add(this.id_cursoTextBox);
            this.Controls.Add(nome_cursoLabel);
            this.Controls.Add(this.nome_cursoTextBox);
            this.Controls.Add(duração_mesesLabel);
            this.Controls.Add(this.duração_mesesTextBox);
            this.Controls.Add(preçoLabel);
            this.Controls.Add(this.preçoTextBox);
            this.Controls.Add(this.cursoBindingNavigator);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).EndInit();
            this.cursoBindingNavigator.ResumeLayout(false);
            this.cursoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private Database1DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cursoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cursoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_cursoTextBox;
        private System.Windows.Forms.TextBox nome_cursoTextBox;
        private System.Windows.Forms.TextBox duração_mesesTextBox;
        private System.Windows.Forms.TextBox preçoTextBox;
        private System.Windows.Forms.Button button1;
    }
}