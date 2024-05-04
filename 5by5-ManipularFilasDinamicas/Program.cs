using _5by5_ManipularFilasDinamicas;
int opc, opc_queue;
void Menu()
{
    Console.Clear();
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("[1] - INSERT IN QUEUE"); //Ready
    Console.WriteLine("[2] - PRINT QUEUE"); //Ready
    Console.WriteLine("[3] - CHECK EQUAL SIZE "); //Ready
    Console.WriteLine("[4] - LARGEST SMALLEST AND ARITHMETIC AVERAGE ");
    Console.WriteLine("[5] - TRANSFER TO AUXILIAR QUEUE ");
    Console.WriteLine("[6] - RETURN QUANTITY AND ELEMENTS IMPARES ");
    Console.WriteLine("[7] - EXIT PROGRAM ");
}
QueueInteger queue1 = new();
QueueInteger queue2 = new();

do
{
    Menu();
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            do
            {
                Console.WriteLine("Chose which QUEUE you want to manipulate 1 or 2: ");
                opc_queue = int.Parse(Console.ReadLine());
                if (opc != 1 && opc != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_queue)
                    {
                        case 1:
                            Console.WriteLine("Write the number to insert into QUEUE: ");
                            queue1.Push(new(int.Parse(Console.ReadLine())));
                            break;
                        case 2:
                            Console.WriteLine("Write the number to insert into QUEUE: ");
                            queue2.Push(new(int.Parse(Console.ReadLine())));
                            break;
                    }
                }
            } while (opc_queue != 1 && opc_queue != 2);
            break;
        case 2:
            do
            {
                Console.WriteLine("Chose which QUEUE you want print 1 or 2: ");
                opc_queue = int.Parse(Console.ReadLine());
                if (opc != 1 && opc != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_queue)
                    {
                        case 1:
                            Console.WriteLine("===== QUEUE 1 ===== ");
                            queue1.Print();
                            break;
                        case 2:
                            Console.WriteLine("===== QUEUE 2 ===== ");
                            queue2.Print();
                            break;
                    }
                }
            } while (opc_queue != 1 && opc_queue != 2);
            break;
        case 3:
            queue1.CheckEqualSize(queue1, queue2);
            break;
        case 4:
            do
            {
                Console.WriteLine("Chose which QUEUE you want check biggest,smallest and arithmetic 1 or 2: ");
                opc_queue = int.Parse(Console.ReadLine());
                if (opc_queue != 1 && opc_queue != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_queue)
                    {
                        case 1:
                            Console.WriteLine("===== QUEUE 1 ===== ");
                            queue1.BiggestSmallestArithmetic();
                            break;
                        case 2:
                            Console.WriteLine("===== QUEUE 2 ===== ");
                            queue2.BiggestSmallestArithmetic();
                            break;
                    }
                }
            } while (opc_queue != 1 && opc_queue != 2);
            break;
        case 5:
            do
            {
                Console.WriteLine("Chose which QUEUE you want copy to auxiliar: ");
                opc_queue = int.Parse(Console.ReadLine());
                if (opc_queue != 1 && opc_queue != 2)
                {
                    Console.WriteLine("Write a valid value: ");
                }
                else
                {
                    QueueInteger queue_aux = new();
                    switch (opc_queue)
                    {

                        case 1:
                            Console.WriteLine("===== QUEUE 1 ===== ");
                            queue1.Print();
                            Console.WriteLine("===== QUEUE AUXILIAR =====");
                            queue1.TransferQueue(queue_aux);
                            break;
                        case 2:
                            Console.WriteLine("===== QUEUE 2 ===== ");
                            queue2.Print();
                            Console.WriteLine("===== QUEUE AUXILIAR =====");
                            queue2.TransferQueue(queue_aux);
                            break;
                    }
                }
            } while (opc_queue != 1 && opc_queue != 2);

            break;
        case 6:
            do
            {
                Console.WriteLine("Chose which QUEUE you want check impairs and pairs 1 or 2:  ");
                opc_queue = int.Parse(Console.ReadLine());
                if (opc_queue != 1 && opc_queue != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_queue)
                    {
                        case 1:
                            queue1.CheckPairsAndImpairs();
                            break;
                        case 2:
                            queue2.CheckPairsAndImpairs();
                            break;
                    }
                }
            } while (opc_queue != 1 && opc_queue != 2);
            break;
        default:
            break;

    }
    Console.WriteLine("Press ENTER to continue");
    Console.ReadKey();

} while (opc != 7);


