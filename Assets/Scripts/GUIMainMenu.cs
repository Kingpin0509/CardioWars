using UnityEngine;
using System.Collections;

public class GUIMainMenu : MonoBehaviour {

	public GUISkin skin;	
	public Texture btnStart;
	
	public int x=189;
	public int y=356;
	
	private void Start()
	{
		
	}
	
	private void loadMainMenu() {        
		if (GUI.Button(new Rect( x, y, 330, 70), btnStart)){			
			Application.LoadLevel(1);
		}		
	}	

	void OnGUI () {		
		GUI.skin = skin;		
		loadMainMenu();		
	}
}