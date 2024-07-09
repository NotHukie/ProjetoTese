using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void SalaTeste()
    {
        SceneManager.LoadScene(1);
    }
    public void RegieA()
    {
        SceneManager.LoadScene(2);
    }
    public void Cisterna()
    {
        SceneManager.LoadScene(3);
    }
    public void TeresaMacedo()
    {
        SceneManager.LoadScene(4);
    }
}
