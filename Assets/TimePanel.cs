using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedUIPanel : MonoBehaviour
{
    [SerializeField] private GameObject panel; // 表示するUIパネル
    [SerializeField] private float displayDuration = 5f; // 表示する時間（秒）

    private void Start()
    {
        // パネルを表示
        panel.SetActive(true);

        // 指定時間後にパネルを非表示
        Invoke("HidePanel", displayDuration);
    }

    private void HidePanel()
    {
        panel.SetActive(false);
    }
}
