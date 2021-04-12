using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePillar : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject[] _objAtivar;
    public bool Ativo = false;
  
    public void Start()
    {
       
    }


    private void OnTriggerEnter(Collider other)
    {
    
        if (other.tag == "Influencia Luz" && Ativo == false)
        {
            
            Ativo = true;
            
            _objAtivar[0].SetActive(true);
            _objAtivar[1].SetActive(true);
            _objAtivar[2].SetActive(true);
            _objAtivar[3].SetActive(false);
            _objAtivar[3].SetActive(false);
           
        }
    }
}
