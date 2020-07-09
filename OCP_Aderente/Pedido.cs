namespace OCP_Aderente
{
    class Pedido
    {
        //...outro codigo

        //palavra virtual significa que vou poder sobreescrever o método

        public virtual double DescontoPedido(double valorFinal)
        {
            return valorFinal;
        }
    }
}
