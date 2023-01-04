﻿namespace PhotoFormatConverter
{
    partial class PhotoFormatConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedFilesOrFolderText = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FolderBrowserButton = new System.Windows.Forms.Button();
            this.ChooseResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectedFilesOrFolderText
            // 
            this.SelectedFilesOrFolderText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedFilesOrFolderText.Location = new System.Drawing.Point(100, 65);
            this.SelectedFilesOrFolderText.Multiline = true;
            this.SelectedFilesOrFolderText.Name = "SelectedFilesOrFolderText";
            this.SelectedFilesOrFolderText.ReadOnly = true;
            this.SelectedFilesOrFolderText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SelectedFilesOrFolderText.Size = new System.Drawing.Size(1000, 200);
            this.SelectedFilesOrFolderText.TabIndex = 0;
            this.SelectedFilesOrFolderText.Text = "There are no files or folder selected yet.";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFileButton.Location = new System.Drawing.Point(100, 271);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(187, 50);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Select Files";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FolderBrowserButton
            // 
            this.FolderBrowserButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FolderBrowserButton.Location = new System.Drawing.Point(913, 271);
            this.FolderBrowserButton.Name = "FolderBrowserButton";
            this.FolderBrowserButton.Size = new System.Drawing.Size(187, 50);
            this.FolderBrowserButton.TabIndex = 2;
            this.FolderBrowserButton.Text = "Open Folder";
            this.FolderBrowserButton.UseVisualStyleBackColor = true;
            this.FolderBrowserButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
            // 
            // ChooseResolutionComboBox
            // 
            this.ChooseResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseResolutionComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseResolutionComboBox.FormattingEnabled = true;
            this.ChooseResolutionComboBox.Items.AddRange(new object[] {
            "720 x 480   DVD NTSC",
            "720 X 576   DVD PAL",
            "800 x 600",
            "1024 x 768",
            "1280 x 720   HD READY",
            "1280 x 768",
            "1280 x 800",
            "1280 x 960",
            "1280 x 1024  Super-eXtended Graphics Array (SXGA)",
            "1366 x 768   High Definition (HD)",
            "1600 x 900   High Definition Plus (HD+)",
            "1920 x 1080  Full High Definition (FHD)",
            "1920 x 1200  Wide Ultra Extended Graphics Array (WUXGA)",
            "2560 x 1440  Quad High Definition (QHD)",
            "3440 x 1440  Wide Quad High Definition (WQHD)",
            "3840 x 2160  4K or Ultra High Definition (UHD)"});
            this.ChooseResolutionComboBox.Location = new System.Drawing.Point(100, 327);
            this.ChooseResolutionComboBox.Name = "ChooseResolutionComboBox";
            this.ChooseResolutionComboBox.Size = new System.Drawing.Size(1000, 39);
            this.ChooseResolutionComboBox.TabIndex = 3;
            this.ChooseResolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseResolutionComboBox_SelectedIndexChanged);
            // 
            // PhotoFormatConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.ChooseResolutionComboBox);
            this.Controls.Add(this.FolderBrowserButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.SelectedFilesOrFolderText);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PhotoFormatConverter";
            this.Text = "Photo Format Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SelectedFilesOrFolderText;
        private Button OpenFileButton;
        private Button FolderBrowserButton;
        private ComboBox ChooseResolutionComboBox;
    }
}