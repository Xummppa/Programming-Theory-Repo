using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class BoxCenter : MonoBehaviour
{
    public TextMeshProUGUI TextLabel;

    // INHERITANCE
    void Awake()
    {
        GenerateBoxName();
        this.gameObject.transform.localScale = new Vector3(1, 2, 1);
    }

    public virtual void GenerateBoxName()
    {
        if (DataSaver.Instance && TextLabel)
        {
            TextLabel.text = DataSaver.Instance.PlayerName + " - center";
        }
    }
}
