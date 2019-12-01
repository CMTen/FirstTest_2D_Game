using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform tranA;
    public Transform tranB;

    public SpriteRenderer spriteA;

    private void Start()
    {
        print("輸出");

        print(Random.value);
        print(Mathf.PI);

        // 靜態方法：類別.方法(對應的參數);
        print("隨機範圍：" + Random.Range(50.5f, 100.9f));

        Debug.Log(true);
        Debug.LogWarning("警告");
        Debug.LogError("錯誤");

        print(tranA.position);

        tranA.position = new Vector3(0, -0.5f, 0);

        tranA.localScale = new Vector3(5, 5, 5);

        spriteA.flipX = true;
    }

    private void Update()
    {
        print(Input.inputString);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("Jump");
        }

        tranA.Rotate(0, 0, 10);
    }
}
