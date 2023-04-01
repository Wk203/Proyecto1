

using System;
using System.Xml.Schema;

namespace Proyecto1
{
    class Program
{
    static void Main(string[] args)
    {
            int opcion_menu_principal = 0,cant_p1=0, cant_p2 = 0, cant_p3 = 0, cant_p4 = 0, cant_p5 = 0, NIT =0,forma_pago=0;
            double ac1=0,ac2=0,ac3=0,ac4=0,ac5 = 0;
            int totalp1=0,totalp2=0,totalp3=0,totalp4=0,totalp5=0,facturas=0;
            double precio_azucar = 10.80, precioArroz = 3.80, preciogalleta = 1.10, preciococa = 17.00, preciocafe = 50.00, puntos = 0, puntos_totales=0;
            double dinero_totalp1 = 0, dinero_totalp2 = 0, dinero_totalp3 = 0, dinero_totalp4 = 0, dinero_totalp5 = 0,dinerototal=0;
            string codigo = "",nombre="", correo="";
            char opcion_menu1=' ',sn=' ';
            DateTime fecha = DateTime.Now;
            double total_factura = 0, total_facturas = 0;
            Console.BackgroundColor= ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        menu_principal:
            Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                        ---------TIENDAS MÁS-----------                                              ║");
        Console.WriteLine("║                                                Menú principal                                                       ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                              1. Facturación                                                         ║");
        Console.WriteLine("║                                              2. Reportes de Facturación                                             ║");
        Console.WriteLine("║                                              3. Salir                                                               ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                              Ingrese el número de la opción a la que desea ingresar:                                ║");
        Console.WriteLine("║                                                      ____________                                                   ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("║                                                                                                                     ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(2, 2);
            Console.WriteLine(fecha); 
        opcion:

            Console.SetCursorPosition(61, 23);
            try
            {
                opcion_menu_principal =int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(50, 24); 
                Console.WriteLine("Debe ingresar un número");
                goto opcion;
            }

            if (opcion_menu_principal > 3 || opcion_menu_principal < 1)
            {
                Console.SetCursorPosition(55, 24); Console.WriteLine("Opción inválida");
                goto opcion;
            }

            switch(opcion_menu_principal)
            {
                case 1:
                    goto opcion_1;
                    break;
                case 2:
                    goto opcion_2;
                    break;
                case 3:
                    Console.SetCursorPosition(50, 24);
                    Console.WriteLine("¿Seguro que desea salir? S/N");
                    Console.SetCursorPosition(61, 23);
                    sn:
                    try
                    {
                        sn = Convert.ToChar(Console.ReadLine());
                    }
                    catch
                    {
                        Console.SetCursorPosition(50, 24);
                        Console.WriteLine("Esa opción no es válida.");
                        goto sn;
                    }
                    if(sn!='s'&& sn != 'S' && sn != 'n' && sn != 'N')
                    {
                        Console.SetCursorPosition(50, 24);
                        Console.WriteLine("Esa opción no es válida.");
                        goto sn;
                    }
                    if (sn=='s'|| sn == 'S') 
                    {
                        return;
                    }
                    else
                    {
                        goto menu_principal;
                    }
                    break;
            }


        opcion_1:
            cant_p1 = 0; cant_p2 = 0; cant_p3 = 0; cant_p4 = 0; cant_p5 = 0; total_factura= 0;
            ac1 = 0; ac2 = 0; ac3 = 0; ac4 = 0; ac5 = 0;
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ i=ingresar factura    p= pagar       m= menu(sin guardar)                                                           ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                         ---------TIENDAS MÁS----------                                              ║");
            Console.WriteLine("║                                             Menú de Facturación                                                     ║");
            Console.WriteLine("║     Nombre:                                                 NIT:                                                    ║");
            Console.WriteLine("║     Correo Eléctrónico:                                                                                             ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║          ┌─────────────┬───────────────────────────────┬──────────────┬───────────────────────────────┐             ║");
            Console.WriteLine("║          │ Código      │  Descripción / Precio         │  Cantidad    │ Total (producto)              │             ║");
            Console.WriteLine("║          ├─────────────┼───────────────────────────────┤──────────────┤───────────────────────────────┤             ║"); 
            Console.WriteLine("║          │             │                               │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │             │                               │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │             │                               │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │             │                               │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │             │                               │              │                               │             ║");
            Console.WriteLine("║          └─────────────┴───────────────────────────────├──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║                                                        │   Total      │                               │             ║");
            Console.WriteLine("║                                                        └──────────────┴───────────────────────────────┘             ║");
            Console.WriteLine("║                              Ingrese el número de la opción a la que desea ingresar:                                ║");
            Console.WriteLine("║                                                      ____________                                                   ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(87, 2);
            Console.WriteLine(fecha);
        opcion_facturacion:

            Console.SetCursorPosition(61, 26);
            try
            {
                opcion_menu1 = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(45, 27);
                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                goto opcion_facturacion; 
            }

                opcion_menu1.ToString();  
            if (opcion_menu1!='i'&& opcion_menu1 != 'I'&& opcion_menu1 != 'm' && opcion_menu1 != 'M' && opcion_menu1 != 'f' && opcion_menu1 != 'F' && opcion_menu1 != 'p' && opcion_menu1 != 'P')
            {
                Console.SetCursorPosition(45, 27);
                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                goto opcion_facturacion;
            }
            ingreso:
            if (opcion_menu1 == 'i'|| opcion_menu1 == 'I')
            {
                Console.SetCursorPosition(13, 6);
                nombre=Convert.ToString(Console.ReadLine());
                if (nombre == "f" || nombre == "F") { goto opcion_facturacion; }
            ingreso_nit:
                Console.SetCursorPosition(67, 6);
                try
                {
                    NIT=int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.SetCursorPosition(45, 27);
                    Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                    goto ingreso_nit;
                }
               

                if (NIT < 100000000 || NIT > 999999999)
                {
                    Console.SetCursorPosition(45, 27);
                    Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                    goto ingreso_nit;
                }
                Console.SetCursorPosition(25, 7);
                correo=Convert.ToString(Console.ReadLine());
                if (correo == "f" || correo== "F") { goto opcion_facturacion; }
                Console.SetCursorPosition(13, 13);
                //21
                int x = 13, y = 13;
                
                while (codigo != "n" || codigo != "N" ) 
                {
                    
                    if(y>13)
                    { 
                    Console.SetCursorPosition(45, 27);
                    Console.WriteLine("       ¿Desea agregar otro producto? S/N      ");
                    ingreso_sn:
                        Console.SetCursorPosition(x, y);
                        try
                        {
                            sn = Convert.ToChar(Console.ReadLine());
                        }
                        catch
                        {
                            Console.SetCursorPosition(45, 27);
                            Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                            goto ingreso_sn;
                        }
                        if (sn != 's' && sn != 'S' && sn != 'n' && sn != 'N')
                        {
                            Console.SetCursorPosition(45, 27);
                            Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                            goto ingreso_sn;
                        }
                        if (sn == 's' || sn == 'S') { goto ingreso_productos; }
                        else { break; }
                    }
                    
                ingreso_productos:
                    Console.SetCursorPosition(x, y);
                    codigo =Convert.ToString(Console.ReadLine());
                    if (codigo != "001" && codigo != "002" && codigo != "003" && codigo != "004" && codigo != "005" &&  codigo != "n" && codigo != "N" )
                    {
                        Console.SetCursorPosition(45, 27);
                        Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                        Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                        goto ingreso_productos;
                    }
                    switch (codigo) 
                    {
                        case"n":
                            break; 
                        case"N":
                            break;
                        case "001":
                            Console.SetCursorPosition(x +14, y );
                            Console.WriteLine("Libra de azúcar Q.10.80");
                            leer_cantidad:
                            Console.SetCursorPosition(x + 46, y);
                            try
                            {
                                cant_p1=int.Parse(Console.ReadLine());
                            }
                            catch 
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad;
                            }
                            if(cant_p1<= 0)
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad;
                            }

                            ac1 = ac1+cant_p1 * precio_azucar;
                            Console.SetCursorPosition(x + 61, y);
                            Console.WriteLine("Q."+Math.Round(cant_p1*precio_azucar,2));

                            break;
                        case "002":
                            Console.SetCursorPosition(x + 14, y);
                            Console.WriteLine("Libra de arroz Q.3.80");
                        leer_cantidad2:
                            Console.SetCursorPosition(x + 46, y);
                            try
                            {
                                cant_p2 = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad2;
                            }
                            if (cant_p2 <= 0)
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad2;
                            }

                            ac2 = ac2 + cant_p2 * precioArroz;
                            Console.SetCursorPosition(x + 61, y);
                            Console.WriteLine("Q." + Math.Round(cant_p2*precioArroz, 2));

                            break;
                        case "003":
                            Console.SetCursorPosition(x + 14, y);
                            Console.WriteLine("Galleta GAMA Q.1.10");
                        leer_cantidad3:
                            Console.SetCursorPosition(x + 46, y);
                            try
                            {
                                cant_p3 = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad3;
                            }
                            if (cant_p3 <= 0)
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad3;
                            }

                            ac3 = ac3 + cant_p3 * preciogalleta;
                            Console.SetCursorPosition(x + 61, y);
                            Console.WriteLine("Q." + Math.Round(cant_p3*preciogalleta, 2));


                            break;
                        case "004":
                            Console.SetCursorPosition(x + 14, y);
                            Console.WriteLine("Coca Cola Q.17.00");
                        leer_cantidad4:
                            Console.SetCursorPosition(x + 46, y);
                            try
                            {
                                cant_p4 = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad4;
                            }
                            if (cant_p4 <= 0)
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad4;
                            }

                            ac4 = ac4 + cant_p4 * preciococa;
                            Console.SetCursorPosition(x + 61, y);
                            Console.WriteLine("Q." + Math.Round(cant_p4*preciococa, 2));

                            break;
                        case "005":
                            Console.SetCursorPosition(x + 14, y);
                            Console.WriteLine("Libra de café Q.50.00");
                        leer_cantidad5:
                            Console.SetCursorPosition(x + 46, y);
                            try
                            {
                                cant_p5 = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad5;
                            }
                            if (cant_p5 <= 0)
                            {
                                Console.SetCursorPosition(45, 27);
                                Console.WriteLine("Ese dato no es válido. Por favor reingrese.");
                                goto leer_cantidad5;
                            }

                            ac5 = ac5 + cant_p5 * preciocafe;
                            Console.SetCursorPosition(x + 61, y);
                            Console.WriteLine("Q." + Math.Round(cant_p5*preciocafe, 2));


                            break;
                    }
                   y = y + 2;
                    

