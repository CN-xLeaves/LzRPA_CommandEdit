namespace CommandEdit
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CommandList = new System.Windows.Forms.TreeView();
            this.TreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.NodeEditGroup = new System.Windows.Forms.GroupBox();
            this.LB_Icon = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TB_InsCodeEnd = new System.Windows.Forms.TextBox();
            this.TB_InsCodeTop = new System.Windows.Forms.TextBox();
            this.TempletTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LB_Param = new System.Windows.Forms.ListView();
            this.ParamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label23 = new System.Windows.Forms.Label();
            this.TB_Param_Describe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CB_Param_Optional = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LB_Param_DataType = new System.Windows.Forms.ComboBox();
            this.TB_Param_Caption = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DelParam = new System.Windows.Forms.Button();
            this.AddParam = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Help_Return = new System.Windows.Forms.TextBox();
            this.LB_Help_RetType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Help_Describe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Help_Define = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Help_Caption = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TB_Help_Doc_Document = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Help_Doc_Caption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TB_Help_Syn_Define = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_Help_Syn_Describe = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_Help_Syn_Caption = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TB_Help_Tpe_Define = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_Help_Tpe_Describe = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TB_Help_Tpe_Caption = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.TB_Help_Else = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.LB_Templet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_InsCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Function = new System.Windows.Forms.CheckBox();
            this.CB_Visible = new System.Windows.Forms.CheckBox();
            this.TB_Remark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Caption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ModuleName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.SaveList = new System.Windows.Forms.Button();
            this.OpenList = new System.Windows.Forms.Button();
            this.TreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_AddPrev = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AddNext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_AddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateList = new System.Windows.Forms.Button();
            this.NodeEditGroup.SuspendLayout();
            this.TempletTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.TreeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandList
            // 
            this.CommandList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommandList.ImageKey = "函数";
            this.CommandList.ImageList = this.TreeImageList;
            this.CommandList.Location = new System.Drawing.Point(12, 70);
            this.CommandList.Name = "CommandList";
            this.CommandList.SelectedImageKey = "函数";
            this.CommandList.Size = new System.Drawing.Size(433, 597);
            this.CommandList.TabIndex = 0;
            this.CommandList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CommandList_AfterSelect);
            this.CommandList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommandList_MouseDown);
            // 
            // TreeImageList
            // 
            this.TreeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImageList.ImageStream")));
            this.TreeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImageList.Images.SetKeyName(0, "命令大全");
            this.TreeImageList.Images.SetKeyName(1, "教学中心");
            this.TreeImageList.Images.SetKeyName(2, "收藏夹");
            this.TreeImageList.Images.SetKeyName(3, "历史记录");
            this.TreeImageList.Images.SetKeyName(4, "公文包");
            this.TreeImageList.Images.SetKeyName(5, "文件夹");
            this.TreeImageList.Images.SetKeyName(6, "文件");
            this.TreeImageList.Images.SetKeyName(7, "类");
            this.TreeImageList.Images.SetKeyName(8, "命名空间");
            this.TreeImageList.Images.SetKeyName(9, "函数");
            this.TreeImageList.Images.SetKeyName(10, "属性");
            this.TreeImageList.Images.SetKeyName(11, "警告");
            this.TreeImageList.Images.SetKeyName(12, "信息");
            // 
            // NodeEditGroup
            // 
            this.NodeEditGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NodeEditGroup.Controls.Add(this.LB_Icon);
            this.NodeEditGroup.Controls.Add(this.label25);
            this.NodeEditGroup.Controls.Add(this.label22);
            this.NodeEditGroup.Controls.Add(this.label21);
            this.NodeEditGroup.Controls.Add(this.TB_InsCodeEnd);
            this.NodeEditGroup.Controls.Add(this.TB_InsCodeTop);
            this.NodeEditGroup.Controls.Add(this.TempletTabs);
            this.NodeEditGroup.Controls.Add(this.LB_Templet);
            this.NodeEditGroup.Controls.Add(this.label4);
            this.NodeEditGroup.Controls.Add(this.TB_InsCode);
            this.NodeEditGroup.Controls.Add(this.label3);
            this.NodeEditGroup.Controls.Add(this.CB_Function);
            this.NodeEditGroup.Controls.Add(this.CB_Visible);
            this.NodeEditGroup.Controls.Add(this.TB_Remark);
            this.NodeEditGroup.Controls.Add(this.label2);
            this.NodeEditGroup.Controls.Add(this.TB_Caption);
            this.NodeEditGroup.Controls.Add(this.label1);
            this.NodeEditGroup.Enabled = false;
            this.NodeEditGroup.Location = new System.Drawing.Point(451, 12);
            this.NodeEditGroup.Name = "NodeEditGroup";
            this.NodeEditGroup.Size = new System.Drawing.Size(586, 655);
            this.NodeEditGroup.TabIndex = 1;
            this.NodeEditGroup.TabStop = false;
            this.NodeEditGroup.Text = "数据编辑区";
            // 
            // LB_Icon
            // 
            this.LB_Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Icon.FormattingEnabled = true;
            this.LB_Icon.Items.AddRange(new object[] {
            "命令大全",
            "教学中心",
            "收藏夹",
            "历史记录",
            "公文包",
            "文件夹",
            "文件",
            "类",
            "命名空间",
            "函数",
            "属性",
            "警告",
            "信息"});
            this.LB_Icon.Location = new System.Drawing.Point(459, 20);
            this.LB_Icon.Name = "LB_Icon";
            this.LB_Icon.Size = new System.Drawing.Size(113, 20);
            this.LB_Icon.TabIndex = 30;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(388, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 29;
            this.label25.Text = "显示图标：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 209);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 28;
            this.label22.Text = "底部代码：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 27;
            this.label21.Text = "顶部代码：";
            // 
            // TB_InsCodeEnd
            // 
            this.TB_InsCodeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_InsCodeEnd.Location = new System.Drawing.Point(90, 206);
            this.TB_InsCodeEnd.Multiline = true;
            this.TB_InsCodeEnd.Name = "TB_InsCodeEnd";
            this.TB_InsCodeEnd.Size = new System.Drawing.Size(482, 47);
            this.TB_InsCodeEnd.TabIndex = 26;
            // 
            // TB_InsCodeTop
            // 
            this.TB_InsCodeTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_InsCodeTop.Location = new System.Drawing.Point(90, 153);
            this.TB_InsCodeTop.Multiline = true;
            this.TB_InsCodeTop.Name = "TB_InsCodeTop";
            this.TB_InsCodeTop.Size = new System.Drawing.Size(482, 47);
            this.TB_InsCodeTop.TabIndex = 25;
            // 
            // TempletTabs
            // 
            this.TempletTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TempletTabs.Controls.Add(this.tabPage1);
            this.TempletTabs.Controls.Add(this.tabPage2);
            this.TempletTabs.Controls.Add(this.tabPage3);
            this.TempletTabs.Controls.Add(this.tabPage4);
            this.TempletTabs.Controls.Add(this.tabPage5);
            this.TempletTabs.Location = new System.Drawing.Point(16, 259);
            this.TempletTabs.Name = "TempletTabs";
            this.TempletTabs.SelectedIndex = 0;
            this.TempletTabs.Size = new System.Drawing.Size(556, 379);
            this.TempletTabs.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LB_Param);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.TB_Param_Describe);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.CB_Param_Optional);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.LB_Param_DataType);
            this.tabPage1.Controls.Add(this.TB_Param_Caption);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.DelParam);
            this.tabPage1.Controls.Add(this.AddParam);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.TB_Help_Return);
            this.tabPage1.Controls.Add(this.LB_Help_RetType);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.TB_Help_Describe);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TB_Help_Define);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.TB_Help_Caption);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "　命令　";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LB_Param
            // 
            this.LB_Param.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_Param.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParamName});
            this.LB_Param.Location = new System.Drawing.Point(90, 227);
            this.LB_Param.Name = "LB_Param";
            this.LB_Param.Size = new System.Drawing.Size(128, 79);
            this.LB_Param.TabIndex = 39;
            this.LB_Param.UseCompatibleStateImageBehavior = false;
            this.LB_Param.View = System.Windows.Forms.View.Details;
            this.LB_Param.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LB_Param_ItemSelectionChanged);
            // 
            // ParamName
            // 
            this.ParamName.Text = "参数名";
            this.ParamName.Width = 100;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(224, 160);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 38;
            this.label23.Text = "返回说明：";
            // 
            // TB_Param_Describe
            // 
            this.TB_Param_Describe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Param_Describe.Location = new System.Drawing.Point(295, 280);
            this.TB_Param_Describe.Multiline = true;
            this.TB_Param_Describe.Name = "TB_Param_Describe";
            this.TB_Param_Describe.Size = new System.Drawing.Size(238, 57);
            this.TB_Param_Describe.TabIndex = 37;
            this.TB_Param_Describe.Leave += new System.EventHandler(this.TB_Param_Describe_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "参数描述：";
            // 
            // CB_Param_Optional
            // 
            this.CB_Param_Optional.AutoSize = true;
            this.CB_Param_Optional.Location = new System.Drawing.Point(413, 257);
            this.CB_Param_Optional.Name = "CB_Param_Optional";
            this.CB_Param_Optional.Size = new System.Drawing.Size(120, 16);
            this.CB_Param_Optional.TabIndex = 35;
            this.CB_Param_Optional.Text = "这是一个可选参数";
            this.CB_Param_Optional.UseVisualStyleBackColor = true;
            this.CB_Param_Optional.Click += new System.EventHandler(this.CB_Param_Optional_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 34;
            this.label13.Text = "数据类型：";
            // 
            // LB_Param_DataType
            // 
            this.LB_Param_DataType.FormattingEnabled = true;
            this.LB_Param_DataType.Items.AddRange(new object[] {
            "Integer",
            "Double",
            "String",
            "Boolean",
            "Object",
            "Time",
            "Array",
            "Any",
            "Ptr"});
            this.LB_Param_DataType.Location = new System.Drawing.Point(295, 254);
            this.LB_Param_DataType.Name = "LB_Param_DataType";
            this.LB_Param_DataType.Size = new System.Drawing.Size(112, 20);
            this.LB_Param_DataType.TabIndex = 33;
            this.LB_Param_DataType.Leave += new System.EventHandler(this.LB_Param_DataType_Leave);
            // 
            // TB_Param_Caption
            // 
            this.TB_Param_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Param_Caption.Location = new System.Drawing.Point(295, 227);
            this.TB_Param_Caption.Name = "TB_Param_Caption";
            this.TB_Param_Caption.Size = new System.Drawing.Size(238, 21);
            this.TB_Param_Caption.TabIndex = 32;
            this.TB_Param_Caption.Leave += new System.EventHandler(this.TB_Param_Caption_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "参数名称：";
            // 
            // DelParam
            // 
            this.DelParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelParam.Location = new System.Drawing.Point(157, 312);
            this.DelParam.Name = "DelParam";
            this.DelParam.Size = new System.Drawing.Size(61, 25);
            this.DelParam.TabIndex = 30;
            this.DelParam.Text = "删 除";
            this.DelParam.UseVisualStyleBackColor = true;
            this.DelParam.Click += new System.EventHandler(this.DelParam_Click);
            // 
            // AddParam
            // 
            this.AddParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddParam.Location = new System.Drawing.Point(90, 312);
            this.AddParam.Name = "AddParam";
            this.AddParam.Size = new System.Drawing.Size(61, 25);
            this.AddParam.TabIndex = 29;
            this.AddParam.Text = "添 加";
            this.AddParam.UseVisualStyleBackColor = true;
            this.AddParam.Click += new System.EventHandler(this.AddParam_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "参数列表：";
            // 
            // TB_Help_Return
            // 
            this.TB_Help_Return.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Return.Location = new System.Drawing.Point(295, 155);
            this.TB_Help_Return.Multiline = true;
            this.TB_Help_Return.Name = "TB_Help_Return";
            this.TB_Help_Return.Size = new System.Drawing.Size(238, 66);
            this.TB_Help_Return.TabIndex = 26;
            // 
            // LB_Help_RetType
            // 
            this.LB_Help_RetType.FormattingEnabled = true;
            this.LB_Help_RetType.Items.AddRange(new object[] {
            "Null",
            "Integer",
            "Double",
            "String",
            "Boolean",
            "Object",
            "Time",
            "Array",
            "Any",
            "Ptr"});
            this.LB_Help_RetType.Location = new System.Drawing.Point(90, 156);
            this.LB_Help_RetType.Name = "LB_Help_RetType";
            this.LB_Help_RetType.Size = new System.Drawing.Size(128, 20);
            this.LB_Help_RetType.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "返回值：";
            // 
            // TB_Help_Describe
            // 
            this.TB_Help_Describe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Describe.Location = new System.Drawing.Point(90, 70);
            this.TB_Help_Describe.Multiline = true;
            this.TB_Help_Describe.Name = "TB_Help_Describe";
            this.TB_Help_Describe.Size = new System.Drawing.Size(443, 80);
            this.TB_Help_Describe.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "功能描述：";
            // 
            // TB_Help_Define
            // 
            this.TB_Help_Define.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Define.Location = new System.Drawing.Point(90, 43);
            this.TB_Help_Define.Name = "TB_Help_Define";
            this.TB_Help_Define.Size = new System.Drawing.Size(443, 21);
            this.TB_Help_Define.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "语法：";
            // 
            // TB_Help_Caption
            // 
            this.TB_Help_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Caption.Location = new System.Drawing.Point(90, 16);
            this.TB_Help_Caption.Name = "TB_Help_Caption";
            this.TB_Help_Caption.Size = new System.Drawing.Size(443, 21);
            this.TB_Help_Caption.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "标题：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TB_Help_Doc_Document);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TB_Help_Doc_Caption);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "　文档　";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TB_Help_Doc_Document
            // 
            this.TB_Help_Doc_Document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Doc_Document.Location = new System.Drawing.Point(90, 43);
            this.TB_Help_Doc_Document.Multiline = true;
            this.TB_Help_Doc_Document.Name = "TB_Help_Doc_Document";
            this.TB_Help_Doc_Document.Size = new System.Drawing.Size(443, 295);
            this.TB_Help_Doc_Document.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "文档内容：";
            // 
            // TB_Help_Doc_Caption
            // 
            this.TB_Help_Doc_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Doc_Caption.Location = new System.Drawing.Point(90, 16);
            this.TB_Help_Doc_Caption.Name = "TB_Help_Doc_Caption";
            this.TB_Help_Doc_Caption.Size = new System.Drawing.Size(443, 21);
            this.TB_Help_Doc_Caption.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "文档标题：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TB_Help_Syn_Define);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.TB_Help_Syn_Describe);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.TB_Help_Syn_Caption);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(548, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "　语法　";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TB_Help_Syn_Define
            // 
            this.TB_Help_Syn_Define.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Syn_Define.Location = new System.Drawing.Point(90, 44);
            this.TB_Help_Syn_Define.Multiline = true;
            this.TB_Help_Syn_Define.Name = "TB_Help_Syn_Define";
            this.TB_Help_Syn_Define.Size = new System.Drawing.Size(443, 80);
            this.TB_Help_Syn_Define.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "语法定义：";
            // 
            // TB_Help_Syn_Describe
            // 
            this.TB_Help_Syn_Describe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Syn_Describe.Location = new System.Drawing.Point(90, 130);
            this.TB_Help_Syn_Describe.Multiline = true;
            this.TB_Help_Syn_Describe.Name = "TB_Help_Syn_Describe";
            this.TB_Help_Syn_Describe.Size = new System.Drawing.Size(443, 208);
            this.TB_Help_Syn_Describe.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 21;
            this.label15.Text = "文档内容：";
            // 
            // TB_Help_Syn_Caption
            // 
            this.TB_Help_Syn_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Syn_Caption.Location = new System.Drawing.Point(90, 16);
            this.TB_Help_Syn_Caption.Name = "TB_Help_Syn_Caption";
            this.TB_Help_Syn_Caption.Size = new System.Drawing.Size(443, 21);
            this.TB_Help_Syn_Caption.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "文档标题：";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TB_Help_Tpe_Define);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.TB_Help_Tpe_Describe);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.TB_Help_Tpe_Caption);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(548, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "数据类型";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TB_Help_Tpe_Define
            // 
            this.TB_Help_Tpe_Define.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Tpe_Define.Location = new System.Drawing.Point(90, 44);
            this.TB_Help_Tpe_Define.Multiline = true;
            this.TB_Help_Tpe_Define.Name = "TB_Help_Tpe_Define";
            this.TB_Help_Tpe_Define.Size = new System.Drawing.Size(443, 80);
            this.TB_Help_Tpe_Define.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 29;
            this.label18.Text = "类型定义：";
            // 
            // TB_Help_Tpe_Describe
            // 
            this.TB_Help_Tpe_Describe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Tpe_Describe.Location = new System.Drawing.Point(90, 130);
            this.TB_Help_Tpe_Describe.Multiline = true;
            this.TB_Help_Tpe_Describe.Name = "TB_Help_Tpe_Describe";
            this.TB_Help_Tpe_Describe.Size = new System.Drawing.Size(443, 208);
            this.TB_Help_Tpe_Describe.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 27;
            this.label19.Text = "文档内容：";
            // 
            // TB_Help_Tpe_Caption
            // 
            this.TB_Help_Tpe_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Tpe_Caption.Location = new System.Drawing.Point(90, 16);
            this.TB_Help_Tpe_Caption.Name = "TB_Help_Tpe_Caption";
            this.TB_Help_Tpe_Caption.Size = new System.Drawing.Size(443, 21);
            this.TB_Help_Tpe_Caption.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 25;
            this.label20.Text = "文档标题：";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.TB_Help_Else);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(548, 353);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "　其他　";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // TB_Help_Else
            // 
            this.TB_Help_Else.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Help_Else.Location = new System.Drawing.Point(90, 16);
            this.TB_Help_Else.Multiline = true;
            this.TB_Help_Else.Name = "TB_Help_Else";
            this.TB_Help_Else.Size = new System.Drawing.Size(443, 321);
            this.TB_Help_Else.TabIndex = 20;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 19;
            this.label26.Text = "JSON：";
            // 
            // LB_Templet
            // 
            this.LB_Templet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Templet.FormattingEnabled = true;
            this.LB_Templet.Items.AddRange(new object[] {
            "index",
            "command",
            "document",
            "syntax",
            "variant"});
            this.LB_Templet.Location = new System.Drawing.Point(91, 74);
            this.LB_Templet.Name = "LB_Templet";
            this.LB_Templet.Size = new System.Drawing.Size(268, 20);
            this.LB_Templet.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "帮助模板：";
            // 
            // TB_InsCode
            // 
            this.TB_InsCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_InsCode.Location = new System.Drawing.Point(90, 100);
            this.TB_InsCode.Multiline = true;
            this.TB_InsCode.Name = "TB_InsCode";
            this.TB_InsCode.Size = new System.Drawing.Size(482, 47);
            this.TB_InsCode.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "插入代码：";
            // 
            // CB_Function
            // 
            this.CB_Function.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Function.AutoSize = true;
            this.CB_Function.Location = new System.Drawing.Point(476, 77);
            this.CB_Function.Name = "CB_Function";
            this.CB_Function.Size = new System.Drawing.Size(96, 16);
            this.CB_Function.TabIndex = 18;
            this.CB_Function.Text = "这是一个函数";
            this.CB_Function.UseVisualStyleBackColor = true;
            // 
            // CB_Visible
            // 
            this.CB_Visible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Visible.AutoSize = true;
            this.CB_Visible.Location = new System.Drawing.Point(374, 77);
            this.CB_Visible.Name = "CB_Visible";
            this.CB_Visible.Size = new System.Drawing.Size(96, 16);
            this.CB_Visible.TabIndex = 17;
            this.CB_Visible.Text = "在列表中显示";
            this.CB_Visible.UseVisualStyleBackColor = true;
            // 
            // TB_Remark
            // 
            this.TB_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Remark.Location = new System.Drawing.Point(90, 47);
            this.TB_Remark.Name = "TB_Remark";
            this.TB_Remark.Size = new System.Drawing.Size(482, 21);
            this.TB_Remark.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "简短描述：";
            // 
            // TB_Caption
            // 
            this.TB_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Caption.Location = new System.Drawing.Point(90, 20);
            this.TB_Caption.Name = "TB_Caption";
            this.TB_Caption.Size = new System.Drawing.Size(292, 21);
            this.TB_Caption.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "命令名：";
            // 
            // TB_ModuleName
            // 
            this.TB_ModuleName.Location = new System.Drawing.Point(89, 43);
            this.TB_ModuleName.Name = "TB_ModuleName";
            this.TB_ModuleName.Size = new System.Drawing.Size(356, 21);
            this.TB_ModuleName.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 15;
            this.label24.Text = "扩展库名：";
            // 
            // SaveList
            // 
            this.SaveList.Location = new System.Drawing.Point(149, 12);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(61, 25);
            this.SaveList.TabIndex = 32;
            this.SaveList.Text = "保 存";
            this.SaveList.UseVisualStyleBackColor = true;
            this.SaveList.Click += new System.EventHandler(this.SaveList_Click);
            // 
            // OpenList
            // 
            this.OpenList.Location = new System.Drawing.Point(82, 12);
            this.OpenList.Name = "OpenList";
            this.OpenList.Size = new System.Drawing.Size(61, 25);
            this.OpenList.TabIndex = 31;
            this.OpenList.Text = "打 开";
            this.OpenList.UseVisualStyleBackColor = true;
            this.OpenList.Click += new System.EventHandler(this.OpenList_Click);
            // 
            // TreeMenu
            // 
            this.TreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_AddPrev,
            this.Menu_AddNext,
            this.toolStripMenuItem1,
            this.Menu_AddChild});
            this.TreeMenu.Name = "WorkSpaceMenu";
            this.TreeMenu.Size = new System.Drawing.Size(149, 76);
            this.TreeMenu.Opening += new System.ComponentModel.CancelEventHandler(this.TreeMenu_Opening);
            // 
            // Menu_AddPrev
            // 
            this.Menu_AddPrev.Name = "Menu_AddPrev";
            this.Menu_AddPrev.Size = new System.Drawing.Size(148, 22);
            this.Menu_AddPrev.Text = "添加到前面";
            this.Menu_AddPrev.Click += new System.EventHandler(this.Menu_AddPrev_Click);
            // 
            // Menu_AddNext
            // 
            this.Menu_AddNext.Name = "Menu_AddNext";
            this.Menu_AddNext.Size = new System.Drawing.Size(148, 22);
            this.Menu_AddNext.Text = "添加到后面";
            this.Menu_AddNext.Click += new System.EventHandler(this.Menu_AddNext_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // Menu_AddChild
            // 
            this.Menu_AddChild.Name = "Menu_AddChild";
            this.Menu_AddChild.Size = new System.Drawing.Size(148, 22);
            this.Menu_AddChild.Text = "添加到子节点";
            this.Menu_AddChild.Click += new System.EventHandler(this.Menu_AddChild_Click);
            // 
            // CreateList
            // 
            this.CreateList.Location = new System.Drawing.Point(15, 12);
            this.CreateList.Name = "CreateList";
            this.CreateList.Size = new System.Drawing.Size(61, 25);
            this.CreateList.TabIndex = 33;
            this.CreateList.Text = "新 建";
            this.CreateList.UseVisualStyleBackColor = true;
            this.CreateList.Click += new System.EventHandler(this.CreateList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 679);
            this.Controls.Add(this.CreateList);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.OpenList);
            this.Controls.Add(this.TB_ModuleName);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.NodeEditGroup);
            this.Controls.Add(this.CommandList);
            this.Name = "Form1";
            this.Text = "命令列表编辑器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NodeEditGroup.ResumeLayout(false);
            this.NodeEditGroup.PerformLayout();
            this.TempletTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.TreeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView CommandList;
        private System.Windows.Forms.GroupBox NodeEditGroup;
        private System.Windows.Forms.TextBox TB_Remark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Caption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_InsCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_Function;
        private System.Windows.Forms.CheckBox CB_Visible;
        private System.Windows.Forms.ComboBox LB_Templet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl TempletTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TB_Help_Doc_Document;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Help_Doc_Caption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Help_Describe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Help_Define;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Help_Caption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Help_Return;
        private System.Windows.Forms.ComboBox LB_Help_RetType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_Param_Describe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CB_Param_Optional;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox LB_Param_DataType;
        private System.Windows.Forms.TextBox TB_Param_Caption;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DelParam;
        private System.Windows.Forms.Button AddParam;
        private System.Windows.Forms.TextBox TB_Help_Syn_Define;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_Help_Syn_Describe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_Help_Syn_Caption;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_Help_Tpe_Define;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_Help_Tpe_Describe;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TB_Help_Tpe_Caption;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TB_InsCodeEnd;
        private System.Windows.Forms.TextBox TB_InsCodeTop;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TB_ModuleName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.Button OpenList;
        private System.Windows.Forms.ImageList TreeImageList;
        private System.Windows.Forms.ComboBox LB_Icon;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox TB_Help_Else;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListView LB_Param;
        private System.Windows.Forms.ColumnHeader ParamName;
        private System.Windows.Forms.ContextMenuStrip TreeMenu;
        private System.Windows.Forms.ToolStripMenuItem Menu_AddPrev;
        private System.Windows.Forms.ToolStripMenuItem Menu_AddNext;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menu_AddChild;
        private System.Windows.Forms.Button CreateList;
    }
}

