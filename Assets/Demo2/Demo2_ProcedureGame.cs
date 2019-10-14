/****************************************************
    文件：Demo2_ProcedureGame.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
using System.Collections;
using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo2_ProcedureGame : ProcedureBase 
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        Log.Debug("进入游戏流程，可以在这里处理游戏逻辑，日志不会打印，因为没有切换到Game流程");
    }
}