using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    public float dx;
    public float xStart;
    public float force;
    public GameObject thisObject;
    public float zEnd;
    public float timer;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        thisObject.SetActive(true);
        this.transform.localPosition = new Vector3(xStart, 1, 0);
        dx = Random.Range(0.2f, 0.5f);
        timer = Random.Range(3f, 7f);

    }
        
    void Update()
    {
        // dxは任意の値
        Transform MoveForward = this.gameObject.transform;

        // そのオブジェクトから見て前方向に0.5だけ移動
        MoveForward.Translate(Vector3.forward * dx);

        if(this.gameObject.transform.localPosition.z >= zEnd)
        {
            
            thisObject.SetActive(false);
            Invoke("Start", timer);
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Enemy") || (collision.gameObject.tag == "Player"))
        {
            audioSource.PlayOneShot(sound1);
            Rigidbody otherRigitbody = collision.gameObject.GetComponent<Rigidbody>(); //相手のRigidbodyを取得（？）
            Vector3 forceVector = GetAngleVec(thisObject, collision.gameObject); //力を加える方向の単位ベクトル
            otherRigitbody.AddForce(forceVector * force, ForceMode.Impulse); //単位ベクトルに力の大きさをかけてインパルスを与える

            //自分から相手に向かう単位ベクトルを作成
            Vector3 GetAngleVec(GameObject from, GameObject to)
            {
                Vector3 fromVec = new Vector3(from.transform.position.x, 0, from.transform.position.z);
                Vector3 toVec = new Vector3(to.transform.position.x, 100, to.transform.position.z);
                return Vector3.Normalize(toVec - fromVec);
            }
        }
    }
}
