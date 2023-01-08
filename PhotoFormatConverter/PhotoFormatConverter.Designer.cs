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
            this.bmpRadioButton = new System.Windows.Forms.RadioButton();
            this.jpgRadioButton = new System.Windows.Forms.RadioButton();
            this.outputImageFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.qualityGroupBox = new System.Windows.Forms.GroupBox();
            this.highQualityRadioButton = new System.Windows.Forms.RadioButton();
            this.normalQualityRadioButton = new System.Windows.Forms.RadioButton();
            this.lowQualityRadioButton = new System.Windows.Forms.RadioButton();
            this.outputImageFormatGroupBox.SuspendLayout();
            this.qualityGroupBox.SuspendLayout();
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
            this.SelectedFilesOrFolderText.Text = "There are no selected files yet.";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFileButton.Location = new System.Drawing.Point(1106, 159);
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
            this.FolderBrowserButton.Location = new System.Drawing.Point(1106, 215);
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
            this.ChooseResolutionComboBox.Location = new System.Drawing.Point(100, 281);
            this.ChooseResolutionComboBox.Name = "ChooseResolutionComboBox";
            this.ChooseResolutionComboBox.Size = new System.Drawing.Size(1000, 39);
            this.ChooseResolutionComboBox.TabIndex = 3;
            // 
            // bmpRadioButton
            // 
            this.bmpRadioButton.AutoSize = true;
            this.bmpRadioButton.Checked = true;
            this.bmpRadioButton.Location = new System.Drawing.Point(6, 33);
            this.bmpRadioButton.Name = "bmpRadioButton";
            this.bmpRadioButton.Size = new System.Drawing.Size(73, 32);
            this.bmpRadioButton.TabIndex = 4;
            this.bmpRadioButton.TabStop = true;
            this.bmpRadioButton.Text = "BMP";
            this.bmpRadioButton.UseVisualStyleBackColor = true;
            // 
            // jpgRadioButton
            // 
            this.jpgRadioButton.AutoSize = true;
            this.jpgRadioButton.Location = new System.Drawing.Point(6, 71);
            this.jpgRadioButton.Name = "jpgRadioButton";
            this.jpgRadioButton.Size = new System.Drawing.Size(65, 32);
            this.jpgRadioButton.TabIndex = 5;
            this.jpgRadioButton.Text = "JPG";
            this.jpgRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputImageFormatGroupBox
            // 
            this.outputImageFormatGroupBox.Controls.Add(this.bmpRadioButton);
            this.outputImageFormatGroupBox.Controls.Add(this.jpgRadioButton);
            this.outputImageFormatGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputImageFormatGroupBox.Location = new System.Drawing.Point(593, 349);
            this.outputImageFormatGroupBox.Name = "outputImageFormatGroupBox";
            this.outputImageFormatGroupBox.Size = new System.Drawing.Size(303, 151);
            this.outputImageFormatGroupBox.TabIndex = 5;
            this.outputImageFormatGroupBox.TabStop = false;
            this.outputImageFormatGroupBox.Text = "Choose output image format";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertButton.Location = new System.Drawing.Point(986, 349);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(307, 151);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(986, 508);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(307, 33);
            this.progressBar.TabIndex = 7;
            // 
            // qualityGroupBox
            // 
            this.qualityGroupBox.Controls.Add(this.highQualityRadioButton);
            this.qualityGroupBox.Controls.Add(this.normalQualityRadioButton);
            this.qualityGroupBox.Controls.Add(this.lowQualityRadioButton);
            this.qualityGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qualityGroupBox.Location = new System.Drawing.Point(100, 349);
            this.qualityGroupBox.Name = "qualityGroupBox";
            this.qualityGroupBox.Size = new System.Drawing.Size(303, 151);
            this.qualityGroupBox.TabIndex = 4;
            this.qualityGroupBox.TabStop = false;
            this.qualityGroupBox.Text = "Choose quality conversion";
            // 
            // highQualityRadioButton
            // 
            this.highQualityRadioButton.AutoSize = true;
            this.highQualityRadioButton.Location = new System.Drawing.Point(6, 109);
            this.highQualityRadioButton.Name = "highQualityRadioButton";
            this.highQualityRadioButton.Size = new System.Drawing.Size(143, 32);
            this.highQualityRadioButton.TabIndex = 2;
            this.highQualityRadioButton.Text = "High Quality";
            this.highQualityRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalQualityRadioButton
            // 
            this.normalQualityRadioButton.AutoSize = true;
            this.normalQualityRadioButton.Checked = true;
            this.normalQualityRadioButton.Location = new System.Drawing.Point(6, 71);
            this.normalQualityRadioButton.Name = "normalQualityRadioButton";
            this.normalQualityRadioButton.Size = new System.Drawing.Size(167, 32);
            this.normalQualityRadioButton.TabIndex = 1;
            this.normalQualityRadioButton.TabStop = true;
            this.normalQualityRadioButton.Text = "Normal Quality";
            this.normalQualityRadioButton.UseVisualStyleBackColor = true;
            // 
            // lowQualityRadioButton
            // 
            this.lowQualityRadioButton.AutoSize = true;
            this.lowQualityRadioButton.Location = new System.Drawing.Point(6, 33);
            this.lowQualityRadioButton.Name = "lowQualityRadioButton";
            this.lowQualityRadioButton.Size = new System.Drawing.Size(136, 32);
            this.lowQualityRadioButton.TabIndex = 0;
            this.lowQualityRadioButton.Text = "Low Quality";
            this.lowQualityRadioButton.UseVisualStyleBackColor = true;
            // 
            // PhotoFormatConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 553);
            this.Controls.Add(this.qualityGroupBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputImageFormatGroupBox);
            this.Controls.Add(this.ChooseResolutionComboBox);
            this.Controls.Add(this.FolderBrowserButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.SelectedFilesOrFolderText);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PhotoFormatConverter";
            this.Text = "Photo Format Converter";
            this.outputImageFormatGroupBox.ResumeLayout(false);
            this.outputImageFormatGroupBox.PerformLayout();
            this.qualityGroupBox.ResumeLayout(false);
            this.qualityGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SelectedFilesOrFolderText;
        private Button OpenFileButton;
        private Button FolderBrowserButton;
        private ComboBox ChooseResolutionComboBox;
        private RadioButton bmpRadioButton;
        private RadioButton jpgRadioButton;
        private GroupBox outputImageFormatGroupBox;
        private Button convertButton;
        private ProgressBar progressBar;
        private Label progressBarLabel;
        private GroupBox qualityGroupBox;
        private RadioButton highQualityRadioButton;
        private RadioButton normalQualityRadioButton;
        private RadioButton lowQualityRadioButton;
    }
}