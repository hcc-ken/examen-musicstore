public class Album
{
	string titulo;
	string artista;
	int anyo;
	bool disponible;

	public Album(string titulo, string artista, int anyo, bool disponible)
	{
		this.titulo = titulo;
		this.artista = artista;
		this.anyo = anyo;
		this.disponible = disponible;
	}

	public string getTitulo()
	{
		return titulo;
	}

	public void setTitulo(string titulo)
	{
		this.titulo = titulo;
	}

	public string getArtista()
	{
		return artista;
	}

	public void setArtista(string artista)
	{
		this.artista = artista;
	}

	public int getAnyo()
	{
		return anyo;
	}

	public void setAnyo(int anyo)
	{
		this.anyo = anyo;
	}

	public bool isDisponible()
	{
		return disponible;
	}

	public string toString()
	{
		return $"Título: {titulo} - Artista: {artista} {anyo}";
	}
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
	}
}