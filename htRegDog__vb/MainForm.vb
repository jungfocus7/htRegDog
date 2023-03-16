Imports System
Imports System.Configuration
Imports System.Drawing
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Xml

Public NotInheritable Class MainForm
    ''' <summary>
    ''' 생성자
    ''' </summary>
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

        Text = "htRegDog  v1.01b"
        MinimumSize = Size
        AllowDrop = False


        '모니터다 듀얼 이상일때
        Dim tcs As Screen = Screen.FromPoint(Cursor.Position)
        Dim tsb As Rectangle = tcs.WorkingArea
        Dim tlp As Point = New Point(tsb.Right, tsb.Bottom)
        Dim tws As Size = Size
        tlp.Offset(-(tws.Width + 10), -(tws.Height + 10))
        Location = tlp


        prReadyForInit()
    End Sub



    ''' <summary>
    ''' 초기화 준비
    ''' </summary>
    Private Sub prReadyForInit()
        'm_txb91, m_txb81, m_txb71
        'm_btn91, m_btn81

        'm_txb91.Text = "yyyy/MM/dd HH:mm:ss.fff"
        ''m_txb81.Text = "/y+|M+|d+|H+|m+|s+|f+/imecsprat"
        'm_txb81.Text = "/y+|M+|d+|H+|m+|s+|f+/imesprt"
        'm_txb71.Text = String.Empty

        Dim txd As New XmlDocument()
        txd.Load(".\DefaultData.xml")
        m_txb91.Text = txd.SelectSingleNode("Root/Body").InnerText
        m_txb81.Text = txd.SelectSingleNode("Root/Regex").InnerText
        m_txb71.Text = String.Empty


        AddHandler m_btn81.Click, AddressOf prBtn81Click
    End Sub



    ''' <summary>
    ''' ^\/(.+)\/g?i?m?s?u?y?$
    ''' </summary>
    ''' <param name="tsd"></param>
    ''' <param name="tea"></param>
    Private Sub prBtn81Click(tsd As Object, tea As EventArgs)
        Dim strInput As String = m_txb91.Text
        Dim strReg As String = m_txb81.Text
        strInput = strInput.Trim()
        strReg = strReg.Trim()

        m_txb71.Clear()
        Dim mts As MatchCollection = prGetMatches(strInput, strReg)
        If (Not mts Is Nothing) AndAlso (mts.Count > 0) Then
            Dim tn As Integer = 1
            For Each mt As Match In mts
                Dim tgx As String = String.Format("{0}
(Num: {1}, Index: {2}, Length: {3})
", mt.Value, tn, mt.Index, mt.Length)
                m_txb71.AppendText(tgx & vbNewLine)
                tn += 1
            Next
        End If
    End Sub




    Private Function prGetMatches(strInput As String, strReg As String) As MatchCollection
        Try
            Dim re1 As String = "^\/(.+)\/([imecsprat]*$)"
            'Dim re1 As String = "^\/(.+)\/(?![imecsprat]*([imecsprat])[imecsprat]*\1)[imecsprat]+$"
            Dim mt As Match = Regex.Match(strReg, re1)
            If mt.Success = False Then
                Return Nothing
            End If

            Dim flags As String = mt.Groups(2).Value
            strReg = mt.Groups(1).Value

            Dim ops As RegexOptions = RegexOptions.None
            If Not String.IsNullOrWhiteSpace(flags) Then
                For Each tc As Char In flags
                    If tc = "i"c Then
                        ops = ops Or RegexOptions.IgnoreCase
                    ElseIf tc = "m"c Then
                        ops = ops Or RegexOptions.Multiline
                    ElseIf tc = "e"c Then
                        ops = ops Or RegexOptions.ExplicitCapture
                    ElseIf tc = "c"c Then
                        ops = ops Or RegexOptions.Compiled
                    ElseIf tc = "s"c Then
                        ops = ops Or RegexOptions.Singleline
                    ElseIf tc = "p"c Then
                        ops = ops Or RegexOptions.IgnorePatternWhitespace
                    ElseIf tc = "r"c Then
                        ops = ops Or RegexOptions.RightToLeft
                    ElseIf tc = "a"c Then
                        ops = ops Or RegexOptions.ECMAScript
                    ElseIf tc = "t"c Then
                        ops = ops Or RegexOptions.CultureInvariant
                    End If
                Next
            End If

            If ops = RegexOptions.None Then
                Return Regex.Matches(strInput, strReg)
            Else
                Return Regex.Matches(strInput, strReg, ops)
            End If
        Catch
            Return Nothing
        End Try
    End Function



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            If ActiveControl Is m_txb81 Then
                prBtn81Click(Nothing, Nothing)
                Return True
            End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function



End Class






