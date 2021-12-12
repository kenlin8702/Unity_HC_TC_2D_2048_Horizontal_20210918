using UnityEngine.UI;
using UnityEngine;
using UnityEditor.Animations;
/// <summary>
/// 血量系統
/// 管理血量、受傷與死亡
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("血量"), Range(0,500)]
    public float hp = 100;
    [Header("要控制的血條")]
    public Text textHP;
    public Image imgHP;
    public Image imgSP;
    [Header("造成傷害的物件標籤")]
    public string tagDamageObject;

    [Header("動畫參數")]
    public string parameterDamage = "TrHit";
    public string parameterDead = "TrDeath";
    private float hpMax;
    private Animator ani;
    private void Awake() {
        hpMax = hp;
        ani = GetComponent<Animator>();
    }
    /// <summary>
    /// 碰撞事件：兩個碰撞器其中一個有勾選 Is Trigger
    /// Enter:碰撞開始執行此事件一次
    /// Collistion 碰到物件的碰撞資訊
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
