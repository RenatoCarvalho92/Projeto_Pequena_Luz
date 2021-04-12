using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriigerCristais : MonoBehaviour
{
   
    private Animator _animatorCristais;

    [SerializeField]
    private Material[] _material;

    [SerializeField]
    private AudioSource _somCristal;
    private bool _somAtivado;

    private Renderer _rend;

    void Start()
    {
        _animatorCristais = GetComponent<Animator>();
        _rend = GetComponent<Renderer>();
        _rend.enabled = true;
        _rend.material = _material[0];

        _somAtivado = false;
        _somCristal.volume = 0.3f;
        //_material.DisableKeyword("_EMISSION");


    }


    private void OnTriggerEnter(Collider other) 
    {

        if (other.tag == "Player")
        {
            //_material.EnableKeyword("_EMISSION");

           // _animatorCristais.SetBool("JogadorPerto", true);
          // Debug.Log("Jogador está Perto");
           //=/// _rend.material = _material[1];

        }
        
        if (other.tag=="Influencia Luz")
        {
           // _material.EnableKeyword("_EMISSION");
            _animatorCristais.SetBool("JogadorPerto", true);
            _animatorCristais.SetBool("JogadorAtivouLuz", true);
            _rend.material = _material[1];
            
            if (_somAtivado == false)
            {
                _somCristal.Play();
                _somAtivado = true;

            }
          

            Debug.Log("Jogador Ativou Luz");
        }


    }



}
