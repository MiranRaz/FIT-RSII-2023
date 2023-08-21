using eProdaja.Model;
using System;

namespace eProdaja.Interfaces.IProizvodiService
{
    public interface IProizvodiService
    {
        IList<Proizvodi> Get();
    }
}

