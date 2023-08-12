<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EasyRead
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbChoMag = New System.Windows.Forms.ComboBox()
        Me.rdoOutGau = New System.Windows.Forms.RadioButton()
        Me.rdoInsGau = New System.Windows.Forms.RadioButton()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblChooseMag = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextMag = New System.Windows.Forms.TextBox()
        Me.txtTotPri = New System.Windows.Forms.TextBox()
        Me.txtDel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblTotPri = New System.Windows.Forms.Label()
        Me.lblDel = New System.Windows.Forms.Label()
        Me.lblPri = New System.Windows.Forms.Label()
        Me.lblMag = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EASY READ"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbChoMag)
        Me.Panel1.Controls.Add(Me.rdoOutGau)
        Me.Panel1.Controls.Add(Me.rdoInsGau)
        Me.Panel1.Controls.Add(Me.lblDestination)
        Me.Panel1.Controls.Add(Me.lblChooseMag)
        Me.Panel1.Location = New System.Drawing.Point(40, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 101)
        Me.Panel1.TabIndex = 1
        '
        'cmbChoMag
        '
        Me.cmbChoMag.FormattingEnabled = True
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextMag)
        Me.Panel2.Controls.Add(Me.txtTotPri)
        Me.Panel2.Controls.Add(Me.txtDel)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.lblTotPri)
        Me.Panel2.Controls.Add(Me.lblDel)
        Me.Panel2.Controls.Add(Me.lblPri)
        Me.Panel2.Controls.Add(Me.lblMag)
        Me.Panel2.Location = New System.Drawing.Point(40, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 119)
        Me.Panel2.TabIndex = 2
        '
        'TextMag
        '
        Me.TextMag.Location = New System.Drawing.Point(122, 15)
        Me.TextMag.Name = "TextMag"
        Me.TextMag.Size = New System.Drawing.Size(130, 20)
        Me.TextMag.TabIndex = 8
        '
        'txtTotPri
        '
        Me.txtTotPri.Location = New System.Drawing.Point(350, 76)
        Me.txtTotPri.Name = "txtTotPri"
        Me.txtTotPri.Size = New System.Drawing.Size(149, 20)
        Me.txtTotPri.TabIndex = 7
        '
        'txtDel
        '
        Me.txtDel.Location = New System.Drawing.Point(350, 47)
        Me.txtDel.Name = "txtDel"
        Me.txtDel.Size = New System.Drawing.Size(149, 20)
        Me.txtDel.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(350, 16)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(149, 20)
        Me.txtPrice.TabIndex = 5
        '
        'lblTotPri
        '
        Me.lblTotPri.AutoSize = True
        Me.lblTotPri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotPri.Location = New System.Drawing.Point(250, 74)
        Me.lblTotPri.Name = "lblTotPri"
        Me.lblTotPri.Size = New System.Drawing.Size(94, 20)
        Me.lblTotPri.TabIndex = 4
        Me.lblTotPri.Text = "Total Price"
        '
        'lblDel
        '
        Me.lblDel.AutoSize = True
        Me.lblDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDel.Location = New System.Drawing.Point(272, 45)
        Me.lblDel.Name = "lblDel"
        Me.lblDel.Size = New System.Drawing.Size(72, 20)
        Me.lblDel.TabIndex = 3
        Me.lblDel.Text = "Delivery"
        '
        'lblPri
        '
        Me.lblPri.AutoSize = True
        Me.lblPri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPri.Location = New System.Drawing.Point(281, 16)
        Me.lblPri.Name = "lblPri"
        Me.lblPri.Size = New System.Drawing.Size(49, 20)
        Me.lblPri.TabIndex = 2
        Me.lblPri.Text = "Price"
        '
        'lblMag
        '
        Me.lblMag.AutoSize = True
        Me.lblMag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMag.Location = New System.Drawing.Point(16, 11)
        Me.lblMag.Name = "lblMag"
        Me.lblMag.Size = New System.Drawing.Size(100, 24)
        Me.lblMag.TabIndex = 0
        Me.lblMag.Text = "Magazine"
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(40, 356)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(118, 36)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(252, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 37)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(435, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 37)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(576, 98)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(330, 238)
        Me.ListBox1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ISD_L2_TASK_4_MEMO.My.Resources.Resources.ISD_COUCH
        Me.PictureBox1.Location = New System.Drawing.Point(134, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ISD_L2_TASK_4_MEMO.My.Resources.Resources.ISD_COUCH
        Me.PictureBox2.Location = New System.Drawing.Point(699, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'EasyRead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 459)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EasyRead"
        Me.Text = "01753723543243"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbChoMag As System.Windows.Forms.ComboBox
    Friend WithEvents rdoOutGau As System.Windows.Forms.RadioButton
    Friend WithEvents rdoInsGau As System.Windows.Forms.RadioButton
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents lblChooseMag As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTotPri As System.Windows.Forms.TextBox
    Friend WithEvents txtDel As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblTotPri As System.Windows.Forms.Label
    Friend WithEvents lblDel As System.Windows.Forms.Label
    Friend WithEvents lblPri As System.Windows.Forms.Label
    Friend WithEvents lblMag As System.Windows.Forms.Label
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents TextMag As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
