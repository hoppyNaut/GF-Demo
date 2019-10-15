/****************************************************
    文件：Demo3_UIMenu.cs
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

public class Demo3_UIMenu : UIFormLogic 
{
    private Demo3_ProcedureMenu m_ProcedureMenu = null;

    public void OnEnterBtnClik()
    {
        m_ProcedureMenu.StartGame();
    }

    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);

        m_ProcedureMenu = (Demo3_ProcedureMenu)userData;
        if(m_ProcedureMenu == null)
        {
            Log.Warning("ProcedureMenu is invalid when openMenuForm.");
            return;
        }

    }
    protected override void OnClose(object userData)
    {
        m_ProcedureMenu = null;
        base.OnClose(userData);
    }
}