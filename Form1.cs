using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEdit
{

    public partial class Form1 : Form
    {
        TreeNode CurNode;
        TreeNode SelectNode;
        ListViewItem SelectParam;
        string FilePath;

        public Form1()
        {
            InitializeComponent();
        }

        // 窗口载入
        private void Form1_Load(object sender, EventArgs e)
        {
            // 好像也没啥需要写的 emm ...
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        // 新建文件
        private void CreateList_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON文件|*.json|所有文件|*";
            sfd.FileName = "command.json";
            sfd.DefaultExt = ".json";
            DialogResult r = sfd.ShowDialog();
            if (r != DialogResult.Cancel)
            {
                // 写入空文件内容
                WriteFile(sfd.FileName, "{\"Caption\": \"插件名\",\"Remark\": \"插件描述\",\"ModuleName\": \"插件包名\",\"Icon\": \"公文包\",\"Visible\": true,\"Templet\": \"index.html\",\"Help\": {},\"Child\": []}");
                // 打开这个文件
                LoadCommandList(sfd.FileName);
            }
        }

        // 打开文件
        private void OpenList_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON文件|*.json|所有文件|*";
            ofd.ShowDialog();
            if (File.Exists(ofd.FileName))
            {
                LoadCommandList(ofd.FileName);
            }
        }

        // 保存文件
        private void SaveList_Click(object sender, EventArgs e)
        {
            // 备份以下旧文件先，避免软件BUG丢数据
            File.Copy(FilePath, FilePath + ".bak", true);
            // 递归整理文件内容保存
            JObject json = RecuTree(CommandList.Nodes[0]);
            json["ModuleName"] = TB_ModuleName.Text;
            WriteFile(FilePath, json.ToString());
            MessageBox.Show("文件保存完毕，旧文件备份在同目录，如数据意外损坏请使用备份文件恢复！");
        }

        // 递归遍历树列表 [保存用]
        private JObject RecuTree(TreeNode Node)
        {
            JObject json = new JObject();
            NodeData Item = (NodeData)Node.Tag;

            // 生成公共数据
            json["Caption"] = Item.Caption;
            if (Item.Remark != "")
            {
                json["Remark"] = Item.Remark;
            }
            if (Item.Icon != "")
            {
                json["Icon"] = Item.Icon;
            }
            json["Templet"] = Item.Templet;
            json["Visible"] = Item.Visible;
            json["Function"] = Item.Function;
            if (Item.InsCode != "")
            {
                json["InsCode"] = Item.InsCode;
            }
            if (Item.InsCodeTop != "")
            {
                json["InsCodeTop"] = Item.InsCodeTop;
            }
            if (Item.InsCodeEnd != "")
            {
                json["InsCodeEnd"] = Item.InsCodeEnd;
            }

            // 生成模板数据
            JObject Help;
            switch (Item.Templet)
            {
                case "command.html":
                    // 命令模板
                    Help = new JObject();
                    Help["Caption"] = Item.Cmd_Caption;
                    Help["Define"] = Item.Cmd_Define;
                    Help["Describe"] = Item.Cmd_Describe;
                    Help["RetType"] = Item.Cmd_RetType;
                    Help["Return"] = Item.Cmd_Return;
                    JArray Param = new JArray();
                    foreach (NodeParam np in Item.Cmd_Param)
                    {
                        JObject op = new JObject();
                        op["Caption"] = np.Caption;
                        op["DataType"] = np.DataType;
                        op["Describe"] = np.Describe;
                        op["Optional"] = np.Optional;
                        Param.Add(op);
                    }
                    Help["Param"] = Param;
                    break;
                case "document.html":
                    // 文档模板
                    Help = new JObject();
                    Help["Caption"] = Item.Doc_Caption;
                    Help["Document"] = Item.Doc_Document;
                    break;
                case "index.html":
                    // 主页 [非模板]
                    Help = new JObject();
                    break;
                case "syntax.html":
                    // 语法模板
                    Help = new JObject();
                    Help["Caption"] = Item.Syn_Caption;
                    Help["Define"] = Item.Syn_Define;
                    Help["Describe"] = Item.Syn_Describe;
                    break;
                case "variant.html":
                    // 变量模板
                    Help = new JObject();
                    Help["Caption"] = Item.Tpe_Caption;
                    Help["Define"] = Item.Tpe_Define;
                    Help["Describe"] = Item.Tpe_Describe;
                    break;
                default:
                    // 未知模板
                    Help = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(Item.Help_Else);
                    break;
            }
            json["Help"] = Help;

            // 递归遍历子节点
            if (Node.Nodes.Count > 0)
            {
                JArray Child = new JArray();
                foreach (TreeNode ChildNode in Node.Nodes)
                {
                    Child.Add(RecuTree(ChildNode));
                }
                json["Child"] = Child;
            }

            return json;
        }

        private void LoadCommandList(string sFile)
        {
            // 从 JSON 文件加载命令树
            FilePath = sFile;
            CommandList.Nodes.Clear();
            object json = Newtonsoft.Json.JsonConvert.DeserializeObject(File.ReadAllText(sFile));
            if (json is JObject)
            {
                JObject DocPlug = (JObject)json;
                TB_ModuleName.Text = DocPlug["ModuleName"].ToString();
                RecuCommandList(CommandList.Nodes, DocPlug);
                CommandList.Nodes[0].Expand();
                CommandList.Nodes[0].EnsureVisible();
            }
            else if (json is JArray)
            {
                MessageBox.Show("程序暂不支持对 setup 目录下的 command.json 进行操作！");
            }
        }

        // 递归遍历命令树 [加载用]
        private void RecuCommandList(TreeNodeCollection node, JObject item)
        {
            NodeData Node   = new NodeData();
            Node.Caption    = item["Caption"]    == null ? ""     : item["Caption"].ToString();
            Node.Remark     = item["Remark"]     == null ? ""     : item["Remark"].ToString();
            Node.Icon       = item["Icon"]       == null ? "函数" : item["Icon"].ToString();
            Node.InsCode    = item["InsCode"]    == null ? ""     : item["InsCode"].ToString();
            Node.InsCodeTop = item["InsCodeTop"] == null ? ""     : item["InsCodeTop"].ToString();
            Node.InsCodeEnd = item["InsCodeEnd"] == null ? ""     : item["InsCodeEnd"].ToString();
            Node.Templet    = item["Templet"]    == null ? ""     : item["Templet"].ToString();
            Node.Visible    = item["Visible"]    == null ? true   : item["Visible"].Value<bool>();
            Node.Function   = item["Function"]   == null ? true   : item["Function"].Value<bool>();

            Node.Cmd_Caption = "";
            Node.Cmd_Define = "";
            Node.Cmd_Describe = "";
            Node.Cmd_RetType = "";
            Node.Cmd_Return = "";
            Node.Cmd_Param = new ArrayList();

            Node.Doc_Caption = "";
            Node.Doc_Document = "";

            Node.Syn_Caption = "";
            Node.Syn_Define = "";
            Node.Syn_Describe = "";

            Node.Tpe_Caption = "";
            Node.Tpe_Define = "";
            Node.Tpe_Describe = "";

            Node.Help_Else = "";

            if (item["Help"] is JObject)
            {
                switch (Node.Templet.ToLower())
                {
                    case "command.html":
                        Node.Cmd_Caption  = item["Help"]["Caption"]  == null ? "" : item["Help"]["Caption"].ToString();
                        Node.Cmd_Define   = item["Help"]["Define"]   == null ? "" : item["Help"]["Define"].ToString();
                        Node.Cmd_Describe = item["Help"]["Describe"] == null ? "" : item["Help"]["Describe"].ToString();
                        Node.Cmd_RetType  = item["Help"]["RetType"]  == null ? "" : item["Help"]["RetType"].ToString();
                        Node.Cmd_Return   = item["Help"]["Return"]   == null ? "" : item["Help"]["Return"].ToString();
                        if (item["Help"]["Param"] is JArray)
                        {
                            foreach (JObject ParamItem in item["Help"]["Param"])
                            {
                                NodeParam Param = new NodeParam();
                                Param.Caption  = ParamItem["Caption"]  == null ? ""    : ParamItem["Caption"].ToString();
                                Param.DataType = ParamItem["DataType"] == null ? ""    : ParamItem["DataType"].ToString();
                                Param.Describe = ParamItem["Describe"] == null ? ""    : ParamItem["Describe"].ToString();
                                Param.Optional = ParamItem["Optional"] == null ? false : ParamItem["Optional"].Value<bool>();
                                Node.Cmd_Param.Add(Param);
                            }
                        }
                        break;
                    case "document.html":
                        Node.Doc_Caption  = item["Help"]["Caption"]  == null ? "" : item["Help"]["Caption"].ToString();
                        Node.Doc_Document = item["Help"]["Document"] == null ? "" : item["Help"]["Document"].ToString();
                        break;
                    case "index.html":

                        break;
                    case "syntax.html":
                        Node.Syn_Caption =  item["Help"]["Caption"]  == null ? "" : item["Help"]["Caption"].ToString();
                        Node.Syn_Define =   item["Help"]["Define"]   == null ? "" : item["Help"]["Define"].ToString();
                        Node.Syn_Describe = item["Help"]["Describe"] == null ? "" : item["Help"]["Describe"].ToString();
                        break;
                    case "variant.html":
                        Node.Tpe_Caption  = item["Help"]["Caption"]  == null ? "" : item["Help"]["Caption"].ToString();
                        Node.Tpe_Define   = item["Help"]["Define"]   == null ? "" : item["Help"]["Define"].ToString();
                        Node.Tpe_Describe = item["Help"]["Describe"] == null ? "" : item["Help"]["Describe"].ToString();
                        break;
                    default:
                        Node.Help_Else = item["Help"].ToString();
                        break;
                }
            }
            // 添加到命令列表
            string sCaption;
            if (Node.Remark == "")
            {
                sCaption = Node.Caption;
            }
            else
            {
                sCaption = Node.Caption + " (" + Node.Remark + ")";
            }
            TreeNode root = node.Add(sCaption);
            root.Tag = Node;
            root.ContextMenuStrip = TreeMenu;
            if (Node.Icon != "")
            {
                root.ImageKey = Node.Icon;
                root.SelectedImageKey = Node.Icon;
            }
            if (item["Child"] != null)
            {
                foreach (JObject child_item in item["Child"])
                {
                    RecuCommandList(root.Nodes, child_item);
                }
                // 是否展开列表项
                if (item["Expand"] != null)
                {
                    if (item["Expand"].Value<bool>() == true)
                    {
                        root.Expand();
                    }
                }
            }
        }

        // 参数列表选择改变
        private void LB_Param_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // 设置新的参数数据
            SelectParam = e.Item;
            LoadParam((NodeParam)SelectParam.Tag);
        }

        // 添加参数
        private void AddParam_Click(object sender, EventArgs e)
        {
            // 添加参数
            NodeData Item = (NodeData)SelectNode.Tag;
            NodeParam Param = new NodeParam();
            Param.Caption = "Param";
            Param.DataType = "Integer";
            Param.Describe = "参数说明";
            Param.Optional = false;
            Item.Cmd_Param.Add(Param);
            // 刷新参数列表
            ListViewItem item = LB_Param.Items.Add(Param.Caption);
            item.Tag = Param;
            SelectParam = item;
            LoadParam(Param);
        }

        // 删除参数
        private void DelParam_Click(object sender, EventArgs e)
        {
            if (SelectParam != null)
            {
                // 删除参数
                NodeData Node = (NodeData)SelectNode.Tag;
                Node.Cmd_Param.Remove(SelectParam.Tag);
                LB_Param.Items.Remove(SelectParam);
                // 加载第一个参数
                if (Node.Cmd_Param.Count > 0)
                {
                    SelectParam = LB_Param.Items[0];
                    LoadParam((NodeParam)SelectParam.Tag);
                }
            }
        }
        
        // 参数 四个控件保存流程单独处理，不然逻辑太复杂了
        private void TB_Param_Caption_Leave(object sender, EventArgs e)
        {
            if (SelectParam != null)
            {
                NodeParam Param = (NodeParam)SelectParam.Tag;
                Param.Caption = ToHtml(TB_Param_Caption.Text);
                // 改标题后要刷新列表
                SelectParam.Text = Param.Caption;
            }
        }
        private void LB_Param_DataType_Leave(object sender, EventArgs e)
        {
            if (SelectParam != null)
            {
                NodeParam Param = (NodeParam)SelectParam.Tag;
                Param.DataType = LB_Param_DataType.Text;
            }
        }
        private void TB_Param_Describe_Leave(object sender, EventArgs e)
        {
            if (SelectParam != null)
            {
                NodeParam Param = (NodeParam)SelectParam.Tag;
                Param.Describe = ToHtml(TB_Param_Describe.Text);
            }
        }
        private void CB_Param_Optional_Click(object sender, EventArgs e)
        {
            if (SelectParam != null)
            {
                NodeParam Param = (NodeParam)SelectParam.Tag;
                Param.Optional = CB_Param_Optional.Checked;
            }
        }

        // 设置参数数据
        private void LoadParam(NodeParam Param)
        {
            if (Param != null)
            {
                TB_Param_Caption.Text = ToText(Param.Caption);
                LB_Param_DataType.Text = Param.DataType;
                TB_Param_Describe.Text = ToText(Param.Describe);
                CB_Param_Optional.Checked = Param.Optional;
            }
            else
            {
                TB_Param_Caption.Text = "";
                LB_Param_DataType.Text = "";
                TB_Param_Describe.Text = "";
                CB_Param_Optional.Checked = false;
            }
        }

        // 节点选择改变事件
        private void CommandList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 保存旧的节点数据
            if (SelectNode != null)
            {
                SaveNode(SelectNode);
            }
            SelectParam = null;
            // 设置新的节点数据
            SelectNode = e.Node;
            LoadNode(SelectNode);
        }

        // 树列表右键按下，获取右键菜单对应的节点
        private void CommandList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CurNode = CommandList.GetNodeAt(e.X, e.Y);
            }
        }

        // 添加到之前
        private void Menu_AddPrev_Click(object sender, EventArgs e)
        {
            NodeData Item = new NodeData();
            Item.DefaultValue();
            TreeNode Node = CurNode.Parent.Nodes.Insert(CurNode.Index, Item.Caption);
            Node.Tag = Item;
            CurNode.Expand();
        }

        // 添加到之后
        private void Menu_AddNext_Click(object sender, EventArgs e)
        {
            NodeData Item = new NodeData();
            Item.DefaultValue();
            TreeNode Node = CurNode.Parent.Nodes.Insert(CurNode.Index + 1, Item.Caption);
            Node.Tag = Item;
            CurNode.Expand();
        }

        // 添加到子项
        private void Menu_AddChild_Click(object sender, EventArgs e)
        {
            NodeData Item = new NodeData();
            Item.DefaultValue();
            TreeNode Node = CurNode.Nodes.Add(Item.Caption);
            Node.Tag = Item;
            CurNode.Expand();
        }

        // 菜单显示事件
        private void TreeMenu_Opening(object sender, CancelEventArgs e)
        {
            if (CurNode.Level == 0)
            {
                Menu_AddPrev.Enabled = false;
                Menu_AddNext.Enabled = false;
            }
            else
            {
                Menu_AddPrev.Enabled = true;
                Menu_AddNext.Enabled = true;
            }
        }

        // 保存节点数据
        private void SaveNode(TreeNode Node)
        {
            NodeData Item = (NodeData)Node.Tag;

            Item.Caption = TB_Caption.Text;
            Item.Remark = TB_Remark.Text;
            Item.Icon = LB_Icon.Text;
            Item.Templet = LB_Templet.Text;
            Item.Visible = CB_Visible.Checked;
            Item.Function = CB_Function.Checked;
            Item.InsCode = TB_InsCode.Text;
            Item.InsCodeTop = TB_InsCodeTop.Text;
            Item.InsCodeEnd = TB_InsCodeEnd.Text;

            Item.Cmd_Caption = ToHtml(TB_Help_Caption.Text);
            Item.Cmd_Define = ToHtml(TB_Help_Define.Text);
            Item.Cmd_Describe = ToHtml(TB_Help_Describe.Text);
            Item.Cmd_RetType = LB_Help_RetType.Text;
            Item.Cmd_Return = ToHtml(TB_Help_Return.Text);

            Item.Doc_Caption = ToHtml(TB_Help_Doc_Caption.Text);
            Item.Doc_Document = ToHtml(TB_Help_Doc_Document.Text);

            Item.Syn_Caption = ToHtml(TB_Help_Syn_Caption.Text);
            Item.Syn_Define = ToHtml(TB_Help_Syn_Define.Text);
            Item.Syn_Describe = ToHtml(TB_Help_Syn_Describe.Text);

            Item.Tpe_Caption = ToHtml(TB_Help_Tpe_Caption.Text);
            Item.Tpe_Define = ToHtml(TB_Help_Tpe_Define.Text);
            Item.Tpe_Describe = ToHtml(TB_Help_Tpe_Describe.Text);

            Item.Help_Else = TB_Help_Else.Text;

            // 刷新树列表标题
            if (Item.Remark == "")
            {
                Node.Text = Item.Caption;
            }
            else
            {
                Node.Text = Item.Caption + " (" + Item.Remark + ")";
            }
        }

        // 设置节点数据
        private void LoadNode(TreeNode Node)
        {
            NodeEditGroup.Enabled = true;

            NodeData Item = (NodeData)Node.Tag;

            TB_Caption.Text = Item.Caption;
            TB_Remark.Text = Item.Remark;
            LB_Icon.Text = Item.Icon;
            LB_Templet.Text = Item.Templet;
            CB_Visible.Checked = Item.Visible;
            CB_Function.Checked = Item.Function;
            TB_InsCode.Text = Item.InsCode;
            TB_InsCodeTop.Text = Item.InsCodeTop;
            TB_InsCodeEnd.Text = Item.InsCodeEnd;

            TB_Help_Caption.Text = ToText(Item.Cmd_Caption);
            TB_Help_Define.Text = ToText(Item.Cmd_Define);
            TB_Help_Describe.Text = ToText(Item.Cmd_Describe);
            LB_Help_RetType.Text = Item.Cmd_RetType;
            TB_Help_Return.Text = ToText(Item.Cmd_Return);

            LB_Param.Items.Clear();
            foreach (NodeParam Param in Item.Cmd_Param)
            {
                ListViewItem np = LB_Param.Items.Add(Param.Caption);
                np.Tag = Param;
            }
            if (Item.Cmd_Param.Count > 0)
            {
                LoadParam((NodeParam)Item.Cmd_Param[0]);
            }
            else
            {
                LoadParam(null);
            }

            TB_Help_Doc_Caption.Text = ToText(Item.Doc_Caption);
            TB_Help_Doc_Document.Text = ToText(Item.Doc_Document);

            TB_Help_Syn_Caption.Text = ToText(Item.Syn_Caption);
            TB_Help_Syn_Define.Text = ToText(Item.Syn_Define);
            TB_Help_Syn_Describe.Text = ToText(Item.Syn_Describe);

            TB_Help_Tpe_Caption.Text = ToText(Item.Tpe_Caption);
            TB_Help_Tpe_Define.Text = ToText(Item.Tpe_Define);
            TB_Help_Tpe_Describe.Text = ToText(Item.Tpe_Describe);

            TB_Help_Else.Text = Item.Help_Else;

            // 切换到对应模板的选项卡
            switch (Item.Templet)
            {
                case "command.html":
                    TempletTabs.Enabled = true;
                    TempletTabs.SelectTab(0);
                    break;
                case "document.html":
                    TempletTabs.Enabled = true;
                    TempletTabs.SelectTab(1);
                    break;
                case "index.html":
                    TempletTabs.Enabled = false;
                    break;
                case "syntax.html":
                    TempletTabs.Enabled = true;
                    TempletTabs.SelectTab(2);
                    break;
                case "variant.html":
                    TempletTabs.Enabled = true;
                    TempletTabs.SelectTab(3);
                    break;
                default:
                    TempletTabs.Enabled = true;
                    TempletTabs.SelectTab(4);
                    break;
            }
        }

        // HTML 内容到输入框中显示 [待完善]
        private string ToText(string html)
        {
            return html.Replace("<br>", "\r\n");
        }

        // 输入框中的内容转换为 HTML 格式 [待完善]
        private string ToHtml(string text)
        {
            return text.Replace("\r\n", "<br>");
        }

        // 写文件 [Utf-8]
        public static void WriteFile(string sPath, string sText)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(sPath));
            StreamWriter sw = new StreamWriter(sPath, false, Encoding.UTF8);
            sw.Write(sText);
            sw.Close();
        }
    }

    // 参数数据
    class NodeParam
    {
        public string Caption;
        public string DataType;
        public string Describe;
        public bool Optional;
    }

    // 节点数据
    class NodeData
    {
        public string Caption;
        public string Remark;
        public string Icon;
        public string Templet;
        public bool Visible;
        public bool Function;
        public string InsCode;
        public string InsCodeTop;
        public string InsCodeEnd;

        public string Cmd_Caption;
        public string Cmd_Define;
        public string Cmd_Describe;
        public string Cmd_RetType;
        public string Cmd_Return;
        public ArrayList Cmd_Param;

        public string Doc_Caption;
        public string Doc_Document;

        public string Syn_Caption;
        public string Syn_Define;
        public string Syn_Describe;

        public string Tpe_Caption;
        public string Tpe_Define;
        public string Tpe_Describe;
        
        public string Help_Else;

        public void DefaultValue()
        {
            Caption = "新节点";
            Remark = "";
            Icon = "函数";
            Templet = "command.html";
            Visible = true;
            Function = true;
            InsCode = "";
            InsCodeTop = "";
            InsCodeEnd = "";

            Cmd_Caption = "";
            Cmd_Define = "";
            Cmd_Describe = "";
            Cmd_RetType = "";
            Cmd_Return = "";
            Cmd_Param = new ArrayList();

            Doc_Caption = "";
            Doc_Document = "";

            Syn_Caption = "";
            Syn_Define = "";
            Syn_Describe = "";

            Tpe_Caption = "";
            Tpe_Define = "";
            Tpe_Describe = "";

            Help_Else = "";
        }
    }
}
