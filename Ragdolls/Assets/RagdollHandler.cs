using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollHandler : MonoBehaviour
{
    public bool freeze = false;
    [SerializeField] Rigidbody[] ragdolls;
    [SerializeField] Collider[] colliders;


    void Start()
    {
        ragdolls = GetComponentsInChildren<Rigidbody>();
        colliders = GetComponentsInChildren<Collider>();

    }

    public void SetRagdollEnabled(bool enabled)
    {
        foreach (Rigidbody rb in ragdolls)
        {
            rb.isKinematic = enabled;
        }
        /*
        foreach (Collider coll in colliders)
        {
            coll.enabled = !enabled;
        }
        */
    }

    private void Update()
    {
        SetRagdollEnabled(freeze);
    }
}
