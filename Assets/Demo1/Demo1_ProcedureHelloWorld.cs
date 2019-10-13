/****************************************************
    文件：Demo1_ProcedureHelloWorld.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/
using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo1_ProcedureHelloWorld:ProcedureBase 
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        string welcomeMsg = "Hello World!";

        Log.Info(welcomeMsg);
        Log.Warning(welcomeMsg);
        Log.Error(welcomeMsg);
    }
}