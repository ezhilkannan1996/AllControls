Imports System.Windows.Forms.DataFormats

Public Class DateTimePickerForm
    Dim Dte As DateTime
    Dim Format As String = "dd:MM:yyyy hh:mm:ss tt"

    Private Sub Btn_Date_Click(sender As Object, e As EventArgs) Handles Btn_Date.Click
        Lbl_OutPut_Display.Text = Dte.Date()
    End Sub

    Private Sub Btn_Day_Click(sender As Object, e As EventArgs) Handles Btn_Day.Click
        Lbl_OutPut_Display.Text = Dte.Day()
    End Sub

    Private Sub Btn_DayOfWeek_Click(sender As Object, e As EventArgs) Handles Btn_DayOfWeek.Click
        Lbl_OutPut_Display.Text = Dte.DayOfWeek()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dte = DateTimePicker.Value()
    End Sub

    Private Sub Btn_Minute_Click(sender As Object, e As EventArgs) Handles Btn_Minute.Click
        Lbl_OutPut_Display.Text = Dte.Minute()
    End Sub

    Private Sub Btn_DateOfYear_Click(sender As Object, e As EventArgs) Handles Btn_DateOfYear.Click
        'Lbl_OutPut_Display.Text = Dte.DateOfYear()
    End Sub

    Private Sub Btn_Year_Click(sender As Object, e As EventArgs) Handles Btn_Year.Click
        Lbl_OutPut_Display.Text = Dte.Year()
    End Sub

    Private Sub Btn_Now_Click(sender As Object, e As EventArgs) Handles Btn_Now.Click
        Lbl_OutPut_Display.Text = DateTime.Now()
    End Sub

    Private Sub Btn_Month_Click(sender As Object, e As EventArgs) Handles Btn_Month.Click
        Lbl_OutPut_Display.Text = Dte.Month()
    End Sub

    Private Sub Btn_Second_Click(sender As Object, e As EventArgs) Handles Btn_Second.Click
        Lbl_OutPut_Display.Text = DateTime.Now.Second()
    End Sub

    Private Sub Btn_Ticks_Click(sender As Object, e As EventArgs) Handles Btn_Ticks.Click
        Lbl_OutPut_Display.Text = DateTime.Now.Ticks()
    End Sub

    Private Sub Btn_Today_Click(sender As Object, e As EventArgs) Handles Btn_Today.Click
        Lbl_OutPut_Display.Text = DateTime.Today()
    End Sub

    Private Sub Btn_TimeOfDay_Click(sender As Object, e As EventArgs) Handles Btn_TimeOfDay.Click
        Lbl_OutPut_Display.Text = DateTime.Now.TimeOfDay().ToString()
    End Sub

    Private Sub Btn_DaysInMonth_Click(sender As Object, e As EventArgs) Handles Btn_DaysInMonth.Click
        Lbl_OutPut_Display.Text = DateTime.DaysInMonth(2001, 6).ToString() 'How many days in month of June
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        'MessageBox.Show(Dte.ToString(Format), "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Lbl_OutPut_Display.Text = Dte.Add(New TimeSpan(1, 1, 1, 1)).ToString(Format)
    End Sub

    Private Sub Btn_AddHours_Click(sender As Object, e As EventArgs) Handles Btn_AddHours.Click
        Lbl_OutPut_Display.Text = Dte.AddHours(5)
    End Sub

    Private Sub Btn_AddYears_Click(sender As Object, e As EventArgs) Handles Btn_AddYears.Click
        Lbl_OutPut_Display.Text = Dte.AddYears(5)
    End Sub

    Private Sub Btn_AddDays_Click(sender As Object, e As EventArgs) Handles Btn_AddDays.Click
        Lbl_OutPut_Display.Text = Dte.AddDays(10)
    End Sub

    Private Sub Btn_AddMinutes_Click(sender As Object, e As EventArgs) Handles Btn_AddMinutes.Click
        Lbl_OutPut_Display.Text = Dte.AddMinutes(10)
    End Sub

    Private Sub Btn_AddMonths_Click(sender As Object, e As EventArgs) Handles Btn_AddMonths.Click
        Lbl_OutPut_Display.Text = Dte.AddMonths(2)
    End Sub

    Private Sub Btn_Minutes_Click(sender As Object, e As EventArgs) Handles Btn_AddSeconds.Click
        Lbl_OutPut_Display.Text = Dte.AddSeconds(10)
    End Sub

    Private Sub Btn_IsLeapYear_Click(sender As Object, e As EventArgs) Handles Btn_IsLeapYear.Click
        Lbl_OutPut_Display.Text = String.Format("Is leap year? : {0}", If(DateTime.IsLeapYear(Dte.Year), "Yes", "No").ToString())
    End Sub

    Private Sub Btn_MinValue_Click(sender As Object, e As EventArgs) Handles Btn_MinValue.Click
        Lbl_OutPut_Display.Text = DateTime.MinValue 'Has doubt
    End Sub

    Private Sub Btn_MaxValue_Click(sender As Object, e As EventArgs) Handles Btn_MaxValue.Click
        Lbl_OutPut_Display.Text = DateTime.MaxValue
    End Sub

    Private Sub Btn_TimeSpan_Click(sender As Object, e As EventArgs) Handles Btn_TimeSpan.Click
        Dim TS As New TimeSpan
        TS = DateTime.Now - Dte
        Lbl_OutPut_Display.Text = String.Format("Current I am {0} years old and also I can tell this as {1} days or {2} hours old", Math.Floor(TS.Days / 365.255), TS.TotalDays, TS.TotalHours)
    End Sub

    Private Sub Btn_Format_d_Click(sender As Object, e As EventArgs) Handles Btn_Format_d.Click
        Lbl_OutPut_Display.Text = Dte.ToString("d")
    End Sub

    Private Sub Btn_Formatt_D_Click(sender As Object, e As EventArgs) Handles Btn_Formatt_D.Click
        Lbl_OutPut_Display.Text = Dte.ToString("D")
    End Sub

    Private Sub Btn_Format_F_Click(sender As Object, e As EventArgs) Handles Btn_Format_R.Click
        Lbl_OutPut_Display.Text = Dte.ToString("R")
    End Sub

    Private Sub Btn_Format_y_Click(sender As Object, e As EventArgs) Handles Btn_Format_y.Click
        Lbl_OutPut_Display.Text = Dte.ToString("y")
    End Sub

    Private Sub Btn_Format_f_Click_1(sender As Object, e As EventArgs) Handles Btn_Format_f.Click
        Lbl_OutPut_Display.Text = Dte.ToString("f")
    End Sub

    Private Sub Btn_Formatt_F_Click(sender As Object, e As EventArgs) Handles Btn_Formatt_F.Click
        Lbl_OutPut_Display.Text = Dte.ToString("F")
    End Sub

    Private Sub Btn_Format_t_Click(sender As Object, e As EventArgs) Handles Btn_Format_t.Click
        Lbl_OutPut_Display.Text = Dte.ToString("t")
    End Sub

    Private Sub Btn_Formatt_T_Click(sender As Object, e As EventArgs) Handles Btn_Formatt_T.Click
        Lbl_OutPut_Display.Text = Dte.ToString("T")
    End Sub

    Private Sub Btn_Format_g_Click(sender As Object, e As EventArgs) Handles Btn_Format_g.Click
        Lbl_OutPut_Display.Text = Dte.ToString("g")
    End Sub

    Private Sub Btn_Formatt_G_Click(sender As Object, e As EventArgs) Handles Btn_Formatt_G.Click
        Lbl_OutPut_Display.Text = Dte.ToString("G")
    End Sub

    Private Sub Btn_Format_M_Click(sender As Object, e As EventArgs) Handles Btn_Format_M.Click
        Lbl_OutPut_Display.Text = Dte.ToString("M")
    End Sub
End Class
