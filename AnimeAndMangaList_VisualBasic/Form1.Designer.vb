<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnAddManga = New Button()
        btnAddAnime = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddManga
        ' 
        btnAddManga.BackColor = Color.DarkOrchid
        btnAddManga.FlatAppearance.BorderSize = 0
        btnAddManga.FlatAppearance.MouseDownBackColor = Color.Black
        btnAddManga.FlatStyle = FlatStyle.Flat
        btnAddManga.Font = New Font("Microsoft Tai Le", 20.25F, FontStyle.Bold)
        btnAddManga.ForeColor = SystemColors.ControlLightLight
        btnAddManga.Location = New Point(98, 138)
        btnAddManga.Name = "btnAddManga"
        btnAddManga.Size = New Size(262, 105)
        btnAddManga.TabIndex = 0
        btnAddManga.Text = "ADD MANGA"
        btnAddManga.UseVisualStyleBackColor = False
        ' 
        ' btnAddAnime
        ' 
        btnAddAnime.BackColor = Color.DarkOrchid
        btnAddAnime.FlatAppearance.BorderSize = 0
        btnAddAnime.FlatAppearance.MouseDownBackColor = Color.Black
        btnAddAnime.FlatStyle = FlatStyle.Flat
        btnAddAnime.Font = New Font("Microsoft Tai Le", 20.25F, FontStyle.Bold)
        btnAddAnime.ForeColor = SystemColors.ControlLightLight
        btnAddAnime.Location = New Point(422, 138)
        btnAddAnime.Name = "btnAddAnime"
        btnAddAnime.Size = New Size(262, 105)
        btnAddAnime.TabIndex = 1
        btnAddAnime.Text = "ADD ANIME"
        btnAddAnime.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(778, 48)
        Label1.TabIndex = 2
        Label1.Text = "Welcome, what would you like to do?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 275)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(152, 163)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(652, 278)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(152, 172)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnAddAnime)
        Controls.Add(btnAddManga)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddManga As Button
    Friend WithEvents btnAddAnime As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
