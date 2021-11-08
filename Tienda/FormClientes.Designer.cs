using System;

namespace Tienda
{
    partial class FormClientes
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idClaseClteLabel;
            System.Windows.Forms.Label direccPaisIdLabel;
            System.Windows.Forms.Label direccDeptoIdLabel;
            System.Windows.Forms.Label direccMinicipioIdLabel;
            System.Windows.Forms.Label direccSectorBoColIdLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label tel1Label;
            System.Windows.Forms.Label tel2Label;
            System.Windows.Forms.Label email1Label;
            System.Windows.Forms.Label email2Label;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.listaClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.CancelarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaTblClaseCltesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTblDeptosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTblMunicipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClaseClteComboBox = new System.Windows.Forms.ComboBox();
            this.direccPaisIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaTblPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccDeptoIdComboBox = new System.Windows.Forms.ComboBox();
            this.direccMinicipioIdComboBox = new System.Windows.Forms.ComboBox();
            this.direccSectorBoColIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaTblSectorBoColsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.tel1TextBox = new System.Windows.Forms.TextBox();
            this.tel2TextBox = new System.Windows.Forms.TextBox();
            this.email1TextBox = new System.Windows.Forms.TextBox();
            this.email2TextBox = new System.Windows.Forms.TextBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            nombreLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idClaseClteLabel = new System.Windows.Forms.Label();
            direccPaisIdLabel = new System.Windows.Forms.Label();
            direccDeptoIdLabel = new System.Windows.Forms.Label();
            direccMinicipioIdLabel = new System.Windows.Forms.Label();
            direccSectorBoColIdLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            tel1Label = new System.Windows.Forms.Label();
            tel2Label = new System.Windows.Forms.Label();
            email1Label = new System.Windows.Forms.Label();
            email2Label = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingNavigator)).BeginInit();
            this.listaClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblClaseCltesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblDeptosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblMunicipiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblSectorBoColsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(223, 76);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(99, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre del Cliente:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(223, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // idClaseClteLabel
            // 
            idClaseClteLabel.AutoSize = true;
            idClaseClteLabel.Location = new System.Drawing.Point(223, 126);
            idClaseClteLabel.Name = "idClaseClteLabel";
            idClaseClteLabel.Size = new System.Drawing.Size(86, 13);
            idClaseClteLabel.TabIndex = 67;
            idClaseClteLabel.Text = "Clase de Cliente:";
            // 
            // direccPaisIdLabel
            // 
            direccPaisIdLabel.AutoSize = true;
            direccPaisIdLabel.Location = new System.Drawing.Point(223, 163);
            direccPaisIdLabel.Name = "direccPaisIdLabel";
            direccPaisIdLabel.Size = new System.Drawing.Size(101, 13);
            direccPaisIdLabel.TabIndex = 68;
            direccPaisIdLabel.Text = "Pais de Residencia:";
            // 
            // direccDeptoIdLabel
            // 
            direccDeptoIdLabel.AutoSize = true;
            direccDeptoIdLabel.Location = new System.Drawing.Point(223, 188);
            direccDeptoIdLabel.Name = "direccDeptoIdLabel";
            direccDeptoIdLabel.Size = new System.Drawing.Size(77, 13);
            direccDeptoIdLabel.TabIndex = 69;
            direccDeptoIdLabel.Text = "Departamento:";
            // 
            // direccMinicipioIdLabel
            // 
            direccMinicipioIdLabel.AutoSize = true;
            direccMinicipioIdLabel.Location = new System.Drawing.Point(223, 213);
            direccMinicipioIdLabel.Name = "direccMinicipioIdLabel";
            direccMinicipioIdLabel.Size = new System.Drawing.Size(55, 13);
            direccMinicipioIdLabel.TabIndex = 70;
            direccMinicipioIdLabel.Text = "Municipio:";
            // 
            // direccSectorBoColIdLabel
            // 
            direccSectorBoColIdLabel.AutoSize = true;
            direccSectorBoColIdLabel.Location = new System.Drawing.Point(223, 238);
            direccSectorBoColIdLabel.Name = "direccSectorBoColIdLabel";
            direccSectorBoColIdLabel.Size = new System.Drawing.Size(84, 13);
            direccSectorBoColIdLabel.TabIndex = 71;
            direccSectorBoColIdLabel.Text = "Barrio o Colonia:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(223, 264);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 72;
            direccionLabel.Text = "Direccion:";
            // 
            // tel1Label
            // 
            tel1Label.AutoSize = true;
            tel1Label.Location = new System.Drawing.Point(223, 289);
            tel1Label.Name = "tel1Label";
            tel1Label.Size = new System.Drawing.Size(31, 13);
            tel1Label.TabIndex = 73;
            tel1Label.Text = "Tel1:";
            // 
            // tel2Label
            // 
            tel2Label.AutoSize = true;
            tel2Label.Location = new System.Drawing.Point(223, 315);
            tel2Label.Name = "tel2Label";
            tel2Label.Size = new System.Drawing.Size(31, 13);
            tel2Label.TabIndex = 74;
            tel2Label.Text = "Tel2:";
            // 
            // email1Label
            // 
            email1Label.AutoSize = true;
            email1Label.Location = new System.Drawing.Point(488, 289);
            email1Label.Name = "email1Label";
            email1Label.Size = new System.Drawing.Size(45, 13);
            email1Label.TabIndex = 75;
            email1Label.Text = "E-Mail1:";
            // 
            // email2Label
            // 
            email2Label.AutoSize = true;
            email2Label.Location = new System.Drawing.Point(488, 315);
            email2Label.Name = "email2Label";
            email2Label.Size = new System.Drawing.Size(45, 13);
            email2Label.TabIndex = 76;
            email2Label.Text = "E-Mail2:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(223, 100);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(45, 13);
            generoLabel.TabIndex = 77;
            generoLabel.Text = "Genero:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(571, 50);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 78;
            activoLabel.Text = "Activo:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(325, 73);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(329, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataSource = typeof(BL.Fashion.Cliente);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(325, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(132, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.Gray;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaClientesBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(675, 47);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(198, 206);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 11;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(21, 47);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(182, 285);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 19;
            this.LogoPictureBox.TabStop = false;
            // 
            // listaClientesBindingNavigator
            // 
            this.listaClientesBindingNavigator.AddNewItem = null;
            this.listaClientesBindingNavigator.BindingSource = this.listaClientesBindingSource;
            this.listaClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaClientesBindingNavigator.DeleteItem = null;
            this.listaClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaClientesBindingNavigatorSaveItem,
            this.CancelarToolStripButton});
            this.listaClientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaClientesBindingNavigator.Name = "listaClientesBindingNavigator";
            this.listaClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaClientesBindingNavigator.Size = new System.Drawing.Size(887, 25);
            this.listaClientesBindingNavigator.TabIndex = 0;
            this.listaClientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaClientesBindingNavigatorSaveItem
            // 
            this.listaClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaClientesBindingNavigatorSaveItem.Image")));
            this.listaClientesBindingNavigatorSaveItem.Name = "listaClientesBindingNavigatorSaveItem";
            this.listaClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaClientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaClientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaClientesBindingNavigatorSaveItem_Click);
            // 
            // CancelarToolStripButton
            // 
            this.CancelarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarToolStripButton.Name = "CancelarToolStripButton";
            this.CancelarToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.CancelarToolStripButton.Text = "Cancelar";
            this.CancelarToolStripButton.Visible = false;
            this.CancelarToolStripButton.Click += new System.EventHandler(this.CancelarToolStripButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listaTblClaseCltesBindingSource
            // 
            this.listaTblClaseCltesBindingSource.DataSource = typeof(BL.Fashion.TblClaseClte);
            // 
            // listaTblDeptosBindingSource
            // 
            this.listaTblDeptosBindingSource.DataSource = typeof(BL.Fashion.TblDepto);
            // 
            // listaTblMunicipiosBindingSource
            // 
            this.listaTblMunicipiosBindingSource.DataSource = typeof(BL.Fashion.TblMunicipio);
            // 
            // idClaseClteComboBox
            // 
            this.idClaseClteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource, "IdClaseClte", true));
            this.idClaseClteComboBox.DataSource = this.listaTblClaseCltesBindingSource;
            this.idClaseClteComboBox.DisplayMember = "Descripcion";
            this.idClaseClteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idClaseClteComboBox.FormattingEnabled = true;
            this.idClaseClteComboBox.Location = new System.Drawing.Point(325, 123);
            this.idClaseClteComboBox.Name = "idClaseClteComboBox";
            this.idClaseClteComboBox.Size = new System.Drawing.Size(191, 21);
            this.idClaseClteComboBox.TabIndex = 68;
            this.idClaseClteComboBox.ValueMember = "Id";
            // 
            // direccPaisIdComboBox
            // 
            this.direccPaisIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource, "DireccPaisId", true));
            this.direccPaisIdComboBox.DataSource = this.listaTblPaisesBindingSource;
            this.direccPaisIdComboBox.DisplayMember = "Descripcion";
            this.direccPaisIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direccPaisIdComboBox.FormattingEnabled = true;
            this.direccPaisIdComboBox.Location = new System.Drawing.Point(325, 160);
            this.direccPaisIdComboBox.Name = "direccPaisIdComboBox";
            this.direccPaisIdComboBox.Size = new System.Drawing.Size(191, 21);
            this.direccPaisIdComboBox.TabIndex = 69;
            this.direccPaisIdComboBox.ValueMember = "Id";
            // 
            // listaTblPaisesBindingSource
            // 
            this.listaTblPaisesBindingSource.DataSource = typeof(BL.Fashion.TblPais);
            // 
            // direccDeptoIdComboBox
            // 
            this.direccDeptoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource, "DireccDeptoId", true));
            this.direccDeptoIdComboBox.DataSource = this.listaTblDeptosBindingSource;
            this.direccDeptoIdComboBox.DisplayMember = "Descripcion";
            this.direccDeptoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direccDeptoIdComboBox.FormattingEnabled = true;
            this.direccDeptoIdComboBox.Location = new System.Drawing.Point(325, 185);
            this.direccDeptoIdComboBox.Name = "direccDeptoIdComboBox";
            this.direccDeptoIdComboBox.Size = new System.Drawing.Size(191, 21);
            this.direccDeptoIdComboBox.TabIndex = 70;
            this.direccDeptoIdComboBox.ValueMember = "Id";
            // 
            // direccMinicipioIdComboBox
            // 
            this.direccMinicipioIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource, "DireccMinicipioId", true));
            this.direccMinicipioIdComboBox.DataSource = this.listaTblMunicipiosBindingSource;
            this.direccMinicipioIdComboBox.DisplayMember = "Descripcion";
            this.direccMinicipioIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direccMinicipioIdComboBox.FormattingEnabled = true;
            this.direccMinicipioIdComboBox.Location = new System.Drawing.Point(325, 210);
            this.direccMinicipioIdComboBox.Name = "direccMinicipioIdComboBox";
            this.direccMinicipioIdComboBox.Size = new System.Drawing.Size(191, 21);
            this.direccMinicipioIdComboBox.TabIndex = 71;
            this.direccMinicipioIdComboBox.ValueMember = "Id";
            // 
            // direccSectorBoColIdComboBox
            // 
            this.direccSectorBoColIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource, "DireccSectorBoColId", true));
            this.direccSectorBoColIdComboBox.DataSource = this.listaTblSectorBoColsBindingSource;
            this.direccSectorBoColIdComboBox.DisplayMember = "Descripcion";
            this.direccSectorBoColIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direccSectorBoColIdComboBox.FormattingEnabled = true;
            this.direccSectorBoColIdComboBox.Location = new System.Drawing.Point(325, 235);
            this.direccSectorBoColIdComboBox.Name = "direccSectorBoColIdComboBox";
            this.direccSectorBoColIdComboBox.Size = new System.Drawing.Size(191, 21);
            this.direccSectorBoColIdComboBox.TabIndex = 72;
            this.direccSectorBoColIdComboBox.ValueMember = "Id";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(325, 262);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(329, 20);
            this.direccionTextBox.TabIndex = 73;
            // 
            // tel1TextBox
            // 
            this.tel1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Tel1", true));
            this.tel1TextBox.Location = new System.Drawing.Point(325, 286);
            this.tel1TextBox.Name = "tel1TextBox";
            this.tel1TextBox.Size = new System.Drawing.Size(100, 20);
            this.tel1TextBox.TabIndex = 74;
            // 
            // tel2TextBox
            // 
            this.tel2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Tel2", true));
            this.tel2TextBox.Location = new System.Drawing.Point(325, 312);
            this.tel2TextBox.Name = "tel2TextBox";
            this.tel2TextBox.Size = new System.Drawing.Size(100, 20);
            this.tel2TextBox.TabIndex = 75;
            // 
            // email1TextBox
            // 
            this.email1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Email1", true));
            this.email1TextBox.Location = new System.Drawing.Point(535, 286);
            this.email1TextBox.Name = "email1TextBox";
            this.email1TextBox.Size = new System.Drawing.Size(100, 20);
            this.email1TextBox.TabIndex = 76;
            // 
            // email2TextBox
            // 
            this.email2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Email2", true));
            this.email2TextBox.Location = new System.Drawing.Point(535, 312);
            this.email2TextBox.Name = "email2TextBox";
            this.email2TextBox.Size = new System.Drawing.Size(100, 20);
            this.email2TextBox.TabIndex = 77;
            // 
            // generoComboBox
            // 
            this.generoComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Femenino"});
            this.generoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(325, 97);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(132, 21);
            this.generoComboBox.TabIndex = 78;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaClientesBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(618, 45);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(17, 24);
            this.activoCheckBox.TabIndex = 79;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(887, 352);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(email2Label);
            this.Controls.Add(this.email2TextBox);
            this.Controls.Add(email1Label);
            this.Controls.Add(this.email1TextBox);
            this.Controls.Add(tel2Label);
            this.Controls.Add(this.tel2TextBox);
            this.Controls.Add(tel1Label);
            this.Controls.Add(this.tel1TextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(direccSectorBoColIdLabel);
            this.Controls.Add(this.direccSectorBoColIdComboBox);
            this.Controls.Add(direccMinicipioIdLabel);
            this.Controls.Add(this.direccMinicipioIdComboBox);
            this.Controls.Add(direccDeptoIdLabel);
            this.Controls.Add(this.direccDeptoIdComboBox);
            this.Controls.Add(direccPaisIdLabel);
            this.Controls.Add(this.direccPaisIdComboBox);
            this.Controls.Add(idClaseClteLabel);
            this.Controls.Add(this.idClaseClteComboBox);
            this.Controls.Add(this.listaClientesBindingNavigator);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.formproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingNavigator)).EndInit();
            this.listaClientesBindingNavigator.ResumeLayout(false);
            this.listaClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblClaseCltesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblDeptosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblMunicipiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTblSectorBoColsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void formproducto_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private static void NewMethod()
        {

        }

        #endregion
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingNavigator listaClientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaTblClaseCltesBindingSource;
        private System.Windows.Forms.BindingSource listaTblDeptosBindingSource;
        private System.Windows.Forms.BindingSource listaTblMunicipiosBindingSource;
        private System.Windows.Forms.ComboBox idClaseClteComboBox;
        private System.Windows.Forms.ComboBox direccPaisIdComboBox;
        private System.Windows.Forms.ComboBox direccDeptoIdComboBox;
        private System.Windows.Forms.ComboBox direccMinicipioIdComboBox;
        private System.Windows.Forms.ComboBox direccSectorBoColIdComboBox;
        private System.Windows.Forms.BindingSource listaTblSectorBoColsBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox tel1TextBox;
        private System.Windows.Forms.TextBox tel2TextBox;
        private System.Windows.Forms.TextBox email1TextBox;
        private System.Windows.Forms.TextBox email2TextBox;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.ToolStripButton CancelarToolStripButton;
        private System.Windows.Forms.BindingSource listaTblPaisesBindingSource;
        private System.Windows.Forms.CheckBox activoCheckBox;
    }
}