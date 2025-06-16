using System;

public class Angajat
{
	private string nume;
	private decimal salariu;
	public string departament;

	public Angajat(string nume, decimal salariu, string departament)
	{
		this.nume = nume;
		this.salariu = salariu;
		this.departament = departament;
	}

	public void AfisareDetalii()
	{
		Console.WriteLine("Nume:" + nume);
		Console.WriteLine($"Salariu: {salariu} lei");
		Console.WriteLine("Departament:" + departament);
	}
}
