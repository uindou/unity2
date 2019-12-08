using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePower : MonoBehaviour
{
    public float force = 100;
    public GameObject shine;
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.tag == "Player") || (collision.gameObject.tag == "Enemy"))
        {
            Debug.Log("プレイヤーに接触");
            ShineOn();
            audioSource.PlayOneShot(sound1);

            Rigidbody otherRigitbody = collision.gameObject.GetComponent<Rigidbody>();　//相手のRigidbodyを取得（？）
            Vector3 forceVector = GetAngleVec(this.gameObject, collision.gameObject);　//力を加える方向の単位ベクトル
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
    
    void ShineOn()
    {
        shine.SetActive(true);
        Invoke("ShineOff", 0.3f);
    }

    void ShineOff()
    {
        shine.SetActive(false);
    }
}
