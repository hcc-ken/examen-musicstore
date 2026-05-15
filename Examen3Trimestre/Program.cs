using MySql.Data.MySqlClient;

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

	public string getArtista()
	{
		return artista;
	}

	public int getAnyo()
	{
		return anyo;
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
		List<Album> albums = new List<Album>();
		albums.Add(new Album("Back in Black", "AC/DC", 1980, true));
		albums.Add(new Album("The Dark Side of the Moon", "Pink Floyd", 1973, true));
		albums.Add(new Album("Thriller", "Michael Jackson", 1982, false));

		foreach (Album album in albums)
		{
			Console.WriteLine(album.toString());

			if (album.getArtista().Contains("Metallica"))
			{
				Console.WriteLine("El álbum de Metallica está disponible");
			}
		}

		Console.WriteLine(DateTime.Now.ToShortTimeString());

		static void GuardarAlbumes(List<Album> albums)
		{
			using (StreamWriter writer = new StreamWriter(@"C:\Users\Alumno1\source\repos\Examen3Trimestre\Examen3Trimestre\Album.txt"))
			{
				foreach (Album album in albums)
				{
					writer.WriteLine(album.getTitulo());
				}
			}
			Console.WriteLine("Fichero guardado correctamente.");
		}
		GuardarAlbumes(albums);
	}
	public class GestorBD
	{
		private MySqlConnection conexion;

		public GestorBD()
		{
			MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
			builder.Server = "localhost";
			builder.UserID = "root";
			builder.Password = "";
			builder.Database = "musicstore";

			conexion = new MySqlConnection(builder.ConnectionString);
		}
		public void InsertarAlbum(Album a)
		{

			string sql = "INSERT INTO album (titulo, artista, anio, disponible)";
			MySqlCommand cmd = new MySqlCommand(sql, conexion);

		}
	}
}