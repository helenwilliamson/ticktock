using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ChangeHeartMaterial : MonoBehaviour {
	
    public float duration = 0.5f;
	public List<Material> materials;
	
	void Start() {
		StartCoroutine(DoMaterialLoop());
	}
	
	public IEnumerator DoMaterialLoop(){
       int i = 0;
       while (true){
         renderer.material = materials[i];
         i = (i+1) % materials.Count;
         yield return new WaitForSeconds(duration);
       }
    }
	
}
