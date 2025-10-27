using LogViewer.Config;
using System.Windows.Forms;

namespace LogViewer;

public partial class OptionsForm : Form
{
    public OptionsForm()
    {
        InitializeComponent();
    }

    public DialogResult Run(AppConfig appConfig)
    {
        numAutoRefreshTimerIntervalMs.Value = appConfig.AutoRefreshTimerIntervalMs / 1000;
        numAutoRefreshTimeoutTimerIntervalMs.Value = appConfig.AutoRefreshTimeoutTimerIntervalMs / 60000;

        ShowDialog();

        if (this.DialogResult == DialogResult.OK)
        {
            appConfig.AutoRefreshTimerIntervalMs = (int)numAutoRefreshTimerIntervalMs.Value * 1000;
            appConfig.AutoRefreshTimeoutTimerIntervalMs = (int)numAutoRefreshTimeoutTimerIntervalMs.Value * 60000;
        }

        this.Hide();
        return this.DialogResult;
    }

    private void btnOk_Click(object sender, System.EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }
}