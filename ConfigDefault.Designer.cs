
namespace OpenINI
{
    partial class ConfigDefault
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
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.cbxKey = new System.Windows.Forms.ComboBox();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.btnWriteConfig = new System.Windows.Forms.Button();
            this.tbxSection = new System.Windows.Forms.TextBox();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.tbxSKValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnDeleteConfig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSection
            // 
            this.cbxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSection.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(555, 31);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(397, 39);
            this.cbxSection.TabIndex = 0;
            this.cbxSection.SelectedIndexChanged += new System.EventHandler(this.cbxSection_SelectedIndexChanged);
            // 
            // cbxKey
            // 
            this.cbxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKey.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxKey.FormattingEnabled = true;
            this.cbxKey.Location = new System.Drawing.Point(555, 108);
            this.cbxKey.Name = "cbxKey";
            this.cbxKey.Size = new System.Drawing.Size(397, 39);
            this.cbxKey.TabIndex = 1;
            this.cbxKey.SelectedIndexChanged += new System.EventHandler(this.cbxKey_SelectedIndexChanged);
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadConfig.Location = new System.Drawing.Point(323, 47);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(185, 59);
            this.btnReadConfig.TabIndex = 3;
            this.btnReadConfig.Text = "更新配置";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // btnWriteConfig
            // 
            this.btnWriteConfig.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteConfig.Location = new System.Drawing.Point(571, 47);
            this.btnWriteConfig.Name = "btnWriteConfig";
            this.btnWriteConfig.Size = new System.Drawing.Size(181, 59);
            this.btnWriteConfig.TabIndex = 4;
            this.btnWriteConfig.Text = "写入配置";
            this.btnWriteConfig.UseVisualStyleBackColor = true;
            this.btnWriteConfig.Click += new System.EventHandler(this.btnWriteConfig_Click);
            // 
            // tbxSection
            // 
            this.tbxSection.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSection.Location = new System.Drawing.Point(139, 31);
            this.tbxSection.Name = "tbxSection";
            this.tbxSection.Size = new System.Drawing.Size(349, 39);
            this.tbxSection.TabIndex = 5;
            // 
            // tbxKey
            // 
            this.tbxKey.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxKey.Location = new System.Drawing.Point(139, 108);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(349, 39);
            this.tbxKey.TabIndex = 6;
            // 
            // tbxSKValues
            // 
            this.tbxSKValues.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSKValues.Location = new System.Drawing.Point(139, 190);
            this.tbxSKValues.Name = "tbxSKValues";
            this.tbxSKValues.Size = new System.Drawing.Size(349, 39);
            this.tbxSKValues.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "节名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "键名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "值名称：";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectFile.Location = new System.Drawing.Point(33, 47);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(236, 59);
            this.btnSelectFile.TabIndex = 11;
            this.btnSelectFile.Text = "配置文件路径选择";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnDeleteConfig
            // 
            this.btnDeleteConfig.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteConfig.Location = new System.Drawing.Point(795, 47);
            this.btnDeleteConfig.Name = "btnDeleteConfig";
            this.btnDeleteConfig.Size = new System.Drawing.Size(188, 59);
            this.btnDeleteConfig.TabIndex = 13;
            this.btnDeleteConfig.Text = "删除配置";
            this.btnDeleteConfig.UseVisualStyleBackColor = true;
            this.btnDeleteConfig.Click += new System.EventHandler(this.btnDeleteConfig_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxKey);
            this.groupBox1.Controls.Add(this.tbxSection);
            this.groupBox1.Controls.Add(this.tbxSKValues);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxKey);
            this.groupBox1.Controls.Add(this.cbxSection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 269);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置参数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteConfig);
            this.groupBox2.Controls.Add(this.btnReadConfig);
            this.groupBox2.Controls.Add(this.btnWriteConfig);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Location = new System.Drawing.Point(22, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 143);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置操作";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.ComboBox cbxKey;
        private System.Windows.Forms.Button btnReadConfig;
        private System.Windows.Forms.Button btnWriteConfig;
        private System.Windows.Forms.TextBox tbxSection;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.TextBox tbxSKValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnDeleteConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}