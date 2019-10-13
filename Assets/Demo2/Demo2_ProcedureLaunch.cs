/****************************************************
    文件：Demo2_ProcedureLaunch.cs
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

public class Demo2_ProcedureLaunch : ProcedureBase 
{
    protected override void OnEnter(ProcedureOwner producedureOwner)
    {
        base.OnEnter(producedureOwner);

        Log.Debug("初始！");

        SceneComponent scene = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();
        //切换场景
        scene.LoadScene("Assets/Demo2/Demo2_Menu.unity", this);
        //切换流程
        ChangeState<Demo2_ProcedureMenu>(producedureOwner);
    }
}