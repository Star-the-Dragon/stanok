using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public GameObject message1;
    public GameObject message2;
    public GameObject button1;
    public GameObject button2;
    private int i = 0;
    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        print("Collision Detected!");
        if (!flag)
        {
            transform.GetComponent<MeshRenderer>().material.color = Color.blue;
            message1.SetActive(true);
            message2.GetComponent<Text>().text = "Высыпать шары";
            button1.SetActive(false);
            button2.SetActive(true);
            flag = true;
        }
        else
        {
            i++;
            message1.GetComponent<Text>().text = i.ToString();
        }

    }
}