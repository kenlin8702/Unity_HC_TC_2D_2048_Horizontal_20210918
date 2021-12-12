using UnityEditor;
using UnityEngine;

public class AttackSystemFar : AttackSystem
{
    [Header("�ͦ��ɤl��m")]
    public Transform positionSpawn;
    [Header("�����ɤl")]
    public GameObject goAttackParticle;
    [Header("�ɤl�o�g�t��")]
    public float speed = 500;
    public override void Attack() {
        base.Attack();

        print("���Z����");

        // �ͦ�
        // �ͦ���
        // Quaternion �|����
        // identity �s����
        GameObject tempAttack = Instantiate(goAttackParticle, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        tempAttack.AddComponent<Bullet>().attack = attack;
    }
}
