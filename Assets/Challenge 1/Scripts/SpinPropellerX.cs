using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Private Variables
    private float propellerRoatation = 10.0f;
    public float speed = 30.0f;
    private Vector3 Vz = new Vector3(0, 0, 1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vz * speed * Time.deltaTime * propellerRoatation);
    }
}
