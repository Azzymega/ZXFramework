﻿namespace QWFramework.IntegralsType;

public class CosxdxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        return addon+"sin(x)+c";
    }
}