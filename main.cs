using System;
using System.Collections.Generic;

namespace ParkingLot{
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Bem-vindo ao Estacionamento!");
            System.Console.WriteLine("Digite o valor do pagamento inicial:");
            int initialPayment = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor cobrado pelas horas: ");
            int hourlyPayment = int.Parse(Console.ReadLine());
            Console.Clear();

            List<string> inTheParkingLot = new List<string>();
            bool chooseOption = false;

            while (!chooseOption){
                Console.WriteLine("Selecione a ação desejada: ");
                Console.WriteLine("1 - Cadastrar veículo; 2 - Remover veículo; 3 - Listar veículos; 4 - Encerrar");
                string choice = Console.ReadLine();
            
                switch (choice){
                    case "1":{
                        Console.WriteLine("Digite a placa do veículo: ");
                        string plate = Console.ReadLine();
                        inTheParkingLot.Add(plate);
                        Console.Clear();
                        break;
                    }
                    case "2":{
                        if(inTheParkingLot.Count > 0) {
                            double valueParking = 0;
                            Console.WriteLine("Digite a placa: ");
                            string plate = Console.ReadLine();
                            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                            int hoursParked = int.Parse(Console.ReadLine());

                            for(int i = 0; i < inTheParkingLot.Count; i++) {
                                if (inTheParkingLot[i] == plate) {
                                    valueParking = [(hoursParked-1) * hourlyPayment] + initialPayment;
                                    Console.WriteLine($"O veículo {inTheParkingLot[i]} foi removido e o preço total foi: {valueParking}");
                                    inTheParkingLot.RemoveAt(i);
                                }
                            }
                        }
                        Console.Clear();
                        break;
                    }
                    case "3":{
                        foreach(string car in inTheParkingLot) {
                            System.Console.WriteLine(car);
                        }
                        Console.Clear();
                        break;
                    }
                    case "4":{
                        chooseOption = true;
                        Console.Clear();
                        break;
                    }
                }
            }
            Console.WriteLine("Fim.");
        }
    }
}