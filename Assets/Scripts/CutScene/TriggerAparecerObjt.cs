using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAparecerObjt : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjtAtivador;

    [SerializeField]
    private GameObject[] ObjtsParaAtivar;

    private bool _spawnar;

    private int _i;

    void Start()
    {
        _spawnar = false;
        _i = 0;
    }


    private void Update()
    {

        while (_i < ObjtsParaAtivar.Length && _spawnar == true)
        {
            ObjtsParaAtivar[_i].SetActive(true);
            _i++;
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ObjtAtivador)
        {
            _spawnar = true;
        }
    }
}
