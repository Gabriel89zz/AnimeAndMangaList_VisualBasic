<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnime))
        btnLoadDataAnime = New Button()
        Label9 = New Label()
        txtReviewAnime = New TextBox()
        lstvDataAnime = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        btnGetStatsAnime = New Button()
        btnDeleteAnime = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        nudRatingAnime = New NumericUpDown()
        cbPlataform = New ComboBox()
        txtChaptersAnime = New TextBox()
        dtpDateAnime = New DateTimePicker()
        cbGenreAnime = New ComboBox()
        txtAuthorAnime = New TextBox()
        txtProductionStudio = New TextBox()
        txtTitleAnime = New TextBox()
        btnSaveAnime = New Button()
        btnExportAnime = New Button()
        SaveReviewAnime = New Button()
        btnSimilarAnimes = New Button()
        CType(nudRatingAnime, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLoadDataAnime
        ' 
        btnLoadDataAnime.BackColor = SystemColors.ActiveCaptionText
        btnLoadDataAnime.Cursor = Cursors.Hand
        btnLoadDataAnime.FlatAppearance.BorderSize = 0
        btnLoadDataAnime.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLoadDataAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnLoadDataAnime.FlatStyle = FlatStyle.Flat
        btnLoadDataAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnLoadDataAnime.ForeColor = SystemColors.ControlLightLight
        btnLoadDataAnime.Location = New Point(27, 13)
        btnLoadDataAnime.Margin = New Padding(4)
        btnLoadDataAnime.Name = "btnLoadDataAnime"
        btnLoadDataAnime.Size = New Size(96, 44)
        btnLoadDataAnime.TabIndex = 47
        btnLoadDataAnime.Text = "Load Data"
        btnLoadDataAnime.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(31, 333)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 19)
        Label9.TabIndex = 46
        Label9.Text = "Add Review"
        ' 
        ' txtReviewAnime
        ' 
        txtReviewAnime.Font = New Font("Microsoft Tai Le", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReviewAnime.Location = New Point(23, 360)
        txtReviewAnime.Margin = New Padding(4)
        txtReviewAnime.Multiline = True
        txtReviewAnime.Name = "txtReviewAnime"
        txtReviewAnime.Size = New Size(317, 188)
        txtReviewAnime.TabIndex = 45
        txtReviewAnime.Text = "Title of Anime:" & vbCrLf & vbCrLf & "Review:"
        ' 
        ' lstvDataAnime
        ' 
        lstvDataAnime.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        lstvDataAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstvDataAnime.FullRowSelect = True
        lstvDataAnime.Location = New Point(355, 296)
        lstvDataAnime.Margin = New Padding(4)
        lstvDataAnime.Name = "lstvDataAnime"
        lstvDataAnime.Size = New Size(856, 267)
        lstvDataAnime.TabIndex = 44
        lstvDataAnime.UseCompatibleStateImageBehavior = False
        lstvDataAnime.View = View.Details
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
        ColumnHeader5.Text = "Number of Chapters"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Platform"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Production Studio"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Rating"
        ' 
        ' btnGetStatsAnime
        ' 
        btnGetStatsAnime.BackColor = SystemColors.ActiveCaptionText
        btnGetStatsAnime.Cursor = Cursors.Hand
        btnGetStatsAnime.FlatAppearance.BorderSize = 0
        btnGetStatsAnime.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnGetStatsAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnGetStatsAnime.FlatStyle = FlatStyle.Flat
        btnGetStatsAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnGetStatsAnime.ForeColor = SystemColors.ControlLightLight
        btnGetStatsAnime.Location = New Point(1073, 147)
        btnGetStatsAnime.Margin = New Padding(4)
        btnGetStatsAnime.Name = "btnGetStatsAnime"
        btnGetStatsAnime.Size = New Size(105, 38)
        btnGetStatsAnime.TabIndex = 43
        btnGetStatsAnime.Text = "Get Cost"
        btnGetStatsAnime.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteAnime
        ' 
        btnDeleteAnime.BackColor = SystemColors.ActiveCaptionText
        btnDeleteAnime.Cursor = Cursors.Hand
        btnDeleteAnime.FlatAppearance.BorderSize = 0
        btnDeleteAnime.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnDeleteAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnDeleteAnime.FlatStyle = FlatStyle.Flat
        btnDeleteAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnDeleteAnime.ForeColor = SystemColors.ControlLightLight
        btnDeleteAnime.Location = New Point(1073, 83)
        btnDeleteAnime.Margin = New Padding(4)
        btnDeleteAnime.Name = "btnDeleteAnime"
        btnDeleteAnime.Size = New Size(105, 38)
        btnDeleteAnime.TabIndex = 42
        btnDeleteAnime.Text = "Delete"
        btnDeleteAnime.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label5.Location = New Point(600, 243)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 19)
        Label5.TabIndex = 41
        Label5.Text = "Rating:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label6.Location = New Point(600, 187)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 19)
        Label6.TabIndex = 40
        Label6.Text = "Production Studio:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label7.Location = New Point(600, 131)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 19)
        Label7.TabIndex = 39
        Label7.Text = "Platform:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label8.Location = New Point(600, 75)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(156, 19)
        Label8.TabIndex = 38
        Label8.Text = "Number of Chapters:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label3.Location = New Point(38, 244)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 19)
        Label3.TabIndex = 37
        Label3.Text = "Date viewed:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label4.Location = New Point(38, 189)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 19)
        Label4.TabIndex = 36
        Label4.Text = "Genre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label2.Location = New Point(38, 134)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 19)
        Label2.TabIndex = 35
        Label2.Text = "Author:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Bold)
        Label1.Location = New Point(38, 79)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 19)
        Label1.TabIndex = 34
        Label1.Text = "Title:"
        ' 
        ' nudRatingAnime
        ' 
        nudRatingAnime.Font = New Font("Microsoft Tai Le", 11F)
        nudRatingAnime.Location = New Point(762, 234)
        nudRatingAnime.Margin = New Padding(4)
        nudRatingAnime.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudRatingAnime.Name = "nudRatingAnime"
        nudRatingAnime.Size = New Size(49, 26)
        nudRatingAnime.TabIndex = 33
        ' 
        ' cbPlataform
        ' 
        cbPlataform.Font = New Font("Microsoft Tai Le", 11F)
        cbPlataform.FormattingEnabled = True
        cbPlataform.Items.AddRange(New Object() {"Crunchyroll", "Netflix", "Disney Plus", "Prime Video"})
        cbPlataform.Location = New Point(762, 125)
        cbPlataform.Margin = New Padding(4)
        cbPlataform.Name = "cbPlataform"
        cbPlataform.Size = New Size(135, 27)
        cbPlataform.TabIndex = 32
        ' 
        ' txtChaptersAnime
        ' 
        txtChaptersAnime.Font = New Font("Microsoft Tai Le", 11F)
        txtChaptersAnime.Location = New Point(762, 71)
        txtChaptersAnime.Margin = New Padding(4)
        txtChaptersAnime.Name = "txtChaptersAnime"
        txtChaptersAnime.Size = New Size(135, 26)
        txtChaptersAnime.TabIndex = 31
        ' 
        ' dtpDateAnime
        ' 
        dtpDateAnime.Font = New Font("Microsoft Tai Le", 11F)
        dtpDateAnime.Format = DateTimePickerFormat.Short
        dtpDateAnime.Location = New Point(230, 238)
        dtpDateAnime.Margin = New Padding(4)
        dtpDateAnime.Name = "dtpDateAnime"
        dtpDateAnime.Size = New Size(154, 26)
        dtpDateAnime.TabIndex = 30
        ' 
        ' cbGenreAnime
        ' 
        cbGenreAnime.Font = New Font("Microsoft Tai Le", 11F)
        cbGenreAnime.FormattingEnabled = True
        cbGenreAnime.Location = New Point(230, 183)
        cbGenreAnime.Margin = New Padding(4)
        cbGenreAnime.Name = "cbGenreAnime"
        cbGenreAnime.Size = New Size(154, 27)
        cbGenreAnime.TabIndex = 29
        ' 
        ' txtAuthorAnime
        ' 
        txtAuthorAnime.Font = New Font("Microsoft Tai Le", 11F)
        txtAuthorAnime.Location = New Point(230, 129)
        txtAuthorAnime.Margin = New Padding(4)
        txtAuthorAnime.Name = "txtAuthorAnime"
        txtAuthorAnime.Size = New Size(318, 26)
        txtAuthorAnime.TabIndex = 28
        ' 
        ' txtProductionStudio
        ' 
        txtProductionStudio.Font = New Font("Microsoft Tai Le", 11F)
        txtProductionStudio.Location = New Point(762, 180)
        txtProductionStudio.Margin = New Padding(4)
        txtProductionStudio.Name = "txtProductionStudio"
        txtProductionStudio.Size = New Size(235, 26)
        txtProductionStudio.TabIndex = 27
        ' 
        ' txtTitleAnime
        ' 
        txtTitleAnime.Font = New Font("Microsoft Tai Le", 11F)
        txtTitleAnime.Location = New Point(230, 75)
        txtTitleAnime.Margin = New Padding(4)
        txtTitleAnime.Name = "txtTitleAnime"
        txtTitleAnime.Size = New Size(318, 26)
        txtTitleAnime.TabIndex = 26
        ' 
        ' btnSaveAnime
        ' 
        btnSaveAnime.BackColor = SystemColors.ActiveCaptionText
        btnSaveAnime.Cursor = Cursors.Hand
        btnSaveAnime.FlatAppearance.BorderSize = 0
        btnSaveAnime.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSaveAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnSaveAnime.FlatStyle = FlatStyle.Flat
        btnSaveAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnSaveAnime.ForeColor = SystemColors.ControlLightLight
        btnSaveAnime.Location = New Point(1073, 19)
        btnSaveAnime.Margin = New Padding(4)
        btnSaveAnime.Name = "btnSaveAnime"
        btnSaveAnime.Size = New Size(105, 38)
        btnSaveAnime.TabIndex = 25
        btnSaveAnime.Text = "Save"
        btnSaveAnime.UseVisualStyleBackColor = False
        ' 
        ' btnExportAnime
        ' 
        btnExportAnime.BackColor = SystemColors.ActiveCaptionText
        btnExportAnime.Cursor = Cursors.Hand
        btnExportAnime.FlatAppearance.BorderSize = 0
        btnExportAnime.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExportAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnExportAnime.FlatStyle = FlatStyle.Flat
        btnExportAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnExportAnime.ForeColor = SystemColors.ControlLightLight
        btnExportAnime.Location = New Point(1106, 577)
        btnExportAnime.Margin = New Padding(4)
        btnExportAnime.Name = "btnExportAnime"
        btnExportAnime.Size = New Size(96, 29)
        btnExportAnime.TabIndex = 49
        btnExportAnime.Text = "Export To"
        btnExportAnime.UseVisualStyleBackColor = False
        ' 
        ' SaveReviewAnime
        ' 
        SaveReviewAnime.BackColor = SystemColors.ActiveCaptionText
        SaveReviewAnime.Cursor = Cursors.Hand
        SaveReviewAnime.FlatAppearance.BorderSize = 0
        SaveReviewAnime.FlatAppearance.MouseDownBackColor = Color.Transparent
        SaveReviewAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        SaveReviewAnime.FlatStyle = FlatStyle.Flat
        SaveReviewAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        SaveReviewAnime.ForeColor = SystemColors.ControlLightLight
        SaveReviewAnime.Location = New Point(27, 567)
        SaveReviewAnime.Margin = New Padding(4)
        SaveReviewAnime.Name = "SaveReviewAnime"
        SaveReviewAnime.Size = New Size(96, 29)
        SaveReviewAnime.TabIndex = 48
        SaveReviewAnime.Text = "Save"
        SaveReviewAnime.UseVisualStyleBackColor = False
        ' 
        ' btnSimilarAnimes
        ' 
        btnSimilarAnimes.BackColor = SystemColors.ActiveCaptionText
        btnSimilarAnimes.Cursor = Cursors.Hand
        btnSimilarAnimes.FlatAppearance.BorderSize = 0
        btnSimilarAnimes.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSimilarAnimes.FlatAppearance.MouseOverBackColor = Color.DarkOrchid
        btnSimilarAnimes.FlatStyle = FlatStyle.Flat
        btnSimilarAnimes.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnSimilarAnimes.ForeColor = SystemColors.ControlLightLight
        btnSimilarAnimes.Location = New Point(1073, 211)
        btnSimilarAnimes.Margin = New Padding(4)
        btnSimilarAnimes.Name = "btnSimilarAnimes"
        btnSimilarAnimes.Size = New Size(105, 51)
        btnSimilarAnimes.TabIndex = 50
        btnSimilarAnimes.Text = "Similar Animes"
        btnSimilarAnimes.UseVisualStyleBackColor = False
        ' 
        ' FrmAnime
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1233, 619)
        Controls.Add(btnSimilarAnimes)
        Controls.Add(btnExportAnime)
        Controls.Add(SaveReviewAnime)
        Controls.Add(btnLoadDataAnime)
        Controls.Add(Label9)
        Controls.Add(txtReviewAnime)
        Controls.Add(lstvDataAnime)
        Controls.Add(btnGetStatsAnime)
        Controls.Add(btnDeleteAnime)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(nudRatingAnime)
        Controls.Add(cbPlataform)
        Controls.Add(txtChaptersAnime)
        Controls.Add(dtpDateAnime)
        Controls.Add(cbGenreAnime)
        Controls.Add(txtAuthorAnime)
        Controls.Add(txtProductionStudio)
        Controls.Add(txtTitleAnime)
        Controls.Add(btnSaveAnime)
        Font = New Font("Segoe UI", 9F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmAnime"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmAnime"
        CType(nudRatingAnime, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLoadDataAnime As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReviewAnime As TextBox
    Friend WithEvents lstvDataAnime As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnGetStatsAnime As Button
    Friend WithEvents btnDeleteAnime As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudRatingAnime As NumericUpDown
    Friend WithEvents cbPlataform As ComboBox
    Friend WithEvents txtChaptersAnime As TextBox
    Friend WithEvents dtpDateAnime As DateTimePicker
    Friend WithEvents cbGenreAnime As ComboBox
    Friend WithEvents txtAuthorAnime As TextBox
    Friend WithEvents txtProductionStudio As TextBox
    Friend WithEvents txtTitleAnime As TextBox
    Friend WithEvents btnSaveAnime As Button
    Friend WithEvents btnExportAnime As Button
    Friend WithEvents SaveReviewAnime As Button
    Friend WithEvents btnSimilarAnimes As Button
End Class
