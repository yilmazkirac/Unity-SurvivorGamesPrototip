using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewObjectInteraction : MonoBehaviour
{
 
    private void OnTriggerStay(Collider other)
    {
       
        if (other.CompareTag("BuildObject"))
        {
            transform.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (!other.CompareTag("BuildObject"))
        {
            transform.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
