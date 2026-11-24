using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        #region Function
        private void ConfigureDataGridView()
        {
            // 設定外觀與行為屬性
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            // 設定交錯列背景色（斑馬紋）
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
        }

        #region LoadConfig
        private void LoadConfig()
        {
            rootConfig = configMgr.Load();
            if (rootConfig != null && rootConfig.Parameters.Count >= 2)
            {
                ServeIP0.Text = rootConfig.Parameters[0].ServerIp;
                ServeIP1.Text = rootConfig.Parameters[1].ServerIp;
                Port0.Text = rootConfig.Parameters[0].Port.ToString();
                Port1.Text = rootConfig.Parameters[1].Port.ToString();

            }
            else
            {
                rootConfig.Parameters.Add(new AppSettings { ServerIp = "", Port = 0 });
                rootConfig.Parameters.Add(new AppSettings { ServerIp = "", Port = 0 });
                configMgr.Save(rootConfig);
            }
        }
        #endregion

        #region SaveConfig
        private void SaveConfig()
        {
            rootConfig.Parameters[0].ServerIp = ServeIP0.Text;
            rootConfig.Parameters[1].ServerIp = ServeIP1.Text;
            rootConfig.Parameters[0].Port = Convert.ToInt32(Port0.Text);
            rootConfig.Parameters[1].Port = Convert.ToInt32(Port1.Text);
            configMgr.Save(rootConfig);
        }
        #endregion

        private void InitUI()
        {
            ServeIP0.SetWatermark("請輸入IP");
            Port0.SetWatermark("請輸入Port");
            ServeIP1.SetWatermark("請輸入IP");
            Port1.SetWatermark("請輸入Port");
        }

        /// <summary>
        /// Usage:Log.Information("Info!");
        /// </summary>
        private void LogInit()
        {
            // 初始化 Serilog 並註冊你的 UI 控制項
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug() // 設定最低記錄層級
            // 同時寫入實體檔案（每天會自動產生一個新檔案）
            .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logger", "log-.txt"), rollingInterval: RollingInterval.Day)
            // 透過我們寫的擴充方法綁定控制項（依序對應：一般、警告、錯誤、除錯）
            .WriteTo.WinFormRichTextBox(richTextBoxDebug, richTextBoxGeneral, richTextBoxWarning, richTextBoxError, tabControl: LogRecord)
            .CreateLogger();
        }

        private void ChangeLanguage(string cultureName)
        {
            // 設定執行緒的文化特性
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);

            // 使用 ComponentResourceManager 重新讀取資源檔
            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());

            // 遞迴更新表單本身與所有子控制項的文字與屬性
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, Thread.CurrentThread.CurrentUICulture);
            }

            // 更新表單自身的標題等屬性
            resources.ApplyResources(this, "$this", Thread.CurrentThread.CurrentUICulture);
        }
        #endregion

        #region Initialization and parameter
        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            InitUI();
            LoadConfig();
            LogInit();
        }
        DataTable dt;
        private ConfigManager<AppRootConfig> configMgr = new ConfigManager<AppRootConfig>(@"Config\config.json", true);
        private AppRootConfig rootConfig;
        private string currentCulture = "zh-TW";
        #endregion

        private void MainBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case nameof(Build):
                    dt = new DataTable();
                    dt.Columns.Add("編號", typeof(int));
                    dt.Columns.Add("姓名", typeof(string));
                    dt.Columns.Add("職稱", typeof(string));

                    dt.Rows.Add(1, "張小明", "工程師");
                    dt.Rows.Add(2, "李美玲", "專案經理");
                    dt.Rows.Add(3, "王大同", "設計師");

                    dataGridView1.DataSource = dt;
                    break;
                case nameof(Modify):
                    try
                    {
                        if (dataGridView1.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("請先選擇要修改的資料列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        DataRowView drv = selectedRow.DataBoundItem as DataRowView;

                        if (drv != null)
                        {
                            drv["姓名"] = "王小明 (已修改)";
                            drv["職稱"] = "資深工程師";
                            drv.EndEdit();
                            MessageBox.Show("資料修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("發生未預期的錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case nameof(Add):
                    {
                        dt.Rows.Add(4, "陳小華", "測試員");
                        break;
                    }
                case nameof(Delete):
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            // 取得選取列對應的資料行索引
                            int rowIndex = dataGridView1.SelectedRows[0].Index;

                            // 從 DataTable 中移除該行
                            dt.Rows.RemoveAt(rowIndex);

                            // 註：資料移除後，DataGridView 會自動更新畫面
                        }
                        else
                        {
                            MessageBox.Show("請先選擇要刪除的列！");
                        }
                        break;
                    }
                case nameof(Demo):
                    //Log.Information("Info!");
                    //Log.Debug("Debug!");
                    //SaveConfig();
                    if (currentCulture == "zh-TW")
                    {
                        currentCulture = "zh-Hans";
                    }
                    else
                    {
                        currentCulture = "zh-TW";
                    }
                    ChangeLanguage(currentCulture);
                    break;
            }
        }

       
    }
}
