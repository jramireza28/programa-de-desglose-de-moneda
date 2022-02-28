using static System.Console;

// tarea_de_desglose_JairoRamirez

    static void desglose()//AGRUPA LOS CODIGOS HACIENDO UN SOLO CODIGO
    {
        int CANT, CANT200, CANT100, CANT50, CANT20, CANT10, CANT5, CANT1, CANT050, CANT025, CANT010, CANT05, CANT01;//declaracion de variables
        CANT200 = CANT100 = CANT50 = CANT20 = CANT10 = CANT5 = CANT1 = CANT050 = CANT025 = CANT010 = CANT05 = CANT01 = 0;
        double cambio;
        float valor;
        cambio = 7.75;


        Console.WriteLine("\n\t\tBienvenidos al programa de conversiones\n");//muestra las instrucciones al usuario
        Console.WriteLine("\t Escoja alguna de las siguientes opciones");
        Console.WriteLine("\t1. Conocer el tipo de Cambio");
        Console.WriteLine("\t2. Conversion de Dolar a Quetzal");
        Console.WriteLine("\t3. salir del programa");
        String opcion = Console.ReadLine();

        switch (opcion)//funcion de de menu switch
        {
            case "1"://primera opcion del switch
            Console.WriteLine("\tEl cambio de dolar en estos momentos esta a:\t" + "Q" + cambio + "\tquetzales");//mostrar a como esta el cambio del dolar en guatemala

            break;

        case "2"://segunda opcion del switch
            Console.WriteLine("\t ingrese la cantidad de dolares");
            CANT = Convert.ToInt32(Console.ReadLine());
            valor = ((float)(CANT * cambio));
            Console.WriteLine("\tLa cantidad ingresada en dolares es de\t" + "$." + CANT + ".00");
            Console.WriteLine("\t el cambio en quetzales seria de: \t" + "Q." + CANT * cambio);


            if ((valor >= 200))//codigo de desglose de monedas
            {
                CANT200 = ((int)valor / 200);
                valor = valor - (CANT200 * 200);

            }

            if ((valor >= 100))
            {
                CANT100 = ((int)valor / 100);
                valor = valor - (CANT100 * 100);

            }

            if ((valor >= 50))
            {
                CANT50 = ((int)valor / 50);
                valor = valor - (CANT50 * 50);

            }

            if ((valor >= 20))
            {
                CANT20 = ((int)valor / 20);
                valor = valor - (CANT20 * 20);

            }

            if ((valor >= 10))
            {
                CANT10 = ((int)valor / 10);
                valor = valor - (CANT10 * 10);

            }

            if ((valor >= 5))
            {
                CANT5 = ((int)valor / 5);
                valor = valor - (CANT5 * 5);

            }

            if ((valor >= 1))
            {
                CANT1 = ((int)valor / 1);
                valor = valor - (CANT1 * 1);

            }

            if ((valor >= 0.50))
            {
                CANT050 = ((int)(valor / 0.50));
                valor = valor - (float)(CANT050 * 0.50);


            }

            if ((valor >= 0.25))
            {
                CANT025 = ((int)(valor / 0.25));
                valor = (valor - (float)(CANT025 * 0.25));


            }

            if ((valor >= 0.10))
            {
                CANT010 = ((int)(valor / 0.10));
                valor = valor - (float)(CANT010 * 0.10);

            }

            if ((valor >= 0.05))
            {
                CANT05 = ((int)(valor / 0.05));
                valor = valor - (float)(CANT05 * 0.05);

            }

            if ((valor >= 0.01))
            {
                CANT01 = ((int)Math.Round(valor / 0.01));
                valor = valor - (float)(CANT01 * 0.01);

            }
            Console.WriteLine("\t A la hora de hacer el cambio, el dinero se entregaria de la siguiente manera:\t");
            Console.WriteLine($"\t\tBilletes de Q200:{CANT200}");
            Console.WriteLine($"\t\tBilletes de Q100:{CANT100}");
            Console.WriteLine($"\t\tBilletes de Q50:{CANT50}");
            Console.WriteLine($"\t\tBilletes de Q20:{CANT20}");
            Console.WriteLine($"\t\tBilletes de Q10:{CANT10}");
            Console.WriteLine($"\t\tBilletes de Q5:{CANT5}");
            Console.WriteLine($"\t\tBilletes de Q1:{CANT1}");
            Console.WriteLine($"\t\tMonedas de 50 centavos:{CANT050}");
            Console.WriteLine($"\t\tMonedas de 25 centavos:{CANT025}");
            Console.WriteLine($"\t\tMonedas de 10 centavos:{CANT010}");
            Console.WriteLine($"\t\tMonedas de 5 centavos:{CANT05}");
            Console.WriteLine($"\t\tMonedas de 1 centavo:{CANT01}");

            break;

        case "3"://tercera opcion del switch

        default:
            Console.WriteLine("GRACIAS POR SU TIEMPO FUE UN GUSTO AYUDARLE!");
            break;
    }




    }
desglose();



