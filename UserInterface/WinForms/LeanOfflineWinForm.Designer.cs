using LiveCharts;
using System;

namespace QuantConnect.Views.WinForms
{
    partial class LeanOfflineWinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeanOfflineWinForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FormToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FormToolStripStatusStringLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatisticsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FormToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitPanel = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Chart = new LiveCharts.WinForms.CartesianChart();
            this.ChartButtonList = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).BeginInit();
            this.splitPanel.Panel1.SuspendLayout();
            this.splitPanel.Panel2.SuspendLayout();
            this.splitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormToolStripStatusLabel,
            this.FormToolStripStatusStringLabel,
            this.StatisticsToolStripStatusLabel,
            this.FormToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1044, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormToolStripStatusLabel
            // 
            this.FormToolStripStatusLabel.Name = "FormToolStripStatusLabel";
            this.FormToolStripStatusLabel.Size = new System.Drawing.Size(105, 17);
            this.FormToolStripStatusLabel.Text = "Loading Complete";
            // 
            // FormToolStripStatusStringLabel
            // 
            this.FormToolStripStatusStringLabel.Name = "FormToolStripStatusStringLabel";
            this.FormToolStripStatusStringLabel.Size = new System.Drawing.Size(737, 17);
            this.FormToolStripStatusStringLabel.Spring = true;
            // 
            // StatisticsToolStripStatusLabel
            // 
            this.StatisticsToolStripStatusLabel.Name = "StatisticsToolStripStatusLabel";
            this.StatisticsToolStripStatusLabel.Size = new System.Drawing.Size(136, 17);
            this.StatisticsToolStripStatusLabel.Text = "Statistics: CPU:    Ram:    ";
            // 
            // FormToolStripProgressBar
            // 
            this.FormToolStripProgressBar.Name = "FormToolStripProgressBar";
            this.FormToolStripProgressBar.Size = new System.Drawing.Size(55, 16);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // splitPanel
            // 
            this.splitPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel.Location = new System.Drawing.Point(0, 0);
            this.splitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPanel.Panel1
            // 
            this.splitPanel.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitPanel.Panel2
            // 
            this.splitPanel.Panel2.Controls.Add(this.groupLog);
            this.splitPanel.Panel2MinSize = 100;
            this.splitPanel.Size = new System.Drawing.Size(1044, 512);
            this.splitPanel.SplitterDistance = 395;
            this.splitPanel.SplitterWidth = 5;
            this.splitPanel.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Chart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ChartButtonList);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 391);
            this.splitContainer1.SplitterDistance = 843;
            this.splitContainer1.TabIndex = 0;
            // 
            // Chart
            // 
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(841, 389);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "cartesianChart1";
            this.Chart.DisableAnimations = true;
            this.Chart.AnimationsSpeed = TimeSpan.FromMilliseconds(150);
            this.Chart.Zoom = ZoomingOptions.X;
            this.Chart.BackColor = System.Drawing.Color.White;

            // 
            // ChartButtonList
            // 
            this.ChartButtonList.ColumnCount = 1;
            this.ChartButtonList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChartButtonList.Location = new System.Drawing.Point(19, 35);
            this.ChartButtonList.Name = "ChartButtonList";
            this.ChartButtonList.RowCount = 1;
            this.ChartButtonList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ChartButtonList.Size = new System.Drawing.Size(163, 351);
            this.ChartButtonList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Charts";
            // 
            // groupLog
            // 
            this.groupLog.Controls.Add(this.LogTextBox);
            this.groupLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLog.Location = new System.Drawing.Point(0, 0);
            this.groupLog.Margin = new System.Windows.Forms.Padding(2);
            this.groupLog.Name = "groupLog";
            this.groupLog.Padding = new System.Windows.Forms.Padding(2);
            this.groupLog.Size = new System.Drawing.Size(1040, 108);
            this.groupLog.TabIndex = 0;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Log";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(2, 15);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(1036, 91);
            this.LogTextBox.TabIndex = 0;
            this.LogTextBox.Text = "";
            // 
            // LeanOfflineWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 534);
            this.Controls.Add(this.splitPanel);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeanOfflineWinForm";
            this.Text = "Lean Offline View";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitPanel.Panel1.ResumeLayout(false);
            this.splitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).EndInit();
            this.splitPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FormToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel FormToolStripStatusStringLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatisticsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar FormToolStripProgressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.SplitContainer splitPanel;
        private System.Windows.Forms.GroupBox groupLog;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private LiveCharts.WinForms.CartesianChart Chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ChartButtonList;
    }
}