using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriigerLuzesRunas : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjtAtivador;

    private bool _luzAtiva;

    private Light _myLight;
    void Start()
    {
        _myLight = GetComponent<Light>();
        _myLight.intensity = 0f;
        _luzAtiva = false;

    }


    private void Update()
    {
        if (_luzAtiva == true && _myLight.intensity <= 0.8f)
        {
            _myLight.intensity += 0.1f * Time.deltaTime;
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ObjtAtivador)
        {
            _luzAtiva = true;
        }
    }
}
