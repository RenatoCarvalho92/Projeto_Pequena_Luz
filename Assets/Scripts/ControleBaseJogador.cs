using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControleBaseJogador : MonoBehaviour
{
    [SerializeField]
    private Camera _cameraJogador; // precisa adicionar de forma manual
    [SerializeField]
   // private Transform _canhao;
    public float movimentoVelocidade;
    public float rotacaoVelocidade;
    public Vector3 respawn;


    private bool movimentoLivre = true;

    public Light minhaLuz; // Pegar a luz do jogador, compomente

    [SerializeField]
    private SphereCollider _distanciaAtivar;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private AudioSource MinhaAudioSource;



    private void Awake()
    {
        MinhaAudioSource = GetComponent<AudioSource>();
        MinhaAudioSource.volume = 0f;
    }



    void Start()
    {

        _distanciaAtivar.gameObject.SetActive(false);

        _cameraJogador = Camera.main; 
        movimentoVelocidade = 8f;
        rotacaoVelocidade = 3;

        

        //minhaLuz = GetComponent<Light>(); // Pega o compomente luz
    }


    void Update()
    {

        ControleJogador();

        ControleLuzIntesidadeTamanho();

        ControleSom();
    }

    private void ControleJogador()
    {

  
        Ray cameraRay = _cameraJogador.ScreenPointToRay(Input.mousePosition);
        Plane chaoPlano = new Plane(Vector3.up, Vector3.zero);
        float raioTamanho;

        if (chaoPlano.Raycast(cameraRay, out raioTamanho))
        {
            Vector3 pontoParaOlhar = cameraRay.GetPoint(raioTamanho);
            Debug.DrawLine(cameraRay.origin, pontoParaOlhar, Color.red);
            gameObject.transform.LookAt(new Vector3(pontoParaOlhar.x, gameObject.transform.position.y, pontoParaOlhar.z));
        }

        if (movimentoLivre == true && minhaLuz.range <= 6.5)
        {            //Movimento do Jogador 
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movimentoVelocidade);
            // transform.Rotate(0, Input.GetAxis("Horizontal") * rotacaoVelocidade, 0, Space.Self);

            if (Input.GetAxis("Vertical") != 0)
            {
                animator.SetBool("IsWalking", true);
            }
        }

    }

    private void ControleLuzIntesidadeTamanho()
    {

        float amplitude = 0.5f;

        if (Input.GetMouseButton(0) && minhaLuz.range <= 10)
        {
            minhaLuz.range += minhaLuz.range * amplitude * Time.deltaTime;
                    
            animator.SetBool("IsCharging",true);
            animator.SetBool("IsWalking", false);
        }
        if (!Input.GetMouseButton(0) && minhaLuz.range >= 5)
        {
            minhaLuz.range -= minhaLuz.range * amplitude *3* Time.deltaTime;
            animator.SetBool("IsCharging", false);         
        }
        
        if (minhaLuz.range >=7.5f)
        {
            _distanciaAtivar.gameObject.SetActive(true);
        }
        else
        {
            _distanciaAtivar.gameObject.SetActive(false);
        }
   
    
    }


    private void ControleSom() {

        float amplitudeSom = 0.5f;

        if (Input.GetMouseButton(0) && MinhaAudioSource.volume <=0.4 )
        {
            MinhaAudioSource.volume += amplitudeSom * Time.deltaTime;
        }
       
        if (!Input.GetMouseButton(0) && MinhaAudioSource.volume >= 0f)
        {
            MinhaAudioSource.volume -= amplitudeSom * Time.deltaTime * 4;
        }

    }


}
