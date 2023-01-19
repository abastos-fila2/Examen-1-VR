using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;
public class CuboColor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioColorSelection(){
        GetComponent<MeshRenderer>().material.color = Color.green;
        
    }


    public void CambioColorActivado(){
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
