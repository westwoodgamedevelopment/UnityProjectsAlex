using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{

    float vertical = Input.GetAxis("vertical");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.position.x, transform.position.y, transform.position.z+1);
    }
}
