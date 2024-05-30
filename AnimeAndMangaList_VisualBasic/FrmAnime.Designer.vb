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
        CType(nudRatingAnime, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLoadDataAnime
        ' 
        btnLoadDataAnime.BackColor = SystemColors.ActiveCaptionText
        btnLoadDataAnime.FlatAppearance.BorderSize = 0
        btnLoadDataAnime.FlatAppearance.MouseDownBackColor = Color.DarkOrchid
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
        txtReviewAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReviewAnime.Location = New Point(17, 356)
        txtReviewAnime.Margin = New Padding(4)
        txtReviewAnime.Multiline = True
        txtReviewAnime.Name = "txtReviewAnime"
        txtReviewAnime.Size = New Size(294, 216)
        txtReviewAnime.TabIndex = 45
        txtReviewAnime.Text = "Title of Anime:" & vbCrLf & vbCrLf & "Review:"
        ' 
        ' lstvDataAnime
        ' 
        lstvDataAnime.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        lstvDataAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstvDataAnime.FullRowSelect = True
        lstvDataAnime.Location = New Point(348, 311)
        lstvDataAnime.Margin = New Padding(4)
        lstvDataAnime.Name = "lstvDataAnime"
        lstvDataAnime.Size = New Size(847, 281)
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
        btnGetStatsAnime.FlatAppearance.BorderSize = 0
        btnGetStatsAnime.FlatAppearance.MouseDownBackColor = Color.DarkOrchid
        btnGetStatsAnime.FlatStyle = FlatStyle.Flat
        btnGetStatsAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnGetStatsAnime.ForeColor = SystemColors.ControlLightLight
        btnGetStatsAnime.Location = New Point(1050, 223)
        btnGetStatsAnime.Margin = New Padding(4)
        btnGetStatsAnime.Name = "btnGetStatsAnime"
        btnGetStatsAnime.Size = New Size(105, 58)
        btnGetStatsAnime.TabIndex = 43
        btnGetStatsAnime.Text = "Get Cost"
        btnGetStatsAnime.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteAnime
        ' 
        btnDeleteAnime.BackColor = SystemColors.ActiveCaptionText
        btnDeleteAnime.FlatAppearance.BorderSize = 0
        btnDeleteAnime.FlatAppearance.MouseDownBackColor = Color.DarkOrchid
        btnDeleteAnime.FlatStyle = FlatStyle.Flat
        btnDeleteAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnDeleteAnime.ForeColor = SystemColors.ControlLightLight
        btnDeleteAnime.Location = New Point(1050, 139)
        btnDeleteAnime.Margin = New Padding(4)
        btnDeleteAnime.Name = "btnDeleteAnime"
        btnDeleteAnime.Size = New Size(105, 58)
        btnDeleteAnime.TabIndex = 42
        btnDeleteAnime.Text = "Delete"
        btnDeleteAnime.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label5.Location = New Point(582, 262)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 19)
        Label5.TabIndex = 41
        Label5.Text = "Rating"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label6.Location = New Point(582, 208)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 19)
        Label6.TabIndex = 40
        Label6.Text = "Production Studio:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label7.Location = New Point(582, 143)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 19)
        Label7.TabIndex = 39
        Label7.Text = "Platform:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label8.Location = New Point(582, 89)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(156, 19)
        Label8.TabIndex = 38
        Label8.Text = "Number of Chapters:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(37, 266)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 19)
        Label3.TabIndex = 37
        Label3.Text = "Date viewed:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label4.Location = New Point(37, 212)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 19)
        Label4.TabIndex = 36
        Label4.Text = "Genre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(37, 147)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 19)
        Label2.TabIndex = 35
        Label2.Text = "Author:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(37, 93)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 19)
        Label1.TabIndex = 34
        Label1.Text = "Title:"
        ' 
        ' nudRatingAnime
        ' 
        nudRatingAnime.Font = New Font("Microsoft Tai Le", 11.25F)
        nudRatingAnime.Location = New Point(666, 254)
        nudRatingAnime.Margin = New Padding(4)
        nudRatingAnime.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudRatingAnime.Name = "nudRatingAnime"
        nudRatingAnime.Size = New Size(49, 27)
        nudRatingAnime.TabIndex = 33
        ' 
        ' cbPlataform
        ' 
        cbPlataform.Font = New Font("Microsoft Tai Le", 11.25F)
        cbPlataform.FormattingEnabled = True
        cbPlataform.Items.AddRange(New Object() {"Crunchyroll", "Netflix", "Disney Plus", "Prime Video"})
        cbPlataform.Location = New Point(666, 139)
        cbPlataform.Margin = New Padding(4)
        cbPlataform.Name = "cbPlataform"
        cbPlataform.Size = New Size(154, 27)
        cbPlataform.TabIndex = 32
        ' 
        ' txtChaptersAnime
        ' 
        txtChaptersAnime.Font = New Font("Microsoft Tai Le", 11.25F)
        txtChaptersAnime.Location = New Point(746, 86)
        txtChaptersAnime.Margin = New Padding(4)
        txtChaptersAnime.Name = "txtChaptersAnime"
        txtChaptersAnime.Size = New Size(113, 27)
        txtChaptersAnime.TabIndex = 31
        ' 
        ' dtpDateAnime
        ' 
        dtpDateAnime.Font = New Font("Microsoft Tai Le", 11.25F)
        dtpDateAnime.Format = DateTimePickerFormat.Short
        dtpDateAnime.Location = New Point(229, 259)
        dtpDateAnime.Margin = New Padding(4)
        dtpDateAnime.Name = "dtpDateAnime"
        dtpDateAnime.Size = New Size(154, 27)
        dtpDateAnime.TabIndex = 30
        ' 
        ' cbGenreAnime
        ' 
        cbGenreAnime.Font = New Font("Microsoft Tai Le", 11.25F)
        cbGenreAnime.FormattingEnabled = True
        cbGenreAnime.Location = New Point(229, 202)
        cbGenreAnime.Margin = New Padding(4)
        cbGenreAnime.Name = "cbGenreAnime"
        cbGenreAnime.Size = New Size(154, 27)
        cbGenreAnime.TabIndex = 29
        ' 
        ' txtAuthorAnime
        ' 
        txtAuthorAnime.Font = New Font("Microsoft Tai Le", 11.25F)
        txtAuthorAnime.Location = New Point(229, 143)
        txtAuthorAnime.Margin = New Padding(4)
        txtAuthorAnime.Name = "txtAuthorAnime"
        txtAuthorAnime.Size = New Size(318, 27)
        txtAuthorAnime.TabIndex = 28
        ' 
        ' txtProductionStudio
        ' 
        txtProductionStudio.Font = New Font("Microsoft Tai Le", 11.25F)
        txtProductionStudio.Location = New Point(729, 202)
        txtProductionStudio.Margin = New Padding(4)
        txtProductionStudio.Name = "txtProductionStudio"
        txtProductionStudio.Size = New Size(261, 27)
        txtProductionStudio.TabIndex = 27
        ' 
        ' txtTitleAnime
        ' 
        txtTitleAnime.Font = New Font("Microsoft Tai Le", 11.25F)
        txtTitleAnime.Location = New Point(229, 89)
        txtTitleAnime.Margin = New Padding(4)
        txtTitleAnime.Name = "txtTitleAnime"
        txtTitleAnime.Size = New Size(318, 27)
        txtTitleAnime.TabIndex = 26
        ' 
        ' btnSaveAnime
        ' 
        btnSaveAnime.BackColor = SystemColors.ActiveCaptionText
        btnSaveAnime.FlatAppearance.BorderSize = 0
        btnSaveAnime.FlatAppearance.MouseDownBackColor = Color.DarkOrchid
        btnSaveAnime.FlatStyle = FlatStyle.Flat
        btnSaveAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnSaveAnime.ForeColor = SystemColors.ControlLightLight
        btnSaveAnime.Location = New Point(1050, 58)
        btnSaveAnime.Margin = New Padding(4)
        btnSaveAnime.Name = "btnSaveAnime"
        btnSaveAnime.Size = New Size(105, 58)
        btnSaveAnime.TabIndex = 25
        btnSaveAnime.Text = "Save"
        btnSaveAnime.UseVisualStyleBackColor = False
        ' 
        ' btnExportAnime
        ' 
        btnExportAnime.BackColor = SystemColors.ActiveCaptionText
        btnExportAnime.FlatAppearance.BorderSize = 0
        btnExportAnime.FlatAppearance.MouseDownBackColor = Color.DarkOrchid
        btnExportAnime.FlatStyle = FlatStyle.Flat
        btnExportAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        btnExportAnime.ForeColor = SystemColors.ControlLightLight
        btnExportAnime.Location = New Point(1092, 610)
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
        SaveReviewAnime.FlatAppearance.BorderSize = 0
        SaveReviewAnime.FlatAppearance.MouseDownBackColor = Color.DarkOrchid
        SaveReviewAnime.FlatStyle = FlatStyle.Flat
        SaveReviewAnime.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Bold)
        SaveReviewAnime.ForeColor = SystemColors.ControlLightLight
        SaveReviewAnime.Location = New Point(17, 591)
        SaveReviewAnime.Margin = New Padding(4)
        SaveReviewAnime.Name = "SaveReviewAnime"
        SaveReviewAnime.Size = New Size(96, 29)
        SaveReviewAnime.TabIndex = 48
        SaveReviewAnime.Text = "Save"
        SaveReviewAnime.UseVisualStyleBackColor = False
        ' 
        ' FrmAnime
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1204, 646)
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
End Class
