using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed;
    private Rigidbody rb;

    public float lifeTime = 10f;     //How many seconds(or fraction thereof) this object will survive
    private bool timeToDie = false;    //The object's trigger of its inevitable DEATH!!!

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Time.deltaTime * bulletSpeed);
    }

    void Update()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0.0f)
        {
            timeToDie = true;
        }

        if (timeToDie == true)
        {
            Destroy(gameObject);
        }
    }
}
