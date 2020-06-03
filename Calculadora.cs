namespace Aula09Calculadora
{
    public class Calculadora
    {
        public float numero1 { get; set; }

        public float numero2 { get; set; }

        public float resultado { get; set; }

        protected string operador { get; set; }


        public void Somar(){
            resultado = 0;
            resultado = numero1 + numero2;
        }

        public void Subtrair(){
            resultado = 0;
            resultado = numero1 - numero2;
        }

        public void Multiplicar(){
            resultado = 0;
            resultado = numero1 * numero2;
        }

        public void Dividir(){
            resultado = 0;
            resultado = numero1 / numero2;
        }
    }
}