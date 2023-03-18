<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThAlertWindow
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.m_txb31 = New System.Windows.Forms.TextBox()
        Me.m_btn31 = New System.Windows.Forms.Button()
        Me.m_btn32 = New System.Windows.Forms.Button()
        Me.m_btn39 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'm_txb31
        '
        Me.m_txb31.Location = New System.Drawing.Point(12, 12)
        Me.m_txb31.Multiline = True
        Me.m_txb31.Name = "m_txb31"
        Me.m_txb31.ReadOnly = True
        Me.m_txb31.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.m_txb31.Size = New System.Drawing.Size(376, 197)
        Me.m_txb31.TabIndex = 3
        Me.m_txb31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.m_txb31.WordWrap = False
        '
        'm_btn31
        '
        Me.m_btn31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_btn31.Location = New System.Drawing.Point(313, 215)
        Me.m_btn31.Name = "m_btn31"
        Me.m_btn31.Size = New System.Drawing.Size(75, 23)
        Me.m_btn31.TabIndex = 0
        Me.m_btn31.Text = "취소"
        Me.m_btn31.UseVisualStyleBackColor = True
        '
        'm_btn32
        '
        Me.m_btn32.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_btn32.Location = New System.Drawing.Point(232, 215)
        Me.m_btn32.Name = "m_btn32"
        Me.m_btn32.Size = New System.Drawing.Size(75, 23)
        Me.m_btn32.TabIndex = 1
        Me.m_btn32.Text = "확인"
        Me.m_btn32.UseVisualStyleBackColor = True
        '
        'm_btn39
        '
        Me.m_btn39.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_btn39.Location = New System.Drawing.Point(12, 215)
        Me.m_btn39.Name = "m_btn39"
        Me.m_btn39.Size = New System.Drawing.Size(100, 23)
        Me.m_btn39.TabIndex = 2
        Me.m_btn39.Text = "클립보드 복사"
        Me.m_btn39.UseVisualStyleBackColor = True
        '
        'ThAlertWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.m_btn39)
        Me.Controls.Add(Me.m_btn32)
        Me.Controls.Add(Me.m_btn31)
        Me.Controls.Add(Me.m_txb31)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ThAlertWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ThAlertWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents m_txb31 As System.Windows.Forms.TextBox
    Friend WithEvents m_btn31 As System.Windows.Forms.Button
    Friend WithEvents m_btn32 As System.Windows.Forms.Button
    Friend WithEvents m_btn39 As System.Windows.Forms.Button
End Class
