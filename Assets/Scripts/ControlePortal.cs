using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePortal : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _objAtivar;

    [SerializeField]
    private MecaCristalTrigger[] Pilares;

    [SerializeField]
    private LevelLoader _levelLoader;

    public bool _todoPilaresAtivados;
    private int _numeroDePilares;


    public void Start()
    {

        _numeroDePilares = 0;

    }


    public void Update()
    {
        if (Pilares.Length > _numeroDePilares)
        {
            if (Pilares[_numeroDePilares].MacamismoAtivado == true)
            {
                _numeroDePilares++;

            }
        }

        if (Pilares.Length == _numeroDePilares)
        {
            _todoPilaresAtivados = true;
        }


        if (_todoPilaresAtivados == true)
        {
           _objAtivar[0].SetActive(true);
           _objAtivar[1].SetActive(true);

            Debug.Log("Teste");

        }
  
    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Player" && _todoPilaresAtivados == true)
        {
            Debug.Log("Passou de Fase");
            _levelLoader.CarregarProximaFase();
           

        }
    }
}
