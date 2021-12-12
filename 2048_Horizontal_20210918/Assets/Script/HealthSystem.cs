using UnityEngine.UI;
using UnityEngine;
using UnityEditor.Animations;
/// <summary>
/// ��q�t��
/// �޲z��q�B���˻P���`
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("��q"), Range(0,500)]
    public float hp = 100;
    [Header("�n������")]
    public Text textHP;
    public Image imgHP;
    public Image imgSP;
    [Header("�y���ˮ`���������")]
    public string tagDamageObject;

    [Header("�ʵe�Ѽ�")]
    public string parameterDamage = "TrHit";
    public string parameterDead = "TrDeath";
    private float hpMax;
    private Animator ani;
    private void Awake() {
        hpMax = hp;
        ani = GetComponent<Animator>();
    }
    /// <summary>
    /// �I���ƥ�G��ӸI�����䤤�@�Ӧ��Ŀ� Is Trigger
    /// Enter:�I���}�l���榹�ƥ�@��
    /// Collistion �I�쪫�󪺸I����T
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == tagDamageObject) Hurt(10);
    }
    public void Hurt(float damage) {
        if (hp <= 0) return;
        hp -= damage;
        hp = Mathf.Clamp(hp, 0, hpMax);
        textHP.text = "HP " + hp;
        imgHP.fillAmount = hp / hpMax;
        imgSP.fillAmount = hp / hpMax;
        ani.SetTrigger(parameterDamage);
        if (hp <= 0) Dead();
    }
    public void Dead() {
        ani.SetTrigger(parameterDead);
    }
}
