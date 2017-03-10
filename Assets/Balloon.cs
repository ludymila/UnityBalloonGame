using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Balloon : MonoBehaviour {
	
	float x_velocity = 0.0f;
	float y_velocity = 0.0f;
	Arduino myArduino;
	public int threshold = 900;
	public Transform myCamera;
	
	//private SerialPort stream;
	
	// Use this for initialization
	void Start ()
	{
		//stream = new SerialPort("COM4",115200);
		//stream.Parity = Parity.None;
		//stream.StopBits = StopBits.One;
		//stream.DataBits = 8;
		
		//stream.Open();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//STREAM THINGS
		//stream.WriteLine("Hello!");
		//string s = stream.ReadLine().ToString();
		//Debug.Log(s);
		//int value = int.Parse(s);
		
		//If input value will be for sideways movement
				//if (myArduino.left < threshold) {
				//		leffCount++;
				//}
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			if(y_velocity < 0)
			{
				y_velocity = 0;
			}
			y_velocity += 0.5f;
		}
		else if(Input.GetKey(KeyCode.DownArrow))
		{
			if(y_velocity > 0)
			{
				y_velocity = 0;
			}
			y_velocity -= 0.5f;
		}
		else if(Input.GetKey(KeyCode.LeftArrow))
		{
			if(x_velocity > 0)
			{
				x_velocity = 0;
			}
			x_velocity -= 0.5f;
		}
		else if(Input.GetKey(KeyCode.RightArrow))
		{
			if(x_velocity < 0)
			{
				x_velocity = 0;
			}
			x_velocity += 0.5f;
		}
		
		if(x_velocity > 3)
		{
			x_velocity = 3;
		}
		else if(x_velocity < -3)
		{
			x_velocity = -3;
		}
		
		if(y_velocity > 3)
		{
			y_velocity = 3;
		}
		else if(y_velocity < -3)
		{
			y_velocity = -3;
		}
		
		rigidbody.AddForce(x_velocity, y_velocity, 0.75f);
	}
}