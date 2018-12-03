<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVistra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFrista = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblcom1 = New System.Windows.Forms.Label()
        Me.lblcom2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Vistra Gluta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Frista Glota"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVistra
        '
        Me.txtVistra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtVistra.Location = New System.Drawing.Point(259, 119)
        Me.txtVistra.Multiline = True
        Me.txtVistra.Name = "txtVistra"
        Me.txtVistra.Size = New System.Drawing.Size(119, 35)
        Me.txtVistra.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ยอดขาย"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFrista
        '
        Me.txtFrista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtFrista.Location = New System.Drawing.Point(259, 192)
        Me.txtFrista.Multiline = True
        Me.txtFrista.Name = "txtFrista"
        Me.txtFrista.Size = New System.Drawing.Size(119, 35)
        Me.txtFrista.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(433, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ค่าคอมมิชชัน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(353, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 35)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ยอดขายรวม"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(433, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 35)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ค่าคอมมิชชันรวม"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(353, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblcom1
        '
        Me.lblcom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblcom1.Location = New System.Drawing.Point(437, 122)
        Me.lblcom1.Name = "lblcom1"
        Me.lblcom1.Size = New System.Drawing.Size(114, 32)
        Me.lblcom1.TabIndex = 4
        '
        'lblcom2
        '
        Me.lblcom2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblcom2.Location = New System.Drawing.Point(438, 192)
        Me.lblcom2.Name = "lblcom2"
        Me.lblcom2.Size = New System.Drawing.Size(114, 32)
        Me.lblcom2.TabIndex = 4
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(256, 408)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(114, 32)
        Me.lbl3.TabIndex = 4
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(438, 408)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(114, 32)
        Me.lbl4.TabIndex = 4
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 548)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lblcom2)
        Me.Controls.Add(Me.lblcom1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFrista)
        Me.Controls.Add(Me.txtVistra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVistra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFrista As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblcom1 As System.Windows.Forms.Label
    Friend WithEvents lblcom2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label

End Class
