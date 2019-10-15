/****************************************************
    文件：Demo5_ProcedureLanuch.cs
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

public class Demo5_ProcedureLanuch : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);

        //获取框架实体组件
        EntityComponent entityComponent = GameEntry.GetComponent<EntityComponent>();

        //创建实体
        entityComponent.ShowEntity<Demo5_CubeEntityLogic>(1, "Assets/Demo5_Entity/CubeEntity.prefab", "EntityGroup");
    }
}