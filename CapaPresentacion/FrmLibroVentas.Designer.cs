
namespace CapaPresentacion
{
    partial class FrmLibroVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibroVentas));
            this.tablaLibroVentas = new System.Windows.Forms.DataGridView();
            this.txtAño = new System.Windows.Forms.ComboBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPorAño = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPorMes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBetweenDates = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAñoyMes = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FECHA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelEfectivo = new System.Windows.Forms.Label();
            this.labelDeb = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCred = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelCheq = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibroVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaLibroVentas
            // 
            this.tablaLibroVentas.AllowUserToAddRows = false;
            this.tablaLibroVentas.AllowUserToOrderColumns = true;
            this.tablaLibroVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaLibroVentas.BackgroundColor = System.Drawing.Color.White;
            this.tablaLibroVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaLibroVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaLibroVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaLibroVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaLibroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibroVentas.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaLibroVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaLibroVentas.Location = new System.Drawing.Point(22, 206);
            this.tablaLibroVentas.Margin = new System.Windows.Forms.Padding(2);
            this.tablaLibroVentas.Name = "tablaLibroVentas";
            this.tablaLibroVentas.ReadOnly = true;
            this.tablaLibroVentas.RowHeadersVisible = false;
            this.tablaLibroVentas.RowHeadersWidth = 51;
            this.tablaLibroVentas.RowTemplate.Height = 24;
            this.tablaLibroVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaLibroVentas.Size = new System.Drawing.Size(1136, 442);
            this.tablaLibroVentas.TabIndex = 87;
            // 
            // txtAño
            // 
            this.txtAño.FormattingEnabled = true;
            this.txtAño.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018"});
            this.txtAño.Location = new System.Drawing.Point(203, 40);
            this.txtAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(126, 21);
            this.txtAño.TabIndex = 90;
            this.txtAño.Text = "Año";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.White;
            this.pictureBox15.Image = global::CapaPresentacion.Properties.Resources.CajaTexto;
            this.pictureBox15.Location = new System.Drawing.Point(199, 35);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(134, 32);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 89;
            this.pictureBox15.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(47, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 20);
            this.label15.TabIndex = 88;
            this.label15.Text = "BUSCAR POR AÑO";
            // 
            // txtMes
            // 
            this.txtMes.FormattingEnabled = true;
            this.txtMes.Items.AddRange(new object[] {
            "01 ENERO",
            "02 FEBRERO",
            "03 MARZO",
            "04 ABRIL",
            "05 MAYO",
            "06 JUNIO",
            "07 JULIO",
            "08 AGOSTO",
            "09 SEPTIEMBRE",
            "10 OCTUBRE",
            "11 NOVIEMBRE",
            "12 DICIEMBRE"});
            this.txtMes.Location = new System.Drawing.Point(203, 85);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(126, 21);
            this.txtMes.TabIndex = 93;
            this.txtMes.Text = "Mes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.CajaTexto;
            this.pictureBox1.Location = new System.Drawing.Point(199, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "BUSCAR POR MES";
            // 
            // dateDesde
            // 
            this.dateDesde.CustomFormat = "yyyy-MM-dd";
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDesde.Location = new System.Drawing.Point(285, 123);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(91, 20);
            this.dateDesde.TabIndex = 94;
            this.dateDesde.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            // 
            // dateHasta
            // 
            this.dateHasta.CustomFormat = "yyyy-MM-dd";
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHasta.Location = new System.Drawing.Point(450, 124);
            this.dateHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(91, 20);
            this.dateHasta.TabIndex = 95;
            this.dateHasta.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(224, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(390, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "hasta";
            // 
            // btnPorAño
            // 
            this.btnPorAño.Activecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPorAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPorAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPorAño.BorderRadius = 7;
            this.btnPorAño.ButtonText = "BUSCAR";
            this.btnPorAño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorAño.DisabledColor = System.Drawing.Color.Gray;
            this.btnPorAño.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPorAño.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPorAño.Iconimage")));
            this.btnPorAño.Iconimage_right = null;
            this.btnPorAño.Iconimage_right_Selected = null;
            this.btnPorAño.Iconimage_Selected = null;
            this.btnPorAño.IconMarginLeft = 0;
            this.btnPorAño.IconMarginRight = 0;
            this.btnPorAño.IconRightVisible = true;
            this.btnPorAño.IconRightZoom = 0D;
            this.btnPorAño.IconVisible = true;
            this.btnPorAño.IconZoom = 90D;
            this.btnPorAño.IsTab = true;
            this.btnPorAño.Location = new System.Drawing.Point(343, 38);
            this.btnPorAño.Name = "btnPorAño";
            this.btnPorAño.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPorAño.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnPorAño.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPorAño.selected = false;
            this.btnPorAño.Size = new System.Drawing.Size(33, 26);
            this.btnPorAño.TabIndex = 98;
            this.btnPorAño.Text = "BUSCAR";
            this.btnPorAño.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPorAño.Textcolor = System.Drawing.Color.White;
            this.btnPorAño.TextFont = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorAño.Click += new System.EventHandler(this.btnPorAño_Click);
            // 
            // btnPorMes
            // 
            this.btnPorMes.Activecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPorMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPorMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPorMes.BorderRadius = 7;
            this.btnPorMes.ButtonText = "BUSCAR";
            this.btnPorMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorMes.DisabledColor = System.Drawing.Color.Gray;
            this.btnPorMes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPorMes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPorMes.Iconimage")));
            this.btnPorMes.Iconimage_right = null;
            this.btnPorMes.Iconimage_right_Selected = null;
            this.btnPorMes.Iconimage_Selected = null;
            this.btnPorMes.IconMarginLeft = 0;
            this.btnPorMes.IconMarginRight = 0;
            this.btnPorMes.IconRightVisible = true;
            this.btnPorMes.IconRightZoom = 0D;
            this.btnPorMes.IconVisible = true;
            this.btnPorMes.IconZoom = 90D;
            this.btnPorMes.IsTab = true;
            this.btnPorMes.Location = new System.Drawing.Point(525, 83);
            this.btnPorMes.Name = "btnPorMes";
            this.btnPorMes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPorMes.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnPorMes.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPorMes.selected = false;
            this.btnPorMes.Size = new System.Drawing.Size(33, 26);
            this.btnPorMes.TabIndex = 99;
            this.btnPorMes.Text = "BUSCAR";
            this.btnPorMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPorMes.Textcolor = System.Drawing.Color.White;
            this.btnPorMes.TextFont = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorMes.Click += new System.EventHandler(this.btnPorMes_Click);
            // 
            // btnBetweenDates
            // 
            this.btnBetweenDates.Activecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBetweenDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBetweenDates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBetweenDates.BorderRadius = 7;
            this.btnBetweenDates.ButtonText = "BUSCAR";
            this.btnBetweenDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBetweenDates.DisabledColor = System.Drawing.Color.Gray;
            this.btnBetweenDates.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBetweenDates.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBetweenDates.Iconimage")));
            this.btnBetweenDates.Iconimage_right = null;
            this.btnBetweenDates.Iconimage_right_Selected = null;
            this.btnBetweenDates.Iconimage_Selected = null;
            this.btnBetweenDates.IconMarginLeft = 0;
            this.btnBetweenDates.IconMarginRight = 0;
            this.btnBetweenDates.IconRightVisible = true;
            this.btnBetweenDates.IconRightZoom = 0D;
            this.btnBetweenDates.IconVisible = true;
            this.btnBetweenDates.IconZoom = 90D;
            this.btnBetweenDates.IsTab = true;
            this.btnBetweenDates.Location = new System.Drawing.Point(563, 122);
            this.btnBetweenDates.Name = "btnBetweenDates";
            this.btnBetweenDates.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBetweenDates.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnBetweenDates.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBetweenDates.selected = false;
            this.btnBetweenDates.Size = new System.Drawing.Size(33, 26);
            this.btnBetweenDates.TabIndex = 100;
            this.btnBetweenDates.Text = "BUSCAR";
            this.btnBetweenDates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBetweenDates.Textcolor = System.Drawing.Color.White;
            this.btnBetweenDates.TextFont = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetweenDates.Click += new System.EventHandler(this.btnBetweenDates_Click);
            // 
            // txtAñoyMes
            // 
            this.txtAñoyMes.FormattingEnabled = true;
            this.txtAñoyMes.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018"});
            this.txtAñoyMes.Location = new System.Drawing.Point(383, 83);
            this.txtAñoyMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtAñoyMes.Name = "txtAñoyMes";
            this.txtAñoyMes.Size = new System.Drawing.Size(126, 21);
            this.txtAñoyMes.TabIndex = 102;
            this.txtAñoyMes.Text = "Año";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.CajaTexto;
            this.pictureBox2.Location = new System.Drawing.Point(379, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(337, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "del";
            // 
            // FECHA
            // 
            this.FECHA.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FECHA.Location = new System.Drawing.Point(30, 175);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(150, 20);
            this.FECHA.TabIndex = 104;
            this.FECHA.Text = "FECHA";
            this.FECHA.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(186, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "TIPO DOC.";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(392, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 106;
            this.label6.Text = "N°";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(501, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 107;
            this.label7.Text = "NETO";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(657, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 108;
            this.label8.Text = "IVA";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(826, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 109;
            this.label9.Text = "TOTAL";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1008, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 110;
            this.label10.Text = "FORMA DE PAGO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(47, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 111;
            this.label11.Text = "BUSCAR POR FECHAS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(23, 672);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 112;
            this.label12.Text = "RESUMEN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(30, 726);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 113;
            this.label13.Text = "Efectivo      $";
            // 
            // labelEfectivo
            // 
            this.labelEfectivo.AutoSize = true;
            this.labelEfectivo.BackColor = System.Drawing.Color.White;
            this.labelEfectivo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEfectivo.Location = new System.Drawing.Point(145, 726);
            this.labelEfectivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEfectivo.Name = "labelEfectivo";
            this.labelEfectivo.Size = new System.Drawing.Size(19, 20);
            this.labelEfectivo.TabIndex = 114;
            this.labelEfectivo.Text = "0";
            // 
            // labelDeb
            // 
            this.labelDeb.AutoSize = true;
            this.labelDeb.BackColor = System.Drawing.Color.White;
            this.labelDeb.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDeb.Location = new System.Drawing.Point(145, 755);
            this.labelDeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeb.Name = "labelDeb";
            this.labelDeb.Size = new System.Drawing.Size(19, 20);
            this.labelDeb.TabIndex = 116;
            this.labelDeb.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(30, 755);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 20);
            this.label16.TabIndex = 115;
            this.label16.Text = "Debito        $";
            // 
            // labelCred
            // 
            this.labelCred.AutoSize = true;
            this.labelCred.BackColor = System.Drawing.Color.White;
            this.labelCred.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCred.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCred.Location = new System.Drawing.Point(145, 785);
            this.labelCred.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCred.Name = "labelCred";
            this.labelCred.Size = new System.Drawing.Size(19, 20);
            this.labelCred.TabIndex = 118;
            this.labelCred.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(30, 785);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 20);
            this.label18.TabIndex = 117;
            this.label18.Text = "Credito       $";
            // 
            // labelCheq
            // 
            this.labelCheq.AutoSize = true;
            this.labelCheq.BackColor = System.Drawing.Color.White;
            this.labelCheq.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCheq.Location = new System.Drawing.Point(145, 816);
            this.labelCheq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCheq.Name = "labelCheq";
            this.labelCheq.Size = new System.Drawing.Size(19, 20);
            this.labelCheq.TabIndex = 120;
            this.labelCheq.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(30, 816);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 20);
            this.label20.TabIndex = 119;
            this.label20.Text = "Cheque       $";
            // 
            // FrmLibroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 865);
            this.Controls.Add(this.labelCheq);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labelCred);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelDeb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelEfectivo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAñoyMes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBetweenDates);
            this.Controls.Add(this.btnPorMes);
            this.Controls.Add(this.btnPorAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaLibroVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLibroVentas";
            this.Text = "FrmLibroVentas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibroVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaLibroVentas;
        private System.Windows.Forms.ComboBox txtAño;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtMes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnPorAño;
        private Bunifu.Framework.UI.BunifuFlatButton btnPorMes;
        private Bunifu.Framework.UI.BunifuFlatButton btnBetweenDates;
        private System.Windows.Forms.ComboBox txtAñoyMes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FECHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelEfectivo;
        private System.Windows.Forms.Label labelDeb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCred;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelCheq;
        private System.Windows.Forms.Label label20;
    }
}