using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

	public float velocidade;
	float direcao_x;
	float posicaoinicial_x, posicaoFinal_x;
	public Transform[] posicoes;
	int posicaoAtual=1;

	// Update is called once per frame
	void Update () {
		//Fire1 - clique do mouse, touch ou ctrl esquerdo
		if(Input.GetButtonDown("Fire1")){
			//posicao do primeiro toque na tela
			posicaoinicial_x = Input.mousePosition.x;
		}else if(Input.GetButtonUp("Fire1")){
			//posicao da ultima posicao do dedo na tela
			posicaoFinal_x = Input.mousePosition.x;
			//define a direcao
			direcao_x = posicaoFinal_x - posicaoinicial_x;
			if (direcao_x > 0 && posicaoAtual < 2) {
				posicaoAtual++;
			} else if(direcao_x <0 && posicaoAtual > 0){
				posicaoAtual--;
			}
		}

		//desloca o cubo para pista atual
		transform.position = Vector3.Lerp(transform.position, 
								posicoes[posicaoAtual].position, 
								velocidade*Time.deltaTime);

		print (posicaoAtual);
	}
}
