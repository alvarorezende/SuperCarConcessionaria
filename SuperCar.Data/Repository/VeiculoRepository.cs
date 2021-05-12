using Microsoft.EntityFrameworkCore;
using SuperCar.Business.Interfaces;
using SuperCar.Business.Models;
using SuperCar.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCar.Data.Repository
{
	public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
	{
		public VeiculoRepository(MeuDbContext contexto) : base(contexto) { }

		public async Task<Veiculo> ObterVeiculoPorPlaca(string placa)
		{
			return await Db.Veiculos.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Placa == placa);
		}

		public async Task<IEnumerable<Veiculo>> ObterVeiculosPorCambio(Guid cambioId)
		{
			return await Db.Veiculos.AsNoTracking()
				.Include(x => x.Cambio).OrderBy(x => x.Modelo).ToListAsync();
		}

		public async Task<IEnumerable<Veiculo>> ObterVeiculosPorMarca(Guid marcaId)
		{
			return await Db.Veiculos.AsNoTracking()
				.Include(x => x.Marca).OrderBy(x => x.Modelo).ToListAsync();
		}
	}
}
