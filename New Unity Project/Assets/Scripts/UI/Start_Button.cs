using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Start_Button : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData e)
    {
        Scene cur_scene = SceneManager.GetActiveScene();
        Debug.Log("current scene name = " + cur_scene.name);
        Debug.Log("current scene build index = " + cur_scene.buildIndex);

        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
