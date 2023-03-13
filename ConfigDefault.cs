using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;


namespace OpenINI
{
    public partial class ConfigDefault : Form
    {
        public OpenINI opi;
        public string section;
        public string key;
        public string skvalue;
        public static string filePath = @".\ini";
        public string fileName="configs.ini";
        public ConfigDefault()
        {
            InitializeComponent();
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);    //创建目录
            }
            fileName = $"{filePath}\\{fileName}";    //创建对应目录的文件名称
            if (!File.Exists(fileName)) File.Create(fileName);
            opi = new OpenINI(fileName);
        }
        /// <summary>
        /// 用于选择不是默认的配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Title = "选择配置文件";
            opn.Filter = ".ini配置文件|*.ini";
            if (opn.ShowDialog() == DialogResult.OK)
            {
                fileName = opn.FileName;
                opi = new OpenINI(fileName);
            }
        }
        /// <summary>
        /// 配置写入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteConfig_Click(object sender, EventArgs e)
        {
            section = tbxSection.Text;
            key= tbxKey.Text;
            skvalue = tbxSKValues.Text;
            if (section.Length == 0 || key.Length == 0 || skvalue.Length == 0) MessageBox.Show("你输入的其中一项为空，请确保节名，键名，值名不为空!", "写入提示！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            opi.WriteINI(section,key,skvalue);
        }
        /// <summary>
        /// 更新配置参数到key列表下拉菜单中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            section= cbxSection.SelectedItem.ToString();
            StringCollection keys= opi.ReadAllKey(section);
            cbxKey.Items.Clear();
            foreach(var skvalues in keys)
            {
                cbxKey.Items.Add(skvalues);
            }
        }
        /// <summary>
        /// 更新配置参数到section列表下拉菜单中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadConfig_Click(object sender, EventArgs e)
        {
            Select();
            ClearText();
        }
        private void cbxKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            section = cbxSection.Text;
            key= cbxKey.Text;
            if (opi.ItemExists(section,key)) MessageBox.Show("读取时，无该项！");
            tbxSection.Text = section;
            tbxKey.Text = key;
            tbxSKValues.Text = opi.ReadIni(section, key);
        }
        /// <summary>
        /// 删除配置，若只选择section项，只删除section项对应节名，若选择section和key项，删除对应section下的key的值（项）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteConfig_Click(object sender, EventArgs e)
        {
            section = cbxSection.Text;
            key = tbxKey.Text;
            if (cbxSection.SelectedIndex > -1 && cbxKey.SelectedIndex ==-1) {
                opi.DeleteSection(section);
            }
            else if ( cbxKey.SelectedIndex > -1)
            {
                opi.DeleteKey(section, key);
            }
            else
            {
                MessageBox.Show("你还未选择任何参数，请先选择！", "删除操作提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 窗体载入函数，初始读取默认配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            Select();
            ClearText();
        }
        /// <summary>
        /// 更新Section列表内容
        /// </summary>
        private void Select()
        {
            cbxSection.Items.Clear();
            cbxKey.Items.Clear();
            StringCollection sections = opi.ReadAllSections();
            foreach (var sct in sections)
            {
                cbxSection.Items.Add(sct);
            }
        }
        /// <summary>
        /// 清空数据参数显示框
        /// </summary>
        private void ClearText()
        {
            tbxSection.Clear();
            tbxKey.Clear();
            tbxSKValues.Clear();
        }
    }
}
