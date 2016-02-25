Imports System

Namespace App
    Public Class Person
        Public name As [String]
        Public age As Integer

        Public Sub New()
        End Sub

        Public Sub New(n As [String], a As Integer)
            name = n
            age = a
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("name: {0}; age: {1}", name, age)
        End Function
    End Class
End Namespace