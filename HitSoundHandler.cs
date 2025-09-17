using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSoundHandler : MonoBehaviour
{
    [SerializeField] private AudioSource _hitSound;
    private void OnCollisionEnter(Collision collision)
    {
        _hitSound.Play();
    }
}
