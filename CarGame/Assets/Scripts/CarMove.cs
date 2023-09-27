using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;

    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * xSpeed * yAxis);
        transform.Translate(Vector3.right * Time.deltaTime * ySpeed * xAxis);

        cam.transform.position = transform.position + new Vector3(0.0f, 5.0f, -15.0f);
    }
}
