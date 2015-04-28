using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberPad : MonoBehaviour
{
	public string inputNumber = "0";
	private socketScript _socketScript;
	//public int inputNum;
	public Text Text;
	// Use this for initialization
	void Start ()
	{
		_socketScript = gameObject.GetComponent<socketScript> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//inputNum = int.Parse (inputNumber);
		Text.text = inputNumber;

	}
	public void InputNum1 ()
	{
		if (inputNumber != "0") {
			inputNumber += "1";
		} else {
			inputNumber = "1";
		}
	}
	public void InputNum2 ()
	{
		if (inputNumber != "0") {
			inputNumber += "2";
		} else {
			inputNumber = "2";
		}
	}
	public void InputNum3 ()
	{
		if (inputNumber != "0") {
			inputNumber += "3";
		} else {
			inputNumber = "3";
		}
	}
	public void InputNum4 ()
	{
		if (inputNumber != "0") {
			inputNumber += "4";
		} else {
			inputNumber = "4";
		}
	}
	public void InputNum5 ()
	{
		if (inputNumber != "0") {
			inputNumber += "5";
		} else {
			inputNumber = "5";
		}
	}
	public void InputNum6 ()
	{
		if (inputNumber != "0") {
			inputNumber += "6";
		} else {
			inputNumber = "6";
		}
	}
	public void InputNum7 ()
	{
		if (inputNumber != "0") {
			inputNumber += "7";
		} else {
			inputNumber = "7";
		}
	}
	public void InputNum8 ()
	{
		if (inputNumber != "0") {
			inputNumber += "8";
		} else {
			inputNumber = "8";
		}
	}
	public void InputNum9 ()
	{
		if (inputNumber != "0") {
			inputNumber += "9";
		} else {
			inputNumber = "9";
		}
	}
	public void InputNum0 ()
	{
		if (inputNumber != "0") {
			inputNumber += "0";
		}
	}
	public void InputClear ()
	{
		inputNumber = "0";
	}
	public void Guess ()
	{
		_socketScript.SendMsg ();
		InputClear ();
	}
}
