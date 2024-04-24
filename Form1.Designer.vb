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
        Label1 = New Label()
        Label2 = New Label()
        TxtBox = New TextBox()
        TxtNumber = New TextBox()
        BtProcess = New Button()
        ListView1 = New ListView()
        BtnClear = New Button()
        BtnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 20)
        Label1.TabIndex = 0
        Label1.Text = "Text"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 20)
        Label2.TabIndex = 1
        Label2.Text = "Repeat of"
        ' 
        ' TxtBox
        ' 
        TxtBox.Location = New Point(139, 23)
        TxtBox.Name = "TxtBox"
        TxtBox.Size = New Size(439, 27)
        TxtBox.TabIndex = 2
        ' 
        ' TxtNumber
        ' 
        TxtNumber.Location = New Point(139, 73)
        TxtNumber.Name = "TxtNumber"
        TxtNumber.Size = New Size(439, 27)
        TxtNumber.TabIndex = 3
        ' 
        ' BtProcess
        ' 
        BtProcess.Enabled = False
        BtProcess.Location = New Point(31, 123)
        BtProcess.Name = "BtProcess"
        BtProcess.Size = New Size(547, 29)
        BtProcess.TabIndex = 4
        BtProcess.Text = "Process"
        BtProcess.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(31, 171)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(547, 267)
        ListView1.TabIndex = 5
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' BtnClear
        ' 
        BtnClear.Enabled = False
        BtnClear.Location = New Point(31, 458)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(269, 29)
        BtnClear.TabIndex = 6
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(306, 458)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(272, 29)
        BtnExit.TabIndex = 7
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(616, 511)
        Controls.Add(BtnExit)
        Controls.Add(BtnClear)
        Controls.Add(ListView1)
        Controls.Add(BtProcess)
        Controls.Add(TxtNumber)
        Controls.Add(TxtBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        Text = "Program Perulangan Text"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBox As TextBox
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents BtProcess As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button

End Class
