Public Class Form1
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf ViewListLoad

        ' KeyboardValidation
        AddHandler TxtNumber.KeyPress, AddressOf KeyboardValidation

        ' InputChecked
        AddHandler TxtBox.TextChanged, AddressOf InputChecked
        AddHandler TxtNumber.TextChanged, AddressOf InputChecked

        ' Event for Tambahkan
        AddHandler BtProcess.MouseClick, AddressOf EventProcess
    End Sub

    Private Sub ViewListLoad()
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.Columns.Add("No.", 40)
        ListView1.Columns.Add("Result", -2)
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Columns(0).TextAlign = HorizontalAlignment.Center
    End Sub


    Private Sub KeyboardValidation(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EventProcess()
        Dim listItem As ListViewItem
        listItem = New ListViewItem

        Dim text As String = TxtBox.Text
        Dim jumlah As Integer = TxtNumber.Text

        ClearListView()
        For i = 1 To jumlah
            Dim itemData() As String = {i.ToString(), text}
            Dim newItem As New ListViewItem(itemData)
            ListView1.Items.Add(newItem)
        Next

        InputCheckForClear()
    End Sub

    Private Sub InputChecked(sender As Object, e As EventArgs)
        Dim allInputsValid As Boolean = True

        If String.IsNullOrWhiteSpace(TxtNumber.Text) Then
            allInputsValid = False
        End If

        If String.IsNullOrWhiteSpace(TxtBox.Text) Then
            allInputsValid = False
        End If

        BtProcess.Enabled = allInputsValid
    End Sub

    Private Sub InputCheckForClear()
        BtnClear.Enabled = ListView1.Items.Count > 0
    End Sub

    Private Sub ClearListView()
        ListView1.Items.Clear()
    End Sub

    Private Sub ClearTextInput()
        TxtBox.Text = String.Empty
        TxtNumber.Text = String.Empty
    End Sub

    Private Sub EventExit(sender As Object, e As MouseEventArgs) Handles BtnExit.MouseClick
        End
    End Sub

    Private Sub EventClear(sender As Object, e As MouseEventArgs) Handles BtnClear.MouseClick
        ClearListView()
        ClearTextInput()
        BtnClear.Enabled = False
    End Sub
End Class
