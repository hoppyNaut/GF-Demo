/****************************************************
    文件：Demo3_ProcedureMenu.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Event;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo3_ProcedureMenu:ProcedureBase 
{
    private bool m_StartGame = false;
    private Demo3_UIMenu m_UIMenu = null;

    private UIComponent UI = null;
    private EventComponent Event = null;

    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        //加载框架的UI组件
        UI = GameEntry.GetComponent<UIComponent>();
        //加载框架Event组件
        Event = GameEntry.GetComponent<EventComponent>();
        //订阅UI加载成功事件
        Event.Subscribe(OpenUIFormSuccessEventArgs.EventId, OnOpenUIFormSuccess);
        //加载UI
        UI.OpenUIForm("Assets/Demo3/UI_Menu.prefab", "MenuUIGroup",this);
    }

    protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner,elapseSeconds,realElapseSeconds);

        if(m_StartGame)
        {
            SceneComponent scene = GameEntry.GetComponent<SceneComponent>();
            //获取所有已经加载的场景名
            string[] loadedSceneNames = scene.GetLoadedSceneAssetNames();
            //遍历并删除场景
            foreach (string sceneName in loadedSceneNames)
            {
                scene.UnloadScene(sceneName);
            }
            //加载新场景
            scene.LoadScene("Assets/Demo3/Demo3_Game.unity", this);
            //切换流程
            ChangeState<Demo3_ProcedureGame>(procedureOwner);
        }
    }

    protected override void OnLeave(ProcedureOwner procedureOwner,bool isShutdown)
    {
        base.OnLeave(procedureOwner, isShutdown);

        //取消订阅UI加载成功事件
        Event.Unsubscribe(OpenUIFormSuccessEventArgs.EventId, OnOpenUIFormSuccess);

        if(m_UIMenu != null)
        {
            //关闭UIForm
            UI.CloseUIForm(m_UIMenu.UIForm);
            m_UIMenu = null;
        }
    }

    private void OnOpenUIFormSuccess(object sender,GameEventArgs e)
    {
        OpenUIFormSuccessEventArgs ne = (OpenUIFormSuccessEventArgs)e;
        if(ne.UserData != this)
        {
            return;
        }
        m_UIMenu = (Demo3_UIMenu)ne.UIForm.Logic;
        Log.Debug("UI_Menu：恭喜你，成功的召唤了我");
    }

    public void StartGame()
    {
        m_StartGame = true;
    }
}