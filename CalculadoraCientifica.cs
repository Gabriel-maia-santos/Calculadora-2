namespace Calculadora2
{
    public class CalculadoraCientifica : Calculadora
    {
            private string[] valores {get;set;}
        public CalculadoraCientifica(float soma) 
        {
            this.soma = soma;
               
        }

        public CalculadoraCientifica()
        {
        }

        private float soma {get; set;}
        public void CalcularMedia(string txtConsole){

            valores = txtConsole.Split(";");
            for (int i = 0; i < valores.Length; i++)
            {
                soma = soma += float.Parse(valores[i]);
            }

            resultado = soma / valores.Length;


        }
        public void ControlarMetodos(string entradaVisor){

            //12 x 4
            //dados [0] = 12
            //dado [1] = x
            //dados[2] = 4
            string[] dados = entradaVisor.Split(" ");
            num1= float.Parse(dados[0]);
            operador = dados [1];
            num2 = float.Parse(dados[2]);

            switch (dados[1]){

                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "/":
                Dividir();
                break;

                case "*":
                Multiplicacao();
                break;
                
                default:
                break;
            }
        }
    }
}