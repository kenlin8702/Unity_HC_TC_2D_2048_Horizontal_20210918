using UnityEngine;

public class AttackSystem : MonoBehaviour
{

    #region ���: ���}
    [Header("�����O��")]
    public float attack = 10;
    [Header("�����ؼ�")]
    public GameObject goTarget;
    #endregion

    #region ��k: ���}
    public void Attack() {
        print("�o�ʧ����A�����O���G" +attack);
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
