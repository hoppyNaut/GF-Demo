/****************************************************
    文件：DRHero.cs
	作者：Shen
    邮箱: 879085103@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using System.Collections;
using UnityEngine;
using GameFramework;
using GameFramework.DataTable;

public class DRHero : IDataRow
{
    public int Id { get; protected set; }
    public string Name { get; private set; }
    public int Atk { get; private set; }

    public void ParseDataRow(string dataRowText)
    {
        string[] text = dataRowText.Split('\t');
        int index = 0;
        index++;    //跳过注释列
        Id = int.Parse(text[index++]);
        Name = text[index++];
        Atk = int.Parse(text[index++]);
    }
}