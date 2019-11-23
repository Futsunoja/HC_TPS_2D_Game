// 繼承：可以享有繼承類別的成員
public class Pipe : Ground
{
    private void Start()
    {
        // gameObject 指此類別的遊戲物件
        // 刪除(物件，延遲時間)
        //Destroy(gameObject,6f);
    }

    //掛此類別的物件需要有元件：Mesh Renderer
    //在攝影機畫面外的時候會執行一次
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3f);
    }

    //在攝影機畫面內的時候會執行一次
    private void OnBecameVisible()
    {
        
    }
}
