using System;

namespace Patrones
{
	public interface IIteratorDenuncias
	{
		void primero();
		void siguiente();
		bool fin();
		IDenuncia actual();
	}
}
