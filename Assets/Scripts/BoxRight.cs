using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxRight : BoxCenter
{
    // POLYMORPHISM
    public override void GenerateBoxName()
    {
        if (DataSaver.Instance && TextLabel)
        {
            TextLabel.text = DataSaver.Instance.PlayerName + " - right";
        }
    }
}
