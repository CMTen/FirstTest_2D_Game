using UnityEngine;

public class BackGround : MonoBehaviour
{
    [Header("速度"), Range(0, 100.5f)]
    public float speed = 0.05f;

    [Header("移動")]
    public Transform tran;

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void Move()
    {
        // Time.deltaTime 一幀的時間
        tran.Translate(-speed * Time.deltaTime, 0, 0);
    }

    private void Update()
    {
        Move();
    }
}
