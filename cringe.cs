using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cringe : MonoBehaviour
{
    public GameObject trubi;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            float randoms = Random.Range(-0f, 4f);
            GameObject trubinot = Instantiate(trubi, new Vector3(2, randoms, 0), Quaternion.identity);
            Destroy(trubinot, 10);
        }
    }
}
