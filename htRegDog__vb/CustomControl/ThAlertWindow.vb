Imports System
Imports System.Windows.Forms




Public NotInheritable Class ThAlertWindow
    Public Sub New()
        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub



    ''' <summary>
    ''' Load 이벤트
    ''' </summary>
    ''' <param name="tea"></param>
    Protected Overrides Sub OnLoad(tea As EventArgs)
        MyBase.OnLoad(tea)

        Text = m_title
        m_txb31.Text = m_msg
        AddHandler m_btn39.Click, AddressOf prBtn39Click
        AddHandler m_btn32.Click, AddressOf prBtn32Click
        AddHandler m_btn31.Click, AddressOf prBtn31Click
    End Sub



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tsd"></param>
    ''' <param name="tea"></param>
    Private Sub prBtn39Click(tsd As Object, tea As EventArgs)
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tsd"></param>
    ''' <param name="tea"></param>
    Private Sub prBtn32Click(tsd As Object, tea As EventArgs)
        DialogResult = DialogResult.Yes
        Close()
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tsd"></param>
    ''' <param name="tea"></param>
    Private Sub prBtn31Click(tsd As Object, tea As EventArgs)
        DialogResult = DialogResult.No
        Close()
    End Sub




    ''' <summary>
    ''' 단축키 입력
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <param name="keyData"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            prBtn31Click(Nothing, Nothing)
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function



    Private m_title As String
    Private m_msg As String

    Public Overloads Function ShowDialog(
            Owner As IWin32Window, title As String, msg As String) As DialogResult
        m_title = If(String.IsNullOrWhiteSpace(title), "알림", title)
        m_msg = msg
        ShowDialog(Owner)

        Return DialogResult
    End Function

End Class