Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine("スタート！")
    End Sub

    Private Sub searchBt_Click(sender As Object, e As EventArgs) Handles searchBt.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Good_Click(sender As Object, e As EventArgs) Handles Good.Click
        Dim elem As HtmlElement
        For Each elem In WebBrowser1.Document.GetElementsByTagName("button")
            If elem.GetAttribute("title") = "高く評価" Then
                elem.InvokeMember("Click")
                Exit For
            End If
        Next
    End Sub

    Private Sub Bad_Click(sender As Object, e As EventArgs) Handles Bad.Click
        Dim elem As HtmlElement
        For Each elem In WebBrowser1.Document.GetElementsByTagName("button")
            If elem.GetAttribute("title") = "低く評価" Then
                elem.InvokeMember("Click")
                Exit For
            End If
        Next
    End Sub

    Private Sub RgstChnl_Click(sender As Object, e As EventArgs) Handles RgstChnl.Click
        Dim elem As HtmlElement
        Dim n1 As Long : n1 = 0
        For Each elem In WebBrowser1.Document.GetElementsByTagName("button")
            n1 = InStr(elem.OuterHtml, "yt-uix-button-subscribe-branded")
            If n1 > 0 Then
                elem.InvokeMember("Click")
                Exit For
            End If
            'System.Diagnostics.Debug.WriteLine(elem.InnerHtml)
        Next
    End Sub

    Private Sub NxtBt_Click(sender As Object, e As EventArgs) Handles NxtBt.Click
        Dim elem As HtmlElement
        Dim n1 As Long : n1 = 0
        For Each elem In WebBrowser1.Document.GetElementsByTagName("a")
            'If elem.GetAttribute("class") = "ytp-next-button ytp-button" Then
            '    elem.InvokeMember("Click")
            'End If
            n1 = InStr(elem.OuterHtml, "ytp-next-button ytp-button")
            If n1 > 0 Then
                elem.InvokeMember("Click")
                Exit For
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
