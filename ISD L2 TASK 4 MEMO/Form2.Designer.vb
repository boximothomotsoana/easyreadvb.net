<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbChoMag = New System.Windows.Forms.ComboBox()
        Me.rdoOutGau = New System.Windows.Forms.RadioButton()
        Me.rdoInsGau = New System.Windows.Forms.RadioButton()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblChooseMag = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbChoMag)
        Me.Panel1.Controls.Add(Me.rdoOutGau)
        Me.Panel1.Controls.Add(Me.rdoInsGau)
        Me.Panel1.Controls.Add(Me.lblDestination)
        Me.Panel1.Controls.Add(Me.lblChooseMag)
        Me.Panel1.Location = New System.Drawing.Point(21, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 101)
        Me.Panel1.TabIndex = 2
        '
        'cmbChoMag
        '
        Me.cmbChoMag.FormattingEnabled = True
        Me.cmbChoMag.Items.AddRange(New Object() {"Huisgennot", "You", "Drum"})
        Me.cmbChoMag.Location = New System.Drawing.Point(262, 18)
        Me.cmbChoMag.Name = "cmbChoMag"
        Me.cmbChoMag.Size = New System.Drawing.Size(237, 21)
        Me.cmbChoMag.TabIndex = 4
        '
        'rdoOutGau
        '
        Me.rdoOutGau.AutoSize = True
        Me.rdoOutGau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoOutGau.Location = New System.Drawing.Point(262, 76)
        Me.rdoOutGau.Name = "rdoOutGau"
        Me.rdoOutGau.Size = New System.Drawing.Size(160, 24)
        Me.rdoOutGau.TabIndex = 3
        Me.rdoOutGau.TabStop = True
        Me.rdoOutGau.Text = "Outside gauteng"
        Me.rdoOutGau.UseVisualStyleBackColor = True
        '
        'rdoInsGau
        '
        Me.rdoInsGau.AutoSize = True
        Me.rdoInsGau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInsGau.Location = New System.Drawing.Point(262, 52)
        Me.rdoInsGau.Name = "rdoInsGau"
        Me.rdoInsGau.Size = New System.Drawing.Size(151, 24)
        Me.rdoInsGau.TabIndex = 2
        Me.rdoInsGau.TabStop = True
        Me.rdoInsGau.Text = "Inside Gauteng"
        Me.rdoInsGau.UseVisualStyleBackColor = True
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(16, 52)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(194, 24)
        Me.lblDestination.TabIndex = 1
        Me.lblDestination.Text = "Delivery Destination"
        '
        'lblChooseMag
        '
        Me.lblChooseMag.AutoSize = True
        Me.lblChooseMag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseMag.Location = New System.Drawing.Point(16, 18)
        Me.lblChooseMag.Name = "lblChooseMag"
        Me.lblChooseMag.Size = New System.Drawing.Size(178, 24)
        Me.lblChooseMag.TabIndex = 0
        Me.lblChooseMag.Text = "Choose Magazine"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(53, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbChoMag As System.Windows.Forms.ComboBox
    Friend WithEvents rdoOutGau As System.Windows.Forms.RadioButton
    Friend WithEvents rdoInsGau As System.Windows.Forms.RadioButton
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents lblChooseMag As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
