'==============================================================
' Program:     New Computer Build Checker
' Course:      MET 1120, Exercise 10
' Purpose:     The user checks off the parts they have for a new
'              PC build. The program works out which parts are
'              still missing and reports how complete the kit is.
'
' Concepts:    decision making (If/Else), strings, number and
'              date formatting, MenuStrip, CheckedListBox
'
' Controls (name prefixes follow the class naming conventions):
'   MenuStrip         mnuMain
'     File            mnuFile
'       Check Parts     mnuCheck
'       Clear           mnuClear
'       Quit            mnuQuit
'     Help            mnuHelp
'       About           mnuAbout
'       Build Guide     mnuBuildGuide
'   Label             lblName       Text: Builder name:
'   TextBox           txtName
'   Label             lblParts      Text: Check each part you have:
'   CheckedListBox    clbParts      (CheckOnClick = True, Items left empty)
'   Label             lblResult     (AutoSize False, room for 4 or 5 lines)
'   Label             lblSummary
'==============================================================

' Option Strict On makes VB check our data types for us, so we
' catch conversion mistakes while writing code instead of at runtime.
Option Strict On

Public Class Exercise10

    '----------------------------------------------------------
    ' Form load: runs once when the program starts.
    ' The parts list is filled here in code instead of in the
    ' Items property, so it is easy to add or remove a part later.
    '----------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clbParts.Items.Add("CPU")
        clbParts.Items.Add("Motherboard")
        clbParts.Items.Add("Memory (RAM)")
        clbParts.Items.Add("Power supply")
        clbParts.Items.Add("Case")
        clbParts.Items.Add("Graphics card")
        clbParts.Items.Add("Hard drive or SSD")
        clbParts.Items.Add("Cooling fan")
        clbParts.Items.Add("Thermal paste")
        clbParts.Items.Add("Operating system")
        clbParts.Items.Add("Keyboard")
        clbParts.Items.Add("Mouse")
        clbParts.Items.Add("Monitor")
    End Sub

    '----------------------------------------------------------
    ' File > Check Parts
    ' Main logic: validate the name, count the checked parts,
    ' build a list of the missing ones, then display the results.
    '----------------------------------------------------------
    Private Sub mnuCheck_Click(sender As Object, e As EventArgs) Handles mnuCheck.Click

        ' Variable declarations
        Dim strName As String = txtName.Text.Trim()   ' Trim removes extra spaces on both ends
        Dim strMissing As String = ""                 ' will hold the list of missing parts
        Dim intHave As Integer = 0                    ' running count of parts the user has
        Dim intTotal As Integer = clbParts.Items.Count ' total parts in the list (13)

        ' Input validation: the name is required.
        ' If it is blank, warn the user, put the cursor back in
        ' the box, and Return to leave the sub before doing any math.
        If strName = "" Then
            MessageBox.Show("Please enter the builder's name.", "Missing Name",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Focus()
            Return
        End If

        ' Loop through every item in the list. Index numbers start
        ' at 0, so the last item is Count - 1.
        ' Checked: add 1 to the count.
        ' Not checked: add its name and a comma to the missing string.
        For intIndex As Integer = 0 To intTotal - 1
            If clbParts.GetItemChecked(intIndex) Then
                intHave += 1
            Else
                strMissing &= clbParts.Items(intIndex).ToString() & ", "
            End If
        Next

        ' The loop leaves an extra ", " on the end of the string.
        ' Substring cuts it off by keeping everything except the
        ' last 2 characters. The If makes sure the string is not
        ' empty first, since cutting an empty string would crash.
        If strMissing.Length > 0 Then
            strMissing = strMissing.Substring(0, strMissing.Length - 2)
        End If

        ' Decision: does the builder have every part or not?
        ' ToUpper makes the name all capitals for the message.
        If intHave = intTotal Then
            lblResult.Text = strName.ToUpper() & ": You have everything. Time to build!"
        Else
            lblResult.Text = strName.ToUpper() & ": You still need the following: " & strMissing & "."
        End If

        ' Formatting the summary.
        ' Dividing the counts gives a decimal (like 0.77), and the
        ' "P0" format string turns it into a percent with 0 decimal
        ' places (77%). Date.Now.ToString("D") gives the long date.
        ' ControlChars.NewLine starts a new line in the label.
        Dim dblPercent As Double = intHave / intTotal
        lblSummary.Text = "Parts on hand: " & intHave.ToString() & " of " & intTotal.ToString() &
                          " (" & dblPercent.ToString("P0") & ")" & ControlChars.NewLine &
                          "Checked on " & Date.Now.ToString("D")
    End Sub

    '----------------------------------------------------------
    ' File > Clear
    ' Resets the form to how it looked when the program started.
    '----------------------------------------------------------
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtName.Clear()

        ' Uncheck every item in the list, one at a time
        For intIndex As Integer = 0 To clbParts.Items.Count - 1
            clbParts.SetItemChecked(intIndex, False)
        Next

        lblResult.Text = ""
        lblSummary.Text = ""

        ' Send the cursor back to the name box, ready for the next user
        txtName.Focus()
    End Sub

    '----------------------------------------------------------
    ' File > Quit
    ' Closes the form, which ends the program.
    '----------------------------------------------------------
    Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    '----------------------------------------------------------
    ' Help > About
    ' Pop-up with program info. ControlChars.NewLine puts each
    ' piece of text on its own line inside the message box.
    '----------------------------------------------------------
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("New Computer Build Checker" & ControlChars.NewLine &
                        "Zak Rowe, Exercise 10, MET 1120" & ControlChars.NewLine &
                        "Check off each part you have and the program lists what is still missing.",
                        "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    '----------------------------------------------------------
    ' Help > Build Guide
    ' Opens a PC build video in the user's default web browser.
    '----------------------------------------------------------
    Private Sub mnuBuildGuide_Click(sender As Object, e As EventArgs) Handles mnuBuildGuide.Click
        ' Const because the link never changes while the program runs
        Const strGUIDE_URL As String = "https://www.youtube.com/watch?v=Mho0M1Ns0Rw"

        ' Try/Catch keeps the program from crashing if the browser
        ' can't open (no default browser, blocked, etc.).
        ' UseShellExecute = True tells Windows to hand the link to
        ' the default browser. Without it, newer .NET versions error out.
        Try
            Process.Start(New ProcessStartInfo(strGUIDE_URL) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Could not open the web page.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class