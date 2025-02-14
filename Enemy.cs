using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isFailed;
    public bool isWin;

    // Start is called before the first frame update
    void Start()
    {
        isFailed = false;
        isWin = false;
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isFailed = true;
        }

        if (collision.gameObject.name == "Win")
        {
            isWin = true;
        }
    
    }
private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            isFailed = true;
        }

        if (other.gameObject.name == "Win")
        {
            isWin = true;
        }
    
    }




 private void Update()
    {
        if(isFailed == true )
        {
            UI.instance.failedUI.SetActive(true);
        }
          if(isWin == true )
        {
            UI.instance.WinUI.SetActive(true);
        }


    }

}
