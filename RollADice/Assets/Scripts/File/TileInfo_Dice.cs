using System;
using UnityEngine;
public class TileInfo_Dice : TileInfo
{
    public DicePlayManager manager;
    public override void TileEvent()
    {
        Debug.Log($"index of this tile : {index}, increase dice num +1");
        DicePlayManager.instance.diceNum++;
    }
}