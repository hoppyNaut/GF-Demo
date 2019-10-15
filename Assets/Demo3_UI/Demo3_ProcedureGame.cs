/****************************************************
    文件：Demo3_ProcedureGame.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo3_ProcedureGame : ProcedureBase 
{
    protected override void OnEnter(ProcedureOwner owner)
    {
        Log.Info("Reach Procedure Game ");
    }
}