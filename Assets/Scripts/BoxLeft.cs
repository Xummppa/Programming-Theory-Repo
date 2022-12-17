using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BoxLeft : BoxCenter
{
    // POLYMORPHISM
    public override void GenerateBoxName()
    {
        if (DataSaver.Instance && TextLabel)
        {
            TextLabel.text = DataSaver.Instance.PlayerName + " - left";
        }
    }
}
