﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo
{
	public abstract class Policko
	{
		public abstract void PolozFigurku(Figurka figurka);

		public abstract bool JeObsazeno();

		public abstract bool JeTamFigurka(Figurka figurka);

		public abstract Figurka DejFigurkuKVyhozeni();

		public abstract void ZvedniFigurku(Figurka figurka, string nickname);

		public abstract void Vypis();
	}
}
