using System;
using UnityEngine;

public class Painel
{
	public int Tamanho{ get;}
	public int Posicao{ get; set;}
	private const[] Teclas{ get;}
	
	public Painel(int size,int p,const[,] key){
		this.Tamanho = size;
		this.Posicao = p;
		this Teclas = key;
	}
	
	public static void IniciaPainel()
	{
		//redefine painel, nivel, linhas e pontuação
	}
	
	private static void GeraPeca()
	{
		//Gera uma peça
	}
	
	public static int ApagaLinha()
	{
		//Apaga uma linha preenchida no painel e retorna que apagou
	}
	
	public Vector2 MovimentaPeca()
	{
		// Altera a posição da peça, sendo esses movimentos o de cair infinitamente e os da ação do jogador. 
		// Retorna o valor de p, um Vector2 que contém os valores de x e y, que será utilizado para definir a movimentação da peça.
	}
	
	private static void VerificaPeca()
	{
		// Verifica a posição da peça. Se ela está próxima a uma parede, não poderá se mover. 
		// Se encostar no chão, a peça fica parada, e então, o GeraPeca() ocorre novamente.
	}
	
	private static void Anima()
	{
		// Utiliza o atributo velocidade do Jogo para definir 
		// o intervalo de frames em que a tecla irá cair automaticamente
	}
	
	public static void GameOver()
	{
		//Fim de jogo, dá ao usuário as opções de sair do jogo ou de reiniciar, que leva ao IniciaJogo() 
	}
	
	
	
}