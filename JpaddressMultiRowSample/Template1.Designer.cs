namespace JpaddressMultiRowSample
{          
    [System.ComponentModel.ToolboxItem(true)]
    partial class Template1
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region MultiRow Template Designer generated code

		/// <summary> 
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
        private void InitializeComponent()
        {
            GrapeCity.Win.MultiRow.CellStyle cellStyle1 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.CellStyle cellStyle2 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border1 = new GrapeCity.Win.MultiRow.Border();
            GrapeCity.Win.MultiRow.CellStyle cellStyle3 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border2 = new GrapeCity.Win.MultiRow.Border();
            GrapeCity.Win.MultiRow.CellStyle cellStyle4 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border3 = new GrapeCity.Win.MultiRow.Border();
            GrapeCity.Win.MultiRow.CellStyle cellStyle5 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border4 = new GrapeCity.Win.MultiRow.Border();
            this.columnHeaderSection1 = new GrapeCity.Win.MultiRow.ColumnHeaderSection();
            this.columnHeaderCell1 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell2 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell3 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell4 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.cornerHeaderCell1 = new GrapeCity.Win.MultiRow.CornerHeaderCell();
            this.textBoxCell3 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.rowHeaderCell1 = new GrapeCity.Win.MultiRow.RowHeaderCell();
            this.gcPostalCell1 = new GrapeCity.Win.MultiRow.InputMan.GcPostalCell(false);
            this.gcBarCodeCell1 = new GrapeCity.Win.MultiRow.PlusPak.GcBarCodeCell();
            this.textBoxCell1 = new GrapeCity.Win.MultiRow.TextBoxCell();
            // 
            // Row
            // 
            this.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Row.Cells.Add(this.gcPostalCell1);
            this.Row.Cells.Add(this.textBoxCell1);
            this.Row.Cells.Add(this.textBoxCell3);
            this.Row.Cells.Add(this.gcBarCodeCell1);
            this.Row.Cells.Add(this.rowHeaderCell1);
            this.Row.Height = 21;
            this.Row.Width = 601;
            // 
            // columnHeaderSection1
            // 
            this.columnHeaderSection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell1);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell2);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell3);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell4);
            this.columnHeaderSection1.Cells.Add(this.cornerHeaderCell1);
            this.columnHeaderSection1.Height = 21;
            this.columnHeaderSection1.Name = "columnHeaderSection1";
            this.columnHeaderSection1.Width = 601;
            // 
            // columnHeaderCell1
            // 
            this.columnHeaderCell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell1.Location = new System.Drawing.Point(40, 0);
            this.columnHeaderCell1.Name = "columnHeaderCell1";
            this.columnHeaderCell1.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell1.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell1.TabIndex = 0;
            this.columnHeaderCell1.Value = "郵便番号";
            // 
            // columnHeaderCell2
            // 
            this.columnHeaderCell2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell2.Location = new System.Drawing.Point(120, 0);
            this.columnHeaderCell2.Name = "columnHeaderCell2";
            this.columnHeaderCell2.Size = new System.Drawing.Size(172, 21);
            this.columnHeaderCell2.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell2.TabIndex = 1;
            this.columnHeaderCell2.Value = "住所1";
            // 
            // columnHeaderCell3
            // 
            this.columnHeaderCell3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell3.Location = new System.Drawing.Point(292, 0);
            this.columnHeaderCell3.Name = "columnHeaderCell3";
            this.columnHeaderCell3.Size = new System.Drawing.Size(175, 21);
            this.columnHeaderCell3.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell3.TabIndex = 2;
            this.columnHeaderCell3.Value = "住所カナ";
            // 
            // columnHeaderCell4
            // 
            this.columnHeaderCell4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell4.Location = new System.Drawing.Point(467, 0);
            this.columnHeaderCell4.Name = "columnHeaderCell4";
            this.columnHeaderCell4.Size = new System.Drawing.Size(134, 21);
            this.columnHeaderCell4.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell4.TabIndex = 3;
            this.columnHeaderCell4.Value = "郵便バーコード";
            // 
            // cornerHeaderCell1
            // 
            this.cornerHeaderCell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cornerHeaderCell1.Location = new System.Drawing.Point(0, 0);
            this.cornerHeaderCell1.Name = "cornerHeaderCell1";
            this.cornerHeaderCell1.Size = new System.Drawing.Size(40, 21);
            this.cornerHeaderCell1.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.cornerHeaderCell1.TabIndex = 4;
            // 
            // textBoxCell3
            // 
            this.textBoxCell3.DataField = "address_kana";
            this.textBoxCell3.Location = new System.Drawing.Point(292, 0);
            this.textBoxCell3.Name = "textBoxCell3";
            this.textBoxCell3.Size = new System.Drawing.Size(175, 21);
            this.textBoxCell3.TabIndex = 2;
            // 
            // rowHeaderCell1
            // 
            this.rowHeaderCell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rowHeaderCell1.Location = new System.Drawing.Point(0, 0);
            this.rowHeaderCell1.Name = "rowHeaderCell1";
            this.rowHeaderCell1.Size = new System.Drawing.Size(40, 21);
            this.rowHeaderCell1.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.rowHeaderCell1.TabIndex = 4;
            // 
            // gcPostalCell1
            // 
            this.gcPostalCell1.AddressKanaOutputCellName = "textBoxCell3";
            this.gcPostalCell1.AddressOutputCellName = "textBoxCell1";
            this.gcPostalCell1.DataField = "postal";
            this.gcPostalCell1.Fields.ZipCodeSeparator.Text = "-";
            this.gcPostalCell1.Location = new System.Drawing.Point(40, 0);
            this.gcPostalCell1.Name = "gcPostalCell1";
            this.gcPostalCell1.ShortcutKeys.AddRange(new GrapeCity.Win.MultiRow.InputMan.ShortcutDictionaryEntry[] {
            new GrapeCity.Win.MultiRow.InputMan.ShortcutDictionaryEntry(System.Windows.Forms.Keys.F2, "ShortcutClear"),
            new GrapeCity.Win.MultiRow.InputMan.ShortcutDictionaryEntry(((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return))), "ApplyRecommendedValue")});
            this.gcPostalCell1.TabIndex = 0;
            // 
            // gcBarCodeCell1
            // 
            this.gcBarCodeCell1.DataField = "postal";
            this.gcBarCodeCell1.Location = new System.Drawing.Point(467, 0);
            this.gcBarCodeCell1.Name = "gcBarCodeCell1";
            this.gcBarCodeCell1.ReadOnly = false;
            this.gcBarCodeCell1.Size = new System.Drawing.Size(134, 21);
            this.gcBarCodeCell1.Style = cellStyle1;
            this.gcBarCodeCell1.TabIndex = 3;
            this.gcBarCodeCell1.Type = GrapeCity.Win.BarCode.ValueType.BarType.JapanesePostal;
            // 
            // textBoxCell1
            // 
            this.textBoxCell1.DataField = "address1";
            this.textBoxCell1.Location = new System.Drawing.Point(120, 0);
            this.textBoxCell1.Name = "textBoxCell1";
            this.textBoxCell1.Size = new System.Drawing.Size(172, 21);
            this.textBoxCell1.TabIndex = 1;
            // 
            // Template1
            // 
            this.AlternatingRowsDefaultCellStyle = new GrapeCity.Win.MultiRow.NamedCellStyle("AlternatingRowsDefaultCellStyle1");
            this.ColumnHeaders.AddRange(new GrapeCity.Win.MultiRow.ColumnHeaderSection[] {
            this.columnHeaderSection1});
            cellStyle2.BackColor = System.Drawing.SystemColors.Control;
            cellStyle2.BackgroundGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle2.Border = border1;
            cellStyle2.DisabledBackColor = System.Drawing.SystemColors.Control;
            cellStyle2.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            cellStyle2.DisabledGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            cellStyle2.Format = "";
            cellStyle2.GradientDirection = GrapeCity.Win.MultiRow.GradientDirection.Center;
            cellStyle2.GradientStyle = GrapeCity.Win.MultiRow.GradientStyle.None;
            cellStyle2.ImageAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter;
            cellStyle2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cellStyle2.ImeSentenceMode = GrapeCity.Win.MultiRow.ImeSentenceMode.NoControl;
            cellStyle2.InputScope = GrapeCity.Win.MultiRow.InputScopeNameValue.Default;
            cellStyle2.LineAdjustment = GrapeCity.Win.MultiRow.LineAdjustment.None;
            cellStyle2.Margin = new System.Windows.Forms.Padding(0);
            cellStyle2.MouseOverGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle2.Multiline = GrapeCity.Win.MultiRow.MultiRowTriState.True;
            cellStyle2.Padding = new System.Windows.Forms.Padding(0);
            cellStyle2.PatternColor = System.Drawing.SystemColors.WindowText;
            cellStyle2.PatternStyle = GrapeCity.Win.MultiRow.MultiRowHatchStyle.None;
            cellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            cellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            cellStyle2.SelectionGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle2.TextAdjustment = GrapeCity.Win.MultiRow.TextAdjustment.Near;
            cellStyle2.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter;
            cellStyle2.TextAngle = 0F;
            cellStyle2.TextEffect = GrapeCity.Win.MultiRow.TextEffect.Flat;
            cellStyle2.TextImageRelation = GrapeCity.Win.MultiRow.MultiRowTextImageRelation.Overlay;
            cellStyle2.TextIndent = 0;
            cellStyle2.TextVertical = GrapeCity.Win.MultiRow.MultiRowTriState.False;
            cellStyle2.UseCompatibleTextRendering = GrapeCity.Win.MultiRow.MultiRowTriState.False;
            cellStyle2.WordWrap = GrapeCity.Win.MultiRow.MultiRowTriState.True;
            this.ColumnHeadersDefaultHeaderCellStyle = cellStyle2;
            this.Height = 42;
            cellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            border2.Outline = new GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))));
            cellStyle3.Border = border2;
            cellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            cellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            border3.Outline = new GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.White);
            cellStyle4.Border = border3;
            cellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            cellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            border4.Outline = new GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.White);
            cellStyle5.Border = border4;
            cellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NamedCellStyles.AddRange(new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry[] {
            new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry("HeaderCellStyle1", cellStyle3),
            new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry("RowsDefaultCellStyle1", cellStyle4),
            new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry("AlternatingRowsDefaultCellStyle1", cellStyle5)});
            this.RowsDefaultCellStyle = new GrapeCity.Win.MultiRow.NamedCellStyle("RowsDefaultCellStyle1");
            this.Width = 601;

        }
        

        #endregion

        private GrapeCity.Win.MultiRow.ColumnHeaderSection columnHeaderSection1;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell1;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell2;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell3;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell4;
        private GrapeCity.Win.MultiRow.CornerHeaderCell cornerHeaderCell1;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell3;
        private GrapeCity.Win.MultiRow.RowHeaderCell rowHeaderCell1;
        private GrapeCity.Win.MultiRow.InputMan.GcPostalCell gcPostalCell1;
        private GrapeCity.Win.MultiRow.PlusPak.GcBarCodeCell gcBarCodeCell1;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell1;
    }
}
