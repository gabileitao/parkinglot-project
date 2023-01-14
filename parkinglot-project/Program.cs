using System;
using System.Collections.Generic;

namespace parkinglot_project {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bem-vindo ao Estacionamento!");
            Console.WriteLine("Digite o valor do pagamento inicial:");
            decimal initialPayment = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor cobrado pelas horas: ");
            decimal hourlyPayment = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            List<string> inTheParkingLot = new List<string>();
            bool chooseOption = false;

            while (!chooseOption) {
                Console.WriteLine("Selecione a ação desejada: ");
                Console.WriteLine("1 - Cadastrar veículo; 2 - Remover veículo; 3 - Listar veículos; 4 - Encerrar");
                string choice = Console.ReadLine();

                switch (choice) {
                    case "1": {
                        Console.WriteLine("Digite a placa do veículo: ");
                        string plate = Console.ReadLine();
                        inTheParkingLot.Add(plate);
                        Console.Clear();
                        break;
                    }
                    case "2": {
                        if (inTheParkingLot.Count > 0) {
                            decimal valueParking;
                            Console.WriteLine("Digite a placa: ");
                            string plate = Console.ReadLine();
                            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                            int hoursParked = int.Parse(Console.ReadLine());

                            for (int i = 0; i < inTheParkingLot.Count; i++) {
                                if (inTheParkingLot[i] == plate) {
                                    valueParking = ((hoursParked - 1) * hourlyPayment) + initialPayment;
                                    Console.WriteLine($"O veículo {inTheParkingLot[i]} foi removido e o preço total foi: {valueParking}");
                                    inTheParkingLot.RemoveAt(i);
                                }
                            }
                        }
                        break;
                    }
                    case "3": {
                        foreach (string car in inTheParkingLot) {
                            System.Console.WriteLine(car);
                        }
                        break;
                    }
                    case "4": {
                        chooseOption = true;
                        Console.Clear();
                        break;
                    }
                    default: {
                        Console.WriteLine("Opção inválida");
                        break;
                    }
                }
            }
            Console.WriteLine("Fim.");
        }
    }
}
