using System;
using UnityEngine;
public class TileInfo_Inverse : TileInfo
{
    public override void TileEvent()
    {
        Debug.Log($"index of this tile : {index}, inverse 1");
        DicePlayManager.instance.direction = -1;
    }
}
