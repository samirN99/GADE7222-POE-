using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private Rigidbody rb;
    private float Acceleration;
    private float Turn;
    [SerializeField] private float speed;
    SFXManager sfx;

    float turningStrength = 180f;

    void Start()
    {
        sfx = FindObjectOfType<SFXManager>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Acceleration = Mathf.Lerp(Acceleration,Input.GetAxisRaw("Vertical") * speed, 2.5f * Time.deltaTime);
        Turn = Input.GetAxisRaw("Horizontal");
        transform.position += transform.forward * Acceleration * Time.deltaTime;

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, Turn * turningStrength * Time.deltaTime * Input.GetAxisRaw("Vertical"), 0f));

    }

    private void FixedUpdate()
    {
        /*if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(transform.forward * speed );
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            sfx.PlaySound("crash");
        }
    }


}
