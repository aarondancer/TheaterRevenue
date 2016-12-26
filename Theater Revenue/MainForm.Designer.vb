<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.AdultTicketSalesBox = New System.Windows.Forms.GroupBox()
        Me.AdultTicketsSoldLabel = New System.Windows.Forms.Label()
        Me.PricePerAdultLabel = New System.Windows.Forms.Label()
        Me.AdultTicketsSoldField = New System.Windows.Forms.TextBox()
        Me.PricePerAdultField = New System.Windows.Forms.TextBox()
        Me.ChildTicketSalesBox = New System.Windows.Forms.GroupBox()
        Me.ChildTicketsSoldLabel = New System.Windows.Forms.Label()
        Me.PricePerChildField = New System.Windows.Forms.TextBox()
        Me.PricePerChildLabel = New System.Windows.Forms.Label()
        Me.ChildTicketsSoldField = New System.Windows.Forms.TextBox()
        Me.GrossTicketRevenueBox = New System.Windows.Forms.GroupBox()
        Me.TotalGrossRevenueLabel = New System.Windows.Forms.Label()
        Me.TotalGrossRevenueField = New System.Windows.Forms.TextBox()
        Me.GrossChildTicketSalesLabel = New System.Windows.Forms.Label()
        Me.GrossAdultTicketSalesLabel = New System.Windows.Forms.Label()
        Me.GrossChildTicketSalesField = New System.Windows.Forms.TextBox()
        Me.GrossAdultTicketSalesField = New System.Windows.Forms.TextBox()
        Me.NetTicketRevenueBox = New System.Windows.Forms.GroupBox()
        Me.TotalNetRevenueLabel = New System.Windows.Forms.Label()
        Me.NetAdultTicketSalesField = New System.Windows.Forms.TextBox()
        Me.TotalNetRevenueField = New System.Windows.Forms.TextBox()
        Me.NetChildTicketSalesField = New System.Windows.Forms.TextBox()
        Me.NetChildTicketSalesLabel = New System.Windows.Forms.Label()
        Me.NetAdultTicketSalesLabel = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.AdultTicketSalesBox.SuspendLayout()
        Me.ChildTicketSalesBox.SuspendLayout()
        Me.GrossTicketRevenueBox.SuspendLayout()
        Me.NetTicketRevenueBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdultTicketSalesBox
        '
        Me.AdultTicketSalesBox.Controls.Add(Me.AdultTicketsSoldLabel)
        Me.AdultTicketSalesBox.Controls.Add(Me.PricePerAdultLabel)
        Me.AdultTicketSalesBox.Controls.Add(Me.AdultTicketsSoldField)
        Me.AdultTicketSalesBox.Controls.Add(Me.PricePerAdultField)
        resources.ApplyResources(Me.AdultTicketSalesBox, "AdultTicketSalesBox")
        Me.AdultTicketSalesBox.Name = "AdultTicketSalesBox"
        Me.AdultTicketSalesBox.TabStop = False
        '
        'AdultTicketsSoldLabel
        '
        resources.ApplyResources(Me.AdultTicketsSoldLabel, "AdultTicketsSoldLabel")
        Me.AdultTicketsSoldLabel.Name = "AdultTicketsSoldLabel"
        '
        'PricePerAdultLabel
        '
        resources.ApplyResources(Me.PricePerAdultLabel, "PricePerAdultLabel")
        Me.PricePerAdultLabel.Name = "PricePerAdultLabel"
        '
        'AdultTicketsSoldField
        '
        resources.ApplyResources(Me.AdultTicketsSoldField, "AdultTicketsSoldField")
        Me.AdultTicketsSoldField.Name = "AdultTicketsSoldField"
        '
        'PricePerAdultField
        '
        resources.ApplyResources(Me.PricePerAdultField, "PricePerAdultField")
        Me.PricePerAdultField.Name = "PricePerAdultField"
        '
        'ChildTicketSalesBox
        '
        Me.ChildTicketSalesBox.Controls.Add(Me.ChildTicketsSoldLabel)
        Me.ChildTicketSalesBox.Controls.Add(Me.PricePerChildField)
        Me.ChildTicketSalesBox.Controls.Add(Me.PricePerChildLabel)
        Me.ChildTicketSalesBox.Controls.Add(Me.ChildTicketsSoldField)
        resources.ApplyResources(Me.ChildTicketSalesBox, "ChildTicketSalesBox")
        Me.ChildTicketSalesBox.Name = "ChildTicketSalesBox"
        Me.ChildTicketSalesBox.TabStop = False
        '
        'ChildTicketsSoldLabel
        '
        resources.ApplyResources(Me.ChildTicketsSoldLabel, "ChildTicketsSoldLabel")
        Me.ChildTicketsSoldLabel.Name = "ChildTicketsSoldLabel"
        '
        'PricePerChildField
        '
        resources.ApplyResources(Me.PricePerChildField, "PricePerChildField")
        Me.PricePerChildField.Name = "PricePerChildField"
        '
        'PricePerChildLabel
        '
        resources.ApplyResources(Me.PricePerChildLabel, "PricePerChildLabel")
        Me.PricePerChildLabel.Name = "PricePerChildLabel"
        '
        'ChildTicketsSoldField
        '
        resources.ApplyResources(Me.ChildTicketsSoldField, "ChildTicketsSoldField")
        Me.ChildTicketsSoldField.Name = "ChildTicketsSoldField"
        '
        'GrossTicketRevenueBox
        '
        Me.GrossTicketRevenueBox.Controls.Add(Me.TotalGrossRevenueLabel)
        Me.GrossTicketRevenueBox.Controls.Add(Me.TotalGrossRevenueField)
        Me.GrossTicketRevenueBox.Controls.Add(Me.GrossChildTicketSalesLabel)
        Me.GrossTicketRevenueBox.Controls.Add(Me.GrossAdultTicketSalesLabel)
        Me.GrossTicketRevenueBox.Controls.Add(Me.GrossChildTicketSalesField)
        Me.GrossTicketRevenueBox.Controls.Add(Me.GrossAdultTicketSalesField)
        resources.ApplyResources(Me.GrossTicketRevenueBox, "GrossTicketRevenueBox")
        Me.GrossTicketRevenueBox.Name = "GrossTicketRevenueBox"
        Me.GrossTicketRevenueBox.TabStop = False
        '
        'TotalGrossRevenueLabel
        '
        resources.ApplyResources(Me.TotalGrossRevenueLabel, "TotalGrossRevenueLabel")
        Me.TotalGrossRevenueLabel.Name = "TotalGrossRevenueLabel"
        '
        'TotalGrossRevenueField
        '
        resources.ApplyResources(Me.TotalGrossRevenueField, "TotalGrossRevenueField")
        Me.TotalGrossRevenueField.Name = "TotalGrossRevenueField"
        Me.TotalGrossRevenueField.ReadOnly = True
        Me.TotalGrossRevenueField.TabStop = False
        '
        'GrossChildTicketSalesLabel
        '
        resources.ApplyResources(Me.GrossChildTicketSalesLabel, "GrossChildTicketSalesLabel")
        Me.GrossChildTicketSalesLabel.Name = "GrossChildTicketSalesLabel"
        '
        'GrossAdultTicketSalesLabel
        '
        resources.ApplyResources(Me.GrossAdultTicketSalesLabel, "GrossAdultTicketSalesLabel")
        Me.GrossAdultTicketSalesLabel.Name = "GrossAdultTicketSalesLabel"
        '
        'GrossChildTicketSalesField
        '
        resources.ApplyResources(Me.GrossChildTicketSalesField, "GrossChildTicketSalesField")
        Me.GrossChildTicketSalesField.Name = "GrossChildTicketSalesField"
        Me.GrossChildTicketSalesField.ReadOnly = True
        Me.GrossChildTicketSalesField.TabStop = False
        '
        'GrossAdultTicketSalesField
        '
        resources.ApplyResources(Me.GrossAdultTicketSalesField, "GrossAdultTicketSalesField")
        Me.GrossAdultTicketSalesField.Name = "GrossAdultTicketSalesField"
        Me.GrossAdultTicketSalesField.ReadOnly = True
        Me.GrossAdultTicketSalesField.TabStop = False
        '
        'NetTicketRevenueBox
        '
        Me.NetTicketRevenueBox.Controls.Add(Me.TotalNetRevenueLabel)
        Me.NetTicketRevenueBox.Controls.Add(Me.NetAdultTicketSalesField)
        Me.NetTicketRevenueBox.Controls.Add(Me.TotalNetRevenueField)
        Me.NetTicketRevenueBox.Controls.Add(Me.NetChildTicketSalesField)
        Me.NetTicketRevenueBox.Controls.Add(Me.NetChildTicketSalesLabel)
        Me.NetTicketRevenueBox.Controls.Add(Me.NetAdultTicketSalesLabel)
        resources.ApplyResources(Me.NetTicketRevenueBox, "NetTicketRevenueBox")
        Me.NetTicketRevenueBox.Name = "NetTicketRevenueBox"
        Me.NetTicketRevenueBox.TabStop = False
        '
        'TotalNetRevenueLabel
        '
        resources.ApplyResources(Me.TotalNetRevenueLabel, "TotalNetRevenueLabel")
        Me.TotalNetRevenueLabel.Name = "TotalNetRevenueLabel"
        '
        'NetAdultTicketSalesField
        '
        resources.ApplyResources(Me.NetAdultTicketSalesField, "NetAdultTicketSalesField")
        Me.NetAdultTicketSalesField.Name = "NetAdultTicketSalesField"
        Me.NetAdultTicketSalesField.ReadOnly = True
        Me.NetAdultTicketSalesField.TabStop = False
        '
        'TotalNetRevenueField
        '
        resources.ApplyResources(Me.TotalNetRevenueField, "TotalNetRevenueField")
        Me.TotalNetRevenueField.Name = "TotalNetRevenueField"
        Me.TotalNetRevenueField.ReadOnly = True
        Me.TotalNetRevenueField.TabStop = False
        '
        'NetChildTicketSalesField
        '
        resources.ApplyResources(Me.NetChildTicketSalesField, "NetChildTicketSalesField")
        Me.NetChildTicketSalesField.Name = "NetChildTicketSalesField"
        Me.NetChildTicketSalesField.ReadOnly = True
        Me.NetChildTicketSalesField.TabStop = False
        '
        'NetChildTicketSalesLabel
        '
        resources.ApplyResources(Me.NetChildTicketSalesLabel, "NetChildTicketSalesLabel")
        Me.NetChildTicketSalesLabel.Name = "NetChildTicketSalesLabel"
        '
        'NetAdultTicketSalesLabel
        '
        resources.ApplyResources(Me.NetAdultTicketSalesLabel, "NetAdultTicketSalesLabel")
        Me.NetAdultTicketSalesLabel.Name = "NetAdultTicketSalesLabel"
        '
        'CalculateBtn
        '
        resources.ApplyResources(Me.CalculateBtn, "CalculateBtn")
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        resources.ApplyResources(Me.ClearBtn, "ClearBtn")
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        resources.ApplyResources(Me.ExitBtn, "ExitBtn")
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.NetTicketRevenueBox)
        Me.Controls.Add(Me.GrossTicketRevenueBox)
        Me.Controls.Add(Me.ChildTicketSalesBox)
        Me.Controls.Add(Me.AdultTicketSalesBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.AdultTicketSalesBox.ResumeLayout(False)
        Me.AdultTicketSalesBox.PerformLayout()
        Me.ChildTicketSalesBox.ResumeLayout(False)
        Me.ChildTicketSalesBox.PerformLayout()
        Me.GrossTicketRevenueBox.ResumeLayout(False)
        Me.GrossTicketRevenueBox.PerformLayout()
        Me.NetTicketRevenueBox.ResumeLayout(False)
        Me.NetTicketRevenueBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdultTicketSalesBox As GroupBox
    Friend WithEvents ChildTicketSalesBox As GroupBox
    Friend WithEvents GrossTicketRevenueBox As GroupBox
    Friend WithEvents NetTicketRevenueBox As GroupBox
    Friend WithEvents AdultTicketsSoldLabel As Label
    Friend WithEvents PricePerAdultLabel As Label
    Friend WithEvents AdultTicketsSoldField As TextBox
    Friend WithEvents PricePerAdultField As TextBox
    Friend WithEvents ChildTicketsSoldLabel As Label
    Friend WithEvents PricePerChildField As TextBox
    Friend WithEvents PricePerChildLabel As Label
    Friend WithEvents ChildTicketsSoldField As TextBox
    Friend WithEvents GrossChildTicketSalesLabel As Label
    Friend WithEvents GrossAdultTicketSalesLabel As Label
    Friend WithEvents GrossChildTicketSalesField As TextBox
    Friend WithEvents GrossAdultTicketSalesField As TextBox
    Friend WithEvents TotalGrossRevenueLabel As Label
    Friend WithEvents TotalGrossRevenueField As TextBox
    Friend WithEvents TotalNetRevenueLabel As Label
    Friend WithEvents TotalNetRevenueField As TextBox
    Friend WithEvents NetChildTicketSalesField As TextBox
    Friend WithEvents NetChildTicketSalesLabel As Label
    Friend WithEvents NetAdultTicketSalesLabel As Label
    Friend WithEvents NetAdultTicketSalesField As TextBox
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
