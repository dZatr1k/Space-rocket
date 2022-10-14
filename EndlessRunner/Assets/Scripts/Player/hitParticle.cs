using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitParticle : MonoBehaviour
{
    [SerializeField] private Transform _traget;

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, _traget.position.y, transform.position.z);
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, _traget.position.y, transform.position.z);
    }
}
