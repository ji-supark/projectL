using UnityEngine;
using System.Collections;

public class AnimateUV : MonoBehaviour {
	
	
	public Material myMat;
	public float scrollSpeed;
	private float offsetX;
	private Vector2 offsetVector;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		offsetX += (float)(scrollSpeed*Time.deltaTime / 10.0);
		offsetVector = new Vector2(offsetX,0);
		myMat.SetTextureOffset ("_MainTex", offsetVector);
	}
}