using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadSceneControl {
    
    public string levelToLoad
    private SceneManager SceneManager
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int LoadScene()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
