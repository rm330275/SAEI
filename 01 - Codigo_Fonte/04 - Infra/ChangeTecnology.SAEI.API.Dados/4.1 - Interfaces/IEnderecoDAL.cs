﻿using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Dados
{
    public interface IEnderecoDAL
    {
        List<Endereco> Get();
        Endereco Get(int id);
        bool Post(Endereco obj);
        bool Put(int id, Endereco obj);
        bool Delete(int id);
    }
}
