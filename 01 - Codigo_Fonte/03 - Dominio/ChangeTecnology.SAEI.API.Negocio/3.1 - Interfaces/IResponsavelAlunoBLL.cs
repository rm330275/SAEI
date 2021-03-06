﻿using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public interface IResponsavelAlunoBLL
    {
        List<ResponsavelAluno> Get();
        ResponsavelAluno Get(int id);
        bool Post(ResponsavelAluno obj);
        bool Put(int id, ResponsavelAluno obj);
        bool Delete(int id);
    }
}
