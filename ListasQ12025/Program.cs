List<string> listaString=new List<string>();

listaString.Add("Naranja");
listaString.Add("5");
listaString.Add("Real España");
listaString.Add("Barcelona");
listaString.Add("Real Madrid");
listaString.Add("Alajuela");
listaString.Insert(3, "Real Madrid");
//listaString.Remove("Real Madrid");
listaString.RemoveAll(lista=> lista.Contains("Real Madrid"));

foreach (string item in listaString)
{
    Console.WriteLine(item);
}