using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 10.0f;
    private float _lifeTime = 3.0f;
    private float _distance = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Launch(transform.right);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //add force to bullet
    public void Launch(Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(direction * _speed, ForceMode.Impulse);
        Destroy(gameObject, _lifeTime);
    }
    //destroy bullet when it hits something
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
   
   
}
