Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ComboBox에 초기 항목을 추가
        ComboBox1.Items.Add("Category 1")
        ComboBox1.Items.Add("Category 2")
        ComboBox1.Items.Add("Category 3")
    End Sub

    ' ComboBox 텍스트 클릭 이벤트 핸들러
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ' ComboBox의 선택된 항목에 따라 ListBox의 항목 갱신
        UpdateListBoxItems()
    End Sub

    ' ComboBox의 선택이 변경될 때 ListBox의 항목 갱신
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        UpdateListBoxItems()
    End Sub

    ' Button 클릭 이벤트 핸들러
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ListBox에서 선택된 항목의 이름을 팝업으로 표시
        If ListBox1.SelectedItem IsNot Nothing Then
            MessageBox.Show("Selected Item: " & ListBox1.SelectedItem.ToString())
        Else
            MessageBox.Show("Please select an item from the list.")
        End If
    End Sub

    Private Sub UpdateListBoxItems()
        ListBox1.Items.Clear()

        Select Case ComboBox1.SelectedItem
            Case "Category 1"
                ListBox1.Items.Add("Item 1-1")
                ListBox1.Items.Add("Item 1-2")
                ListBox1.Items.Add("Item 1-3")
            Case "Category 2"
                ListBox1.Items.Add("Item 2-1")
                ListBox1.Items.Add("Item 2-2")
                ListBox1.Items.Add("Item 2-3")
            Case "Category 3"
                ListBox1.Items.Add("Item 3-1")
                ListBox1.Items.Add("Item 3-2")
                ListBox1.Items.Add("Item 3-3")
        End Select
    End Sub

End Class
