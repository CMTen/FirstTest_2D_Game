
using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"),Range(50,1000)]
    public int jump = 450;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM, goGround, delGround;
    [Header("剛體")]
    public Rigidbody2D r2d;

    public GameManager gm;

    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip audJump, audHit, audAdd;

    /// <summary>
    /// 跳躍功能
    /// </summary>
    private void Jump()
    {
        if (dead) return;

        // 如果 按下 左鍵
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("Jump");

            goScore.SetActive(true);     // 分數顯示
            goGM.SetActive(true);        // GM顯示
            goGround.SetActive(true);
            delGround.SetActive(false);

            r2d.gravityScale = 2f;
            r2d.Sleep();
            r2d.AddForce(new Vector2(0, jump));   // 剛體, 增加推力

            aud.PlayOneShot(audJump, 0.25f);
        }

        r2d.SetRotation(4.5f * r2d.velocity.y);    // velocity 剛體加速度
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        if (dead) return;

        dead = true;
        gm.GameOver();
        aud.PlayOneShot(audHit, 0.5f);
    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void PassPipe()
    {
        if (dead) return;

        print("+1");

        gm.AddScore(1);
    }

    private void Update()
    {
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "移動地板")
        {
            Dead();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "水管 - 上" || collision.gameObject.name == "水管 - 下")
        {
            Dead();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "加分區域")
        {
            PassPipe();
            aud.PlayOneShot(audAdd, 0.25f);
        }
    }
}
