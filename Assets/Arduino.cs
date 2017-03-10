using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System;

public class Arduino : MonoBehaviour {

	// Use this for initialization
	public string port;
	public int left, right;
	private SerialPort stream;
	void Start () {
		stream = new SerialPort(port,9600);
		stream.Parity = Parity.None;
		stream.StopBits = StopBits.One;
		stream.DataBits = 8;
		if (stream.IsOpen){
			Debug.LogWarning ("Serial is already, open. Closing.");
						stream.Close();
		}
		stream.Open();
	}
	
	// Update is called once per frame
	void Update () {
	
		stream.WriteLine("H");
		string line = stream.ReadLine ();
		string[] vecSensors = line.Split (new string[] {","}, StringSplitOptions.None);

		left = System.Convert.ToInt16(vecSensors[0]);
		right = System.Convert.ToInt16(vecSensors[1]);
		//if (left <= 900) { //someone blow the left pinwheels
		//}
				Debug.Log (line);
	}
}
