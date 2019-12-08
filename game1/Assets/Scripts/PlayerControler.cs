using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject thisObject;
    public float force;　//接触相手に与える力の大きさ
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //接触判定時
    void OnCollisionEnter(Collision collision)
    {   
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("敵に接触");
            audioSource.PlayOneShot(sound1);

            Rigidbody otherRigitbody = collision.gameObject.GetComponent<Rigidbody>(); //相手のRigidbodyを取得（？）
            Vector3 forceVector = GetAngleVec(thisObject, collision.gameObject); //力を加える方向の単位ベクトル
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
