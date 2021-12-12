using UnityEditor;
using UnityEngine;

public class AttackSystemFar : AttackSystem
{
    [Header("ネΘ采竚")]
    public Transform positionSpawn;
    [Header("ю阑采")]
    public GameObject goAttackParticle;
    [Header("采祇甮硉")]
    public float speed = 500;
    public override void Attack() {
        base.Attack();

        print("环禯ю阑");

        // ネΘ
        // ネΘ
        // Quaternion じ计
        // identity 箂à
        GameObject tempAttack = Instantiate(goAttackParticle, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        tempAttack.AddComponent<Bullet>().attack = attack;
    }
}
