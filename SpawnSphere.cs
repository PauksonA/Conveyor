using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnSphere;

    private void Start()
    {
        Instantiate(_template, _spawnSphere.position, Quaternion.identity);
    }
}
