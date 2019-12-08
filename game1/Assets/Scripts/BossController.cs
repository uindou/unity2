using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject player;
    public GameObject thisObject;
    public float accele;
    public float force;　//接触相手に与える力の大きさ
    float atktime;
    public float atkforce;　//攻撃時にプレイヤーに向かっていく力

    Rigidbody enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.GetComponent<Rigidbody>();

        atktime = Random.Range(3f, 15f);
        Invoke("Attack", atktime);
    }

    // Update is called once per frame
    void Update()
    {
        var direction = player.transform.position - transform.position;
        direction.Normalize();
        enemy.AddForce(direction * accele, ForceMode.Acceleration);
    }

    //たまに攻撃してくる
    void Attack()
    {
        var direction = player.transform.position - transform.position;
        direction.Normalize();
        enemy.AddForce(direction * atkforce, ForceMode.Acceleration);
        Debug.Log("attack!");
        atktime = Random.Range(3f, 10f);
        Invoke("Attack", atktime);
    }

    //接触判定時
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーに接触");

            Rigidbody otherRigitbody = collision.gameObject.GetComponent<Rigidbody>();　//相手のRigidbodyを取得（？）
            Vector3 forceVector = GetAngleVec(thisObject, collision.gameObject);　//力を加える方向の単位ベクトル
            otherRigitbody.AddForce(forceVector * force, ForceMode.Impulse); //単位ベクトルに力の大きさをかけてインパルスを与える

            //自分から相手に向かう単位ベクトルを作成
            Vector3 GetAngleVec(GameObject from, GameObject to)
            {
                Vector3 fromVec = new Vector3(from.transform.position.x, 0, from.transform.position.z);
                Vector3 toVec = new Vector3(to.transform.position.x, 0, to.transform.position.z);
                return Vector3.Normalize(toVec - fromVec);
            }
        }
    }
}
