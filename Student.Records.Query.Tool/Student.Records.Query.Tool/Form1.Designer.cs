namespace Student.Records.Query.Tool
{
    partial class Form1
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
            studentList = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            totalCountLabel = new MaterialSkin.Controls.MaterialLabel();
            totalCount = new MaterialSkin.Controls.MaterialLabel();
            searchMode = new MaterialSkin.Controls.MaterialComboBox();
            averageGpa = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            resetSearch = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // studentList
            // 
            studentList.AutoSizeTable = false;
            studentList.BackColor = Color.FromArgb(255, 255, 255);
            studentList.BorderStyle = BorderStyle.None;
            studentList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            studentList.Depth = 0;
            studentList.FullRowSelect = true;
            studentList.Location = new Point(3, 121);
            studentList.MinimumSize = new Size(200, 100);
            studentList.MouseLocation = new Point(-1, -1);
            studentList.MouseState = MaterialSkin.MouseState.OUT;
            studentList.Name = "studentList";
            studentList.OwnerDraw = true;
            studentList.Size = new Size(794, 281);
            studentList.TabIndex = 0;
            studentList.UseCompatibleStateImageBehavior = false;
            studentList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Firstname";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Lastname";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "GPA";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Program";
            columnHeader5.Width = 350;
            // 
            // searchButton
            // 
            searchButton.AutoSize = false;
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchButton.Depth = 0;
            searchButton.HighEmphasis = true;
            searchButton.Icon = null;
            searchButton.Location = new Point(673, 70);
            searchButton.Margin = new Padding(4, 6, 4, 6);
            searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchButton.Name = "searchButton";
            searchButton.NoAccentTextColor = Color.Empty;
            searchButton.Padding = new Padding(20, 10, 20, 10);
            searchButton.Size = new Size(120, 40);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchButton.UseAccentColor = false;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.CharacterCasing = CharacterCasing.Normal;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.HideSelection = true;
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(150, 67);
            searchTextBox.MaxLength = 32767;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            searchTextBox.PrefixSuffixText = "Search student by Id, Programs etc";
            searchTextBox.ReadOnly = false;
            searchTextBox.RightToLeft = RightToLeft.No;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.ShortcutsEnabled = true;
            searchTextBox.Size = new Size(516, 48);
            searchTextBox.TabIndex = 1;
            searchTextBox.TabStop = false;
            searchTextBox.TextAlign = HorizontalAlignment.Left;
            searchTextBox.TrailingIcon = null;
            searchTextBox.UseSystemPasswordChar = false;
            // 
            // totalCountLabel
            // 
            totalCountLabel.AutoSize = true;
            totalCountLabel.Depth = 0;
            totalCountLabel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalCountLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            totalCountLabel.Location = new Point(22, 419);
            totalCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            totalCountLabel.Name = "totalCountLabel";
            totalCountLabel.Size = new Size(102, 19);
            totalCountLabel.TabIndex = 3;
            totalCountLabel.Text = "Total count    :";
            // 
            // totalCount
            // 
            totalCount.AutoSize = true;
            totalCount.Depth = 0;
            totalCount.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            totalCount.Location = new Point(150, 419);
            totalCount.MouseState = MaterialSkin.MouseState.HOVER;
            totalCount.Name = "totalCount";
            totalCount.Size = new Size(10, 19);
            totalCount.TabIndex = 4;
            totalCount.Text = "0";
            // 
            // searchMode
            // 
            searchMode.AutoResize = false;
            searchMode.BackColor = Color.FromArgb(255, 255, 255);
            searchMode.Depth = 0;
            searchMode.DrawMode = DrawMode.OwnerDrawVariable;
            searchMode.DropDownHeight = 174;
            searchMode.DropDownStyle = ComboBoxStyle.DropDownList;
            searchMode.DropDownWidth = 121;
            searchMode.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            searchMode.ForeColor = Color.FromArgb(222, 0, 0, 0);
            searchMode.FormattingEnabled = true;
            searchMode.Hint = "Search mode";
            searchMode.IntegralHeight = false;
            searchMode.ItemHeight = 43;
            searchMode.Items.AddRange(new object[] { "By program", "By gpa", "By id", "Sort by" });
            searchMode.Location = new Point(3, 66);
            searchMode.MaxDropDownItems = 4;
            searchMode.MouseState = MaterialSkin.MouseState.OUT;
            searchMode.Name = "searchMode";
            searchMode.Size = new Size(141, 49);
            searchMode.StartIndex = 0;
            searchMode.TabIndex = 5;
            // 
            // averageGpa
            // 
            averageGpa.AutoSize = true;
            averageGpa.Depth = 0;
            averageGpa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            averageGpa.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            averageGpa.Location = new Point(385, 419);
            averageGpa.MouseState = MaterialSkin.MouseState.HOVER;
            averageGpa.Name = "averageGpa";
            averageGpa.Size = new Size(10, 19);
            averageGpa.TabIndex = 7;
            averageGpa.Text = "0";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel2.Location = new Point(257, 419);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(109, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "Average gpa    :";
            // 
            // resetSearch
            // 
            resetSearch.AutoSize = false;
            resetSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resetSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            resetSearch.Depth = 0;
            resetSearch.HighEmphasis = true;
            resetSearch.Icon = null;
            resetSearch.Location = new Point(643, 408);
            resetSearch.Margin = new Padding(4, 6, 4, 6);
            resetSearch.MouseState = MaterialSkin.MouseState.HOVER;
            resetSearch.Name = "resetSearch";
            resetSearch.NoAccentTextColor = Color.Empty;
            resetSearch.Padding = new Padding(20, 10, 20, 10);
            resetSearch.Size = new Size(150, 38);
            resetSearch.TabIndex = 8;
            resetSearch.Text = "Reset search";
            resetSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            resetSearch.UseAccentColor = false;
            resetSearch.UseVisualStyleBackColor = true;
            resetSearch.Click += resetSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetSearch);
            Controls.Add(averageGpa);
            Controls.Add(materialLabel2);
            Controls.Add(searchMode);
            Controls.Add(totalCount);
            Controls.Add(totalCountLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(studentList);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lookup student information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView studentList;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialTextBox2 searchTextBox;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel totalCountLabel;
        private MaterialSkin.Controls.MaterialLabel totalCount;
        private MaterialSkin.Controls.MaterialComboBox searchMode;
        private MaterialSkin.Controls.MaterialLabel averageGpa;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton resetSearch;
    }
}
