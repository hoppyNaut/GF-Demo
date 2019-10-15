/****************************************************
    文件：Demo5_CubeEntityLogic.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using GameFramework;
using UnityGameFramework.Runtime;

public class Demo5_CubeEntityLogic : EntityLogic 
{
    protected override void OnShow(object userData)
    {
        base.OnShow(userData);

        Log.Debug("显示实体CubeEntity");
    }
}