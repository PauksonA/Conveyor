using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    private  Rigidbody _rb;
    [SerializeField] private float _speed;
    public Material mt;
    

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }



    public void FixedUpdate()
    {
        mt.mainTextureOffset = new Vector2(Time.time * 10 * Time.deltaTime, 0f);
        Vector3 pos = _rb.position;
        _rb.position += Vector3.forward * _speed * Time.fixedDeltaTime;
        _rb.MovePosition(pos);
    }
}


    