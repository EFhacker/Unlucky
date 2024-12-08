using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveClosetDoor : MonoBehaviour
{
    public string doorTag = "ClosetDoor"; // ドアのタグ名を指定

    void Update()
    {
        // Aボタンが押された場合
        if (Input.GetKeyDown(KeyCode.JoystickButton0)) // "JoystickButton0" はAボタン
        {
            RemoveDoor();
        }
    }

    void RemoveDoor()
    {
        // タグを使ってドアオブジェクトを探す
        GameObject closetDoor = GameObject.FindWithTag(doorTag);
        if (closetDoor != null)
        {
            Destroy(closetDoor); // ドアオブジェクトを削除
            Debug.Log("Closet door has been destroyed!");
        }
        else
        {
            Debug.LogWarning("No object with the tag " + doorTag + " was found.");
        }
    }
}
