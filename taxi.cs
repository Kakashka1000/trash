using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class taxi : MonoBehaviour
{

    public float speeed;

    private void Update()
    {
       
        transform.Translate(-speeed * Time.deltaTime, 0, 0);
        
    }
}
