// 子類別繼承父類別
// 可享有所有父類別成員

public class Pipe : Ground
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 2);
    }
}
