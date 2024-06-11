<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManga
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManga))
        btnSaveManga = New Button()
        txtTitle = New TextBox()
        txtPrice = New TextBox()
        txtAuthor = New TextBox()
        cbGenre = New ComboBox()
        dtpDate = New DateTimePicker()
        txtChapters = New TextBox()
        cbEditorial = New ComboBox()
        nudRating = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnDeleteManga = New Button()
        btnGetStatsManga = New Button()
        lstvDataManga = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        txtReviewManga = New TextBox()
        Label9 = New Label()
        SaveReviewManga = New Button()
        btnExportManga = New Button()
        btnLoadData = New Button()
        btnSimilarMangas = New Button()
        CType(nudRating, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSaveManga
        ' 
        btnSaveManga.BackColor = SystemColors.ActiveCaptionText
        btnSaveManga.Cursor = Cursors.Hand
        btnSaveManga.FlatAppearance.BorderSize = 0
        btnSaveManga.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSaveManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnSaveManga.FlatStyle = FlatStyle.Flat
        btnSaveManga.ForeColor = SystemColors.ControlLightLight
        btnSaveManga.Location = New Point(1046, 15)
        btnSaveManga.Margin = New Padding(4)
        btnSaveManga.Name = "btnSaveManga"
        btnSaveManga.Size = New Size(105, 38)
        btnSaveManga.TabIndex = 0
        btnSaveManga.Text = "Save"
        btnSaveManga.UseVisualStyleBackColor = False
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Microsoft Tai Le", 11F)
        txtTitle.Location = New Point(225, 72)
        txtTitle.Margin = New Padding(4)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(312, 26)
        txtTitle.TabIndex = 1
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Microsoft Tai Le", 11.25F)
        txtPrice.Location = New Point(662, 225)
        txtPrice.Margin = New Padding(4)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(318, 27)
        txtPrice.TabIndex = 2
        txtPrice.Visible = False
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Microsoft Tai Le", 11F)
        txtAuthor.Location = New Point(225, 128)
        txtAuthor.Margin = New Padding(4)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(312, 26)
        txtAuthor.TabIndex = 3
        ' 
        ' cbGenre
        ' 
        cbGenre.Font = New Font("Microsoft Tai Le", 11F)
        cbGenre.FormattingEnabled = True
        cbGenre.Items.AddRange(New Object() {"Shonen", "Seinen", "Comedy", "Sci-Fi", "Romcom", "Isekai"})
        cbGenre.Location = New Point(225, 184)
        cbGenre.Margin = New Padding(4)
        cbGenre.Name = "cbGenre"
        cbGenre.Size = New Size(177, 27)
        cbGenre.TabIndex = 4
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Microsoft Tai Le", 11F)
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(225, 241)
        dtpDate.Margin = New Padding(4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(142, 26)
        dtpDate.TabIndex = 5
        ' 
        ' txtChapters
        ' 
        txtChapters.Font = New Font("Microsoft Tai Le", 11F)
        txtChapters.Location = New Point(662, 72)
        txtChapters.Margin = New Padding(4)
        txtChapters.Name = "txtChapters"
        txtChapters.Size = New Size(154, 26)
        txtChapters.TabIndex = 6
        ' 
        ' cbEditorial
        ' 
        cbEditorial.Font = New Font("Microsoft Tai Le", 11F)
        cbEditorial.FormattingEnabled = True
        cbEditorial.Items.AddRange(New Object() {"Panini", "Norma", "Ivrea", "Kamite"})
        cbEditorial.Location = New Point(662, 122)
        cbEditorial.Margin = New Padding(4)
        cbEditorial.Name = "cbEditorial"
        cbEditorial.Size = New Size(154, 27)
        cbEditorial.TabIndex = 7
        ' 
        ' nudRating
        ' 
        nudRating.Font = New Font("Microsoft Tai Le", 11F)
        nudRating.Location = New Point(662, 185)
        nudRating.Margin = New Padding(4)
        nudRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudRating.Name = "nudRating"
        nudRating.Size = New Size(49, 26)
        nudRating.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label1.Location = New Point(33, 76)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 19)
        Label1.TabIndex = 9
        Label1.Text = "Title:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label2.Location = New Point(33, 133)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 19)
        Label2.TabIndex = 10
        Label2.Text = "Author:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label3.Location = New Point(33, 247)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 19)
        Label3.TabIndex = 12
        Label3.Text = "Acqusition Date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label4.Location = New Point(33, 190)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 19)
        Label4.TabIndex = 11
        Label4.Text = "Genre:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label5.Location = New Point(578, 188)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 19)
        Label5.TabIndex = 16
        Label5.Text = "Rating:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(578, 191)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 19)
        Label6.TabIndex = 15
        Label6.Text = "Price:"
        Label6.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label7.Location = New Point(578, 130)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 19)
        Label7.TabIndex = 14
        Label7.Text = "Editorial:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label8.Location = New Point(578, 72)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 19)
        Label8.TabIndex = 13
        Label8.Text = "Volume:"
        ' 
        ' btnDeleteManga
        ' 
        btnDeleteManga.BackColor = SystemColors.ActiveCaptionText
        btnDeleteManga.Cursor = Cursors.Hand
        btnDeleteManga.FlatAppearance.BorderSize = 0
        btnDeleteManga.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnDeleteManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnDeleteManga.FlatStyle = FlatStyle.Flat
        btnDeleteManga.ForeColor = SystemColors.ControlLightLight
        btnDeleteManga.Location = New Point(1046, 81)
        btnDeleteManga.Margin = New Padding(4)
        btnDeleteManga.Name = "btnDeleteManga"
        btnDeleteManga.Size = New Size(105, 38)
        btnDeleteManga.TabIndex = 17
        btnDeleteManga.Text = "Delete"
        btnDeleteManga.UseVisualStyleBackColor = False
        ' 
        ' btnGetStatsManga
        ' 
        btnGetStatsManga.BackColor = SystemColors.ActiveCaptionText
        btnGetStatsManga.Cursor = Cursors.Hand
        btnGetStatsManga.FlatAppearance.BorderSize = 0
        btnGetStatsManga.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnGetStatsManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnGetStatsManga.FlatStyle = FlatStyle.Flat
        btnGetStatsManga.ForeColor = SystemColors.ControlLightLight
        btnGetStatsManga.Location = New Point(1046, 147)
        btnGetStatsManga.Margin = New Padding(4)
        btnGetStatsManga.Name = "btnGetStatsManga"
        btnGetStatsManga.Size = New Size(105, 38)
        btnGetStatsManga.TabIndex = 18
        btnGetStatsManga.Text = "Get Stats"
        btnGetStatsManga.UseVisualStyleBackColor = False
        ' 
        ' lstvDataManga
        ' 
        lstvDataManga.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        lstvDataManga.FullRowSelect = True
        lstvDataManga.Location = New Point(364, 304)
        lstvDataManga.Margin = New Padding(4)
        lstvDataManga.Name = "lstvDataManga"
        lstvDataManga.Size = New Size(856, 267)
        lstvDataManga.TabIndex = 19
        lstvDataManga.UseCompatibleStateImageBehavior = False
        lstvDataManga.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Title"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Author"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Genre"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Date"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Volume"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Editorial"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Rating"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Price"
        ' 
        ' txtReviewManga
        ' 
        txtReviewManga.Font = New Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReviewManga.Location = New Point(28, 373)
        txtReviewManga.Margin = New Padding(4)
        txtReviewManga.Multiline = True
        txtReviewManga.Name = "txtReviewManga"
        txtReviewManga.Size = New Size(317, 188)
        txtReviewManga.TabIndex = 20
        txtReviewManga.Text = "Title of Manga:" & vbCrLf & vbCrLf & "Review:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(32, 350)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 19)
        Label9.TabIndex = 21
        Label9.Text = "Add Review"
        ' 
        ' SaveReviewManga
        ' 
        SaveReviewManga.BackColor = SystemColors.ActiveCaptionText
        SaveReviewManga.Cursor = Cursors.Hand
        SaveReviewManga.FlatAppearance.BorderSize = 0
        SaveReviewManga.FlatAppearance.MouseDownBackColor = Color.Transparent
        SaveReviewManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        SaveReviewManga.FlatStyle = FlatStyle.Flat
        SaveReviewManga.ForeColor = SystemColors.ControlLightLight
        SaveReviewManga.Location = New Point(23, 569)
        SaveReviewManga.Margin = New Padding(4)
        SaveReviewManga.Name = "SaveReviewManga"
        SaveReviewManga.Size = New Size(96, 29)
        SaveReviewManga.TabIndex = 22
        SaveReviewManga.Text = "Save"
        SaveReviewManga.UseVisualStyleBackColor = False
        ' 
        ' btnExportManga
        ' 
        btnExportManga.BackColor = SystemColors.ActiveCaptionText
        btnExportManga.Cursor = Cursors.Hand
        btnExportManga.FlatAppearance.BorderSize = 0
        btnExportManga.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExportManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnExportManga.FlatStyle = FlatStyle.Flat
        btnExportManga.ForeColor = SystemColors.ControlLightLight
        btnExportManga.Location = New Point(1118, 581)
        btnExportManga.Margin = New Padding(4)
        btnExportManga.Name = "btnExportManga"
        btnExportManga.Size = New Size(96, 29)
        btnExportManga.TabIndex = 23
        btnExportManga.Text = "Export To"
        btnExportManga.UseVisualStyleBackColor = False
        ' 
        ' btnLoadData
        ' 
        btnLoadData.BackColor = SystemColors.ActiveCaptionText
        btnLoadData.Cursor = Cursors.Hand
        btnLoadData.FlatAppearance.BorderSize = 0
        btnLoadData.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLoadData.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnLoadData.FlatStyle = FlatStyle.Flat
        btnLoadData.ForeColor = SystemColors.ControlLightLight
        btnLoadData.Location = New Point(23, 15)
        btnLoadData.Margin = New Padding(4)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New Size(96, 44)
        btnLoadData.TabIndex = 24
        btnLoadData.Text = "Load Data"
        btnLoadData.UseVisualStyleBackColor = False
        ' 
        ' btnSimilarMangas
        ' 
        btnSimilarMangas.BackColor = SystemColors.ActiveCaptionText
        btnSimilarMangas.Cursor = Cursors.Hand
        btnSimilarMangas.FlatAppearance.BorderSize = 0
        btnSimilarMangas.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSimilarMangas.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnSimilarMangas.FlatStyle = FlatStyle.Flat
        btnSimilarMangas.ForeColor = SystemColors.ControlLightLight
        btnSimilarMangas.Location = New Point(1046, 213)
        btnSimilarMangas.Margin = New Padding(4)
        btnSimilarMangas.Name = "btnSimilarMangas"
        btnSimilarMangas.Size = New Size(105, 48)
        btnSimilarMangas.TabIndex = 25
        btnSimilarMangas.Text = "Similar Mangas"
        btnSimilarMangas.UseVisualStyleBackColor = False
        ' 
        ' FrmManga
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1233, 619)
        Controls.Add(btnSimilarMangas)
        Controls.Add(btnLoadData)
        Controls.Add(btnExportManga)
        Controls.Add(SaveReviewManga)
        Controls.Add(Label9)
        Controls.Add(txtReviewManga)
        Controls.Add(lstvDataManga)
        Controls.Add(btnGetStatsManga)
        Controls.Add(btnDeleteManga)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(nudRating)
        Controls.Add(cbEditorial)
        Controls.Add(txtChapters)
        Controls.Add(dtpDate)
        Controls.Add(cbGenre)
        Controls.Add(txtAuthor)
        Controls.Add(txtPrice)
        Controls.Add(txtTitle)
        Controls.Add(btnSaveManga)
        Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "FrmManga"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmManga"
        CType(nudRating, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSaveManga As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents cbGenre As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtChapters As TextBox
    Friend WithEvents cbEditorial As ComboBox
    Friend WithEvents nudRating As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDeleteManga As Button
    Friend WithEvents btnGetStatsManga As Button
    Friend WithEvents lstvDataManga As ListView
    Friend WithEvents txtReviewManga As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SaveReviewManga As Button
    Friend WithEvents btnExportManga As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnLoadData As Button
    Friend WithEvents btnSimilarMangas As Button
End Class
