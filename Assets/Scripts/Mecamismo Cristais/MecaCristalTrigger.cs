using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecaCristalTrigger : MonoBehaviour
{
    private Animator _animatorCristais;

    [SerializeField]
    private Material[] _materialLuz;

    [SerializeField]
    private Renderer _rendLuz;


    [SerializeField]
    private Material _materialBase;

    public bool MacamismoAtivado;


    [SerializeField]
    private AudioSource _somMecanismo;
    //private bool _somAtivado;

    void Start()
    {
        _animatorCristais = GetComponent<Animator>();

        _rendLuz.enabled = true;
        _rendLuz.material = _materialLuz[0];

        

        MacamismoAtivado = false;
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            
            //_animatorCristais.SetBool("JogadorPerto", true);
            //Debug.Log("Jogador está Perto");

        }

        if (other.tag == "Influencia Luz")
        {
            //_materialLuz.EnableKeyword("_EMISSION");
            // _materialBase.EnableKeyword("_EMISSION");
           


            _animatorCristais.SetBool("JogadorPerto", true);
            _animatorCristais.SetBool("JogadorAtivouLuz", true);

            _rendLuz.material = _materialLuz[1];


            if (MacamismoAtivado == false)
            {
                _somMecanismo.Play();
            }

            MacamismoAtivado = true;




            Debug.Log("Jogador Ativou Luz");
        }


    }
}
