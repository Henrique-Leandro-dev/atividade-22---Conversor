namespace static__Convertor_de_dolar
{
    public class Conversor
    {
    private static float CotacaoDolar = 5.24f;

        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }
        public static float DolarParaReais(float valorRS){
            return valorRS * CotacaoDolar;
        }


        private static float CotacaoEuro = 5.90f;
        public static float ReaisParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }
        public static float EuroParaReais(float valorRS){
            return valorRS * CotacaoEuro;
        }
        
    }
}     
   