/****************************************************
    文件：Demo3_ProcedureLaunch.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo3_ProcedureLaunch : ProcedureBase 
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        SceneComponent scene = GameEntry.GetComponent<SceneComponent>();
        //切换场景
        scene.LoadScene("Assets/Demo3/Demo3_Menu.unity", this);
        //切换流程
        ChangeState<Demo3_ProcedureMenu>(procedureOwner);
    }
}