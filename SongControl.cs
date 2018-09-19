using UnityEngine;
using System.Collections;

public class SongControl : MonoBehaviour {

	public Transform[] Note=new Transform[7] ;

	public AudioClip[] sound= new AudioClip[7];

	public static float songlength=0;
	public float points = 0;
	static public float diff=1;

	public KeyCode keyA;
	public KeyCode keyS;
	public KeyCode keyD;
	public KeyCode keyJ;
	public KeyCode keyK;
	public KeyCode keyL;
	public KeyCode keyExit;

	public static string destroyA="n";
	public static string destroyA1="n";
	public static string destroyB="n";
	public static string destroyB1="n";
	public static string destroyC="n";
	public static string destroyD="n";
	public static string destroyE="n";
	public static string destroyF="n";
	public static string destroyC1="n";
	public static string destroyD1="n";
	public static string destroyE1="n";
	public static string destroyF1="n";
	public static string destroyA2="n";
	public static string destroyB2="n";

	void FixedUpdate () {//Генерация кругов

		songlength += Time.deltaTime;
		
		if ((songlength>=.1) && (songlength<=.125))
		{
			Instantiate(Note[2],Note[2].position,Note[2].rotation);
		}
		if ((songlength>=.6) && (songlength<=.625))
		{
			Instantiate(Note[4],Note[4].position,Note[4].rotation);
		}
		if ((songlength>=1.3) && (songlength<=1.325))
		{
			Instantiate(Note[0],Note[0].position,Note[0].rotation);
		}
		if ((songlength>=1.8) && (songlength<=1.825))	
		{
			Instantiate(Note[5],Note[5].position,Note[5].rotation);
		}
		if ((songlength>=2.5) && (songlength<=2.525))
		{
			Instantiate(Note[1],Note[1].position,Note[1].rotation);
		}
		if ((songlength>=3.0) && (songlength<=3.025))	
		{
			Instantiate(Note[6],Note[6].position,Note[6].rotation);
		}
		if ((songlength>=3.4) && (songlength<=3.425))	
		{
			Instantiate(Note[3],Note[3].position,Note[3].rotation);
		}
		if ((songlength>=4.1) && (songlength<=4.125))	
		{
			Instantiate(Note[7],Note[7].position,Note[7].rotation);
		}
		if ((songlength>=4.8) && (songlength<=4.825))	
		{
			Instantiate(Note[8],Note[8].position,Note[8].rotation);
		}
		if ((songlength>=5.5) && (songlength<=5.525))	
		{
			Instantiate(Note[9],Note[9].position,Note[9].rotation);
		}
		if ((songlength>=6.2) && (songlength<=6.225))	
		{
			Instantiate(Note[10],Note[10].position,Note[10].rotation);
		}
		if ((songlength>=6.7) && (songlength<=6.725))	
		{
			Instantiate(Note[11],Note[11].position,Note[11].rotation);
		}
		if ((songlength>=7.4) && (songlength<=7.425))	
		{
			Instantiate(Note[12],Note[12].position,Note[12].rotation);
		}
		if ((songlength>=8.1) && (songlength<=8.125))	
		{
			Instantiate(Note[13],Note[13].position,Note[13].rotation);
		}
		if (songlength >= 18) 
		{
			songlength = 0;
			destroyA="n";
			destroyA1="n";
			destroyB="n";
			destroyB1="n";
			destroyA2="n";
			destroyB2="n";
			destroyC="n";
			destroyC1="n";
			destroyD="n";
			destroyD1="n";
			destroyE="n";
			destroyE1="n";
			destroyF="n";
			destroyF1="n";
		}
	}

	void OnTriggerStay2D(Collider2D other) //При нажатии БАМ
	{
		if ((Input.GetKeyDown(keyA)) && (other.gameObject.name == "S1Note(Clone)")) //1
		{
			destroyA="y";
			AudioSource.PlayClipAtPoint(sound[3],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyA)) && (other.gameObject.name == "S1Note 1(Clone)")) //1
		{
			destroyA1="y";
			AudioSource.PlayClipAtPoint(sound[1],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyS)) && (other.gameObject.name == "S2Note(Clone)"))
		{
			destroyB="y";
			AudioSource.PlayClipAtPoint(sound[2],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyS)) && (other.gameObject.name == "S2Note 1(Clone)"))
		{
			destroyB1="y";
			AudioSource.PlayClipAtPoint(sound[0],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyD)) && (other.gameObject.name == "S3Note(Clone)"))
		{
			destroyC="y";
			AudioSource.PlayClipAtPoint(sound[0],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyJ)) && (other.gameObject.name == "S4Note(Clone)"))
		{
			destroyD="y";
			AudioSource.PlayClipAtPoint(sound[0],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyK)) && (other.gameObject.name == "S5Note(Clone)"))
		{
			destroyE="y";
			AudioSource.PlayClipAtPoint(sound[2],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyL)) && (other.gameObject.name == "S6Note(Clone)"))
		{
			destroyF="y";
			AudioSource.PlayClipAtPoint(sound[4],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyJ)) && (other.gameObject.name == "S4Note 1(Clone)"))
		{
			destroyC1="y";
			AudioSource.PlayClipAtPoint(sound[3],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyL)) && (other.gameObject.name == "S6Note 1(Clone)"))
		{
			destroyD1="y";
			AudioSource.PlayClipAtPoint(sound[3],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyD)) && (other.gameObject.name == "S3Note 1(Clone)"))
		{
			destroyE1="y";
			AudioSource.PlayClipAtPoint(sound[2],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyK)) && (other.gameObject.name == "S5Note 1(Clone)"))
		{
			destroyF1="y";
			AudioSource.PlayClipAtPoint(sound[1],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyA)) && (other.gameObject.name == "S1Note 2(Clone)")) //1
		{
			destroyA2="y";
			AudioSource.PlayClipAtPoint(sound[0],transform.position);
			points++;
		}
		if ((Input.GetKeyDown(keyL)) && (other.gameObject.name == "S6Note 2(Clone)"))
		{
			destroyB2="y";
			AudioSource.PlayClipAtPoint(sound[5],transform.position);
			points++;
		}
	}
	void OnGUI() {
		GUIStyle style = GUI.skin.GetStyle ("Label");
		style.fontSize = 24;
		GUI.Label(new Rect(10, 10, 100, 200), points.ToString());
	}
}
