// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilty;

Console.WriteLine("Hello, World!");
/*
 * Chain of Responsibilty - Sorumluluk Zinciri.
 *  Bir talebi gerçekleştirmek için; koşullara göre talebi işleyen bir yapıya ihtiyacınız var. Bu ihtiyacı nesneler arasında nasıl giderirsiniz?
 *  
 *  Bir talebi aldıktan sonra ya işleyen ya da bir sonraki halkadan devam eden bir zincir oluşturmalısınız.
 */

Reservation reservation = new Reservation { Owner = "Türkay", CheckIn = new DateOnly(2024, 5, 30), CheckOut = new DateOnly(2024, 6, 5), Country = "Türkiye" };

CheckOwnerHandler checkOwnerHandler = new CheckOwnerHandler();
CheckInAndOutHandler checkInAndOutHandler = new CheckInAndOutHandler();
CheckCountryItalyHandler checkCountryItaly = new CheckCountryItalyHandler ();
CheckCountryFranceHandler checkCountryFrance = new CheckCountryFranceHandler ();
CheckCountryTurkiyeHandler checkCountryTurkiyeHandler = new CheckCountryTurkiyeHandler ();

checkOwnerHandler.Next = checkInAndOutHandler;
checkInAndOutHandler.Next = checkCountryItaly;
checkCountryItaly.Next = checkCountryFrance;
checkCountryFrance.Next = checkCountryTurkiyeHandler;

checkOwnerHandler.Handler(reservation);

