Imports System
Imports System.Threading
Imports Thinknode

Namespace App

    Class App
        Inherits Provider
        ' ***
        ' REPLACE THE METHODS WITHIN THESE MARKERS WITH THE METHODS DEFINED IN YOUR MANIFEST.
        ' ***

        ''' <summary>
        ''' Add the specified integers a and b.
        ''' </summary>
        ''' <returns>The result of adding a and b.</returns>
        ''' <param name="a">The integer a.</param>
        ''' <param name="b">The integer b.</param>
        Public Shared Function Add(a As Integer, b As Integer) As Integer
            Return a + b
        End Function

        ''' <summary>
        ''' Adds the specified integers while reporting progress.
        ''' </summary>
        ''' <returns>The result of adding a and b.</returns>
        ''' <param name="a">The integer a.</param>
        ''' <param name="b">The integer b.</param>
        ''' <param name="progress">The progress callback.</param>
        Public Shared Function AddWithProgress(a As Integer, b As Integer, progress As ProgressDelegate) As Integer
            progress(0.25F, "25%")
            Thread.Sleep(1000)
            progress(0.5F, "50%")
            Thread.Sleep(1000)
            progress(0.75F, "75%")
            Thread.Sleep(1000)
            Return a + b
        End Function

        ''' <summary>
        ''' Reports a failure before adding the integers.
        ''' </summary>
        ''' <returns>The result of adding a and b.</returns>
        ''' <param name="a">The integer a.</param>
        ''' <param name="b">The integer b.</param>
        ''' <param name="fail">The failure callback.</param>
        Public Shared Function AddWithFailure(a As Integer, b As Integer, fail As FailureDelegate) As Integer
            fail("my_error", "This is a test of the error functionality")
            Return a + b
        End Function

        ''' <summary>
        ''' Computes the average age given the specified list of Person objects.
        ''' Note: This function's purpose is to demonstrate the MessagePack Serialization
        ''' and Deserialization of the Person class.
        ''' </summary>
        ''' <returns>The average age</returns>
        ''' <param name="list">A list of Person objects.</param>
        Public Shared Function AverageAge(list As Person()) As Double
            Dim running_avg As Double = 0
            Dim count As Integer = 0
            For i As var = 0 To list.Length - 1
                running_avg = ((running_avg * count) + list(i).age) / (count + 1)
                count += 1
            Next
            Return running_avg
        End Function

        ''' <summary>
        ''' Gets the length of the byte array.
        ''' </summary>
        ''' <returns>The byte array length.</returns>
        ''' <param name="arr">The byte array.</param>
        Public Shared Function GetByteArrayLength(arr As Byte()) As Integer
            Return arr.Length
        End Function

        ''' <summary>
        ''' Gets the year component of the given datetime value.
        ''' </summary>
        ''' <returns>The year.</returns>
        ''' <param name="val">The datetime value.</param>
        Public Shared Function GetYear(val As DateTime) As UInteger
            Return Convert.ToUInt32(val.Year)
        End Function

        ' ***
        ' REPLACE THE METHODS WITHIN THESE MARKERS WITH THE METHODS DEFINED IN YOUR MANIFEST.
        ' ***

        ''' <summary>
        ''' MODIFY THIS MAIN METHOD WITH CARE.
        ''' The entry point of the program, where the program control starts and ends.
        ''' </summary>
        ''' <param name="args">The command-line arguments.</param>
        Public Shared Sub Main(args As String())
            ' Create App instance.
            Dim app As New App()

            ' Start app.
            app.Start()
        End Sub
    End Class
End Namespace