// See https://aka.ms/new-console-template for more information
using OpenClosedPrinciple;

Console.WriteLine("Hello, World!");
/*
 *  OCP:
 *  Bir nesne .........Gelişime......... AÇIK .........Değişime....... KAPALI olmalıdır.
 *    
 *    --Yeni Özellik eklemek....
 *   Varolan ve çalışan bir uygulamaya yeni bir özellik eklemek istediğinizde eski nesnelere müdahale etmeniz gerekiyorsa, prensibi ihlal ediyorsunuz demektir.
 */

BookingDetails bookingDetails = new BookingDetails() { Owner="Türkay", CountryInfo= new Italy(), CheckInDate=DateTime.Now};
BookingManagement bookingManagement = new BookingManagement() {  BookingDetails = bookingDetails};
bookingManagement.CreateBookingOnDb();