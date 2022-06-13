using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{   
    public GameObject Patron;
    public bool incombat;
    public Transform hospital;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (incombat == true)
        {
            Debug.Log("incombat");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("click click boom");
                shoot();
            }
        }
    }
    void shoot()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        GameObject BulletIns = Instantiate(Patron, hospital.position, hospital.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(mousePos * 5, ForceMode2D.Impulse);

    }
}
