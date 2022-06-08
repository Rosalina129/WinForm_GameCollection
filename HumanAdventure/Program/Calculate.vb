﻿Imports System.Threading
Public Class Calculate
    'This scheme uses the damage calculation system of American RPG.
    '一次攻击结算伤害=攻击者输出伤害*(1-防御值物免率)

    '防御值物免率换算方法1：

    '防御值物免率=1-1/(1+防守者防御总值/10)
    Public Shared Function ADCount(hp As Integer, a As Integer, ed As Integer, crate As Double, cdmg As Double, eleS As Integer, eleT As Integer)
        Dim r1 As New Random
        Thread.Sleep(1)             'Force pausing the program process for 1 ms to refresh random seed values.
        Dim c As Double
        c = r1.NextDouble()         'Critical Rate Random Pools
        Dim Defenseinv As Double
        Defenseinv = 1 - 1 / (1 + ed / 10)
        If c >= 1 - crate Then
            Return hp - a * (1 - Defenseinv) * (1 + cdmg)
        Else
            Return hp - a * (1 - Defenseinv)
        End If
    End Function
End Class