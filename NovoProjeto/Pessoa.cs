using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovoProjeto;


   public class Pessoa
    {
    public string nome;
    public int idade;
    public double altura;
    public double peso;
    public double imc;
    public int qtdString;
    public int anoNasc;
    
    

    public void CalculaImc(double peso, double altura)
    {
        this.peso = peso;
        this.altura = altura;

       imc = this.peso / (this.altura * this.altura);
    }

    public void CalculaIdade(int ano_nasc, int ano_atual)
    {
        this.anoNasc = ano_nasc;
        
        idade = ano_atual - ano_nasc;
    }

    public void ContaString (string nome)
    {
        this.nome = nome;
        qtdString = nome.Length;

    }

    }

