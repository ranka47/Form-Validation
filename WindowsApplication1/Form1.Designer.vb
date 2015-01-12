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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QrCodeWinForm1 = New BarcodeLib.Barcode.WinForms.QRCodeWinForm()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider7 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider8 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider9 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider10 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider11 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Upload Picture"
        '
        'QrCodeWinForm1
        '
        Me.QrCodeWinForm1.BackgroundColor = System.Drawing.Color.White
        Me.QrCodeWinForm1.BottomMargin = 0.0!
        Me.QrCodeWinForm1.Data = "QR Code"
        Me.QrCodeWinForm1.ECI = 3
        Me.QrCodeWinForm1.ECL = BarcodeLib.Barcode.QRCodeErrorCorrectionLevel.L
        Me.QrCodeWinForm1.EnableStructuredAppend = False
        Me.QrCodeWinForm1.Encoding = BarcodeLib.Barcode.QRCodeEncoding.[Auto]
        Me.QrCodeWinForm1.FNC1Mode = BarcodeLib.Barcode.QRCodeFNC1Mode.NotSupported
        Me.QrCodeWinForm1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png
        Me.QrCodeWinForm1.ImageHeight = 0.0!
        Me.QrCodeWinForm1.ImageWidth = 0.0!
        Me.QrCodeWinForm1.LeftMargin = 0.0!
        Me.QrCodeWinForm1.Location = New System.Drawing.Point(358, -114)
        Me.QrCodeWinForm1.ModuleColor = System.Drawing.Color.Black
        Me.QrCodeWinForm1.ModuleSize = 2.0!
        Me.QrCodeWinForm1.Name = "QrCodeWinForm1"
        Me.QrCodeWinForm1.ProcessTilde = True
        Me.QrCodeWinForm1.ResizeImage = False
        Me.QrCodeWinForm1.Resolution = 72
        Me.QrCodeWinForm1.RightMargin = 0.0!
        Me.QrCodeWinForm1.Rotate = BarcodeLib.Barcode.RotateOrientation.BottomFacingDown
        Me.QrCodeWinForm1.Size = New System.Drawing.Size(42, 42)
        Me.QrCodeWinForm1.StructuredAppendCount = 0
        Me.QrCodeWinForm1.StructuredAppendIndex = 0
        Me.QrCodeWinForm1.TabIndex = 25
        Me.QrCodeWinForm1.TopMargin = 0.0!
        Me.QrCodeWinForm1.UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
        Me.QrCodeWinForm1.Version = BarcodeLib.Barcode.QRCodeVersion.V1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(125, 696)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(376, 437)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(194, 29)
        Me.TextBox7.TabIndex = 23
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(312, 393)
        Me.TextBox6.MaxLength = 32728
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(258, 29)
        Me.TextBox6.TabIndex = 21
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(312, 437)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(58, 29)
        Me.TextBox3.TabIndex = 20
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(312, 352)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(258, 32)
        Me.ComboBox3.TabIndex = 19
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(312, 314)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(258, 32)
        Me.ComboBox2.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(312, 271)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 32)
        Me.ComboBox1.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(121, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Institute"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(312, 141)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(258, 29)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(121, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 24)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Contact No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(121, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "City"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "State"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(121, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Country"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(312, 188)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(258, 30)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(312, 93)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 30)
        Me.TextBox2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(121, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Application Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(330, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 100, 3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 862)
        Me.Panel1.TabIndex = 27
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(147, 696)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(423, 72)
        Me.TextBox5.TabIndex = 31
        Me.TextBox5.Text = resources.GetString("TextBox5.Text")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.FormValidation.My.Resources.Resources._5243081_glossy_round_refresh__recycle_button_isolated_over_white_background2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(542, 641)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 30
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(340, 640)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 29)
        Me.TextBox1.TabIndex = 29
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(340, 546)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 78)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(125, 546)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 123)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.FormValidation.My.Resources.Resources.nextButton
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.Location = New System.Drawing.Point(247, 774)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 47)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'ErrorProvider7
        '
        Me.ErrorProvider7.ContainerControl = Me
        '
        'ErrorProvider8
        '
        Me.ErrorProvider8.ContainerControl = Me
        '
        'ErrorProvider9
        '
        Me.ErrorProvider9.ContainerControl = Me
        '
        'ErrorProvider10
        '
        Me.ErrorProvider10.ContainerControl = Me
        '
        'ErrorProvider11
        '
        Me.ErrorProvider11.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1345, 836)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.QrCodeWinForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QrCodeWinForm1 As BarcodeLib.Barcode.WinForms.QRCodeWinForm
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider4 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider5 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider6 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider7 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider8 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider9 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider10 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider11 As System.Windows.Forms.ErrorProvider

End Class
