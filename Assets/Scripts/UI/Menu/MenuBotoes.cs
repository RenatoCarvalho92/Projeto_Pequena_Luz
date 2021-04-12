using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuBotoes : MonoBehaviour
{

    private Animator _animatorBottom;

    public bool testenumero1;

    [SerializeField]
    private AudioSource[] _somBotoes;
    private bool _somTocando;


    void Start()
    {
        _animatorBottom = GetComponent<Animator>();

        _somTocando = false;
    }



    // Update is called once per frame
    void Update()
    {

    }

   // public void OnPointerEnter(PointerEventData eventData)
   // {
    //    Debug.Log("The cursor entered the selectable UI element.");
   //}

    public void MouseDentro() {

       // Debug.Log("Mouse ENTROU no botão");
        _animatorBottom.SetBool("MouseSobre", true);

        _somBotoes[0].Play();

    }

    public void MouseSaiu() 
    {
       // Debug.Log("Mouse SAIU no botão");
        _animatorBottom.SetBool("MouseSobre", false);
        _animatorBottom.SetBool("MousePress", false);

        _somBotoes[0].Stop();
    }


    public void MouseClicou() {

       // Debug.Log("Mouse CLICOU no botão");
        _animatorBottom.SetBool("MousePress", true);

        _somBotoes[0].Stop();
        if (_somTocando == false)
        {
            _somBotoes[1].Play();
            _somTocando = true;
        }
      
    }
}
