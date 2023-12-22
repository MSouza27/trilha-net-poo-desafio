using System.ComponentModel;
using DesafioPOO.Models;

        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia(numero: "9999", modelo: "3310", imei: "123456789", memoria: 128);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone(numero: "9999", modelo: "3310", imei: "123456789", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Google");

