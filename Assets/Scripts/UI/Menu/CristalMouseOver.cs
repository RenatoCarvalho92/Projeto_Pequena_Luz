using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalMouseOver : MonoBehaviour
{
    [SerializeField]
    private Light _luz;
    private bool _mouseSobre;
    private float _velocidade;

    void Start()
    {
        _mouseSobre = false;
        _velocidade = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (_mouseSobre == true && _luz.range <=9f)
        {
            _luz.range += _velocidade * Time.deltaTime;
        }
        if (_mouseSobre  == false && _luz.range >=0f)
        {
            _luz.range -= _velocidade/2 * Time.deltaTime;
        }

    }



    void OnMouseOver()
    {
        _mouseSobre = true;
        //Debug.Log("Mouse true");
    }

    private void OnMouseExit()
    {
        _mouseSobre = false;
       // Debug.Log("Mouse false");
    }
}
