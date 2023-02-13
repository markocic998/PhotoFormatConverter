namespace PhotoFormatConverter
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NewPhotoLabel = new System.Windows.Forms.Label();
            this.OriginalPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.NewPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.OriginalPhotoLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.NewPhotoLabel, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.OriginalPhotoPictureBox, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.NewPhotoPictureBox, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.OriginalPhotoLabel, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660377F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.33963F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(1382, 685);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // NewPhotoLabel
            // 
            this.NewPhotoLabel.AutoSize = true;
            this.NewPhotoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewPhotoLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPhotoLabel.Location = new System.Drawing.Point(694, 0);
            this.NewPhotoLabel.Name = "NewPhotoLabel";
            this.NewPhotoLabel.Size = new System.Drawing.Size(157, 38);
            this.NewPhotoLabel.TabIndex = 3;
            this.NewPhotoLabel.Text = "New Image";
            // 
            // OriginalPhotoPictureBox
            // 
            this.OriginalPhotoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPhotoPictureBox.Location = new System.Drawing.Point(3, 41);
            this.OriginalPhotoPictureBox.Name = "OriginalPhotoPictureBox";
            this.OriginalPhotoPictureBox.Size = new System.Drawing.Size(685, 641);
            this.OriginalPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalPhotoPictureBox.TabIndex = 0;
            this.OriginalPhotoPictureBox.TabStop = false;
            // 
            // NewPhotoPictureBox
            // 
            this.NewPhotoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewPhotoPictureBox.Location = new System.Drawing.Point(694, 41);
            this.NewPhotoPictureBox.Name = "NewPhotoPictureBox";
            this.NewPhotoPictureBox.Size = new System.Drawing.Size(685, 641);
            this.NewPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewPhotoPictureBox.TabIndex = 1;
            this.NewPhotoPictureBox.TabStop = false;
            // 
            // OriginalPhotoLabel
            // 
            this.OriginalPhotoLabel.AutoSize = true;
            this.OriginalPhotoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OriginalPhotoLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OriginalPhotoLabel.Location = new System.Drawing.Point(3, 0);
            this.OriginalPhotoLabel.Name = "OriginalPhotoLabel";
            this.OriginalPhotoLabel.Size = new System.Drawing.Size(199, 38);
            this.OriginalPhotoLabel.TabIndex = 2;
            this.OriginalPhotoLabel.Text = "Original Image";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 685);
            this.Controls.Add(this.TableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultForm";
            this.Text = "Conversion Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Label NewPhotoLabel;
        private PictureBox OriginalPhotoPictureBox;
        private PictureBox NewPhotoPictureBox;
        private Label OriginalPhotoLabel;
    }
}