using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public TextMeshProUGUI ammoCountLabel;
    public GameObject gun;
    public GameObject gunBarrel;
    public GameObject muzzleFlareObject;

    private ParticleSystem muzzleFlareParticle;

    public GameObject bullet;

    public int magazineSize;
    public float firingSpeed;

    private int ammoCount;

    private float timeSinceLast;

    // Start is called before the first frame update
    void Start()
    {
        Reload();
        timeSinceLast = 0;


        muzzleFlareParticle = muzzleFlareObject.GetComponent<ParticleSystem>();
       
    }

    void Reload()
    {
        ammoCount = magazineSize;
    }

    void ShootBullet()
    {
        ammoCount -= 1;
        Instantiate(bullet, gunBarrel.transform.position, transform.rotation);
        timeSinceLast = 0;
        muzzleFlareParticle.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && timeSinceLast >= firingSpeed)
        {
            ShootBullet();
        }
        ammoCountLabel.text = "Bullet Count: " + ammoCount;
        timeSinceLast += Time.deltaTime;
    }
}
