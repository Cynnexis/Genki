using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using SerializerManager;
using Genki.SudokuEngine.GridEngine;
using System.Diagnostics;
using Genki.SudokuEngine;

namespace Genki
{
	public class Saver
	{
		private static SerializerSettings<Game> settings = new SerializerSettings<Game>(GetAppDataFile(), EWriteType.BINARY);
		private static Serializer<Game> serializer = new Serializer<Game>(settings);

		public static void Save(Game g)
		{
			try
			{
				serializer.Save(g);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.StackTrace);
			}
		}

		public static Game Load()
		{
			Game game = null;
			try
			{
				List<Game> list = serializer.LoadList();

				if (list != null && list.Count >= 1)
					game = list[0];
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.StackTrace);
			}

			return game;
		}

		public static void InitAppData()
		{
			string path = GetAppDataDir();
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
		}

		public static string GetAppDataDir()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Genki");
		}

		public static string GetAppDataFile()
		{
			InitAppData();
			return Path.Combine(GetAppDataDir(), "sudokugrid.bin");
		}
	}
}
