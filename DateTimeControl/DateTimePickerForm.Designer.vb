<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateTimePickerForm
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
        DateTimePicker = New DateTimePicker()
        Btn_Date = New Button()
        Btn_Day = New Button()
        Lbl_OutPut = New Label()
        Lbl_OutPut_Display = New Label()
        Lbl_Title = New Label()
        Lbl_Task = New Label()
        Lbl_DateTime = New Label()
        Btn_DayOfWeek = New Button()
        Btn_Minute = New Button()
        Btn_DateOfYear = New Button()
        Btn_Year = New Button()
        Btn_Now = New Button()
        Btn_Month = New Button()
        Btn_Second = New Button()
        Btn_Ticks = New Button()
        Btn_Today = New Button()
        Btn_TimeOfDay = New Button()
        Btn_DaysInMonth = New Button()
        Btn_Add = New Button()
        Btn_AddHours = New Button()
        Btn_AddYears = New Button()
        Btn_AddDays = New Button()
        Btn_AddMinutes = New Button()
        Btn_AddMonths = New Button()
        Btn_AddSeconds = New Button()
        Btn_IsLeapYear = New Button()
        Btn_MinValue = New Button()
        Btn_MaxValue = New Button()
        Btn_TimeSpan = New Button()
        Btn_Format_d = New Button()
        Btn_Formatt_D = New Button()
        Btn_Format_R = New Button()
        Btn_Format_y = New Button()
        Btn_Format_f = New Button()
        Btn_Formatt_F = New Button()
        Btn_Format_t = New Button()
        Btn_Formatt_T = New Button()
        Btn_Format_g = New Button()
        Btn_Formatt_G = New Button()
        Btn_Format_M = New Button()
        SuspendLayout()
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.CalendarMonthBackground = Color.White
        DateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.Location = New Point(280, 40)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(200, 23)
        DateTimePicker.TabIndex = 0
        DateTimePicker.Value = New Date(1996, 6, 13, 1, 1, 1, 0)
        ' 
        ' Btn_Date
        ' 
        Btn_Date.Location = New Point(12, 132)
        Btn_Date.Name = "Btn_Date"
        Btn_Date.Size = New Size(75, 23)
        Btn_Date.TabIndex = 1
        Btn_Date.Text = "Date"
        Btn_Date.UseVisualStyleBackColor = True
        ' 
        ' Btn_Day
        ' 
        Btn_Day.Location = New Point(12, 161)
        Btn_Day.Name = "Btn_Day"
        Btn_Day.Size = New Size(75, 23)
        Btn_Day.TabIndex = 2
        Btn_Day.Text = "Day"
        Btn_Day.UseVisualStyleBackColor = True
        ' 
        ' Lbl_OutPut
        ' 
        Lbl_OutPut.BackColor = Color.Black
        Lbl_OutPut.ForeColor = Color.White
        Lbl_OutPut.Location = New Point(522, 101)
        Lbl_OutPut.Name = "Lbl_OutPut"
        Lbl_OutPut.Size = New Size(170, 23)
        Lbl_OutPut.TabIndex = 3
        Lbl_OutPut.Text = "OutPut"
        Lbl_OutPut.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_OutPut_Display
        ' 
        Lbl_OutPut_Display.BackColor = SystemColors.InactiveBorder
        Lbl_OutPut_Display.BorderStyle = BorderStyle.FixedSingle
        Lbl_OutPut_Display.Location = New Point(522, 132)
        Lbl_OutPut_Display.Name = "Lbl_OutPut_Display"
        Lbl_OutPut_Display.Size = New Size(170, 172)
        Lbl_OutPut_Display.TabIndex = 4
        ' 
        ' Lbl_Title
        ' 
        Lbl_Title.BackColor = Color.Black
        Lbl_Title.ForeColor = Color.White
        Lbl_Title.Location = New Point(12, 101)
        Lbl_Title.Name = "Lbl_Title"
        Lbl_Title.Size = New Size(229, 23)
        Lbl_Title.TabIndex = 5
        Lbl_Title.Text = "Properties and method of DateTime :"
        Lbl_Title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_Task
        ' 
        Lbl_Task.AutoSize = True
        Lbl_Task.BackColor = Color.Black
        Lbl_Task.ForeColor = Color.White
        Lbl_Task.Location = New Point(12, 9)
        Lbl_Task.Name = "Lbl_Task"
        Lbl_Task.Size = New Size(35, 15)
        Lbl_Task.TabIndex = 6
        Lbl_Task.Text = "Task :"
        ' 
        ' Lbl_DateTime
        ' 
        Lbl_DateTime.AutoSize = True
        Lbl_DateTime.BackColor = Color.Black
        Lbl_DateTime.ForeColor = Color.White
        Lbl_DateTime.Location = New Point(53, 9)
        Lbl_DateTime.Name = "Lbl_DateTime"
        Lbl_DateTime.Size = New Size(103, 15)
        Lbl_DateTime.TabIndex = 7
        Lbl_DateTime.Text = "Date Time Control"
        ' 
        ' Btn_DayOfWeek
        ' 
        Btn_DayOfWeek.Location = New Point(12, 190)
        Btn_DayOfWeek.Name = "Btn_DayOfWeek"
        Btn_DayOfWeek.Size = New Size(75, 23)
        Btn_DayOfWeek.TabIndex = 8
        Btn_DayOfWeek.Text = "DayOfWeek"
        Btn_DayOfWeek.UseVisualStyleBackColor = True
        ' 
        ' Btn_Minute
        ' 
        Btn_Minute.Location = New Point(12, 219)
        Btn_Minute.Name = "Btn_Minute"
        Btn_Minute.Size = New Size(75, 23)
        Btn_Minute.TabIndex = 9
        Btn_Minute.Text = "Minute"
        Btn_Minute.UseVisualStyleBackColor = True
        ' 
        ' Btn_DateOfYear
        ' 
        Btn_DateOfYear.Location = New Point(12, 248)
        Btn_DateOfYear.Name = "Btn_DateOfYear"
        Btn_DateOfYear.Size = New Size(75, 23)
        Btn_DateOfYear.TabIndex = 10
        Btn_DateOfYear.Text = "DateOfYear"
        Btn_DateOfYear.UseVisualStyleBackColor = True
        ' 
        ' Btn_Year
        ' 
        Btn_Year.Location = New Point(12, 277)
        Btn_Year.Name = "Btn_Year"
        Btn_Year.Size = New Size(75, 23)
        Btn_Year.TabIndex = 11
        Btn_Year.Text = "Year"
        Btn_Year.UseVisualStyleBackColor = True
        ' 
        ' Btn_Now
        ' 
        Btn_Now.Location = New Point(12, 306)
        Btn_Now.Name = "Btn_Now"
        Btn_Now.Size = New Size(75, 23)
        Btn_Now.TabIndex = 12
        Btn_Now.Text = "Now"
        Btn_Now.UseVisualStyleBackColor = True
        ' 
        ' Btn_Month
        ' 
        Btn_Month.Location = New Point(12, 335)
        Btn_Month.Name = "Btn_Month"
        Btn_Month.Size = New Size(75, 23)
        Btn_Month.TabIndex = 13
        Btn_Month.Text = "Month"
        Btn_Month.UseVisualStyleBackColor = True
        ' 
        ' Btn_Second
        ' 
        Btn_Second.Location = New Point(12, 364)
        Btn_Second.Name = "Btn_Second"
        Btn_Second.Size = New Size(75, 23)
        Btn_Second.TabIndex = 14
        Btn_Second.Text = "Second"
        Btn_Second.UseVisualStyleBackColor = True
        ' 
        ' Btn_Ticks
        ' 
        Btn_Ticks.Location = New Point(12, 393)
        Btn_Ticks.Name = "Btn_Ticks"
        Btn_Ticks.Size = New Size(75, 23)
        Btn_Ticks.TabIndex = 15
        Btn_Ticks.Text = "Ticks"
        Btn_Ticks.UseVisualStyleBackColor = True
        ' 
        ' Btn_Today
        ' 
        Btn_Today.Location = New Point(12, 422)
        Btn_Today.Name = "Btn_Today"
        Btn_Today.Size = New Size(75, 23)
        Btn_Today.TabIndex = 16
        Btn_Today.Text = "Today"
        Btn_Today.UseVisualStyleBackColor = True
        ' 
        ' Btn_TimeOfDay
        ' 
        Btn_TimeOfDay.Location = New Point(12, 451)
        Btn_TimeOfDay.Name = "Btn_TimeOfDay"
        Btn_TimeOfDay.Size = New Size(75, 23)
        Btn_TimeOfDay.TabIndex = 17
        Btn_TimeOfDay.Text = "TimeOfDay"
        Btn_TimeOfDay.UseVisualStyleBackColor = True
        ' 
        ' Btn_DaysInMonth
        ' 
        Btn_DaysInMonth.Location = New Point(12, 480)
        Btn_DaysInMonth.Name = "Btn_DaysInMonth"
        Btn_DaysInMonth.Size = New Size(75, 23)
        Btn_DaysInMonth.TabIndex = 18
        Btn_DaysInMonth.Text = "DaysInMonth"
        Btn_DaysInMonth.UseVisualStyleBackColor = True
        ' 
        ' Btn_Add
        ' 
        Btn_Add.Location = New Point(12, 509)
        Btn_Add.Name = "Btn_Add"
        Btn_Add.Size = New Size(75, 23)
        Btn_Add.TabIndex = 19
        Btn_Add.Text = "Add"
        Btn_Add.UseVisualStyleBackColor = True
        ' 
        ' Btn_AddHours
        ' 
        Btn_AddHours.Location = New Point(12, 538)
        Btn_AddHours.Name = "Btn_AddHours"
        Btn_AddHours.Size = New Size(75, 23)
        Btn_AddHours.TabIndex = 20
        Btn_AddHours.Text = "AddHours"
        Btn_AddHours.UseVisualStyleBackColor = True
        ' 
        ' Btn_AddYears
        ' 
        Btn_AddYears.Location = New Point(12, 567)
        Btn_AddYears.Name = "Btn_AddYears"
        Btn_AddYears.Size = New Size(75, 23)
        Btn_AddYears.TabIndex = 21
        Btn_AddYears.Text = "AddYears"
        Btn_AddYears.UseVisualStyleBackColor = True
        ' 
        ' Btn_AddDays
        ' 
        Btn_AddDays.Location = New Point(12, 596)
        Btn_AddDays.Name = "Btn_AddDays"
        Btn_AddDays.Size = New Size(75, 23)
        Btn_AddDays.TabIndex = 22
        Btn_AddDays.Text = "AddDays"
        Btn_AddDays.UseVisualStyleBackColor = True
        ' 
        ' Btn_AddMinutes
        ' 
        Btn_AddMinutes.Location = New Point(93, 132)
        Btn_AddMinutes.Name = "Btn_AddMinutes"
        Btn_AddMinutes.Size = New Size(75, 23)
        Btn_AddMinutes.TabIndex = 23
        Btn_AddMinutes.Text = "AddMinutes"
        Btn_AddMinutes.UseVisualStyleBackColor = True
        ' 
        ' Btn_AddMonths
        ' 
        Btn_AddMonths.Location = New Point(93, 161)
        Btn_AddMonths.Name = "Btn_AddMonths"
        Btn_AddMonths.Size = New Size(75, 23)
        Btn_AddMonths.TabIndex = 24
        Btn_AddMonths.Text = "AddMonths"
        Btn_AddMonths.UseVisualStyleBackColor = True
        ' 
        ' Btn_AddSeconds
        ' 
        Btn_AddSeconds.Location = New Point(93, 190)
        Btn_AddSeconds.Name = "Btn_AddSeconds"
        Btn_AddSeconds.Size = New Size(75, 23)
        Btn_AddSeconds.TabIndex = 25
        Btn_AddSeconds.Text = "AddSeconds"
        Btn_AddSeconds.UseVisualStyleBackColor = True
        ' 
        ' Btn_IsLeapYear
        ' 
        Btn_IsLeapYear.Location = New Point(93, 219)
        Btn_IsLeapYear.Name = "Btn_IsLeapYear"
        Btn_IsLeapYear.Size = New Size(75, 23)
        Btn_IsLeapYear.TabIndex = 26
        Btn_IsLeapYear.Text = "IsLeapYear"
        Btn_IsLeapYear.UseVisualStyleBackColor = True
        ' 
        ' Btn_MinValue
        ' 
        Btn_MinValue.Location = New Point(93, 248)
        Btn_MinValue.Name = "Btn_MinValue"
        Btn_MinValue.Size = New Size(75, 23)
        Btn_MinValue.TabIndex = 27
        Btn_MinValue.Text = "MinValue"
        Btn_MinValue.UseVisualStyleBackColor = True
        ' 
        ' Btn_MaxValue
        ' 
        Btn_MaxValue.Location = New Point(93, 277)
        Btn_MaxValue.Name = "Btn_MaxValue"
        Btn_MaxValue.Size = New Size(75, 23)
        Btn_MaxValue.TabIndex = 28
        Btn_MaxValue.Text = "MaxValue"
        Btn_MaxValue.UseVisualStyleBackColor = True
        ' 
        ' Btn_TimeSpan
        ' 
        Btn_TimeSpan.Location = New Point(93, 306)
        Btn_TimeSpan.Name = "Btn_TimeSpan"
        Btn_TimeSpan.Size = New Size(75, 23)
        Btn_TimeSpan.TabIndex = 29
        Btn_TimeSpan.Text = "TimeSpan"
        Btn_TimeSpan.UseVisualStyleBackColor = True
        ' 
        ' Btn_Format_d
        ' 
        Btn_Format_d.Location = New Point(93, 335)
        Btn_Format_d.Name = "Btn_Format_d"
        Btn_Format_d.Size = New Size(75, 23)
        Btn_Format_d.TabIndex = 30
        Btn_Format_d.Text = "Format d"
        Btn_Format_d.UseVisualStyleBackColor = True
        ' 
        ' Btn_Formatt_D
        ' 
        Btn_Formatt_D.Location = New Point(93, 364)
        Btn_Formatt_D.Name = "Btn_Formatt_D"
        Btn_Formatt_D.Size = New Size(75, 23)
        Btn_Formatt_D.TabIndex = 31
        Btn_Formatt_D.Text = "Format D"
        Btn_Formatt_D.UseVisualStyleBackColor = True
        ' 
        ' Btn_Format_R
        ' 
        Btn_Format_R.Location = New Point(93, 393)
        Btn_Format_R.Name = "Btn_Format_R"
        Btn_Format_R.Size = New Size(75, 23)
        Btn_Format_R.TabIndex = 32
        Btn_Format_R.Text = "Format R"
        Btn_Format_R.UseVisualStyleBackColor = True
        ' 
        ' Btn_Format_y
        ' 
        Btn_Format_y.Location = New Point(93, 422)
        Btn_Format_y.Name = "Btn_Format_y"
        Btn_Format_y.Size = New Size(75, 23)
        Btn_Format_y.TabIndex = 33
        Btn_Format_y.Text = "Format y"
        Btn_Format_y.UseVisualStyleBackColor = True
        ' 
        ' Btn_Format_f
        ' 
        Btn_Format_f.Location = New Point(93, 451)
        Btn_Format_f.Name = "Btn_Format_f"
        Btn_Format_f.Size = New Size(75, 23)
        Btn_Format_f.TabIndex = 34
        Btn_Format_f.Text = "Format f"
        Btn_Format_f.UseVisualStyleBackColor = True
        ' 
        ' Btn_Formatt_F
        ' 
        Btn_Formatt_F.Location = New Point(93, 480)
        Btn_Formatt_F.Name = "Btn_Formatt_F"
        Btn_Formatt_F.Size = New Size(75, 23)
        Btn_Formatt_F.TabIndex = 35
        Btn_Formatt_F.Text = "Format F"
        Btn_Formatt_F.UseVisualStyleBackColor = True
        ' 
        ' Btn_Format_t
        ' 
        Btn_Format_t.Location = New Point(93, 509)
        Btn_Format_t.Name = "Btn_Format_t"
        Btn_Format_t.Size = New Size(75, 23)
        Btn_Format_t.TabIndex = 36
        Btn_Format_t.Text = "Format t"
        Btn_Format_t.UseVisualStyleBackColor = True
        ' 
        ' Btn_Formatt_T
        ' 
        Btn_Formatt_T.Location = New Point(93, 538)
        Btn_Formatt_T.Name = "Btn_Formatt_T"
        Btn_Formatt_T.Size = New Size(75, 23)
        Btn_Formatt_T.TabIndex = 37
        Btn_Formatt_T.Text = "Format T"
        Btn_Formatt_T.UseVisualStyleBackColor = True
        ' 
        ' Btn_Format_g
        ' 
        Btn_Format_g.Location = New Point(93, 567)
        Btn_Format_g.Name = "Btn_Format_g"
        Btn_Format_g.Size = New Size(75, 23)
        Btn_Format_g.TabIndex = 38
        Btn_Format_g.Text = "Format g"
        Btn_Format_g.UseVisualStyleBackColor = True
        ' 
        ' Btn_Formatt_G
        ' 
        Btn_Formatt_G.Location = New Point(93, 596)
        Btn_Formatt_G.Name = "Btn_Formatt_G"
        Btn_Formatt_G.Size = New Size(75, 23)
        Btn_Formatt_G.TabIndex = 39
        Btn_Formatt_G.Text = "Format G"
        Btn_Formatt_G.UseVisualStyleBackColor = True
        ' 
        ' Btn_Format_M
        ' 
        Btn_Format_M.Location = New Point(174, 132)
        Btn_Format_M.Name = "Btn_Format_M"
        Btn_Format_M.Size = New Size(75, 23)
        Btn_Format_M.TabIndex = 40
        Btn_Format_M.Text = "Format M"
        Btn_Format_M.UseVisualStyleBackColor = True
        ' 
        ' DateTimePickerForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 639)
        Controls.Add(Btn_Format_M)
        Controls.Add(Btn_Formatt_G)
        Controls.Add(Btn_Format_g)
        Controls.Add(Btn_Formatt_T)
        Controls.Add(Btn_Format_t)
        Controls.Add(Btn_Formatt_F)
        Controls.Add(Btn_Format_f)
        Controls.Add(Btn_Format_y)
        Controls.Add(Btn_Format_R)
        Controls.Add(Btn_Formatt_D)
        Controls.Add(Btn_Format_d)
        Controls.Add(Btn_TimeSpan)
        Controls.Add(Btn_MaxValue)
        Controls.Add(Btn_MinValue)
        Controls.Add(Btn_IsLeapYear)
        Controls.Add(Btn_AddSeconds)
        Controls.Add(Btn_AddMonths)
        Controls.Add(Btn_AddMinutes)
        Controls.Add(Btn_AddDays)
        Controls.Add(Btn_AddYears)
        Controls.Add(Btn_AddHours)
        Controls.Add(Btn_Add)
        Controls.Add(Btn_DaysInMonth)
        Controls.Add(Btn_TimeOfDay)
        Controls.Add(Btn_Today)
        Controls.Add(Btn_Ticks)
        Controls.Add(Btn_Second)
        Controls.Add(Btn_Month)
        Controls.Add(Btn_Now)
        Controls.Add(Btn_Year)
        Controls.Add(Btn_DateOfYear)
        Controls.Add(Btn_Minute)
        Controls.Add(Btn_DayOfWeek)
        Controls.Add(Lbl_DateTime)
        Controls.Add(Lbl_Task)
        Controls.Add(Lbl_Title)
        Controls.Add(Lbl_OutPut_Display)
        Controls.Add(Lbl_OutPut)
        Controls.Add(Btn_Day)
        Controls.Add(Btn_Date)
        Controls.Add(DateTimePicker)
        Name = "DateTimePickerForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DateTimePicker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Btn_Date As Button
    Friend WithEvents Btn_Day As Button
    Friend WithEvents Lbl_OutPut As Label
    Friend WithEvents Lbl_OutPut_Display As Label
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Lbl_Task As Label
    Friend WithEvents Lbl_DateTime As Label
    Friend WithEvents Btn_DayOfWeek As Button
    Friend WithEvents Btn_Minute As Button
    Friend WithEvents Btn_DateOfYear As Button
    Friend WithEvents Btn_Year As Button
    Friend WithEvents Btn_Now As Button
    Friend WithEvents Btn_Month As Button
    Friend WithEvents Btn_Second As Button
    Friend WithEvents Btn_Ticks As Button
    Friend WithEvents Btn_Today As Button
    Friend WithEvents Btn_TimeOfDay As Button
    Friend WithEvents Btn_DaysInMonth As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_AddHours As Button
    Friend WithEvents Btn_AddYears As Button
    Friend WithEvents Btn_AddDays As Button
    Friend WithEvents Btn_AddMinutes As Button
    Friend WithEvents Btn_AddMonths As Button
    Friend WithEvents Btn_AddSeconds As Button
    Friend WithEvents Btn_IsLeapYear As Button
    Friend WithEvents Btn_MinValue As Button
    Friend WithEvents Btn_MaxValue As Button
    Friend WithEvents Btn_TimeSpan As Button
    Friend WithEvents Btn_Format_d As Button
    Friend WithEvents Btn_Formatt_D As Button
    Friend WithEvents Btn_Format_R As Button
    Friend WithEvents Btn_Format_y As Button
    Friend WithEvents Btn_Format_f As Button
    Friend WithEvents Btn_Formatt_F As Button
    Friend WithEvents Btn_Format_t As Button
    Friend WithEvents Btn_Formatt_T As Button
    Friend WithEvents Btn_Format_g As Button
    Friend WithEvents Btn_Formatt_G As Button
    Friend WithEvents Btn_Format_M As Button
End Class
