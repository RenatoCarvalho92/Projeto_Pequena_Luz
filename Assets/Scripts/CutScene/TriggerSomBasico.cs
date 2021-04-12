using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSomBasico : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjtAtivador;

    private bool _somAtivo;

    private AudioSource _myAudioSource;
    void Start()
    {
        _myAudioSource = GetComponent<AudioSource>();
        _somAtivo = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ObjtAtivador && _somAtivo==  false)
        {
            _myAudioSource.Play();
            _somAtivo = true;
            Debug.Log("Teste Som foi ativado");
        }
    }
}
