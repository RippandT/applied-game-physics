using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityHandler : MonoBehaviour
{
    public float gravityStrength = 9.807f;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3 (0.0f, -gravityStrength, 0.0f);
    }
}
