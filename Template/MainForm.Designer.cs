namespace Template
{
    partial class Template
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Build = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.LogRecord = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.richTextBoxGeneral = new System.Windows.Forms.RichTextBox();
            this.tabPageWarning = new System.Windows.Forms.TabPage();
            this.richTextBoxWarning = new System.Windows.Forms.RichTextBox();
            this.tabPageError = new System.Windows.Forms.TabPage();
            this.richTextBoxError = new System.Windows.Forms.RichTextBox();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.richTextBoxDebug = new System.Windows.Forms.RichTextBox();
            this.Demo = new System.Windows.Forms.Button();
            this.ServeIP0 = new System.Windows.Forms.TextBox();
            this.Port0 = new System.Windows.Forms.TextBox();
            this.ServeIP1 = new System.Windows.Forms.TextBox();
            this.Port1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LogRecord.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageWarning.SuspendLayout();
            this.tabPageError.SuspendLayout();
            this.tabPageDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // Build
            // 
            resources.ApplyResources(this.Build, "Build");
            this.Build.Name = "Build";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // Modify
            // 
            resources.ApplyResources(this.Modify, "Modify");
            this.Modify.Name = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // Add
            // 
            resources.ApplyResources(this.Add, "Add");
            this.Add.Name = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // LogRecord
            // 
            resources.ApplyResources(this.LogRecord, "LogRecord");
            this.LogRecord.Controls.Add(this.tabPageGeneral);
            this.LogRecord.Controls.Add(this.tabPageWarning);
            this.LogRecord.Controls.Add(this.tabPageError);
            this.LogRecord.Controls.Add(this.tabPageDebug);
            this.LogRecord.Name = "LogRecord";
            this.LogRecord.SelectedIndex = 0;
            this.LogRecord.Tag = "";
            // 
            // tabPageGeneral
            // 
            resources.ApplyResources(this.tabPageGeneral, "tabPageGeneral");
            this.tabPageGeneral.Controls.Add(this.richTextBoxGeneral);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // richTextBoxGeneral
            // 
            resources.ApplyResources(this.richTextBoxGeneral, "richTextBoxGeneral");
            this.richTextBoxGeneral.Name = "richTextBoxGeneral";
            // 
            // tabPageWarning
            // 
            resources.ApplyResources(this.tabPageWarning, "tabPageWarning");
            this.tabPageWarning.Controls.Add(this.richTextBoxWarning);
            this.tabPageWarning.Name = "tabPageWarning";
            this.tabPageWarning.UseVisualStyleBackColor = true;
            // 
            // richTextBoxWarning
            // 
            resources.ApplyResources(this.richTextBoxWarning, "richTextBoxWarning");
            this.richTextBoxWarning.Name = "richTextBoxWarning";
            // 
            // tabPageError
            // 
            resources.ApplyResources(this.tabPageError, "tabPageError");
            this.tabPageError.Controls.Add(this.richTextBoxError);
            this.tabPageError.Name = "tabPageError";
            this.tabPageError.UseVisualStyleBackColor = true;
            // 
            // richTextBoxError
            // 
            resources.ApplyResources(this.richTextBoxError, "richTextBoxError");
            this.richTextBoxError.Name = "richTextBoxError";
            // 
            // tabPageDebug
            // 
            resources.ApplyResources(this.tabPageDebug, "tabPageDebug");
            this.tabPageDebug.Controls.Add(this.richTextBoxDebug);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDebug
            // 
            resources.ApplyResources(this.richTextBoxDebug, "richTextBoxDebug");
            this.richTextBoxDebug.Name = "richTextBoxDebug";
            // 
            // Demo
            // 
            resources.ApplyResources(this.Demo, "Demo");
            this.Demo.Name = "Demo";
            this.Demo.UseVisualStyleBackColor = true;
            this.Demo.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // ServeIP0
            // 
            resources.ApplyResources(this.ServeIP0, "ServeIP0");
            this.ServeIP0.Name = "ServeIP0";
            // 
            // Port0
            // 
            resources.ApplyResources(this.Port0, "Port0");
            this.Port0.Name = "Port0";
            // 
            // ServeIP1
            // 
            resources.ApplyResources(this.ServeIP1, "ServeIP1");
            this.ServeIP1.Name = "ServeIP1";
            // 
            // Port1
            // 
            resources.ApplyResources(this.Port1, "Port1");
            this.Port1.Name = "Port1";
            // 
            // Template
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Port1);
            this.Controls.Add(this.ServeIP1);
            this.Controls.Add(this.Port0);
            this.Controls.Add(this.ServeIP0);
            this.Controls.Add(this.Demo);
            this.Controls.Add(this.LogRecord);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Template";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LogRecord.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageWarning.ResumeLayout(false);
            this.tabPageError.ResumeLayout(false);
            this.tabPageDebug.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TabControl LogRecord;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageWarning;
        private System.Windows.Forms.TabPage tabPageError;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.RichTextBox richTextBoxGeneral;
        private System.Windows.Forms.RichTextBox richTextBoxWarning;
        private System.Windows.Forms.RichTextBox richTextBoxError;
        private System.Windows.Forms.RichTextBox richTextBoxDebug;
        private System.Windows.Forms.Button Demo;
        private System.Windows.Forms.TextBox ServeIP0;
        private System.Windows.Forms.TextBox Port0;
        private System.Windows.Forms.TextBox ServeIP1;
        private System.Windows.Forms.TextBox Port1;
    }
}

