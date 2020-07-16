using System;
using System.ComponentModel.DataAnnotations;

namespace SuperCar.Business.Models
{
	public class Veiculo
	{
		public Guid VeiculoId { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(7, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 7)]
		public string Placa { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
		public string Modelo { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int Ano { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int AnoModelo { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int KmRodado { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int QtdPortas { get; set; }

		public string ObsVeiculo { get; set; }

		/* EF Relations*/

		public Marca Marca { get; set; }

		public Cambio Cambio { get; set; }

		public Combustivel Combustivel { get; set; }

		public Cor Cor { get; set; }

	}
}
