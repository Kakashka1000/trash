using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class knopka : MonoBehaviour
{
    public void pomidoro()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
