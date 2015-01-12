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
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(156,Byte),Integer), CType(CType(18,Byte),Integer))
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(330, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 100, 3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 862)
        Me.Panel1.TabIndex = 28
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboBox3.FormattingEnabled = true
        Me.ComboBox3.Location = New System.Drawing.Point(449, 302)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox3.TabIndex = 35
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboBox2.FormattingEnabled = true
        Me.ComboBox2.Location = New System.Drawing.Point(312, 302)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox2.TabIndex = 34
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(312, 213)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(258, 50)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = false
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(312, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 32)
        Me.ComboBox1.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(194, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 35)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Application Form"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(64, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Card Scheme"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "ATM Card No."
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.FormValidation.My.Resources.Resources.nextButton
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(156,Byte),Integer), CType(CType(18,Byte),Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(156,Byte),Integer), CType(CType(18,Byte),Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.Location = New System.Drawing.Point(247, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 47)
        Me.Button3.TabIndex = 22
        Me.Button3.UseVisualStyleBackColor = false
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox4.Location = New System.Drawing.Point(312, 148)
        Me.TextBox4.Multiline = true
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(258, 30)
        Me.TextBox4.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.Location = New System.Drawing.Point(64, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 24)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Expiry Date"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(23,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1345, 836)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
