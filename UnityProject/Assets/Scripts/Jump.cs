using UnityEngine;

public class Jump : MonoBehaviour
{
    [Header("跳躍高度"),Range(1,2000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;
}
