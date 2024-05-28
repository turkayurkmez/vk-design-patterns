// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Dependency Inversion:
 * Büyük nesne küçüğe değil küçük nesne büyüğe "bağlı" olmalı.
 */
Report report = new Report(new TelegramSender());