                    if (codigo == "n"|| codigo == "N")
                    {
                        break;
                    }
                    if (y > 21)
                    {
                        break;
                    }

                }
                total_factura=ac1+ac2+ac3+ac4+ac5;
                Console.SetCursorPosition(74, 23);
                Console.WriteLine("Q." + Math.Round(total_factura, 2));
                goto opcion_facturacion; 



            }
            if (opcion_menu1 == 'p' || opcion_menu1 == 'P')
            {
                puntos = 0;
                
                Console.SetCursorPosition(25, 27);
                Console.WriteLine("Ingrese su forma de pago: 1. Tarjeta de crédito/debito 2. Efectivo");
                Console.SetCursorPosition(61, 26);
            opcion_pago:
                try
                {
                    forma_pago = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.SetCursorPosition(50, 24); Console.WriteLine("Debe ingresar un número");
                    goto opcion_pago;
                }

                if (forma_pago > 2 || forma_pago < 1)
                {
                    Console.SetCursorPosition(55, 24); Console.WriteLine("Opción inválida");
                    goto opcion_pago;
                }

                if (forma_pago == 1)
                {
                    if (total_factura >= 10 && total_factura <= 50)
                    {
                        puntos = total_factura /10;
                    }
                    if (total_factura > 50 && total_factura <= 100)
                    {
                        puntos = 2;
                    }
                    if (total_factura > 100)
                    {
                        puntos = 3; 
                    }
                }
                else
                {
                    if (total_factura>100) 
                    {
                        puntos = 3; 
                    }
                }


                Console.SetCursorPosition(25, 27);
                Console.WriteLine("Total de puntos ganados: "+ Math.Truncate(puntos)+". Click en cualquier letra para volver al menú.");
                totalp1 = totalp1 + cant_p1;
                totalp2=totalp2 + cant_p2;
                totalp3= totalp3 + cant_p3;
                totalp4 = totalp4 + cant_p4;
                totalp5= totalp5 + cant_p5;
                dinerototal = total_factura + dinerototal;
                total_facturas = ++total_facturas;
                puntos_totales=puntos_totales+puntos;

                Console.ReadKey();
                goto menu_principal; 
            }
            if (opcion_menu1 == 'm' || opcion_menu1 == 'M') { goto menu_principal; }

            opcion_2:
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                         ---------TIENDAS MÁS----------                                              ║");
            Console.WriteLine("║                                                    Registros                                                        ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║   Facturas realizadas:                                                                                              ║");
            Console.WriteLine("║   Puntos:                                                                                                           ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║          ┌─────────────┬───────────────────────────────┬──────────────┬───────────────────────────────┐             ║");
            Console.WriteLine("║          │ Código      │ Precio unitario y descripción │  Cantidad    │ Total (producto)              │             ║");
            Console.WriteLine("║          ├─────────────┼───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │  001        │ Libra de azúcar    Q.10.80    │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │  002        │ Libra de Arroz     Q.3.80     │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │  003        │ Galleta GAMA       Q.1.10     │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │  004        │ Coca Cola          Q.17.00    │              │                               │             ║");
            Console.WriteLine("║          ├─────────────┤───────────────────────────────┤──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║          │  005        │ Libra de Café      Q.50.00    │              │                               │             ║");
            Console.WriteLine("║          └─────────────┴───────────────────────────────├──────────────┤───────────────────────────────┤             ║");
            Console.WriteLine("║                                                        │   Total      │                               │             ║");
            Console.WriteLine("║                                                        └──────────────┴───────────────────────────────┘             ║");
            Console.WriteLine("║                                      Click en cualquier tecla para volver al menú.                                  ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            dinero_totalp1 = totalp1 * precio_azucar;
            dinero_totalp2= totalp2 * precioArroz;
            dinero_totalp3 = totalp3 * preciogalleta;
            dinero_totalp4 = totalp4 * preciococa;
            dinero_totalp5 = totalp5 * preciocafe;
            Console.SetCursorPosition(13, 8);
            Console.WriteLine(Math.Truncate(puntos_totales));
            Console.SetCursorPosition(25, 7);
            Console.WriteLine(total_facturas);
            Console.SetCursorPosition(58, 13);
            Console.WriteLine(totalp1);
            Console.SetCursorPosition(73, 13);
            Console.WriteLine("Q."+Math.Round(dinero_totalp1,2));
            Console.SetCursorPosition(58, 15);
            Console.WriteLine(totalp2);
            Console.SetCursorPosition(73, 15);
            Console.WriteLine("Q." + Math.Round(dinero_totalp2, 2));
            Console.SetCursorPosition(58, 17);
            Console.WriteLine(totalp3);
            Console.SetCursorPosition(73, 17);
            Console.WriteLine("Q." + Math.Round(dinero_totalp3, 2));
            Console.SetCursorPosition(58, 19);
            Console.WriteLine(totalp4);
            Console.SetCursorPosition(73, 19);
            Console.WriteLine("Q." + Math.Round(dinero_totalp4, 2));
            Console.SetCursorPosition(58, 21);
            Console.WriteLine(totalp5);
            Console.SetCursorPosition(73, 21);
            Console.WriteLine("Q." + Math.Round(dinero_totalp5, 2));
            Console.SetCursorPosition(73, 23);
            Console.WriteLine("Q." + Math.Round(dinerototal, 2));
            Console.ReadKey();
            goto menu_principal;
        }
}
}