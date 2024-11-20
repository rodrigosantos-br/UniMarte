namespace UniMarte.Web.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class IdadeValidaAttribute : ValidationAttribute
    {
        private readonly int _idadeMinima;
        private readonly int _idadeMaxima;

        public IdadeValidaAttribute(int idadeMinima, int idadeMaxima)
        {
            _idadeMinima = idadeMinima;
            _idadeMaxima = idadeMaxima;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dataNascimento)
            {
                var idade = DateTime.Now.Year - dataNascimento.Year;

                // Ajusta a idade se o aniversário ainda não ocorreu neste ano
                if (dataNascimento > DateTime.Now.AddYears(-idade))
                    idade--;

                if (idade < _idadeMinima || idade > _idadeMaxima)
                {
                    return new ValidationResult($"A idade deve estar entre {_idadeMinima} e {_idadeMaxima} anos.");
                }

                return ValidationResult.Success;
            }

            return new ValidationResult("Data de nascimento inválida.");
        }
    }

}
