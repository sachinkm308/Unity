using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;    
using System.Text;
using Random=UnityEngine.Random;


public class DemoScript : MonoBehaviour
{

	public Text tosText;
	//public GameObject cubeObj;
	private float startTime;
	

	public void quit(){
		Application.Quit();
		Debug.Log("Inside Quit");
	}
    
	public class RandomGenerator    
	{
    public int RandomNumber(int min, int max)    
    {    
        System.Random random = new System.Random();    
        return random.Next(min, max);    
    }
	}

	public void Spawn(){
		
		RandomGenerator generator = new RandomGenerator(); 
		for(int i=1; i<=10;i++){
 			int a=generator.RandomNumber(0,6);
			int b=generator.RandomNumber(i-9,11);
			int c=generator.RandomNumber(i-14,10);
			int d=generator.RandomNumber(0,4);
			int e=generator.RandomNumber(i-10,10);
			int f=generator.RandomNumber(i-8,10);
			GameObject cubeObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cubeObj.transform.localScale = new Vector3(1,1,1);
	    	cubeObj.transform.position = new Vector3(a,b,c);
			cubeObj.GetComponent<Renderer>().material.color = new Color(0,128,0);
			GameObject sphereObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			sphereObj.transform.localScale = new Vector3(1,1,1);
	    	sphereObj.transform.position = new Vector3(d,e,f);
			sphereObj.GetComponent<Renderer>().material.color = new Color(0,255,0);

		}   


	    
	}
	void Start() {
		startTime = Time.time;
		RandomGenerator generator = new RandomGenerator();
		GameObject cubeObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cubeObj.transform.localScale = new Vector3(1,1,1);
	    cubeObj.transform.position = new Vector3(generator.RandomNumber(0,6),generator.RandomNumber(0,4),2);
		cubeObj.GetComponent<Renderer>().material.color = new Color(255,0,0);
		Spawn();



	}
	
	void Update() {
				
		if(Input.anyKeyDown){
 			 float t = Time.time - startTime;
			 string minutes = ((int) t / 60).ToString();
			 string seconds = (t % 60).ToString();
			 tosText.text = minutes + ":" + seconds;
             Debug.Log("A key or mouse click has been detected");
			 quit(); 
		} //else {
			//myLight.enabled = false;
		//}
	}
}
