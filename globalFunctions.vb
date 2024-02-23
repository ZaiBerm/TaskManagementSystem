Imports System.IO

Module globalFunctions

    Public Function ToImage(ImageData As Byte())

        Using mem As New MemoryStream(ImageData)
            Return Image.FromStream(mem)
        End Using

    End Function

End Module
