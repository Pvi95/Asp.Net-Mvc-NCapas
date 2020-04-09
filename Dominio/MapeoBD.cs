using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using bd = Datos;
using ent = Entidades;

namespace Dominio
{
    public class MapeoBD : Profile
    {
        public override string ProfileName 
        {
            get 
            {
                return "MapeoBD";
            }
        }

        public MapeoBD() 
        {
            //BD hacia Entidades
            CreateMap<bd.CLIENTES, ent.ClientesE>();
            //Entidades hacia BD
            CreateMap<ent.ClientesE, bd.CLIENTES>();
        }
    }
}
