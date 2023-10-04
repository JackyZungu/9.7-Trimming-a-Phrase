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
        btnTrimm = New Button()
        lbTrim = New Label()
        SuspendLayout()
        ' 
        ' btnTrimm
        ' 
        btnTrimm.Location = New Point(234, 147)
        btnTrimm.Name = "btnTrimm"
        btnTrimm.Size = New Size(94, 70)
        btnTrimm.TabIndex = 0
        btnTrimm.Text = "Trimm"
        btnTrimm.UseVisualStyleBackColor = True
        ' 
        ' lbTrim
        ' 
        lbTrim.AutoSize = True
        lbTrim.Location = New Point(243, 83)
        lbTrim.Name = "lbTrim"
        lbTrim.Size = New Size(115, 20)
        lbTrim.TabIndex = 1
        lbTrim.Text = "Trimmed Phrase"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbTrim)
        Controls.Add(btnTrimm)
        Name = "Form1"
        Text = "Trimming a Phrase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTrimm As Button
    Friend WithEvents lbTrim As Label
End Class
