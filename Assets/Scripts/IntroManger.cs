using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class IntroManger : MonoBehaviour
{
    private float startTime = 44f;
    private float CurrentTime;

    [SerializeField] private GameObject press;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = startTime;
        press.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        if (CurrentTime <= 0)
        {
            press.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(2);
            }
        }
        
    }
}
