using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Windows.Speech;

[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{

    [SerializeField] float speed = 5.0f;
    private Collider coll;
    private Rigidbody rb;

    void Start()
    {
        coll = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);

        if (collision == null) { return; }

        RagdollHandler rgd = collision.gameObject.GetComponentInParent<RagdollHandler>();

        if (rgd != null) { return; }

        rgd.freeze = false;
        Debug.Log(rgd.freeze);
    }
}
