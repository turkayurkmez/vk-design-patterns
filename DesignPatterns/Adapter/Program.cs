// See https://aka.ms/new-console-template for more information
using Adapter;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
/*
 * Uygulamanızda bir kaynaktan gelen belirli bir formatta veriye ihtiyacınız var. Fakat kaynağın ürettiği veri formatı ihtiyacınız olandan farklı. 
 */

XMLSource source = new XMLSource();
JsonAdapter jsonAdapter = new JsonAdapter(source);
jsonAdapter.GetProducts();

SqlDataAdapter adapter = new SqlDataAdapter("", ""); //db'deki veriyi -> uygulamada dataTable nesnesine dönüştür.
DataTable dataTable = new DataTable();
adapter.Fill(dataTable);
