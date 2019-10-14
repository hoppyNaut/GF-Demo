/****************************************************
    文件：Demo4_ProcedureLanuch.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Demo4_Lanuch
*****************************************************/

using UnityEngine;
using GameFramework;
using GameFramework.DataTable;
using GameFramework.Event;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo4_ProcedureLanuch : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        //获取框架事件组件
        EventComponent Event = GameEntry.GetComponent<EventComponent>();
        //获取框架数据表组件
        DataTableComponent DataTable = GameEntry.GetComponent<DataTableComponent>();
        //订阅数据表加载成功事件
        Event.Subscribe(UnityGameFramework.Runtime.LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
        DataTable.LoadDataTable<DRHero>("Hero", "Assets/Demo4/Hero2.txt");
    }

    private void OnLoadDataTableSuccess(object sender, GameEventArgs e)
    {
        //获取框架数据表组件
        DataTableComponent DataTable = GameEntry.GetComponent<DataTableComponent>();
        //获得数据表
        IDataTable<DRHero> dtScene = DataTable.GetDataTable<DRHero>();

        //获得所有行
        DRHero[] drHeros = dtScene.GetAllDataRows();
        Log.Debug("drHeros：" + drHeros.Length);
        //根据行号获取某一行
        DRHero drScene = dtScene.GetDataRow(1);
        //DRHero drScene = drHeros[1];
        if(drScene != null)
        {
            string name = drScene.Name;
            int atk = drScene.Atk;
            Log.Debug("name：" + name + "，atk：" + atk);
        }
        else
        {
            Log.Debug("index not exist");
        }
        //获取满足条件的所有行
        DRHero[] drScenesWithCondition = dtScene.GetAllDataRows(x => x.Id > 0);

        //获取满足条件的第一行
        DRHero drFirstSceneWithCondition = dtScene.GetDataRow(x => x.Name == "mutou");
    }
}