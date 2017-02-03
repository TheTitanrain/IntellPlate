<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BDownload = New System.Windows.Forms.Button()
        Me.BFlush = New System.Windows.Forms.Button()
        Me.BNext = New System.Windows.Forms.Button()
        Me.cbletter1 = New System.Windows.Forms.CheckBox()
        Me.cbletter2 = New System.Windows.Forms.CheckBox()
        Me.cbletter3 = New System.Windows.Forms.CheckBox()
        Me.cbnumber1 = New System.Windows.Forms.CheckBox()
        Me.cbnumber2 = New System.Windows.Forms.CheckBox()
        Me.cbnumber3 = New System.Windows.Forms.CheckBox()
        Me.cbregion1 = New System.Windows.Forms.CheckBox()
        Me.cbregion2 = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PB2r = New System.Windows.Forms.ProgressBar()
        Me.PB1r = New System.Windows.Forms.ProgressBar()
        Me.PB3l = New System.Windows.Forms.ProgressBar()
        Me.PB2l = New System.Windows.Forms.ProgressBar()
        Me.PB3n = New System.Windows.Forms.ProgressBar()
        Me.PB2n = New System.Windows.Forms.ProgressBar()
        Me.PB1n = New System.Windows.Forms.ProgressBar()
        Me.PB1l = New System.Windows.Forms.ProgressBar()
        Me.NUD2r = New System.Windows.Forms.NumericUpDown()
        Me.NUD1r = New System.Windows.Forms.NumericUpDown()
        Me.NUD3l = New System.Windows.Forms.NumericUpDown()
        Me.NUD2l = New System.Windows.Forms.NumericUpDown()
        Me.NUD3n = New System.Windows.Forms.NumericUpDown()
        Me.NUD2n = New System.Windows.Forms.NumericUpDown()
        Me.NUD1n = New System.Windows.Forms.NumericUpDown()
        Me.NUD1l = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.TBNumber = New System.Windows.Forms.TextBox()
        Me.TBTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUDn = New System.Windows.Forms.NumericUpDown()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBPass = New System.Windows.Forms.TextBox()
        Me.TBUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD2r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD1r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD3l, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD2l, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD3n, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD2n, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD1n, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD1l, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IntellPlate.My.Resources.Resources.trafficcontrol_auto_intellect_small
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(689, 531)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BDownload
        '
        Me.BDownload.Location = New System.Drawing.Point(707, 64)
        Me.BDownload.Name = "BDownload"
        Me.BDownload.Size = New System.Drawing.Size(219, 23)
        Me.BDownload.TabIndex = 2
        Me.BDownload.Text = "Загрузить"
        Me.BDownload.UseVisualStyleBackColor = True
        '
        'BFlush
        '
        Me.BFlush.Location = New System.Drawing.Point(178, 661)
        Me.BFlush.Name = "BFlush"
        Me.BFlush.Size = New System.Drawing.Size(142, 23)
        Me.BFlush.TabIndex = 3
        Me.BFlush.Text = "Сбросить"
        Me.ToolTip1.SetToolTip(Me.BFlush, "Сбрасывает значения уже посчитанных ошибок")
        Me.BFlush.UseVisualStyleBackColor = True
        '
        'BNext
        '
        Me.BNext.Location = New System.Drawing.Point(551, 661)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(150, 23)
        Me.BNext.TabIndex = 4
        Me.BNext.Text = "Следующий >>"
        Me.ToolTip1.SetToolTip(Me.BNext, "Загрузить следующее изображение")
        Me.BNext.UseVisualStyleBackColor = True
        '
        'cbletter1
        '
        Me.cbletter1.AutoSize = True
        Me.cbletter1.Location = New System.Drawing.Point(6, 15)
        Me.cbletter1.Name = "cbletter1"
        Me.cbletter1.Size = New System.Drawing.Size(73, 17)
        Me.cbletter1.TabIndex = 5
        Me.cbletter1.Text = "1-я буква"
        Me.cbletter1.UseVisualStyleBackColor = True
        '
        'cbletter2
        '
        Me.cbletter2.AutoSize = True
        Me.cbletter2.Location = New System.Drawing.Point(329, 15)
        Me.cbletter2.Name = "cbletter2"
        Me.cbletter2.Size = New System.Drawing.Size(73, 17)
        Me.cbletter2.TabIndex = 6
        Me.cbletter2.Text = "2-я буква"
        Me.cbletter2.UseVisualStyleBackColor = True
        '
        'cbletter3
        '
        Me.cbletter3.AutoSize = True
        Me.cbletter3.Location = New System.Drawing.Point(408, 14)
        Me.cbletter3.Name = "cbletter3"
        Me.cbletter3.Size = New System.Drawing.Size(73, 17)
        Me.cbletter3.TabIndex = 7
        Me.cbletter3.Text = "3-я буква"
        Me.cbletter3.UseVisualStyleBackColor = True
        '
        'cbnumber1
        '
        Me.cbnumber1.AutoSize = True
        Me.cbnumber1.Location = New System.Drawing.Point(85, 15)
        Me.cbnumber1.Name = "cbnumber1"
        Me.cbnumber1.Size = New System.Drawing.Size(76, 17)
        Me.cbnumber1.TabIndex = 8
        Me.cbnumber1.Text = "1-я цифра"
        Me.cbnumber1.UseVisualStyleBackColor = True
        '
        'cbnumber2
        '
        Me.cbnumber2.AutoSize = True
        Me.cbnumber2.Location = New System.Drawing.Point(165, 15)
        Me.cbnumber2.Name = "cbnumber2"
        Me.cbnumber2.Size = New System.Drawing.Size(76, 17)
        Me.cbnumber2.TabIndex = 9
        Me.cbnumber2.Text = "2-я цифра"
        Me.cbnumber2.UseVisualStyleBackColor = True
        '
        'cbnumber3
        '
        Me.cbnumber3.AutoSize = True
        Me.cbnumber3.Location = New System.Drawing.Point(247, 15)
        Me.cbnumber3.Name = "cbnumber3"
        Me.cbnumber3.Size = New System.Drawing.Size(76, 17)
        Me.cbnumber3.TabIndex = 10
        Me.cbnumber3.Text = "3-я цифра"
        Me.cbnumber3.UseVisualStyleBackColor = True
        '
        'cbregion1
        '
        Me.cbregion1.AutoSize = True
        Me.cbregion1.Location = New System.Drawing.Point(487, 14)
        Me.cbregion1.Name = "cbregion1"
        Me.cbregion1.Size = New System.Drawing.Size(79, 17)
        Me.cbregion1.TabIndex = 11
        Me.cbregion1.Text = "1-я регион"
        Me.cbregion1.UseVisualStyleBackColor = True
        '
        'cbregion2
        '
        Me.cbregion2.AutoSize = True
        Me.cbregion2.Location = New System.Drawing.Point(572, 15)
        Me.cbregion2.Name = "cbregion2"
        Me.cbregion2.Size = New System.Drawing.Size(79, 17)
        Me.cbregion2.TabIndex = 12
        Me.cbregion2.Text = "2-я регион"
        Me.cbregion2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(707, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(219, 433)
        Me.ListBox1.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(707, 568)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 151)
        Me.TextBox1.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PB2r)
        Me.GroupBox1.Controls.Add(Me.PB1r)
        Me.GroupBox1.Controls.Add(Me.PB3l)
        Me.GroupBox1.Controls.Add(Me.PB2l)
        Me.GroupBox1.Controls.Add(Me.PB3n)
        Me.GroupBox1.Controls.Add(Me.PB2n)
        Me.GroupBox1.Controls.Add(Me.PB1n)
        Me.GroupBox1.Controls.Add(Me.PB1l)
        Me.GroupBox1.Controls.Add(Me.NUD2r)
        Me.GroupBox1.Controls.Add(Me.NUD1r)
        Me.GroupBox1.Controls.Add(Me.NUD3l)
        Me.GroupBox1.Controls.Add(Me.NUD2l)
        Me.GroupBox1.Controls.Add(Me.NUD3n)
        Me.GroupBox1.Controls.Add(Me.NUD2n)
        Me.GroupBox1.Controls.Add(Me.NUD1n)
        Me.GroupBox1.Controls.Add(Me.NUD1l)
        Me.GroupBox1.Controls.Add(Me.cbnumber3)
        Me.GroupBox1.Controls.Add(Me.cbletter1)
        Me.GroupBox1.Controls.Add(Me.cbletter2)
        Me.GroupBox1.Controls.Add(Me.cbregion2)
        Me.GroupBox1.Controls.Add(Me.cbletter3)
        Me.GroupBox1.Controls.Add(Me.cbregion1)
        Me.GroupBox1.Controls.Add(Me.cbnumber1)
        Me.GroupBox1.Controls.Add(Me.cbnumber2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 575)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 80)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ошибки в:"
        '
        'PB2r
        '
        Me.PB2r.Location = New System.Drawing.Point(566, 62)
        Me.PB2r.Name = "PB2r"
        Me.PB2r.Size = New System.Drawing.Size(73, 12)
        Me.PB2r.TabIndex = 47
        '
        'PB1r
        '
        Me.PB1r.Location = New System.Drawing.Point(486, 62)
        Me.PB1r.Name = "PB1r"
        Me.PB1r.Size = New System.Drawing.Size(73, 12)
        Me.PB1r.TabIndex = 46
        '
        'PB3l
        '
        Me.PB3l.Location = New System.Drawing.Point(406, 62)
        Me.PB3l.Name = "PB3l"
        Me.PB3l.Size = New System.Drawing.Size(73, 12)
        Me.PB3l.TabIndex = 45
        '
        'PB2l
        '
        Me.PB2l.Location = New System.Drawing.Point(326, 62)
        Me.PB2l.Name = "PB2l"
        Me.PB2l.Size = New System.Drawing.Size(73, 12)
        Me.PB2l.TabIndex = 44
        '
        'PB3n
        '
        Me.PB3n.Location = New System.Drawing.Point(246, 62)
        Me.PB3n.Name = "PB3n"
        Me.PB3n.Size = New System.Drawing.Size(73, 12)
        Me.PB3n.TabIndex = 43
        '
        'PB2n
        '
        Me.PB2n.Location = New System.Drawing.Point(166, 62)
        Me.PB2n.Name = "PB2n"
        Me.PB2n.Size = New System.Drawing.Size(73, 12)
        Me.PB2n.TabIndex = 42
        '
        'PB1n
        '
        Me.PB1n.Location = New System.Drawing.Point(86, 62)
        Me.PB1n.Name = "PB1n"
        Me.PB1n.Size = New System.Drawing.Size(73, 12)
        Me.PB1n.TabIndex = 41
        '
        'PB1l
        '
        Me.PB1l.Location = New System.Drawing.Point(6, 62)
        Me.PB1l.Name = "PB1l"
        Me.PB1l.Size = New System.Drawing.Size(73, 12)
        Me.PB1l.TabIndex = 40
        '
        'NUD2r
        '
        Me.NUD2r.Location = New System.Drawing.Point(566, 37)
        Me.NUD2r.Name = "NUD2r"
        Me.NUD2r.Size = New System.Drawing.Size(73, 20)
        Me.NUD2r.TabIndex = 20
        '
        'NUD1r
        '
        Me.NUD1r.Location = New System.Drawing.Point(486, 37)
        Me.NUD1r.Name = "NUD1r"
        Me.NUD1r.Size = New System.Drawing.Size(73, 20)
        Me.NUD1r.TabIndex = 19
        '
        'NUD3l
        '
        Me.NUD3l.Location = New System.Drawing.Point(406, 37)
        Me.NUD3l.Name = "NUD3l"
        Me.NUD3l.Size = New System.Drawing.Size(73, 20)
        Me.NUD3l.TabIndex = 18
        '
        'NUD2l
        '
        Me.NUD2l.Location = New System.Drawing.Point(326, 38)
        Me.NUD2l.Name = "NUD2l"
        Me.NUD2l.Size = New System.Drawing.Size(73, 20)
        Me.NUD2l.TabIndex = 17
        '
        'NUD3n
        '
        Me.NUD3n.Location = New System.Drawing.Point(246, 39)
        Me.NUD3n.Name = "NUD3n"
        Me.NUD3n.Size = New System.Drawing.Size(73, 20)
        Me.NUD3n.TabIndex = 16
        '
        'NUD2n
        '
        Me.NUD2n.Location = New System.Drawing.Point(166, 39)
        Me.NUD2n.Name = "NUD2n"
        Me.NUD2n.Size = New System.Drawing.Size(73, 20)
        Me.NUD2n.TabIndex = 15
        '
        'NUD1n
        '
        Me.NUD1n.Location = New System.Drawing.Point(86, 39)
        Me.NUD1n.Name = "NUD1n"
        Me.NUD1n.Size = New System.Drawing.Size(73, 20)
        Me.NUD1n.TabIndex = 14
        '
        'NUD1l
        '
        Me.NUD1l.Location = New System.Drawing.Point(6, 38)
        Me.NUD1l.Name = "NUD1l"
        Me.NUD1l.Size = New System.Drawing.Size(73, 20)
        Me.NUD1l.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(707, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 20)
        Me.DateTimePicker1.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Дата, с которой загружаются машины")
        Me.DateTimePicker1.Value = New Date(2017, 2, 1, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(707, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(219, 20)
        Me.DateTimePicker2.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.DateTimePicker2, "Дата, по которую загружаются машины")
        Me.DateTimePicker2.Value = New Date(2017, 2, 1, 23, 59, 59, 0)
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 300
        '
        'LabelCount
        '
        Me.LabelCount.Location = New System.Drawing.Point(706, 722)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(219, 15)
        Me.LabelCount.TabIndex = 18
        Me.LabelCount.Text = "LabelCount"
        '
        'TBNumber
        '
        Me.TBNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TBNumber.Location = New System.Drawing.Point(295, 549)
        Me.TBNumber.Name = "TBNumber"
        Me.TBNumber.Size = New System.Drawing.Size(119, 26)
        Me.TBNumber.TabIndex = 25
        Me.TBNumber.Text = "К455УТ127"
        Me.TBNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBTime
        '
        Me.TBTime.Location = New System.Drawing.Point(497, 549)
        Me.TBTime.Name = "TBTime"
        Me.TBTime.Size = New System.Drawing.Size(203, 20)
        Me.TBTime.TabIndex = 26
        Me.TBTime.Text = "31.01.2017 14:44:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Время:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(396, 666)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Проверено:"
        '
        'NUDn
        '
        Me.NUDn.Location = New System.Drawing.Point(468, 664)
        Me.NUDn.Name = "NUDn"
        Me.NUDn.Size = New System.Drawing.Size(69, 20)
        Me.NUDn.TabIndex = 29
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(176, 555)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(707, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Список идентификаторов снимков:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(707, 552)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Статистика:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBPass)
        Me.GroupBox2.Controls.Add(Me.TBUser)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TBServer)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 690)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 47)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Настройки подключения к серверу:"
        '
        'TBPass
        '
        Me.TBPass.Location = New System.Drawing.Point(458, 19)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPass.Size = New System.Drawing.Size(224, 20)
        Me.TBPass.TabIndex = 30
        Me.TBPass.Text = "Intellect_default_DB_4"
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(297, 19)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(100, 20)
        Me.TBUser.TabIndex = 29
        Me.TBUser.Text = "sa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Пароль:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Пользователь:"
        '
        'TBServer
        '
        Me.TBServer.Location = New System.Drawing.Point(53, 19)
        Me.TBServer.Name = "TBServer"
        Me.TBServer.Size = New System.Drawing.Size(149, 20)
        Me.TBServer.TabIndex = 26
        Me.TBServer.Text = "SRVVIDEO\SQLEXPRESS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Сервер:"
        '
        'Form1
        '
        Me.AcceptButton = Me.BNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 739)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.NUDn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBTime)
        Me.Controls.Add(Me.TBNumber)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BNext)
        Me.Controls.Add(Me.BFlush)
        Me.Controls.Add(Me.BDownload)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "IntellPlate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUD2r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD1r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD3l, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD2l, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD3n, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD2n, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD1n, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD1l, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BDownload As Button
    Friend WithEvents BFlush As Button
    Friend WithEvents BNext As Button
    Friend WithEvents cbletter1 As CheckBox
    Friend WithEvents cbletter2 As CheckBox
    Friend WithEvents cbletter3 As CheckBox
    Friend WithEvents cbnumber1 As CheckBox
    Friend WithEvents cbnumber2 As CheckBox
    Friend WithEvents cbnumber3 As CheckBox
    Friend WithEvents cbregion1 As CheckBox
    Friend WithEvents cbregion2 As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelCount As Label
    Friend WithEvents TBNumber As TextBox
    Friend WithEvents TBTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NUD2r As NumericUpDown
    Friend WithEvents NUD1r As NumericUpDown
    Friend WithEvents NUD3l As NumericUpDown
    Friend WithEvents NUD2l As NumericUpDown
    Friend WithEvents NUD3n As NumericUpDown
    Friend WithEvents NUD2n As NumericUpDown
    Friend WithEvents NUD1n As NumericUpDown
    Friend WithEvents NUD1l As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NUDn As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PB2r As ProgressBar
    Friend WithEvents PB1r As ProgressBar
    Friend WithEvents PB3l As ProgressBar
    Friend WithEvents PB2l As ProgressBar
    Friend WithEvents PB3n As ProgressBar
    Friend WithEvents PB2n As ProgressBar
    Friend WithEvents PB1n As ProgressBar
    Friend WithEvents PB1l As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TBPass As TextBox
    Friend WithEvents TBUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBServer As TextBox
    Friend WithEvents Label1 As Label
End Class
