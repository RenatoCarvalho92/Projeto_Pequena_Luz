using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class EsferaDeLuzLerp : MonoBehaviour
{
    [SerializeField]
    private Transform _start;
    [SerializeField]
    private Transform _end;
    
    [SerializeField]
    [Range(0f,1f)]
    private float _lerpPorcent = 0f;

    private float speed;
    void Start()
    {
        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && _lerpPorcent <= 1)
        {
            _lerpPorcent += speed * Time.deltaTime;

            transform.position = Vector3.Lerp(_start.position, _end.position, _lerpPorcent);

        }
        if(!Input.GetMouseButton(0) && _lerpPorcent >= 0)
        {
            _lerpPorcent -= speed *4* Time.deltaTime;
            transform.position = Vector3.Lerp(_start.position, _end.position, _lerpPorcent);
        }
    }
}
