Module Module1
    Public diretorio As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public banco_access = Application.StartupPath & "\Banco_dados\Database.accdb"

    Public Sub Conecta_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            NewMethod()
            MsgBox("Conexão realizado com sucesso !!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO ao conectar !!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub NewMethod()
        db.Open("Provider=Microsoft.ACE.OLEDB.12.0;data source =" & banco_access)
    End Sub

    Sub conecta_banco_sql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;data source =DESKTOP-B2E2GF8\ARTHUR;initial catalog=adsva2_cad;trusted_connection=yes;")
            MsgBox("Conexão realizado com sucesso !!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO ao conectar !!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Module
