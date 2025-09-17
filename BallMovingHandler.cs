using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using static UnityEngine.GraphicsBuffer;

public class BallMovingHandler : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private GameObject _target;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _ball;
    [SerializeField] private GameObject _whereInstantiate;
    private void Update()
    {
        
        _timer -= Time.deltaTime;

        if (_timer <= 0.1)
        {
            GameObject newBall = Instantiate(_ball, _whereInstantiate.transform.position, Quaternion.identity);
            Color randomColour = Random.ColorHSV();

            MeshRenderer my_renderer = newBall.GetComponent<MeshRenderer>();
            my_renderer.material.color = randomColour;

            newBall.GetComponent<Rigidbody>().AddForce((_target.transform.position - transform.position).normalized * _force, ForceMode.Impulse);
            _timer = 6;
        }
    }
}
