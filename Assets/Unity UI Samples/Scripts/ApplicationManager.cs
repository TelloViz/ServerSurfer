/* This file was implemented by unity as part of their Demo GUI Menu project.
 
 I interpret this as being a file that handles things on the application level.
The only task they are doing in this file so far is exiting the application. 
They do a simple check for editor window or runtime game mode...*/

using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {


    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
