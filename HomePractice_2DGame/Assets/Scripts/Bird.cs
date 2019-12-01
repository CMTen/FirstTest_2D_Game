
using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"),Range(50,1000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM, goGround, delGround;

    /// <summary>
    /// 跳躍功能
    /// </summary>
    private void Jump()
    {
        // 如果 按下 左鍵
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("Jump");

            goScore.SetActive(true);
            goGM.SetActive(true);
            goGround.SetActive(true);
            delGround.SetActive(false);
        }
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void PassPipe()
    {

    }

    private void Update()
    {
        Jump();
    }
}
