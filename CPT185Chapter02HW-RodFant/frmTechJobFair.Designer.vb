<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechJobFair
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnViewJobFairDetails = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRoomLocation = New System.Windows.Forms.Label()
        Me.lblRoomNumbers = New System.Windows.Forms.Label()
        Me.picFair = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(59, 48)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(270, 46)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Tech Job Fair"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(80, 94)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(224, 23)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "All Students are Welcome"
        '
        'btnViewJobFairDetails
        '
        Me.btnViewJobFairDetails.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewJobFairDetails.Location = New System.Drawing.Point(95, 165)
        Me.btnViewJobFairDetails.Name = "btnViewJobFairDetails"
        Me.btnViewJobFairDetails.Size = New System.Drawing.Size(197, 55)
        Me.btnViewJobFairDetails.TabIndex = 2
        Me.btnViewJobFairDetails.Text = "View Job Fair Details"
        Me.btnViewJobFairDetails.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(128, 237)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(112, 23)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "May 2, 2016"
        '
        'lblRoomLocation
        '
        Me.lblRoomLocation.AutoSize = True
        Me.lblRoomLocation.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomLocation.Location = New System.Drawing.Point(91, 288)
        Me.lblRoomLocation.Name = "lblRoomLocation"
        Me.lblRoomLocation.Size = New System.Drawing.Size(203, 23)
        Me.lblRoomLocation.TabIndex = 4
        Me.lblRoomLocation.Text = "Located in Lochlen Hall"
        '
        'lblRoomNumbers
        '
        Me.lblRoomNumbers.AutoSize = True
        Me.lblRoomNumbers.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNumbers.Location = New System.Drawing.Point(146, 311)
        Me.lblRoomNumbers.Name = "lblRoomNumbers"
        Me.lblRoomNumbers.Size = New System.Drawing.Size(94, 23)
        Me.lblRoomNumbers.TabIndex = 5
        Me.lblRoomNumbers.Text = "Room 101"
        '
        'picFair
        '
        Me.picFair.Location = New System.Drawing.Point(368, 48)
        Me.picFair.Name = "picFair"
        Me.picFair.Size = New System.Drawing.Size(189, 348)
        Me.picFair.TabIndex = 6
        Me.picFair.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(95, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(197, 41)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmTechJobFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 402)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picFair)
        Me.Controls.Add(Me.lblRoomNumbers)
        Me.Controls.Add(Me.lblRoomLocation)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnViewJobFairDetails)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmTechJobFair"
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnViewJobFairDetails As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRoomLocation As Label
    Friend WithEvents lblRoomNumbers As Label
    Friend WithEvents picFair As PictureBox
    Friend WithEvents btnExit As Button
End Class
