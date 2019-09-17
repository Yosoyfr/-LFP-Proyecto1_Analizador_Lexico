namespace _LFP_Proyecto1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.lblPais = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.CurvaSideBar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaGrafica = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionAcercaDe = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.CurvaAcercaDe = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaBtnAnalizar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaBtnGenerarPDF = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaErrores = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaBtnOpenImage = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnOpenImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.areaSeleccionPais = new System.Windows.Forms.PictureBox();
            this.btnGenerarPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnalizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.areaGrafica = new System.Windows.Forms.PictureBox();
            this.lblErrores = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnHTMLError = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHTMLToken = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblHTML = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnOpenFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblAcercaDe = new System.Windows.Forms.Label();
            this.btnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOpenPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveAs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewTabPage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LineaSidebar2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.curvaBandera = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textualTabControl1 = new _LFP_Proyecto1.TextualTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CurvaTextualTab = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MenuTop.SuspendLayout();
            this.SidebarWrapper.SuspendLayout();
            this.Wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaSeleccionPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaGrafica)).BeginInit();
            this.lblErrores.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.textualTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.MenuTop, "MenuTop");
            this.MenuTop.Name = "MenuTop";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.AnimacionAcercaDe.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.AnimacionSidebar.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation3;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.SidebarWrapper.Controls.Add(this.lblErrores);
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.SidebarWrapper, "SidebarWrapper");
            this.SidebarWrapper.Name = "SidebarWrapper";
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.Wrapper.Controls.Add(this.btnOpenImage);
            this.Wrapper.Controls.Add(this.areaSeleccionPais);
            this.Wrapper.Controls.Add(this.btnGenerarPDF);
            this.Wrapper.Controls.Add(this.btnAnalizar);
            this.Wrapper.Controls.Add(this.areaGrafica);
            this.Wrapper.Controls.Add(this.textualTabControl1);
            this.Wrapper.Controls.Add(this.lblPais);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Wrapper, "Wrapper");
            this.Wrapper.Name = "Wrapper";
            // 
            // lblPais
            // 
            this.AnimacionAcercaDe.SetDecoration(this.lblPais, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblPais, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.lblPais, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.lblPais, "lblPais");
            this.lblPais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPais.Name = "lblPais";
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // CurvaSideBar
            // 
            this.CurvaSideBar.ElipseRadius = 10;
            this.CurvaSideBar.TargetControl = this.Sidebar;
            // 
            // CurvaGrafica
            // 
            this.CurvaGrafica.ElipseRadius = 15;
            this.CurvaGrafica.TargetControl = this.areaGrafica;
            // 
            // AnimacionAcercaDe
            // 
            this.AnimacionAcercaDe.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.AnimacionAcercaDe.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionAcercaDe.DefaultAnimation = animation1;
            // 
            // CurvaAcercaDe
            // 
            this.CurvaAcercaDe.ElipseRadius = 10;
            this.CurvaAcercaDe.TargetControl = this.lblAcercaDe;
            // 
            // CurvaBtnAnalizar
            // 
            this.CurvaBtnAnalizar.ElipseRadius = 15;
            this.CurvaBtnAnalizar.TargetControl = this.btnAnalizar;
            // 
            // CurvaBtnGenerarPDF
            // 
            this.CurvaBtnGenerarPDF.ElipseRadius = 15;
            this.CurvaBtnGenerarPDF.TargetControl = this.btnGenerarPDF;
            // 
            // CurvaErrores
            // 
            this.CurvaErrores.ElipseRadius = 20;
            this.CurvaErrores.TargetControl = this.lblErrores;
            // 
            // CurvaBtnOpenImage
            // 
            this.CurvaBtnOpenImage.ElipseRadius = 15;
            this.CurvaBtnOpenImage.TargetControl = this.btnOpenImage;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.btnOpenImage, "btnOpenImage");
            this.btnOpenImage.BorderRadius = 0;
            this.btnOpenImage.ButtonText = "               ABRIR GRAFICA";
            this.btnOpenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnOpenImage, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnOpenImage, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnOpenImage, BunifuAnimatorNS.DecorationType.None);
            this.btnOpenImage.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenImage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenImage.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_picture_32;
            this.btnOpenImage.Iconimage_right = null;
            this.btnOpenImage.Iconimage_right_Selected = null;
            this.btnOpenImage.Iconimage_Selected = null;
            this.btnOpenImage.IconMarginLeft = 0;
            this.btnOpenImage.IconMarginRight = 0;
            this.btnOpenImage.IconRightVisible = true;
            this.btnOpenImage.IconRightZoom = 0D;
            this.btnOpenImage.IconVisible = true;
            this.btnOpenImage.IconZoom = 50D;
            this.btnOpenImage.IsTab = false;
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnOpenImage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(161)))), ((int)(((byte)(138)))));
            this.btnOpenImage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenImage.selected = false;
            this.btnOpenImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenImage.Textcolor = System.Drawing.Color.White;
            this.btnOpenImage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.Click += new System.EventHandler(this.BtnOpenImage_Click);
            // 
            // areaSeleccionPais
            // 
            this.AnimacionAcercaDe.SetDecoration(this.areaSeleccionPais, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.areaSeleccionPais, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.areaSeleccionPais, BunifuAnimatorNS.DecorationType.None);
            this.areaSeleccionPais.Image = global::_LFP_Proyecto1.Properties.Resources.Logo;
            resources.ApplyResources(this.areaSeleccionPais, "areaSeleccionPais");
            this.areaSeleccionPais.Name = "areaSeleccionPais";
            this.areaSeleccionPais.TabStop = false;
            this.areaSeleccionPais.Click += new System.EventHandler(this.AreaSeleccionPais_Click);
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnGenerarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.btnGenerarPDF, "btnGenerarPDF");
            this.btnGenerarPDF.BorderRadius = 0;
            this.btnGenerarPDF.ButtonText = "               GENERAR PDF";
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnGenerarPDF, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnGenerarPDF, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnGenerarPDF, BunifuAnimatorNS.DecorationType.None);
            this.btnGenerarPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerarPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerarPDF.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_pdf_2_32;
            this.btnGenerarPDF.Iconimage_right = null;
            this.btnGenerarPDF.Iconimage_right_Selected = null;
            this.btnGenerarPDF.Iconimage_Selected = null;
            this.btnGenerarPDF.IconMarginLeft = 0;
            this.btnGenerarPDF.IconMarginRight = 0;
            this.btnGenerarPDF.IconRightVisible = true;
            this.btnGenerarPDF.IconRightZoom = 0D;
            this.btnGenerarPDF.IconVisible = true;
            this.btnGenerarPDF.IconZoom = 50D;
            this.btnGenerarPDF.IsTab = false;
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnGenerarPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(161)))), ((int)(((byte)(138)))));
            this.btnGenerarPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerarPDF.selected = false;
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPDF.Textcolor = System.Drawing.Color.White;
            this.btnGenerarPDF.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.Click += new System.EventHandler(this.BtnGenerarPDF_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAnalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.btnAnalizar, "btnAnalizar");
            this.btnAnalizar.BorderRadius = 0;
            this.btnAnalizar.ButtonText = "               ANALIZAR";
            this.btnAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnAnalizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnAnalizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnAnalizar, BunifuAnimatorNS.DecorationType.None);
            this.btnAnalizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnalizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnalizar.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_list_32;
            this.btnAnalizar.Iconimage_right = null;
            this.btnAnalizar.Iconimage_right_Selected = null;
            this.btnAnalizar.Iconimage_Selected = null;
            this.btnAnalizar.IconMarginLeft = 0;
            this.btnAnalizar.IconMarginRight = 0;
            this.btnAnalizar.IconRightVisible = true;
            this.btnAnalizar.IconRightZoom = 0D;
            this.btnAnalizar.IconVisible = true;
            this.btnAnalizar.IconZoom = 50D;
            this.btnAnalizar.IsTab = false;
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAnalizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(161)))), ((int)(((byte)(138)))));
            this.btnAnalizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnalizar.selected = false;
            this.btnAnalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalizar.Textcolor = System.Drawing.Color.White;
            this.btnAnalizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Click += new System.EventHandler(this.BtnAnalizar_Click);
            // 
            // areaGrafica
            // 
            this.AnimacionAcercaDe.SetDecoration(this.areaGrafica, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.areaGrafica, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.areaGrafica, BunifuAnimatorNS.DecorationType.None);
            this.areaGrafica.Image = global::_LFP_Proyecto1.Properties.Resources.logoUsac;
            resources.ApplyResources(this.areaGrafica, "areaGrafica");
            this.areaGrafica.Name = "areaGrafica";
            this.areaGrafica.TabStop = false;
            // 
            // lblErrores
            // 
            resources.ApplyResources(this.lblErrores, "lblErrores");
            this.lblErrores.Controls.Add(this.btnHTMLError);
            this.lblErrores.Controls.Add(this.btnHTMLToken);
            this.lblErrores.Controls.Add(this.lblHTML);
            this.lblErrores.Controls.Add(this.bunifuSeparator1);
            this.AnimacionSidebar.SetDecoration(this.lblErrores, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblErrores, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.lblErrores, BunifuAnimatorNS.DecorationType.None);
            this.lblErrores.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.lblErrores.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.lblErrores.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.lblErrores.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Quality = 10;
            // 
            // btnHTMLError
            // 
            this.btnHTMLError.Activecolor = System.Drawing.Color.Transparent;
            this.btnHTMLError.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnHTMLError, "btnHTMLError");
            this.btnHTMLError.BorderRadius = 0;
            this.btnHTMLError.ButtonText = "       HTML DE ERRORES";
            this.btnHTMLError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnHTMLError, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnHTMLError, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnHTMLError, BunifuAnimatorNS.DecorationType.None);
            this.btnHTMLError.DisabledColor = System.Drawing.Color.Gray;
            this.btnHTMLError.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHTMLError.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_code_file_32;
            this.btnHTMLError.Iconimage_right = null;
            this.btnHTMLError.Iconimage_right_Selected = null;
            this.btnHTMLError.Iconimage_Selected = null;
            this.btnHTMLError.IconMarginLeft = 0;
            this.btnHTMLError.IconMarginRight = 0;
            this.btnHTMLError.IconRightVisible = true;
            this.btnHTMLError.IconRightZoom = 0D;
            this.btnHTMLError.IconVisible = true;
            this.btnHTMLError.IconZoom = 70D;
            this.btnHTMLError.IsTab = false;
            this.btnHTMLError.Name = "btnHTMLError";
            this.btnHTMLError.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHTMLError.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnHTMLError.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHTMLError.selected = false;
            this.btnHTMLError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHTMLError.Textcolor = System.Drawing.Color.LightGray;
            this.btnHTMLError.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTMLError.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // btnHTMLToken
            // 
            this.btnHTMLToken.Activecolor = System.Drawing.Color.Transparent;
            this.btnHTMLToken.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnHTMLToken, "btnHTMLToken");
            this.btnHTMLToken.BorderRadius = 0;
            this.btnHTMLToken.ButtonText = "        HTML DE TOKENS";
            this.btnHTMLToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnHTMLToken, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnHTMLToken, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnHTMLToken, BunifuAnimatorNS.DecorationType.None);
            this.btnHTMLToken.DisabledColor = System.Drawing.Color.Gray;
            this.btnHTMLToken.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHTMLToken.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_code_file_32;
            this.btnHTMLToken.Iconimage_right = null;
            this.btnHTMLToken.Iconimage_right_Selected = null;
            this.btnHTMLToken.Iconimage_Selected = null;
            this.btnHTMLToken.IconMarginLeft = 0;
            this.btnHTMLToken.IconMarginRight = 0;
            this.btnHTMLToken.IconRightVisible = true;
            this.btnHTMLToken.IconRightZoom = 0D;
            this.btnHTMLToken.IconVisible = true;
            this.btnHTMLToken.IconZoom = 70D;
            this.btnHTMLToken.IsTab = false;
            this.btnHTMLToken.Name = "btnHTMLToken";
            this.btnHTMLToken.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHTMLToken.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnHTMLToken.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHTMLToken.selected = false;
            this.btnHTMLToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHTMLToken.Textcolor = System.Drawing.Color.LightGray;
            this.btnHTMLToken.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTMLToken.Click += new System.EventHandler(this.BunifuFlatButton1_Click_1);
            // 
            // lblHTML
            // 
            this.lblHTML.Activecolor = System.Drawing.Color.Transparent;
            this.lblHTML.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblHTML, "lblHTML");
            this.lblHTML.BorderRadius = 0;
            this.lblHTML.ButtonText = "          NO SE HA ANALIZADO               NADA";
            this.lblHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.lblHTML, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblHTML, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.lblHTML, BunifuAnimatorNS.DecorationType.None);
            this.lblHTML.DisabledColor = System.Drawing.Color.Gray;
            this.lblHTML.Iconcolor = System.Drawing.Color.Transparent;
            this.lblHTML.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_attention_32;
            this.lblHTML.Iconimage_right = null;
            this.lblHTML.Iconimage_right_Selected = null;
            this.lblHTML.Iconimage_Selected = null;
            this.lblHTML.IconMarginLeft = 0;
            this.lblHTML.IconMarginRight = 0;
            this.lblHTML.IconRightVisible = true;
            this.lblHTML.IconRightZoom = 0D;
            this.lblHTML.IconVisible = true;
            this.lblHTML.IconZoom = 80D;
            this.lblHTML.IsTab = false;
            this.lblHTML.Name = "lblHTML";
            this.lblHTML.Normalcolor = System.Drawing.Color.Transparent;
            this.lblHTML.OnHovercolor = System.Drawing.Color.Transparent;
            this.lblHTML.OnHoverTextColor = System.Drawing.Color.White;
            this.lblHTML.selected = false;
            this.lblHTML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHTML.Textcolor = System.Drawing.Color.LightGray;
            this.lblHTML.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            resources.ApplyResources(this.bunifuSeparator1, "bunifuSeparator1");
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Sidebar
            // 
            resources.ApplyResources(this.Sidebar, "Sidebar");
            this.Sidebar.Controls.Add(this.btnOpenFile);
            this.Sidebar.Controls.Add(this.lblAcercaDe);
            this.Sidebar.Controls.Add(this.btnAbout);
            this.Sidebar.Controls.Add(this.btnExit);
            this.Sidebar.Controls.Add(this.btnOpenPDF);
            this.Sidebar.Controls.Add(this.btnSaveAs);
            this.Sidebar.Controls.Add(this.btnSave);
            this.Sidebar.Controls.Add(this.btnNewTabPage);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Controls.Add(this.LineaSidebar2);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Activecolor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnOpenFile, "btnOpenFile");
            this.btnOpenFile.BorderRadius = 0;
            this.btnOpenFile.ButtonText = "           ABRIR";
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnOpenFile, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnOpenFile, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnOpenFile, BunifuAnimatorNS.DecorationType.None);
            this.btnOpenFile.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenFile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenFile.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_view_file_32;
            this.btnOpenFile.Iconimage_right = null;
            this.btnOpenFile.Iconimage_right_Selected = null;
            this.btnOpenFile.Iconimage_Selected = null;
            this.btnOpenFile.IconMarginLeft = 0;
            this.btnOpenFile.IconMarginRight = 0;
            this.btnOpenFile.IconRightVisible = true;
            this.btnOpenFile.IconRightZoom = 0D;
            this.btnOpenFile.IconVisible = true;
            this.btnOpenFile.IconZoom = 50D;
            this.btnOpenFile.IsTab = false;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOpenFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnOpenFile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenFile.selected = false;
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Textcolor = System.Drawing.Color.LightGray;
            this.btnOpenFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionAcercaDe.SetDecoration(this.lblAcercaDe, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblAcercaDe, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.lblAcercaDe, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.lblAcercaDe, "lblAcercaDe");
            this.lblAcercaDe.ForeColor = System.Drawing.Color.White;
            this.lblAcercaDe.Name = "lblAcercaDe";
            // 
            // btnAbout
            // 
            this.btnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.BorderRadius = 0;
            this.btnAbout.ButtonText = "           ACERCA DE...";
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.btnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbout.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_info_32;
            this.btnAbout.Iconimage_right = null;
            this.btnAbout.Iconimage_right_Selected = null;
            this.btnAbout.Iconimage_Selected = null;
            this.btnAbout.IconMarginLeft = 0;
            this.btnAbout.IconMarginRight = 0;
            this.btnAbout.IconRightVisible = true;
            this.btnAbout.IconRightZoom = 0D;
            this.btnAbout.IconVisible = true;
            this.btnAbout.IconZoom = 70D;
            this.btnAbout.IsTab = false;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbout.selected = false;
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Textcolor = System.Drawing.Color.LightGray;
            this.btnAbout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Click += new System.EventHandler(this.BunifuFlatButton6_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.Transparent;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "           SALIR";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_shutdown_321;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 50D;
            this.btnExit.IsTab = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.LightGray;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnOpenPDF
            // 
            this.btnOpenPDF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnOpenPDF.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnOpenPDF, "btnOpenPDF");
            this.btnOpenPDF.BorderRadius = 0;
            this.btnOpenPDF.ButtonText = "           ABRIR HTMLS";
            this.btnOpenPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnOpenPDF, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnOpenPDF, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnOpenPDF, BunifuAnimatorNS.DecorationType.None);
            this.btnOpenPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenPDF.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_html_filetype_32;
            this.btnOpenPDF.Iconimage_right = null;
            this.btnOpenPDF.Iconimage_right_Selected = null;
            this.btnOpenPDF.Iconimage_Selected = null;
            this.btnOpenPDF.IconMarginLeft = 0;
            this.btnOpenPDF.IconMarginRight = 0;
            this.btnOpenPDF.IconRightVisible = true;
            this.btnOpenPDF.IconRightZoom = 0D;
            this.btnOpenPDF.IconVisible = true;
            this.btnOpenPDF.IconZoom = 70D;
            this.btnOpenPDF.IsTab = false;
            this.btnOpenPDF.Name = "btnOpenPDF";
            this.btnOpenPDF.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOpenPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnOpenPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenPDF.selected = false;
            this.btnOpenPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenPDF.Textcolor = System.Drawing.Color.LightGray;
            this.btnOpenPDF.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPDF.Click += new System.EventHandler(this.BtnOpenPDF_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Activecolor = System.Drawing.Color.Transparent;
            this.btnSaveAs.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            this.btnSaveAs.BorderRadius = 0;
            this.btnSaveAs.ButtonText = "           GUARDAR COMO...";
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnSaveAs, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnSaveAs, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnSaveAs, BunifuAnimatorNS.DecorationType.None);
            this.btnSaveAs.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveAs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveAs.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_save_as_32;
            this.btnSaveAs.Iconimage_right = null;
            this.btnSaveAs.Iconimage_right_Selected = null;
            this.btnSaveAs.Iconimage_Selected = null;
            this.btnSaveAs.IconMarginLeft = 0;
            this.btnSaveAs.IconMarginRight = 0;
            this.btnSaveAs.IconRightVisible = true;
            this.btnSaveAs.IconRightZoom = 0D;
            this.btnSaveAs.IconVisible = true;
            this.btnSaveAs.IconZoom = 50D;
            this.btnSaveAs.IsTab = false;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSaveAs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnSaveAs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveAs.selected = false;
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAs.Textcolor = System.Drawing.Color.LightGray;
            this.btnSaveAs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "           GUARDAR";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_save_32;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 50D;
            this.btnSave.IsTab = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.LightGray;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnNewTabPage
            // 
            this.btnNewTabPage.Activecolor = System.Drawing.Color.Transparent;
            this.btnNewTabPage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnNewTabPage, "btnNewTabPage");
            this.btnNewTabPage.BorderRadius = 0;
            this.btnNewTabPage.ButtonText = "           NUEVA PESTAÑA";
            this.btnNewTabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAcercaDe.SetDecoration(this.btnNewTabPage, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnNewTabPage, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnNewTabPage, BunifuAnimatorNS.DecorationType.None);
            this.btnNewTabPage.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewTabPage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewTabPage.Iconimage = global::_LFP_Proyecto1.Properties.Resources.icons8_add_file_32;
            this.btnNewTabPage.Iconimage_right = null;
            this.btnNewTabPage.Iconimage_right_Selected = null;
            this.btnNewTabPage.Iconimage_Selected = null;
            this.btnNewTabPage.IconMarginLeft = 0;
            this.btnNewTabPage.IconMarginRight = 0;
            this.btnNewTabPage.IconRightVisible = true;
            this.btnNewTabPage.IconRightZoom = 0D;
            this.btnNewTabPage.IconVisible = true;
            this.btnNewTabPage.IconZoom = 50D;
            this.btnNewTabPage.IsTab = false;
            this.btnNewTabPage.Name = "btnNewTabPage";
            this.btnNewTabPage.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNewTabPage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnNewTabPage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewTabPage.selected = false;
            this.btnNewTabPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTabPage.Textcolor = System.Drawing.Color.LightGray;
            this.btnNewTabPage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTabPage.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAcercaDe.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            resources.ApplyResources(this.LineaSidebar, "LineaSidebar");
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAcercaDe.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // LineaSidebar2
            // 
            this.LineaSidebar2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.LineaSidebar2, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar2.LineThickness = 1;
            resources.ApplyResources(this.LineaSidebar2, "LineaSidebar2");
            this.LineaSidebar2.Name = "LineaSidebar2";
            this.LineaSidebar2.Transparency = 255;
            this.LineaSidebar2.Vertical = false;
            // 
            // Restaurar
            // 
            resources.ApplyResources(this.Restaurar, "Restaurar");
            this.AnimacionAcercaDe.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.TabStop = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            resources.ApplyResources(this.Minimizar, "Minimizar");
            this.AnimacionAcercaDe.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            resources.ApplyResources(this.Maximizar, "Maximizar");
            this.AnimacionAcercaDe.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            resources.ApplyResources(this.Salir, "Salir");
            this.AnimacionAcercaDe.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Name = "Salir";
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // MenuSidebar
            // 
            this.AnimacionAcercaDe.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.MenuSidebar, "MenuSidebar");
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // curvaBandera
            // 
            this.curvaBandera.ElipseRadius = 15;
            this.curvaBandera.TargetControl = this.areaSeleccionPais;
            // 
            // textualTabControl1
            // 
            this.textualTabControl1.Controls.Add(this.tabPage1);
            this.AnimacionSidebar.SetDecoration(this.textualTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.textualTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.textualTabControl1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.textualTabControl1, "textualTabControl1");
            this.textualTabControl1.Multiline = true;
            this.textualTabControl1.Name = "textualTabControl1";
            this.textualTabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.AnimacionSidebarBack.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAcercaDe.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CurvaTextualTab
            // 
            this.CurvaTextualTab.ElipseRadius = 15;
            this.CurvaTextualTab.TargetControl = this.textualTabControl1;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionAcercaDe.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.SidebarWrapper.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.areaSeleccionPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaGrafica)).EndInit();
            this.lblErrores.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.textualTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse CurvaSideBar;
        private Bunifu.Framework.UI.BunifuElipse CurvaTextualTab;
        private TextualTabControl textualTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbout;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenPDF;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveAs;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewTabPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnalizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerarPDF;
        private System.Windows.Forms.PictureBox areaSeleccionPais;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPais;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuElipse CurvaGrafica;
        private System.Windows.Forms.Label lblAcercaDe;
        private BunifuAnimatorNS.BunifuTransition AnimacionAcercaDe;
        private Bunifu.Framework.UI.BunifuElipse CurvaAcercaDe;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar2;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenFile;
        private Bunifu.Framework.UI.BunifuElipse CurvaBtnAnalizar;
        private Bunifu.Framework.UI.BunifuElipse CurvaBtnGenerarPDF;
        private Bunifu.Framework.UI.BunifuElipse CurvaErrores;
        private Bunifu.Framework.UI.BunifuGradientPanel lblErrores;
        private Bunifu.Framework.UI.BunifuFlatButton lblHTML;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHTMLToken;
        private Bunifu.Framework.UI.BunifuFlatButton btnHTMLError;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenImage;
        private Bunifu.Framework.UI.BunifuElipse CurvaBtnOpenImage;
        public System.Windows.Forms.PictureBox areaGrafica;
        private Bunifu.Framework.UI.BunifuElipse curvaBandera;
    }
}

