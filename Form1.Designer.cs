using System.Windows.Forms;

namespace Zad2_Mateusz_Moczarski
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openDir = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.openFile = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDir
            // 
            this.openDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openDir.Location = new System.Drawing.Point(12, 444);
            this.openDir.Name = "openDir";
            this.openDir.Size = new System.Drawing.Size(105, 49);
            this.openDir.TabIndex = 7;
            this.openDir.Text = "Otwórz folder";
            this.openDir.UseVisualStyleBackColor = true;
            this.openDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomOut.Location = new System.Drawing.Point(12, 664);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(237, 49);
            this.zoomOut.TabIndex = 7;
            this.zoomOut.Text = "Pomniejsz";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.ZoomMinus);
            // 
            // zoomIn
            // 
            this.zoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomIn.Location = new System.Drawing.Point(12, 609);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(237, 49);
            this.zoomIn.TabIndex = 7;
            this.zoomIn.Text = "Powiększ";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.ZoomPlus);
            // 
            // rotateLeft
            // 
            this.rotateLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateLeft.Location = new System.Drawing.Point(12, 499);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(237, 49);
            this.rotateLeft.TabIndex = 7;
            this.rotateLeft.Text = "Obróć w lewo";
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.RotateToLeft);
            // 
            // rotateRight
            // 
            this.rotateRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateRight.Location = new System.Drawing.Point(12, 554);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(237, 49);
            this.rotateRight.TabIndex = 7;
            this.rotateRight.Text = "Obróć w prawo";
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.RotateToRight);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(237, 426);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.SmallIcon;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.SelectImage);
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFile.Location = new System.Drawing.Point(144, 444);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(105, 49);
            this.openFile.TabIndex = 7;
            this.openFile.Text = "Otwórz plik";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 715);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1350, 26);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(0, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1095, 680);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 701);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obraz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.rotateLeft);
            this.Controls.Add(this.rotateRight);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.openDir);
            this.MinimumSize = new System.Drawing.Size(1368, 788);
            this.Name = "Form1";
            this.Text = "Przeglądarka obrazów by Moczarski";
            this.ResizeEnd += new System.EventHandler(this.ChangeSize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openDir;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox;
        private GroupBox groupBox1;
    }
}

