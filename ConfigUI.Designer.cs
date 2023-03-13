
namespace OpenINI
{
    partial class ConfigUI
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
            this.btnFreshConifg = new Sunny.UI.UISymbolButton();
            this.btnDeleteConfig = new Sunny.UI.UISymbolButton();
            this.btnWriteConfig = new Sunny.UI.UISymbolButton();
            this.btnSelectFile = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.cbxSection = new Sunny.UI.UIComboBox();
            this.cbxKey = new Sunny.UI.UIComboBox();
            this.tbxSKValues = new Sunny.UI.UITextBox();
            this.tbxKey = new Sunny.UI.UITextBox();
            this.tbxSection = new Sunny.UI.UITextBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFreshConifg
            // 
            this.btnFreshConifg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFreshConifg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFreshConifg.Location = new System.Drawing.Point(391, 49);
            this.btnFreshConifg.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFreshConifg.Name = "btnFreshConifg";
            this.btnFreshConifg.Size = new System.Drawing.Size(161, 60);
            this.btnFreshConifg.Symbol = 61473;
            this.btnFreshConifg.TabIndex = 0;
            this.btnFreshConifg.Text = "更新配置";
            this.btnFreshConifg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFreshConifg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnFreshConifg.Click += new System.EventHandler(this.btnFreshConifg_Click);
            // 
            // btnDeleteConfig
            // 
            this.btnDeleteConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteConfig.Location = new System.Drawing.Point(832, 49);
            this.btnDeleteConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteConfig.Name = "btnDeleteConfig";
            this.btnDeleteConfig.Size = new System.Drawing.Size(161, 60);
            this.btnDeleteConfig.Symbol = 262189;
            this.btnDeleteConfig.TabIndex = 1;
            this.btnDeleteConfig.Text = "删除配置";
            this.btnDeleteConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnDeleteConfig.Click += new System.EventHandler(this.btnDeleteConfig_Click);
            // 
            // btnWriteConfig
            // 
            this.btnWriteConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteConfig.Location = new System.Drawing.Point(605, 49);
            this.btnWriteConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWriteConfig.Name = "btnWriteConfig";
            this.btnWriteConfig.Size = new System.Drawing.Size(161, 60);
            this.btnWriteConfig.Symbol = 261639;
            this.btnWriteConfig.TabIndex = 2;
            this.btnWriteConfig.Text = "保存配置";
            this.btnWriteConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnWriteConfig.Click += new System.EventHandler(this.btnWriteConfig_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectFile.Location = new System.Drawing.Point(110, 49);
            this.btnSelectFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(215, 60);
            this.btnSelectFile.Symbol = 110;
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "选择配置文件";
            this.btnSelectFile.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectFile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(18, 46);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(115, 31);
            this.uiMarkLabel1.TabIndex = 9;
            this.uiMarkLabel1.Text = "节名称：";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.AutoSize = true;
            this.uiMarkLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(18, 120);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(115, 31);
            this.uiMarkLabel2.TabIndex = 10;
            this.uiMarkLabel2.Text = "键名称：";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(18, 197);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(134, 39);
            this.uiMarkLabel3.TabIndex = 11;
            this.uiMarkLabel3.Text = "值：";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxSection
            // 
            this.cbxSection.DataSource = null;
            this.cbxSection.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbxSection.FillColor = System.Drawing.Color.White;
            this.cbxSection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxSection.Location = new System.Drawing.Point(623, 47);
            this.cbxSection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSection.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxSection.Size = new System.Drawing.Size(411, 39);
            this.cbxSection.TabIndex = 12;
            this.cbxSection.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxSection.Watermark = "";
            this.cbxSection.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxSection.SelectedIndexChanged += new System.EventHandler(this.cbxSection_SelectedIndexChanged);
            // 
            // cbxKey
            // 
            this.cbxKey.DataSource = null;
            this.cbxKey.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbxKey.FillColor = System.Drawing.Color.White;
            this.cbxKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxKey.Location = new System.Drawing.Point(623, 121);
            this.cbxKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxKey.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxKey.Name = "cbxKey";
            this.cbxKey.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxKey.Size = new System.Drawing.Size(411, 39);
            this.cbxKey.TabIndex = 13;
            this.cbxKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxKey.Watermark = "";
            this.cbxKey.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxKey.SelectedIndexChanged += new System.EventHandler(this.cbxKey_SelectedIndexChanged);
            // 
            // tbxSKValues
            // 
            this.tbxSKValues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSKValues.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSKValues.Location = new System.Drawing.Point(140, 198);
            this.tbxSKValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSKValues.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbxSKValues.Name = "tbxSKValues";
            this.tbxSKValues.ShowText = false;
            this.tbxSKValues.Size = new System.Drawing.Size(402, 40);
            this.tbxSKValues.TabIndex = 14;
            this.tbxSKValues.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxSKValues.Watermark = "";
            this.tbxSKValues.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbxKey
            // 
            this.tbxKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxKey.Location = new System.Drawing.Point(140, 120);
            this.tbxKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxKey.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.ShowText = false;
            this.tbxKey.Size = new System.Drawing.Size(402, 40);
            this.tbxKey.TabIndex = 15;
            this.tbxKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxKey.Watermark = "";
            this.tbxKey.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbxSection
            // 
            this.tbxSection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSection.Location = new System.Drawing.Point(140, 46);
            this.tbxSection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSection.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbxSection.Name = "tbxSection";
            this.tbxSection.ShowText = false;
            this.tbxSection.Size = new System.Drawing.Size(402, 40);
            this.tbxSection.TabIndex = 15;
            this.tbxSection.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxSection.Watermark = "";
            this.tbxSection.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cbxKey);
            this.uiGroupBox1.Controls.Add(this.tbxSection);
            this.uiGroupBox1.Controls.Add(this.uiMarkLabel1);
            this.uiGroupBox1.Controls.Add(this.tbxKey);
            this.uiGroupBox1.Controls.Add(this.uiMarkLabel2);
            this.uiGroupBox1.Controls.Add(this.tbxSKValues);
            this.uiGroupBox1.Controls.Add(this.uiMarkLabel3);
            this.uiGroupBox1.Controls.Add(this.cbxSection);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(30, 52);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1065, 271);
            this.uiGroupBox1.TabIndex = 16;
            this.uiGroupBox1.Text = "配置参数";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btnSelectFile);
            this.uiGroupBox2.Controls.Add(this.btnFreshConifg);
            this.uiGroupBox2.Controls.Add(this.btnDeleteConfig);
            this.uiGroupBox2.Controls.Add(this.btnWriteConfig);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(30, 333);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(1065, 148);
            this.uiGroupBox2.TabIndex = 17;
            this.uiGroupBox2.Text = "配置操作";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ConfigUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1127, 513);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.MaximumSize = new System.Drawing.Size(1127, 513);
            this.MinimumSize = new System.Drawing.Size(1127, 513);
            this.Name = "ConfigUI";
            this.Text = "ConfigUI";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.ConfigUI_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton btnFreshConifg;
        private Sunny.UI.UISymbolButton btnDeleteConfig;
        private Sunny.UI.UISymbolButton btnWriteConfig;
        private Sunny.UI.UISymbolButton btnSelectFile;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UIComboBox cbxSection;
        private Sunny.UI.UIComboBox cbxKey;
        private Sunny.UI.UITextBox tbxSKValues;
        private Sunny.UI.UITextBox tbxKey;
        private Sunny.UI.UITextBox tbxSection;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
    }
}