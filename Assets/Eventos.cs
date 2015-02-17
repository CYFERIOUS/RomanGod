using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngineInternal;

public class Eventos : MonoBehaviour {

	// Use this for initialization

	string[] Unidades  = new string[]{"I","II","III","IV","V","VI","VII","VIII","IX","X"};
	string[] Decenas  = new string[]{"X","XX","XXX","XL","L","LX","LXXX","LXXX","XC","C"};
	string[] Centenas  = new string[]{"C","CC","CCC","CD","D","DC","DCC","DCCC","CM","M"};
	string[] Milenas  = new string[]{"M","MM","MMM"};

	string t;
	int longEst;
	
	void EnterNumbers(int a, int b){

		int t = resultados (a,b);

		string d = t.ToString ();

		d.Split (new char[]{','});

		string romano = "";

		for (int i = 0; i<d.Length; i++) {
			
			romano += transformNumbers (d[i], d.Length-i)+" ";
		}

		Debug.Log (romano);

	}

	int resultados(int a, int b){

		return a + b;

	}
	
	string unitario(int w){

		string unidad= "";

		if(w==0)
			unidad= "";
		if(w==1)
			unidad=Unidades[0];
		if(w==2)
			unidad=Unidades[1];
		if(w==3)
			unidad=Unidades[2];
		if(w==4)
			unidad=Unidades[3];
		if(w==5)
			unidad=Unidades[4];
		if(w==6)
			unidad=Unidades[5];
		if(w==7)
			unidad=Unidades[6];
		if(w==8)
			unidad=Unidades[7];
		if(w==9)
			unidad=Unidades[8];
		if(w==10)
			unidad=Unidades[9];


		return unidad;
	}

	string decenario(int w){
		
		string decenal= "";
		
		if(w==0)
			decenal="";
		if(w==1)
			decenal=Decenas[0];
		if(w==2)
			decenal=Decenas[1];
		if(w==3)
			decenal=Decenas[2];
		if(w==4)
			decenal=Decenas[3];
		if(w==5)
			decenal=Decenas[4];
		if(w==6)
			decenal=Decenas[5];
		if(w==7)
			decenal=Decenas[6];
		if(w==8)
			decenal=Decenas[7];
		if(w==9)
			decenal=Decenas[8];
		if(w==10)
			decenal=Decenas[9];

		return decenal;
	}

	string centenario(int w){
		
		string centenal= "";
		
		if(w==0)
			centenal="";
		if(w==1)
			centenal= Centenas[0];
		if(w==2)
			centenal= Centenas[1];
		if(w==3)
			centenal= Centenas[2];
		if(w==4)
			centenal= Centenas[3];
		if(w==5)
			centenal= Centenas[4];
		if(w==6)
			centenal= Centenas[5];
		if(w==7)
			centenal= Centenas[6];
		if(w==8)
			centenal= Centenas[7];
		if(w==9)
			centenal= Centenas[8];
		if(w==10)
			centenal= Centenas[9];
		
		return centenal;
	}

	string milenario(int w){
		
		string milenal = "";
		
		if(w==0)
			milenal="";
		if(w==1)
			milenal= Milenas[0];
		if(w==2)
			milenal= Milenas[1];
		if(w==3)
			milenal= Milenas[2];
		if(w==4)
			milenal= Milenas[3];
		if(w==5)
			milenal= Milenas[4];
		if(w==6)
			milenal= Milenas[5];
		if(w==7)
			milenal= Milenas[6];
		if(w==8)
			milenal= Milenas[7];
		if(w==9)
			milenal= Milenas[8];
		if(w==10)
			milenal = Milenas[9];
		
		return milenal;
	}

	string transformNumbers(char c, int longEst){

		string j = c.ToString();
		int w = int.Parse (j);

		Debug.Log (c+longEst);


		switch (longEst) 
		{
			case 1:
				return unitario(w);
				
			case 2:
				return decenario(w);
				
			case 3:
				return centenario(w);
				
			case 4:
				return milenario(w);
		default:
			return "";
		}	
	}
	
	void Start () {

		EnterNumbers (15,8);

	}
	
	void Update () {
	
	}
}
