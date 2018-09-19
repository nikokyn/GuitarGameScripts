using UnityEngine;
using System.Collections;


public class NoteControl : MonoBehaviour {

	public Transform burst;


	void Start () { //Скеллинг по струнам
		if (SongControl.diff == 1) 
		{
			if (gameObject.name == "S1Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.23f, -1, 0);
			}
			if (gameObject.name == "S1Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.23f, -1, 0);
			}
			if (gameObject.name == "S2Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.16f, -1, 0);
			}
			if (gameObject.name == "S2Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.16f, -1, 0);
			}
			if (gameObject.name == "S3Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.07f, -1, 0);
			}
			if (gameObject.name == "S4Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.03f, -1, 0);
			}
			if (gameObject.name == "S4Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.03f, -1, 0);
			}
			if (gameObject.name == "S5Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.13f, -1, 0);
			}
			if (gameObject.name == "S6Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.24f, -1, 0);
			}
			if (gameObject.name == "S6Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.24f, -1, 0);
			}
			if (gameObject.name == "S3Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.07f, -1, 0);
			}
			if (gameObject.name == "S5Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.13f, -1, 0);
			}
			if (gameObject.name == "S1Note 2(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.23f, -1, 0);
			}
			if (gameObject.name == "S6Note 2(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.24f, -1, 0);
			}
		}
		if (SongControl.diff == 2) 
		{
			if (gameObject.name == "S1Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.46f, -2, 0);
			}
			if (gameObject.name == "S1Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.46f, -2, 0);
			}
			if (gameObject.name == "S2Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.32f, -2, 0);
			}
			if (gameObject.name == "S2Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.32f, -2, 0);
			}
			if (gameObject.name == "S3Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.14f, -2, 0);
			}
			if (gameObject.name == "S4Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.06f, -2, 0);
			}
			if (gameObject.name == "S4Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.06f, -2, 0);
			}
			if (gameObject.name == "S5Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.26f, -2, 0);
			}
			if (gameObject.name == "S6Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.48f, -2, 0);
			}
			if (gameObject.name == "S6Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.48f, -2, 0);
			}
			if (gameObject.name == "S3Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.14f, -2, 0);
			}
			if (gameObject.name == "S5Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.26f, -2, 0);
			}
			if (gameObject.name == "S1Note 2(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.46f, -2, 0);
			}
			if (gameObject.name == "S6Note 2(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.48f, -2, 0);
			}
		}
		if (SongControl.diff == 3) 
		{
			if (gameObject.name == "S1Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.69f, -3, 0);
			}
			if (gameObject.name == "S1Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.69f, -3, 0);
			}
			if (gameObject.name == "S2Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.48f, -3, 0);
			}
			if (gameObject.name == "S2Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.48f, -3, 0);
			}
			if (gameObject.name == "S3Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.21f, -3, 0);
			}
			if (gameObject.name == "S4Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.09f, -3, 0);
			}
			if (gameObject.name == "S4Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.09f, -3, 0);
			}
			if (gameObject.name == "S5Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.39f, -3, 0);
			}
			if (gameObject.name == "S6Note(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.72f, -3, 0);
			}
			if (gameObject.name == "S6Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.72f, -3, 0);
			}
			if (gameObject.name == "S3Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.21f, -3, 0);
			}
			if (gameObject.name == "S5Note 1(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.39f, -3, 0);
			}
			if (gameObject.name == "S1Note 2(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.69f, -3, 0);
			}
			if (gameObject.name == "S6Note 2(Clone)") {
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (.72f, -3, 0);
			}
		}
	}

	void Update ()//Уничтожение ноты, управление
	{
		if ((SongControl.destroyA == "y") && (gameObject.name == "S1Note(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyA1 == "y") && (gameObject.name == "S1Note 1(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyB == "y") && (gameObject.name == "S2Note(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyB1 == "y") && (gameObject.name == "S2Note 1(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyC == "y") && (gameObject.name == "S3Note(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyD == "y") && (gameObject.name == "S4Note(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyE == "y") && (gameObject.name == "S5Note(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyF == "y") && (gameObject.name == "S6Note(Clone)"))///////////
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyC1 == "y") && (gameObject.name == "S4Note 1(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyD1 == "y") && (gameObject.name == "S6Note 1(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyE1 == "y") && (gameObject.name == "S3Note 1(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyF1 == "y") && (gameObject.name == "S5Note 1(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyA2 == "y") && (gameObject.name == "S1Note 2(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
		if ((SongControl.destroyB2 == "y") && (gameObject.name == "S6Note 2(Clone)"))
		{
			Destroy (gameObject);
			Instantiate(burst,transform.position,burst.rotation);
		}
	}
	void OnTriggerEnter2D() //Измена цвета
		
	{
		GetComponent<SpriteRenderer> ().color = new Color (0, 1, 0);
	}
	void OnTriggerExit2D()
	{
		GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0);
		Destroy (gameObject, .25f);
	}

	}
