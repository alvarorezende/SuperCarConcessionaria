using SuperCar.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperCar.Business.Interfaces
{
	public interface IVeiculoRepository : IRepository<Veiculo>
	{
		Task<Veiculo> ObterVeiculoPorPlaca(string placa);

		Task<IEnumerable<Veiculo>> ObterVeiculosPorMarca(Guid marcaId);

		Task<IEnumerable<Veiculo>> ObterVeiculosPorCambio(Guid cambioId);
	}
}
