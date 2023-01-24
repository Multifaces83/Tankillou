using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    [SerializeField] protected GameObject bulletBasicPrefab;
    [SerializeField] protected Transform bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void Fire()
    {
        Instantiate(bulletBasicPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}
