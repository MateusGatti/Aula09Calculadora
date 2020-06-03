namespace Aula09Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {

        private string[] valores { get; set; }
        private float soma { get; set; }

        public void CalcularMedia(string txtConsole ){

            // O Split é usado para separar os números (no caso, irá separar com o ";")
            // Ex: 5;8;22;6
            valores = txtConsole.Split(";");

            for (int i = 0; i < valores.Length; i++)
            {
                soma += soma + float.Parse(valores[i]);
            }

            resultado = soma / valores.Length;

        }


        public void ControlarMetodos(string entradaUsuario){

            resultado = 0;

            
            string[] dados = entradaUsuario.Split(" ");

            operador = dados[1];
            numero1 = float.Parse(dados[0]);
            numero2 = float.Parse(dados[2]);

            switch (operador){
                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "x":
                Multiplicar();
                break;

                case "/":
                Dividir();
                break;
            }

        }


    }
}