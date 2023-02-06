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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTechJobFair))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnViewJobFairDetails = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRoomLocation = New System.Windows.Forms.Label()
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.picFair = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DarkGreen
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
        Me.btnViewJobFairDetails.BackColor = System.Drawing.Color.Honeydew
        Me.btnViewJobFairDetails.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewJobFairDetails.Location = New System.Drawing.Point(95, 165)
        Me.btnViewJobFairDetails.Name = "btnViewJobFairDetails"
        Me.btnViewJobFairDetails.Size = New System.Drawing.Size(197, 55)
        Me.btnViewJobFairDetails.TabIndex = 2
        Me.btnViewJobFairDetails.Text = "View Job Fair Details"
        Me.btnViewJobFairDetails.UseVisualStyleBackColor = False
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
        Me.lblDate.Visible = False
        '
        'lblRoomLocation
        '
        Me.lblRoomLocation.AutoSize = True
        Me.lblRoomLocation.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomLocation.Location = New System.Drawing.Point(91, 288)
        Me.lblRoomLocation.Name = "lblRoomLocation"
        Me.lblRoomLocation.Size = New System.Drawing.Size(203, 23)
        Me.lblRoomLocation.TabIndex = 4
        Me.lblRoomLocation.Text = "Located in Lochlan Hall"
        Me.lblRoomLocation.Visible = False
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNumber.Location = New System.Drawing.Point(146, 311)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(94, 23)
        Me.lblRoomNumber.TabIndex = 5
        Me.lblRoomNumber.Text = "Room 101"
        Me.lblRoomNumber.Visible = False
        '
        'picFair
        '
        Me.picFair.Image = CType(resources.GetObject("picFair.Image"), System.Drawing.Image)
        Me.picFair.Location = New System.Drawing.Point(335, 48)
        Me.picFair.Name = "picFair"
        Me.picFair.Size = New System.Drawing.Size(318, 529)
        Me.picFair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFair.TabIndex = 6
        Me.picFair.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(95, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(197, 41)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'frmTechJobFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(660, 582)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picFair)
        Me.Controls.Add(Me.lblRoomNumber)
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
    Friend WithEvents lblRoomNumber As Label
    Friend WithEvents picFair As PictureBox
    Friend WithEvents btnExit As Button
End Class
