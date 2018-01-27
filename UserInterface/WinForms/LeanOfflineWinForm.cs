using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuantConnect.Logging;
using QuantConnect.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts.Geared;

namespace QuantConnect.Views.WinForms
{
    public partial class LeanOfflineWinForm : Form, IDesktopMessageHandler
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private readonly QueueLogHandler _logging;

        public LeanOfflineWinForm()
        {
            InitializeComponent();

            CenterToScreen();
            WindowState = FormWindowState.Maximized;
            Text = "QuantConnect Lean Algorithmic Trading Engine.  Offline Viewer : v" + Globals.Version;
            _logging = new QueueLogHandler();
        }

        public void DisplayBacktestResultsPacket(BacktestResultPacket packet)
        {
            if (packet.Progress != 1) return;
            _logging.Trace("Recieved backtest result packet.");

            var charts = packet.Results?.Charts;

            if(charts != null)
            {
                foreach(var chart in charts)
                {
                    var chartSelectionButton = new Button();
                    chartSelectionButton.Text = chart.Key;
                    chartSelectionButton.Dock = DockStyle.Top;
                    chartSelectionButton.Click += (sender, EventArgs) => { RenderChart(chart.Value); }; ;

                    this.BeginInvoke((Action)(() =>
                    {
                        ChartButtonList.Controls.Add(chartSelectionButton);
                    }));
                }
            }
        }

        private static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }

        private void RenderChart(Chart chart)
        {
            Chart.AxisX = new AxesCollection();
            Chart.AxisY = new AxesCollection();

            var seriesCollection = new SeriesCollection();
            foreach (var series in chart.Series) {
                seriesCollection.Add(new GLineSeries()
                {
                    Title = series.Key,
                    Values = new ChartValues<decimal>(series.Value.Values.Select(val => val.y))
                                    .AsGearedValues().WithQuality(Quality.Low),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    StrokeThickness = 0.8
                });

            }

            Chart.AxisY.Add(new Axis
            {
                LabelFormatter = yVal => yVal.ToString("C")
            });

            Chart.AxisX.Add(new Axis { 
                Labels = chart.Series.First().Value.Values
                            .Select(val => FromUnixTime(val.x).ToString("yyyy-MM-dd"))
                            .ToList()
            });

            Chart.LegendLocation = LegendLocation.Top;

            Chart.Series = seriesCollection;
        }

        public void DisplayDebugPacket(DebugPacket packet)
        {
            _logging.Trace(packet.Message);
        }

        public void DisplayHandledErrorPacket(HandledErrorPacket packet)
        {
            var hstack = (!string.IsNullOrEmpty(packet.StackTrace) ? (Environment.NewLine + " " + packet.StackTrace) : string.Empty);
            _logging.Error(packet.Message + hstack);
        }

        public void DisplayLogPacket(LogPacket packet)
        {
            _logging.Trace(packet.Message);
        }

        public void DisplayRuntimeErrorPacket(RuntimeErrorPacket packet)
        {
            var rstack = (!string.IsNullOrEmpty(packet.StackTrace) ? (Environment.NewLine + " " + packet.StackTrace) : string.Empty);
            _logging.Error(packet.Message + rstack);
        }

        public void Initialize(AlgorithmNodePacket job)
        {
            _logging.Trace("Recieved init packet.");
        }

        /// <summary>
        /// Update the status label at the bottom of the form
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            StatisticsToolStripStatusLabel.Text = string.Concat("Performance: CPU: ", OS.CpuUsage.NextValue().ToString("0.0"), "%",
                                                                " Ram: ", OS.TotalPhysicalMemoryUsed, " Mb");

            if (_logging == null) return;

            LogEntry log;
            while (_logging.Logs.TryDequeue(out log))
            {
                switch (log.MessageType)
                {
                    case LogType.Debug:
                        LogTextBox.AppendText(log.ToString(), System.Drawing.Color.Black);
                        break;
                    default:
                    case LogType.Trace:
                        LogTextBox.AppendText(log.ToString(), System.Drawing.Color.Black);
                        break;
                    case LogType.Error:
                        LogTextBox.AppendText(log.ToString(), System.Drawing.Color.DarkRed);
                        break;
                }
            }
        }

    }
}
