' Program Name: TechJobFair
' Programmer: Rod Fant
' Date Written: 2/6/2023
' Purpose: Shows date, room number, information about job fair.

Public Class frmTechJobFair
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblRoomNumber.Click

    End Sub

    Private Sub btnViewJobFairDetails_Click(sender As Object, e As EventArgs) Handles btnViewJobFairDetails.Click
        lblDate.Visible = True ' Display the Date info
        lblRoomLocation.Visible = True ' Display the room location
        lblRoomNumber.Visible = True ' Display the room number
        btnExit.Visible = True ' Display the Exit button
        btnExit.Enabled = True ' Enable the Exit button
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close() ' Closes the form
    End Sub
End Class
