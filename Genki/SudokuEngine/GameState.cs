using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genki.SudokuEngine
{
	[Serializable]
	public enum GameState
	{
		[XmlEnum(Name = "0")]
		COMPUTING = 0,
		[XmlEnum(Name = "1")]
		PLAYING = 1,
		[XmlEnum(Name = "2")]
		PAUSE = 2,
		[XmlEnum(Name = "3")]
		WIN = 3
	}
}
