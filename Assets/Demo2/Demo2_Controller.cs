/****************************************************
    文件：Demo2_Controller.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

public class Demo2_Controller : MonoBehaviour 
{
    public void EnterGame()
    {
        SceneComponent scene = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();
        //卸载所有场景
        string[] loadedSceneNames = scene.GetLoadedSceneAssetNames();
        foreach(string name in loadedSceneNames)
        {
            scene.UnloadScene(name);
        }
        //加载游戏场景
        scene.LoadScene("Assets/Demo2/Demo2_Game.unity", this);
        
    }
}