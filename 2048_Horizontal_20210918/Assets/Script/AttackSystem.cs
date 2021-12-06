using UnityEngine;

public class AttackSystem : MonoBehaviour
{

    #region 欄位: 公開
    [Header("攻擊力基底")]
    public float attack = 10;
    [Header("攻擊目標")]
    public GameObject goTarget;
    #endregion

    #region 方法: 公開
    public void Attack() {
        print("發動攻擊，攻擊力為：" +attack);
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
