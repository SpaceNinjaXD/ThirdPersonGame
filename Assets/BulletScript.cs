using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float m_Thrust;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * m_Thrust);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
