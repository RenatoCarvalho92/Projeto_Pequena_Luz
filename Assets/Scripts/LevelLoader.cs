using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float TempoEspera = 1.3f;


    [SerializeField]
    private AudioSource[] _fonteSom;
    private int _controleMusica;
    private bool _controleVolume;

    private void Awake()
    {
        transition = GetComponent<Animator>();

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            _fonteSom[0].Play();
            _controleMusica = 0;
        }
        else
        {
            _fonteSom[1].Play();
            _controleMusica = 1;
        }


        _controleVolume = false;

    }


    private void Update()
    {

        if (_controleVolume == true && _fonteSom[_controleMusica].volume >= 0f)
        {
            _fonteSom[_controleMusica].volume -= 0.7f*Time.deltaTime;
        }
      

        if (Input.GetMouseButtonDown(0)&& SceneManager.GetActiveScene().buildIndex == 1 ) 
        {

            CarregarProximaFase();

        }
    }


    public void CarregarProximaFase() 
    {
        _controleVolume = true;

        StartCoroutine( CarregarFase(SceneManager.GetActiveScene().buildIndex + 1));

    }

    public void CarregarMenuFase()   
    {
        _controleVolume = true;

        StartCoroutine(CarregarFase(0));

    }
    public void CarregarParaUltimaFase(int levelindex, int tempoExtra) 
     {

        StartCoroutine(CarregarFaseMaisTempo(levelindex, tempoExtra));

    }

    public void FechaAplicativo() 
    {

        Application.Quit();

    }


    

    IEnumerator CarregarFase(int levelindex) 
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(TempoEspera);
        
        SceneManager.LoadScene(levelindex);
    
    }
    IEnumerator CarregarFaseMaisTempo(int levelindex, int tempoExtra) 
    {

        yield return new WaitForSeconds(tempoExtra);
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(TempoEspera);
        SceneManager.LoadScene(levelindex);
    }

}
