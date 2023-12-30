using UnityEngine;
using UnityEngine.UI;

public class HareketliNesne : MonoBehaviour
{
    public float hiz = 10.0f; 
    public float yatayHiz = 5.0f; 
    public float ziplamaGucu = 2.0f; 
    public bool yerdeMi = true;
    private float eskiHiz;
    private Rigidbody rb;
    private float degiskenKonum;
    public Animator animator;
    public GameObject kamera;
    public Text text;
    public Text text2;
    public GameObject buton;
    private int kalanHak = 3;
    public GameObject panel;

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        degiskenKonum = gameObject.transform.position.z;
        eskiHiz = hiz;
    }

    void Update()
    {
        text.text = "Kalan Hak : " + kalanHak;
        transform.Translate(Vector3.forward * hiz * Time.deltaTime);

        
        float yatayGiris = Input.GetAxis("Horizontal"); 
        transform.Translate(Vector3.right * yatayGiris * yatayHiz * Time.deltaTime);

       
        if (Input.GetKeyDown(KeyCode.Space) && yerdeMi)
        {
            rb.AddForce(Vector3.up * ziplamaGucu, ForceMode.Impulse);
            animator.SetTrigger("Jump");
            yerdeMi = false; 
        }

       if (gameObject.transform.position.z > degiskenKonum-500 && hiz !=0)
        {
            hiz = hiz + Time.deltaTime;
            degiskenKonum = gameObject.transform.position.z;
        }
        if(kalanHak <= 0)
        {
            hiz = 0;
            panel.SetActive(true); 
            buton.SetActive(false);
            animator.SetTrigger("Lose");
            
        }
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Zemin"))
        {
            yerdeMi = true;
        }
        else if (collision.gameObject.tag == "Engel")
        {
            Destroy(collision.gameObject);
            hiz = hiz / 2;
            kalanHak--;
            
            

        }
        if (collision.gameObject.tag == "Bitis")
        {
            hiz = 0f;
            animator.SetTrigger("Win");
            panel.SetActive(true);
            text2.text = "Kazandýn!!!";
          

            
        }
        
    }
    
}
