using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 定義方法 Method (宣告函式、功能)
    // 語法：
    // 修飾詞 方法傳回類型 方法名稱 () { }
    // void 無傳回
    private void Test()
    {

    }

    /// <summary>
    /// 小鳥飛。
    /// </summary>
    private void Bird()
    {
        print("FlyFlyFly");
    }

    private void Start()
    {
        // 呼叫方法
        Bird();
    }
}
