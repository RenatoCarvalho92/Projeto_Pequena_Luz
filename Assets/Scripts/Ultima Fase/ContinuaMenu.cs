using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuaMenu : MonoBehaviour
{
    [SerializeField]
    private Light _luz;
    private bool _luzAtiva;

    [SerializeField]
    private LevelLoader _levelLoader;



    void Start()
    {
        _luzAtiva = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_luzAtiva ==true && _luz.intensity <=15)
        {
            _luz.intensity += 10 * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            _luzAtiva = true;
            _levelLoader.CarregarParaUltimaFase(0,5);

        }
    }
}