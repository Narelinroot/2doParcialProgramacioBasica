namespace Examen_Cafeteria_Narelin
    {
    partial class frmPedidos
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
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblFecha = new Label();
            lblProducto = new Label();
            dtpFecha = new DateTimePicker();
            txtProducto = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCantidad = new Label();
            chkFrecuente = new CheckBox();
            nudCantidad = new NumericUpDown();
            GroupBox = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            GroupBox2 = new GroupBox();
            rbtllevar = new RadioButton();
            rbtlocal = new RadioButton();
            chkPorcionExtra = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lstPedido = new ListBox();
            lblsubb = new Label();
            lblDesc = new Label();
            lblEmpaq = new Label();
            lblitbi = new Label();
            label10 = new Label();
            lblEncabezado = new Label();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblEmpaque = new Label();
            lblitbis = new Label();
            lblTotal = new Label();
            lblclient = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            GroupBox.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(0, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(100, 23);
            lblCliente.TabIndex = 0;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(112, 34);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(264, 27);
            txtCliente.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(35, 124);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 19);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(32, 164);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(84, 19);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto:";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(112, 118);
            dtpFecha.MaxDate = new DateTime(2026, 11, 19, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 25);
            dtpFecha.TabIndex = 4;
            dtpFecha.Value = new DateTime(2026, 11, 19, 0, 0, 0, 0);
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProducto.Location = new Point(122, 164);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 25);
            txtProducto.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(35, 203);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 19);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(122, 203);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 25);
            txtPrecio.TabIndex = 7;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(32, 247);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(76, 19);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkFrecuente.Location = new Point(35, 80);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(159, 23);
            chkFrecuente.TabIndex = 9;
            chkFrecuente.Text = "Cliente frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(125, 244);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 25);
            nudCantidad.TabIndex = 10;
            // 
            // GroupBox
            // 
            GroupBox.BackColor = Color.Pink;
            GroupBox.Controls.Add(rbtGrande);
            GroupBox.Controls.Add(rbtNormal);
            GroupBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox.Location = new Point(25, 313);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(199, 125);
            GroupBox.TabIndex = 11;
            GroupBox.TabStop = false;
            GroupBox.Text = "Tamanio";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(9, 68);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(163, 23);
            rbtGrande.TabIndex = 1;
            rbtGrande.TabStop = true;
            rbtGrande.Text = "Grande (+RD$25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(9, 35);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(87, 23);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.BackColor = Color.Pink;
            GroupBox2.Controls.Add(rbtllevar);
            GroupBox2.Controls.Add(rbtlocal);
            GroupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox2.Location = new Point(230, 313);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(204, 125);
            GroupBox2.TabIndex = 12;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Servicio";
            // 
            // rbtllevar
            // 
            rbtllevar.AutoSize = true;
            rbtllevar.Location = new Point(10, 56);
            rbtllevar.Name = "rbtllevar";
            rbtllevar.Size = new Size(190, 23);
            rbtllevar.TabIndex = 1;
            rbtllevar.TabStop = true;
            rbtllevar.Text = "Para llevar (+RD$20)";
            rbtllevar.UseVisualStyleBackColor = true;
            // 
            // rbtlocal
            // 
            rbtlocal.AutoSize = true;
            rbtlocal.Location = new Point(9, 24);
            rbtlocal.Name = "rbtlocal";
            rbtlocal.Size = new Size(184, 23);
            rbtlocal.TabIndex = 0;
            rbtlocal.TabStop = true;
            rbtlocal.Text = "Consumir en el local";
            rbtlocal.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkPorcionExtra.Location = new Point(25, 444);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(136, 23);
            chkPorcionExtra.TabIndex = 13;
            chkPorcionExtra.Text = "Porcion Extra";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Pristina", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(25, 482);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(152, 29);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Pristina", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(200, 482);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(146, 29);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Pristina", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(373, 482);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(435, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(291, 40);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar al Pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstPedido
            // 
            lstPedido.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(406, 106);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(356, 175);
            lstPedido.TabIndex = 18;
            // 
            // lblsubb
            // 
            lblsubb.AutoSize = true;
            lblsubb.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsubb.Location = new Point(446, 303);
            lblsubb.Name = "lblsubb";
            lblsubb.Size = new Size(71, 19);
            lblsubb.TabIndex = 19;
            lblsubb.Text = "Subtotal";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(446, 340);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(85, 19);
            lblDesc.TabIndex = 20;
            lblDesc.Text = "Descuento";
            // 
            // lblEmpaq
            // 
            lblEmpaq.AutoSize = true;
            lblEmpaq.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpaq.Location = new Point(446, 375);
            lblEmpaq.Name = "lblEmpaq";
            lblEmpaq.Size = new Size(77, 19);
            lblEmpaq.TabIndex = 21;
            lblEmpaq.Text = "Empaque";
            // 
            // lblitbi
            // 
            lblitbi.AutoSize = true;
            lblitbi.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblitbi.Location = new Point(445, 409);
            lblitbi.Name = "lblitbi";
            lblitbi.Size = new Size(94, 17);
            lblitbi.TabIndex = 22;
            lblitbi.Text = "ITBIS (18%)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(445, 444);
            label10.Name = "label10";
            label10.Size = new Size(128, 17);
            label10.TabIndex = 23;
            label10.Text = "TOTAL A PAGAR";
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEncabezado.Location = new Point(406, 88);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(287, 15);
            lblEncabezado.TabIndex = 24;
            lblEncabezado.Text = "Cantidad   Producto                              Precio        Total";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.White;
            lblSubtotal.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(589, 303);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 17);
            lblSubtotal.TabIndex = 28;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(589, 338);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(0, 17);
            lblDescuento.TabIndex = 29;
            // 
            // lblEmpaque
            // 
            lblEmpaque.AutoSize = true;
            lblEmpaque.Location = new Point(589, 375);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(0, 20);
            lblEmpaque.TabIndex = 30;
            // 
            // lblitbis
            // 
            lblitbis.AutoSize = true;
            lblitbis.BackColor = Color.White;
            lblitbis.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblitbis.Location = new Point(589, 409);
            lblitbis.Name = "lblitbis";
            lblitbis.Size = new Size(0, 17);
            lblitbis.TabIndex = 31;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(589, 444);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 17);
            lblTotal.TabIndex = 32;
            // 
            // lblclient
            // 
            lblclient.AutoSize = true;
            lblclient.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclient.Location = new Point(34, 37);
            lblclient.Name = "lblclient";
            lblclient.Size = new Size(70, 19);
            lblclient.TabIndex = 33;
            lblclient.Text = "Cliente:";
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(766, 523);
            Controls.Add(lblclient);
            Controls.Add(lblTotal);
            Controls.Add(lblitbis);
            Controls.Add(lblEmpaque);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lblEncabezado);
            Controls.Add(label10);
            Controls.Add(lblitbi);
            Controls.Add(lblEmpaq);
            Controls.Add(lblDesc);
            Controls.Add(lblsubb);
            Controls.Add(lstPedido);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkPorcionExtra);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox);
            Controls.Add(nudCantidad);
            Controls.Add(chkFrecuente);
            Controls.Add(lblCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtProducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Controls.Add(txtCliente);
            Name = "frmPedidos";
            Text = "Cafeteria El Buen Sabor -Pedidos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblFecha;
        private Label lblProducto;
        private DateTimePicker dtpFecha;
        private TextBox txtProducto;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCantidad;
        private CheckBox chkFrecuente;
        private NumericUpDown nudCantidad;
        private GroupBox GroupBox;
        private GroupBox GroupBox2;
        private CheckBox chkPorcionExtra;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private ListBox lstPedido;
        private Label lblsubb;
        private Label lblDesc;
        private Label lblEmpaq;
        private RadioButton rbtNormal;
        private Label lblitbi;
        private Label label10;
        private RadioButton rbtGrande;
        private RadioButton rbtllevar;
        private RadioButton rbtlocal;
        private Label lblEncabezado;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblEmpaque;
        private Label lblitbis;
        private Label lblTotal;
        private Label lblclient;
        }
    }

