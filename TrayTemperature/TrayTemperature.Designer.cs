
namespace TrayTemperature
{
    partial class TrayTemperature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayTemperature));
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStripChangeDisplayColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStripRgbValue = new System.Windows.Forms.ToolStripTextBox();
            this.trayMenuStripResetLocationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.trayMenuStrip;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Tray Temperature v2.0";
            this.tray.Visible = true;
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.trayMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runOnStartupToolStripMenuItem,
            this.trayMenuStripChangeDisplayColorItem,
            this.trayMenuStripResetLocationItem,
            this.trayMenuStripExitItem});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(223, 112);
            this.trayMenuStrip.Text = "Tray Temperature 2.0";
            // 
            // runOnStartupToolStripMenuItem
            // 
            this.runOnStartupToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.runOnStartupToolStripMenuItem.Checked = true;
            this.runOnStartupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.runOnStartupToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.runOnStartupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.runOnStartupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runOnStartupToolStripMenuItem.Name = "runOnStartupToolStripMenuItem";
            this.runOnStartupToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.runOnStartupToolStripMenuItem.Size = new System.Drawing.Size(222, 20);
            this.runOnStartupToolStripMenuItem.Text = "Run on startup";
            this.runOnStartupToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.runOnStartupToolStripMenuItem.CheckedChanged += new System.EventHandler(this.runOnStartupToolStripMenuItem_CheckedChanged);
            // 
            // trayMenuStripChangeDisplayColorItem
            // 
            this.trayMenuStripChangeDisplayColorItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trayMenuStripChangeDisplayColorItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuStripRgbValue});
            this.trayMenuStripChangeDisplayColorItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trayMenuStripChangeDisplayColorItem.Name = "trayMenuStripChangeDisplayColorItem";
            this.trayMenuStripChangeDisplayColorItem.Size = new System.Drawing.Size(222, 22);
            this.trayMenuStripChangeDisplayColorItem.Text = "Change display color (RGB)";
            this.trayMenuStripChangeDisplayColorItem.DropDownClosed += new System.EventHandler(this.trayMenuStripChangeDisplayColorItem_DropDownClosed);
            // 
            // trayMenuStripRgbValue
            // 
            this.trayMenuStripRgbValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayMenuStripRgbValue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trayMenuStripRgbValue.Name = "trayMenuStripRgbValue";
            this.trayMenuStripRgbValue.Size = new System.Drawing.Size(100, 23);
            // 
            // trayMenuStripResetLocationItem
            // 
            this.trayMenuStripResetLocationItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trayMenuStripResetLocationItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trayMenuStripResetLocationItem.Name = "trayMenuStripResetLocationItem";
            this.trayMenuStripResetLocationItem.Size = new System.Drawing.Size(222, 22);
            this.trayMenuStripResetLocationItem.Text = "Reset location";
            this.trayMenuStripResetLocationItem.Click += new System.EventHandler(this.trayMenuStripResetLocationItem_Click);
            // 
            // trayMenuStripExitItem
            // 
            this.trayMenuStripExitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trayMenuStripExitItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trayMenuStripExitItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trayMenuStripExitItem.Name = "trayMenuStripExitItem";
            this.trayMenuStripExitItem.Size = new System.Drawing.Size(222, 22);
            this.trayMenuStripExitItem.Text = "Exit";
            this.trayMenuStripExitItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.trayMenuStripExitItem.Click += new System.EventHandler(this.trayMenuStripExitItem_Click);
            // 
            // TrayTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrayTemperature";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tray Temperature v2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TrayTemperature_Load);
            this.trayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem runOnStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStripChangeDisplayColorItem;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStripResetLocationItem;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStripExitItem;
        private System.Windows.Forms.ToolStripTextBox trayMenuStripRgbValue;
    }
}

