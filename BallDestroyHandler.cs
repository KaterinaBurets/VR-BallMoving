using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyHandler : MonoBehaviour
{
    [SerializeField] private float _force;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bat") == true)
        {
            var rb = GetComponent<Rigidbody>();
            GetComponent<Rigidbody>().AddForce(rb.velocity * _force);
            Destroy(gameObject, 1f);
        }   
    }
}
