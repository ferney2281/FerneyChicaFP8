namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicional Múltiple

            /*Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
            o Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  
            o Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 
            o Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 
            o Si es domingo no se realiza descuento. 
            o Visualizar el día, el descuento y el total a pagar por la compra.*/

            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de la compra:");
            valorCompra=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana: l:lunes, m:martes, x:miércoles, j: jueves, v: viernes, s:sábado, d: domingo");
            dia=Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento=valorCompra*0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento: {descuento}, valor a pagar: {valorCompra-descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miércoles, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es sábado, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0;
                    Console.WriteLine($"Hoy es domingo, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                default:
                    Console.WriteLine("Debe ingresar un valor válido");
                    break;
            }
        }
    }
}
