using System;
using System.ComponentModel.DataAnnotations;

namespace SuperCar.Business.Models
{
	public class Veiculo
	{
		public Guid VeiculoId { get; set; }

		public string Placa { get; set; }

		public string Modelo { get; set; }

		public int Ano { get; set; }

		public int AnoModelo { get; set; }

		public int KmRodado { get; set; }

		public int QtdPortas { get; set; }

		public string ObsVeiculo { get; set; }

		/* EF Relations*/

		public Marca Marca { get; set; }

		public Cambio Cambio { get; set; }

		public Combustivel Combustivel { get; set; }

		public Cor Cor { get; set; }

	}
}
