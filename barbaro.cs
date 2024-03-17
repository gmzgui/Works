using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace Class_bárbaro
{
    public class barbaro
    {
        public string nome;
        public int vida;
        public int energia;
        public int maxVida;
        public int maxEnergia;
        public int nivel;
        public int vitalidade;
        public int forca;
        public int destreza;
        public int inteligencia;

        public void status(){
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Vida Atual: {vida}");
            System.Console.WriteLine($"Energia: {energia}");
            System.Console.WriteLine($"Vida Máxima: {maxVida}");
            System.Console.WriteLine($"Energia Máxima: {maxEnergia}");
            System.Console.WriteLine($"Nível: {nivel}");
            System.Console.WriteLine($"Vitalidade: {vitalidade}");
            System.Console.WriteLine($"Força: {forca}");
            System.Console.WriteLine($"Destreza: {destreza}");
            System.Console.WriteLine($"Inteligência: {inteligencia}");
        }

        public void upar(){
            nivel += 1;
            forca += 5;
            vitalidade += 5;
            maxEnergia += 2;
            inteligencia += 1;
            destreza += 2;
            maxVida = maxVida + (vitalidade*3)/2;
        }

        public void revigorar(int valorRevigorar){
            if (vida < maxVida){
                vida = vida + ((valorRevigorar*2)/3);
            }
            if (energia < maxEnergia){
                energia = energia + ((valorRevigorar*1)/3);
            }
            if (vida > maxVida){
                vida = maxVida;
            }
            if (energia > maxEnergia){
                energia = maxEnergia;
            }
        }
        public void atacar(barbaro outroBarbaro){
            outroBarbaro.vida = outroBarbaro.vida - ((forca/2) + (destreza/3) + (inteligencia/5));
            energia = energia - 2;
            if (energia < 2){
                outroBarbaro.vida = outroBarbaro.vida - 0;
            }
        }
    }
}