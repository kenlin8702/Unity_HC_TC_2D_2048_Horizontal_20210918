using UnityEngine;
using UnityEngine.UI;

public class AttackSystem : MonoBehaviour
{

    #region ���: ���}
    [Header("�����O��")]
    public float attack = 50;
    [Header("�����ؼ�")]
    public GameObject goTarget;

    [Header("�����O����")]
    public Text TextAttack;
    #endregion

    public void Awake() {
        TextAttack.text = "ATK " + attack;
    }
    #region ��k: ���}
    public virtual void Attack() {
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
