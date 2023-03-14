<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.imgBuilding = New System.Windows.Forms.PictureBox()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.rbtnInToM = New System.Windows.Forms.RadioButton()
        Me.rbtnMToIn = New System.Windows.Forms.RadioButton()
        Me.grpConversion = New System.Windows.Forms.GroupBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.imgBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Ebrima", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(824, 119)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(320, 59)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Converter App"
        '
        'imgBuilding
        '
        Me.imgBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBuilding.Image = CType(resources.GetObject("imgBuilding.Image"), System.Drawing.Image)
        Me.imgBuilding.Location = New System.Drawing.Point(52, 34)
        Me.imgBuilding.Name = "imgBuilding"
        Me.imgBuilding.Size = New System.Drawing.Size(571, 446)
        Me.imgBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBuilding.TabIndex = 1
        Me.imgBuilding.TabStop = False
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(699, 237)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(280, 80)
        Me.lblInstruction.TabIndex = 2
        Me.lblInstruction.Text = "Enter a Value and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Choose Conversion"
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.LightCyan
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(1107, 248)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(160, 49)
        Me.txtValue.TabIndex = 3
        '
        'rbtnInToM
        '
        Me.rbtnInToM.AutoSize = True
        Me.rbtnInToM.Checked = True
        Me.rbtnInToM.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnInToM.Location = New System.Drawing.Point(26, 57)
        Me.rbtnInToM.Name = "rbtnInToM"
        Me.rbtnInToM.Size = New System.Drawing.Size(259, 44)
        Me.rbtnInToM.TabIndex = 4
        Me.rbtnInToM.TabStop = True
        Me.rbtnInToM.Text = "Inches to Meters"
        Me.rbtnInToM.UseVisualStyleBackColor = True
        '
        'rbtnMToIn
        '
        Me.rbtnMToIn.AutoSize = True
        Me.rbtnMToIn.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMToIn.Location = New System.Drawing.Point(26, 107)
        Me.rbtnMToIn.Name = "rbtnMToIn"
        Me.rbtnMToIn.Size = New System.Drawing.Size(259, 44)
        Me.rbtnMToIn.TabIndex = 5
        Me.rbtnMToIn.Text = "Meters to Inches"
        Me.rbtnMToIn.UseVisualStyleBackColor = True
        '
        'grpConversion
        '
        Me.grpConversion.BackColor = System.Drawing.Color.LightCyan
        Me.grpConversion.Controls.Add(Me.rbtnInToM)
        Me.grpConversion.Controls.Add(Me.rbtnMToIn)
        Me.grpConversion.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversion.Location = New System.Drawing.Point(791, 380)
        Me.grpConversion.Name = "grpConversion"
        Me.grpConversion.Size = New System.Drawing.Size(444, 180)
        Me.grpConversion.TabIndex = 6
        Me.grpConversion.TabStop = False
        Me.grpConversion.Text = "Convert Measurement"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Ebrima", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(697, 630)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(145, 50)
        Me.lblResults.TabIndex = 7
        Me.lblResults.Text = "Results"
        Me.lblResults.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.LightCyan
        Me.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnConvert.FlatAppearance.BorderSize = 2
        Me.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnConvert.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(146, 738)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(297, 79)
        Me.btnConvert.TabIndex = 8
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightCyan
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnClear.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(595, 738)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(297, 79)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightCyan
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnExit.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1036, 738)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(297, 79)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1435, 854)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.grpConversion)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.imgBuilding)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.imgBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConversion.ResumeLayout(False)
        Me.grpConversion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents imgBuilding As PictureBox
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents rbtnInToM As RadioButton
    Friend WithEvents rbtnMToIn As RadioButton
    Friend WithEvents grpConversion As GroupBox
    Friend WithEvents lblResults As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
