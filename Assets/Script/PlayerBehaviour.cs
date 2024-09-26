using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float movementSpeed = 5f;
    public int monedasConseguidas = 0;
    public TextMeshProUGUI coinsText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Space ))
        { 
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse); 
        }

        Vector3 movement = new()
        {
            x = Input.GetAxis("Horizontal"),
            z = Input.GetAxis("Vertical")
        };

        rb.AddForce(movementSpeed * Time.deltaTime * movement, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CoinItem"))
        {
            monedasConseguidas ++;

            Debug.Log("He tocado una moneda");

            Debug.Log("Monedas conseguidas: " + monedasConseguidas);
        }
        else if(other.CompareTag("SpecialCoinItem"))
        {
            monedasConseguidas += 5;

            Debug.Log("He tocado una moneda especial");

            Debug.Log("Monedas conseguidas: " + monedasConseguidas);
        }
        
        if(other.tag.Contains("Coin"))
        {
            coinsText.text = monedasConseguidas.ToString();
            other.gameObject.SetActive(false);
        }
    }
}
