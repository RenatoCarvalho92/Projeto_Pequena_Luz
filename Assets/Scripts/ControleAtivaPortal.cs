using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleAtivaPortal : MonoBehaviour
{
    public ControlePillar[] PilaresAtivos;

    public bool PilaresAtivados = false;

    private int _quantidadePilares = 0;


    private void Update()
    {


        if (_quantidadePilares < PilaresAtivos.Length)
        {
            ControleQuantidadePilares();
        }

    }

    private void ControleQuantidadePilares()
    {
        if (PilaresAtivos[_quantidadePilares].Ativo == true &&
            _quantidadePilares + 1 <= PilaresAtivos.Length)
        {
            _quantidadePilares++;
        }



        if (_quantidadePilares + 1 > PilaresAtivos.Length)
        {
            PilaresAtivados = true;
            Debug.Log("Teste");
        }



    }


}
