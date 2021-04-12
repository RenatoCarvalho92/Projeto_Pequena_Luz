using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProximaFase : MonoBehaviour
{


    public LevelLoader levelLoader;

    [SerializeField]
    private GameObject ObjtAtivador;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ObjtAtivador)
        {
            levelLoader.CarregarProximaFase();
        }
    }

}
