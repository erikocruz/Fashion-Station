using BL.Fashion;
using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormTblTiposPersonas : Form
    {
        
        TblTiposPersonasBL _tipospersonas;

        public FormTblTiposPersonas()
        {
            InitializeComponent();

            _tipospersonas = new TblTiposPersonasBL();
            listaTblTiposPersonasBindingSource.DataSource = _tipospersonas.ObtenerTblTiposPersonas();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTblTiposPersonas));
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idLabel;
            this.listaTblTiposPersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTblTiposPersonasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listaTblTiposPersonasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            descripcionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblTiposPersonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblTiposPersonasBindingNavigator)).BeginInit();
            this.listaTblTiposPersonasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaTblTiposPersonasBindingSource
            // 
            this.listaTblTiposPersonasBindingSource.DataSource = typeof(BL.Fashion.TblTipoPersona);
            // 
            // listaTiposPersonasBindingNavigator
            // 
            this.listaTblTiposPersonasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaTblTiposPersonasBindingNavigator.BindingSource = this.listaTblTiposPersonasBindingSource;
            this.listaTblTiposPersonasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaTblTiposPersonasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaTblTiposPersonasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaTblTiposPersonasBindingNavigatorSaveItem});
            this.listaTblTiposPersonasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaTblTiposPersonasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaTblTiposPersonasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaTblTiposPersonasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaTblTiposPersonasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaTblTiposPersonasBindingNavigator.Name = "listaTblTiposPersonasBindingNavigator";
            this.listaTblTiposPersonasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaTblTiposPersonasBindingNavigator.Size = new System.Drawing.Size(437, 25);
            this.listaTblTiposPersonasBindingNavigator.TabIndex = 0;
            this.listaTblTiposPersonasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaTblTiposPersonasBindingNavigatorSaveItem
            // 
            this.listaTblTiposPersonasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaTblTiposPersonasBindingNavigatorSaveItem.Enabled = false;
            this.listaTblTiposPersonasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaTblTiposPersonasBindingNavigatorSaveItem.Image")));
            this.listaTblTiposPersonasBindingNavigatorSaveItem.Name = "listaTblTiposPersonasBindingNavigatorSaveItem";
            this.listaTblTiposPersonasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaTblTiposPersonasBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(89, 95);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTblTiposPersonasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(161, 92);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(89, 121);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTblTiposPersonasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(161, 118);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // FormTiposPersonas
            // 
            this.ClientSize = new System.Drawing.Size(437, 272);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.listaTblTiposPersonasBindingNavigator);
            this.Name = "FormTblTiposPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.listaTblTiposPersonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblTiposPersonasBindingNavigator)).EndInit();
            this.listaTblTiposPersonasBindingNavigator.ResumeLayout(false);
            this.listaTblTiposPersonasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
