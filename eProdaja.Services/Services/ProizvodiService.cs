﻿using System;
using eProdaja.Interfaces.IProizvodiService;
using eProdaja.Model;

namespace eProdaja.Services.Services
{
    public class ProizvodiService : IProizvodiService
    {
        List<Proizvodi> proizvodis = new List<Proizvodi>()
        {
            new Proizvodi()
            {
                ProizvodId = 1,
                Naziv = "Laptop",
            }
        };

        public IList<Proizvodi> Get()
        {
            return proizvodis;
        }
    }
}

