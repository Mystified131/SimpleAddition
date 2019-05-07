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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "+"
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSum.Location = New System.Drawing.Point(348, 258)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 35)
        Me.btnSum.TabIndex = 5
        Me.btnSum.Text = "="
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(525, 262)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(100, 26)
        Me.txtSum.TabIndex = 6
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(102, 152)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(100, 26)
        Me.txtAdd1.TabIndex = 7
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(395, 152)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(100, 26)
        Me.txtAdd2.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtAdd2)
        Me.Controls.Add(Me.txtAdd1)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Simple Addition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSum As Button
    Friend WithEvents txtSum As TextBox
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents txtAdd2 As TextBox
End Class
