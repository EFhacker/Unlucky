using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDestroy : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player"; // プレイヤーのタグを設定

    private void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトがプレイヤーの場合
        if (collision.collider.CompareTag(playerTag))
        {
            Destroy(gameObject); // このオブジェクトを削除
        }
    }
}
