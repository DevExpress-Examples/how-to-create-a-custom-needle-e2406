﻿Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace Q269849
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            SkinManager.EnableFormSkins()
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace