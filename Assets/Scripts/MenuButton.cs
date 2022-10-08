using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
	[SerializeField] MenuButtonController menuButtonController;
	[SerializeField] Animator animator;
	[SerializeField] AnimatorFunctions animatorFunctions;
	[SerializeField] int thisIndex; 
            
    // Update is called once per frame
    void Update()
    {
		if(menuButtonController.index == thisIndex)
		{
			animator.SetBool ("selected", true);
			if(Input.GetAxis ("Submit") == 1){
			Debug.Log(menuButtonController.index);
			if (menuButtonController.index == 0)
			{
				Invoke("startGame",1f);
			}

			else if (menuButtonController.index == 1)
			{
				Credit();
			}
			else if (menuButtonController.index == 2)
			{
				Exit();
			}
				animator.SetBool ("pressed", true);
			}else if (animator.GetBool ("pressed")){
				animator.SetBool ("pressed", false);
				
				animatorFunctions.disableOnce = true;
				
			}
		}else{
			animator.SetBool ("selected", false);
		}
    }
    private void startGame(){

	    SceneManager.LoadScene(1);
    }
    private void Credit(){
	    
	    SceneManager.LoadScene(2);
    }
    private void Exit()
    {
	    Application.Quit();

    }
}
