using UnityEngine;

public class LearAPI : MonoBehaviour
{
    public Transform transformA;
    public Transform transformB;
    public Camera Camera;

    private void Start()
    {
        // 使用靜態成員 - 屬性
        print("隨機:" + Random.value);

        // 使用靜態成員 - 屬性  數學類別.PI (Mathf)
        print("PI:" + Mathf.PI);

        // 使用靜態成員 - 方法
        print("隨機範圍:" + Random.Range(1, 10));
        print("絕對值:" + Mathf.Abs(-99));

        // 非靜態成員
        // 需要先給予欄位存放實體物件
        print("物件A的座標:" + transformA.position);

        transformB.position = new Vector3(-2, 0, 0);
        print("物件B的座標:" + transformB.position);

        print("攝影機位置:" + Camera.depth);
    }

    private void Update()
    {
        // 非靜態成員 - 方法
        transformB.Rotate(0, 0, 10);
    }
}
