namespace KomisyonNET
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel34 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.materialLabel36 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pTaxiPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxPTlogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnFolderSelect = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxFolderPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCalculate = new MaterialSkin.Controls.MaterialButton();
            this.labelPtInfo = new MaterialSkin.Controls.MaterialLabel();
            this.statisticPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.mCardProfit = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabelProfitHeader = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabelTProfit = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.mLabelTInvoice = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost5 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.tableLayoutPanelRadio = new System.Windows.Forms.TableLayoutPanel();
            this.mRadioBtnStacked = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioBtnColumn = new MaterialSkin.Controls.MaterialRadioButton();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.mBtnClear = new MaterialSkin.Controls.MaterialButton();
            this.mBtnCalculateStatistic = new MaterialSkin.Controls.MaterialButton();
            this.mBtnFileSelect = new MaterialSkin.Controls.MaterialButton();
            this.mCardPreview = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel30 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.MaskTxtBoxNewFee = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.MaskTxtBoxNewComm = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            this.mBtnPreview = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTest = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.mCbxPreview = new MaterialSkin.Controls.MaterialCheckbox();
            this.mCardTable = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            this.mListViewTable = new MaterialSkin.Controls.MaterialListView();
            this.colNameSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTInvoice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEarn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEarnRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel33 = new System.Windows.Forms.TableLayoutPanel();
            this.mRadioBtnName = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioBtnEarn = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxExportPath = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnExportPath = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.themeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.BtnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.mComboBoxLanguage = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.MaskTxtBoxFee = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.MaskTxtBoxComm = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnReset = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.ımageListSideNav = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.homePage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.pTaxiPage.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPTlogo)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.statisticPage.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.mCardProfit.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.tableLayoutPanelRadio.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            this.mCardPreview.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.tableLayoutPanel30.SuspendLayout();
            this.tableLayoutPanel31.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.mCardTable.SuspendLayout();
            this.tableLayoutPanel32.SuspendLayout();
            this.tableLayoutPanel33.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.homePage);
            this.materialTabControl1.Controls.Add(this.pTaxiPage);
            this.materialTabControl1.Controls.Add(this.statisticPage);
            this.materialTabControl1.Controls.Add(this.settingsPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.ımageListSideNav;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(897, 664);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // homePage
            // 
            this.homePage.AutoScroll = true;
            this.homePage.Controls.Add(this.tableLayoutPanel1);
            this.homePage.ImageKey = "icons8-home-32.png";
            this.homePage.Location = new System.Drawing.Point(4, 39);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(889, 621);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Anasayfa";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 615);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tableLayoutPanel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(58, 57);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(766, 500);
            this.materialCard1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel29, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel30, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel31, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel32, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel33, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel34, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel35, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel34, 1, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(738, 472);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // materialLabel29
            // 
            this.materialLabel29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel29.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel29.Location = new System.Drawing.Point(305, 4);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(127, 29);
            this.materialLabel29.TabIndex = 0;
            this.materialLabel29.Text = "Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel30
            // 
            this.materialLabel30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel30.AutoSize = true;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel30.Location = new System.Drawing.Point(49, 178);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(639, 18);
            this.materialLabel30.TabIndex = 2;
            this.materialLabel30.Text = "KomisyonNET, muhasebe ofislerinin ihtiyaçlarına özel olarak tasarlanmış bir yazıl" +
    "ımdır. Bu";
            // 
            // materialLabel31
            // 
            this.materialLabel31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel31.Location = new System.Drawing.Point(57, 196);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(623, 18);
            this.materialLabel31.TabIndex = 3;
            this.materialLabel31.Text = "platform, paket taxi faturalarının kolayca hesaplanması, analiz edilmesi ve rapor" +
    "lanması";
            // 
            // materialLabel32
            // 
            this.materialLabel32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel32.Location = new System.Drawing.Point(34, 214);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(669, 18);
            this.materialLabel32.TabIndex = 4;
            this.materialLabel32.Text = "için geliştirilmiştir. Kullanıcı dostu arayüzü ile faturalarınızı hızlıca işleyeb" +
    "ilir, aidat ve komisyon";
            // 
            // materialLabel33
            // 
            this.materialLabel33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel33.Location = new System.Drawing.Point(18, 232);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(700, 18);
            this.materialLabel33.TabIndex = 5;
            this.materialLabel33.Text = "hesaplamalarını otomatik olarak yapabilirsiniz. Ayrıca, elde edilen verileri graf" +
    "iklerle görselleştirerek ";
            // 
            // materialLabel34
            // 
            this.materialLabel34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel34.Location = new System.Drawing.Point(179, 250);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(378, 18);
            this.materialLabel34.TabIndex = 6;
            this.materialLabel34.Text = "iş performansınızı detaylı bir şekilde inceleyebilirsiniz.";
            // 
            // materialLabel35
            // 
            this.materialLabel35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel35.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel35.Location = new System.Drawing.Point(64, 286);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(609, 17);
            this.materialLabel35.TabIndex = 7;
            this.materialLabel35.Text = "KomisyonNET, muhasebe süreçlerinizi basitleştirmek ve iş akışınızı optimize etmek" +
    " için burada!";
            // 
            // tableLayoutPanel34
            // 
            this.tableLayoutPanel34.ColumnCount = 3;
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel34.Controls.Add(this.pictureBoxMainLogo, 1, 2);
            this.tableLayoutPanel34.Controls.Add(this.materialLabel36, 1, 1);
            this.tableLayoutPanel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel34.Location = new System.Drawing.Point(10, 307);
            this.tableLayoutPanel34.Name = "tableLayoutPanel34";
            this.tableLayoutPanel34.RowCount = 3;
            this.tableLayoutPanel34.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064517F));
            this.tableLayoutPanel34.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.63772F));
            this.tableLayoutPanel34.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.29777F));
            this.tableLayoutPanel34.Size = new System.Drawing.Size(717, 162);
            this.tableLayoutPanel34.TabIndex = 8;
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainLogo.Image = global::KomisyonNET.Properties.Resources.logo_light;
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(10, 67);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(696, 92);
            this.pictureBoxMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMainLogo.TabIndex = 0;
            this.pictureBoxMainLogo.TabStop = false;
            // 
            // materialLabel36
            // 
            this.materialLabel36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel36.AutoSize = true;
            this.materialLabel36.Depth = 0;
            this.materialLabel36.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel36.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel36.Location = new System.Drawing.Point(64, 30);
            this.materialLabel36.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel36.Name = "materialLabel36";
            this.materialLabel36.Size = new System.Drawing.Size(587, 17);
            this.materialLabel36.TabIndex = 1;
            this.materialLabel36.Text = "**NOT: \"Ayarlar\" sekmesinden kendinize uygun \'Aidat\' ve \'Komisyon\' değerlerini be" +
    "lirleyebilirsiniz.";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(349, 583);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(183, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "© 2024 by Atakan Demir. ";
            // 
            // pTaxiPage
            // 
            this.pTaxiPage.Controls.Add(this.tableLayoutPanel9);
            this.pTaxiPage.ImageKey = "icons8-taxi-32.png";
            this.pTaxiPage.Location = new System.Drawing.Point(4, 39);
            this.pTaxiPage.Name = "pTaxiPage";
            this.pTaxiPage.Padding = new System.Windows.Forms.Padding(3);
            this.pTaxiPage.Size = new System.Drawing.Size(889, 621);
            this.pTaxiPage.TabIndex = 1;
            this.pTaxiPage.Text = "Paket Taxi";
            this.pTaxiPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel9.Controls.Add(this.materialCard5, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(883, 615);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.tableLayoutPanel10);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(58, 57);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(766, 500);
            this.materialCard5.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel10.Controls.Add(this.materialLabel9, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel10, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel11, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel12, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel13, 1, 4);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel14, 1, 5);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 1, 6);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 7;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(738, 472);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel9.Location = new System.Drawing.Point(10, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(717, 66);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "Paket Taxi";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel10.Location = new System.Drawing.Point(10, 66);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(717, 14);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Paket Taxi operasyonları bu sayfada icra edilmektedir.";
            this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel10.UseAccent = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel11.Location = new System.Drawing.Point(10, 94);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(717, 17);
            this.materialLabel11.TabIndex = 2;
            this.materialLabel11.Text = "Müşterilerinizin gönderdiği faturaları (.pdf) bir klasörün içinde toplayın. Ardın" +
    "an aşağıdaki butondan";
            this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel12.Location = new System.Drawing.Point(10, 117);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(717, 17);
            this.materialLabel12.TabIndex = 3;
            this.materialLabel12.Text = "faturaların bulunduğu klasörü seçin. Bu faturalar \'.pdf\' formatında olmalıdır ve " +
    "Paket taxi tarafından verilen ";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel13.Location = new System.Drawing.Point(10, 140);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(717, 17);
            this.materialLabel13.TabIndex = 4;
            this.materialLabel13.Text = "\'Hakediş\' i içermelidir. Farklı formatta dosyalar yada faturalar programın doğal " +
    "akışını etkileyeceği için sorunlara";
            this.materialLabel13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel14
            // 
            this.materialLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel14.Location = new System.Drawing.Point(10, 163);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(717, 17);
            this.materialLabel14.TabIndex = 5;
            this.materialLabel14.Text = "(Hata, yanlış hesaplama vb.) sebep olabilir. Program akışında sorumluluk size ait" +
    "tir.";
            this.materialLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel11.Controls.Add(this.pictureBoxPTlogo, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 1, 1);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(10, 189);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.617978F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.91011F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.47191F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(717, 280);
            this.tableLayoutPanel11.TabIndex = 6;
            // 
            // pictureBoxPTlogo
            // 
            this.pictureBoxPTlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPTlogo.Image = global::KomisyonNET.Properties.Resources.ptLogoWhite;
            this.pictureBoxPTlogo.Location = new System.Drawing.Point(187, 223);
            this.pictureBoxPTlogo.Name = "pictureBoxPTlogo";
            this.pictureBoxPTlogo.Size = new System.Drawing.Size(340, 50);
            this.pictureBoxPTlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPTlogo.TabIndex = 0;
            this.pictureBoxPTlogo.TabStop = false;
            this.pictureBoxPTlogo.WaitOnLoad = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel14, 1, 2);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(24, 18);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 4;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(667, 195);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 4;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel13.Controls.Add(this.BtnFolderSelect, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.txtBoxFolderPath, 2, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(69, 22);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.912621F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.17476F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.912621F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(527, 72);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // BtnFolderSelect
            // 
            this.BtnFolderSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnFolderSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFolderSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnFolderSelect.Depth = 0;
            this.BtnFolderSelect.HighEmphasis = true;
            this.BtnFolderSelect.Icon = null;
            this.BtnFolderSelect.Location = new System.Drawing.Point(66, 17);
            this.BtnFolderSelect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnFolderSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnFolderSelect.Name = "BtnFolderSelect";
            this.BtnFolderSelect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnFolderSelect.Size = new System.Drawing.Size(114, 36);
            this.BtnFolderSelect.TabIndex = 0;
            this.BtnFolderSelect.Text = "Klasör Seç : ";
            this.BtnFolderSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnFolderSelect.UseAccentColor = true;
            this.BtnFolderSelect.UseVisualStyleBackColor = true;
            this.BtnFolderSelect.Click += new System.EventHandler(this.BtnFolderSelect_Click);
            // 
            // txtBoxFolderPath
            // 
            this.txtBoxFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFolderPath.AnimateReadOnly = false;
            this.txtBoxFolderPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxFolderPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxFolderPath.Depth = 0;
            this.txtBoxFolderPath.Enabled = false;
            this.txtBoxFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxFolderPath.HideSelection = true;
            this.txtBoxFolderPath.LeadingIcon = null;
            this.txtBoxFolderPath.Location = new System.Drawing.Point(187, 11);
            this.txtBoxFolderPath.MaxLength = 32767;
            this.txtBoxFolderPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxFolderPath.Name = "txtBoxFolderPath";
            this.txtBoxFolderPath.PasswordChar = '\0';
            this.txtBoxFolderPath.PrefixSuffixText = null;
            this.txtBoxFolderPath.ReadOnly = true;
            this.txtBoxFolderPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxFolderPath.SelectedText = "";
            this.txtBoxFolderPath.SelectionLength = 0;
            this.txtBoxFolderPath.SelectionStart = 0;
            this.txtBoxFolderPath.ShortcutsEnabled = true;
            this.txtBoxFolderPath.Size = new System.Drawing.Size(257, 48);
            this.txtBoxFolderPath.TabIndex = 1;
            this.txtBoxFolderPath.TabStop = false;
            this.txtBoxFolderPath.Text = "Faturaların Bulunduğu Klasörü Seçiniz.";
            this.txtBoxFolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxFolderPath.TrailingIcon = null;
            this.txtBoxFolderPath.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.BtnCalculate, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.labelPtInfo, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(69, 100);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(527, 72);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCalculate.AutoSize = false;
            this.BtnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCalculate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnCalculate.Depth = 0;
            this.BtnCalculate.Enabled = false;
            this.BtnCalculate.HighEmphasis = true;
            this.BtnCalculate.Icon = null;
            this.BtnCalculate.Location = new System.Drawing.Point(195, 31);
            this.BtnCalculate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCalculate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnCalculate.Size = new System.Drawing.Size(137, 35);
            this.BtnCalculate.TabIndex = 1;
            this.BtnCalculate.Text = "hesapla";
            this.BtnCalculate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnCalculate.UseAccentColor = false;
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // labelPtInfo
            // 
            this.labelPtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPtInfo.AutoSize = true;
            this.labelPtInfo.Depth = 0;
            this.labelPtInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPtInfo.ForeColor = System.Drawing.Color.Red;
            this.labelPtInfo.Location = new System.Drawing.Point(3, 6);
            this.labelPtInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPtInfo.Name = "labelPtInfo";
            this.labelPtInfo.Size = new System.Drawing.Size(521, 19);
            this.labelPtInfo.TabIndex = 2;
            this.labelPtInfo.Text = "**Öncelikle Faturaların Bulunduğu Klasörü Seçmelisiniz.";
            this.labelPtInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPtInfo.UseAccent = true;
            // 
            // statisticPage
            // 
            this.statisticPage.AutoScroll = true;
            this.statisticPage.Controls.Add(this.tableLayoutPanel20);
            this.statisticPage.ImageKey = "icons8-statistics-32.png";
            this.statisticPage.Location = new System.Drawing.Point(4, 39);
            this.statisticPage.Name = "statisticPage";
            this.statisticPage.Size = new System.Drawing.Size(889, 621);
            this.statisticPage.TabIndex = 2;
            this.statisticPage.Text = "İstatistik";
            this.statisticPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 3;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel21, 1, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(889, 621);
            this.tableLayoutPanel20.TabIndex = 0;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel21.Controls.Add(this.mCardProfit, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel27, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(20, 15);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(847, 590);
            this.tableLayoutPanel21.TabIndex = 0;
            // 
            // mCardProfit
            // 
            this.mCardProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardProfit.Controls.Add(this.tableLayoutPanel22);
            this.mCardProfit.Depth = 0;
            this.mCardProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCardProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardProfit.Location = new System.Drawing.Point(564, 14);
            this.mCardProfit.Margin = new System.Windows.Forms.Padding(14);
            this.mCardProfit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardProfit.Name = "mCardProfit";
            this.mCardProfit.Padding = new System.Windows.Forms.Padding(14);
            this.mCardProfit.Size = new System.Drawing.Size(269, 562);
            this.mCardProfit.TabIndex = 0;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Controls.Add(this.mLabelProfitHeader, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel24, 0, 2);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 3;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(241, 534);
            this.tableLayoutPanel22.TabIndex = 0;
            // 
            // mLabelProfitHeader
            // 
            this.mLabelProfitHeader.AutoSize = true;
            this.mLabelProfitHeader.Depth = 0;
            this.mLabelProfitHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mLabelProfitHeader.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mLabelProfitHeader.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.mLabelProfitHeader.Location = new System.Drawing.Point(3, 0);
            this.mLabelProfitHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelProfitHeader.Name = "mLabelProfitHeader";
            this.mLabelProfitHeader.Size = new System.Drawing.Size(235, 50);
            this.mLabelProfitHeader.TabIndex = 0;
            this.mLabelProfitHeader.Text = "Gelir";
            this.mLabelProfitHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.38298F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.61702F));
            this.tableLayoutPanel23.Controls.Add(this.mLabelTProfit, 1, 1);
            this.tableLayoutPanel23.Controls.Add(this.materialLabel23, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.materialLabel24, 0, 1);
            this.tableLayoutPanel23.Controls.Add(this.mLabelTInvoice, 1, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 2;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(235, 74);
            this.tableLayoutPanel23.TabIndex = 1;
            // 
            // mLabelTProfit
            // 
            this.mLabelTProfit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mLabelTProfit.AutoSize = true;
            this.mLabelTProfit.Depth = 0;
            this.mLabelTProfit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLabelTProfit.Location = new System.Drawing.Point(112, 47);
            this.mLabelTProfit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTProfit.Name = "mLabelTProfit";
            this.mLabelTProfit.Size = new System.Drawing.Size(31, 19);
            this.mLabelTProfit.TabIndex = 3;
            this.mLabelTProfit.Text = "0,00";
            this.mLabelTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel23
            // 
            this.materialLabel23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel23.Location = new System.Drawing.Point(59, 11);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(47, 17);
            this.materialLabel23.TabIndex = 0;
            this.materialLabel23.Text = "Fatura:";
            this.materialLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel24
            // 
            this.materialLabel24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel24.Location = new System.Drawing.Point(54, 48);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(52, 17);
            this.materialLabel24.TabIndex = 1;
            this.materialLabel24.Text = "Kazanç:";
            this.materialLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mLabelTInvoice
            // 
            this.mLabelTInvoice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mLabelTInvoice.AutoSize = true;
            this.mLabelTInvoice.Depth = 0;
            this.mLabelTInvoice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLabelTInvoice.Location = new System.Drawing.Point(112, 10);
            this.mLabelTInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelTInvoice.Name = "mLabelTInvoice";
            this.mLabelTInvoice.Size = new System.Drawing.Size(31, 19);
            this.mLabelTInvoice.TabIndex = 2;
            this.mLabelTInvoice.Text = "0,00";
            this.mLabelTInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 1;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Controls.Add(this.elementHost4, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel25, 0, 1);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 2;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(235, 398);
            this.tableLayoutPanel24.TabIndex = 2;
            // 
            // elementHost4
            // 
            this.elementHost4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost4.Location = new System.Drawing.Point(3, 3);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(229, 153);
            this.elementHost4.TabIndex = 0;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.pieChart1;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 1;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Controls.Add(this.elementHost5, 0, 1);
            this.tableLayoutPanel25.Controls.Add(this.tableLayoutPanelRadio, 0, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(3, 162);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 2;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(229, 233);
            this.tableLayoutPanel25.TabIndex = 1;
            // 
            // elementHost5
            // 
            this.elementHost5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost5.Location = new System.Drawing.Point(3, 49);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(223, 181);
            this.elementHost5.TabIndex = 0;
            this.elementHost5.Text = "elementHost5";
            this.elementHost5.Child = this.cartesianChart1;
            // 
            // tableLayoutPanelRadio
            // 
            this.tableLayoutPanelRadio.ColumnCount = 2;
            this.tableLayoutPanelRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRadio.Controls.Add(this.mRadioBtnStacked, 0, 0);
            this.tableLayoutPanelRadio.Controls.Add(this.mRadioBtnColumn, 1, 0);
            this.tableLayoutPanelRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRadio.Enabled = false;
            this.tableLayoutPanelRadio.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelRadio.Name = "tableLayoutPanelRadio";
            this.tableLayoutPanelRadio.RowCount = 1;
            this.tableLayoutPanelRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRadio.Size = new System.Drawing.Size(223, 40);
            this.tableLayoutPanelRadio.TabIndex = 1;
            // 
            // mRadioBtnStacked
            // 
            this.mRadioBtnStacked.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mRadioBtnStacked.AutoSize = true;
            this.mRadioBtnStacked.Checked = true;
            this.mRadioBtnStacked.Depth = 0;
            this.mRadioBtnStacked.Location = new System.Drawing.Point(40, 1);
            this.mRadioBtnStacked.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioBtnStacked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioBtnStacked.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioBtnStacked.Name = "mRadioBtnStacked";
            this.mRadioBtnStacked.Ripple = true;
            this.mRadioBtnStacked.Size = new System.Drawing.Size(71, 37);
            this.mRadioBtnStacked.TabIndex = 0;
            this.mRadioBtnStacked.TabStop = true;
            this.mRadioBtnStacked.Text = "Yığın";
            this.mRadioBtnStacked.UseVisualStyleBackColor = true;
            this.mRadioBtnStacked.CheckedChanged += new System.EventHandler(this.mRadioBtnStacked_CheckedChanged);
            // 
            // mRadioBtnColumn
            // 
            this.mRadioBtnColumn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mRadioBtnColumn.AutoSize = true;
            this.mRadioBtnColumn.Depth = 0;
            this.mRadioBtnColumn.Location = new System.Drawing.Point(111, 1);
            this.mRadioBtnColumn.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioBtnColumn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioBtnColumn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioBtnColumn.Name = "mRadioBtnColumn";
            this.mRadioBtnColumn.Ripple = true;
            this.mRadioBtnColumn.Size = new System.Drawing.Size(71, 37);
            this.mRadioBtnColumn.TabIndex = 1;
            this.mRadioBtnColumn.TabStop = true;
            this.mRadioBtnColumn.Text = "Sıralı";
            this.mRadioBtnColumn.UseVisualStyleBackColor = true;
            this.mRadioBtnColumn.CheckedChanged += new System.EventHandler(this.mRadioBtnColumn_CheckedChanged);
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 1;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Controls.Add(this.materialCard10, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.mCardPreview, 0, 2);
            this.tableLayoutPanel27.Controls.Add(this.tableLayoutPanel26, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.mCardTable, 0, 3);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 4;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(544, 584);
            this.tableLayoutPanel27.TabIndex = 1;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.tableLayoutPanel28);
            this.materialCard10.Depth = 0;
            this.materialCard10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(14, 14);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(516, 54);
            this.materialCard10.TabIndex = 0;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 8;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel28.Controls.Add(this.materialLabel25, 0, 0);
            this.tableLayoutPanel28.Controls.Add(this.mBtnClear, 6, 0);
            this.tableLayoutPanel28.Controls.Add(this.mBtnCalculateStatistic, 4, 0);
            this.tableLayoutPanel28.Controls.Add(this.mBtnFileSelect, 2, 0);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 1;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(488, 26);
            this.tableLayoutPanel28.TabIndex = 0;
            // 
            // materialLabel25
            // 
            this.materialLabel25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel25.Location = new System.Drawing.Point(5, 1);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(55, 24);
            this.materialLabel25.TabIndex = 0;
            this.materialLabel25.Text = "İşlem:";
            // 
            // mBtnClear
            // 
            this.mBtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mBtnClear.Depth = 0;
            this.mBtnClear.Enabled = false;
            this.mBtnClear.HighEmphasis = true;
            this.mBtnClear.Icon = null;
            this.mBtnClear.Location = new System.Drawing.Point(353, 6);
            this.mBtnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnClear.Name = "mBtnClear";
            this.mBtnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mBtnClear.Size = new System.Drawing.Size(114, 14);
            this.mBtnClear.TabIndex = 3;
            this.mBtnClear.Text = "Temizle";
            this.mBtnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mBtnClear.UseAccentColor = true;
            this.mBtnClear.UseVisualStyleBackColor = true;
            this.mBtnClear.Click += new System.EventHandler(this.mBtnClear_Click);
            // 
            // mBtnCalculateStatistic
            // 
            this.mBtnCalculateStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnCalculateStatistic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnCalculateStatistic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mBtnCalculateStatistic.Depth = 0;
            this.mBtnCalculateStatistic.Enabled = false;
            this.mBtnCalculateStatistic.HighEmphasis = true;
            this.mBtnCalculateStatistic.Icon = null;
            this.mBtnCalculateStatistic.Location = new System.Drawing.Point(217, 6);
            this.mBtnCalculateStatistic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnCalculateStatistic.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnCalculateStatistic.Name = "mBtnCalculateStatistic";
            this.mBtnCalculateStatistic.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mBtnCalculateStatistic.Size = new System.Drawing.Size(114, 14);
            this.mBtnCalculateStatistic.TabIndex = 2;
            this.mBtnCalculateStatistic.Text = "Hesapla";
            this.mBtnCalculateStatistic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mBtnCalculateStatistic.UseAccentColor = false;
            this.mBtnCalculateStatistic.UseVisualStyleBackColor = true;
            this.mBtnCalculateStatistic.Click += new System.EventHandler(this.mBtnCalculateStatistic_Click);
            // 
            // mBtnFileSelect
            // 
            this.mBtnFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnFileSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnFileSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mBtnFileSelect.Depth = 0;
            this.mBtnFileSelect.HighEmphasis = true;
            this.mBtnFileSelect.Icon = null;
            this.mBtnFileSelect.Location = new System.Drawing.Point(81, 6);
            this.mBtnFileSelect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnFileSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnFileSelect.Name = "mBtnFileSelect";
            this.mBtnFileSelect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mBtnFileSelect.Size = new System.Drawing.Size(114, 14);
            this.mBtnFileSelect.TabIndex = 1;
            this.mBtnFileSelect.Text = "Dosya Seç";
            this.mBtnFileSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.mBtnFileSelect.UseAccentColor = true;
            this.mBtnFileSelect.UseVisualStyleBackColor = true;
            this.mBtnFileSelect.Click += new System.EventHandler(this.mBtnFileSelect_Click);
            // 
            // mCardPreview
            // 
            this.mCardPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardPreview.Controls.Add(this.tableLayoutPanel29);
            this.mCardPreview.Depth = 0;
            this.mCardPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCardPreview.Enabled = false;
            this.mCardPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardPreview.Location = new System.Drawing.Point(14, 131);
            this.mCardPreview.Margin = new System.Windows.Forms.Padding(14);
            this.mCardPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardPreview.Name = "mCardPreview";
            this.mCardPreview.Padding = new System.Windows.Forms.Padding(14);
            this.mCardPreview.Size = new System.Drawing.Size(516, 180);
            this.mCardPreview.TabIndex = 1;
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 2;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.08197F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.91803F));
            this.tableLayoutPanel29.Controls.Add(this.tableLayoutPanel30, 0, 0);
            this.tableLayoutPanel29.Controls.Add(this.solidGauge1, 1, 0);
            this.tableLayoutPanel29.Controls.Add(this.tableLayoutPanel31, 0, 1);
            this.tableLayoutPanel29.Controls.Add(this.tableLayoutPanel19, 1, 1);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 2;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(488, 152);
            this.tableLayoutPanel29.TabIndex = 0;
            // 
            // tableLayoutPanel30
            // 
            this.tableLayoutPanel30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel30.ColumnCount = 2;
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.2029F));
            this.tableLayoutPanel30.Controls.Add(this.materialLabel26, 0, 1);
            this.tableLayoutPanel30.Controls.Add(this.materialLabel27, 0, 0);
            this.tableLayoutPanel30.Controls.Add(this.MaskTxtBoxNewFee, 1, 0);
            this.tableLayoutPanel30.Controls.Add(this.MaskTxtBoxNewComm, 1, 1);
            this.tableLayoutPanel30.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel30.Name = "tableLayoutPanel30";
            this.tableLayoutPanel30.RowCount = 2;
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.Size = new System.Drawing.Size(214, 102);
            this.tableLayoutPanel30.TabIndex = 4;
            // 
            // materialLabel26
            // 
            this.materialLabel26.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel26.Location = new System.Drawing.Point(5, 68);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(68, 17);
            this.materialLabel26.TabIndex = 2;
            this.materialLabel26.Text = "Komisyon:";
            this.materialLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel27
            // 
            this.materialLabel27.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel27.Location = new System.Drawing.Point(34, 17);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(39, 17);
            this.materialLabel27.TabIndex = 1;
            this.materialLabel27.Text = "Aidat:";
            this.materialLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaskTxtBoxNewFee
            // 
            this.MaskTxtBoxNewFee.AllowPromptAsInput = true;
            this.MaskTxtBoxNewFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskTxtBoxNewFee.AnimateReadOnly = false;
            this.MaskTxtBoxNewFee.AsciiOnly = false;
            this.MaskTxtBoxNewFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaskTxtBoxNewFee.BeepOnError = true;
            this.MaskTxtBoxNewFee.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxNewFee.Depth = 0;
            this.MaskTxtBoxNewFee.ErrorMessage = "Hata!!";
            this.MaskTxtBoxNewFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaskTxtBoxNewFee.HelperText = "500,00";
            this.MaskTxtBoxNewFee.HidePromptOnLeave = false;
            this.MaskTxtBoxNewFee.HideSelection = true;
            this.MaskTxtBoxNewFee.Hint = "Yeni Değer";
            this.MaskTxtBoxNewFee.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MaskTxtBoxNewFee.LeadingIcon = null;
            this.MaskTxtBoxNewFee.LeaveOnEnterKey = true;
            this.MaskTxtBoxNewFee.Location = new System.Drawing.Point(79, 3);
            this.MaskTxtBoxNewFee.Mask = "";
            this.MaskTxtBoxNewFee.MaximumSize = new System.Drawing.Size(280, 48);
            this.MaskTxtBoxNewFee.MaxLength = 32767;
            this.MaskTxtBoxNewFee.MouseState = MaterialSkin.MouseState.OUT;
            this.MaskTxtBoxNewFee.Name = "MaskTxtBoxNewFee";
            this.MaskTxtBoxNewFee.PasswordChar = '\0';
            this.MaskTxtBoxNewFee.PrefixSuffixText = "₺";
            this.MaskTxtBoxNewFee.PromptChar = '_';
            this.MaskTxtBoxNewFee.ReadOnly = false;
            this.MaskTxtBoxNewFee.RejectInputOnFirstFailure = false;
            this.MaskTxtBoxNewFee.ResetOnPrompt = true;
            this.MaskTxtBoxNewFee.ResetOnSpace = true;
            this.MaskTxtBoxNewFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaskTxtBoxNewFee.SelectedText = "";
            this.MaskTxtBoxNewFee.SelectionLength = 0;
            this.MaskTxtBoxNewFee.SelectionStart = 0;
            this.MaskTxtBoxNewFee.ShortcutsEnabled = true;
            this.MaskTxtBoxNewFee.ShowAssistiveText = true;
            this.MaskTxtBoxNewFee.Size = new System.Drawing.Size(132, 48);
            this.MaskTxtBoxNewFee.SkipLiterals = true;
            this.MaskTxtBoxNewFee.TabIndex = 3;
            this.MaskTxtBoxNewFee.TabStop = false;
            this.MaskTxtBoxNewFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaskTxtBoxNewFee.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxNewFee.TrailingIcon = global::KomisyonNET.Properties.Resources.fee_50;
            this.MaskTxtBoxNewFee.UseSystemPasswordChar = false;
            this.MaskTxtBoxNewFee.ValidatingType = null;
            // 
            // MaskTxtBoxNewComm
            // 
            this.MaskTxtBoxNewComm.AllowPromptAsInput = true;
            this.MaskTxtBoxNewComm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskTxtBoxNewComm.AnimateReadOnly = false;
            this.MaskTxtBoxNewComm.AsciiOnly = false;
            this.MaskTxtBoxNewComm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaskTxtBoxNewComm.BeepOnError = false;
            this.MaskTxtBoxNewComm.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxNewComm.Depth = 0;
            this.MaskTxtBoxNewComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaskTxtBoxNewComm.HidePromptOnLeave = false;
            this.MaskTxtBoxNewComm.HideSelection = true;
            this.MaskTxtBoxNewComm.Hint = "Yeni Oran";
            this.MaskTxtBoxNewComm.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MaskTxtBoxNewComm.LeadingIcon = null;
            this.MaskTxtBoxNewComm.Location = new System.Drawing.Point(79, 54);
            this.MaskTxtBoxNewComm.Mask = "";
            this.MaskTxtBoxNewComm.MaximumSize = new System.Drawing.Size(280, 48);
            this.MaskTxtBoxNewComm.MaxLength = 32767;
            this.MaskTxtBoxNewComm.MouseState = MaterialSkin.MouseState.OUT;
            this.MaskTxtBoxNewComm.Name = "MaskTxtBoxNewComm";
            this.MaskTxtBoxNewComm.PasswordChar = '\0';
            this.MaskTxtBoxNewComm.PrefixSuffixText = "%";
            this.MaskTxtBoxNewComm.PromptChar = '_';
            this.MaskTxtBoxNewComm.ReadOnly = false;
            this.MaskTxtBoxNewComm.RejectInputOnFirstFailure = false;
            this.MaskTxtBoxNewComm.ResetOnPrompt = true;
            this.MaskTxtBoxNewComm.ResetOnSpace = true;
            this.MaskTxtBoxNewComm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaskTxtBoxNewComm.SelectedText = "";
            this.MaskTxtBoxNewComm.SelectionLength = 0;
            this.MaskTxtBoxNewComm.SelectionStart = 0;
            this.MaskTxtBoxNewComm.ShortcutsEnabled = true;
            this.MaskTxtBoxNewComm.Size = new System.Drawing.Size(132, 48);
            this.MaskTxtBoxNewComm.SkipLiterals = true;
            this.MaskTxtBoxNewComm.TabIndex = 4;
            this.MaskTxtBoxNewComm.TabStop = false;
            this.MaskTxtBoxNewComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaskTxtBoxNewComm.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxNewComm.TrailingIcon = global::KomisyonNET.Properties.Resources.commission_50;
            this.MaskTxtBoxNewComm.UseSystemPasswordChar = false;
            this.MaskTxtBoxNewComm.ValidatingType = null;
            // 
            // solidGauge1
            // 
            this.solidGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solidGauge1.Location = new System.Drawing.Point(235, 15);
            this.solidGauge1.Margin = new System.Windows.Forms.Padding(15);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(238, 91);
            this.solidGauge1.TabIndex = 0;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // tableLayoutPanel31
            // 
            this.tableLayoutPanel31.ColumnCount = 3;
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel31.Controls.Add(this.mBtnPreview, 1, 0);
            this.tableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel31.Location = new System.Drawing.Point(3, 124);
            this.tableLayoutPanel31.Name = "tableLayoutPanel31";
            this.tableLayoutPanel31.RowCount = 1;
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel31.Size = new System.Drawing.Size(214, 25);
            this.tableLayoutPanel31.TabIndex = 6;
            // 
            // mBtnPreview
            // 
            this.mBtnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mBtnPreview.Depth = 0;
            this.mBtnPreview.HighEmphasis = true;
            this.mBtnPreview.Icon = null;
            this.mBtnPreview.Location = new System.Drawing.Point(32, 0);
            this.mBtnPreview.Margin = new System.Windows.Forms.Padding(0);
            this.mBtnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnPreview.Name = "mBtnPreview";
            this.mBtnPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mBtnPreview.Size = new System.Drawing.Size(149, 25);
            this.mBtnPreview.TabIndex = 5;
            this.mBtnPreview.Text = "Önizleme";
            this.mBtnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mBtnPreview.UseAccentColor = false;
            this.mBtnPreview.UseVisualStyleBackColor = true;
            this.mBtnPreview.Click += new System.EventHandler(this.mBtnPreview_Click);
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.labelTest, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.materialLabel28, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(223, 124);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(262, 25);
            this.tableLayoutPanel19.TabIndex = 7;
            // 
            // labelTest
            // 
            this.labelTest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTest.AutoSize = true;
            this.labelTest.Depth = 0;
            this.labelTest.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTest.Location = new System.Drawing.Point(134, 3);
            this.labelTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(31, 19);
            this.labelTest.TabIndex = 0;
            this.labelTest.Text = "0,00";
            // 
            // materialLabel28
            // 
            this.materialLabel28.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel28.Location = new System.Drawing.Point(65, 4);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(63, 17);
            this.materialLabel28.TabIndex = 1;
            this.materialLabel28.Text = "Değişim : ";
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel26.ColumnCount = 3;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel26.Controls.Add(this.mCbxPreview, 1, 0);
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 85);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(538, 29);
            this.tableLayoutPanel26.TabIndex = 2;
            // 
            // mCbxPreview
            // 
            this.mCbxPreview.AutoSize = true;
            this.mCbxPreview.Depth = 0;
            this.mCbxPreview.Enabled = false;
            this.mCbxPreview.Location = new System.Drawing.Point(5, 0);
            this.mCbxPreview.Margin = new System.Windows.Forms.Padding(0);
            this.mCbxPreview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mCbxPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCbxPreview.Name = "mCbxPreview";
            this.mCbxPreview.ReadOnly = false;
            this.mCbxPreview.Ripple = true;
            this.mCbxPreview.Size = new System.Drawing.Size(355, 29);
            this.mCbxPreview.TabIndex = 0;
            this.mCbxPreview.Text = "Yeni Değerler ile Önizleme Yapmak İstiyorum.";
            this.mCbxPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mCbxPreview.UseVisualStyleBackColor = true;
            this.mCbxPreview.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // mCardTable
            // 
            this.mCardTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardTable.Controls.Add(this.tableLayoutPanel32);
            this.mCardTable.Depth = 0;
            this.mCardTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCardTable.Enabled = false;
            this.mCardTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardTable.Location = new System.Drawing.Point(14, 339);
            this.mCardTable.Margin = new System.Windows.Forms.Padding(14);
            this.mCardTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardTable.Name = "mCardTable";
            this.mCardTable.Padding = new System.Windows.Forms.Padding(14);
            this.mCardTable.Size = new System.Drawing.Size(516, 231);
            this.mCardTable.TabIndex = 3;
            // 
            // tableLayoutPanel32
            // 
            this.tableLayoutPanel32.ColumnCount = 1;
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel32.Controls.Add(this.mListViewTable, 0, 1);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel33, 0, 0);
            this.tableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel32.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel32.Name = "tableLayoutPanel32";
            this.tableLayoutPanel32.RowCount = 2;
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76355F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.23645F));
            this.tableLayoutPanel32.Size = new System.Drawing.Size(488, 203);
            this.tableLayoutPanel32.TabIndex = 13;
            // 
            // mListViewTable
            // 
            this.mListViewTable.AutoSizeTable = false;
            this.mListViewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mListViewTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mListViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNameSurname,
            this.colTInvoice,
            this.colFee,
            this.colCommission,
            this.colEarn,
            this.colEarnRate});
            this.mListViewTable.Depth = 0;
            this.mListViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mListViewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mListViewTable.FullRowSelect = true;
            this.mListViewTable.HideSelection = false;
            this.mListViewTable.Location = new System.Drawing.Point(3, 35);
            this.mListViewTable.MinimumSize = new System.Drawing.Size(200, 100);
            this.mListViewTable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mListViewTable.MouseState = MaterialSkin.MouseState.OUT;
            this.mListViewTable.Name = "mListViewTable";
            this.mListViewTable.OwnerDraw = true;
            this.mListViewTable.Size = new System.Drawing.Size(482, 165);
            this.mListViewTable.TabIndex = 12;
            this.mListViewTable.UseCompatibleStateImageBehavior = false;
            this.mListViewTable.View = System.Windows.Forms.View.Details;
            // 
            // colNameSurname
            // 
            this.colNameSurname.Text = "İsim Soyisim";
            this.colNameSurname.Width = 150;
            // 
            // colTInvoice
            // 
            this.colTInvoice.Text = "Fatura Tutarı";
            this.colTInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTInvoice.Width = 130;
            // 
            // colFee
            // 
            this.colFee.Text = "Aidat Tutarı";
            this.colFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFee.Width = 130;
            // 
            // colCommission
            // 
            this.colCommission.Text = "Komisyon Miktarı";
            this.colCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCommission.Width = 150;
            // 
            // colEarn
            // 
            this.colEarn.Text = "Kazanç";
            this.colEarn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEarn.Width = 130;
            // 
            // colEarnRate
            // 
            this.colEarnRate.Text = "Gelire Katkı (%)";
            this.colEarnRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEarnRate.Width = 130;
            // 
            // tableLayoutPanel33
            // 
            this.tableLayoutPanel33.ColumnCount = 4;
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Controls.Add(this.mRadioBtnName, 1, 0);
            this.tableLayoutPanel33.Controls.Add(this.mRadioBtnEarn, 2, 0);
            this.tableLayoutPanel33.Controls.Add(this.materialLabel22, 0, 0);
            this.tableLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel33.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel33.Name = "tableLayoutPanel33";
            this.tableLayoutPanel33.RowCount = 1;
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Size = new System.Drawing.Size(482, 26);
            this.tableLayoutPanel33.TabIndex = 13;
            // 
            // mRadioBtnName
            // 
            this.mRadioBtnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mRadioBtnName.AutoSize = true;
            this.mRadioBtnName.Depth = 0;
            this.mRadioBtnName.Location = new System.Drawing.Point(100, 0);
            this.mRadioBtnName.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioBtnName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioBtnName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioBtnName.Name = "mRadioBtnName";
            this.mRadioBtnName.Ripple = true;
            this.mRadioBtnName.Size = new System.Drawing.Size(150, 26);
            this.mRadioBtnName.TabIndex = 2;
            this.mRadioBtnName.TabStop = true;
            this.mRadioBtnName.Text = "İsim Soyisim";
            this.mRadioBtnName.UseVisualStyleBackColor = true;
            this.mRadioBtnName.CheckedChanged += new System.EventHandler(this.mRadioBtnName_CheckedChanged);
            // 
            // mRadioBtnEarn
            // 
            this.mRadioBtnEarn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mRadioBtnEarn.AutoSize = true;
            this.mRadioBtnEarn.Depth = 0;
            this.mRadioBtnEarn.Location = new System.Drawing.Point(250, 0);
            this.mRadioBtnEarn.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioBtnEarn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioBtnEarn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioBtnEarn.Name = "mRadioBtnEarn";
            this.mRadioBtnEarn.Ripple = true;
            this.mRadioBtnEarn.Size = new System.Drawing.Size(150, 26);
            this.mRadioBtnEarn.TabIndex = 3;
            this.mRadioBtnEarn.TabStop = true;
            this.mRadioBtnEarn.Text = "Kazanç";
            this.mRadioBtnEarn.UseVisualStyleBackColor = true;
            this.mRadioBtnEarn.CheckedChanged += new System.EventHandler(this.mRadioBtnEarn_CheckedChanged);
            // 
            // materialLabel22
            // 
            this.materialLabel22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel22.Location = new System.Drawing.Point(25, 3);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(50, 19);
            this.materialLabel22.TabIndex = 4;
            this.materialLabel22.Text = "Sırala :";
            // 
            // settingsPage
            // 
            this.settingsPage.AllowDrop = true;
            this.settingsPage.AutoScroll = true;
            this.settingsPage.Controls.Add(this.tableLayoutPanel3);
            this.settingsPage.ImageKey = "icons8-settings-32.png";
            this.settingsPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.settingsPage.Location = new System.Drawing.Point(4, 39);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(889, 621);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Ayarlar";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.78505F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.21495F));
            this.tableLayoutPanel3.Controls.Add(this.materialCard2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialCard3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnSave, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.materialCard4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.materialCard6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel17, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(856, 592);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tableLayoutPanel4);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(518, 244);
            this.materialCard2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 14);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(480, 213);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(121, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(237, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Export edilecek dosya yolu";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.Location = new System.Drawing.Point(21, 59);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(438, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "İşlenen Excel dosyasının hangi klasöre çıkarılacağını belirtiniz.";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.30802F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.69199F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel5.Controls.Add(this.txtBoxExportPath, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.BtnExportPath, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 108);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(474, 102);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // txtBoxExportPath
            // 
            this.txtBoxExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxExportPath.AnimateReadOnly = false;
            this.txtBoxExportPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxExportPath.Depth = 0;
            this.txtBoxExportPath.Enabled = false;
            this.txtBoxExportPath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxExportPath.LeadingIcon = null;
            this.txtBoxExportPath.Location = new System.Drawing.Point(90, 25);
            this.txtBoxExportPath.MaxLength = 50;
            this.txtBoxExportPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxExportPath.Multiline = false;
            this.txtBoxExportPath.Name = "txtBoxExportPath";
            this.txtBoxExportPath.ReadOnly = true;
            this.txtBoxExportPath.Size = new System.Drawing.Size(317, 50);
            this.txtBoxExportPath.TabIndex = 0;
            this.txtBoxExportPath.Text = "";
            this.txtBoxExportPath.TrailingIcon = null;
            // 
            // BtnExportPath
            // 
            this.BtnExportPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExportPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExportPath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnExportPath.Depth = 0;
            this.BtnExportPath.HighEmphasis = true;
            this.BtnExportPath.Icon = null;
            this.BtnExportPath.Location = new System.Drawing.Point(4, 32);
            this.BtnExportPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExportPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExportPath.Name = "BtnExportPath";
            this.BtnExportPath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnExportPath.Size = new System.Drawing.Size(79, 36);
            this.BtnExportPath.TabIndex = 1;
            this.BtnExportPath.Text = "Yol Seç :";
            this.BtnExportPath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnExportPath.UseAccentColor = true;
            this.BtnExportPath.UseVisualStyleBackColor = true;
            this.BtnExportPath.Click += new System.EventHandler(this.BtnExportPath_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tableLayoutPanel6);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(560, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(282, 244);
            this.materialCard3.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.materialLabel4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.05785F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.94215F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(254, 216);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.materialRadioButton3);
            this.groupBox2.Controls.Add(this.materialRadioButton1);
            this.groupBox2.Controls.Add(this.materialRadioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(3, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(248, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Düzeni";
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Location = new System.Drawing.Point(27, 87);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(184, 37);
            this.materialRadioButton3.TabIndex = 8;
            this.materialRadioButton3.TabStop = true;
            this.materialRadioButton3.Text = "Üçüncül Renk Düzeni";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            this.materialRadioButton3.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(27, 50);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(168, 37);
            this.materialRadioButton1.TabIndex = 7;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "İkincil Renk Düzeni";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Location = new System.Drawing.Point(27, 13);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(175, 37);
            this.materialRadioButton2.TabIndex = 6;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Birincil Renk Düzeni";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(85, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(83, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Görünüm";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.themeSwitch);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(248, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tema";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(44, 21);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(57, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Aydınlık";
            // 
            // themeSwitch
            // 
            this.themeSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.themeSwitch.AutoSize = true;
            this.themeSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.themeSwitch.Depth = 0;
            this.themeSwitch.Location = new System.Drawing.Point(106, 12);
            this.themeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.themeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeSwitch.Name = "themeSwitch";
            this.themeSwitch.Ripple = true;
            this.themeSwitch.Size = new System.Drawing.Size(94, 37);
            this.themeSwitch.TabIndex = 1;
            this.themeSwitch.Text = "Koyu";
            this.themeSwitch.UseCompatibleTextRendering = true;
            this.themeSwitch.UseVisualStyleBackColor = true;
            this.themeSwitch.CheckedChanged += new System.EventHandler(this.themeSwitch_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSave.AutoSize = false;
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSave.Depth = 0;
            this.BtnSave.Enabled = false;
            this.BtnSave.HighEmphasis = true;
            this.BtnSave.Icon = null;
            this.BtnSave.Location = new System.Drawing.Point(550, 550);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSave.Size = new System.Drawing.Size(158, 36);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSave.UseAccentColor = false;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.tableLayoutPanel7);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(560, 286);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(282, 163);
            this.materialCard4.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.materialLabel6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.materialLabel7, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.57576F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.42424F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(254, 135);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(115, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(24, 24);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Dil";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel7.Location = new System.Drawing.Point(3, 40);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(248, 19);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "Dil seçenekleri eklenecek.";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.09091F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.90909F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel8.Controls.Add(this.materialLabel8, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.mComboBoxLanguage, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(248, 59);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel8.Location = new System.Drawing.Point(7, 21);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(73, 17);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Dil Tercihi :";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mComboBoxLanguage
            // 
            this.mComboBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mComboBoxLanguage.AutoResize = false;
            this.mComboBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mComboBoxLanguage.Depth = 0;
            this.mComboBoxLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mComboBoxLanguage.DropDownHeight = 174;
            this.mComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mComboBoxLanguage.DropDownWidth = 121;
            this.mComboBoxLanguage.Enabled = false;
            this.mComboBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mComboBoxLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mComboBoxLanguage.FormattingEnabled = true;
            this.mComboBoxLanguage.IntegralHeight = false;
            this.mComboBoxLanguage.ItemHeight = 43;
            this.mComboBoxLanguage.Items.AddRange(new object[] {
            "Türkçe",
            "English"});
            this.mComboBoxLanguage.Location = new System.Drawing.Point(86, 5);
            this.mComboBoxLanguage.MaxDropDownItems = 4;
            this.mComboBoxLanguage.MaximumSize = new System.Drawing.Size(190, 0);
            this.mComboBoxLanguage.MouseState = MaterialSkin.MouseState.OUT;
            this.mComboBoxLanguage.Name = "mComboBoxLanguage";
            this.mComboBoxLanguage.Size = new System.Drawing.Size(99, 49);
            this.mComboBoxLanguage.StartIndex = 0;
            this.mComboBoxLanguage.TabIndex = 1;
            // 
            // materialCard6
            // 
            this.materialCard6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.tableLayoutPanel15);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 286);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(518, 244);
            this.materialCard6.TabIndex = 5;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.materialLabel15, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.materialLabel16, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.materialLabel17, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel16, 0, 3);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 4;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(490, 216);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // materialLabel15
            // 
            this.materialLabel15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel15.Location = new System.Drawing.Point(174, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(141, 24);
            this.materialLabel15.TabIndex = 0;
            this.materialLabel15.Text = "Fatura İşlemleri";
            // 
            // materialLabel16
            // 
            this.materialLabel16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel16.Location = new System.Drawing.Point(29, 37);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(431, 19);
            this.materialLabel16.TabIndex = 1;
            this.materialLabel16.Text = "Faturaların hesaplamasında Kullanılacak Aidat ve Komisyon ";
            // 
            // materialLabel17
            // 
            this.materialLabel17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel17.Location = new System.Drawing.Point(163, 60);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(164, 19);
            this.materialLabel17.TabIndex = 2;
            this.materialLabel17.Text = "miktarlarını belirleyiniz.";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.90722F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.09278F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel16.Controls.Add(this.materialLabel19, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.materialLabel18, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.MaskTxtBoxFee, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.MaskTxtBoxComm, 1, 1);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(484, 105);
            this.tableLayoutPanel16.TabIndex = 3;
            // 
            // materialLabel19
            // 
            this.materialLabel19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel19.Location = new System.Drawing.Point(44, 70);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(135, 17);
            this.materialLabel19.TabIndex = 2;
            this.materialLabel19.Text = "Komisyon Oranı (%) : ";
            this.materialLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel18
            // 
            this.materialLabel18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel18.Location = new System.Drawing.Point(68, 17);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(111, 17);
            this.materialLabel18.TabIndex = 1;
            this.materialLabel18.Text = "Aidat Miktarı (₺) :";
            this.materialLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaskTxtBoxFee
            // 
            this.MaskTxtBoxFee.AllowPromptAsInput = true;
            this.MaskTxtBoxFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskTxtBoxFee.AnimateReadOnly = false;
            this.MaskTxtBoxFee.AsciiOnly = false;
            this.MaskTxtBoxFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaskTxtBoxFee.BeepOnError = true;
            this.MaskTxtBoxFee.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxFee.Depth = 0;
            this.MaskTxtBoxFee.ErrorMessage = "Hata!!";
            this.MaskTxtBoxFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaskTxtBoxFee.HelperText = "500,00";
            this.MaskTxtBoxFee.HidePromptOnLeave = false;
            this.MaskTxtBoxFee.HideSelection = true;
            this.MaskTxtBoxFee.Hint = "ör: 1050,90";
            this.MaskTxtBoxFee.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MaskTxtBoxFee.LeadingIcon = null;
            this.MaskTxtBoxFee.LeaveOnEnterKey = true;
            this.MaskTxtBoxFee.Location = new System.Drawing.Point(185, 3);
            this.MaskTxtBoxFee.Mask = "";
            this.MaskTxtBoxFee.MaximumSize = new System.Drawing.Size(280, 48);
            this.MaskTxtBoxFee.MaxLength = 32767;
            this.MaskTxtBoxFee.MouseState = MaterialSkin.MouseState.OUT;
            this.MaskTxtBoxFee.Name = "MaskTxtBoxFee";
            this.MaskTxtBoxFee.PasswordChar = '\0';
            this.MaskTxtBoxFee.PrefixSuffixText = "₺";
            this.MaskTxtBoxFee.PromptChar = '_';
            this.MaskTxtBoxFee.ReadOnly = false;
            this.MaskTxtBoxFee.RejectInputOnFirstFailure = false;
            this.MaskTxtBoxFee.ResetOnPrompt = true;
            this.MaskTxtBoxFee.ResetOnSpace = true;
            this.MaskTxtBoxFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaskTxtBoxFee.SelectedText = "";
            this.MaskTxtBoxFee.SelectionLength = 0;
            this.MaskTxtBoxFee.SelectionStart = 0;
            this.MaskTxtBoxFee.ShortcutsEnabled = true;
            this.MaskTxtBoxFee.ShowAssistiveText = true;
            this.MaskTxtBoxFee.Size = new System.Drawing.Size(200, 48);
            this.MaskTxtBoxFee.SkipLiterals = true;
            this.MaskTxtBoxFee.TabIndex = 3;
            this.MaskTxtBoxFee.TabStop = false;
            this.MaskTxtBoxFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaskTxtBoxFee.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxFee.TrailingIcon = global::KomisyonNET.Properties.Resources.fee_50;
            this.MaskTxtBoxFee.UseSystemPasswordChar = false;
            this.MaskTxtBoxFee.ValidatingType = null;
            // 
            // MaskTxtBoxComm
            // 
            this.MaskTxtBoxComm.AllowPromptAsInput = true;
            this.MaskTxtBoxComm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskTxtBoxComm.AnimateReadOnly = false;
            this.MaskTxtBoxComm.AsciiOnly = false;
            this.MaskTxtBoxComm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaskTxtBoxComm.BeepOnError = false;
            this.MaskTxtBoxComm.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxComm.Depth = 0;
            this.MaskTxtBoxComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaskTxtBoxComm.HidePromptOnLeave = false;
            this.MaskTxtBoxComm.HideSelection = true;
            this.MaskTxtBoxComm.Hint = "ör: 2,8";
            this.MaskTxtBoxComm.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MaskTxtBoxComm.LeadingIcon = null;
            this.MaskTxtBoxComm.Location = new System.Drawing.Point(185, 55);
            this.MaskTxtBoxComm.Mask = "";
            this.MaskTxtBoxComm.MaximumSize = new System.Drawing.Size(280, 48);
            this.MaskTxtBoxComm.MaxLength = 32767;
            this.MaskTxtBoxComm.MouseState = MaterialSkin.MouseState.OUT;
            this.MaskTxtBoxComm.Name = "MaskTxtBoxComm";
            this.MaskTxtBoxComm.PasswordChar = '\0';
            this.MaskTxtBoxComm.PrefixSuffixText = "%";
            this.MaskTxtBoxComm.PromptChar = '_';
            this.MaskTxtBoxComm.ReadOnly = false;
            this.MaskTxtBoxComm.RejectInputOnFirstFailure = false;
            this.MaskTxtBoxComm.ResetOnPrompt = true;
            this.MaskTxtBoxComm.ResetOnSpace = true;
            this.MaskTxtBoxComm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaskTxtBoxComm.SelectedText = "";
            this.MaskTxtBoxComm.SelectionLength = 0;
            this.MaskTxtBoxComm.SelectionStart = 0;
            this.MaskTxtBoxComm.ShortcutsEnabled = true;
            this.MaskTxtBoxComm.Size = new System.Drawing.Size(200, 48);
            this.MaskTxtBoxComm.SkipLiterals = true;
            this.MaskTxtBoxComm.TabIndex = 4;
            this.MaskTxtBoxComm.TabStop = false;
            this.MaskTxtBoxComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaskTxtBoxComm.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MaskTxtBoxComm.TrailingIcon = global::KomisyonNET.Properties.Resources.commission_50;
            this.MaskTxtBoxComm.UseSystemPasswordChar = false;
            this.MaskTxtBoxComm.ValidatingType = null;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.62963F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.37037F));
            this.tableLayoutPanel17.Controls.Add(this.BtnReset, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel18, 0, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 547);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(540, 42);
            this.tableLayoutPanel17.TabIndex = 6;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnReset.AutoSize = false;
            this.BtnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReset.Depth = 0;
            this.BtnReset.HighEmphasis = true;
            this.BtnReset.Icon = null;
            this.BtnReset.Location = new System.Drawing.Point(380, 6);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnReset.Size = new System.Drawing.Size(156, 30);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Sıfırla";
            this.BtnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnReset.UseAccentColor = false;
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Controls.Add(this.materialLabel21, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.materialLabel20, 0, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(370, 36);
            this.tableLayoutPanel18.TabIndex = 3;
            // 
            // materialLabel21
            // 
            this.materialLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel21.Location = new System.Drawing.Point(3, 18);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(364, 14);
            this.materialLabel21.TabIndex = 3;
            this.materialLabel21.Text = "** Mevcut ayarları yüklemek için \'SIFIRLA\' ya basınız.";
            this.materialLabel21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel21.UseAccent = true;
            // 
            // materialLabel20
            // 
            this.materialLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel20.Location = new System.Drawing.Point(3, 0);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(364, 14);
            this.materialLabel20.TabIndex = 2;
            this.materialLabel20.Text = "** Ayarların geçerli olması için \'KAYDET\' butonuna basınız.";
            this.materialLabel20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel20.UseAccent = true;
            // 
            // ımageListSideNav
            // 
            this.ımageListSideNav.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListSideNav.ImageStream")));
            this.ımageListSideNav.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListSideNav.Images.SetKeyName(0, "icons8-home-32.png");
            this.ımageListSideNav.Images.SetKeyName(1, "icons8-settings-32.png");
            this.ımageListSideNav.Images.SetKeyName(2, "icons8-statistics-32.png");
            this.ımageListSideNav.Images.SetKeyName(3, "icons8-taxi-32.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(900, 731);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 730);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KomisyonNET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel34.ResumeLayout(false);
            this.tableLayoutPanel34.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.pTaxiPage.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPTlogo)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.statisticPage.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.mCardProfit.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanelRadio.ResumeLayout(false);
            this.tableLayoutPanelRadio.PerformLayout();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.materialCard10.ResumeLayout(false);
            this.tableLayoutPanel28.ResumeLayout(false);
            this.tableLayoutPanel28.PerformLayout();
            this.mCardPreview.ResumeLayout(false);
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel30.ResumeLayout(false);
            this.tableLayoutPanel30.PerformLayout();
            this.tableLayoutPanel31.ResumeLayout(false);
            this.tableLayoutPanel31.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.mCardTable.ResumeLayout(false);
            this.tableLayoutPanel32.ResumeLayout(false);
            this.tableLayoutPanel33.ResumeLayout(false);
            this.tableLayoutPanel33.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage pTaxiPage;
        private System.Windows.Forms.ImageList ımageListSideNav;
        private System.Windows.Forms.TabPage statisticPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.TabPage homePage;
        public MaterialSkin.Controls.MaterialSwitch themeSwitch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton BtnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialTextBox txtBoxExportPath;
        private MaterialSkin.Controls.MaterialButton BtnExportPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox mComboBoxLanguage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.PictureBox pictureBoxPTlogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private MaterialSkin.Controls.MaterialButton BtnFolderSelect;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxFolderPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private MaterialSkin.Controls.MaterialButton BtnCalculate;
        public MaterialSkin.Controls.MaterialLabel labelPtInfo;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialMaskedTextBox MaskTxtBoxFee;
        private MaterialSkin.Controls.MaterialMaskedTextBox MaskTxtBoxComm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private MaterialSkin.Controls.MaterialButton BtnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private MaterialSkin.Controls.MaterialCard mCardProfit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private MaterialSkin.Controls.MaterialLabel mLabelProfitHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialLabel mLabelTProfit;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel mLabelTInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private LiveCharts.Wpf.PieChart pieChart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.Integration.ElementHost elementHost5;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private MaterialSkin.Controls.MaterialRadioButton mRadioBtnColumn;
        private MaterialSkin.Controls.MaterialRadioButton mRadioBtnStacked;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialButton mBtnFileSelect;
        private MaterialSkin.Controls.MaterialButton mBtnCalculateStatistic;
        private MaterialSkin.Controls.MaterialButton mBtnClear;
        private MaterialSkin.Controls.MaterialCheckbox mCbxPreview;
        private MaterialSkin.Controls.MaterialCard mCardPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private MaterialSkin.Controls.MaterialCard mCardTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel30;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialMaskedTextBox MaskTxtBoxNewFee;
        private MaterialSkin.Controls.MaterialMaskedTextBox MaskTxtBoxNewComm;
        private MaterialSkin.Controls.MaterialButton mBtnPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
        private MaterialSkin.Controls.MaterialListView mListViewTable;
        private System.Windows.Forms.ColumnHeader colNameSurname;
        private System.Windows.Forms.ColumnHeader colTInvoice;
        private System.Windows.Forms.ColumnHeader colFee;
        private System.Windows.Forms.ColumnHeader colCommission;
        private System.Windows.Forms.ColumnHeader colEarn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel33;
        private System.Windows.Forms.ColumnHeader colEarnRate;
        private MaterialSkin.Controls.MaterialRadioButton mRadioBtnName;
        private MaterialSkin.Controls.MaterialRadioButton mRadioBtnEarn;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private MaterialSkin.Controls.MaterialLabel labelTest;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel30;
        private MaterialSkin.Controls.MaterialLabel materialLabel31;
        private MaterialSkin.Controls.MaterialLabel materialLabel32;
        private MaterialSkin.Controls.MaterialLabel materialLabel33;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
        private MaterialSkin.Controls.MaterialLabel materialLabel35;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel34;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private MaterialSkin.Controls.MaterialLabel materialLabel36;
    }
}

