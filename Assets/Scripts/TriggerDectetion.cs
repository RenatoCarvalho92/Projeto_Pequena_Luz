using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDectetion : MonoBehaviour
{

    public GameObject objAtivar;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Influencia Luz")
        {
            objAtivar.SetActive(true);
        }
    }

}
