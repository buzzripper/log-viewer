using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogViewer;

public partial class GlowPanel : UserControl
{
    private Timer _pulseTimer;
    private int _frame = 0;
    private const int _totalFrames = 30;

    // Dark blue and bright blue used in the GIF
    private readonly Color darkBlue = Color.FromArgb(0, 20, 140);
    private readonly Color brightBlue = Color.FromArgb(0, 160, 255);

    public GlowPanel()
    {
        _pulseTimer = new Timer();
        _pulseTimer.Interval = 80; // match gif frame speed (100ms)
        _pulseTimer.Tick += PulseTimer_Tick;

        this.DoubleBuffered = true;
        this.BackColor = Color.Transparent;
    }

    public void Start()
    {
        _pulseTimer.Start();
    }

    public void Stop()
    {
        _pulseTimer.Stop();
		this.BackColor = Color.Transparent;
	}

    private void PulseTimer_Tick(object sender, EventArgs e)
    {
        _frame = (_frame + 1) % _totalFrames;
        float factor;

        if (_frame < _totalFrames / 2)
            factor = _frame / (float)(_totalFrames / 2);
        else
            factor = (_totalFrames - _frame) / (float)(_totalFrames / 2);

        int r = (int)(darkBlue.R + factor * (brightBlue.R - darkBlue.R));
        int g = (int)(darkBlue.G + factor * (brightBlue.G - darkBlue.G));
        int b = (int)(darkBlue.B + factor * (brightBlue.B - darkBlue.B));
        int a = (int)(255 * (0.3 + 0.7 * factor)); // Vary alpha from ~76 to 255

        this.BackColor = Color.FromArgb(a, r, g, b);
        this.Invalidate();
    }
}
