using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd = Datos;
using ent = Entidades;
using Repositorio;
using System.Linq.Expressions;

namespace Dominio
{
    public class ClientesD
    {
        private Repositorio<bd.CLIENTES> _repositorio = new Repositorio<bd.CLIENTES>(new bd.MVC_ASPNET_TUTORIALEntitiesConnection());

        public IEnumerable<ent.ClientesE> ClientesList()
        {
            var _consultaBd = _repositorio.TraerTodo();
            var _clientes = AutoMapper.Mapper.Map<IEnumerable<bd.CLIENTES>, IEnumerable<ent.ClientesE>>(_consultaBd);
            return _clientes;
        }

        public ent.ClientesE ClientesPorID(int id)
        {
            var _consultaBd = _repositorio.TraerUnoPorID(id);
            var _clientes = AutoMapper.Mapper.Map<bd.CLIENTES, ent.ClientesE>(_consultaBd);
            return _clientes;
        }

        public void CrearCliente(ent.ClientesE _ClienteCrear)
        {
            var _adicionarCliente = AutoMapper.Mapper.Map<ent.ClientesE, bd.CLIENTES>(_ClienteCrear);
            _repositorio.Adicionar(_adicionarCliente);
            _repositorio.Grabar();
        }
        public void ModificarCliente(ent.ClientesE _ClienteModificar)
        {
            var _modificarCliente = AutoMapper.Mapper.Map<ent.ClientesE, bd.CLIENTES>(_ClienteModificar);
            _repositorio.Modificar(_modificarCliente);
            _repositorio.Grabar();
        }
        public void EliminarCliente(ent.ClientesE _ClienteEliminar)
        {
            var _eliminarCliente = AutoMapper.Mapper.Map<ent.ClientesE, bd.CLIENTES>(_ClienteEliminar);
            _repositorio.Eliminar(_eliminarCliente);
            _repositorio.Grabar();
        }

        public IEnumerable<ent.ClientesE> BuscarClientes(Expression<Func<bd.CLIENTES, bool>> predicadoBusqueda)
        {
            var _consultaBd = _repositorio.Buscar(predicadoBusqueda);
            var _ClientesEncontrados = AutoMapper.Mapper.Map<IEnumerable<bd.CLIENTES>, IEnumerable<ent.ClientesE>>(_consultaBd);
            return _ClientesEncontrados;
        }
        public ent.ClientesE BuscarUnCliente(Expression<Func<bd.CLIENTES, bool>> predicadoBusqueda)
        {
            var _consultaBd = _repositorio.TraerUno(predicadoBusqueda);
            var _ClienteEncontrado = AutoMapper.Mapper.Map<bd.CLIENTES, ent.ClientesE>(_consultaBd);
            return _ClienteEncontrado;
        }
    }
}
